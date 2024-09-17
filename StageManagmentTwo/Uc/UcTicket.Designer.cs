namespace StageManagmentTwo.Uc
{
    partial class UcTicket
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
            groupBoxTicket = new GroupBox();
            numericUpDownSeatNumber = new NumericUpDown();
            comboBoxSeatRow = new ComboBox();
            label6 = new Label();
            textBoxPrice = new TextBox();
            label3 = new Label();
            labelSeat = new Label();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxArtist = new ComboBox();
            labelSeatRow = new Label();
            dataGridViewTicket = new DataGridView();
            label2 = new Label();
            textBoxCustomerFirstname = new TextBox();
            textBoxcustomerLastname = new TextBox();
            labelLastname = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            groupBoxTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeatNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).BeginInit();
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
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(439, 360);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(95, 40);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Bearbeiten";
            buttonUpdate.UseVisualStyleBackColor = true;
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
            // 
            // groupBoxTicket
            // 
            groupBoxTicket.Controls.Add(textBox4);
            groupBoxTicket.Controls.Add(label7);
            groupBoxTicket.Controls.Add(textBox3);
            groupBoxTicket.Controls.Add(label5);
            groupBoxTicket.Controls.Add(textBoxcustomerLastname);
            groupBoxTicket.Controls.Add(labelLastname);
            groupBoxTicket.Controls.Add(textBoxCustomerFirstname);
            groupBoxTicket.Controls.Add(label2);
            groupBoxTicket.Controls.Add(numericUpDownSeatNumber);
            groupBoxTicket.Controls.Add(comboBoxSeatRow);
            groupBoxTicket.Controls.Add(label6);
            groupBoxTicket.Controls.Add(textBoxPrice);
            groupBoxTicket.Controls.Add(label3);
            groupBoxTicket.Controls.Add(labelSeat);
            groupBoxTicket.Controls.Add(buttonSave);
            groupBoxTicket.Controls.Add(label1);
            groupBoxTicket.Controls.Add(comboBoxArtist);
            groupBoxTicket.Controls.Add(labelSeatRow);
            groupBoxTicket.Location = new Point(641, 5);
            groupBoxTicket.Name = "groupBoxTicket";
            groupBoxTicket.Size = new Size(261, 395);
            groupBoxTicket.TabIndex = 11;
            groupBoxTicket.TabStop = false;
            groupBoxTicket.Text = "Program";
            // 
            // numericUpDownSeatNumber
            // 
            numericUpDownSeatNumber.Location = new Point(111, 71);
            numericUpDownSeatNumber.Name = "numericUpDownSeatNumber";
            numericUpDownSeatNumber.Size = new Size(144, 27);
            numericUpDownSeatNumber.TabIndex = 20;
            // 
            // comboBoxSeatRow
            // 
            comboBoxSeatRow.FormattingEnabled = true;
            comboBoxSeatRow.Location = new Point(111, 37);
            comboBoxSeatRow.Name = "comboBoxSeatRow";
            comboBoxSeatRow.Size = new Size(144, 28);
            comboBoxSeatRow.TabIndex = 19;
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
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(154, 108);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(83, 27);
            textBoxPrice.TabIndex = 8;
            textBoxPrice.Text = "0";
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
            // labelSeat
            // 
            labelSeat.AutoSize = true;
            labelSeat.Location = new Point(6, 73);
            labelSeat.Name = "labelSeat";
            labelSeat.Size = new Size(33, 20);
            labelSeat.TabIndex = 5;
            labelSeat.Text = "Sitz";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(161, 360);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 276);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Künstler";
            // 
            // comboBoxArtist
            // 
            comboBoxArtist.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxArtist.FormattingEnabled = true;
            comboBoxArtist.Location = new Point(111, 273);
            comboBoxArtist.Name = "comboBoxArtist";
            comboBoxArtist.Size = new Size(144, 28);
            comboBoxArtist.TabIndex = 2;
            // 
            // labelSeatRow
            // 
            labelSeatRow.AutoSize = true;
            labelSeatRow.Location = new Point(6, 40);
            labelSeatRow.Name = "labelSeatRow";
            labelSeatRow.Size = new Size(46, 20);
            labelSeatRow.TabIndex = 0;
            labelSeatRow.Text = "Reihe";
            // 
            // dataGridViewTicket
            // 
            dataGridViewTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTicket.Location = new Point(3, 5);
            dataGridViewTicket.MultiSelect = false;
            dataGridViewTicket.Name = "dataGridViewTicket";
            dataGridViewTicket.ReadOnly = true;
            dataGridViewTicket.RowHeadersWidth = 51;
            dataGridViewTicket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTicket.Size = new Size(632, 349);
            dataGridViewTicket.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 144);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 21;
            label2.Text = "Vorname";
            // 
            // textBoxCustomerFirstname
            // 
            textBoxCustomerFirstname.Location = new Point(111, 141);
            textBoxCustomerFirstname.Name = "textBoxCustomerFirstname";
            textBoxCustomerFirstname.Size = new Size(144, 27);
            textBoxCustomerFirstname.TabIndex = 22;
            // 
            // textBoxcustomerLastname
            // 
            textBoxcustomerLastname.Location = new Point(111, 174);
            textBoxcustomerLastname.Name = "textBoxcustomerLastname";
            textBoxcustomerLastname.Size = new Size(144, 27);
            textBoxcustomerLastname.TabIndex = 24;
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Location = new Point(6, 177);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(80, 20);
            labelLastname.TabIndex = 23;
            labelLastname.Text = "Nachname";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 27);
            textBox3.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 210);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 25;
            label5.Text = "label5";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 27);
            textBox4.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 243);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 27;
            label7.Text = "label7";
            // 
            // UcTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(groupBoxTicket);
            Controls.Add(dataGridViewTicket);
            Name = "UcTicket";
            Size = new Size(905, 405);
            groupBoxTicket.ResumeLayout(false);
            groupBoxTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeatNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTicket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private GroupBox groupBoxTicket;
        private TextBox textBoxDuration;
        private Label label6;
        private TextBox textBoxPrice;
        private Label label3;
        private Label labelSeat;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxArtist;
        private TextBox textBoxProgramName;
        private Label labelSeatRow;
        private DataGridView dataGridViewTicket;
        private NumericUpDown numericUpDownSeatNumber;
        private ComboBox comboBoxSeatRow;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBoxcustomerLastname;
        private Label labelLastname;
        private TextBox textBoxCustomerFirstname;
        private Label label2;
    }
}
