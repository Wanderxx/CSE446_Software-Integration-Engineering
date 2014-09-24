using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;

public partial class _Default : System.Web.UI.Page
{
    class course
    {
       public string Coursecode { get; set; }
       public string Title { get; set; }
       public string Instructor { get; set; }
       public string Cap { get; set; }
    }
    class instructor
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string OfficeNum { get; set; }
       public string Courses { get; set; }
    }
    static List<course> courses = new List<course>();  //1.3
    static List<instructor> instructors = new List<instructor>();  //1.5

    protected void Page_Load(object sender, EventArgs e)
    {
        CoursesClassesDataContext db = new CoursesClassesDataContext();
        Table<myCourse> coureseTab = db.GetTable<myCourse>();
      //   List<course> courses = new List<course>();
        foreach (var cor in coureseTab)
        {
            courses.Add(new course{Coursecode=cor.CourseCode,Title=cor.Title,
                Instructor=cor.Instructor,Cap=cor.Cap});
        }
        Table<Instructors> instructorTab = db.GetTable<Instructors>();
     //   List<instructor> instructors = new List<instructor>();
        foreach (var ins in instructorTab) {
            instructors.Add(new instructor { FirstName = ins.FirstName, LastName = ins.LastName, OfficeNum = ins.OfficeNum, Courses = ins.Courses });
        }

        

    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //1.6a
        IEnumerable<string> query =
            from course in courses
            where Convert.ToInt32(course.Coursecode) > 300
            orderby course.Cap
            select course.Title + "" + course.Instructor;
        foreach (string name in query) {
            TextBox1.Text = TextBox1.Text + name + Environment.NewLine;   
        }
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        //1.6b
        var courseGroups =
            from course in courses
            group course.Title by course.Coursecode into g
            select new { code = g.Key, Tit = g };
        foreach (var g in courseGroups) {
            TextBox2.Text =TextBox2.Text  + "Courses with course code: " + g.code + "are courses:";
            foreach (var t in g.Tit) {
                TextBox2.Text = TextBox2.Text + Environment.NewLine + t + Environment.NewLine; 
            }
        }
    }



    //1.6c
    protected void Button3_Click(object sender, EventArgs e)
    {
        var mixGroups =
            from course in courses
            join instructor in instructors
            on course.Instructor equals instructor.LastName
            group course by new { course.Instructor, instructor.OfficeNum } into g
            select new { name = g.Key.Instructor, office = g.Key.OfficeNum };
        foreach (var g in mixGroups)
        {
            TextBox3.Text = TextBox3.Text + "The instructor:" + g.name + "works in:" + g.office + Environment.NewLine;
        }
    }
}