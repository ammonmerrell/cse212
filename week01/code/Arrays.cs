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

        // my plan is to use a for loop with the length var being the variable that determines the length of code.
        
        // The function will create a list and add numbers to it as it goes through the loop.
        var multiples = new double[] {};
        // var multiples = new List<double> ();
        // The function will create a var that will be a placeholder for the number added to the array.
        double num = 0;
        // the loop itself will increase the number multiplied by one starting with 1.
        for(int i = 1; i < length; i++)
        {
            Console.WriteLine(i);
            num = number * i;
             // insert the placeholder number into the array.
            //  Convert array to list.
             List<double> numlist = multiples.ToList();
             numlist.Add(num);
            // convert back to array.
            multiples = numlist.ToArray();
        }
        return multiples; // replace this return statement with your own
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
    }
}
