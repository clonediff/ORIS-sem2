using dogsAPI.Models;
using System.Reflection;

namespace dogsAPI
{
	public static class Extensions
	{
		public static IEnumerable<T> FilterByInterval<T>(this IEnumerable<T> source, Interval interval, string property)
		{
			if (property is null || interval is null) return source;

			var properties = property.Split('.');
			return source.Where(item =>
			{
				object cur = item;
				foreach (var curProp in properties)
					cur = cur.GetType().GetProperty(curProp)?.GetValue(cur)!;
				return (cur as Interval)!.Intersects(interval);
			});
		}
	}
}
