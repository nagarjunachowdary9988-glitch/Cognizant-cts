using DIP;


IDatabase mysql =
new MySQLDatabase();


OrderService service =
new OrderService(mysql);


service.PlaceOrder();



IDatabase mongo =
new MongoDatabase();


OrderService service2 =
new OrderService(mongo);


service2.PlaceOrder();