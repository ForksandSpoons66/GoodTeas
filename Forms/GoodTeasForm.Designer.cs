namespace GoodTeas
{
    partial class goodTeasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goodTeasForm));
            this.teasDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caffeineContentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steepTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterTemperatureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTeaButton = new System.Windows.Forms.Button();
            this.removeTeaButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teasDataGridView
            // 
            this.teasDataGridView.AllowUserToAddRows = false;
            this.teasDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.caffeineContentColumn,
            this.steepTimeColumn,
            this.waterTemperatureColumn,
            this.notesColumn,
            this.ratingColumn});
            this.teasDataGridView.Location = new System.Drawing.Point(12, 12);
            this.teasDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teasDataGridView.Name = "teasDataGridView";
            this.teasDataGridView.ReadOnly = true;
            this.teasDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.teasDataGridView.RowTemplate.Height = 25;
            this.teasDataGridView.Size = new System.Drawing.Size(1096, 516);
            this.teasDataGridView.TabIndex = 0;
            // 
            // nameColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 150;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // caffeineContentColumn
            // 
            this.caffeineContentColumn.HeaderText = "Caffeine Content";
            this.caffeineContentColumn.Name = "caffeineContentColumn";
            this.caffeineContentColumn.ReadOnly = true;
            this.caffeineContentColumn.Width = 150;
            // 
            // steepTimeColumn
            // 
            this.steepTimeColumn.HeaderText = "Steep Time (min)";
            this.steepTimeColumn.Name = "steepTimeColumn";
            this.steepTimeColumn.ReadOnly = true;
            this.steepTimeColumn.Width = 150;
            // 
            // waterTemperatureColumn
            // 
            this.waterTemperatureColumn.HeaderText = "Water Temperature (°F)";
            this.waterTemperatureColumn.Name = "waterTemperatureColumn";
            this.waterTemperatureColumn.ReadOnly = true;
            this.waterTemperatureColumn.Width = 200;
            // 
            // notesColumn
            // 
            this.notesColumn.HeaderText = "Notes";
            this.notesColumn.Name = "notesColumn";
            this.notesColumn.ReadOnly = true;
            this.notesColumn.Width = 260;
            // 
            // ratingColumn
            // 
            this.ratingColumn.HeaderText = "Rating";
            this.ratingColumn.Name = "ratingColumn";
            this.ratingColumn.ReadOnly = true;
            // 
            // addTeaButton
            // 
            this.addTeaButton.BackColor = System.Drawing.Color.Magenta;
            this.addTeaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTeaButton.Location = new System.Drawing.Point(820, 533);
            this.addTeaButton.Name = "addTeaButton";
            this.addTeaButton.Size = new System.Drawing.Size(141, 32);
            this.addTeaButton.TabIndex = 1;
            this.addTeaButton.Text = "Add Tea";
            this.addTeaButton.UseVisualStyleBackColor = false;
            this.addTeaButton.Click += new System.EventHandler(this.addTeaButton_Click);
            // 
            // removeTeaButton
            // 
            this.removeTeaButton.BackColor = System.Drawing.Color.Crimson;
            this.removeTeaButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeTeaButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeTeaButton.Location = new System.Drawing.Point(967, 533);
            this.removeTeaButton.Name = "removeTeaButton";
            this.removeTeaButton.Size = new System.Drawing.Size(141, 32);
            this.removeTeaButton.TabIndex = 2;
            this.removeTeaButton.Text = "Remove Tea";
            this.removeTeaButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(12, 533);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(141, 32);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // goodTeasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1120, 570);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.removeTeaButton);
            this.Controls.Add(this.addTeaButton);
            this.Controls.Add(this.teasDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "goodTeasForm";
            this.Text = "GoodTeas";
            ((System.ComponentModel.ISupportInitialize)(this.teasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView teasDataGridView;
        private Button addTeaButton;
        private Button removeTeaButton;
        private Button saveButton;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn typeColumn;
        private DataGridViewTextBoxColumn caffeineContentColumn;
        private DataGridViewTextBoxColumn steepTimeColumn;
        private DataGridViewTextBoxColumn waterTemperatureColumn;
        private DataGridViewTextBoxColumn notesColumn;
        private DataGridViewTextBoxColumn ratingColumn;
    }
}