using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1
{

    //class hotelystem
    //  {
    //      public int roomNum { get; set; }//here we convert it from field to properity
    //       string roomtype { get; set; }
    //       double price { get; set; }
    //       bool isBooked { get; set; }
    //  //    public const string hotelName = "Grand Stay Hotel";



    //      //way 1 for constructor

    //      //public hotelystem()
    //      //{
    //      //    roomNum = 5;
    //      //    roomtype = "single";
    //      //    price = 100.5;
    //      //    isBooked = true;
    //      //}


    //      //way 2 for consrtuctor
    //     public hotelystem(int roomNum1,string roomtype2,double price3,bool isBooked4) 
    //       {
    //          roomNum = roomNum1;// what in class = the parameter


    //       }


    //  }


    //code coach batool study it again

    //******************************************here start the task***************************************

    class student
    {
        private string name;
        private int age;
        private int studentID;
        public string Email { get; set; }
        public const int MinAge= 18;
        public const int MaxAge= 40;




        public string Name { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= MinAge && value <= MaxAge)
                {
                    age= value;
                }
                else
                {
                    Console.WriteLine("the age is less than 18");
                }
            }
        }

        public student(string name,int age,int studentID)
        {
            this.name = name;
            this.age = age;
            this.studentID = studentID;
        }

        public void GetDetails()
        {
            Console.WriteLine("All about student:" + name + " " + age + " " + studentID);
        }
        ~student()
        {
            Console.WriteLine("This was deleted");
        }

    }

    //class student
    //{
    //    private string name;
    //    private int age;
    //    private int studentid;
    //    public string Email { get; set; }
    //    public const int MinAge = 18;
    //    public const int MaxAge = 40;

    //    public string Name {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }

    //    public int Age {

    //        get

    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            age = value;
    //        }
    //            }
    //    public int StudentID
    //    {
    //        get
    //        {
    //            return studentid;
    //        }
    //        set
    //        {
    //            studentid = value;
    //        }
    //    }



    //    public student(string name, int age, int id)
    //    {
    //        Name = name;
    //        Age = age;
    //        StudentID = id;
    //    }

    //    ~student()
    //    {
    //        Console.WriteLine("This object was deleted");
    //    }

    //    public void GetDetails()
    //    {



    //    }



//***************************************

    //class car
    //{
    //    public string name;
    //    public string cuntry;
    //    public int model;


    //    car()
    //    {
    //        name = "";
    //        cuntry = "";
    //        model = 0;
    //    }
    //     public car(string name,string cuntry, int model)
    //    {
    //        this.name = name;
    //        this.cuntry = cuntry;
    //        this.model = model;
    //    }
    //   public void dcar()
    //    {
    //        Console.WriteLine("this car is:" + name + " " + cuntry + " " + model);
    //    }
    //}

    internal class Program
        {
            static void Main(string[] args)
            {

            student obj1 = new student("Ahmaad", 22, 1001);
            obj1.GetDetails();
            obj1.Age = 14;



            //car obj1 = new car("bmw", "jor", 2020);
            //obj1.dcar();

               
            }
        }
    }

