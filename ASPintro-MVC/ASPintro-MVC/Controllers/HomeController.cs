using ASPintro_MVC.Models;
using ASPintro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPintro_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //string text = "Welcome";
            //List<string> students = new List<string> { "Emiratsan", "Fexriyye", "Elmir", "Ilqar", "Nurlan" };
            HomeVM model = new()
            {
                //Text = text,
                //Students = students,
                // Users = GetAllUsers()
                Student = GetAllStudents(),
                Product=GetAllProduct(),
                DescendingByAge=GetAllStudents().OrderByDescending(m=>m.Age).ToList(),

                //GetAllStudentDesc()

            };
            return View(model);
        }

        private List<User> GetAllUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Age = 100
                },
                new User
                {
                    Id = 1,
                    Age = 100
                }
            };
        }
        private List <Student> GetAllStudents()
        {
            return new List<Student> {
                new Student
                {
                    Id = 1,
                    Name="Rashad",
                    Surname="Aghayev",
                    Email="rashad@gmail.com",
                    PhoneNumber="0708181700",
                    Age = 21,
                },
                 new Student
                {
                    Id = 2,
                    Name="Behruz",
                    Surname="Eliyev",
                    Email="behruz@gmail.com",
                    PhoneNumber="0700000700",
                    Age = 38,
                },
                  new Student
                {
                    Id = 3,
                    Name="Esgerxan",
                    Surname="Bayramov",
                    Email="esgerxan@gmail.com",
                    PhoneNumber="0708188700",
                    Age = 26,
                }
            };
        }
        private List<Product> GetAllProduct()
        {
            return new List<Product>{
            new Product
            {
                Id = 1,
                Name="Apple",
                Color="White",
                Price=4000

            },
            new Product
            {
                Id = 2,
                Name="Samsung",
                Color="Black",
                Price=3000

            },
            new Product
            {
                Id = 3,
                Name="Huawei",
                Color="Gray",
                Price=1700

            }
            };
        }
        private List<Student> GetAllStudentDesc()
        {
            return GetAllStudents().OrderByDescending(x => x.Id).ToList();    
            
        }
    }
}
