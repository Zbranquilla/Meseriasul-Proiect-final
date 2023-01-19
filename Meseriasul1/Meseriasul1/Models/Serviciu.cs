using System.Security.Policy;

namespace Meseriasul1.Models
{
    public class Serviciu
    {
        public int ID { get; set; }
        public string NumeServiciu { get; set; }
        public decimal Pret { get; set; }
        public int? ProgramareID { get; set; }
        public Programare? Programare { get; set; }
        public ICollection<Meserias>? Meseriasii { get; set; }

    }



}

