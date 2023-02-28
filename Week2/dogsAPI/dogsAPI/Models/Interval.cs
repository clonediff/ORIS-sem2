namespace dogsAPI.Models
{
	public class Interval
	{
		public static string IntervalPartRegex = @"\d+(\.\d+)?";
		public static string IntervalRegex = @"\d+(\.\d+)?-\d+(\.\d+)?";

		public double Start { get; set; }
		public double End { get; set; }

		public double Length => End - Start;

		public Interval(double start, double end)
		{
			Start = start;
			End = end;
		}

		public Interval(double val = double.NaN)
		{
			Start = val;
			End = val;
		}

		public bool Intersects(Interval other)
		{
			if (this is null || other is null) return false;
			return Start <= other.End && other.End <= End ||
					other.Start <= End && End <= other.End;
		}

		public bool Intersects2(Interval other)
		{
			if (this is null || other is null) return false;
			var sumLength = new Interval(Math.Min(other.Start, Start), Math.Max(other.End, End)).Length;
			return sumLength - other.Length - Length <= 1e-5;
		}

		public override string ToString() => $"[({Start}) - ({End})]";
	}
}
