

using IMS_Services.Manager;
using IMS_Services.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Utils;

public class LoadComboBoxes
{
    private static DatabaseConnection connection = DatabaseConnection.Instance;
    public static void LoadCategoryCBO(ComboBox comboBox)
    {
        string query = "SELECT CategoryID, CategoryName FROM tbCategory";
        List<Category> list = new List<Category>();
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        //comboBox.Items.Add(new Category()
                        //{ 
                        //    ID = reader.GetByte("CategoryID"),
                        //    Name = reader.GetString("CategoryName"),
                        //});
                        list.Add(new Category()
                        {
                            ID = reader.GetByte("CategoryID"),
                            Name = reader.GetString("CategoryName"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "ID";
        comboBox.DisplayMember = "Name";
        comboBox.SelectedIndex = -1;
    }
    public static void LoadProductCBO(ComboBox comboBox)
    {
        string query = "SELECT ProductID, ProductName FROM tbProduct";
        List<Product> list = new List<Product>();
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            ID = reader.GetInt32("ProductID"),
                            Name = reader.GetString("ProductName"),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        comboBox.DataSource = list;
        comboBox.ValueMember = "ID";
        comboBox.DisplayMember = "Name";
        comboBox.SelectedIndex = -1;
    }
    public static void LoadImportID(ComboBox comboBox)
    {
        string query = "SELECT ImportID FROM tbImport ORDER BY ImportID DESC";
        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox.Items.Clear();
                try
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader.GetInt32("ImportID"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        comboBox.SelectedIndex = -1;
    }

}
