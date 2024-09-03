using CsvHelper.Configuration;

namespace FormNewProject.Data.Entities
{
    public class Reclamation
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string OF { get; set; } = string.Empty;
        public int Num_Paquet { get; set; }
        public int Opn_Id { get; set; }
        public string Operation { get; set; } = string.Empty;
        public string Operatrice { get; set; } = string.Empty;
        public string Chaine { get; set; } = string.Empty;
    }
    public class ReclamationMap : ClassMap<Reclamation>
    {
        public ReclamationMap()
        {
            Map(m => m.OF).Name("OF");
            Map(m => m.Num_Paquet).Name("Num_Paquet");
            Map(m => m.Opn_Id).Name("Opn_Id");
            Map(m => m.Operation).Name("Operation");
            Map(m => m.Operatrice).Name("Operatrice");
            Map(m => m.Chaine).Name("Chaine");
        }
    }

}
