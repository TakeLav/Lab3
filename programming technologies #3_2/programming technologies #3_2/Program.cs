//factory method
using System.Globalization;
using System.Net.Http.Headers;

abstract class Master
{
	abstract public Sword Create();
}
abstract class Sword
{

}
class NorwayMaster: Master
{
	public NorwayMaster()
	{

	}

	public override Sword Create()
	{
		return new NorwaySword();
	}

}
class JapaneseMaster: Master
{
	public JapaneseMaster()
	{

	}

	public override Sword Create()
	{
		return new JapaneseSword();
	}
}
class NorwaySword: Sword
{
	public NorwaySword()
	{
		Console.WriteLine("Выкован меч викингов");
	}
}
class JapaneseSword: Sword
{
	public JapaneseSword()
	{
		Console.WriteLine("Выкована катана");
	}
}

class Programm
{
	static void Main(string[] args)
	{
		Master nor = new NorwayMaster();
		Sword sword2 = nor.Create();

		nor = new JapaneseMaster();
		Sword sword = nor.Create();

		Console.ReadLine();
	}
}