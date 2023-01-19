using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Meseriasul1.Models
{
    public class Meserias
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Meserie { get; set; }
        public int Experienta { get; set; }
        public int? ServiciuID { get; set; }
        public Serviciu? Serviciu { get; set; }
        public int? ProgramareID { get; set; }
        public Programare? Programare { get; set; }
    }
}
