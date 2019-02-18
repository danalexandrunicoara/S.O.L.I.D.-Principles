class CreditCard
{
	private string firstname = string.Empty;
	private string lastname = string.Empty;
	private DateTime expirationDate = string.Empty;

	protected int monthlyCost = 0;

	private Persistence persistence;

	private CreditCard(string firstname, string lastname, Date expirationDate, int monthlyCost, Persistence persistence)
	{
		this.persistence = persistence;

		this.firstname = firstname;
		this.lastname = lastname;
		this.expirationDate = expirationDate;
		this.monthlyCost = monthlyCost;
	}

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

	public void save()
	{
		this.persistence.saveCreditCard(this);
	}
}

class Persistence
{
	public void connect(string connectionString)
	{
		throw new Exception("Method not implemented.");
	}

	public void saveCreditCard(CreditCard creditCard)
	{
		throw new Exception("Method not implemented.");
	}
}
