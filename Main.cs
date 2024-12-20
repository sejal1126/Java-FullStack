
import java.sql.*;//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
import java.util.Scanner;

// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws ClassNotFoundException {
        String url="jdbc:mysql://localhost:3306/student";
        String username="root";
        String password="Priyanka@123";

        try{
            Class.forName(
                    "com.mysql.cj.jdbc.Driver");
            System.out.println("Driver Loaded Successfully");
        }
        catch(ClassNotFoundException e)
        {
            System.out.println(e.getMessage());
        }

        try{
            Connection con = DriverManager.getConnection(url,username,password);
            System.out.println("Connection establish successfully");
            Statement stmt = con.createStatement();
            ResultSet rs = stmt.executeQuery("select * from students");
            System.out.println("1..Display of Data");
            System.out.println("2..Insert of Data");
            System.out.println("3..Deletion of Data");
            System.out.println("4..Updation of data");
            System.out.println("5..Exit");
            System.out.println("Enter Your choice : ");
            Scanner sc = new Scanner(System.in);
            int choice = sc.nextInt();
            switch (choice)
            {
                case 1:  System.out.println("1..Display of Data");
                    while(rs.next())
                    {
                        int rollno = rs.getInt("rollno");
                        String name = rs.getString("name");
                        String subject = rs.getString("subject");
                        System.out.println("=======================================");
                        System.out.println("rollno : "+rollno);
                        System.out.println("name : "+name);
                        System.out.println("subject : " +subject);
                        System.out.println("=======================================");
                    }
                    break;
                case 2: System.out.println("2..Insertion of data");
                      String query ="insert into students(rollno,name,subject) values(7,'xyz','BE');";
                      int rowaffected = stmt.executeUpdate(query);
                      if(rowaffected>0)
                      {
                          System.out.println("Insertion happen Successfully");

                      }
                      else {
                          System.out.println();
                      }
                      break;

                case 3: System.out.println("3.. Deletion of data");
                    String delquery ="delete from students where rollno=7;";
                    rowaffected = stmt.executeUpdate(delquery);
                    if(rowaffected>0)
                    {
                        System.out.println("Deletion happen Successfully");

                    }
                    else {
                        System.out.println();
                    }
                    break;

                case 4: System.out.println("4..Updation of data");
                    String upquery ="update students set rollno=11 where name= 'Sejal';";
                    rowaffected = stmt.executeUpdate(upquery);
                    if(rowaffected>0)
                    {
                        System.out.println("Updation4 happen Successfully");

                    }
                    else {
                        System.out.println();
                    }
                    break;


            }

            rs.close();
            stmt.close();
            con.close();
            System.out.println("Connection closed successfully");

        }
        catch(SQLException e)
        {
            System.out.println(e.getMessage());
        }




    }
}
