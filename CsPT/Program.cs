using CsPT.Task_2;
using CsPT.Task_3;
using CsPT.Task_4;

//  Задание 1
Exception ex = new Exception();
Console.WriteLine(ex.Message);
try
{
    string a = "sdfsdf";
    int s = Convert.ToInt32(a);
}
catch(Exception e) { Console.WriteLine(e.Message); }

//  Задание 2
Department dep1 = new Department("PSU", 21, "You");
Department dep2 = new Department("Завод", 21, "I");

List<Worker> workers = new List<Worker>()
    {
        new Worker(){ lastName = "Гарбуз", firstName = "хз", patronymic = "хз", year = 44, dep1 },
        new Worker(){ lastName = "Пупкин", firstName = "Василий", patronymic = "Нету отчества", year = 34, dep2 },
        new Worker(){ lastName = "Воронин", firstName = "Василий", patronymic = "Николаевич", year = 23, dep2 },
        new Worker(){ lastName = "Пупкин", firstName = "Василий", patronymic = "Нету отчества", year = 34, dep2 },
};

SortedDictionary<string, Worker> dict = new SortedDictionary<string, Worker>();
var dep = from w in workers
          orderby w.dep
          select w;

foreach (Worker worker in workers)
{
    dict[worker.dep.department] = worker;
}

//  Задание 3
Cat cat = new Cat();
cat.scream();

//  Задание 4
Class4_1 class4 = new Class4_1();

class4.Human("Alex");
class4.Human(23);

Date date1 = new Date();
Date date2 = new Date(day: 5, month: 9);
Date date3 = new Date(day: 5, month: 9, year: 2022);