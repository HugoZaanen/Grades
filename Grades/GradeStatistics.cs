namespace Grades
{
    internal class GradeStatistics
    {
        float averageGrade;
        float highestGrade;
        float lowestGrade;

        public float AverageGrade
        {
            get
            {
                return averageGrade;
            }
            set
            {
                averageGrade = value;
            }
        }
        public float HighestGrade
        {
            get
            {
                return highestGrade;
            }
            set
            {
                highestGrade = value;
            }
        }
        public float LowestGrade
        {
            get
            {
                return lowestGrade;
            }
            set
            {
                lowestGrade = value;
            }
        }


    }
}