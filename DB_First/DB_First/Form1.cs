using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities northwindEntities = new NorthwindEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Categories.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Products.Select(x => new 
                                                    {
                                                        x.ProductID,
                                                        x.ProductName,
                                                        x.UnitPrice,
                                                        x.UnitsInStock,
                                                        x.CategoryID
                                                    }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
                                                                  .Select(x => new
                                                                  {
                                                                      x.ProductID,
                                                                      x.ProductName,
                                                                      x.UnitPrice,
                                                                      x.UnitsInStock
                                                                  }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Category category = northwindEntities.Categories.FirstOrDefault(x => x.CategoryID > 7);

            if (category == null)
                MessageBox.Show("Aradığınız kategori bulunmamaktadır..!");
            else
                MessageBox.Show($"ID:{category.CategoryID}\nName: {category.CategoryName}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Products.OrderByDescending(x => x.UnitPrice)
                                      .Skip(5)
                                      .Take(5)
                                      .ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Employees.Where(x => x.FirstName.Contains("m"))
                                       .OrderBy(x => x.FirstName)
                                       .Select(x => new
                                       {
                                           x.EmployeeID,
                                           x.FirstName,
                                           x.LastName,
                                           x.Title
                                       }).ToList();
        }
    }
}
