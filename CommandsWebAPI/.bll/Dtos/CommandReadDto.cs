namespace Commander.Dtos
{
    public class CommandReadDto{
        public CommandReadDto(int id, string howTo, string line)
        {
            Id = id;
            HowTo = howTo;
            Line = line;
        }

        public int Id { get; set; }
        public string HowTo { get; set; } 
        public string Line { get; set; }
    }
}