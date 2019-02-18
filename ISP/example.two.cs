interface IPrinter
{
	void printDocument(Document document);
}

interface IStaple
{
	void stapleDocument(Document document, int tray);
}

interface ICopier
{
	void copyDocument();
}

class SimplePrinter : IPrinter
{
	public void printDocument(Document document)
	{
		//...
	}
}

class ComplexPrinter : IPrinter, IStaple
{
	public void printDocument(Document document)
	{
		// ...
	}
	public void stapleDocument(Document document, int tray)
	{
		//...
	}
}

class SuperPrinter : IPrinter, IStaple, ICopier
{
	public void printDocument(Document document)
	{
		//...
	}

	public void stapleDocument(Document document, int tray)
	{
		//...
	}

	public void copyDocument()
	{
		//...
	}
}

class Document
{

}