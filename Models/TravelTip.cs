namespace TravelTipsAPI.Models
{
    public class TravelTip
    {
        public int Id { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string AirbnbLink { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
