/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;

using System.Media;



namespace metsastaja_harkka

{
    class Hunter : Human

    {

        public void MetsastajaHurt()

        {

            if (OperatingSystem.IsWindows())

            {

                SoundPlayer Noises = new SoundPlayer("hunter.wav");

                Noises.Load();

                Noises.Play();

            }

            Console.WriteLine("Urgh!");

        }

    }

}
