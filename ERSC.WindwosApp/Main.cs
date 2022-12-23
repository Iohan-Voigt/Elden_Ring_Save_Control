namespace ERSC.WindwosApp
{
    public partial class Main : Form
    {
        private string _ERFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EldenRing");
        private string _ERSCFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ERSC");
        private string _ERSaveNumber;
        private List<string> Directories = new();    

        public Main()
        {
            _ERSaveNumber = Directory.GetDirectories(_ERFolder).First().Replace(_ERFolder + "\\", "");
            FirstConfiguration();
            InitializeComponent();
            UpdateSavesList();
        }
        #region Buttons
        private void loadBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you Sure that wanna load this Save ({SavesCbx.Text}) ?","Elden Ring Saves Control",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoadSave();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(newSaveTxb.Text == "")
                MessageBox.Show("The save name can not be empty", "Elden Ring Saves Control", MessageBoxButtons.OK);
            else if (Directory.Exists(_ERSCFolder + "\\" + newSaveTxb.Text.ToString()))
                MessageBox.Show("This Save Name Already Exists", "Elden Ring Saves Control", MessageBoxButtons.OK);
            else
                CreateSave();
        }

        #endregion

        #region FileMenager
        private void FirstConfiguration()
        {
            if (EldenRingSavesFilesExists())
            {
                ConfigureERSCFiles();
            }
            else
            {
                MessageBox.Show("Any Elden Ring Saves Found", "Elden Ring Saves Control",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }    
        }

        private bool EldenRingSavesFilesExists()
        {
            if (Directory.Exists(_ERFolder))
                return true;
            else
                return false;
        }

        private void ConfigureERSCFiles()
        {
            if (!Directory.Exists(_ERSCFolder))
                Directory.CreateDirectory(_ERSCFolder);
        }

        private void LoadSave()
        {
            var filePaths = Directory.GetFiles(_ERSCFolder + "\\" + SavesCbx.Text);
            foreach (var filePath in filePaths)
            {
                string newFile = filePath.Replace(_ERSCFolder + "\\" + SavesCbx.Text + "\\", "");
                File.Copy(filePath, _ERFolder + "\\" + _ERSaveNumber + "\\" + newFile, true);
            }
            MessageBox.Show($"Successfully loaded save ({SavesCbx.Text})");
            newSaveTxb.Text = "";
            UpdateSavesList();
        }

        private void CreateSave()
        {
            var filePaths = Directory.GetFiles(_ERFolder + "\\" + _ERSaveNumber);
            Directory.CreateDirectory(_ERSCFolder + "\\" + newSaveTxb.Text);
            foreach (var filePath in filePaths)
            {
                string newFile = filePath.Replace(_ERFolder + "\\" + _ERSaveNumber + "\\", "");
                File.Copy(filePath, _ERSCFolder + "\\" + newSaveTxb.Text + "\\" + newFile, true);
            }
            MessageBox.Show($"Successfully created save ({newSaveTxb.Text})");
            UpdateSavesList();
        }


        #endregion

        private void UpdateSavesList()
        {
            Directories.Clear();
            var saves = Directory.GetDirectories(_ERSCFolder);
            foreach (var SaveFolder in saves)
            {
                Directories.Add(SaveFolder);
            }

            foreach (var save in Directories)
            {
                SavesCbx.Items.Add(save.Replace(_ERSCFolder + "\\",""));
            }
            if(Directories.Count > 0)
                SavesCbx.Text = SavesCbx.Items[0].ToString();
        }


    }
}