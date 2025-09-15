import java.util.Scanner;
import java.util.function.Predicate;
import java.io.*;

class A
{
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Program to check the given number is even or odd");
        System.out.print("Enter the Number : ");
        int num = sc.nextInt();

        Predicate<Integer> p = no -> no%2==0;
        if(p.test(num))
        {
            System.out.println("Number is even");
        }
        else
        {
            System.out.println("Number is odd");
        }



    }
}
