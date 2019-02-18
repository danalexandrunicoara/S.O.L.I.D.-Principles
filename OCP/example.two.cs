class CreditCard
{
	private string firstname = string.Empty;
	private string lastname = string.Empty;
	private DateTime expirationDate = new DateTime();

	protected int monthlyCost;

	public string getOwnerName()
	{
		return this.firstname + " " + this.lastname;
	}

	public DateTime getExpirationDate()
	{
		return this.expirationDate;
	}

	public double getMonthlyDiscount()
	{
		return this.monthlyCost * 0.02;
	}
}

class Silver : CreditCard
{
	public double getMonthlyDiscount()
	{
		return this.monthlyCost * 0.05;
	}
}

class Gold : CreditCard
{
	public double getMonthlyDiscount()
	{
		return this.monthlyCost * 0.07;
	}
}