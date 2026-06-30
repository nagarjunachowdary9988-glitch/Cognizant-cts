using Observer;


NewsAgency agency =
new NewsAgency();


Subscriber user1 =
new Subscriber("Nagarjuna");


Subscriber user2 =
new Subscriber("Alex");


agency.AddObserver(user1);

agency.AddObserver(user2);


agency.SetNews(
    "New Design Pattern Course Released"
);