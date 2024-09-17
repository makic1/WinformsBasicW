namespace StageManagmentTwo.Uc
{
    partial class UcArtist
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
            dataGridViewArtist = new DataGridView();
            groupBoxArtist = new GroupBox();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxartistCategorie = new ComboBox();
            textBoxArtistName = new TextBox();
            labelName = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtist).BeginInit();
            groupBoxArtist.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewArtist
            // 
            dataGridViewArtist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArtist.Location = new Point(3, 3);
            dataGridViewArtist.MultiSelect = false;
            dataGridViewArtist.Name = "dataGridViewArtist";
            dataGridViewArtist.ReadOnly = true;
            dataGridViewArtist.RowHeadersWidth = 51;
            dataGridViewArtist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArtist.Size = new Size(632, 349);
            dataGridViewArtist.TabIndex = 0;
            // 
            // groupBoxArtist
            // 
            groupBoxArtist.Controls.Add(buttonSave);
            groupBoxArtist.Controls.Add(label1);
            groupBoxArtist.Controls.Add(comboBoxartistCategorie);
            groupBoxArtist.Controls.Add(textBoxArtistName);
            groupBoxArtist.Controls.Add(labelName);
            groupBoxArtist.Location = new Point(641, 3);
            groupBoxArtist.Name = "groupBoxArtist";
            groupBoxArtist.Size = new Size(261, 176);
            groupBoxArtist.TabIndex = 1;
            groupBoxArtist.TabStop = false;
            groupBoxArtist.Text = "Künstler";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(161, 129);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 78);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "Kategorie";
            // 
            // comboBoxartistCategorie
            // 
            comboBoxartistCategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxartistCategorie.FormattingEnabled = true;
            comboBoxartistCategorie.Location = new Point(111, 75);
            comboBoxartistCategorie.Name = "comboBoxartistCategorie";
            comboBoxartistCategorie.Size = new Size(144, 28);
            comboBoxartistCategorie.TabIndex = 2;
            // 
            // textBoxArtistName
            // 
            textBoxArtistName.Location = new Point(111, 42);
            textBoxArtistName.Name = "textBoxArtistName";
            textBoxArtistName.Size = new Size(144, 27);
            textBoxArtistName.TabIndex = 1;
            textBoxArtistName.KeyPress += textBoxArtistName_KeyPress;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 45);
            labelName.Name = "labelName";
            labelName.Size = new Size(99, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Künstlername";
            // 
            // buttonAdd
            // 
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(338, 358);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 40);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(439, 358);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 40);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Bearbeiten";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(540, 358);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 40);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // UcArtist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxArtist);
            Controls.Add(dataGridViewArtist);
            Name = "UcArtist";
            Size = new Size(905, 405);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArtist).EndInit();
            groupBoxArtist.ResumeLayout(false);
            groupBoxArtist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewArtist;
        private GroupBox groupBoxArtist;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxartistCategorie;
        private TextBox textBoxArtistName;
        private Label labelName;
    }
}
