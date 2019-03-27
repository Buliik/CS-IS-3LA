using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Bul0056.Aggregates
{
    public class StrelbaDTO
    {
        public int Id { get; set; }
        public String Zacatek { get; set; }
        public String Konec { get; set; }
        public String Prostor { get; set; }
        public String Zakaznik { get; set; }
        public String Zamestnanec { get; set; }
        public String Zbran { get; set; }

        public StrelbaDTO(Strelba strelba)
        {
            Id = strelba.Id;
            Zacatek = strelba.Zacatek.ToString();
            Konec = strelba.Konec.ToString();

            if (strelba.Prostor.Id != 0)
                Prostor = strelba.Prostor.Id.ToString() + " " + strelba.Prostor.Vzdalenost.ToString() + "m";
            else Prostor = "Daná položka se již nevyskytuje v systému.";

            if(strelba.Zakaznik.Id != 0)
                Zakaznik = strelba.Zakaznik.Email;
            else Zakaznik = "Daná položka se již nevyskytuje v systému.";

            if(strelba.Zamestnanec.Id != 0)
                Zamestnanec = strelba.Zamestnanec.Email;
            else Zamestnanec = "Daná položka se již nevyskytuje v systému.";

            if(strelba.Zbran.Id != 0)
                Zbran = strelba.Zbran.Nazev;
            else Zbran = "Daná položka se již nevyskytuje v systému.";

        }

    }
}
