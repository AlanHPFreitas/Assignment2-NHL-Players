using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Assignment2_NHL_Players.Models;


namespace Assignment2_NHL_Players.Services
{
    public class PlayerService
    {
        /// <summary>
        /// Load player statistics from a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file containing player stats.</param>
        /// <returns>A list of PlayerStats objects.</returns>
        public List<PlayerStats> LoadPlayerStats(string filePath)
        {
            // Initialize a list to hold player statistics
            var playerStats = new List<PlayerStats>();

            try
            {

                // Read all lines from the file, skipping the header row
                var lines = File.ReadAllLines(filePath).Skip(1);

                foreach (var line in lines)
                {
                    // Split each line by comma to get the individual fields
                    var fields = line.Split(',');

                    // Ensure that the correct number of fields are present
                    if (fields.Length < 21)
                    {
                        Console.WriteLine($"Linha inválida: {line}");
                        continue; // Skip this line and continue to the next
                    }
                    if (fields.Length > 21)
                    {
                        Console.WriteLine($"Linha inválida: {line}");
                        continue; // Skip this line and continue to the next
                    }
                    try
                    {
                        // Create a new PlayerStats object and populate its properties
                        var playerStat = new PlayerStats
                        {
                            Player = fields[0],
                            Team = fields[1],
                            Pos = fields[2],
                            GP = int.Parse(fields[3]),
                            G = int.Parse(fields[4]),
                            A = int.Parse(fields[5]),
                            P = int.Parse(fields[6]),
                            PlusMinus = int.Parse(fields[7]),
                            PIM = int.Parse(fields[8]),
                            PGP = double.Parse(fields[9]),
                            PPG = int.Parse(fields[10]),
                            PPP = int.Parse(fields[11]),
                            SHG = int.Parse(fields[12]),
                            SHP = int.Parse(fields[13]),
                            GWG = int.Parse(fields[14]),
                            OTG = int.Parse(fields[15]),
                            S = int.Parse(fields[16]),
                            SPercentage = double.Parse(fields[17]),
                            TOIGP = fields[18],
                            ShiftsGP = double.Parse(fields[19]),
                            FOWPercentage = double.Parse(fields[20])
                        };
                        // Add the created object to the list
                        playerStats.Add(playerStat);
                    }
                    catch (Exception e) 
                    { 
                    }

                   
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro ao converter dados: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }

            return playerStats;
        }
    }
}

