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
        //First, we need to create an array to store the result.
        double[] result = new double[length];
        //Next, we will loop from 0 to length - 1.
        for (int i = 0; i < length; i++)
        {
            //For step 3 ,each index i, store the value number * (i + 1).
            result[i] = number * (i + 1);
        }
        //Finally, we return the result array.
        // This will give us an array of multiples of the given number.

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
        // First,we use the modulo operator to prevent over-rotation.
        amount = amount % data.Count;
        // Next, if there is no rotation needed, we can return early.
        if (amount == 0)
            return;

        // Step 3,we will get the last 'amount' elements from the list.
        List<int> tail = data.GetRange(data.Count - amount, amount);
        // Step 4, get the first 'data.Count - amount', elements.
        List<int> head = data.GetRange(0, data.Count - amount);
        // Step 5, clear the original list and add tail first,then head.
        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }

