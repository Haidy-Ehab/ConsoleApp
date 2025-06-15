using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Class1;

namespace ConsoleApp1
{
    internal class hospital
    {

public class HospitalSystem
    {
        private Queue<Patient> emergencyQueue;
        private Queue<Patient> criticalQueue;
        private Queue<Patient> generalQueue;

        public HospitalSystem()
        {
            emergencyQueue = new Queue<Patient>();
            criticalQueue = new Queue<Patient>();
            generalQueue = new Queue<Patient>();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n**** Hospital Management System ****");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Display Queues");
                //Console.WriteLine("3. Assign Doctor to a Patient");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice)) // convert string to int 
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddPatientFlow();
                        break;

                    case 2:
                        DisplayQueues();
                        break;

                    //case 3:
                    //    AssignDoctorToPatient();
                    //    break;

                    case 4:
                        Console.WriteLine("Thank You! Stay Safe\n... Exiting ...");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Enter a Number between [1-4]");
                        break;
                }
            }
        }

        private void AddPatientFlow()
        {
            Console.Write("Enter Patient's ID: ");
            int id = int.Parse(Console.ReadLine());// read next line character

            Console.Write("Enter Patient's name: ");
            string name = Console.ReadLine();

            Console.Write("Patient's Priority (0: General, 1: Critical, 2: Emergency): ");
            int priorityVal = Int32.Parse(Console.ReadLine());
                
                priority priority = priority.General;
                Patient newPatient = new Patient(id, name, priority);
           switch (priorityVal)
            {
                    case 0:
                        newPatient.Priority = priority.General;
                        break;
                        case 1:
                        newPatient.Priority = priority.Critical;
                        break;
                    case 2:
                        newPatient.Priority = priority.Emergency;
                        break;
            };

            
            AddPatient(newPatient);
        }

        public void AddPatient(Patient p)
        {
            switch (p.GetPriority())
            {
                case priority.Emergency:
                    emergencyQueue.Enqueue(p);
                    break;
                case priority.Critical:
                    criticalQueue.Enqueue(p);
                    break;
                case priority.General:
                    generalQueue.Enqueue(p);
                    break;
            }
        }

        public void DisplayQueues()
        {
            if (emergencyQueue.IsEmpty() && criticalQueue.IsEmpty() && generalQueue.IsEmpty())
            {
                Console.WriteLine("No Patients in the Queues");
                return;
            }

            Console.WriteLine("\n<<<<< Emergency Patients >>>>>");
            if (emergencyQueue.IsEmpty())
                Console.WriteLine("No Patients in this Queue");
            else
                emergencyQueue.Print();

            Console.WriteLine("\n<<<<< Critical Patients >>>>>");
            if (criticalQueue.IsEmpty())
                Console.WriteLine("No Patients in this Queue");
            else
                criticalQueue.Print();

            Console.WriteLine("\n<<<<< General Patients >>>>>");
            if (generalQueue.IsEmpty())
                Console.WriteLine("No Patients in this Queue");
            else
                generalQueue.Print();
        }

 
      

            }

        }
}
