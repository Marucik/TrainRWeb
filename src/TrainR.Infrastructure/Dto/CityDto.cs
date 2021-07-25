namespace TrainR.Infrastructure.Dto
{
    public class CityDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public CityDto(int? id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}