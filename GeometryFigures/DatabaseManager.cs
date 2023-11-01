using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeometryFigures
{
    public class DatabaseManager
    {
        private const string DatabaseFileName = "geometry_database.db";
        private const string TableName = "geometry_figures";
        public Fields field = Fields.id;
        public SortOrders sortorder = SortOrders.ASC;

        private SQLiteConnection connection;

        public DatabaseManager()
        {
            // Проверяем наличие файла базы данных и создаём, если его нет
            if (!File.Exists(DatabaseFileName))
            {
                SQLiteConnection.CreateFile(DatabaseFileName);
            }

            // Создаем соединение
            connection = new SQLiteConnection($"Data Source={DatabaseFileName};Version=3;");

            // Подключаемся к базе данных
            connection.Open();

            string dropQuery = @"DROP TABLE IF EXISTS geometry_figures";

            // Проверяем наличие таблицы и создаем, если не нашлась
            string createTableQuery = @"
    CREATE TABLE IF NOT EXISTS geometry_figures (
        id INTEGER PRIMARY KEY,
        type TEXT,
        length REAL,
        width REAL,
        height REAL,
        weight REAL,
        volume REAL,
        area REAL,
        price REAL,
        price_per_kg REAL,
        density REAL,
        material_type TEXT
    );
";
            SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);
            SQLiteCommand dropQuery1 = new SQLiteCommand(dropQuery, connection);
            dropQuery1.ExecuteNonQuery();
            createTableCommand.ExecuteNonQuery();

        }

        public void AddData(BaseObject baseobject)
        {
            try
            {
                string insertQuery = @"
    INSERT INTO geometry_figures (type, length, width, height, weight, volume, area, price, price_per_kg, density, material_type)
    VALUES (@type, @length, @width, @height, @weight, @volume, @area, @price, @price_per_kg, @density, @material_type)
";

                using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@type", baseobject.Type);
                    cmd.Parameters.AddWithValue("@length", baseobject.Length);
                    cmd.Parameters.AddWithValue("@width", baseobject.Width);
                    cmd.Parameters.AddWithValue("@height", baseobject.Depth);
                    cmd.Parameters.AddWithValue("@weight", baseobject.Weight);
                    cmd.Parameters.AddWithValue("@volume", baseobject.Volume);
                    cmd.Parameters.AddWithValue("@area", baseobject.Area);
                    cmd.Parameters.AddWithValue("@price", baseobject.Price);
                    cmd.Parameters.AddWithValue("@price_per_kg", baseobject.PricePerKg);
                    cmd.Parameters.AddWithValue("@density", baseobject.Density);
                    cmd.Parameters.AddWithValue("@material_type", baseobject.Material);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (System.Exception)
            {

                MessageBox.Show("Произошла ошибка занесения объекта. Попробуйте провести генерацию еще раз.");
            }
        }

        public void ClearData()
        {
            try
            {
                string connectionString = $"Data Source={DatabaseFileName};Version=3;";
                string query = "DELETE FROM geometry_figures";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception)
            {

                MessageBox.Show("Произошла ошибка удаления данных из БД. Попробуйте перезапустить программу.");
            }
        }

        public bool SetData(DataGridView dataGridView1)
        {
            try
            {
                string connectionString = $"Data Source={DatabaseFileName};Version=3;";
                string query = SortData(TableName, field.ToString(), sortorder.ToString());

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            if (dataGridView1.DataSource == null)
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                dataGridView1.DataSource = dt;

                                dataGridView1.Columns["type"].HeaderText = "Тип";
                                dataGridView1.Columns["length"].HeaderText = "Длина, м";
                                dataGridView1.Columns["width"].HeaderText = "Ширина, м";
                                dataGridView1.Columns["height"].HeaderText = "Высота, м";
                                dataGridView1.Columns["weight"].HeaderText = "Масса, кг";
                                dataGridView1.Columns["volume"].HeaderText = "Объем, м³";
                                dataGridView1.Columns["area"].HeaderText = "Площадь, м²";
                                dataGridView1.Columns["price"].HeaderText = "Цена, ₽";
                                dataGridView1.Columns["price_per_kg"].HeaderText = "Цена за кг, ₽";
                                dataGridView1.Columns["density"].HeaderText = "Плотность, кг/м³";
                                dataGridView1.Columns["material_type"].HeaderText = "Материал";
                            }
                            else
                            {
                                DataTable dt = (DataTable)dataGridView1.DataSource;
                                dt.Clear();
                                adapter.Fill(dt);
                            }
                            dataGridView1.Refresh();
                        }
                    }
                }

                return true;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Произошла ошибка вывода данных.");
                return false;
            }
        }

        public string SortData(string TableName, string field, string ascendingOrder)
        {
            return $"SELECT * FROM {TableName} ORDER BY {field} {ascendingOrder};";
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        public enum Fields
        {
            id,
            price,
            price_per_kg,
            density
        }

        public enum SortOrders
        {
            ASC,
            DESC
        }
    }

}
