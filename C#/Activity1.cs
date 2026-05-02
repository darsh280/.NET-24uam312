class Activity1{
    static void evenOdd(int num)
    {
        if(num % 2 == 0)
        {
            System.Console.WriteLine(num +" is Even");
        }
        else
        {
            System.Console.WriteLine(num +" is Odd");
        }
    }

    static void votingEligible(int age)
    {
        if(age >= 18)
        {
            System.Console.WriteLine("Eligible for Voting");
        }
        else
        {
            System.Console.WriteLine("Not Eligible for voting");
        }
    }

    static void sumOfArray(int[] arr)
    {
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        System.Console.WriteLine("Sum of Array is: " +sum);
    }

    public static void Main()
    {
        evenOdd(111);

        votingEligible(17);

        int[] arr = {10, 20, 30, 40, 50};
        sumOfArray(arr);
    } 
}