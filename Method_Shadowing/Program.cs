using System;

namespace Method_Shadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Andrei", "Sologubov");
            person1.Display();

            Employee employee1 = new Employee("Kolya", "Demidenko", "EPAM");
            employee1.Display();

            Person tom = new Employee ("Tom", "Kek", "Microsoft"); // В классе Employee метод Display не
                                                                   // переопределён (считает как совершенно другой метод),
                                                                   // поэтому оно ссылается на базовый класс и вызывает
                                                                   // бзовый метод
            tom.Display();
        }
    }
}
