using System.Collections.Generic;
using System.ComponentModel;

namespace SortingHat
{
    public enum Houses
    {
        Gryffindor = 0,
        Hufflepuff = 1,
        Slytherin = 2,
        Ravenclaw = 3,
        None,
    }
    public class SortingHat
    {
        public HouseInfo[] Houses;
        public HashSet<Student> Students;

        public SortingHat(HouseInfo[] houses, HashSet<Student> students)
        {
            Houses = houses;
            Students = students;
        }

        public void ProcessAssignments()
        {
            //TODO
        }
    }
}