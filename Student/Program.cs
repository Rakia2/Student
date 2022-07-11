using System;
namespace StudentUniversity
{

 public class Person
    {
        string Name;
        int Id;
        int GPA;
        string Field;

      
  public Person(string name,int id,int gpa,string field)
        {

            Name = name;
            Id = id;
            GPA = gpa;
            Field = field;

        }
       /* public Person()
        {
            Name = "";
            Id = 0;
            GPA = 0;
            Field = "";
        }*/

        public   void ShowGPA()

        {


            Console.WriteLine(GPA);

        }
        public static void Display( int ID, string Name,string Field)
        {
            Console.WriteLine(ID + "the student  is:" + Name + "" + Field);
        }
        

            public static void Main(string[] args)
            {
                Person Person1 = new Person("Rakia",1,14,"Mnagement");
                Person Person2 = new Person("Salma", 1, 14, "Marketing");
            Console.WriteLine("Program start executing:");

               Console.WriteLine("name is " +   Person1.Name);
                Console.WriteLine( "Id is " + Person1.Id);
               Person1.ShowGPA();
                Console.WriteLine("study in " +  Person1.Field );




        }
         
       








    }









}