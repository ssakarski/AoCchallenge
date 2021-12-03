using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace TestingGit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1 of Advent of Code !!!
            // string[] depth = File.ReadAllLines(@"C:\Users\User\source\repos\TestingGit\TestInputs\depthInput.txt");
            // depthCount(depth);

            // Day 2 of Advent of Code !!!
            // string[] movement = File.ReadAllLines(@"C:\Users\User\source\repos\TestingGit\TestInputs\submarineMovement.txt");
            // submarineMovement(movement);
            // Day 3 of Advent of Code !!!  D:\Users\User\Desktop\testInputs.txt    C:\Users\User\source\repos\TestingGit\TestInputs\binDiagnostic.txt
            string[] binDiagnostic = File.ReadAllLines(@"C:\Users\User\source\repos\TestingGit\TestInputs\binDiagnostic.txt");
            binaryDiagnostic(binDiagnostic);
        }

        static void binaryDiagnostic(string[] bin)
        {
            string currentBitLine = "";
            int[] currentBitCount = new int[bin[0].Length];
            string gammaRate = "";
            string epsilonRate = "";
            // Finding the most common bits
            for (int i = 0; i < bin.Length; i++)
            {
                currentBitLine = bin[i];
                for (int j = 0; j < bin[i].Length; j++)
                {
                    if (currentBitLine[j] == '1')
                    {
                        currentBitCount[j] += 1;
                    }
                }
            }
            // Finding the gamma and epsilon rates
            for (int i = 0; i < currentBitCount.Length; i++)
            {
                if (currentBitCount[i] < bin.Length/2)
                {
                    gammaRate += "0";
                    epsilonRate += "1";
                }
                else
                {
                    gammaRate += "1";
                    epsilonRate += "0";
                }
            }
            int decimalGammaRate = Convert.ToInt32(gammaRate, 2);
            int decimalEpsilonRate = Convert.ToInt32(epsilonRate, 2);
            Console.WriteLine(decimalGammaRate*decimalEpsilonRate);
        }
        static void submarineMovement(string[] mov)
        {
            int forward = 0;
            int depth = 0;
            int aim = 0;
            string[] test = new string[2];
            for (int i = 0; i < mov.Length; i++)
            {
                test = mov[i].Split(" ");
                switch (test[0])
                {
                    case "forward": 
                        { 
                            forward += int.Parse(test[1]);
                            depth = depth+(aim*int.Parse(test[1]));
                            break;
                        }
                    case "up": 
                        {
                            aim -= int.Parse(test[1]);
                            break;
                        }
                    default:
                        {
                            aim += int.Parse(test[1]);
                            break;
                        }
                }
            }
            Console.WriteLine("forward: "+forward);
            Console.WriteLine("depth: " + depth);
            Console.WriteLine("aim: " + aim);
            Console.WriteLine("distance: {0}",depth * forward);
        }
        static void depthCount(string[] depth)
        {
            /*  Test input
                199
                200
                208
                210
                200
                207
                240
                269
                260
                263
                Test output
                7
            */
            int[] d = Array.ConvertAll(depth, item => int.Parse(item));
            int[] depthHolder = new int[d.Length - 2];
            int firstSum = 0;
            int counter = 0;
            for (int i = 0; i < d.Length - 2; i++)
            {
                firstSum = d[i] + d[i + 1] + d[i + 2];
                depthHolder[i] = firstSum;
            }
            for (int i = 0; i < depthHolder.Length - 1; i++)
            {
                if (depthHolder[i] < depthHolder[i + 1])
                {
                    counter += 1;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
