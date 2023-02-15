using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class Farm
    {
        public Animal[] Animals;
        public void AddAnimal(Animal animal)
        {
            if (animal is Horse)
            {
                Horse horse = (Horse)animal;
                if (horse.Country!="Ingiltere")
                    throw new Exception("Country deyeri ingiltere olmalidir")
                

                
            }
            Array.Resize(ref Animals, Animals.Length + 1);
            Animals[Animals.Length - 1] = animal;
        }
        public int GetSheepCount()
        {


            int count = 0;
            foreach (var item in Animals)
            {
                if (item is Sheep)
                    count++;
            }
            return count;
        }
        public int GetHorseCount()
        {
            int count = 0;
            foreach (var item in Animals)
            {
                if (item is Horse)
                    count++;
            }
            return count;
        }
        public int GetAnimalCount()
        {
            int count = 0;
            foreach (var item in Animals)
            {
                if (item is Animal)
                    count++;
            }
            return count;
        }
    }
}
