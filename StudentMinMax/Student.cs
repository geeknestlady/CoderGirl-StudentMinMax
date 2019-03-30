namespace StudentMinMax
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public int? GetMaximumScore()
        {
            int maxScore = 0;
            for (int i = 0; i < Scores.Length; i++)
            {
                if(Scores[i] < maxScore)
                {
                    maxScore = Scores[i];
                }
            }
            return maxScore;

        }

        public int? GetMinimumScore()
        {
            int minScore = 100;
            for (int i = 0; i < Scores.Length; i++)
            {
                if(minScore < Scores[i])
                {
                    minScore = Scores[i];
                }

            }
            return minScore;
        }
    }
}