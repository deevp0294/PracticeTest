namespace PracticeTest
{
    internal class Question4
    {
        int[][] jobDurations = new int[][]
        {
            new int[] {45,60,30},
            new int[] {90},
            new int[] {},
            new int[] {20,35,50,40},
        };

        public void CountAndTotal()
        {
            int[] noOrExtra = new int[] {0,0,0,0};
            for(int i = 0; i < jobDurations.Length; i++)
            {
                Console.WriteLine($"Count of total jobs for technician no. {i+1} is {jobDurations[i].Length}");
                int minCount = 0;
                for( int j = 0; j < jobDurations[i].Length; j++)
                {
                    minCount += jobDurations[i][j];
                }

                if(minCount == 0)
                {
                    noOrExtra[i] = 1;
                }

                if(minCount > 120)
                {
                    noOrExtra[i] = 2;
                }
            }

            for(int i = 0;i< noOrExtra.Length; i++)
            {
                if (noOrExtra[i] == 1)
                {
                    Console.WriteLine($"Technician no {i+1} has no work");
                }

                if (noOrExtra[i] == 2)
                {
                    Console.WriteLine($"Technician no {i + 1} has more than 120 minutes of remaining work");
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Select technician to update work hours : (enter 1 for yes 0 for no, enter 0 to start)");
            int choice1 = 0;
            for (int i = 0; i < jobDurations.Length; i++)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < jobDurations[i].Length; j++)
                {
                    Console.Write(" " + jobDurations[i][j] + " ");
                }
                if (choice == 1)
                {
                    choice1 = i;
                    break;
                }
            }

            Console.WriteLine("Enter minutes you want to update");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jobDurations[choice1].Length; i++)
            {
                if (jobDurations[choice1][i] == value)
                {
                    Console.WriteLine($"Enter minutes to change at place of {value}");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    jobDurations[choice1][i] = value1;
                }
            }
        }
    }
}
