using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing.Text;
using System.Reflection;
using System.IO;
using System;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace GeometryFigures
{
    public partial class Form1 : Form
    {
        private PrivateFontCollection fontCollection = new PrivateFontCollection();
        List<BaseObject> FiguresList = new List<BaseObject>();
        DatabaseManager dbManager = new DatabaseManager();
        SQLiteConnection connection;

        Image genOn = Image.FromFile(FileHelper.GetMat("but_gen_.png"));
        Image genHov = Image.FromFile(FileHelper.GetMat("but_gen_hovered.png"));
        Image moreOn = Image.FromFile(FileHelper.GetMat("but_more_on.png"));
        Image moreOff = Image.FromFile(FileHelper.GetMat("but_more_off.png"));
        Image moreOnHov = Image.FromFile(FileHelper.GetMat("but_more_on_hovered.png"));
        Image moreOffHov = Image.FromFile(FileHelper.GetMat("but_more_off_hovered.png"));
        Image lessOn = Image.FromFile(FileHelper.GetMat("but_less_on.png"));
        Image lessOff = Image.FromFile(FileHelper.GetMat("but_less_off.png"));
        Image lessOnHov = Image.FromFile(FileHelper.GetMat("but_less_on_hovered.png"));
        Image lessOffHov = Image.FromFile(FileHelper.GetMat("but_less_off_hovered.png"));
        Image plotnostOn = Image.FromFile(FileHelper.GetMat("but_plotnost_on.png"));
        Image plotnostOff = Image.FromFile(FileHelper.GetMat("but_plotnost_off.png"));
        Image plotnostOnHov = Image.FromFile(FileHelper.GetMat("but_plotnost_on_hovered.png"));
        Image plotnostOffHov = Image.FromFile(FileHelper.GetMat("but_plotnost_off_hovered.png"));
        Image priceOn = Image.FromFile(FileHelper.GetMat("but_price_on.png"));
        Image priceOff = Image.FromFile(FileHelper.GetMat("but_price_off.png"));
        Image priceOnHov = Image.FromFile(FileHelper.GetMat("but_price_on_hovered.png"));
        Image priceOffHov = Image.FromFile(FileHelper.GetMat("but_price_off_hovered.png"));
        Image pricekgOn = Image.FromFile(FileHelper.GetMat("but_pricekg_on.png"));
        Image pricekgOff = Image.FromFile(FileHelper.GetMat("but_pricekg_off.png"));
        Image pricekgOnHov = Image.FromFile(FileHelper.GetMat("but_pricekg_on_hovered.png"));
        Image pricekgOffHov = Image.FromFile(FileHelper.GetMat("but_pricekg_off_hovered.png"));
        Image idOn = Image.FromFile(FileHelper.GetMat("but_id_on.png"));
        Image idOff = Image.FromFile(FileHelper.GetMat("but_id_off.png"));
        Image idOnHov = Image.FromFile(FileHelper.GetMat("but_id_on_hovered.png"));
        Image idOffHov = Image.FromFile(FileHelper.GetMat("but_id_off_hovered.png"));

        public Form1()
        {
            InitializeComponent();

            but_id.Tag = 0;
            but_price.Tag = 0;
            but_pricekg.Tag = 0;
            but_den.Tag = 0;
            but_more.Tag = 0;
            but_less.Tag = 0;
            fontCollection.AddFontFile(FileHelper.GetMat("Inter-Regular.ttf"));
            fontCollection.AddFontFile(FileHelper.GetMat("Inter-SemiBold.ttf"));
            label1.Font = new Font(fontCollection.Families[0], 13);
            dataGridView1.DefaultCellStyle.Font = new Font(fontCollection.Families[0], 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(fontCollection.Families[1], 11);
            connection = dbManager.GetConnection();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            but_id.PerformClick();
            but_more.PerformClick();
        }

        private void GenerateFigures(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                Random randomValues = new Random(Guid.NewGuid().GetHashCode());
                double length = DoubleGenerator(3, 0.001, 3, randomValues, out length);
                double width = DoubleGenerator(3, 0.001, 3, randomValues, out width);
                double depth = DoubleGenerator(3, 0.001, 3, randomValues, out depth);
                double weight = 1;

                int randomFigure = randomValues.Next(1, 7);
                BaseObject baseobject;
                switch (randomFigure)
                {
                    case 0:
                        baseobject = new Cube(length, length, length, weight);
                        break;

                    case 1:
                        baseobject = new Cone(length, width, depth, weight);
                        break;

                    case 2:
                        baseobject = new Cylinder(length, width, depth, weight);
                        break;

                    case 3:
                        baseobject = new Parallelepiped(length, width, depth, weight);
                        break;

                    case 4:
                        baseobject = new Pyramid(length, width, depth, weight);
                        break;

                    case 5:
                        baseobject = new Sphere(length, width, depth, weight);
                        break;

                    default: 
                        baseobject = new Cube(length, width, depth, weight);
                        break;
                }

                baseobject.CalculateArea();
                baseobject.CalculateVolume();
                // Сделано, чтобы не генерировались объекты с нереалистичным соотношением веса и объема.
                baseobject.CalculateGoodWeight(randomValues);
                GetPricePKGAndDensity(baseobject);
                AddToList(baseobject, i+1, quantity);
                //MessageBox.Show($"{baseobject.Type} добавлен по номеру {i+1} из {quantity}");
            }
        }

        private double DoubleGenerator(double max, double min, int roundDepth, Random random, out double result)
        {
            return result = Math.Round(random.NextDouble() * (max - min) + min, roundDepth);
        }

        private void GetPricePKGAndDensity(BaseObject baseobject)
        {
            baseobject.CalculateDensity();
            double nearestDensity = 0;
            double targetDensity = baseobject.Density;
            string materialName = "";
            double pricePerKilogram = 0;

            string[] lines = File.ReadAllLines((FileHelper.GetMat("density.txt")));
            int lineIndex = -1;
            int correctLineIndex = -1;

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                lineIndex++;

                if (parts.Length == 3)
                {
                    double density = double.Parse(parts[0].Trim());
                    string name = parts[1].Trim();
                    double price = double.Parse(parts[2].Split(new char[] { ' ' })[1]);

                    if (nearestDensity == 0 || Math.Abs(targetDensity - density) < Math.Abs(targetDensity - nearestDensity) && (targetDensity / density < 1.05 || targetDensity < 2700))
                    {
                        nearestDensity = density;
                        materialName = name;
                        pricePerKilogram = price;
                        correctLineIndex = lineIndex;
                    }
                }
                else
                {
                    MessageBox.Show("Ого! Кажется, файл отвалился... Чинить надо!");
                    this.Close();
                }
            }

            baseobject.Material = materialName;
            baseobject.PricePerKg = pricePerKilogram;
            baseobject.CalculatePrice();
        }

        private void AddToList(BaseObject baseobject, int number, int targetQuantity)
        {
            FiguresList.Add(baseobject);
            if (number == targetQuantity)
            {
                foreach (var f in FiguresList)
                {
                    dbManager.AddData(f);
                }
                if (dbManager.SetData(dataGridView1) == true)
                {
                    MessageBox.Show("Успешно.");
                    FiguresList.Clear();
                };
            }
        }

        private void button_gen_Click(object sender, EventArgs e)
        {
            FiguresList.Clear();
            dbManager.ClearData();
            dataGridView1.Refresh();
            GenerateFigures(100);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 || e.ColumnIndex == 9)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double value))
                {
                    // Если число меньше 1, то не округляем
                    if (value < 1)
                    {
                        e.Value = value.ToString();
                    }
                    else
                    {
                        string formattedValue = string.Format("{0:#,##0}", value);
                        e.Value = formattedValue;
                    }

                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex > 4 && e.ColumnIndex < 8)
            {
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double value))
                {
                    if (value >= 0)
                    {
                        string formattedValue = value.ToString("#,##0.0000"); 
                        e.Value = formattedValue;
                    }
                }
                e.FormattingApplied = true;
            }
        }

        private void button_gen_MouseEnter(object sender, EventArgs e)
        {
            button_gen.BackgroundImage = genHov;
        }

        private void button_gen_MouseLeave(object sender, EventArgs e)
        {
            button_gen.BackgroundImage = genOn;
        }

        private void but_id_Click(object sender, EventArgs e)
        {
            if ((int)but_id.Tag != 1)
            {
                but_id.Tag = 1;
                but_price.Tag = 0;
                but_pricekg.Tag = 0;
                but_den.Tag = 0;
                but_id.BackgroundImage = idOn;
                but_price.BackgroundImage = priceOff;
                but_pricekg.BackgroundImage = pricekgOff;
                but_den.BackgroundImage = plotnostOff;
                SetSort();
            }
        }

        private void but_id_MouseEnter(object sender, EventArgs e)
        {
            if ((int)but_id.Tag != 1)
            {
                but_id.BackgroundImage = idOffHov;
            }
            else
            {
                but_id.BackgroundImage = idOnHov;
            }
        }

        private void but_id_MouseLeave(object sender, EventArgs e)
        {
            if ((int)but_id.Tag != 1)
            {
                but_id.BackgroundImage = idOff;
            }
            else
            {
                but_id.BackgroundImage = idOn;
            }
        }

        private void button_sort_price_Click(object sender, EventArgs e)
        {
            if ((int)but_price.Tag != 1)
            {
                but_id.Tag = 0;
                but_price.Tag = 1;
                but_pricekg.Tag = 0;
                but_den.Tag = 0;
                but_price.BackgroundImage = priceOn;
                but_id.BackgroundImage = idOff;
                but_pricekg.BackgroundImage = pricekgOff;
                but_den.BackgroundImage = plotnostOff;
                SetSort();
            }
        }

        private void button_sort_price_MouseEnter(object sender, EventArgs e)
        {
            if ((int)but_price.Tag != 1)
            {
                but_price.BackgroundImage = priceOffHov;
            }
            else
            {
                but_price.BackgroundImage = priceOnHov;
            }
        }

        private void button_sort_price_MouseLeave(object sender, EventArgs e)
        {
            if((int)but_price.Tag != 1)
            {
                but_price.BackgroundImage = priceOff;
            }
            else
            {
                but_price.BackgroundImage = priceOn;
            }
        }

        private void but_pricekg_Click(object sender, EventArgs e)
        {
            if ((int)but_pricekg.Tag != 1)
            {
                but_id.Tag = 0;
                but_price.Tag = 0;
                but_pricekg.Tag = 1;
                but_den.Tag = 0;
                but_price.BackgroundImage = priceOff;
                but_id.BackgroundImage = idOff;
                but_pricekg.BackgroundImage = pricekgOn;
                but_den.BackgroundImage = plotnostOff;
                SetSort();
            }
        }

        private void but_pricekg_MouseEnter(object sender, EventArgs e)
        {
            if ((int)but_pricekg.Tag != 1)
            {
                but_pricekg.BackgroundImage = pricekgOffHov;
            }
            else
            {
                but_pricekg.BackgroundImage = pricekgOnHov;
            }
        }

        private void but_pricekg_MouseLeave(object sender, EventArgs e)
        {
            if ((int)but_pricekg.Tag != 1)
            {
                but_pricekg.BackgroundImage = pricekgOff;
            }
            else
            {
                but_pricekg.BackgroundImage = pricekgOn;
            }
        }

        private void but_den_Click(object sender, EventArgs e)
        {
            if ((int)but_den.Tag != 1)
            {
                but_id.Tag = 0;
                but_price.Tag = 0;
                but_pricekg.Tag = 0;
                but_den.Tag = 1;
                but_price.BackgroundImage = priceOff;
                but_id.BackgroundImage = idOff;
                but_pricekg.BackgroundImage = pricekgOff;
                but_den.BackgroundImage = plotnostOn;
                SetSort();
            }
        }

        private void but_den_MouseEnter(object sender, EventArgs e)
        {
            if ((int)but_den.Tag != 1)
            {
                but_den.BackgroundImage = plotnostOffHov;
            }
            else
            {
                but_den.BackgroundImage = plotnostOnHov;
            }
        }

        private void but_den_MouseLeave(object sender, EventArgs e)
        {
            if ((int)but_den.Tag != 1)
            {
                but_den.BackgroundImage = plotnostOff;
            }
            else
            {
                but_den.BackgroundImage = plotnostOn;
            }
        }

        private void but_more_Click(object sender, EventArgs e)
        {
            if ((int)but_more.Tag != 1)
            {
                but_more.Tag = 1;
                but_less.Tag = 0;
                but_more.BackgroundImage = moreOn;
                but_less.BackgroundImage = lessOff;
                SetSort();
            }
        }

        private void but_more_MouseEnter(object sender, EventArgs e)
        {
            if ((int)but_more.Tag != 1)
            {
                but_more.BackgroundImage = moreOffHov;
            }
            else
            {
                but_more.BackgroundImage = moreOnHov;
            }
        }

        private void but_more_MouseLeave(object sender, EventArgs e)
        {
            if ((int)but_more.Tag != 1)
            {
                but_more.BackgroundImage = moreOff;
            }
            else
            {
                but_more.BackgroundImage = moreOn;
            }
        }

        private void but_less_Click(object sender, EventArgs e)
        {
            if ((int)but_less.Tag != 1)
            {
                but_more.Tag = 0;
                but_less.Tag = 1;
                but_more.BackgroundImage = moreOff;
                but_less.BackgroundImage = lessOn;
                SetSort();
            }
        }

        private void but_less_MouseEnter(object sender, EventArgs e)
        {
            if ((int)but_less.Tag != 1)
            {
                but_less.BackgroundImage = lessOffHov;
            }
            else
            {
                but_less.BackgroundImage = lessOnHov;
            }
        }

        private void but_less_MouseLeave(object sender, EventArgs e)
        {
            if ((int)but_more.Tag != 1)
            {
                but_more.BackgroundImage = moreOff;
            }
            else
            {
                but_more.BackgroundImage = moreOn;
            }
        }

        private void SetSort()
        {
            if ((int)but_id.Tag == 1) dbManager.field = DatabaseManager.Fields.id;
            else if ((int)but_price.Tag == 1) dbManager.field = DatabaseManager.Fields.price;
            else if ((int)but_pricekg.Tag == 1) dbManager.field = DatabaseManager.Fields.price_per_kg;
            else if ((int)but_den.Tag == 1) dbManager.field = DatabaseManager.Fields.density;

            if ((int)but_more.Tag == 1) dbManager.sortorder = DatabaseManager.SortOrders.ASC;
            else if ((int)but_less.Tag == 1) dbManager.sortorder = DatabaseManager.SortOrders.DESC;


            if (dataGridView1.DataSource != null) dbManager.SetData(dataGridView1);
        }
    }
}
