
namespace PetShop
{
    

    internal abstract class Animals
    {
        // Fields
        protected string __name;
        protected string __gender;
        protected int __age;
        protected short __energy=100;
        protected int __price;
        protected int __meal_quantity=100;
        protected string __pet_type;

        // Constructor
        public Animals(string name_g,string gender_g,int age_g,int price_g,string pet_type)
        {
            SetName(name_g);
            SetGender(gender_g);
            SetAge(age_g);
            SetPrice(price_g);
            SetPetType(pet_type);
        }
        // Set Methods
        public void SetName(string name_g)
        {
            if (name_g == " ")
                throw new Exception("Wrong Name");
            __name = name_g;
        }
        public void SetGender(string gender_g)
        {
            if(gender_g=="Male" || gender_g=="male"|| gender_g=="Female" || gender_g=="female")
                __gender = gender_g;    
            else
                throw new Exception("Wrong Gender");
        }
        public void SetAge(int age_g)
        {
            if (age_g < 0 || age_g > 100)
                throw new Exception("Wrong Age");
            __age= age_g;
        }
        public void SetPrice(int price_g)
        {
            if (price_g < 0)
                throw new Exception("Wrong Price");
            __price= price_g;
        }
        public void SetPetType(string pet_type_g)
        {
            __pet_type = pet_type_g;
        }
        //Get Methods
        public string GetName() { return this.__name; }
        public string GetGender() { return this.__gender; } 
        public int GetAge() { return this.__age; }
        public int GetPrice() { return this.__price; }
        public int GetEnergy() { return this.__energy; }
        public int GetMealQuantity() { return this.__meal_quantity; }


