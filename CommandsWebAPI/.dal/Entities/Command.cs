using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command{
        public Command(int id, string howTo, string line)
        {
            Id = id;
            HowTo = howTo;
            Line = line;
        }

        public Command(int id, string howTo, string line, string platform)
        {
            Id = id;
            HowTo = howTo;
            Line = line;
            Platform = platform;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; } 
        [Required]  
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

/*        [Timestamp]
        public byte[] RowVersion { get; set; }*/
    }
}