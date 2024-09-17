namespace StageManagmentTwo.Uc
{
    partial class UcProgramStage
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
            groupBoxProgramStage = new GroupBox();
            textBoxDuration = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            checkBoxIsPayed = new CheckBox();
            textBoxEdnPay = new TextBox();
            label5 = new Label();
            textBoxStartPay = new TextBox();
            label4 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxArtist = new ComboBox();
            textBoxProgramName = new TextBox();
            labelName = new Label();
            dataGridViewProgramStage = new DataGridView();
            groupBoxProgramStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramStage).BeginInit();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(540, 360);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(95, 40);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(439, 360);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 40);
            buttonUpdate.TabIndex = 8;
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
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBoxProgramStage
            // 
            groupBoxProgramStage.Controls.Add(textBoxDuration);
            groupBoxProgramStage.Controls.Add(label8);
            groupBoxProgramStage.Controls.Add(label7);
            groupBoxProgramStage.Controls.Add(label6);
            groupBoxProgramStage.Controls.Add(checkBoxIsPayed);
            groupBoxProgramStage.Controls.Add(textBoxEdnPay);
            groupBoxProgramStage.Controls.Add(label5);
            groupBoxProgramStage.Controls.Add(textBoxStartPay);
            groupBoxProgramStage.Controls.Add(label4);
            groupBoxProgramStage.Controls.Add(textBoxPrice);
            groupBoxProgramStage.Controls.Add(label3);
            groupBoxProgramStage.Controls.Add(label2);
            groupBoxProgramStage.Controls.Add(buttonSave);
            groupBoxProgramStage.Controls.Add(label1);
            groupBoxProgramStage.Controls.Add(comboBoxArtist);
            groupBoxProgramStage.Controls.Add(textBoxProgramName);
            groupBoxProgramStage.Controls.Add(labelName);
            groupBoxProgramStage.Location = new Point(641, 5);
            groupBoxProgramStage.Name = "groupBoxProgramStage";
            groupBoxProgramStage.Size = new Size(261, 335);
            groupBoxProgramStage.TabIndex = 6;
            groupBoxProgramStage.TabStop = false;
            groupBoxProgramStage.Text = "Program";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(111, 75);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(144, 27);
            textBoxDuration.TabIndex = 18;
            textBoxDuration.KeyPress += textBoxDuration_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 177);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 17;
            label8.Text = "€";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 144);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 16;
            label7.Text = "€";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 111);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 15;
            label6.Text = "€";
            // 
            // checkBoxIsPayed
            // 
            checkBoxIsPayed.AutoSize = true;
            checkBoxIsPayed.Location = new Point(175, 207);
            checkBoxIsPayed.Name = "checkBoxIsPayed";
            checkBoxIsPayed.Size = new Size(80, 24);
            checkBoxIsPayed.TabIndex = 14;
            checkBoxIsPayed.Text = "Bezahlt";
            checkBoxIsPayed.UseVisualStyleBackColor = true;
            // 
            // textBoxEdnPay
            // 
            textBoxEdnPay.Location = new Point(154, 174);
            textBoxEdnPay.Name = "textBoxEdnPay";
            textBoxEdnPay.Size = new Size(83, 27);
            textBoxEdnPay.TabIndex = 13;
            textBoxEdnPay.Text = "0";
            textBoxEdnPay.KeyPress += textBoxEdnPay_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 177);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 12;
            label5.Text = "Schlusszahlung";
            // 
            // textBoxStartPay
            // 
            textBoxStartPay.Location = new Point(154, 141);
            textBoxStartPay.Name = "textBoxStartPay";
            textBoxStartPay.Size = new Size(83, 27);
            textBoxStartPay.TabIndex = 10;
            textBoxStartPay.Text = "0";
            textBoxStartPay.KeyPress += textBoxStartPay_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 144);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 9;
            label4.Text = "Anzahlung";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(154, 108);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(83, 27);
            textBoxPrice.TabIndex = 8;
            textBoxPrice.Text = "0";
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "Preis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Dauer";
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
            label1.Location = new Point(6, 240);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Künstler";
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(111, 237);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(144, 28);
            comboBoxArtist.TabIndex = 2;
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(111, 42);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(144, 27);
            textBoxProgramName.TabIndex = 1;
            textBoxProgramName.KeyPress += textBoxProgramName_KeyPress;
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
            // dataGridViewProgramStage
            // 
            dataGridViewProgramStage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramStage.Location = new Point(3, 5);
            dataGridViewProgramStage.MultiSelect = false;
            dataGridViewProgramStage.Name = "dataGridViewProgramStage";
            dataGridViewProgramStage.ReadOnly = true;
            dataGridViewProgramStage.RowHeadersWidth = 51;
            dataGridViewProgramStage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProgramStage.Size = new Size(632, 349);
            dataGridViewProgramStage.TabIndex = 5;
            // 
            // UcProgramStage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxProgramStage);
            Controls.Add(dataGridViewProgramStage);
            Name = "UcProgramStage";
            Size = new Size(905, 405);
            groupBoxProgramStage.ResumeLayout(false);
            groupBoxProgramStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramStage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private GroupBox groupBoxProgramStage;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxArtist;
        private TextBox textBoxProgramName;
        private Label labelName;
        private DataGridView dataGridViewProgramStage;
        private TextBox textBoxStartPay;
        private Label label4;
        private TextBox textBoxPrice;
        private Label label3;
        private Label label2;
        private CheckBox checkBoxIsPayed;
        private TextBox textBoxEdnPay;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxDuration;
    }
}
