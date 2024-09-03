namespace FormNewProject.Data.Entities
{
    public class Defaut
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Opn_Id { get; set; }
        public int TRet_Id {  get; set; }
        public string Defauls { get; set; } = string.Empty;
    }
}
