using System;

namespace Objekt_Orienteret_Programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant myplant = new Plant();
            Console.WriteLine("The color of my plant is " + myplant.coloroftheplant);
            Console.WriteLine(myplant.numberofleaves + " pieces of leaves on my plant");
            Console.WriteLine(myplant.hightoftheplant + "cm. Hight of my plant");
            Console.WriteLine(myplant.hightofthepot + "cm. Hight of my pot");

            Mobile myMobile = new Mobile();
            Console.WriteLine(myMobile.gbspace + "GB space, on my phone");

            Classroom myClass = new Classroom();
            Console.WriteLine("Hr " + myClass.nameofteacher + " is my teacher");

            Shoes myShoes = new Shoes();
            Console.WriteLine(myShoes.brand + " is the name of the shoe brand, I am wearing");

            Gaming myGames = new Gaming();
            Console.WriteLine("I am playing: " + myGames.nameofthegame + ". All on my Mobile");

            Car myCar = new Car();
            Console.WriteLine("My car to school is a: " + myCar.brand);

        }

    }
    class Plant
    {
        public string coloroftheplant = "Green"; // color of the plant
        public int numberofleaves = 45; // number of leaves on the plant
        public string colorofthepot = "White"; // color of the pot the plant is standig in
        public double hightofthepot = 35.5; // hight of the pot(only the pot)
        public double hightoftheplant = 40.00; // hight of the plant(only the plant)
    }

    class Mobile
    {
        public string typemobile = "Huawei"; //name of the mobile you own
        public string mobilsubscription = "Telmore"; //mobil "abonnement" you have
        public int gbspace = 128; // GB space on your mobile
        public bool smashedscreen = true || false; // bool or while to a yes or no qustien 
        public int ownedinbumberofmonths = 15; // how longe have you own the mobil-in months 
    }
    class Classroom
    {
        public int numberofstudents = 18; // number of students in the class
        public string nameofteacher = "Rene"; // name of the teacher in the class
        public int weeklyschoolhoursstudents = 36; //number of school hours in a week for the student
        public int weeklyworkhoursteacher = 38; // number of work hours in a week for a teacher
    }
    class Shoes
    {
        public bool womenorman = true || false; // woman or man shoe
        public bool girlorboy = true || false; // girl or boy shoe
        public int shoesizeEU = 40; // shoe size in EU-size
        public double shoesizeUKUS = 39.50;    //shoe size in UK- and US-size
        public string brand = "Vans"; // brand of the shoe
        public int numberoforders = 40; // number of the shoe you want
        public double percentindiscount = 12.50; // discount percent you will get
    }
    class Gaming
    {
        public bool gameryesorno = true || false; // do u play games?
        public int numberofgames = 4; // how many games do you play
        public string nameofthegame = "Knives Out, Call of Duty, PUBG Mobile, Mobile Legends"; // name of the game you play
        public int playedforhowlong = 25; // months 
    }
    class Car
    {
        public bool ownacar = true || false; //yes or no
        public string brand = "Hyundai"; // type of car
        public int owninyears = 6; //how many yeah have u owned it
    }
}
