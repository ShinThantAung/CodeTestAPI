namespace Am.Infrastructure.Dto.WeatherInfo
{
    public class RequestModel
    {
        public string deviceId { get; set; }
        public string deviceType { get; set; }
        public string deviceName { get; set; }
        public string groupId { get; set; }
        public string dataType { get; set; }
        public Data data { get; set; }
        public long timestamp { get; set; }
    }

    public class Data
    {
        public bool? fullPowerMode { get; set; }
        public bool? activePowerControl { get; set; }
        public int? firmwareVersion { get; set; }
        public int? temperature { get; set; }
        public int? humidity { get; set; }
        public int? version { get; set; }
        public string? messageType { get; set; }
        public bool? occupancy { get; set; }
        public int? stateChanged { get; set; }
    }
}
