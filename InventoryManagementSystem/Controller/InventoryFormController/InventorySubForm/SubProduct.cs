﻿

using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Validation;
using InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm;
using InventoryManagementSystem.Utils;
using System.Windows.Forms;

namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    public partial class SubProduct : Form
    {


        private static SubProduct instance = null!;
        private Control[] controls;
        public static Product? product { get; set; } = null;
        public SubProduct()
        {
            InitializeComponent();
            cboUOM.DataSource = Enum.GetValues<EnumUOM>();
            cboUOM.SelectedIndex = -1;
            LoadComboBoxes.LoadCategoryCBO(cboCategory);
            controls = new Control[]
            {
                txtId,
                txtName,
                txtBarCode,
                txtSalePrice,
                cboUOM,
                nudTotalStock,
                cboCategory,
            };
            if (product == null)
                btnSubmit.Click += DoClickAdd;
            else if (product != null)
            {
                LoadEntities.LoadProductFromObject(controls, product!);
                btnSubmit.Click += DoClickUpdate;
            }
        }

       
        #region click
        private void DoClickAdd(object? sender, EventArgs e)
        {
            try
            {
                if (IsProductValid())
                {
                    // create instance product
                    Product product = CreatorEntities.CreateProduct(controls);

                    // add product to database
                    ProductServices.Add(product);

                    //clear control
                    Util.ClearControls(controls);

                    PersonModified?.Invoke(this);
                    // show message to user
                    MessageBox.Show($"Product Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Some Inputs are missing or not correct format!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoClickUpdate(object? sender, EventArgs e)
        {
            try
            {
               
                if (IsProductValid())
                {
                    // create instance product
                    Product product = CreatorEntities.CreateProduct(controls);

                    // assign staff id for product
                    product.ID = int.Parse(txtId.Text);

                    // add product to database
                    bool effected = ProductServices.Update(product);

                    if (effected)
                    {
                        MessageBox.Show($"Product ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Util.ClearControls(controls);
                        PersonModified?.Invoke(this);
                    }
                    else
                    {
                        MessageBox.Show($"Error Updating Data", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //clear control
                    Util.ClearControls(controls);

                }
                else
                {
                    MessageBox.Show("Some Inputs are missing or not correct format!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region method

        private void LoadProductData()
        {

        }
        #endregion


        #region Validation


        private bool IsProductValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
            return isVilid;
        }

        #endregion

        #region SingleTon For Only Show One Form
        public static SubProduct GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SubProduct();
            }
            return instance;
        }
        public new void Show()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = this;
                base.Show();
            }
            else
            {
                // Bring the existing form to the front if already open
                instance.BringToFront();
            }
        }
        #endregion


        public event PersonEventHandler? PersonModified;
    }
}
