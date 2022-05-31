using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_zadatak.Models
{
    public class Evidencija_Posudbe
    {
        public int Id { get; set; }
        public string Opremu_Posudio { get; set; }
        public string Oremu_Izdao { get; set; }
        public DateTime Datum_Posudbe { get; set; }
        public DateTime Ocekivani_Datum_Povratka { get; set; }

        public string Razlog_Posudbe { get; set; }
        public string Popis_Opreme { get; set; }

    }
}
