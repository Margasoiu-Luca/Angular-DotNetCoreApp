namespace ASP.NET_Core_API.RequestModelsDTO
{
    public class ProdusDTO
    {
        public int? ProdusId { get; set; }
        public string DenumireProdus { get; set; }
        public float CostProdus { get; set; }
        public string DescriereProdus { get; set; }

        public DateTime? DataInceput { get; set; }
        public DateTime? DataSfarsit { get; set; }
        public int CategorieProdusId { get; set; }
        public int ProducatorId { get; set; }
    }
  }
