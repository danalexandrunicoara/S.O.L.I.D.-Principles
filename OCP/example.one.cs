class CreditCard
{
	private string firstname = string.Empty;
	private string lastname = string.Empty;
	private DateTime expirationDate = new DateTime();

	private string type;

	protected int monthlyCost = 0;

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
		if (this.type == "Silver")
		{
			return this.monthlyCost * 0.05;
		}
		if (this.type == "Gold")
		{
			return this.monthlyCost * 0.07;
		}
		if (this.type == "Platinum")
		{
			return this.monthlyCost * 0.10;
		}
		return this.monthlyCost * 0.02;
	}
}