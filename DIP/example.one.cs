class LightBulb
{
	public void turnOn()
	{
		//... 
	}

	public void turnOff()
	{
		//...
	}
}

class LightSwitch
{
	private bool isOn = false;
	private LightBulb lightBulb;

	public LightSwitch(LightBulb lightBulb)
	{
		this.lightBulb = lightBulb;
	}

	public void onPress()
	{
		if (this.isOn)
		{
			this.lightBulb.turnOff();
			this.isOn = false;
		}
		else
		{
			this.lightBulb.turnOn();
			this.isOn = true;
		}
	}
}
