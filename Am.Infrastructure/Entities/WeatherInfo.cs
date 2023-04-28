namespace Am.Infrastructure.Entities
{

    public class WeatherInfo : BaseEntity
    {
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public bool? Occupancy { get; set; }
    }
}
