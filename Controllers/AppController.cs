using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using Assignment2_NHL_Players.Forms;
using Assignment2_NHL_Players.Models;
using Assignment2_NHL_Players.Services;
using Label = System.Windows.Forms.Label;

namespace Assignment2_NHL_Players.Controllers
{
    public class AppController
    {
        private List<PlayerStats> _players;
        private readonly PlayerService _playerService;
      
        public AppController(string filePath)
        {
            _playerService = new PlayerService();
            _players = _playerService.LoadPlayerStats(filePath);
            
        }

        public List<PlayerStats> GetFilteredAndSortedPlayers(string filter, string sort, Label filterErrorTxt, Label sortErrorTxt)
        {
            var query = _players.AsQueryable();

            // Apply filters
            if (!string.IsNullOrWhiteSpace(filter))
            {
                try
                {
                    var filterExpressions = filter.Split(',');
                    foreach (var expression in filterExpressions)
                    {
                        var parts = expression.Trim().Split(' ');
                        var field = parts[0];
                        var op = parts[1];
                        var value = parts[2];

                        query = query.Where(p => Compare(p, field, op, value, filterErrorTxt));
                    }
                }
                catch (Exception e)
                {
                    filterErrorTxt.Text = e.Message;
                }

            }

            // Apply sorting
            if (!string.IsNullOrWhiteSpace(sort))
            {
                try
                {
                    var sortExpressions = sort.Split(',');
                    foreach (var expression in sortExpressions)
                    {
                        var parts = expression.Trim().Split(' ');
                        var field = parts[0];
                        var direction = parts[1];

                        query = direction.ToLower() == "asc"
                            ? query.OrderBy(p => GetFieldValue(p, field, sortErrorTxt))
                            : query.OrderByDescending(p => GetFieldValue(p, field, sortErrorTxt));
                    }
                }
                catch (Exception e)
                {
                    sortErrorTxt.Text = e.Message;
                }

            }

            return query.ToList();
        }

        private bool Compare(PlayerStats p, string field, string op, string value, Label filterErrorTxt)
        {
            // Logic to dynamically compare player fields with a given value
            var playerValue = GetFieldValue(p, field, filterErrorTxt);
            var numericValue = double.Parse(value); // Handles both int and double

            return op switch
            {
                ">" => Convert.ToDouble(playerValue) > numericValue,
                ">=" => Convert.ToDouble(playerValue) >= numericValue,
                "<" => Convert.ToDouble(playerValue) < numericValue,
                "<=" => Convert.ToDouble(playerValue) <= numericValue,
                "==" => Convert.ToDouble(playerValue) == numericValue,
                _ => false
            };
        }

        private object GetFieldValue(PlayerStats p, string field, Label ErrorTxt)
        {
            try
            {
                var selectedField = typeof(PlayerStats).GetProperty(field);
                if (selectedField == null)
                {
                    ErrorTxt.Text = $"{field} field does not exist";
                    return null;
                } else
                {
                    var selectedValue = selectedField.GetValue(p);
                    return selectedValue;
                }
            } catch (Exception e)
            {
                ErrorTxt.Text = e.Message;
            }
            return null;

        }
    }
}
