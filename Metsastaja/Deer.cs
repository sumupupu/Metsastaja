/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;

using System.Media;



namespace metsastaja_harkka

{
    class Deer : Animal

    {

        public void DeerHurt()

        {

            if (OperatingSystem.IsWindows())

            {

                SoundPlayer Noises = new SoundPlayer("peura.wav");

                Noises.Load();

                Noises.Play();

            }

            Console.WriteLine("Möö!");

        }

        public void Kick()

        {

            Console.WriteLine("Peura potkaisee sinua. Jatkat matkaasi haavoittuneena");

        }

        public void Hide()

        {

            Console.WriteLine("Et osunut ja peura juoksi piiloon");

        }

    }

}
