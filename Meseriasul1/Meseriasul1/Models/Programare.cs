namespace Meseriasul1.Models
{
    public class Programare
    { 
        public int ID { get; set; }
        public DateTime Dataprogramarii { get; set; }
        public ICollection<Serviciu>? Servicii { get; set; }
        public ICollection<Meserias>? Meseriasi { get; set; }
    }
}
