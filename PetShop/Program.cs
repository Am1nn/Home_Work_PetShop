using PetShop;

Dog d1 = new("Hatiko", "Male", 10,1);
Dog d2 = new("Hatikoo", "Male", 10,10);

Cat c1 = new("Mesi", "Female", 100, 10);
Cat c2 = new("Mesi", "Male", 100, 10);

Bird B1 = new("Cik Cik", "Male", 24, 24567);
Bird B2 = new("Cik Cikkkkk", "Female", 24, 24567);

Fish f1 = new("Karl", "Male", 11, 12345);
Fish f2 = new("Karll", "Female", 11, 12345);


d1.Play();
d1.PetInformation();
d1.Play();
d1.Sleep();
d1.Eat();
ClassPetShop p1 = new();
p1.AddDog(d1);
p1.AddDog(d2);
p1.AddCat(c1);
p1.AddCat(c2);
p1.AddBird(B1);
p1.AddBird(B2);
p1.AddFish(f1);
p1.AddFish(f2);


p1.PrintPets();

p1.DeleteByName("Karl");
p1.PrintPets();
