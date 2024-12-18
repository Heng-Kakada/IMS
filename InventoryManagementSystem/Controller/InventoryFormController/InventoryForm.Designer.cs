﻿namespace InventoryManagementSystem.Controller.InventoryFormController
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            pHead = new Panel();
            inventoryFormTitle = new Label();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvInventory = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUnitCost = new DataGridViewTextBoxColumn();
            colCurrentStock = new DataGridViewTextBoxColumn();
            colInitQty = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            colExpireDate = new DataGridViewTextBoxColumn();
            colLastUpdate = new DataGridViewTextBoxColumn();
            colImportId = new DataGridViewTextBoxColumn();
            colProductId = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            btnDelete = new Button();
            textBox1 = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(inventoryFormTitle);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1800, 80);
            pHead.TabIndex = 0;
            // 
            // inventoryFormTitle
            // 
            inventoryFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inventoryFormTitle.AutoSize = true;
            inventoryFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryFormTitle.Location = new Point(773, 23);
            inventoryFormTitle.Name = "inventoryFormTitle";
            inventoryFormTitle.Size = new Size(310, 33);
            inventoryFormTitle.TabIndex = 12;
            inventoryFormTitle.Text = "Inventory's Information";
            // 
            // pBottom
            // 
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 797);
            pBottom.Margin = new Padding(3, 2, 3, 2);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1800, 103);
            pBottom.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.Controls.Add(panel3);
            pBody.Controls.Add(panel2);
            pBody.Controls.Add(panel1);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 80);
            pBody.Name = "pBody";
            pBody.Size = new Size(1800, 717);
            pBody.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvInventory);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1452, 717);
            panel3.TabIndex = 3;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.Control;
            dgvInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] { colId, colUnitCost, colCurrentStock, colInitQty, colNote, colExpireDate, colLastUpdate, colImportId, colProductId });
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = SystemColors.Control;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.Size = new Size(1452, 717);
            dgvInventory.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle12;
            colId.FillWeight = 120F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 45;
            // 
            // colUnitCost
            // 
            colUnitCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colUnitCost.DefaultCellStyle = dataGridViewCellStyle13;
            colUnitCost.FillWeight = 80F;
            colUnitCost.HeaderText = "Unit Cost";
            colUnitCost.Name = "colUnitCost";
            colUnitCost.ReadOnly = true;
            // 
            // colCurrentStock
            // 
            colCurrentStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colCurrentStock.DefaultCellStyle = dataGridViewCellStyle14;
            colCurrentStock.HeaderText = "Current Stock";
            colCurrentStock.Name = "colCurrentStock";
            colCurrentStock.ReadOnly = true;
            colCurrentStock.Width = 102;
            // 
            // colInitQty
            // 
            colInitQty.HeaderText = "Initial Qty";
            colInitQty.Name = "colInitQty";
            colInitQty.ReadOnly = true;
            // 
            // colNote
            // 
            colNote.HeaderText = "Note";
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            // 
            // colExpireDate
            // 
            colExpireDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colExpireDate.DefaultCellStyle = dataGridViewCellStyle15;
            colExpireDate.HeaderText = "Expired Date";
            colExpireDate.Name = "colExpireDate";
            colExpireDate.ReadOnly = true;
            // 
            // colLastUpdate
            // 
            colLastUpdate.HeaderText = "Last Update";
            colLastUpdate.Name = "colLastUpdate";
            colLastUpdate.ReadOnly = true;
            // 
            // colImportId
            // 
            colImportId.HeaderText = "Import ID";
            colImportId.Name = "colImportId";
            colImportId.ReadOnly = true;
            // 
            // colProductId
            // 
            colProductId.HeaderText = "Product ID";
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 717);
            panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(89, 434);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(19, 53);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "search ...";
            textBox1.Size = new Size(269, 26);
            textBox1.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(89, 321);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 21;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(89, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1752, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 717);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 100);
            panel4.TabIndex = 23;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(pBody);
            Controls.Add(pBottom);
            Controls.Add(pHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryForm";
            Text = "InventoryForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Panel pBody;
        private DataGridView dgvInventory;
        private Label inventoryFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUnitCost;
        private DataGridViewTextBoxColumn colCurrentStock;
        private DataGridViewTextBoxColumn colInitQty;
        private DataGridViewTextBoxColumn colNote;
        private DataGridViewTextBoxColumn colExpireDate;
        private DataGridViewTextBoxColumn colLastUpdate;
        private DataGridViewTextBoxColumn colImportId;
        private DataGridViewTextBoxColumn colProductId;
        private Button btnDelete;
        private TextBox textBox1;
        private Button btnUpdate;
        private Label label1;
        private Button btnAdd;
        private Panel panel4;
    }
}