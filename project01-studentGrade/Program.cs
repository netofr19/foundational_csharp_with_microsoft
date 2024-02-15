using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_firstProject_studentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] gradSophia = {93, 87, 98, 95, 100};
           int[] gradNicolas = {80, 83, 82, 88, 85};
           int[] gradZahirah = {84, 96, 73, 85, 79};
           int[] gradJeong = {90, 92, 98, 100, 97};

           int sumSophia = 0;
           int sumNicolas = 0;
           int sumZahirah = 0;
           int sumJeong = 0;

            // Cálculo do total das notas para cada aluno
           for (int i = 0; i < gradSophia.Length; i++)
           {
                sumSophia += gradSophia[i];
                sumNicolas += gradNicolas[i];
                sumZahirah += gradZahirah[i];
                sumJeong += gradJeong[i];
           }

           Console.WriteLine($"Total Sophia: {sumSophia}");
           Console.WriteLine($"Total Nicolas: {sumNicolas}");
           Console.WriteLine($"Total Zahirah: {sumZahirah}");
           Console.WriteLine($"Total Jeong: {sumJeong}\n");

            // Cálculo das médias para cada aluno
            double meanSophia;
            double meanNicolas;
            double meanZahirah;
            double meanJeong;

            meanSophia = (double)sumSophia / gradSophia.Length;
            meanNicolas = (double)sumNicolas / gradNicolas.Length;
            meanZahirah = (double)sumZahirah / gradZahirah.Length;
            meanJeong = (double)sumJeong / gradJeong.Length;

            double[] means = {meanSophia, meanNicolas, meanZahirah, meanJeong};

            string[] scale = {"X","X","X","X"};

            // Definição das escalas de notas
            for (int i = 0; i < means.Length; i++)
            {
                if (means[i] >=97 && means[i]<=100)
                {
                    scale[i] = "A+";
                } 
                else if (means[i] >=93 && means[i] <=96)
                {
                    scale[i] = "A";
                }
                else if (means[i] >=90 && means[i] <=92)
                {
                    scale[i] = "A-";
                }
                else if (means[i] >=87 && means[i] <=89)
                {
                    scale[i] = "B+";
                }
                else
                {
                    scale[i] = "B";
                }
                
            }

            Console.WriteLine("Student\tScore\tGrade");

           Console.WriteLine($"Sophia:\t {meanSophia} \t{scale[0]}");
           Console.WriteLine($"Nicolas: {meanNicolas} \t{scale[1]}");
           Console.WriteLine($"Zahirah: {meanZahirah} \t{scale[2]}");
           Console.WriteLine($"Jeong:\t {meanJeong} \t{scale[3]}\n");
        }
    }
}

