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
            Console.WriteLine("C-tor without params");
        }

       public Student(Int32? test, Int32? term, Int32? exam): this ("Иван", "Иванович", "Иванов", "12.01.2003", "г.Одесса ул.Пушкинская 10", "069635422", 12, 12, 12)
        {
            Tests = new List<Int32?>();
            SetTests(test);
            TermPapers = new List<Int32?>();
            SetTermPapers(term);
            Exams = new List<Int32?>();
            SetExams(exam);

            Console.WriteLine("C-tor with params");
        }

        public Student(string? firstname, string? secondname, string? lastname, string? birthday, string? address, string? phone, Int32? test, Int32? term, Int32? exam)//main c-tor
        {
            SetName(firstname);
            SetName(secondname);
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

            Console.WriteLine("Main c-tor");
        }

        public void SetName (string? name)
        {
            this.firstname = name;
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
            return firstname;
        }

        public string? GetSecondname()
        {
            return secondname;
        }

        public string? GetLastname()
        {
            return lastname;
        }

        public string? GetBirthday()
        {
            return birthday;
        }

        public string? GetAddress()
        {
            return address;
        }

        public string? GetPhone()
        {
            return phone;
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

        public void Print ()
        {
            GetFirstname();
            GetSecondname();
            GetLastname();
            GetBirthday();
            GetAddress();
            GetPhone();
            GetTests();
            GetTermPapers();
            GetExams();
        }
        static void Main(string[] args)
        {
            Student s = new ();
            s.Print();
            //Student s2 = new Student();
            //Console.WriteLine("Hello, World!");"Василий", "Васильевич", "Пупкин", "01.01.1999", "г. Киев", "32536654"
        }
    }
}
