using System;
using System.Collections.Generic;

namespace InheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Horse("Horse",56.67,12,true));
            animals.Add(new Dog("Dog",12.56,8,"BullDog"));
            animals.Add(new Hedgehog("Hedgehog",13.45,10,5000));
            animals.Add(new Worm("Worm",1.2,1,false));
            animals.Add(new Bird("Bird",3.5,2,14.67));
            animals.Add(new Pelican("Pelican",23.5, 21,45.78,12.56));
            animals.Add(new Flamengo("Flamengo",23.5,21,45.78,12.56));
            animals.Add(new Swan("Swan",23.5,21,45.78,true));
            animals.Add(new Wolf("Wolf", 23.5, 21, true));
            animals.Add(new WolfMan("WolfMan",23.5,23,true));

            //Polymorphism 3.2) ARV 
            //Fråga 13: Vi bör lägga det i klassen bird klassen
            //Fråga 14: Vi bör lägga det i baseklassen Animal

            foreach (var animal in animals)
            {
                animal.DoSound();
                if(animal is IPerson)
                {                
                    IPerson pp = animal as IPerson;
                    pp.Talk();
                }

                //Polymorphism 3.3)Polymorfism  
                List<Dog> dogs = new List<Dog>();
                //Fråga 9 F:  dogs.Add(new Horse("Horse", 56.67, 12, true)); 
                //Svar: Cannot för att they are olika typer
                //Fråga 10 F: svar: Listan måste ha typen Animals


                //Fråga 11
                Console.WriteLine(animal.Stats());
                //Fråga 12 och 13 F Testa och se så det fungerar:
                //Programmet loopar igenom listan och kör den overriden Stats() metoden för varje djur. 
                //Kompilatorn bestämmer vilken metod som ska anropas vid körning (Runtime). 
                //Det är där polymorfism träder i kraft. 


                //Polymorphism 3.3 
                //Fråga 14:
                if (animal is Dog) 
                {
                    Console.WriteLine(animal.Stats());
                }

                //Frågan 16:kan inte komma  till metoden FreeChoice() vid animal 
                //Frågan 17: För att metoden hörer bara till Dog
                //Frågan 18: Jag gör en kast
                if (animal is Dog dog)
                {
                    dog.FreeChoice();
                    Dog d = (Dog)animal;
                    d.FreeChoice();
                }
            }


            // Polymorphism 3.4
            List<UseError> errors = new List<UseError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new SyntaxError());
            errors.Add(new FormatException());
            errors.Add(new TypeException());

            foreach (var err in errors)
            {
                Console.WriteLine(err.UEMessage());

            }

            //Fråga 11:Det är viktigt att behårska Polymorfism för att
            //det hjälper programmeraren att använda koderna som redan finns
            //och är testad. Programmeraren sparar mycket tid. Tänk på det här scenariot
            //var listan "animals" innehåller olika djur. Vi kan nu loopa runt alla djur i Kollectionen
            //och säger till varje djur objekt på listan till att anropa deras Stats metoden.
            // Om vi har 100 djur på listen, kommer vi inte att skriva funktioner 100 gång. 
            //Vi undvikar att skriva DogStats(), BirdStats(), etc.. funktion separat.etc../. 
            //Det är svårt att felsöka koderna och gör ändringarna. Det är svårt 
            //att rätta fel i koderna när vi inte har polymorfism.  
            //Polymorfism handlar om hur programmet bestämmer vilka metoder
            //det ska använda, beroende på vilken typ av sak det har. 
            //För att förstå polymorfism, you måste också förstå arv and interfaces.

            //Fråga 12:
            //Polymorfism minskar duplicering av kod när du vill att samma 
            //handlingar ska utföras på olika typer av objekt. Detta vill förbättra
            //systemets struktur. Det kan förenkla våra koder. 

            //Fråga 13:
            //Abstrakta klasser kan ha implementeringar för några av dess 
            //medlemmar, men gränssnitt kan inte ha implementeringar av någon
            //av dess medlemmar. Gränssnitt kan inte ha fält medan en abstrakt 
            //klass kan ha fält. Gränssnitt kan bara ärva från ett annat 
            //gränssnitt och kan inte ärva från en abstrakt klass medan en 
            //abstrakt klass kan ärva från en annan abstrakt klass eller ett
            //annat gränssnitt. Abstrakta klassmedlemmar kan ha 
            // "access modifiers" medan gränssnittsmedlemmar inte kan ha 
            //"access modifiers".

        }
    }
}
