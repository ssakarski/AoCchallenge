using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;

namespace TestingGit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1 of Advent of Code !!!
            // string[] depth = File.ReadAllLines(@"..\..\..\TestInputs\depthInput.txt");
            // AocChallenge.depthCount(depth);

            // Day 2 of Advent of Code !!!
            // string[] movement = File.ReadAllLines(@"..\..\..\TestInputs\submarineMovement.txt");
            // AocChallenge.submarineMovement(movement);

            // Day 3 of Advent of Code !!!  D:\Users\User\Desktop\testInputs.txt    @"..\..\..\TestInputs\binDiagnostic.txt"
               string[] binDiagnostic = File.ReadAllLines(@"..\..\..\TestInputs\binDiagnostic.txt");
               AocChallenge.binaryDiagnostic(binDiagnostic);
        }
    }
}
