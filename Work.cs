﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
	class Work
	{

        public int Salary { get; set; }

        public string JobTitle { get; set; }

        public boolean IsLate { get; set; }

        public WorkDay(int salary, string jobTitle, Boolean isLate)
		{
            this.Salary = salary;
            this.JobTitle = jobTitle;
            this.IsLate = IsLate;
		}

		public void WorkStart(Work job, player person)
        {
			switch (job.jobTitle)
            {
                case "Uber":
                    uberJob(job, person);
                    break;
                case "Monop":
                    monopJob(job, person);
                    break;
                case "Metro":
                    metroJob(job, person);
                    break;
                default:
                    unemployed(person);
                    break;
            }
        }

        public void uberJob(Work uber, player person)
        {
            person.money = person.money + uber.Salary
        }

        public void monopJob(Work Monop, player person)
        {

        }

        public void metroJob(Work metro, player person)
        {

        }

        public void unemployed(player person)
        {
            int hours = 8;
            while (hours > 0)
            {

                Boolean correctResponse = false;
                string answer = "";
                Console.WriteLine("Another day at home.... Only {0} hours left", hours.ToString);
                System.Threading.Thread.Sleep(2000);
                person.Depression = person.Depression + 10;
                while(correctResponse = false)
                {
                    Console.WriteLine("You can either {0}A) Find New Job {0}B) Smoke weed and chill {0}C) Meet friends", Environment.NewLine);
                    answer = Console.ReadLine;
                    if(answer.ToUpper =! "A" && answer.ToUpper =! "B" && answer.ToUpper =! "C")
                    {
                        Console.WriteLine("Please type the corresponding letter e.g 'A'");
                        correctResponse = false;
                    }
                    else
                    {
                        correctResponse = true;
                    }
                }
                switch(answer.ToUpper)
                {
                    case ("A"):
                        jobOffer(person);

                    case ("B"):
                        smokeChill(person);

                    case ("C"):
                        meetFriends(person);
                }
                
                
            }
        }

        public void jobOffer(player person)
        {
            string answer = "";
            while (correctResponse = false)
            {
                Console.WriteLine("You can either {0}A) Work for Uber {0}B) Work For Monop {0}C) Work for Metro", Environment.NewLine);
                answer = Console.ReadLine;
                if (answer.ToUpper = !"A" && answer.ToUpper = !"B" && answer.ToUpper = !"C")
                {
                    Console.WriteLine("Please type the corresponding letter e.g 'A'");
                    correctResponse = false;
                }
                else
                {
                    correctResponse = true;
                }
            }

            int rnd = Random.next(500);
            int choice = (rnd + person.Depression) - player.Health;
            
            if (choice <= 250)
            {
                switch (answer.ToUpper)
                {
                    // Add function to fight interviewer, if you win yoyu get job
                    case ("A"):

                    case ("B"):

                    case ("C"):

                }
            }
            else
            {
                Console.WriteLine("You were unsuccesful");
                person.Depression = person.Depression - 10;
                return person;
            }
            
        }

        public void smokeChill (player person)
        {

        }

        public void meetFriends (player person)
        {

        }
    }
}


