using System.Xml.Linq;

namespace CsPT.Task_2
{
    internal class Department
    {
        public string department { get; set; }  //  Отдел
        public int number { get; set; } //  Номер
        public string director { get; set; }    //  Руководитель

        public Department(string Name, int Number, string Boss)
        {
            department = Name;
            number = Number;
            director = Boss;
        }
    }
}
