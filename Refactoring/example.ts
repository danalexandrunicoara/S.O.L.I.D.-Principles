import { DeprecatedI18NPipesModule } from "@angular/common";

interface ILightState {
	toogleLight(): ILightState;
}

abstract class LightState implements ILightState {
	abstract toogleLight(): ILightState;
}

class LightOn extends LightState {
	constructor() {
		super();
		console.log("Light is turning on");
	}

	toogleLight(): ILightState {
		return new LightOff();
	}
}

class LightFlicker extends LightState {
	constructor() {
		super();
		console.log("Light is flickering");
	}

	toogleLight(): ILightState {
		return new LightOn();
	}
}

class LightOff extends LightState {
	constructor() {
		super();
		console.log("Light is turning off");
	}

	toogleLight(): ILightState {
		return new LightFlicker();
	}
}

class LightSwitch {
	private lightState: ILightState;

	constructor(lightState: ILightState) {
		this.lightState = lightState;
	}

	onPress() {
		this.lightState = this.lightState.toogleLight();
	}
}