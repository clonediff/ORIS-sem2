using dogsAPI.Models;
using dogsAPI.Models.DogApiModels;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.RegularExpressions;

namespace dogsAPI.Controllers
{
    [ApiController]
	[Route("[controller]")]
	public class ParserController : ControllerBase
	{
		[HttpPost]
		public string GetAll([FromBody] IEnumerable<ApiDog> dogs)
		{
			var builder = new StringBuilder();

			builder.AppendLine("\t\t{");
			foreach (var dog in dogs)
			{
				builder.AppendLine( "\t\t\tnew Dog");
				builder.AppendLine( "\t\t\t{");
				builder.AppendLine($"\t\t\t\tId = Guid.NewGuid(),");
				builder.AppendLine($"\t\t\t\tName = \"{dog.Name}\",");
				builder.AppendLine( "\t\t\t\tWeight = new()");
				builder.AppendLine( "\t\t\t\t{");
				builder.AppendLine($"\t\t\t\t\tImperial = new({GetInterval(dog.Weight.Imperial)}),");
				builder.AppendLine($"\t\t\t\t\tMetric = new({GetInterval(dog.Weight.Metric)})");
				builder.AppendLine( "\t\t\t\t},");
				builder.AppendLine( "\t\t\t\tHeight = new()");
				builder.AppendLine( "\t\t\t\t{");
				builder.AppendLine($"\t\t\t\t\tImperial = new({GetInterval(dog.Height.Imperial)}),");
				builder.AppendLine($"\t\t\t\t\tMetric = new({GetInterval(dog.Height.Metric)})");
				builder.AppendLine( "\t\t\t\t},");
				builder.AppendLine($"\t\t\t\tLifeSpan = new({GetInterval(dog.life_span)}),");
				builder.AppendLine($"\t\t\t\tImageUrl = \"{dog.Image.Url}\"");
				builder.AppendLine( "\t\t\t},");
			}
			builder.Append("\t\t}");
			return builder.ToString();
		}

		string GetInterval(string interval) => string.Join(", ", Regex.Matches(interval, Interval.IntervalPartRegex));
	}
}
