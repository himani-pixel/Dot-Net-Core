namespace Practical_1_Writeup.Models
{
    public class StudentResultModel
    {
        public string RollNo { get; set; }
        public string Name { get; set; }

        public int Sub1 { get; set; }
        public int Sub2 { get; set; }
        public int Sub3 { get; set; }
        public int Sub4 { get; set; }
        public int Sub5 { get; set; }

        public int Total { get; set; }
        public double Percentage { get; set; }
        public string Grade { get; set; }
    }
}