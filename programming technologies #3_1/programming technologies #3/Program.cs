//singleton
class Singleton
{
	private static Singleton instance;

	private Singleton()
	{ }

	public static Singleton Instance()
	{
		if (instance == null)
			instance = new Singleton();
		return instance;
	}
}

class Human
{
	public Name Name { get; set; }
	public void Nname(string humanName)
	{
		Name = Name.getInstance(humanName);
	}
}
class Name
{
	private static Name instance;

	public string HumanName { get; private set; }

	protected Name(string name)
	{
		this.HumanName = name;
	}

	public static Name getInstance(string name)
	{
		if (instance == null)
			instance = new Name(name);
		return instance;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Human human = new Human();
		human.Nname("Gleb");
		Console.WriteLine(human.Name.HumanName);  
		human.Name = Name.getInstance("Andrey");
		Console.WriteLine(human.Name.HumanName);
	}
}
