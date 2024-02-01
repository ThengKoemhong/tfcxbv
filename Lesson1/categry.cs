namespace Lesson1;
using System;
public class categry
{
    public static double[] CalculateAverageByDay(int[,] calories)
    {
        int sum = 0;
        double[] dailyAverage = new double[7];
        for (int r = 0; r < calories.GetLength(0); r++)
        {
            for (int c = 0; c < calories.GetLength(1); c++)
                sum += calories[r, c];
            dailyAverage[r] = (double)sum / calories.GetLength(1);
            sum = 0;
        }
        return dailyAverage;
    }

    public static double[] CalculateAverageByMeal(int[,] calories)
    {
        int sum = 0;
        double[] mealAverage = new double[3];
        for (int c = 0; c < calories.GetLength(1); c++)
        {
            for (int r = 0; r < calories.GetLength(0); r++)
                sum += calories[r, c];
            mealAverage[c] = (double)sum / calories.GetLength(0);
            sum = 0;
        }
        return mealAverage;
    }
    public static void DisplayAverageCaloriesPerMeal(int[,] calories)
    {
        double sum = 0;
        for (int da = 0; da < calories.GetLength(0); da++)
            for (int ml = 0; ml < calories.GetLength(1); ml++)
                sum += calories[da, ml];
        Console.WriteLine("\nCaloric Average Per Meal: {0:N0}",
                          sum / calories.Length);
    }

    public static void Main()
    {
        int[,] calorieIntake = {
            { 900, 750, 1020 }, // Day 1
            { 300, 1000, 2700 }, // Day 2
            { 500, 700, 2100 }, // Day 3
            { 450, 900, 1780 }, // Day 4
            { 650, 1200, 1100 }, // Day 5
            { 575, 1550, 1900 }, // Day 6
            { 600, 1020, 1700 } // Day 7
        };

        // Calculate average by 
        double[] dailyAverage = CalculateAverageByDay(calorieIntake);
        Console.WriteLine("Average calorie intake by day:");
        for (int i = 0; i < dailyAverage.Length; i++)
        {
            Console.WriteLine($"Day {i + 1}: {dailyAverage[i]}");
        }

        Console.WriteLine("\nAverage calorie intake by meal:");
        double[] mealAverage = CalculateAverageByMeal(calorieIntake);
        Console.WriteLine("Breakfast :" + mealAverage[0]);
        Console.WriteLine("Lunch :" + mealAverage[1]);
        Console.WriteLine("Dinner :" + mealAverage[2]);

        DisplayAverageCaloriesPerMeal(calorieIntake);


    }
}
