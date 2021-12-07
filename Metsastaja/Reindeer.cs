/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;

using System.Media;



namespace metsastaja_harkka

{
    class Reindeer : Animal

    {

        public void ReindeerHurt()

        {

            if (OperatingSystem.IsWindows())

            {

                SoundPlayer Noises = new SoundPlayer("poro.wav");

                Noises.Load();

                Noises.Play();

            }

            //Console.WriteLine("Argh!"); 

        }

        public void Fly()

        {

            Console.WriteLine("Poro väistää ammuksesi ja lentää pois.");

        }

    }

}
