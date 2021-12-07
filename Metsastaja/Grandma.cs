/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;

using System.Media;



namespace metsastaja_harkka

{
    class Grandma : Human

    {

        public void MummoHurt()

        {

            if (OperatingSystem.IsWindows())

            {

                SoundPlayer Noises = new SoundPlayer("mummo.wav");

                Noises.Load();

                Noises.Play();

            }

            Console.WriteLine("Auts!");

        }



        public void Ampu()

        {

            Console.WriteLine("Mummo ampui sinua!");

        }

        public void CallPolice()

        {

            Console.WriteLine("Mummo soitti poliisille! \nPoliisit heittivät sinut putkaan.");

        }

    }

}
