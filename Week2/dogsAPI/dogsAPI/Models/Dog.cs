namespace dogsAPI.Models
{
	public class Dog
	{
		public Guid Id { get; set; }
		public string Name { get; set; }

		public ImperialMetricPair Weight { get; set; }
		public ImperialMetricPair Height { get; set; }

		public Interval LifeSpan { get; set; }
		public string ImageUrl { get; set; }
	}
}
