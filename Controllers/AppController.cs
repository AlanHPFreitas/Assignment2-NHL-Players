using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Assignment2_NHL_Players.Models;
using Assignment2_NHL_Players.Services;

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

        public List<PlayerStats> GetFilteredAndSortedPlayers(string filter, string sort)
        {
            var query = _players.AsQueryable();

            // Apply filters
            if (!string.IsNullOrWhiteSpace(filter))
            {
                var filterExpressions = filter.Split(',');
                foreach (var expression in filterExpressions)
                {
                    var parts = expression.Trim().Split(' ');
                    var field = parts[0];
                    var op = parts[1];
                    var value = parts[2];

                    query = query.Where(p => Compare(p, field, op, value));
                }
            }

            // Apply sorting
            if (!string.IsNullOrWhiteSpace(sort))
            {
                var sortExpressions = sort.Split(',');
                foreach (var expression in sortExpressions)
                {
                    var parts = expression.Trim().Split(' ');
                    var field = parts[0];
                    var direction = parts[1];

                    query = direction.ToLower() == "asc"
                        ? query.OrderBy(p => GetFieldValue(p, field))
                        : query.OrderByDescending(p => GetFieldValue(p, field));
                }
            }

            return query.ToList();
        }

        private bool Compare(PlayerStats p, string field, string op, string value)
        {
            // Logic to dynamically compare player fields with a given value
            var playerValue = GetFieldValue(p, field);
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

        private object GetFieldValue(PlayerStats p, string field)
        {
            return typeof(PlayerStats).GetProperty(field)?.GetValue(p);

        }
    }
}
