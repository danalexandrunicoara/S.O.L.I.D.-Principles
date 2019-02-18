class CreditCard
{
	private string firstname = string.Empty;
	private string lastname = string.Empty;
	private Date expirationDate = string.Empty;

	protected int monthlyCost = 0;

	private Persistence persistence;

	private CreditCard(string firstname, string lastname, Date expirationDate, int monthlyCost, Persistence persistence)
	{
		this.persistence = persistence.connect("admin:password@fakedb");

		this.firstname = firstname;
		this.lastname = lastname;
		this.expirationDate = expirationDate;
		this.monthlyCost = monthlyCost;
	}

	public string getOwnerName()
	{
		return this.firstname + " " + this.lastname;
	}

	public Date getExpirationDate()
	{
		return this.expirationDate;
	}

	public Date getMonthlyDiscount()
	{
		return this.monthlyCost * 0.02;
	}
}

class CreditCardRepository
{
	private Persistence persistence;

	public CreditCardRepository(Persistence persistence)
	{
		this.persistence = persistence.connect("admin:password@fakedb");
	}

	public void save(CreditCard creditCard)
	{
		this.persistence.saveCreditCard(creditCard);
	}
}

class Persistence
{
	public static void connect(string connectionString)
	{
		throw new Error("Method not implemented.");
	}

	public void saveCreditCard(CreditCard creditCard)
	{
		throw new Error("Method not implemented.");
	}
}
