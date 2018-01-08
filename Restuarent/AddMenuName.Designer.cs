namespace Restuarent
{
    partial class AddMenuName
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
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.ColTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAddDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalp = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textboxquantity = new System.Windows.Forms.TextBox();
            this.textBoxcategoryType = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.LabelQty = new System.Windows.Forms.Label();
            this.labelCategoryType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItem.Location = new System.Drawing.Point(556, 439);
            this.labelTotalItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(83, 20);
            this.labelTotalItem.TabIndex = 69;
            this.labelTotalItem.Text = "Total Price";
            // 
            // ColTotalPrice
            // 
            this.ColTotalPrice.HeaderText = "Total Price";
            this.ColTotalPrice.Name = "ColTotalPrice";
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Quantity";
            this.ColQuantity.Name = "ColQuantity";
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            // 
            // ColItemName
            // 
            this.ColItemName.HeaderText = "Item Name";
            this.ColItemName.Name = "ColItemName";
            // 
            // ColItemID
            // 
            this.ColItemID.HeaderText = "Item Id";
            this.ColItemID.Name = "ColItemID";
            // 
            // dataGridViewAddDisplay
            // 
            this.dataGridViewAddDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColItemID,
            this.ColItemName,
            this.ColPrice,
            this.ColQuantity,
            this.ColTotalPrice});
            this.dataGridViewAddDisplay.Location = new System.Drawing.Point(303, 124);
            this.dataGridViewAddDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAddDisplay.Name = "dataGridViewAddDisplay";
            this.dataGridViewAddDisplay.RowTemplate.Height = 24;
            this.dataGridViewAddDisplay.Size = new System.Drawing.Size(548, 302);
            this.dataGridViewAddDisplay.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(271, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item Name";
            // 
            // textBoxTotalp
            // 
            this.textBoxTotalp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalp.Location = new System.Drawing.Point(682, 433);
            this.textBoxTotalp.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalp.Name = "textBoxTotalp";
            this.textBoxTotalp.Size = new System.Drawing.Size(76, 26);
            this.textBoxTotalp.TabIndex = 71;
            this.textBoxTotalp.Text = "0.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-38, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 107);
            this.panel1.TabIndex = 66;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(146, 399);
            this.textBoxTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(138, 27);
            this.textBoxTotalPrice.TabIndex = 58;
            // 
            // textboxquantity
            // 
            this.textboxquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxquantity.Location = new System.Drawing.Point(146, 345);
            this.textboxquantity.Margin = new System.Windows.Forms.Padding(2);
            this.textboxquantity.Name = "textboxquantity";
            this.textboxquantity.Size = new System.Drawing.Size(138, 27);
            this.textboxquantity.TabIndex = 59;
            this.textboxquantity.TextChanged += new System.EventHandler(this.textboxquantity_TextChanged);
            // 
            // textBoxcategoryType
            // 
            this.textBoxcategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcategoryType.Location = new System.Drawing.Point(146, 232);
            this.textBoxcategoryType.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxcategoryType.Name = "textBoxcategoryType";
            this.textBoxcategoryType.Size = new System.Drawing.Size(138, 27);
            this.textBoxcategoryType.TabIndex = 60;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(146, 286);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(138, 27);
            this.textBoxPrice.TabIndex = 61;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(146, 179);
            this.textBoxItemName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(138, 27);
            this.textBoxItemName.TabIndex = 62;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(146, 123);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(138, 27);
            this.textBoxID.TabIndex = 63;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(11, 411);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(97, 22);
            this.labelTotalPrice.TabIndex = 52;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // LabelQty
            // 
            this.LabelQty.AutoSize = true;
            this.LabelQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQty.Location = new System.Drawing.Point(11, 345);
            this.LabelQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelQty.Name = "LabelQty";
            this.LabelQty.Size = new System.Drawing.Size(77, 22);
            this.LabelQty.TabIndex = 53;
            this.LabelQty.Text = "Quantity";
            // 
            // labelCategoryType
            // 
            this.labelCategoryType.AutoSize = true;
            this.labelCategoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoryType.Location = new System.Drawing.Point(11, 237);
            this.labelCategoryType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryType.Name = "labelCategoryType";
            this.labelCategoryType.Size = new System.Drawing.Size(129, 22);
            this.labelCategoryType.TabIndex = 54;
            this.labelCategoryType.Text = "Category Type";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(11, 286);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 22);
            this.labelPrice.TabIndex = 55;
            this.labelPrice.Text = "Price";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(11, 181);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(95, 22);
            this.labelItemName.TabIndex = 56;
            this.labelItemName.Text = "Item Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(11, 123);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(65, 22);
            this.labelId.TabIndex = 57;
            this.labelId.Text = "Item ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(33, 455);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 50);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Orange;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.MintCream;
            this.buttonRemove.Location = new System.Drawing.Point(317, 455);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(92, 50);
            this.buttonRemove.TabIndex = 73;
            this.buttonRemove.Text = "Cancel";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MintCream;
            this.button1.Location = new System.Drawing.Point(183, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 50);
            this.button1.TabIndex = 72;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddMenuName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalItem);
            this.Controls.Add(this.dataGridViewAddDisplay);
            this.Controls.Add(this.textBoxTotalp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textboxquantity);
            this.Controls.Add(this.textBoxcategoryType);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.LabelQty);
            this.Controls.Add(this.labelCategoryType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelItemName);
            this.Controls.Add(this.labelId);
            this.Name = "AddMenuName";
            this.Size = new System.Drawing.Size(1000, 576);
            this.Load += new System.EventHandler(this.FirstCustomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemID;
        private System.Windows.Forms.DataGridView dataGridViewAddDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.TextBox textboxquantity;
        private System.Windows.Forms.TextBox textBoxcategoryType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label LabelQty;
        private System.Windows.Forms.Label labelCategoryType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button button1;
    }
}
