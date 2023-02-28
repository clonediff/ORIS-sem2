using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Burgers
{
	public abstract class Ingredient
	{
		public double Price { get; set; }

		public override string ToString() => $"{GetType().Name}, price: {Price}";
	}

	public abstract class Sauce : Ingredient { }

	public abstract class Fryable : Ingredient
	{
		public bool Fryed { get; set; }

		public virtual void Fry() => Fryed = true;

		public override string ToString() => $"{GetType().Name}: {(!Fryed ? "not " : "")}fryed, price: {Price}";
	}
}
