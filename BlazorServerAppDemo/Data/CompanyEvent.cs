using System.ComponentModel.DataAnnotations;

namespace BlazorServerAppDemo.Data
{
    public class CompanyEvent
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        public IReadOnlyCollection<Participant> Participants { get; set; }
    }
}
