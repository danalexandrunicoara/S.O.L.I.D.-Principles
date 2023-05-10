interface ILightBulb
{
	void turnOn();

	void turnOff();
}

class LightBulb : ILightBulb
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
	private ILightBulb lightBulb;

	public LightSwitch(ILightBulb lightBulb)
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
