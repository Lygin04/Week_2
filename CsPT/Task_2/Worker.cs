using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;

namespace CsPT.Task_2
{
    internal class Worker
    {
        public string lastName { get; set; }    //  Фамилия
        public string firstName { get; set; }   //  Имя
        public string patronymic { get; set; }  //  Отчество
        public int year { get; set; }   //  Возраст
        public Department dep { get; set; } //  Отдел

    }
}
