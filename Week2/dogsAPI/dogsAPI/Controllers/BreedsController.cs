using dogsAPI.Data;
using dogsAPI.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;

namespace dogsAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BreedsController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<DogShortInfo> GetAll([FromQuery] int limit, [FromQuery] int page,
			string lifeSpan = "", string weight = "", string weightType = "", string height = "", string heightType = "")
		{

			var lifeSpanInterval = GetInterval(lifeSpan);
			var weightInterval = GetInterval(weight);
			var heightInterval = GetInterval(height);

			var result = DataSeeds.Dogs
				.FilterByInterval(lifeSpanInterval!, nameof(Dog.LifeSpan))
				.FilterByInterval(weightInterval!, $"{nameof(Dog.Weight)}.{weightType}")
				.FilterByInterval(heightInterval!, $"{nameof(Dog.Height)}.{heightType}");
			Response.Headers.Add("pagination-count", result.Count().ToString());

			return result
				.OrderBy(x => x.Name)
				.Select(dog => new DogShortInfo
					{
						Id = dog.Id,
						Name = dog.Name,
						ImageUrl = dog.ImageUrl
					})
				.Skip(limit * page)
				.Take(limit);
		}

		Interval? GetInterval(string intervalStr)
		{
			if (!Regex.IsMatch(intervalStr, Interval.IntervalRegex)) return null;
			var parts = Regex.Matches(intervalStr, Interval.IntervalPartRegex)
				.Select(x => double.Parse(x.Value))
				.OrderBy(x => x)
				.ToArray();
			return new(parts[0], parts[1]);
		}


		[HttpGet("{id}")]
		public Dog? GetById([FromRoute] Guid id)
			=> DataSeeds.Dogs.FirstOrDefault(x => x.Id == id);
	}
}
