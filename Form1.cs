using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BirthdayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            int daysUntilMonday = ((int)today.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            DateTime nearestMonday = today.AddDays(-daysUntilMonday);
            string temp;
            // блок взаимодействия с базой данных (чтение)
            using (var connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=BirthdaysDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                
                var query = "SELECT * FROM Persons INNER JOIN Dates ON Persons.DatesID = Dates.Id";
                var result = connection.Query<Person, BirthdayList.Date, Person>(query, (person, date) =>
                {
                    person.Date = date;
                    return person;
                },
                splitOn: "DatesID");
                // заполняем дни недели именниниками
                for(int i = 0; i < 7; i++)
                {
                    int k = 1;
                    var dayofweek = result.Where(x => x.Date.Birthday == nearestMonday.AddDays(i));
                    foreach (var person in dayofweek)
                    {
                        FullNameUserControl fullNameUserControl = new FullNameUserControl(person.FirstName, person.LastName);
                        fullNameUserControl.Location = new System.Drawing.Point(3, 50 * k);
                        if (i == 0) mon_panel.Controls.Add(fullNameUserControl);
                        if (i == 1) tue_panel.Controls.Add(fullNameUserControl);
                        if (i == 2) wed_panel.Controls.Add(fullNameUserControl);
                        if (i == 3) thu_panel.Controls.Add(fullNameUserControl);
                        if (i == 4) fri_panel.Controls.Add(fullNameUserControl);
                        if (i == 5) sat_panel.Controls.Add(fullNameUserControl);
                        if (i == 6) sun_panel.Controls.Add(fullNameUserControl);
                        k++;
                    }
                }
            }
            // отображаем на панеле "Неделя" панели дни с датой и именниниками если есть
            temp = nearestMonday.ToString("d:MM");
            mon_date_lb.Text = temp;
            mon_date_lb.Text = temp;
            temp = nearestMonday.AddDays(1).ToString("d:MM");
            tu_date_lb.Text = temp;
            temp = nearestMonday.AddDays(2).ToString("d:MM");
            wed_date_lb.Text = temp;
            temp = nearestMonday.AddDays(3).ToString("d:MM");
            thur_date_lb.Text = temp;
            temp = nearestMonday.AddDays(4).ToString("d:MM");
            fri_date_lb.Text = temp;
            temp=nearestMonday.AddDays(5).ToString("d:MM");
            sat_date_lb.Text = temp;
            temp = nearestMonday.AddDays(6).ToString("d:MM");
            sun_date_lb.Text = temp;
        }

        private void month_rb_CheckedChanged(object sender, EventArgs e)
        {
            show_panel.Controls.Clear();
            DateTime today = DateTime.Today;
            int year = today.Year;
            int month = today.Month;
            int daysInMonth = DateTime.DaysInMonth(year, month);
        }

        private void week_rd_CheckedChanged(object sender, EventArgs e)
        {
            show_panel.Controls.Clear();
            this.show_panel.Controls.Add(this.sun_panel);
            this.show_panel.Controls.Add(this.sat_panel);
            this.show_panel.Controls.Add(this.wed_panel);
            this.show_panel.Controls.Add(this.fri_panel);
            this.show_panel.Controls.Add(this.thu_panel);
            this.show_panel.Controls.Add(this.tue_panel);
            this.show_panel.Controls.Add(this.mon_panel);
        }

        private void all_rb_CheckedChanged(object sender, EventArgs e)
        {
            show_panel.Controls.Clear();
        }

        public IEnumerable<Person> GetPersonWithBirthday()
        {
            using (var connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=BirthdaysDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();

                var query = "SELECT * FROM Persons INNER JOIN Dates ON Persons.DatesID = Dates.Id";
                var result = connection.Query<Person, BirthdayList.Date, Person>(query, (person, date) =>
                {
                    person.Date = date;
                    return person;
                },
                splitOn: "DatesID");
                return result;
            }
        }
     }
}
