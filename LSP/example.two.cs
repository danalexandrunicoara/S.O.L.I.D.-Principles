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

	public void Fly()
	{
		throw new Exception("I don't fly rather I run");
	}

	public void run()
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

		ostrichBird.fly(); // I don't fly rather I run.
	}
}