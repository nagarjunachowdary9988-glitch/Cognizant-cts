using Command;


Light light =
new Light();


ICommand command =
new LightOnCommand(light);


RemoteControl remote =
new RemoteControl();


remote.SetCommand(command);


remote.PressButton();