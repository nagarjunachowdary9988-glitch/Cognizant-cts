using AbstractFactory;


IGUIFactory factory;


// Windows UI

factory = new WindowsFactory();


IButton button =
factory.CreateButton();


ICheckbox checkbox =
factory.CreateCheckbox();


button.Paint();

checkbox.Paint();



// Mac UI

factory = new MacFactory();


button = factory.CreateButton();

checkbox = factory.CreateCheckbox();


button.Paint();

checkbox.Paint();