namespace AssemblyInfoEditor
{
    partial class AssEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssEditor));
            this.ChangeData = new System.Windows.Forms.Button();
            this.CloneData = new System.Windows.Forms.Button();
            this.ProdText = new System.Windows.Forms.Label();
            this.DescriptText = new System.Windows.Forms.Label();
            this.CompanyText = new System.Windows.Forms.Label();
            this.CopyRightText = new System.Windows.Forms.Label();
            this.TrademarksText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.ProdVerText = new System.Windows.Forms.Label();
            this.FileVerText = new System.Windows.Forms.Label();
            this.ProductBox = new System.Windows.Forms.TextBox();
            this.DescriptBox = new System.Windows.Forms.TextBox();
            this.CopyrightBox = new System.Windows.Forms.TextBox();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.InternalBox = new System.Windows.Forms.TextBox();
            this.TrademarksBox = new System.Windows.Forms.TextBox();
            this.FileVerBox = new System.Windows.Forms.TextBox();
            this.ProdVerBox = new System.Windows.Forms.TextBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.PathToFileText = new System.Windows.Forms.Label();
            this.BinaryOpen = new System.Windows.Forms.Button();
            this.OriginalBox = new System.Windows.Forms.TextBox();
            this.FilenameText = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CleanBox = new System.Windows.Forms.ToolStripMenuItem();
            this.CleanAllBox = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeData
            // 
            this.ChangeData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeData.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeData.Location = new System.Drawing.Point(267, 203);
            this.ChangeData.Name = "ChangeData";
            this.ChangeData.Size = new System.Drawing.Size(124, 23);
            this.ChangeData.TabIndex = 0;
            this.ChangeData.TabStop = false;
            this.ChangeData.Text = "Заменить данные";
            this.ChangeData.UseVisualStyleBackColor = true;
            this.ChangeData.Click += new System.EventHandler(this.ChangeData_Click);
            // 
            // CloneData
            // 
            this.CloneData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloneData.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloneData.Location = new System.Drawing.Point(267, 179);
            this.CloneData.Name = "CloneData";
            this.CloneData.Size = new System.Drawing.Size(124, 23);
            this.CloneData.TabIndex = 1;
            this.CloneData.TabStop = false;
            this.CloneData.Text = "Клонировать данные";
            this.CloneData.UseVisualStyleBackColor = true;
            this.CloneData.Click += new System.EventHandler(this.CloneData_Click);
            // 
            // ProdText
            // 
            this.ProdText.AutoSize = true;
            this.ProdText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdText.Location = new System.Drawing.Point(14, 13);
            this.ProdText.Name = "ProdText";
            this.ProdText.Size = new System.Drawing.Size(83, 15);
            this.ProdText.TabIndex = 2;
            this.ProdText.Text = "ProductName:";
            // 
            // DescriptText
            // 
            this.DescriptText.AutoSize = true;
            this.DescriptText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptText.Location = new System.Drawing.Point(14, 38);
            this.DescriptText.Name = "DescriptText";
            this.DescriptText.Size = new System.Drawing.Size(88, 15);
            this.DescriptText.TabIndex = 3;
            this.DescriptText.Text = "FileDescription:";
            // 
            // CompanyText
            // 
            this.CompanyText.AutoSize = true;
            this.CompanyText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyText.Location = new System.Drawing.Point(14, 62);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(91, 15);
            this.CompanyText.TabIndex = 4;
            this.CompanyText.Text = "CompanyName:";
            // 
            // CopyRightText
            // 
            this.CopyRightText.AutoSize = true;
            this.CopyRightText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyRightText.Location = new System.Drawing.Point(14, 86);
            this.CopyRightText.Name = "CopyRightText";
            this.CopyRightText.Size = new System.Drawing.Size(90, 15);
            this.CopyRightText.TabIndex = 5;
            this.CopyRightText.Text = "LegalCopyright:";
            // 
            // TrademarksText
            // 
            this.TrademarksText.AutoSize = true;
            this.TrademarksText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrademarksText.Location = new System.Drawing.Point(14, 110);
            this.TrademarksText.Name = "TrademarksText";
            this.TrademarksText.Size = new System.Drawing.Size(98, 15);
            this.TrademarksText.TabIndex = 6;
            this.TrademarksText.Text = "LegalTrademarks:";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(14, 135);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(81, 15);
            this.NameText.TabIndex = 7;
            this.NameText.Text = "InternalName:";
            // 
            // ProdVerText
            // 
            this.ProdVerText.AutoSize = true;
            this.ProdVerText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdVerText.Location = new System.Drawing.Point(14, 184);
            this.ProdVerText.Name = "ProdVerText";
            this.ProdVerText.Size = new System.Drawing.Size(92, 15);
            this.ProdVerText.TabIndex = 8;
            this.ProdVerText.Text = "ProductVersion:";
            // 
            // FileVerText
            // 
            this.FileVerText.AutoSize = true;
            this.FileVerText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileVerText.Location = new System.Drawing.Point(14, 207);
            this.FileVerText.Name = "FileVerText";
            this.FileVerText.Size = new System.Drawing.Size(68, 15);
            this.FileVerText.TabIndex = 9;
            this.FileVerText.Text = "FileVersion:";
            // 
            // ProductBox
            // 
            this.ProductBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductBox.Location = new System.Drawing.Point(122, 11);
            this.ProductBox.MaxLength = 99;
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(269, 20);
            this.ProductBox.TabIndex = 10;
            this.ProductBox.TabStop = false;
            this.ProductBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DescriptBox
            // 
            this.DescriptBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptBox.Location = new System.Drawing.Point(122, 35);
            this.DescriptBox.MaxLength = 99;
            this.DescriptBox.Name = "DescriptBox";
            this.DescriptBox.Size = new System.Drawing.Size(269, 20);
            this.DescriptBox.TabIndex = 11;
            this.DescriptBox.TabStop = false;
            this.DescriptBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CopyrightBox
            // 
            this.CopyrightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CopyrightBox.Location = new System.Drawing.Point(122, 83);
            this.CopyrightBox.MaxLength = 99;
            this.CopyrightBox.Name = "CopyrightBox";
            this.CopyrightBox.Size = new System.Drawing.Size(269, 20);
            this.CopyrightBox.TabIndex = 13;
            this.CopyrightBox.TabStop = false;
            this.CopyrightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompanyBox
            // 
            this.CompanyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyBox.Location = new System.Drawing.Point(122, 59);
            this.CompanyBox.MaxLength = 99;
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(269, 20);
            this.CompanyBox.TabIndex = 12;
            this.CompanyBox.TabStop = false;
            this.CompanyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InternalBox
            // 
            this.InternalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InternalBox.Location = new System.Drawing.Point(122, 131);
            this.InternalBox.MaxLength = 99;
            this.InternalBox.Name = "InternalBox";
            this.InternalBox.Size = new System.Drawing.Size(269, 20);
            this.InternalBox.TabIndex = 15;
            this.InternalBox.TabStop = false;
            this.InternalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrademarksBox
            // 
            this.TrademarksBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrademarksBox.Location = new System.Drawing.Point(122, 107);
            this.TrademarksBox.MaxLength = 99;
            this.TrademarksBox.Name = "TrademarksBox";
            this.TrademarksBox.Size = new System.Drawing.Size(269, 20);
            this.TrademarksBox.TabIndex = 14;
            this.TrademarksBox.TabStop = false;
            this.TrademarksBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileVerBox
            // 
            this.FileVerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileVerBox.Location = new System.Drawing.Point(122, 205);
            this.FileVerBox.MaxLength = 20;
            this.FileVerBox.Name = "FileVerBox";
            this.FileVerBox.Size = new System.Drawing.Size(139, 20);
            this.FileVerBox.TabIndex = 17;
            this.FileVerBox.TabStop = false;
            this.FileVerBox.Text = "1.0.0.0";
            // 
            // ProdVerBox
            // 
            this.ProdVerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProdVerBox.Location = new System.Drawing.Point(122, 180);
            this.ProdVerBox.MaxLength = 20;
            this.ProdVerBox.Name = "ProdVerBox";
            this.ProdVerBox.Size = new System.Drawing.Size(139, 20);
            this.ProdVerBox.TabIndex = 16;
            this.ProdVerBox.TabStop = false;
            this.ProdVerBox.Text = "1.0.0.0";
            // 
            // FilePathBox
            // 
            this.FilePathBox.AllowDrop = true;
            this.FilePathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePathBox.ContextMenuStrip = this.contextMenuStrip1;
            this.FilePathBox.Location = new System.Drawing.Point(52, 234);
            this.FilePathBox.MaxLength = 99;
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.ReadOnly = true;
            this.FilePathBox.Size = new System.Drawing.Size(283, 20);
            this.FilePathBox.TabIndex = 19;
            this.FilePathBox.TabStop = false;
            this.FilePathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePathBox_DragDrop);
            this.FilePathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilePathBox_DragEnter);
            // 
            // PathToFileText
            // 
            this.PathToFileText.AutoSize = true;
            this.PathToFileText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.PathToFileText.Location = new System.Drawing.Point(14, 236);
            this.PathToFileText.Name = "PathToFileText";
            this.PathToFileText.Size = new System.Drawing.Size(34, 15);
            this.PathToFileText.TabIndex = 18;
            this.PathToFileText.Text = "Path:";
            // 
            // BinaryOpen
            // 
            this.BinaryOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BinaryOpen.Location = new System.Drawing.Point(340, 232);
            this.BinaryOpen.Name = "BinaryOpen";
            this.BinaryOpen.Size = new System.Drawing.Size(51, 23);
            this.BinaryOpen.TabIndex = 20;
            this.BinaryOpen.TabStop = false;
            this.BinaryOpen.Text = "...";
            this.BinaryOpen.UseVisualStyleBackColor = true;
            this.BinaryOpen.Click += new System.EventHandler(this.BinaryOpen_Click);
            // 
            // OriginalBox
            // 
            this.OriginalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalBox.Location = new System.Drawing.Point(122, 155);
            this.OriginalBox.MaxLength = 99;
            this.OriginalBox.Name = "OriginalBox";
            this.OriginalBox.Size = new System.Drawing.Size(269, 20);
            this.OriginalBox.TabIndex = 22;
            this.OriginalBox.TabStop = false;
            this.OriginalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FilenameText
            // 
            this.FilenameText.AutoSize = true;
            this.FilenameText.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilenameText.Location = new System.Drawing.Point(14, 158);
            this.FilenameText.Name = "FilenameText";
            this.FilenameText.Size = new System.Drawing.Size(99, 15);
            this.FilenameText.TabIndex = 21;
            this.FilenameText.Text = "OriginalFilename:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CleanBox,
            this.CleanAllBox});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 70);
            // 
            // CleanBox
            // 
            this.CleanBox.Name = "CleanBox";
            this.CleanBox.Size = new System.Drawing.Size(155, 22);
            this.CleanBox.Text = "CleanBoxMenu";
            this.CleanBox.Click += new System.EventHandler(this.CleanBox_Click);
            // 
            // CleanAllBox
            // 
            this.CleanAllBox.Name = "CleanAllBox";
            this.CleanAllBox.Size = new System.Drawing.Size(155, 22);
            this.CleanAllBox.Text = "CleanAllBoxMenu";
            this.CleanAllBox.Click += new System.EventHandler(this.CleanAllBox_Click);
            // 
            // AssEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.OriginalBox);
            this.Controls.Add(this.FilenameText);
            this.Controls.Add(this.BinaryOpen);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.PathToFileText);
            this.Controls.Add(this.FileVerBox);
            this.Controls.Add(this.ProdVerBox);
            this.Controls.Add(this.InternalBox);
            this.Controls.Add(this.TrademarksBox);
            this.Controls.Add(this.CopyrightBox);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.DescriptBox);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.FileVerText);
            this.Controls.Add(this.ProdVerText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.TrademarksText);
            this.Controls.Add(this.CopyRightText);
            this.Controls.Add(this.CompanyText);
            this.Controls.Add(this.DescriptText);
            this.Controls.Add(this.ProdText);
            this.Controls.Add(this.CloneData);
            this.Controls.Add(this.ChangeData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembly File Info Editor";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeData;
        private System.Windows.Forms.Button CloneData;
        private System.Windows.Forms.Label ProdText;
        private System.Windows.Forms.Label DescriptText;
        private System.Windows.Forms.Label CompanyText;
        private System.Windows.Forms.Label CopyRightText;
        private System.Windows.Forms.Label TrademarksText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label ProdVerText;
        private System.Windows.Forms.Label FileVerText;
        private System.Windows.Forms.TextBox ProductBox;
        private System.Windows.Forms.TextBox DescriptBox;
        private System.Windows.Forms.TextBox CopyrightBox;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.TextBox InternalBox;
        private System.Windows.Forms.TextBox TrademarksBox;
        private System.Windows.Forms.TextBox FileVerBox;
        private System.Windows.Forms.TextBox ProdVerBox;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Label PathToFileText;
        private System.Windows.Forms.Button BinaryOpen;
        private System.Windows.Forms.TextBox OriginalBox;
        private System.Windows.Forms.Label FilenameText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CleanBox;
        private System.Windows.Forms.ToolStripMenuItem CleanAllBox;
    }
}

