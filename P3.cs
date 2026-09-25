using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Collage
    {
        private string name;
        protected string uni_name;
        public string department;

        public Collage(string name, string uni_name, string department)
        {
            this.name = name;
            this.uni_name = uni_name;
            this.department = department;
        }

        public void DisplayName()
        {
            Console.WriteLine("Collage Name: " + name);

        }

        public void DisplayUniName()
        {
            Console.WriteLine("university Name: " + uni_name);

        }

        public void DisplayDepName()
        {
            Console.WriteLine("Department Name: " + department);

        }

        public void Display()
        {
            DisplayName();
            DisplayUniName();
            DisplayDepName();
        }

        //child class
        class SOE : Collage
        {
            private string Event_name;
            protected string Cost_of_event;
            public string co_ordinator_name;

            public SOE(string name, string uni_name, string department, string Event_name, string Cost_of_event, string co_ordinator_name)
                : base(name, uni_name, department)
            {
                this.Event_name = Event_name;
                this.Cost_of_event = Cost_of_event;
                this.co_ordinator_name = co_ordinator_name;
            }

            public void DisplayEventName()
            {
                Console.WriteLine("Event Name: " + Event_name);
            }

            public void DisplayCostOfEvent()
            {
                Console.WriteLine("Cost of Event: " + Cost_of_event);
            }

            public void DisplayCoordinatorName()
            {
                Console.WriteLine("Co-ordinator Name: " + co_ordinator_name);
            }

            public void DisplaySOE()
            {
                Display();
                DisplayEventName();
                DisplayCostOfEvent();
                DisplayCoordinatorName();
            }

        }


        class P3
        {
            static void Main()
            {
                SOE s = new SOE("Global", "RKU", "Computer science", "Techno_planet", "50000", "Raviraj");
                s.Display();
                s.DisplaySOE();

                Console.WriteLine("=========================");
                Console.WriteLine("Name: Aesh Domadiya");
                Console.WriteLine("Enrollment no.: 24SOECE11008");

                Console.ReadLine();
            }
        }
    }
}