/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;



namespace metsastaja_harkka

{
    abstract class Character

    {

        protected string name = "Esko";

        protected double speed;

        protected double luck;



        public void SetName()

        {

            Console.WriteLine("Mikä on nimesi?");

            name = Console.ReadLine().Trim();

        }

        public string GetName()

        {

            Console.WriteLine($"Pelihahmo {name}");

            return name;

        }

        public void SetSpeed(double speedvalue)

        {

            speed = speedvalue;

        }

        public double GetSpeed()

        {

            Console.WriteLine($"Nopeutesi on {speed}/100");

            return speed;

        }

        public void SetLuck(double luckvalue)

        {

            luck = luckvalue;

        }

        public double GetLuck()

        {

            Console.WriteLine($"Onnesi on {luck}/100");

            return luck;

        }

    }

}
