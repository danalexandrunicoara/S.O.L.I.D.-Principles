
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

	onPress()
	{
		if (this.isOn)
		{
			this.bulb.turnOn();
			this.isOn = false;
		}
		else
		{
			this.bulb.turnOff();
			this.isOn = true;
		}
	}
}