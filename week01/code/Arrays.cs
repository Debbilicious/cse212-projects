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
    // plan:
    // Step 1: Create a new array of doubles with size 'length'.
    // Step 2: Loop from 0 to length-1.
    // Step 3: For each index i, calculate the multiple as number * (i + 1).
    // Step 4: Assign this value to the array at index i.
    // Step 5: After the loop, return the array.

    double[] multiples = new double[length];
    for (int i = 0; i < length; i++)
    {
        multiples[i] = number * (i + 1);
    }
    return multiples;
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
    // plan:
    // Step 1: Calculate the split point where the list will be divided. 
    // This is data.Count - amount, because I want the last 'amount' items to move to the front.
    // Step 2: Get the last 'amount' items using GetRange(split, amount) and store them in a temporary list.
    // Step 3: Remove the last 'amount' items from the original list using RemoveRange(split, amount).
    // Step 4: Insert the temporary list at the beginning of the original list using InsertRange(0, temp).

    int split = data.Count - amount;
    List<int> temp = data.GetRange(split, amount);
    data.RemoveRange(split, amount);
    data.InsertRange(0, temp);
}
    }

