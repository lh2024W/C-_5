using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace C__5
{
    class Student
    {
        private string? firstname;//имя
        private string? secondname;//отчество
        private string? lastname;//фамилия
        private string? birthday;//дата рождения
        private string? address;//домашний адрес
        private string? phone;//телефон
        List<Int32?> Tests;//зачеты
        List<Int32?> TermPapers;//курсовые работы
        List<Int32?> Exams;//экзамены

        public Student () : this (10, 11, 11)
        {
            //Console.WriteLine("C-tor without params");
        }

       public Student(Int32? test, Int32? term, Int32? exam): this ("Иван", "Иванович", "Иванов", "12.01.2003", "г.Одесса ул.Пушкинская 10", "069635422", 12, 12, 12)
        {
            Tests = new List<Int32?>();
            SetTests(test);
            TermPapers = new List<Int32?>();
            SetTermPapers(term);
            Exams = new List<Int32?>();
            SetExams(exam);

            //Console.WriteLine("C-tor with params");
        }

        public Student(string? firstname, string? secondname, string? lastname, string? birthday, string? address, string? phone, Int32? test, Int32? term, Int32? exam)//main c-tor
        {
            SetFirstname(firstname);
            SetSecondname(secondname);
            SetLastname(lastname);
            SetBirthday(birthday);
            SetAddress(address);
            SetPhone(phone);
            Tests = new List<Int32?>();
            SetTests(test);
            TermPapers = new List<Int32?>();
            SetTermPapers(term);
            Exams = new List<Int32?>();
            SetExams(exam);

            //Console.WriteLine("Main c-tor");
        }

        public void SetFirstname (string? firstname)
        {
            this.firstname = firstname;
        }

        public void SetSecondname (string? secondname) 
        {
            this.secondname = secondname;
        }

        public void SetLastname(string? lastname)
        {
            this.lastname = lastname;
        }

        public void SetBirthday (string? birthday)
        {
            this.birthday = birthday;
        }

        public void SetAddress (string? address)
        {
            this.address = address;
        }

        public void SetPhone (string? phone)
        {
            this.phone = phone;
        }

        public void SetTests(Int32? test)
        {
            Tests.Add(test);
        }

        public void SetTermPapers(Int32? term)
        {
            TermPapers.Add(term);
        }

        public void SetExams(Int32? exam)
        {
            Exams.Add(exam);
        }

        public string? GetFirstname()
        {
            return firstname != null ? firstname : "Не задано";
        }

        public string? GetSecondname()
        {
            return secondname != null ? secondname : "Не задано";
        }

        public string? GetLastname()
        {
            return lastname != null ? lastname : "Не задано";
        }

        public string? GetBirthday()
        {
            return birthday != null ? birthday : "Не задано";
        }

        public string? GetAddress()
        {
            return address != null ? address : "Не задано";
        }

        public string? GetPhone()
        {
            return phone != null ? phone : "Не задано";
        }

        public List<Int32?> GetTests()
        {
            return Tests;
        }

        public List<Int32?> GetTermPapers()
        {
            return TermPapers;
        }

        public List<Int32?> GetExams()
        {
            return Exams;
        }

        public void Print()
        {
            Console.WriteLine("Имя: " + GetFirstname());
            Console.WriteLine("Отчество: " + GetSecondname());
            Console.WriteLine("Фамилия: " + GetLastname());
            Console.WriteLine("Дата рождения: " + GetBirthday());
            Console.WriteLine("Адрес проживания: " + GetAddress());
            Console.WriteLine("Телефон: " + GetPhone());
            foreach (Int32? test in Tests)
            {
                Console.WriteLine("Оценки за зачеты: " + test);
            }
            foreach (Int32? term in TermPapers)
            {
                Console.WriteLine("Оценки за зачеты: " + term);
            }
            foreach (Int32? exam in Exams)
            {
                Console.WriteLine("Оценки за зачеты: " + exam);
            }
            Console.WriteLine();
        }
            static void Main(string[] args)
        {
            Student s = new ();
            s.Print();
            Student s2 = new Student(9,9,9);
            s2.Print();
            Student s3 = new Student("Василий", "Васильевич", "Пупкин", "01.01.1999", "г. Киев", "32536654", 12,12,12);
            s3.Print();
        }
    }
}
