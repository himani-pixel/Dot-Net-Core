using System;

namespace CollegeAdmission
{
    class Admission
    {
        public void VerifyDocuments()
        {
            Console.WriteLine("Documents Verified Successfully.");
        }

        public void GenerateRollNumber()
        {
            Console.WriteLine("Roll Number Generated.");
        }

        public void AllocateDivision()
        {
            Console.WriteLine("Division Allocated.");
        }

        public void SendSMS()
        {
            Console.WriteLine("SMS Sent to Student.");
        }
    }

    class Program
    {
        // Delegate
        delegate void AdmissionProcess();

        static void Main(string[] args)
        {
            Admission student = new Admission();

            // Multicast Delegate
            AdmissionProcess process = student.VerifyDocuments;
            process += student.GenerateRollNumber;
            process += student.AllocateDivision;
            process += student.SendSMS;

            Console.WriteLine("Press Enter to Confirm Admission...");
            Console.ReadLine();

            Console.WriteLine("\nAdmission Process Started...\n");

            // Invoke Delegate
            process();

            Console.WriteLine("\nAdmission Completed Successfully.");

            Console.ReadKey();
        }
    }
}
