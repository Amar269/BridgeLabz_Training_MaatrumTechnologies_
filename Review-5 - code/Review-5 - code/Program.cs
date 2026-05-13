using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;



public class Employee
{
    public int id { get; set; }
    public string name { get; set; }

    public string Email { get; set; }

}
public interface IReader
{
    List<Employee> Read(string path);
}

public interface Iwriter
{
    void Write(String path, List<Employee> emp);

}

public interface IFactory
{
    IReader CreateReader();
    Iwriter CreaterWriter();
}

public sealed class Logger
{
    private static readonly Logger _instance = new Logger();

    public  readonly String _logFilepath = "log.txt";

    private Logger()
    {

    }

    public static Logger Instance
    {
        get { return _instance; }
    }

    public void Log(string message)
    {
        using (StreamWriter writer = new StreamWriter(_logFilepath, true))
        {
            writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")  + " - " + message);
        }
    }
    
}

public class csvwriter : Iwriter
{
    public void Write(string path, List<Employee> emp)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach(var employee in emp)
            {
                writer.WriteLine(employee.id + "," +
                    employee.name + "," +
                    employee.Email);
                    
                    
                    
            }
        }

        Logger.Instance.Log("CSV file written successfully: " + path);

    }

}
