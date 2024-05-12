using ASPintro_MVC.Models;

namespace ASPintro_MVC.ViewModels
{
    public class HomeVM
    {
        public string Text { get; set; }
        public List<string> Students { get; set; }
        public List<User> Users { get; set; }
        public List<Student> Student { get; set; }
        public List<Product> Product { get; set; }
        public List<Student> DescendingByAge { get; set; }
    }
}
