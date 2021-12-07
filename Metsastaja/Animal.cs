/*Title: Metsästäjä

* Authors: Sari Tolonen ja Marja Tuhkanen 

*/



using System;



namespace metsastaja_harkka

{
    abstract class Animal : Character

    {

        //NAME from character 

        //SPEED from character 

        //LUCK from character 

        //HURT from character 



        public int GetRandomLocation()

        {

            Random random = new Random();

            int value = random.Next(3);

            return value;

        }

    }

}
