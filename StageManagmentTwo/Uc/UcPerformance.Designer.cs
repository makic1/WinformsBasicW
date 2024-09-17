namespace StageManagmentTwo.Uc
{
    partial class UcPerformance
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
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            groupBoxPerformance = new GroupBox();
            checkBoxIsActive = new CheckBox();
            label9 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            labelEnd = new Label();
            dateTimePickerStart = new DateTimePicker();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxProgramStage = new ComboBox();
            textBoxPerfromanceName = new TextBox();
            labelName = new Label();
            dataGridViewPerformance = new DataGridView();
            groupBoxPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(540, 360);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 40);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(439, 360);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 40);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Bearbeiten";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(338, 360);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 40);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBoxPerformance
            // 
            groupBoxPerformance.Controls.Add(checkBoxIsActive);
            groupBoxPerformance.Controls.Add(label9);
            groupBoxPerformance.Controls.Add(dateTimePickerEnd);
            groupBoxPerformance.Controls.Add(labelEnd);
            groupBoxPerformance.Controls.Add(dateTimePickerStart);
            groupBoxPerformance.Controls.Add(buttonSave);
            groupBoxPerformance.Controls.Add(label1);
            groupBoxPerformance.Controls.Add(comboBoxProgramStage);
            groupBoxPerformance.Controls.Add(textBoxPerfromanceName);
            groupBoxPerformance.Controls.Add(labelName);
            groupBoxPerformance.Location = new Point(641, 5);
            groupBoxPerformance.Name = "groupBoxPerformance";
            groupBoxPerformance.Size = new Size(261, 335);
            groupBoxPerformance.TabIndex = 11;
            groupBoxPerformance.TabStop = false;
            groupBoxPerformance.Text = "Vorstellung";
            // 
            // checkBoxIsActive
            // 
            checkBoxIsActive.AutoSize = true;
            checkBoxIsActive.Location = new Point(191, 141);
            checkBoxIsActive.Name = "checkBoxIsActive";
            checkBoxIsActive.Size = new Size(64, 24);
            checkBoxIsActive.TabIndex = 19;
            checkBoxIsActive.Text = "Aktiv";
            checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 80);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 18;
            label9.Text = "Start";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(86, 108);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(169, 27);
            dateTimePickerEnd.TabIndex = 17;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(6, 111);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(42, 20);
            labelEnd.TabIndex = 16;
            labelEnd.Text = "Ende";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(86, 75);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(169, 27);
            dateTimePickerStart.TabIndex = 15;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(161, 296);
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
            label1.Location = new Point(6, 174);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Program";
            // 
            // comboBoxProgramStage
            // 
            comboBoxProgramStage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProgramStage.FormattingEnabled = true;
            comboBoxProgramStage.Location = new Point(86, 171);
            comboBoxProgramStage.Name = "comboBoxProgramStage";
            comboBoxProgramStage.Size = new Size(169, 28);
            comboBoxProgramStage.TabIndex = 2;
            // 
            // textBoxPerfromanceName
            // 
            textBoxPerfromanceName.Location = new Point(86, 42);
            textBoxPerfromanceName.Name = "textBoxPerfromanceName";
            textBoxPerfromanceName.Size = new Size(169, 27);
            textBoxPerfromanceName.TabIndex = 1;
            textBoxPerfromanceName.KeyPress += textBoxPerfromanceName_KeyPress;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 45);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // dataGridViewPerformance
            // 
            dataGridViewPerformance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPerformance.Location = new Point(3, 5);
            dataGridViewPerformance.MultiSelect = false;
            dataGridViewPerformance.Name = "dataGridViewPerformance";
            dataGridViewPerformance.ReadOnly = true;
            dataGridViewPerformance.RowHeadersWidth = 51;
            dataGridViewPerformance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPerformance.Size = new Size(632, 349);
            dataGridViewPerformance.TabIndex = 10;
            // 
            // UcPerformance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxPerformance);
            Controls.Add(dataGridViewPerformance);
            Name = "UcPerformance";
            Size = new Size(905, 405);
            groupBoxPerformance.ResumeLayout(false);
            groupBoxPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerformance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private GroupBox groupBoxPerformance;
        private TextBox textBoxDuration;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckBox checkBoxIsPayed;
        private TextBox textBoxEdnPay;
        private Label label5;
        private TextBox textBoxStartPay;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label3;
        private Label label2;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxProgramStage;
        private TextBox textBoxPerfromanceName;
        private Label labelName;
        private DataGridView dataGridViewPerformance;
        private DateTimePicker dateTimePickerEnd;
        private Label labelEnd;
        private DateTimePicker dateTimePickerStart;
        private CheckBox checkBoxIsActive;
        private Label label9;
    }
}
