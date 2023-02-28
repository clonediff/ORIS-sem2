using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
	public class TopBun : Fryable
	{
		
		

		public TopBun() => Price = 10;

		public override void Fry()
		{
			base.Fry();
			Price *= 1.5;
		}
	}

	public class MiddleBun : Fryable
	{
		
		

		public MiddleBun() => Price = 10;

		public override void Fry()
		{
			base.Fry();
			Price *= 1.5;
		}
	}

	public class BottomBun : Fryable
	{
		
		

		public BottomBun() => Price = 10; 
		
		public override void Fry()
		{
			base.Fry();
			Price *= 1.5;
		}
	}

	public class Cheese : Fryable
	{
		
		

		public Cheese() => Price = 2;

		public override void Fry()
		{
			base.Fry();
			Price *= 2;
		}
	}

	public class Tomatoes : Ingredient
	{
		

		public Tomatoes() => Price = 12;
	}

	public class Lettuce : Ingredient
	{
		

		public Lettuce() => Price = 7;
	}

	public class Cucumber : Ingredient
	{
		public Cucumber() => Price = 11;
	}

	public class Pepper : Ingredient
	{
		public Pepper() => Price = 10;
	}

	public class Ketchup : Sauce
	{
		public Ketchup() => Price = 7;
	}

	public class Mustard : Sauce
	{
		public Mustard() => Price = 7;
	}

	public class Cutlet : Fryable
	{
		public Cutlet() => Price = 20;

		public override void Fry()
		{
			base.Fry();
			Price *= 2;
		}
	}

	public class Pack : Ingredient
	{
		public double OwnPrice { get; set; }
		IEnumerable<Ingredient> _ingredients;
		public Pack(IEnumerable<Ingredient> ingredients)
		{
			OwnPrice = 1.5;
			_ingredients = ingredients;
			Price = ingredients.Sum(x => x.Price) + OwnPrice;
		}

		public override string ToString()
		{
			return $"{nameof(Pack)}: {{\n{string.Join(",\n", _ingredients)}\n}}, price: {Price - OwnPrice} + {OwnPrice} = {Price}";
		}
	}
}
