using System;
using System.Collections.Generic;
using static System.Configuration.ConfigurationManager;
using System.Data.SqlClient;
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
using Dapper;
using OneToMany.Entities;

namespace OneToMany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var conn=new SqlConnection(ConnectionStrings["MyConnString"].ConnectionString))
            {
                //var sql = @"select S.StudentId,S.Firstname,S.Age,
                //            G.GroupId,G.Title
                //            from Students as S
                //            inner join Groups as G
                //            on S.GroupId=G.GroupId";
                //var students = conn.Query<Student, Group, Student>(sql,
                //    (student, group) =>
                //    {
                //        student.Group = group; student.GroupId = group.GroupId;
                //        return student;
                //    }, splitOn: "GroupId").ToList();
                //mydatagrid.ItemsSource = students;

                //var sql = @"select G.GroupId,G.Title,S.StudentId,S.Firstname,S.Age
                //        from Groups as G
                //        inner join Students as S
                //        on S.GroupId=G.GroupId";
                //var groups = conn.Query<Group, Student, Group>(sql,
                //    (group, student) => {
                //        group.Students.Add(student);
                //        return group;
                //    },splitOn:"StudentId");

                //mydatagrid.ItemsSource = groups;

            }

        }
    }
}
