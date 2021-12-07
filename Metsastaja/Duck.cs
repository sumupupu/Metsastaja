/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;

using System.Media;



namespace metsastaja_harkka

{
    class Duck : Animal

    {

        public void DuckHurt()

        {

            if (OperatingSystem.IsWindows())

            {

                SoundPlayer Noises = new SoundPlayer("ankka.wav");

                Noises.Load();

                Noises.Play();

            }

            Console.WriteLine("Kääk!");

        }

        public void Heristys()

        {

            Console.WriteLine("Ankka heristää sinulle nyrkkiään ja lentää sitten sinua päin ennen kuin katoaa.");

        }

        public void Swim()

        {

            Console.WriteLine("Ankka hyppää lampeen ja ui karkuun.");

        }

    }

}
