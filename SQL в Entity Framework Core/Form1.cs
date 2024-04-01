using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace SQL_в_Entity_Framework_Core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowAll(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT * FROM Products").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AllByName(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT * FROM Products").OrderBy(b => b.Name).ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AllByColor(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT * FROM Products").ToList();
                    List<string> c = new List<string>();
                    foreach (var item in prod)
                    {
                        c.Add("Цвет: " + item.Color!);
                    }
                    listBox1.DataSource = c;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ByMaxCal(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT TOP 1 * FROM Products ORDER BY Calories DESC").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByMinCal(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT TOP 1 * FROM Products ORDER BY Calories").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByAvgCal(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("FindAVGCal").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByColor(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    SqlParameter color = new SqlParameter("@Color", textBox1.Text);
                    var prod = db.Products.FromSqlRaw("FindByColor @Color", color).ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByColorСount(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT * FROM Products").ToList();
                    var colorCounts = prod.GroupBy(p => p.Color)
                                         .Select(g => new { Color = g.Key, Count = g.Count() });
                    List<string> res = new List<string>();
                    foreach (var colorCount in colorCounts)
                    {
                        res.Add($"Цвет: {colorCount.Color}, Кол-во: {colorCount.Count}");
                    }
                    listBox1.DataSource = res;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByCaloriesMin(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    SqlParameter min = new SqlParameter("@minCalories", Convert.ToInt32(textBox2.Text));
                    var prod = db.Products.FromSqlRaw("FindMinCal @minCalories", min).ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByCaloriesMax(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    SqlParameter max = new SqlParameter("@maxCalories", Convert.ToInt32(textBox3.Text));
                    var prod = db.Products.FromSqlRaw("FindMaxCal @maxCalories", max).ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByCaloriesMinMax(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    SqlParameter min = new SqlParameter("@minCalories", Convert.ToInt32(textBox2.Text));
                    SqlParameter max = new SqlParameter("@maxCalories", Convert.ToInt32(textBox3.Text));
                    var prod = db.Products.FromSqlRaw("FindMinMaxCal @minCalories, @maxCalories", min, max).ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ByYellowRedColor(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("FindYelowRed").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnlyFruits(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT * FROM Products").Where(n=>n.Type=="Fruit").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnlyVegetables(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    var prod = db.Products.FromSqlRaw("SELECT * FROM Products").Where(n=>n.Type=="Vegetable").ToList();
                    listBox1.DataSource = prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertProduct(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    SqlParameter[] sqlParameters = {
                        new SqlParameter("name", textBox4.Text),
                        new SqlParameter("type", textBox5.Text),
                        new SqlParameter("color", textBox6.Text),
                        new SqlParameter("calories", Convert.ToInt32(textBox7.Text)),
                    };
                    var numberOfRowInserted = db.Database.ExecuteSqlRaw("InsertProduct @name, @type, @color, @calories", sqlParameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteProduct(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseProdContext db = new DatabaseProdContext())
                {
                    Product selectedProduct = (Product)listBox1.SelectedItem!;
                    SqlParameter[] sqlParameters = {
                        new SqlParameter("name", selectedProduct.Name),
                        new SqlParameter("type", selectedProduct.Type),
                        new SqlParameter("color", selectedProduct.Color),
                        new SqlParameter("calories", selectedProduct.Calories),
                    };
                    var numberOfRowInserted = db.Database.ExecuteSqlRaw("DeleteProduct @name, @type, @color, @calories", sqlParameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
                button17.Enabled = true;
        }
    }
}
