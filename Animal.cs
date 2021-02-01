using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    abstract class Animal
    {
      
        //Vi bör det lägga i Animal class 
        private string name;
        private double weight;
        private int age;

        public virtual string Stats()
        {
            return $"{name}, {weight}, {age}";
        }


    public abstract void DoSound();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public double Weight
        {
            get { return weight; }
            set {weight = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Animal(string name,double weight,int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

    }

  class Horse : Animal
    {
        public bool IsRaceActive { get; set; }
        public Horse(string name,double weight,int age, bool isRaceActive) : base(name,weight,age)
        {
            IsRaceActive = isRaceActive;
        }


        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + ","+ this.IsRaceActive;
            return temp2;
        }

        public override void DoSound()
        {
            Console.WriteLine("The horse is neighing");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, double weight, int age,string breed) : base(name, weight, age)
        {
            Breed = breed;
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + ", "+this.Breed;
            return temp2;
        }

        public override void DoSound()
        {
            Console.WriteLine("The dog is barking");
        }

        //Frågan 15 på Polymorism 3.3
        public string FreeChoice()
        {
            return "I am a beatiful dog";
        }

     
    }

    class Hedgehog : Animal
    {

        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + this.NrOfSpikes;
            return temp2;
        }

        public override void DoSound()
        {
            Console.WriteLine("A hedgehog makes this aggressive sound ");
        }
    }


    class Worm : Animal
    {

        public bool IsPoisonous { get; set; }

        public Worm (string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }


        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + ", "+this.IsPoisonous;
            return temp2;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm also make a loud popping noise that sounds like a champagne cork");
        }
    }

    class Bird : Animal
    {
        //--13 F:
        //Vi bör det lägga i Bird class 
        
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double winSpan) : base(name, weight, age)
        {
            WingSpan = winSpan;
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + this.WingSpan;
            return temp2;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird is tweeting");
        }
    }

    class Wolf : Animal
    {
        public bool IsDomesticated { get; set; }

        public Wolf(string name, double weight, int age, bool isDomesticated) : base(name, weight, age)
        {
            IsDomesticated = isDomesticated;
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + ", "+ this.IsDomesticated;
            return temp2;
        }

        public override void DoSound()
        {
            Console.WriteLine("The wolf is barking");
        }
    }

    class Pelican : Bird
    {
        public double BeakLength { get; set; }
        public Pelican(string name, double weight, int age, double winSpan,double beakLength) : base(name, weight, age, winSpan)
        {
            BeakLength = beakLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("The Pelican is rumbling");
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + this.WingSpan;
            return temp2;
        }


    }
    class Flamengo : Bird
    {
        public double LegsLength { get; set; }
        public Flamengo(string name, double weight, int age, double winSpan,double legsLength) : base(name, weight, age, winSpan)
        {
            LegsLength = legsLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("The Flamengo is growling");
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + this.WingSpan;
            return temp2;
        }

    }

    class Swan : Bird
    {
        public bool IsAggressive { get; set; }
        public Swan(string name, double weight, int age, double winSpan, bool isAggressive) : base(name, weight, age, winSpan)
        {
            IsAggressive = isAggressive;
        }

        public override void DoSound()
        {
            Console.WriteLine("The Swan is whistling");
        }

        public override string Stats()
        {
            var temp = base.Stats();
            var temp2 = temp + ", "+this.IsAggressive;
            return temp2;
        }
    }

    public interface IPerson
    { 
        public abstract void Talk();
    }


    abstract class UseError
    {

        public abstract string UEMessage();
    }


    class NumericInputError: UseError
    {

        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";

        }

    }


    class TextInputError : UseError
    {


        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field.This fired an error!";

        }
    }

    class SyntaxError: UseError
    {
        public override string UEMessage()
        {
            return "Wrong C# syntax";
        }
    }

    class FormatException : UseError
    {

        public override string UEMessage()
        {
            return "Wrong format for this input";
        }
    }

    class TypeException : UseError
    {

        public override string UEMessage()
        {
            return "This object is not an animal type";
        }
    }
}
