using System;
using System.Collections.Generic;

public static class Arrays
{
    // =========================================================
    // Part 1: Arrays
    // =========================================================
    // The purpose of this function is to create an array
    // containing multiples of a starting number.
    //
    // Example:
    // MultiplesOf(3, 5)
    // Result: {3, 6, 9, 12, 15}
    // =========================================================
    public static double[] MultiplesOf(double startingNumber, int numberOfMultiples)
    {
        // Step 1:
        // Create a new array with the required size.
        double[] multiples = new double[numberOfMultiples];

        // Step 2:
        // Loop through every position in the array.
        for (int i = 0; i < numberOfMultiples; i++)
        {
            // Step 3:
            // Multiply the starting number by the position + 1.
            // We use (i + 1) because array indexes start at 0.
            multiples[i] = startingNumber * (i + 1);
        }

        // Step 4:
        // Return the completed array.
        return multiples;
    }

    // =========================================================
    // Part 2: Rotate List Right
    // =========================================================
    // The purpose of this function is to rotate a list
    // to the right by a specified amount.
    //
    // Example:
    // Original: {1,2,3,4,5,6,7,8,9}
    // Amount: 3
    // Result: {7,8,9,1,2,3,4,5,6}
    // =========================================================
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1:
        // Find the position where the list should split.
        int splitIndex = data.Count - amount;

        // Step 2:
        // Get the last part of the list.
        List<int> rightSide = data.GetRange(splitIndex, amount);

        // Step 3:
        // Get the beginning part of the list.
        List<int> leftSide = data.GetRange(0, splitIndex);

        // Step 4:
        // Clear the original list.
        data.Clear();

        // Step 5:
        // Add the rotated values back in order.
        data.AddRange(rightSide);
        data.AddRange(leftSide);
    }
}