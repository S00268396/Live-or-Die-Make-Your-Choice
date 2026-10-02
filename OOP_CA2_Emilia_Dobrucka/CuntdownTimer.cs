using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_CA2_Emilia_Dobrucka
{
    public class CuntdownTimer
    {
        // I has use AL in this part after trying to do it on my own few times
        //The second that are left 
        private int _seconds;

        //Using the bool to stop the timer
        private bool _stop = false; 

        //Get the number of seconds
        public CuntdownTimer(int seconds)
        {
            _seconds = seconds;
        }

        //This method is call to stop the countdown early
        public void Stop()
        {
            _stop = true;
        }

        //Start the countdown in the background thread
        public void Start()
        {
            new Thread(() =>
            {
                //Loop until the time runs or user enter their decision
                while (_seconds >= 0 && !_stop)
                {
                    //It save the user's current positon 
                    int savedLeft = Console.CursorLeft;
                    int savedTop = Console.CursorTop;
                    
                    //Make sure that the timer prints out in the same place
                    Console.SetCursorPosition(0, 0);

                    //Display the time the user have
                    Console.Write($"Time Left: {TimeSpan.FromSeconds(_seconds):mm\\:ss}   ");

                    // Restore user original location
                    Console.SetCursorPosition(savedLeft, savedTop);

                    //Wait for 1 second
                    Thread.Sleep(1000);
                    _seconds--;
                }
                //If the timer run out, it show this message
                if (!_stop)
                {
                    //It save the user's current positon 

                    int savedLeft = Console.CursorLeft;
                    int savedTop = Console.CursorTop;

                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Time is up!");
                }
            })
            {
                //Make the thread run in the background thread
                IsBackground = true
            }.Start();// Start the thread
        }

    }
    
}
