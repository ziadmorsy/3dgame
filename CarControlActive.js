var CarControl : GameObject;
var DreamCar01 : GameObject;




function Start (){




CarControl.GetComponent("CarController").enabled = true; 


DreamCar01.GetComponent("CarAIControl").enabled = true;

}
