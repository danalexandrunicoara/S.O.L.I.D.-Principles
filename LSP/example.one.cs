using System;

class Bird
{
	public void fly()
	{
		Console.WriteLine("I can fly!");
	}
}

class Kingfisher : Bird
{

	public Kingfisher() : base()
	{
	}

}

class Ostrich : Bird
{
	public Ostrich() : base()
	{
	}
}

class Program
{
	static void Main()
	{
		Bird kingfisherBird = new Kingfisher();

		Bird ostrichBird = new Ostrich();

		kingfisherBird.fly(); // kingfisher can fly.

		ostrichBird.fly(); // ostrich can fly ?!
	}
}