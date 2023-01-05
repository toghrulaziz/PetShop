using PetShop;

Cat c = new("HelloKitty",12,"famale",10,55.2,22.4);
Cat c1 = new("Garfield",22,"male",7,21.5,25.3);


c.Play();
c.Sleep();
c.Eat();


c1.Play();


CatHouse house = new();
house.AddCat(c);
house.AddCat(c1);

house.ShowCats();


