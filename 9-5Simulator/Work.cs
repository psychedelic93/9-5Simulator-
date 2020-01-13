using System;
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

        public bool IsLate { get; set; }

        public Work(int salary, string jobTitle, Boolean isLate)
		{
            this.Salary = salary;
            this.JobTitle = jobTitle;
            this.IsLate = IsLate;
		}

		public void WorkStart(Work job, Player user)
        {
			switch (job.JobTitle)
            {
                case "Uber":
                    uberJob(job, user);
                    break;
                case "Monop":
                    monopJob(job, user);
                    break;
                case "Metro":
                    metroJob(job, user);
                    break;
                default:
                    unemployed(user);
                    break;
            }
        }

        public void uberJob(Work uber, Player person)
        {
            person.Money = person.Money + uber.Salary;
        }

        public void monopJob(Work Monop, Player person)
        {

        }

        public void metroJob(Work metro, Player person)
        {

        }

        public void unemployed(Player person)
        {
            int hours = 8;
            while (hours > 0)
            {

                bool correctResponse = false;
                string answer = "";
                Console.WriteLine("Another day at home.... Only {0} hours left", hours.ToString());
                System.Threading.Thread.Sleep(2000);
                person.Depression = person.Depression + 10;
                while(correctResponse == false)
                {
                    Console.WriteLine("You can either {0}A) Find New Job {0}B) Smoke weed and chill {0}C) Meet friends", Environment.NewLine);
                    answer = Console.ReadLine();
                    if(answer.ToUpper() != "A" && answer.ToUpper() != "B" && answer.ToUpper() != "C")
                    {
                        Console.WriteLine("Please type the corresponding letter e.g 'A'");
                        correctResponse = false;
                    }
                    else
                    {
                        correctResponse = true;
                    }
                }
                switch(answer.ToUpper())
                {
                    case ("A"):
                        Console.WriteLine("You have decided to find a job");
                        jobOffer(person);
                        break;

                    case ("B"):
                        smokeChill(person);
                        break;

                    case ("C"):
                        meetFriends(person);
                        break;
                }
                
                
            }
        }

        public Player jobOffer(Player person)
        {
            string answer = "";
            bool correctResponse = false;
            while (correctResponse == false)
            {
                Console.WriteLine("You can either {0}A) Work for Uber {0}B) Work For Monop {0}C) Work for Metro", Environment.NewLine);
                answer = Console.ReadLine();
                if (answer.ToUpper() != "A" && answer.ToUpper() != "B" && answer.ToUpper() != "C")
                {
                    Console.WriteLine("Please type the corresponding letter e.g 'A'");
                    correctResponse = false;
                }
                else
                {
                    correctResponse = true;
                }
            }

            Random rnd = new Random();
            int choice = (rnd.Next(500) + person.Depression) - person.Health;
            
            if (choice <= 250)
            {
                switch (answer.ToUpper())
                {
                    // Add function to fight interviewer, if you win you get job
                    case ("A"):
                        Console.WriteLine("When you arrive, you find that the interviewer is ready to fight!");
                        Enemy UberInter = new Enemy("Terrence", 1, 100, 15);
                        Event.CombatLoop(person, UberInter);
                        if
                        break;

                    case ("B"):
                        break;

                    case ("C"):
                        break;

                }
            }
            else
            {
                Console.WriteLine("You were unsuccesful");
                person.Depression = person.Depression - 10;
            }

            return person;
        }

        public void smokeChill (Player person)
        {

        }

        public void meetFriends (Player person)
        {

        }
    }
}


