
using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Controller.InventoryFormController;

public partial class InventoryForm : Form
{
    BindingSource bs = new BindingSource();
    DataTable tblInv = new DataTable("tbInventory");
    public InventoryForm()
    {
        InitializeComponent();
        InventoryServices.RetrieveData(tblInv);
        bs.DataSource = tblInv;
        dgvInventory.DataSource = bs;
        ConfigView();
        btnAdd.Click += DoClickAddInventory;

    }

    private void ConfigView()
    {
        dgvInventory.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvInventory.Columns["LastUpdate"].DefaultCellStyle.Format = "dd/MM/yyyy";


        dgvInventory.Columns["InvID"].Width = 200;
    }
    private void DoClickAddInventory(object? sender, EventArgs e)
    {
        SubInventory.Table = tblInv.Clone();
        SubInventory subInventory = new SubInventory();
        subInventory.InventoryModified += (sender) => InventoryServices.RetrieveData(tblInv);
        subInventory.Show();
    }

    #region method

    private void LoadData()
    {
        
    }
    private void AddToView(Inventory inventory)
    {
        dgvInventory.Rows.Add(inventory.ID, inventory.UnitCost, inventory.CurrentStock, inventory.InitialQty, inventory.Note, inventory.ExpirationDate, 
            inventory.LastUpdate, inventory.ImportID, inventory.ProductID);
    }

    #endregion
}
