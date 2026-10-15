using Microsoft.AspNetCore.Mvc;
using ShopingApp.Models;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
namespace ShopingApp.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _dbcontext;
    public HomeController(AppDbContext dbcontext)
    {
        _dbcontext = dbcontext;
    }
    public IActionResult Index()
    {
        Student stud = new Student()
        {
         
            Name = "Arun Kumar",
            College = "Anna University",
            Department = "Computer Science",
            Degree = "B.E"
        };

        return View(stud);
        //TempData["College"] = "AURCM";
        //ViewData["Name"] = "Deva";
        //List <Employee> olist = new List<Employee> ();
        //olist.Add(new Employee { EmpName = "Dailu", EmpID = "1326", Profile = "Software Developer" });
        //ViewData["ListOfEmployee"] = olist;

    }

    public IActionResult AboutUs()
    {
        List<Student> listofstudent = GetStudents();
        return View(listofstudent);
    }
    public IActionResult content()
    {
        return View();
    }
    public IActionResult userdetails(string Id)
    {
        int idvalue = Convert.ToInt16(Id);
        var item = GetStudents().Where(x => x.Id == idvalue).FirstOrDefault();
        return View(item);
    }
    [HttpPost]
    public IActionResult SaveData(Student stud)
    {
        if(ModelState.IsValid)
        {
            _dbcontext.Add(stud);
            _dbcontext.SaveChanges();
            return View("index", stud);
        }
        return View("index", stud);
        //string query = "Insert into StudentsList(Id, Name, College, Department, Degree) values (@Id, @Name, @College, @Department, @Degree)";
        //SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
        //                   Persist Security Info=False;
        //                   Initial Catalog=JSQUARE_StudentManagement;
        //                   Data Source=(LocalDB)\MSSQLLocalDB;
        //                   Encrypt=False;");
        //sql.Open();
        //SqlCommand sqlCommand = new SqlCommand(query, sql);
        //sqlCommand.Parameters.AddWithValue("@Id", stud.Id);
        //sqlCommand.Parameters.AddWithValue("@Name", stud.Name);
        //sqlCommand.Parameters.AddWithValue("@College", stud.College);
        //sqlCommand.Parameters.AddWithValue("@Department", stud.Department);
        //sqlCommand.Parameters.AddWithValue("@Degree", stud.Degree);
        //sqlCommand.ExecuteNonQuery();
        //sql.Close();
       

    }
    [HttpPost]
    public IActionResult UpdateData(Student stud)
    {
        string query = "update StudentsList Set Name=@Name, College = @College, Department=@Department, Degree=@Degree where Id=@Id";
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                           Persist Security Info=False;
                           Initial Catalog=JSQUARE_StudentManagement;
                           Data Source=(LocalDB)\MSSQLLocalDB;
                           Encrypt=False;");
        sql.Open();
        SqlCommand sqlCommand = new SqlCommand(query, sql);
        sqlCommand.Parameters.AddWithValue("@Id", stud.Id);
        sqlCommand.Parameters.AddWithValue("@Name", stud.Name);
        sqlCommand.Parameters.AddWithValue("@College", stud.College);
        sqlCommand.Parameters.AddWithValue("@Department", stud.Department);
        sqlCommand.Parameters.AddWithValue("@Degree", stud.Degree);
        sqlCommand.ExecuteNonQuery();
        sql.Close();
        return View("index", stud);

    }
    [HttpPost]
    public IActionResult DeleteData(Student stud)
    {
        string query = "Delete From StudentsList where Id=@Id";
        SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
                           Persist Security Info=False;
                           Initial Catalog=JSQUARE_StudentManagement;
                           Data Source=(LocalDB)\MSSQLLocalDB;
                           Encrypt=False;");
        sql.Open();
        SqlCommand sqlCommand = new SqlCommand(query, sql);
        sqlCommand.Parameters.AddWithValue("@Id", stud.Id);
        sqlCommand.ExecuteNonQuery();
        sql.Close();
        return View("index", stud);


    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(reg regs)
    {
        if (ModelState.IsValid)
        {
            _dbcontext.Add(regs);
            _dbcontext.SaveChanges();
            return View("index", regs);
        }
        return View("index", regs);

        //if (!ModelState.IsValid)
        //{
        //    return View(regs);
        //}
        //string query = @"INSERT INTO Users
        //                 (Name, Education, FieldOfStudy, Email, MobileNo, Profile)
        //                 VALUES
        //                 (@Name, @Education, @FieldOfStudy, @Email, @MobileNo, @Profile)";

        //SqlConnection sql = new SqlConnection(@"Integrated Security=SSPI;
        //                   Persist Security Info=False;
        //                   Initial Catalog=JSQUARE_StudentManagement;
        //                   Data Source=(LocalDB)\MSSQLLocalDB;
        //                   Encrypt=False;");
        
        //sql.Open();
        //SqlCommand cmd = new SqlCommand(query, sql);
        //cmd.Parameters.AddWithValue("@Name", regs.Name);
        //cmd.Parameters.AddWithValue("@Education", regs.Education);
        //cmd.Parameters.AddWithValue("@FieldOfStudy", regs.FieldOfStudy);
        //cmd.Parameters.AddWithValue("@Email", regs.Email);
        //cmd.Parameters.AddWithValue("@MobileNo", regs.MobileNo);
        //cmd.Parameters.AddWithValue("@Profile", regs.Profile);

        //cmd.ExecuteNonQuery();
        //sql.Close();

        //return Content("Registration Successful");
    }
    public List<Student> GetStudents()
    {
        var students = new List<Student>
{
    new Student
    {
        Id = 1,
        Name = "Arun Kumar",
        College = "Anna University",
        Department = "Computer Science",
        Degree = "B.E"
    },

    new Student
    {
        Id = 2,
        Name = "Priya",
        College = "Bharathiar University",
        Department = "Information Technology",
        Degree = "B.Tech"
    },

    new Student
    {
        Id = 3,
        Name = "Karthik",
        College = "Madras University",
        Department = "Mechanical Engineering",
        Degree = "B.E"
    },

    new Student
    {
        Id = 4,
        Name = "Divya",
        College = "Anna University",
        Department = "Electronics and Communication",
        Degree = "B.E"
    },

    new Student
    {
        Id = 5,
        Name = "Vijay",
        College = "Bharathidasan University",
        Department = "Civil Engineering",
        Degree = "B.E"
    },

    new Student
    {
        Id = 6,
        Name = "Keerthana",
        College = "Alagappa University",
        Department = "Computer Science",
        Degree = "B.Sc"
    },

    new Student
    {
        Id = 7,
        Name = "Sanjay",
        College = "Madurai Kamaraj University",
        Department = "Information Technology",
        Degree = "B.Sc"
    },

    new Student
    {
        Id = 8,
        Name = "Harini",
        College = "Anna University",
        Department = "Electrical Engineering",
        Degree = "B.E"
    },

    new Student
    {
        Id = 9,
        Name = "Rahul",
        College = "Coimbatore Institute of Technology",
        Department = "Computer Science",
        Degree = "B.E"
    },

    new Student
    {
        Id = 10,
        Name = "Naveen",
        College = "PSG College of Technology",
        Department = "Mechanical Engineering",
        Degree = "B.E"
    }
};
        return students;
    }
}
