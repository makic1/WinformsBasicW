using StageManagmentTwo.Entities;
using StageManagmentTwo.Service;

namespace StageManagmentTwo.Uc
{
    public partial class UcArtist : UserControl
    {
        private readonly ServiceArtist _serviceArtist;
        private IsEdit _addOrEdit;

        public UcArtist()
        {
            InitializeComponent();

            var context = new DbContextStageManagmentTwo();
            _serviceArtist = new ServiceArtist(context);

            LoadUi();
            groupBoxArtist.Visible = false;
        }

        private void LoadUi()
        {
            dataGridViewArtist.DataSource = _serviceArtist.GetAllArtists();

            comboBoxartistCategorie.DataSource = Enum.GetValues(typeof(ArtistCategorie));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateArtist().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateArtist()), "Vallidierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var artist = new Artist
            {
                ArtistName = textBoxArtistName.Text,
                ArtistCategorie = (ArtistCategorie)comboBoxartistCategorie.SelectedValue,
            };

            if (_addOrEdit is IsEdit.Add)
            {
                _serviceArtist.AddArtist(artist);
            }
            else if (_addOrEdit is IsEdit.Edit)
            {
                artist.ArtistId = CurrentArtistId();
                _serviceArtist.UpdateArtist(artist);
            }
            LoadUi();
            groupBoxArtist.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;

            groupBoxArtist.Visible = true;

            textBoxArtistName.Clear();
            comboBoxartistCategorie.SelectedItem = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxArtist.Visible = true;

            var artist = _serviceArtist.FindArtistById(CurrentArtistId());

            textBoxArtistName.Text = artist.ArtistName;
            comboBoxartistCategorie.SelectedItem = artist.ArtistCategorie;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var artist = _serviceArtist.FindArtistById(CurrentArtistId());

            var dialogresult = MessageBox.Show($"Sind sie sich sicher das sie den Künstler {artist.ArtistName} löschen möchten?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogresult == DialogResult.Yes)
            {
                _serviceArtist.DeleteArtist(artist);
                LoadUi();
            }
        }

        private int CurrentArtistId()
        {
            return Convert.ToInt32(dataGridViewArtist.SelectedRows[0].Cells[0].Value);
        }

        private List<string> ValidateArtist()
        {
            List<string> errors = new();

            if (string.IsNullOrWhiteSpace(textBoxArtistName.Text))
            {
                errors.Add("Bitte geben den Namen vom Künstler ein");
            }
            if (comboBoxartistCategorie.SelectedItem == null)
            {
                errors.Add("Wählen sie bitte eine Kategorie aus");
            }

            return errors;
        }

        private void textBoxArtistName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ');
        }

        private enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
