using Lab1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Movie> Movies { get; set; }
        public List<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Movies = GetMovies();
            Students = GetStudents();
            DataContext = this;
        }
        private List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student() { FirstName = "John", LastName = "Doe", Group = "PAP", IDNP = 1234567890123, BirthDate = new DateTime(2003, 01, 01), Grades = new List<double>() { 9.5, 8.5, 7.5 }, EnrollmentYear = 2017 } );
            students.Add(new Student() { FirstName = "Jane", LastName = "Doe", Group = "AAW", IDNP = 1234567890124, BirthDate = new DateTime(2002, 01, 01), Grades = new List<double>() { 1, 7.0, 6.0 }, EnrollmentYear = 2018 });
            students.Add(new Student() { FirstName = "Bob", LastName = "Smith", Group = "PAP", IDNP = 1234567890125, BirthDate = new DateTime(2003, 01, 02), Grades = new List<double>() { 9.0, 8.0, 7.0 }, EnrollmentYear = 2019 });
            students.Add(new Student() { FirstName = "Alice", LastName = "Johnson", Group = "AAW", IDNP = 1234567890126, BirthDate = new DateTime(2003, 01, 03), Grades = new List<double>() { 9.5, 9.0, 8.5 }, EnrollmentYear = 2019 });
            students.Add(new Student() { FirstName = "Charlie", LastName = "Williams", Group = "CON", IDNP = 1234567890127, BirthDate = new DateTime(2002, 01, 04), Grades = new List<double>() { 8.5, 7.5, 6.5 }, EnrollmentYear = 2018 });
            students.Add(new Student() { FirstName = "David", LastName = "Jones", Group = "PAP", IDNP = 1234567890128, BirthDate = new DateTime(2003, 01, 05), Grades = new List<double>() { 9.0, 8.0, 2 }, EnrollmentYear = 2019 });
            students.Add(new Student() { FirstName = "Emily", LastName = "Brown", Group = "AAW", IDNP = 1234567890129, BirthDate = new DateTime(2003, 01, 06), Grades = new List<double>() { 9.5, 9.0, 8.5 }, EnrollmentYear = 2018 });
            students.Add(new Student() { FirstName = "Michael", LastName = "Miller", Group = "CON", IDNP = 1234567890130, BirthDate = new DateTime(2004, 01, 07), Grades = new List<double>() { 8.5, 7.5, 6.5 }, EnrollmentYear = 2019 });
            students.Add(new Student() { FirstName = "Sarah", LastName = "Davis", Group = "PAP", IDNP = 1234567890131, BirthDate = new DateTime(2003, 01, 08), Grades = new List<double>() { 9.0, 8.0, 7.0 }, EnrollmentYear = 2017 });
            return students;
        }
        private List<Movie> GetMovies()
        {
            var movies = new List<Movie>();
            movies.Add(new Movie { Name = "The Shawshank Redemption", ProductionYear = 1994, ProductionCountries = new List<string>() { "USA" }, Duration = 142, Budget = 25 });
            movies.Add(new Movie { Name = "The Godfather", ProductionYear = 1972, ProductionCountries = new List<string>() { "France" }, Duration = 175, Budget = 6 });
            movies.Add(new Movie { Name = "The Dark Knight", ProductionYear = 2008, ProductionCountries = new List<string>() { "UK" }, Duration = 152, Budget = 185 });
            movies.Add(new Movie { Name = "The Lord of the Rings: The Return of the King", ProductionYear = 2003, ProductionCountries = new List<string>() { "New Zealand" }, Duration = 201, Budget = 94 });
            movies.Add(new Movie { Name = "Pulp Fiction", ProductionYear = 1994, ProductionCountries = new List<string>() { "USA", "France" }, Duration = 154, Budget = 8 });
            return movies;
        }

        private void Subsir_Click(object sender, RoutedEventArgs e)
        {
            var searchText = subsir.Text;
            if(searchText.Trim() != "")
            {
                var selectedMovies = Movies.Where(m => m.Name.Contains(searchText));
                MoviesListView.ItemsSource = selectedMovies;
            }
        }

        private void An_Click(object sender, RoutedEventArgs e)
        {
            if (an.Text.Trim() != "")
            {
                var searchText = Int32.Parse(an.Text);
                var selectedMovies = Movies.Where(m => m.ProductionYear == searchText);
                MoviesListView.ItemsSource = selectedMovies;
            }
        }

        private void Tara_Click(object sender, RoutedEventArgs e)
        {
            var selectedMovies = Movies.Where(m => m.ProductionCountries.Contains("USA") || m.ProductionCountries.Contains("France")).Distinct();
            MoviesListView.ItemsSource = selectedMovies;
        }

        private void Ansearch_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudents = Students.Where(s => s.BirthDate.Year == 2003);
            StudentsListView.ItemsSource = selectedStudents;
        }

        private void Restanta_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudents = Students.Where(s => s.Grades.Any(g => g < 5)).Distinct();
            StudentsListView.ItemsSource = selectedStudents;
        }

        private void Ansearch2_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudents = Students.Where(s => s.EnrollmentYear == 2019);
            StudentsListView.ItemsSource = selectedStudents;
        }
    }
}
