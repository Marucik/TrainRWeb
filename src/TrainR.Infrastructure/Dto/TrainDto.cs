namespace TrainR.Infrastructure.Dto
{
    public class TrainDto
    {
        public string Name { get; set; }
        public TrainDto(string name)
        {
            Name = name;
        }

    }
}