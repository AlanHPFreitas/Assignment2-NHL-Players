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
            // Inicializar uma lista para guardar as estatísticas dos jogadores
            var playerStats = new List<PlayerStats>();

            try
            {

                // Lê todas as linhas do ficheiro, pulando a linha do cabeçalho
                var lines = File.ReadAllLines(filePath).Skip(1);

                foreach (var line in lines)
                {
                    // Dividir cada linha por vírgula para obter os campos individuais
                    var fields = line.Split(',');

                    // Certifica de que o número correto de campos está presente
                    if (fields.Length < 21)
                    {
                        Console.WriteLine($"Invalid line: {line}");
                        continue; // Saltar esta linha e passar à seguinte
                    }
                    if (fields.Length > 21)
                    {
                        Console.WriteLine($"Invalid line: {line}");
                        continue; // Saltar esta linha e passar à seguinte
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
                        // Adicionar o objeto criado à lista
                        playerStats.Add(playerStat);
                    }
                    catch (Exception e) 
                    { 
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

