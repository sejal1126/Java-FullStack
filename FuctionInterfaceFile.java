import java.util.Scanner;
import java.util.function.Function;
import java.util.function.Predicate;
import java.io.*;

class A
{
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Program to check the Length of String");




        Function<String,Integer> fun = num-> num.length();

        System.out.println("The Length of Entered String is "+fun.apply("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));



    }
}
