using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;

namespace SortingHat
{
    public class HouseInfo
    {
        public int number_of_students;
        public int[] coefficients = new int[8];
        public int sum;
        public List<Student> ranking = new List<Student>();

        
        public HouseInfo(string input)
        {
            string[] arr = new string[9];
            arr = input.Split();
            number_of_students = Int32.Parse(arr[0]);
            for (int i = 0; i < 8; i++)
            {
                coefficients[i] = Int32.Parse(arr[i+1]);
                sum += Int32.Parse(arr[i+1]);
                if (Int32.Parse(arr[i+1]) < 0) throw new InvalidDataException("Coeffients must be positive");
            }
            if (sum == 0) throw new InvalidDataException("Sum of coefficients cannot be equal to zero");
        }

        private double GetAverage(Student student)
        {
            int[] notes = student.grades;
            double average = 0;
            foreach (int note in notes)
            {
                average += note;
            }
            return average;
        }

        public void tri(double[] array) //fonction qui sert a trier un tableau dans l'ordre décroissant
        {
            double x;
            int t = array.Length - 1;
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {

                    if (array[j] < array[j+1])
                    {
                        x = array[j + 1];
                        array[j+1] = array[j];
                        array[j]=x;
                    }
                }
            }
        }

        public void RankStudents(HashSet<Student> students)
        {
            int cpt = 0;
            double[] moyennes = new double[students.Count];
            foreach (var student in students)
            {
                moyennes[cpt] = GetAverage(student);
            }
            tri(moyennes);
        }
    }
}