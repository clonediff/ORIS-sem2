namespace dogsAPI.Models.DogApiModels
{
    public class ApiDog
    {
        public ImpMetric Weight { get; set; }
        public ImpMetric Height { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string life_span { get; set; }
        public ApiImage Image { get; set; }
    }

    public class ImpMetric
    {
        public string Imperial { get; set; }
        public string Metric { get; set; }
    }
}
