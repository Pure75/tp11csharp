using System;
using System.Collections.Generic;
using System.IO;

namespace SortingHat
{
    public class Student
    {
        public int[] grades = new int[8];
        public Houses[] preferences = new Houses[4];
        public string name;
        public Houses assignement;
        
        public Student(string input)
        {
            string[] list = input.Split();
            name = list[0];
            for (int i = 0; i < 4; i++)
            {
                int school = Int32.Parse(list[i+1]);
                switch (school)
                {
                    case 0:
                        preferences[i] = Houses.Gryffindor;
                        break;
                    case 1:
                        preferences[i] = Houses.Hufflepuff;
                        break;
                    case 2:
                        preferences[i] = Houses.Slytherin;
                        break;
                    case 3:
                        preferences[i] = Houses.Ravenclaw;
                        break;
                    default:
                        preferences[i] = Houses.None;
                        break;
                }
            }
            int cpt = 5;
            for (int j = 0; j < 8; j++)
            {
                grades[j] = Int32.Parse(list[cpt]);
                cpt++;
                if (Int32.Parse(list[cpt]) < 0) throw new InvalidDataException("Grades must be positive");
            }
        }
    }
}