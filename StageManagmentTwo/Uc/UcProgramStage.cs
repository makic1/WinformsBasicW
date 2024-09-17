using StageManagmentTwo.Entities;
using StageManagmentTwo.Service;

namespace StageManagmentTwo.Uc
{
    public partial class UcProgramStage : UserControl
    {
        private readonly ServiceProgramStage _serviceProgramStage;
        private readonly ServiceArtist _serviceArtist;
        private IsEdit _addOrEdit;
        public UcProgramStage()
        {
            InitializeComponent();
            var context = new DbContextStageManagmentTwo();
            _serviceProgramStage = new ServiceProgramStage(context);
            _serviceArtist = new ServiceArtist(context);

            groupBoxProgramStage.Visible = false;
            LoadUi();
            ConfDataGridAndDateTimePicker();
        }

        private void ConfDataGridAndDateTimePicker()
        {
        }

        private void LoadUi()
        {
            dataGridViewProgramStage.DataSource = _serviceProgramStage.GetAllProgramStages();

            comboBoxArtist.DataSource = _serviceArtist.GetAllArtists();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateProgramm().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateProgramm()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artist = (Artist)comboBoxArtist.SelectedItem;

            var programStage = new ProgramStage
            {
                Name = textBoxProgramName.Text,
                PriceEuro = Convert.ToDecimal(textBoxPrice.Text),
                StartPaidEuro = Convert.ToDecimal(textBoxStartPay.Text),
                EndPaidEuro = Convert.ToDecimal(textBoxEdnPay.Text),
                Duration = TimeSpan.Parse(textBoxDuration.Text),
                IsPaid = checkBoxIsPayed.Checked,
                ArtistId = artist.ArtistId
            };
            if (_addOrEdit is IsEdit.Add)
            {
                if (_serviceProgramStage.CheckOfDuplicateProgramStage(programStage))
                {
                    MessageBox.Show("Dieser Auftritt ist schon vorhanden");
                    return;
                }
                _serviceProgramStage.AddProgrammStage(programStage);
            }
            if (_addOrEdit is IsEdit.Edit)
            {
                programStage.ProgramStageId = CurrentProgramStageId();
                _serviceProgramStage.UpdateProgramStage(programStage);
            }
            LoadUi();
            groupBoxProgramStage.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxProgramStage.Visible = true;

            textBoxProgramName.Clear();
            textBoxEdnPay.Text = "0";
            textBoxPrice.Text = "0";
            textBoxStartPay.Text = "0";
            textBoxDuration.Clear();
            checkBoxIsPayed.Checked = false;
            comboBoxArtist.SelectedItem = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxProgramStage.Visible = true;

            var program = _serviceProgramStage.FindProgramStageById(CurrentProgramStageId());

            textBoxProgramName.Text = program.Name;
            textBoxEdnPay.Text = program.EndPaidEuro.ToString();
            textBoxPrice.Text = program.PriceEuro.ToString();
            textBoxStartPay.Text = program.StartPaidEuro.ToString();
            textBoxDuration.Text = program.Duration.ToString();
            checkBoxIsPayed.Checked = program.IsPaid;
            comboBoxArtist.SelectedItem = program.ArtistId;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var programStage = _serviceProgramStage.FindProgramStageById(CurrentProgramStageId());
            if (programStage is null)
            {
                MessageBox.Show("Sie müssen zuerst ein Programm auswählen bevor sie es Löschen können");
                return;
            }

            var dialogresult = MessageBox.Show($"Sind sie sich sicher das sie das Program {programStage.Name} löschen möchten", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogresult == DialogResult.Yes)
            {
                _serviceProgramStage.DeleteProgramStage(CurrentProgramStageId());
                LoadUi();
            }
        }

        public List<string> ValidateProgramm()
        {
            List<string> errors = new List<string>();

            // todo: timespan besser vallidieren
            try
            {
                TimeSpan duration = TimeSpan.Parse(textBoxDuration.Text);
            }
            catch (FormatException)
            {
                errors.Add("Bitte geben sie als Dauer das Format HH:mm:ss ein.");
            }
            if (string.IsNullOrWhiteSpace(textBoxProgramName.Text))
            {
                errors.Add("Bitte geben sie einen namen ein");
            }
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                errors.Add("Geben sie Bitte einen Preis ein");
            }
            if (string.IsNullOrWhiteSpace(textBoxStartPay.Text) && string.IsNullOrWhiteSpace(textBoxEdnPay.Text))
            {
                errors.Add("Geben sie bitte eine Anzahlung und eine Endzahlung kein wenn keine Vorhanden geben sie 0 ein");
            }
            if ((Convert.ToInt32(textBoxStartPay.Text) + Convert.ToInt32(textBoxEdnPay.Text)) > Convert.ToInt32(textBoxPrice.Text))
            {
                errors.Add("Anzahlung + Endzahlung kann nicht grüßer als Preis sein");
            }
            if (comboBoxArtist.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte einen Künstler aus");
            }
            return errors;

        }

        private int CurrentProgramStageId()
        {
            return Convert.ToInt32(dataGridViewProgramStage.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxProgramName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ');
        }

        private void textBoxDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ':');
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',');
        }

        private void textBoxStartPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',');
        }

        private void textBoxEdnPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ',');
        }

        private enum IsEdit
        {
            Add,
            Edit
        }
    }
}
