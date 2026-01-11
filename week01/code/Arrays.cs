public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


         // My Plan: I will do the following: 
        // 1. Create a new array of type double with the given length.
        // 2. Use a loop that runs from index 0 up to (length - 1).
        // 3. For each index i:
        //      - I will calculate the multiple as number * (i + 1)
        //      - Then store the result in the array at position i.
        // 4. Return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // My Plan:

        // 1. To start with I need to understand that rotating right means moving the last 'amount'
        //    elements to the front of the list.
        // 2. Calculate how many elements should remain at the front after rotation:
        //      splitIndex = data.Count - amount
        // 3. Use GetRange to:
        //      - Extract the last 'amount' elements
        //      - Extract the remaining elements at the beginning
        // 4. Clear the original list.
        // 5. Add the extracted last elements first.
        // 6. Add the remaining elements after.
        // 7. The list is now rotated in place.

        int splitIndex = data.Count - amount;

        // Get the elements that will move to the front
        List<int> rightPart = data.GetRange(splitIndex, amount);

        // Get the elements that will move to the back
        List<int> leftPart = data.GetRange(0, splitIndex);

        // Clear original list
        data.Clear();

        // Rebuild list in rotated order
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
