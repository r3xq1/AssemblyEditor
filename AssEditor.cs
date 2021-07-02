namespace AssemblyInfoEditor
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AssEditor : Form
    {
        // для записи только цифр в определённые текстбоксы
        private void TextBoxOnTextChanged(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 46)
            {
                e.Handled = true;
            }
        }

        public AssEditor()
        {
            InitializeComponent();
            AllowDrop = true;
            FilePathBox.AllowDrop = true;
            ProdVerBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            FileVerBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
        }

        private void BinaryOpen_Click(object sender, EventArgs e)
        {
            ActiveControl = null; // Уберает фокус с кнопки
            try
            {
                using var filedi = new OpenFileDialog
                {
                    Title = "[AssemblyInfo Editor] - Выберите файл которому нужно изменить данные",
                    Filter = "Executable File (*.exe)|*.exe",
                    AutoUpgradeEnabled = true,
                    CheckFileExists = true,
                    Multiselect = false,
                    RestoreDirectory = true
                };
                if (filedi.ShowDialog() == DialogResult.OK)
                {
                    FilePathBox.Text = filedi.FileName;
                }
            }
            catch { }
        }

        // Проверка всех текстбоксов с исключением некоторых на пустоту
        private bool CheckIsEmptyBoxs => Controls.OfType<TextBox>().Except(new TextBox[] { DescriptBox, CompanyBox, TrademarksBox }).Any(t => string.IsNullOrEmpty(t.Text));
        private void ChangeData_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            if (CheckIsEmptyBoxs)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                WriteAssembly(FilePathBox.Text);
            }
        }

        public void WriteAssembly(string filename)
        {
            try
            {
                var versionResource = new AssemblyEditor();
                versionResource.LoadFrom(filename);
                versionResource.Language = 0;

                var stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
                stringFileInfo["ProductName"] = ProductBox.Text;
                stringFileInfo["FileDescription"] = DescriptBox.Text;
                stringFileInfo["CompanyName"] = CompanyBox.Text;
                stringFileInfo["LegalCopyright"] = CopyrightBox.Text;
                stringFileInfo["LegalTrademarks"] = TrademarksBox.Text;
                stringFileInfo["InternalName"] = InternalBox.Text;
                stringFileInfo["OriginalFilename"] = OriginalBox.Text;
                stringFileInfo["Assembly Version"] = versionResource.ProductVersion;
                stringFileInfo["ProductVersion"] = ProdVerBox.Text ?? versionResource.ProductVersion;
                stringFileInfo["FileVersion"] = FileVerBox.Text ?? versionResource.FileVersion;

                versionResource.SaveTo(filename);
                MessageBox.Show("Данные заменены успешно!", "AssemblyEditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Assembly: {ex.Message}");
            }
        }

        private void CloneData_Click(object sender, EventArgs e)
        {
            ActiveControl = null; 
            try
            {
                using var openFileDialog = new OpenFileDialog
                {
                    Title = "[AssemblyInfo Editor] - Выберите файл из которого хотите получить данные",
                    Filter = "Executable (*.exe)|*.exe",
                    AutoUpgradeEnabled = true,
                    CheckFileExists = true,
                    Multiselect = false,
                    RestoreDirectory = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);

                    InternalBox.Text = fileVersionInfo.InternalName ?? string.Empty;
                    DescriptBox.Text = fileVersionInfo.FileDescription ?? string.Empty;
                    CompanyBox.Text = fileVersionInfo.CompanyName ?? string.Empty;
                    ProductBox.Text = fileVersionInfo.ProductName ?? string.Empty;
                    CopyrightBox.Text = fileVersionInfo.LegalCopyright ?? string.Empty;
                    TrademarksBox.Text = fileVersionInfo.LegalTrademarks ?? string.Empty;
                    FileVerBox.Text = $"{fileVersionInfo.FileMajorPart}.{fileVersionInfo.FileMinorPart}.{fileVersionInfo.FileBuildPart}.{fileVersionInfo.FilePrivatePart}";
                    ProdVerBox.Text = $"{fileVersionInfo.FileMajorPart}.{fileVersionInfo.FileMinorPart}.{fileVersionInfo.FileBuildPart}.{fileVersionInfo.FilePrivatePart}";
                }
            }
            catch { }
        }

        private void FilePathBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void FilePathBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0 && string.Equals(Path.GetExtension(files[0]), ".exe", StringComparison.InvariantCultureIgnoreCase))
            {
                FilePathBox.Text = files[0];
            }
        }

        private void CleanBox_Click(object sender, EventArgs e)
        {
            FilePathBox.Clear();
        }

        private void CleanAllBox_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox box)
                {
                    box.Text = null;
                }
            }
        }
    }
}