class Arithmetic{
    public static void Main(){
        int a = 10;
        int b = 20;
        System.Console.WriteLine("Addition:"+(a+b));
        System.Console.WriteLine("Subtraction:"+(a-b));
        System.Console.WriteLine("Multiplication:"+(a*b));
        System.Console.WriteLine("Division:"+(b/a));

        //Type Casting
        //When converting smaller type into larger type -> no need of casting
        int num = 15;
        double num_double = num;

        System.Console.WriteLine("num : " + num + "type of num : "+ num.GetType());
        System.Console.WriteLine("num_double : "+ num_double + "type of num_double : " + num_double.GetType());

        double d = 15.26;
        int d_num = (int)d;
        System.Console.WriteLine("d : " + d + " type of d : " + d.GetType());
        System.Console.WriteLine("d_num : " + d_num + " type of d_num : " + d_num.GetType());
    }
}