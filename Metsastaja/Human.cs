/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;

using System.Media;



namespace metsastaja_harkka

{
    abstract class Human : Character

    {

        //NAME from character 

        //SPEED from character 

        //LUCK from character 

        //HURT from character 

        protected string weapon = "haulikko";

        protected string prey = "peura";

        protected double weaponStrength = 60;

        protected double accuracy = 35;

        //protected const string shoot = "Bang"; 



        public void SetWeapon()

        {

            Console.Write($"Valitsetko metsästysretkelle (H)aulikon vai (J)ousipyssyn? : ");

            string input = Console.ReadLine().Trim().ToLower();



            switch (input)

            {

                case "h":

                    Console.WriteLine($"Haulikko valittu.");

                    weapon = "haulikko";

                    weaponStrength = 60;

                    accuracy = 35;

                    break;

                case "j":

                    Console.WriteLine("Jousipyssy valittu.");

                    weapon = "jousipyssy";

                    weaponStrength = 25;

                    accuracy = 55;

                    break;

                default:

                    Console.WriteLine("Valintaa ei tunnistettu. Nyrkki valittu.");

                    weapon = "nyrkki";

                    weaponStrength = 10;

                    accuracy = 50;

                    break;

            }

        }



        public string GetWeapon()

        {

            Console.WriteLine($"Sinulla on {weapon}");

            return weapon;

        }

        public void SetPrey()

        {

            Console.Write($"Haluatko metsästää (P)euroja vai (A)nkkoja?: ");

            string input = Console.ReadLine().Trim().ToLower();



            switch (input)

            {

                case "p":

                    Console.WriteLine($"Saaliiksesi valitsit peuran.");

                    prey = "peura";

                    break;

                case "a":

                    Console.WriteLine("Saaliiksesi valitsit ankan.");

                    prey = "ankka";

                    break;

                default:

                    Console.WriteLine("Valintaa ei tunnistettu. Poro valittu.");

                    prey = "poro";

                    break;

            }

        }

        public string GetPrey()

        {

            Console.WriteLine($"Saaliseläin {prey}");

            return prey;

        }

        public double GetWeaponStrength()

        {

            Console.WriteLine($"Aseen voima on {weaponStrength}/100");

            return weaponStrength;

        }

        public void SetAccuracy(double accuracyvalue)

        {

            accuracy = accuracyvalue;

        }

        public double GetAccuracy()

        {

            Console.WriteLine($"Tarkkuutesi on {accuracy}/100");

            return accuracy;

        }

        public void Shot()

        {

            if (weapon == "haulikko" && OperatingSystem.IsWindows())

            {

                Console.ReadLine();

                SoundPlayer Noises = new SoundPlayer("haulikko.wav");

                Noises.Load();

                Noises.Play();

            }

            else if (weapon == "jousipyssy" && OperatingSystem.IsWindows())

            {

                SoundPlayer Noises = new SoundPlayer("nuoli.wav");

                Noises.Load();

                Noises.Play();

            }

            Console.WriteLine("Ammuit aseella");

        }

    }

}
