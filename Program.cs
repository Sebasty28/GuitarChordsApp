
using System;
using System.Reflection;

namespace GuitarChordApp
{

    class Program
    {
        //user's input
        static int userChoice;
        static string userChordName;
        static string userChordType;
        static string userChordNotes;

        //storage
        static string[] chordName = new string[4];
        static string[] chordType = new string[4];
        static string[] chordNotes = new string[4];

        static int chordSize = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Guitar Chord Application\n");
            Console.WriteLine("-- Guideline --\n");
            Console.WriteLine("Chord Name: C Major\n" + "Chord Type: Major\n" + "Chord Diagram: C-E-G\n");
            Console.WriteLine("[1] Add Chord");
            Console.WriteLine("[2] Edit Chord");
            Console.WriteLine("[3] View Chord");
            Console.WriteLine("[4] Exit");

            while (true)
            {
                Console.Write("Choose Action: ");
                userChoice = Convert.ToInt16(Console.ReadLine());

                if (userChoice == 1)
                {
                    AddChord();
                }
                else if (userChoice == 2)
                {
                    EditChord();
                }
                else if (userChoice == 3)
                {
                    ViewChords();
                }
                else
                {
                    break;
                }
            }

        }

        static void AddChord()
        {
            if (chordSize >= chordName.Length)
            {
                Console.WriteLine("Chord storage is full!");
                return;
            }

            Console.Write("Enter the Chord Name: ");
            chordName[chordSize] = Console.ReadLine();

            Console.Write("Enter the Chord Type: ");
            chordType[chordSize] = Console.ReadLine();

            Console.Write("Enter the Chord Notes or Diagram: ");
            chordNotes[chordSize] = Console.ReadLine();

            Console.WriteLine("New Chord Acquired!");
            chordSize++;
        }

        static void EditChord()
        {
            ViewChords();
            Console.Write("Choose a Chord to Edit: ");
            string userUpdate = Console.ReadLine();
            int num = -1;

            for (int i = 0; i < chordSize; i++)
            {
                if (chordName[i] == userUpdate)
                {
                    num = i;
                    break;
                }
            }

            if (num == -1)
            {
                Console.WriteLine("Chord not found!");
                return;
            }

            Console.Write("Update the Chord Name: ");
            chordName[num] = Console.ReadLine();

            Console.Write("Update the Chord Type: ");
            chordType[num] = Console.ReadLine();

            Console.Write("Update the Chord Notes or Diagram: ");
            chordNotes[num] = Console.ReadLine();

            Console.WriteLine("Chord Updated!");
        }

        static void ViewChords()
        {
            Console.WriteLine("Acquired Chords: ");
            for (int i = 0; i < chordSize; i++)
            {
                Console.WriteLine(i + 1 + ". " + chordName[i] + " - " + chordType[i] + " - " + chordNotes[i]);
            }
        }

    }

}