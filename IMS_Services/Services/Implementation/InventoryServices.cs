#define COL_MAPPING


using IMS_Services.Entities;
using IMS_Services.Manager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;




namespace IMS_Services.Services.Implementation;

public class InventoryServices : ICRUDServices<Inventory, int>
{
    private static DatabaseConnection connection = DatabaseConnection.Instance;

    public const string INV_TB_NAME = "tbInventory";
    public const string INV_COL_ID = "InvID";
    public const string INV_COL_UNITCOST = "UnitCost";
    public const string INV_COL_EXPDATE = "ExpirationDate";
    public const string INV_COL_CURRSTOCK = "CurrentStock";
    public const string INV_COL_INITQTY = "InitialQty";
    public const string INV_COL_NOTE = "Note";
    public const string INV_COL_LAST_UPDATE = "LastUpdate";
    public const string INV_COL_PRO_ID = "ProductID";
    public const string INV_COL_IMP_ID = "ImportID";
    
    public static int Add(Inventory entity)
    {
        throw new NotImplementedException();
    }
    public static DataRow AddRow(DataTable table, Inventory inv)
    {
        var row = table.NewRow();
        
        row[INV_COL_ID] = inv.UnitCost;
        row[INV_COL_UNITCOST] = inv.UnitCost;
        row[INV_COL_EXPDATE] = inv.ExpirationDate;
        row[INV_COL_CURRSTOCK] = inv.CurrentStock;
        row[INV_COL_INITQTY] = inv.InitialQty;
        row[INV_COL_NOTE] = inv.Note;
        row[INV_COL_LAST_UPDATE] = inv.LastUpdate;
        row[INV_COL_PRO_ID] = inv.ProductID;
       
        return row;
    }

    public static SqlBulkCopy Submit(string tableName)
    {

        SqlBulkCopy bulkCopy = new SqlBulkCopy(connection.GetConnection());
        bulkCopy.DestinationTableName = tableName;

    #if COL_MAPPING
        // Map the columns in the source DataTable to the columns in the destination table
        
        bulkCopy.ColumnMappings.Add(INV_COL_UNITCOST, INV_COL_UNITCOST);
        bulkCopy.ColumnMappings.Add(INV_COL_EXPDATE, INV_COL_EXPDATE);
        bulkCopy.ColumnMappings.Add(INV_COL_CURRSTOCK, INV_COL_CURRSTOCK);
        bulkCopy.ColumnMappings.Add(INV_COL_INITQTY, INV_COL_INITQTY);
        bulkCopy.ColumnMappings.Add(INV_COL_LAST_UPDATE, INV_COL_LAST_UPDATE);
        bulkCopy.ColumnMappings.Add(INV_COL_PRO_ID, INV_COL_PRO_ID);
        bulkCopy.ColumnMappings.Add(INV_COL_NOTE, INV_COL_NOTE);
        bulkCopy.ColumnMappings.Add(INV_COL_IMP_ID, INV_COL_IMP_ID);
#endif

        return bulkCopy;
        
    }

    public static bool Delete(int id)
    {
        throw new NotImplementedException();
    }
    public static void RetrieveData(DataTable table)
    {
        table.Rows.Clear();
        string read_query = "SELECT * FROM tbInventory";
        SqlDataAdapter da = new SqlDataAdapter(read_query, connection.GetConnection());
        da.Fill(table);
    }
    public static IEnumerable<Inventory> GetAll()
    {
        string query = "SELECT * FROM tbInventory";

        using (SqlCommand cmd = new SqlCommand(query, connection.GetConnection()))
        {
            SqlDataReader? reader = null;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in getting all inventory > {ex.Message}");
            }

            if (reader != null && reader.HasRows == true)
            {
                var queryable = reader.Cast<IDataRecord>().AsQueryable();
                foreach (var record in queryable)
                {
                    yield return record.ToInventory();
                }
            }
            reader?.Close();

        }
    }

    public static Inventory GetById(int id)
    {
        throw new NotImplementedException();
    }

    public static IEnumerable<Inventory> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public static bool Update(Inventory entity)
    {
        throw new NotImplementedException();
    }
}
