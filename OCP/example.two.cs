class CreditCard
{
	private string firstname = string.Empty;
	private string lastname = string.Empty;
	private Date expirationDate = string.Empty;

	private int monthlyCost;

	public string getOwnerName()
	{
		return this.firstname + " " + this.lastname;
	}

	public Date getExpirationDate()
	{
		return this.expirationDate;
	}

	public int getMonthlyDiscount()
	{
		return this.monthlyCost * 0.02;
	}
}

class Silver : CreditCard
{
	public int getMonthlyDiscount()
	{
		return this.monthlyCost * 0.05;
	}
}

class Gold : CreditCard
{
	public int getMonthlyDiscount()
	{
		return this.monthlyCost * 0.07;
	}
}
