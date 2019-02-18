
interface IPrinter
{
	void copyDocument();
	void printDocument(Document document);
	void stapleDocument(Document document, int tray);
}

class SimplePrinter : IPrinter
{
	public void copyDocument()
	{
		//...
	}

	public void printDocument(Document document)
	{
		//...
	}

	public void stapleDocument(Document document, int tray)
	{
		//...
	}

}