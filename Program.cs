 using System;
 namespace Object_args{
  class Program{
       static void Main( String [] args){
        Car c1 = new Car("Honda","Red");
        Car c2=Copy(c1);
        System.Console.WriteLine($"The model of car is {c2.model} & the color of car is{ c2.color}");

       }
       public static Car Copy( Car c)
       {
        return new Car(c.model,c.color);
       }
  
  }
     class Car{
        public String model;
        public String color;
          public Car( String model ,String color)
          {
            this.model=model;
            this.color=color;
          }
     }

 }