using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm;


namespace InventoryManagementSystem.Controller
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            LoadData();

            btnAdd.Click += DoClickAddProduct;
            btnUpdate.Click += DoClickUpdateProduct;
            dgvProduct.Click += DoClickDataGridView;
        }

        private void DoClickDataGridView(object? sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null) return;
        }

        private void DoClickUpdateProduct(object? sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null)
            {
                MessageBox.Show("Please pick a product!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product product = ProductServices.GetById((int)dgvProduct.CurrentRow.Cells[0].Value);
            SubProduct.product = product;
            SubProduct subProduct = new SubProduct();
            
            subProduct.PersonModified += (sender) => LoadData();
            subProduct.Show();
        }

        private void DoClickAddProduct(object? sender, EventArgs e)
        {
            SubProduct subProduct = new SubProduct();
            subProduct.PersonModified += (sender) => LoadData();
            subProduct.Show();
        }

        #region method

        private void LoadData()
        {
            dgvProduct.Rows.Clear();
            var result = ProductServices.GetAll();
            foreach (Product product in result)
            {
                AddToView(product);
            }
        }
        private void AddToView(Product product)
        {
            dgvProduct.Rows.Add(product.ID, product.Barcode, product.Name, product.SalePrice, product.UOM, product.TotalStock, product.CategoryID);
        }

        #endregion
    }
}
