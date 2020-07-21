namespace GradeBook {
    public class Statistics
    {
        public double Average;
        public double High;
        public double Low;
        public char Letter;

        public Statistics()
        {
            Average = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}