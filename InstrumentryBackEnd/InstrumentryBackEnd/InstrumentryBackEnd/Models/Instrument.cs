namespace InstrumentryBackEnd.Models
{
    public class Instrument
    {
        public int Id { get; set; }

        public string? Image { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public string? Description { get; set; }

        public double Price { get; set; }

        public string? Year { get; set; }
    }
}