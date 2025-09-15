import java.util.Map;
import java.util.Scanner;
import java.util.function.Consumer;
import java.util.function.Function;
import java.util.function.Predicate;
import java.io.*;
import java.util.function.Supplier;

class A
{
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);


        Supplier<String> sup = () -> {
            String name[]={"apple","mango","banana","papaya","watermelon"};
            int i =(int)(Math.random()*4);
            return name[i];
        };

                System.out.println("Current choosen fruit of the day is "+ sup.get());




    }
}
