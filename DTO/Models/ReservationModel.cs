using Newtonsoft.Json;

namespace DTO.Models
{
    public sealed class ReservationModel
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}
