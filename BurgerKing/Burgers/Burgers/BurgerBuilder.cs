using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
	public class Burger
	{
		List<Ingredient> ingredients = new();

		public double Price => ingredients.Sum(x => x.Price);

		internal void Add(Ingredient ingredient)
		{
			ingredients.Add(ingredient);
		}

		internal void Pack()
		{
			if (ingredients.Count < 1)
				Console.WriteLine("Can't pack nothing");
			else
			{
				var pack = new Pack(ingredients);
				ingredients = new();
				Add(pack);
			}
		}

		internal void Fry()
		{
			if (ingredients.Count < 1)
				Console.WriteLine("Can't fry nothing");
			else if (ingredients[^1] is not Fryable fryable)
				Console.WriteLine($"Can't fry {ingredients[^1].GetType().Name}");
			else
				fryable.Fry();
		}

		public override string ToString() => $"{string.Join(",\n", ingredients)}\nTotal cost: {Price}";
	}

	public abstract class BurgerBuilder
	{
		public abstract void AddTopBun();
		public abstract void AddMiddleBun();
		public abstract void AddBottomBun();
		public abstract void AddCheese();
		public abstract void AddTomatoes();
		public abstract void AddLettuce();
		public abstract void AddCucumber();
		public abstract void AddCutlet();
		public abstract void AddPepper();
		public abstract void AddKetchup();
		public abstract void AddMustard();

		public abstract void Fry();

		public abstract void Pack();
		public abstract Burger GetBurger();
	}
}
