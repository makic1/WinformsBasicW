using StageManagmentTwo.Entities;
using StageManagmentTwo.Service;

namespace StageManagmentTwo.Uc
{
    public partial class UcPerformance : UserControl
    {
        private readonly ServicePerformance _servicePerformance;
        private readonly ServiceProgramStage _serviceProgramStage;
        private IsEdit _addOrEdit;

        public UcPerformance()
        {
            InitializeComponent();
            var context = new DbContextStageManagmentTwo();
            _servicePerformance = new ServicePerformance(context);
            _serviceProgramStage = new ServiceProgramStage(context);

            groupBoxPerformance.Visible = false;

            LoadUi();
            ConfDatagridAndDateTimePicker();
        }

        private void ConfDatagridAndDateTimePicker()
        {
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM/dd/yyy , HH:mm:ss";

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM/dd/yyy , HH:mm:ss";

            dataGridViewPerformance.Columns["PerfomanceId"].Visible = false;
            dataGridViewPerformance.Columns["ProgramStageId"].Visible = false;
            dataGridViewPerformance.Columns["Tickets"].Visible = false;


            dataGridViewPerformance.Columns["SartPerformance"].HeaderText = "Beginn";
            dataGridViewPerformance.Columns["EndPerformance"].HeaderText = "Ende";
            dataGridViewPerformance.Columns["IsActive"].HeaderText = "Aktiv";
            dataGridViewPerformance.Columns["ProgramStage"].HeaderText = "Program";
        }

        private void LoadUi()
        {
            dataGridViewPerformance.DataSource = _servicePerformance.GetAllPerformances();
            comboBoxProgramStage.DataSource = _serviceProgramStage.GetAllProgramStages();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidatePerformance().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidatePerformance()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var program = (ProgramStage)comboBoxProgramStage.SelectedItem;

            var performance = new Performance
            {
                Name = textBoxPerfromanceName.Text,
                SartPerformance = dateTimePickerStart.Value,
                EndPerformance = dateTimePickerEnd.Value,
                IsActive = checkBoxIsActive.Checked,
                ProgramStageId = program.ProgramStageId
            };

            if (_addOrEdit == IsEdit.Add)
            {
                if (_servicePerformance.CkeckForDuplicatePerformance(performance))
                {
                    MessageBox.Show("Diese Vorstellung gibt es schon");
                    return;
                }
                _servicePerformance.AddPerformance(performance);
            }
            else if (_addOrEdit == IsEdit.Edit)
            {
                performance.PerfomanceId = CurrentPerformanceId();

                _servicePerformance.UpdatePerformance(performance);
            }
            LoadUi();
            groupBoxPerformance.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxPerformance.Visible = true;

            textBoxPerfromanceName.Clear();
            checkBoxIsActive.Checked = false;
            comboBoxProgramStage.SelectedItem = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxPerformance.Visible = true;

            var performance = _servicePerformance.FindPerformanceById(CurrentPerformanceId());

            textBoxPerfromanceName.Text = performance.Name;
            dateTimePickerStart.Value = performance.SartPerformance;
            dateTimePickerEnd.Value = performance.EndPerformance;
            checkBoxIsActive.Checked = performance.IsActive;
            comboBoxProgramStage.SelectedItem = performance.ProgramStage;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var performance = _servicePerformance.FindPerformanceById(CurrentPerformanceId());
            if (performance is null)
            {
                MessageBox.Show("Wählen sie zuerst eine Vorstellung aus um sie zum löschen");
            }

            var dialogresult = MessageBox.Show($"Sind sie sich sicher das sie die Vorstellung {performance.Name} löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.Yes)
            {
                _servicePerformance.RemovePerformanceById(performance.PerfomanceId);
                LoadUi();
            }
        }

        public List<string> ValidatePerformance()
        {
            List<string> errors = new();

            if (string.IsNullOrWhiteSpace(textBoxPerfromanceName.Text))
            {
                errors.Add("Bitte geben sie einen Namen der Voratellung ein");
            }
            if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
            {
                errors.Add("Die Startzeit muss vor der Endzeit liegen");
            }
            if (comboBoxProgramStage.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte ein Program aus");
            }
            return errors;
        }

        private int CurrentPerformanceId()
        {
            return Convert.ToInt32(dataGridViewPerformance.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxPerfromanceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ');
        }

        private enum IsEdit
        {
            Add,
            Edit
        }
    }
}
