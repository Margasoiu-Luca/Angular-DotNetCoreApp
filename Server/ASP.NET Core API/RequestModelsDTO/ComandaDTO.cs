namespace ASP.NET_Core_API.RequestModelsDTO
{
    public class ComandaDTO
    {
        public int? ComandaId { get; set; }
        public string? Numar { get; set; }
        public float? CostTotalProduse { get; set; }
        public float? CostLivrare { get; set; }
        public int? CumparatorId { get; set; }
        public DateTime? DataComanda { get; set; }

    }
}
