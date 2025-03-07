
using System;
using System.Reflection;

namespace GuitarChordApp
{

    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("Guitar Chord Application");
            Console.WriteLine("[1] Add Chord");
            Console.WriteLine("[2] Edit Chord");
            Console.WriteLine("[3] View Chord");
            Console.WriteLine("[4] Exit");

            //user's input
            int userChoice;
            string userChordName;
            string userChordType;
            string userChordNotes;

            //storage
            string[] chordName = new string[4];
            string[] chordType = new string[4];
            string[] chordNotes = new string[4];

            int chordSize = 0;

            bool loop = true;

            while (loop)
            {
                Console.Write("Choose Action: ");
                userChoice = Convert.ToInt16(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.Write("Enter the Chord Name: ");
                    userChordName = Console.ReadLine();
                    chordName[chordSize] = userChordName;

                    Console.Write("Enter the Chord Type: ");
                    userChordType = Console.ReadLine();
                    chordType[chordSize] = userChordType;

                    Console.Write("Enter the Chord Notes or Diagram: ");
                    userChordNotes = Console.ReadLine();
                    chordNotes[chordSize] = userChordNotes;

                    Console.WriteLine("New Chord Acquired!");
                    chordSize++;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Acquired Chords: ");
                    foreach (var chord in chordName)
                    {
                        Console.WriteLine(chord);
                    }

                    string userUpdate;

                    Console.Write("Choose a Chord: ");
                    userUpdate = Console.ReadLine();

                    int num = -1;

                    for (int i = 0; i < chordSize; i++)
                    {
                        if (chordName[i] == userUpdate)
                        {
                            num = i;
                            break;
                        }
                    }

                    Console.Write("Update the Chord Name: ");
                    userChordName = Console.ReadLine();
                    chordName[chordSize] = userChordName;

                    Console.Write("Update the Chord Type: ");
                    userChordType = Console.ReadLine();
                    chordType[chordSize] = userChordType;

                    Console.Write("Update the Chord Notes or Diagram: ");
                    userChordNotes = Console.ReadLine();
                    chordNotes[chordSize] = userChordNotes;

                    Console.WriteLine("Chord Updated!");
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Acquired Chords: ");
                    foreach (var chord in chordName)
                    {
                        Console.WriteLine(chord);
                    }
                }
                else
                {
                    break;
                }
            }

        }

    }

}