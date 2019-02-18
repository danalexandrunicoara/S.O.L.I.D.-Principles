using System;

interface ILightState
{
	ILightState toogleLight();
}

abstract class LightState : ILightState
{
	public abstract ILightState toogleLight();
}

class LightOn : LightState
{
	public LightOn() : base()
	{
		Console.WriteLine("Light is turning on");
	}

	public override ILightState toogleLight()
	{
		return new LightOff();
	}
}

class LightOff : LightState
{
	public LightOff() : base()
	{
		Console.WriteLine("Light is turning off");
	}

	public override ILightState toogleLight()
	{
		return new LightOn();
	}
}

class LightSwitch
{
	private ILightState lightState;

	public LightSwitch(ILightState lightState)
	{
		this.lightState = lightState;
	}

	public void onPress()
	{
		this.lightState = this.lightState.toogleLight();
	}
}

public class Program
{
	public static void Main()
	{
		ILightState lightOn = new LightOn();
		LightSwitch lightSwitch = new LightSwitch(lightOn);
		lightSwitch.onPress();
	}
}