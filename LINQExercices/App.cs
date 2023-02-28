internal class App
{
    internal void Run()
    {
        //IList<Student> studentList = new List<Student>() {
        //    new Student() { StudentID = 1, StudentName = "John", age = 18 },
        //    new Student() { StudentID = 2, StudentName = "Steve",  age = 21 },
        //    new Student() { StudentID = 3, StudentName = "Bill",  age = 18 },
        //    new Student() { StudentID = 4, StudentName = "Ram" , age = 20  },
        //    new Student() { StudentID = 5, StudentName = "Ron" , age = 21 }
        //};
        //var students = from s in studentList
        //               select new { Id = s.StudentID, Name = s.StudentName };

        //foreach (var stud in students)
        //    Console.WriteLine(stud.Id + "-" + stud.Name);


        //1
        //var endDate = DateTime.Now.AddDays(30);
        //var annons = new {endDate, seller = "Delia Cirstea", title = "Playstation 5", description = "used", price = 5500};
        //Console.WriteLine(annons.endDate);

        //2
        var endDate = DateTime.Now.AddDays(30);
        var annons = new { endDate, seller = "Delia Cirstea", title = "Playstation 5", description = "used", price = 5500 };
        var bid = new { Kalle = 2022 - 11 - 05, Lisa = 2022 - 11 - 06 };
        var bid2 = new { Kalle = 2100 + "kr", Lisa = 2200 + "kr" };
        // Console.WriteLine(annons.endDate);



    }
    //    public class Student
    //    {
    //        public int StudentID { get; set; }
    //        public string StudentName { get; set; }
    //        public int age { get; set; }
    //    }
}