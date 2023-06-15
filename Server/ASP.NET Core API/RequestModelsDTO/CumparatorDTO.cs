namespace ASP.NET_Core_API.RequestModelsDTO
{
    public class CumparatorDTO
    {
        public int? CumparatorId { get; set; }
        public string? Nume { get; set; }
        public string? Prenume { get; set; }
        public string? Email { get; set; }
        public int? TipPersoana  { get; set; }
        public DateTime? DataNasterii { get; set; }
        public string? CNP {get; set; }
        public DateTime? DataInceput { get; set; }
        public DateTime? DataSfarsit { get;set; }
        public int? MMId { get; set; }
        public string TelefonMobil { get; set; }
    }
}
