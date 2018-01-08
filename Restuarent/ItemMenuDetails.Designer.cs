namespace Restuarent
{
    partial class ItemMenuDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.ColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnItemquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.buttonCal = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.ButtomImport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNotepad = new System.Windows.Forms.Button();
            this.buttonlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSave.Location = new System.Drawing.Point(633, 416);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 51);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // ColumnTotalPrice
            // 
            this.ColumnTotalPrice.Frozen = true;
            this.ColumnTotalPrice.HeaderText = "TotalPrice";
            this.ColumnTotalPrice.Name = "ColumnTotalPrice";
            this.ColumnTotalPrice.ReadOnly = true;
            this.ColumnTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.Frozen = true;
            this.ColumnPrice.HeaderText = "price";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCategoryType
            // 
            this.ColumnCategoryType.Frozen = true;
            this.ColumnCategoryType.HeaderText = "CategoryType";
            this.ColumnCategoryType.Name = "ColumnCategoryType";
            this.ColumnCategoryType.ReadOnly = true;
            this.ColumnCategoryType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCategoryType.Width = 110;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.Frozen = true;
            this.ColumnItemName.HeaderText = "Item Name";
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.ReadOnly = true;
            this.ColumnItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnItemName.Width = 120;
            // 
            // ColumnID
            // 
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnSN
            // 
            this.ColumnSN.Frozen = true;
            this.ColumnSN.HeaderText = "SN";
            this.ColumnSN.Name = "ColumnSN";
            this.ColumnSN.ReadOnly = true;
            this.ColumnSN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSN,
            this.ColumnID,
            this.ColumnItemName,
            this.ColumnCategoryType,
            this.ColumnPrice,
            this.ColumnTotalPrice,
            this.ColumnItemquantity});
            this.dataGridView2.Location = new System.Drawing.Point(0, 66);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1000, 576);
            this.dataGridView2.TabIndex = 33;
            // 
            // ColumnItemquantity
            // 
            this.ColumnItemquantity.Frozen = true;
            this.ColumnItemquantity.HeaderText = "Item Quantity";
            this.ColumnItemquantity.Name = "ColumnItemquantity";
            this.ColumnItemquantity.ReadOnly = true;
            this.ColumnItemquantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.buttonAddNewItem);
            this.panel1.Controls.Add(this.buttonCal);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonImport);
            this.panel1.Controls.Add(this.ButtomImport);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonNotepad);
            this.panel1.Controls.Add(this.buttonlogout);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-106, -28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 90);
            this.panel1.TabIndex = 31;
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.FlatAppearance.BorderSize = 0;
            this.buttonAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewItem.Location = new System.Drawing.Point(124, 45);
            this.buttonAddNewItem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(127, 43);
            this.buttonAddNewItem.TabIndex = 35;
            this.buttonAddNewItem.Text = "Add New Menu Item";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            // 
            // buttonCal
            // 
            this.buttonCal.FlatAppearance.BorderSize = 0;
            this.buttonCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCal.Location = new System.Drawing.Point(564, 47);
            this.buttonCal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(80, 43);
            this.buttonCal.TabIndex = 11;
            this.buttonCal.Text = "Calculator";
            this.buttonCal.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(610, 202);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 34);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(488, 202);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 34);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add New Manu Item";
            // 
            // buttonImport
            // 
            this.buttonImport.FlatAppearance.BorderSize = 0;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Location = new System.Drawing.Point(277, 37);
            this.buttonImport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(105, 42);
            this.buttonImport.TabIndex = 16;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // ButtomImport
            // 
            this.ButtomImport.Location = new System.Drawing.Point(632, -160);
            this.ButtomImport.Margin = new System.Windows.Forms.Padding(2);
            this.ButtomImport.Name = "ButtomImport";
            this.ButtomImport.Size = new System.Drawing.Size(79, 34);
            this.ButtomImport.TabIndex = 8;
            this.ButtomImport.Text = "Import";
            this.ButtomImport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, -160);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add New Manu Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonNotepad
            // 
            this.buttonNotepad.BackColor = System.Drawing.Color.Crimson;
            this.buttonNotepad.FlatAppearance.BorderSize = 0;
            this.buttonNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotepad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNotepad.Location = new System.Drawing.Point(431, 46);
            this.buttonNotepad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNotepad.Name = "buttonNotepad";
            this.buttonNotepad.Size = new System.Drawing.Size(85, 42);
            this.buttonNotepad.TabIndex = 5;
            this.buttonNotepad.Text = "Notepad";
            this.buttonNotepad.UseVisualStyleBackColor = false;
            // 
            // buttonlogout
            // 
            this.buttonlogout.FlatAppearance.BorderSize = 0;
            this.buttonlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.Location = new System.Drawing.Point(705, 47);
            this.buttonlogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(73, 36);
            this.buttonlogout.TabIndex = 4;
            this.buttonlogout.Text = "Logout";
            this.buttonlogout.UseVisualStyleBackColor = true;
            // 
            // ItemMenuDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemMenuDetails";
            this.Size = new System.Drawing.Size(774, 469);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemquantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button ButtomImport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNotepad;
        private System.Windows.Forms.Button buttonlogout;
    }
}