        // Other Functions
        public void Eat()
        {
            Console.WriteLine($"\nCurrently {__pet_type} Name ->>{__name}\n");
            if (__meal_quantity == 100)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("No Food Provided Because Quantitiy Is Full");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                __meal_quantity++;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Food Provided Sucsesfully");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void Sleep()
        {
            Console.WriteLine($"\nCurrently {__pet_type} NickName ->>{__name}\n");
            if (__energy == 100)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Cannot Sleep Because Energy Is Full");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                __energy++;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Sleeping...");
                Thread.Sleep(1000);
                Console.WriteLine("Slepping Complated Sucsessfuly");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        public void Play()
        {
            Console.WriteLine($"\nCurrently {__pet_type} NickName ->>{__name}\n");
            if(__energy==0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Cannot Playing Bcause Not have Enough Energy");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if(__meal_quantity==0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Cannot Sleep Because {__name} is Hungry");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if(__energy!=0 && __meal_quantity!=0)
            {
                __energy--;
                __meal_quantity--;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Playing...");
                Thread.Sleep(1000);
                Console.WriteLine("Playing Complated Sucsessfuly");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
        // Print Currently Status
        public void PetInformation()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\t\t~~~Pet Information~~~\n");
            Console.WriteLine($"Pet Type ->> {__pet_type}");
            Console.WriteLine($"Pet NickName ->>{__name} ");
            Console.WriteLine($"Pet Gender ->> {__gender}");
            Console.WriteLine($"Pet Age ->> {__age}");
            Console.WriteLine($"Pet Energy ->> {__energy}");
            Console.WriteLine($"Pet Meal Quatity ->> {__meal_quantity}");
            Console.Write($"Price ->> {__price}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
    internal class Dog:Animals
    {
        public Dog(string name_g, string gender_g, int age_g, int price_g) : base(name_g, gender_g, age_g, price_g, "Dog") { }
    }
    internal class Cat : Animals
    {
        public Cat(string name_g, string gender_g, int age_g, int price_g) : base(name_g, gender_g, age_g, price_g, "Cat") { }
      }
    internal class Fish : Animals
    {
        public Fish(string name_g, string gender_g, int age_g, int price_g) : base(name_g, gender_g, age_g, price_g, "Fish") { }
    }
    internal class Bird : Animals
    {
        public Bird(string name_g, string gender_g, int age_g, int price_g) : base(name_g, gender_g, age_g, price_g, "Bird") { }
    }

    //Pet Shop
    class ClassPetShop
    {
        private List<Dog> Dogs = new() {  };
        private List<Cat> Cats= new() { };
        private List<Bird> Birds = new() { };
        private List<Fish> Fishes = new() { };

        // Constructor Default
        public ClassPetShop() { }
        // Add Methods
        public void AddDog(Dog new_dog)
        {
            Dogs.Add(new_dog);
        }
        public void AddCat(Cat new_cat)
        {
            Cats.Add(new_cat);
        }
        public void AddBird(Bird new_bird)
        {
            Birds.Add(new_bird);
        }
        public void AddFish(Fish new_fish)
        {
            Fishes.Add(new_fish);
        }
        // Print Functions
        public void PrintDogs()
        {
            foreach (var dog_1 in Dogs)
            {
                dog_1.PetInformation();
            }
        }
        public void PrintCats()
        {
            foreach (var cat_1 in Cats)
            {
                cat_1.PetInformation();
            }
        }
        public void PrintBirds()
        {
            foreach (var birds_1 in Birds)
            {
                birds_1.PetInformation();
            }
        }
        public void PrintFishes()
        {
            foreach (var fish_1 in Fishes)
            {
                fish_1.PetInformation();
            }
        }
        public void PrintPets()
        {
            Console.WriteLine("\t\tDogs\n");
            PrintDogs();
            Console.WriteLine("\t\tCats]\n");
            PrintCats();
            Console.WriteLine("\t\tBirds\n");
            PrintBirds();
            Console.WriteLine("\t\tFishes\n");
            PrintFishes();
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Delete By specifed Name And Gender
        // ->> Overload vol 1
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void DeleteByName(string name ,string gender)
        {
            if (gender == "dog" || gender == "Dog" || gender == "d" || gender == "D") // Dog
            {
                for (int a = 0; a < Dogs.Count; a++)
                {
                    if (Dogs[a].GetName() == name)
                    {
                        Dogs.RemoveAt(a);
                    }
                    else
                    {
                        throw new Exception("Cannot Deleted because this username wrong."); //make error
                    }  
                }
            }
            else if (gender == "cat" || gender == "Cat" || gender == "c" || gender == "C") // Cat
            {
                for (int a = 0; a < Cats.Count; a++)
                {
                    if (Cats[a].GetName() == name)
                    {
                        Cats.RemoveAt(a);
                    }
                    else
                    {
                        throw new Exception("Cannot Deleted because this username wrong."); //make error
                    }
                }
            }
            else if (gender == "Bird" || gender == "bird" || gender == "B" || gender == "b") // Bird
            {
                for (int a = 0; a < Birds.Count; a++)
                {
                    if (Birds[a].GetName() == name)
                    {
                        Birds.RemoveAt(a);
                    }
                    else
                    { 
                        throw new Exception("Cannot Deleted because this username wrong."); //make error
                    }

                }
            }
            if (gender == "Fish" || gender == "fish" || gender == "f" || gender == "F") // Fish
            {
                for (int a = 0; a < Fishes.Count; a++)
                {
                    if (Fishes[a].GetName() == name)
                    {
                        Fishes.RemoveAt(a);

                    }
                    else
                    {
                        throw new Exception("Cannot Deleted because this username wrong."); //make error
                    }

                }
            }
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Delete By specifed Name
        // ->> Overload vol 2
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public void DeleteByName(string name)
        {
            bool check = false;
            for (int a = 0; a < Dogs.Count; a++)
            {
                if (Dogs[a].GetName() == name)
                {
                    Dogs.RemoveAt(a);
                    check = true;
                }
               
            }
            for (int a = 0; a < Cats.Count; a++)
            {
                if (Cats[a].GetName() == name)
                {
                    Cats.RemoveAt(a);
                    check=true;
                }
            }
            for (int a = 0; a < Birds.Count; a++)
            {
                if (Birds[a].GetName() == name)
                {
                    Birds.RemoveAt(a);
                    check = true;
                }
            }
            for (int a = 0; a < Fishes.Count; a++)
            {
                if (Fishes[a].GetName() == name)
                {
                    Fishes.RemoveAt(a);
                    check = true;
                }
                
            }
            if(!check)
                throw new Exception("Cannot Deleted because this username wrong.");
        }
    }

}
