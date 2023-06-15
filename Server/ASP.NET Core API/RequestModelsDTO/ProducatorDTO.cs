namespace ASP.NET_Core_API.RequestModelsDTO
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ProducatorDTO
    {
        public int? producatorId { get; set; }
        public int? producatorIdCt { get; set; }
        public DateTime? dataInceput { get; set; }
        public DateTime? dataSfarsit { get; set ; }
        public string nume { get; set; }
        public string adresa { get; set; }
        public int? mmId { get; set; }
    }


}
