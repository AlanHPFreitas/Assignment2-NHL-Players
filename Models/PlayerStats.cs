using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_NHL_Players.Models
{
    public class PlayerStats
    {
        public string Player { get; set; }
        public string Team { get; set; }
        public string Pos { get; set; }
        public int GP { get; set; }
        public int G { get; set; }
        public int A { get; set; }
        public int P { get; set; }
        public int PlusMinus { get; set; }
        public int PIM { get; set; }
        public double PGP { get; set; }
        public int PPG { get; set; }
        public int PPP { get; set; }
        public int SHG { get; set; }
        public int SHP { get; set; }
        public int GWG { get; set; }
        public int OTG { get; set; }
        public int S { get; set; }
        public double SPercentage { get; set; }
        public string TOIGP { get; set; }
        public double ShiftsGP { get; set; }
        public double FOWPercentage { get; set; }

        public override string ToString()
        {
            return string.Format("Player: {0}, Team: {1}", Player, Team);
        }
    }


}
