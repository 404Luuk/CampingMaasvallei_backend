using System.ComponentModel.DataAnnotations;


namespace CampingMaasvallei_v2.Models
{
    public class Reservation
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public string camping_spot_id { get; set; }
        public int guest_count { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int acces_code { get; set; }
    }
}