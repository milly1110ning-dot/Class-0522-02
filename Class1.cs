using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
public interface IData
{
    public string GetData();//1
}

public interface ICard
{
    public string GetCard();//2
}

public interface IName : IData, ICard
{
    public string GetName();//3
}

public class Person : IName, ICard
{
    public string GetName()
    {
        return "Name";
    }
    public string GetCard()
    {
        return "Card";
    }
    public string GetData()
    {
        return "Data";
    }
}
public class Student : Person, ICard
{
}