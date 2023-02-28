using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
	public class BurgerBuilderImpl : BurgerBuilder
	{
		Burger burger = new Burger();

		public override void AddBottomBun()
		{
			burger.Add(new BottomBun());
		}

		public override void AddCheese()
		{
			burger.Add(new Cheese());
		}

		public override void AddCucumber()
		{
			burger.Add(new Cucumber());
		}

		public override void AddCutlet()
		{
			burger.Add(new Cutlet());
		}

		public override void AddKetchup()
		{
			burger.Add(new Ketchup());
		}

		public override void AddLettuce()
		{
			burger.Add(new Lettuce());
		}

		public override void AddMiddleBun()
		{
			burger.Add(new MiddleBun());
		}

		public override void AddMustard()
		{
			burger.Add(new Mustard());
		}

		public override void AddPepper()
		{
			burger.Add(new Pepper());
		}

		public override void AddTomatoes()
		{
			burger.Add(new Tomatoes());
		}

		public override void AddTopBun()
		{
			burger.Add(new TopBun());
		}

		public override void Fry()
		{
			burger.Fry();
		}

		public override Burger GetBurger()
		{
			return burger;
		}

		public override void Pack()
		{
			burger.Pack();
		}
	}
}
