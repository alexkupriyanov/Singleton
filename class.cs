using System;


public sealed class Singleton
{
    public static string text = "Test";
    public string Date { get; private set; }

    private Singleton()
    {
        Date = DateTime.Now.TimeOfDay.ToString();
    }

    public static Singleton Instance { get { return Nested.instance; } }

    private class Nested
    {
        static Nested()
        {
        }

        internal static readonly Singleton instance = new Singleton();
    }
}
//Данная реализация является потокобезопасной, а также данные будут созданы либо в момент создания 1 экземпляра класса, 
//либо при 1 обращении к статическим членам класса
