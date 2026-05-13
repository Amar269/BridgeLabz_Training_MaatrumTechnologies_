using System;
using System.Reflection;
class Employee
{
    private string name = "Amarnath";
    public int age;

    private int add(int a, int b) => a + b;

}

class refelcationsexample 
{
    static void Main()
    {
        Type type1 = typeof(Employee);

        Employee emp = new Employee();
        Type type2 = emp.GetType();


        // access the rpivate method 
        MethodInfo method = type2.GetMethod("add", BindingFlags.NonPublic | BindingFlags.Instance);

        int result = (int)method.Invoke(emp, new object[] { 10, 20 });
        Console.WriteLine("Add result : " + result );



        // to acces the private field name uisng reflection

        FieldInfo field = type2.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine("Old Value: " + field.GetValue(emp));

        field.SetValue(emp, "Kolla");
        Console.WriteLine("NEW  Value: " + field.GetValue(emp));



        //Console.WriteLine("class name : " + type1.Name);

        //Console.WriteLine("class name : " + type2.Name);


    }

}