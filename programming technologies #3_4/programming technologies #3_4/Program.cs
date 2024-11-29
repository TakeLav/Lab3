// builder
using System.Text;

class Juice
{
	public string Taste { get; set; }
}
class Ice
{ }
class Drink
{
	public Juice Juice { get; set; }
	public Ice Ice { get; set; }
	public override string ToString()
	{
		StringBuilder a = new StringBuilder();
		a.Append(Juice.Taste + " и ");
		a.Append("лёд \n");
		return a.ToString();
	}
}

class Program
{
	static void Main(string[] args)
	{
		Bartender_senior baker = new Bartender_senior();
		Bartender bartender = new DrinkBuilder();
		Drink Drink1 = baker.Mix(bartender);
		Console.WriteLine(Drink1.ToString());

		bartender = new DrinkBuilder2();
		Drink Drink2 = baker.Mix(bartender);
		Console.WriteLine(Drink2.ToString());
	}
}

abstract class Bartender
{
	public Drink Drink { get; private set; }
	public void CreateDrink()
	{
		Drink = new Drink();
	}
	public abstract void SetJuice();
	public abstract void SetIce();
}
// пекарь
class Bartender_senior
{
	public Drink Mix(Bartender bar)
	{
		bar.CreateDrink();
		bar.SetJuice();
		bar.SetIce();
		return bar.Drink;
	}
}
class DrinkBuilder : Bartender
{
	public override void SetJuice()
	{
		this.Drink.Juice = new Juice { Taste = "Апельсиновый сок" };
	}

	public override void SetIce()
	{
		this.Drink.Ice = new Ice();
	}
}
class DrinkBuilder2 : Bartender
{
	public override void SetJuice()
	{
		this.Drink.Juice = new Juice { Taste = "Яблочный сок" };
	}

	public override void SetIce()
	{
		this.Drink.Ice = new Ice();
	}
}
