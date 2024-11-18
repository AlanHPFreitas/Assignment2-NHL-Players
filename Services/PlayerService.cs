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
            // Initialize a list to store player statistics
            var playerStats = new List<PlayerStats>();

            try
            {

                // Reads all the lines in the file, skipping the header line
                var lines = File.ReadAllLines(filePath).Skip(1);

                foreach (var line in lines)
                {
                    // Divide each line by a comma to get the individual fields
                    var fields = line.Split(',');

                    // Certifies that the correct number of fields is present
                    if (fields.Length < 21)
                    {
                        Console.WriteLine($"Invalid line: {line}");
                        continue; // Skip this line and go to the next one
                    } else if (fields.Length > 24)
                    {
                        Console.WriteLine($"Invalid line: {line}");
                        continue; // Skip this line and go to the next one
                    }
                    else if (fields.Length == 22)
                    {
                        try
                        {
                            var zero = 0.0;
                            // Create a new PlayerStats object and populate its properties
                            var playerStat = new PlayerStats
                            {
                                Player = fields[0],
                                Team = fields[1] + ", " + fields[2],
                                Pos = fields[3],
                                GP = int.Parse(fields[4]),
                                G = int.Parse(fields[5]),
                                A = int.Parse(fields[6]),
                                P = int.Parse(fields[7]),
                                PlusMinus = int.Parse(fields[8]),
                                PIM = int.Parse(fields[9]),
                                PGP = double.TryParse(fields[10], out zero) ? double.Parse(fields[10]) : 0.0,
                                PPG = int.Parse(fields[11]),
                                PPP = int.Parse(fields[12]),
                                SHG = int.Parse(fields[13]),
                                SHP = int.Parse(fields[14]),
                                GWG = int.Parse(fields[15]),
                                OTG = int.Parse(fields[16]),
                                S = int.Parse(fields[17]),
                                SPercentage = double.Parse(fields[18]),
                                TOIGP = fields[19],
                                ShiftsGP = double.Parse(fields[20]),
                                FOWPercentage = double.Parse(fields[21])
                            };
                            // Add the created object to the list
                            playerStats.Add(playerStat);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else if (fields.Length == 23)
                    {
                        try
                        {
                            var zero = 0.0;
                            // Create a new PlayerStats object and populate its properties
                            var playerStat = new PlayerStats
                            {
                                Player = fields[0],
                                Team = fields[1] + ", " + fields[2] + ", " + fields[3],
                                Pos = fields[4],
                                GP = int.Parse(fields[5]),
                                G = int.Parse(fields[6]),
                                A = int.Parse(fields[7]),
                                P = int.Parse(fields[8]),
                                PlusMinus = int.Parse(fields[9]),
                                PIM = int.Parse(fields[10]),
                                PGP = double.TryParse(fields[11], out zero) ? double.Parse(fields[11]) : 0.0,
                                PPG = int.Parse(fields[12]),
                                PPP = int.Parse(fields[13]),
                                SHG = int.Parse(fields[14]),
                                SHP = int.Parse(fields[15]),
                                GWG = int.Parse(fields[16]),
                                OTG = int.Parse(fields[17]),
                                S = int.Parse(fields[18]),
                                SPercentage = double.Parse(fields[19]),
                                TOIGP = fields[20],
                                ShiftsGP = double.Parse(fields[21]),
                                FOWPercentage = double.Parse(fields[22])
                            };
                            // Add the created object to the list
                            playerStats.Add(playerStat);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else if (fields.Length == 24)
                    {
                        try
                        {
                            var zero = 0.0;
                            // Create a new PlayerStats object and populate its properties
                            var playerStat = new PlayerStats
                            {
                                Player = fields[0],
                                Team = fields[1] + ", " + fields[2] + ", " + fields[3] + ", " + fields[4],
                                Pos = fields[5],
                                GP = int.Parse(fields[6]),
                                G = int.Parse(fields[7]),
                                A = int.Parse(fields[8]),
                                P = int.Parse(fields[9]),
                                PlusMinus = int.Parse(fields[10]),
                                PIM = int.Parse(fields[11]),
                                PGP = double.TryParse(fields[12], out zero) ? double.Parse(fields[12]) : 0.0,
                                PPG = int.Parse(fields[13]),
                                PPP = int.Parse(fields[14]),
                                SHG = int.Parse(fields[15]),
                                SHP = int.Parse(fields[16]),
                                GWG = int.Parse(fields[17]),
                                OTG = int.Parse(fields[18]),
                                S = int.Parse(fields[19]),
                                SPercentage = double.Parse(fields[20]),
                                TOIGP = fields[21],
                                ShiftsGP = double.Parse(fields[22]),
                                FOWPercentage = double.Parse(fields[23])
                            };
                            // Add the created object to the list
                            playerStats.Add(playerStat);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            var zero = 0.0;
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
                                PGP = double.TryParse(fields[9], out zero) ? double.Parse(fields[9]) : 0.0,
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
                            Console.WriteLine(e.Message);

                        }
                    }
                    

                   
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error reading the file {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error has occurred: {ex.Message}");
            }

            return playerStats;
        }
    }
}

