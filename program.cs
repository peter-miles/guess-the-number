using System;
using System.Collections.Generic;

namespace guess_the_number {
    class program {
        static void Main(string[] args) {
            Random rand = new Random();
            int correct_num = rand.Next(0, 26); // generate random number to guess
            List<int> log = new List<int>();

            Console.WriteLine("Hey there! Lets play a little guessing game.");
            Console.WriteLine("Guess the number between 0 and 25");

            for (int i = 0; i < 7; i ++) {
                Console.Write("Enter Guess: ");
                string input = Console.ReadLine(); // get input
                int guess = int.Parse(input); // convert user input to int
                log.Add(guess); // add guess to log

                if (guess == correct_num) {
                    Console.WriteLine("Damn. You win!");
                    Console.WriteLine("The number was indeed {0}", correct_num); // display correct number
                    Console.WriteLine("You guessed in {0} guesses", (i + 1)); // show how many guesses it took the user to get
                    Console.WriteLine("Your guess log:");
                    print_log(log); // print log
                    return;
                } else if (guess > correct_num) {
                    Console.WriteLine("Nope, its less than that");
                    Console.WriteLine("You have {0} guesses left!", 6 - i); // show how many guesses are left
                } else if (guess < correct_num) {
                    Console.WriteLine("Nope, its greater than that");
                    Console.WriteLine("You have {0} guesses left!", 6 - i);
                }
            }

            Console.WriteLine("AHAHAHAH YOU LOOSE!");
            Console.WriteLine("The number was {0} you fool.", correct_num);
            Console.WriteLine("Your guess log:");
            print_log(log);
            return;
        }

        static public void print_log(List<int> log) {
            Console.Write("[");
            foreach (int i in log) {
                Console.Write(i + (i == log[log.Count - 1] ? "" : ", ")); // if last number is equal to last number in list dont print a comma
            }
            Console.WriteLine("]");
        }
    }
}
