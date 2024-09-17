namespace StageManagmentTwo.Uc
{
    partial class UcManageUserControls
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
            tabControlMain = new TabControl();
            tabPageArtist = new TabPage();
            tabPageProgram = new TabPage();
            tabPagePerformance = new TabPage();
            tabPageTicket = new TabPage();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageArtist);
            tabControlMain.Controls.Add(tabPageProgram);
            tabControlMain.Controls.Add(tabPagePerformance);
            tabControlMain.Controls.Add(tabPageTicket);
            tabControlMain.Location = new Point(3, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(913, 438);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPageArtist
            // 
            tabPageArtist.Location = new Point(4, 29);
            tabPageArtist.Name = "tabPageArtist";
            tabPageArtist.Padding = new Padding(3);
            tabPageArtist.Size = new Size(905, 405);
            tabPageArtist.TabIndex = 0;
            tabPageArtist.Text = "Künstler";
            tabPageArtist.UseVisualStyleBackColor = true;
            // 
            // tabPageProgram
            // 
            tabPageProgram.Location = new Point(4, 29);
            tabPageProgram.Name = "tabPageProgram";
            tabPageProgram.Padding = new Padding(3);
            tabPageProgram.Size = new Size(905, 405);
            tabPageProgram.TabIndex = 1;
            tabPageProgram.Text = "Program";
            tabPageProgram.UseVisualStyleBackColor = true;
            // 
            // tabPagePerformance
            // 
            tabPagePerformance.Location = new Point(4, 29);
            tabPagePerformance.Name = "tabPagePerformance";
            tabPagePerformance.Size = new Size(905, 405);
            tabPagePerformance.TabIndex = 2;
            tabPagePerformance.Text = "Vorstellung";
            tabPagePerformance.UseVisualStyleBackColor = true;
            // 
            // tabPageTicket
            // 
            tabPageTicket.Location = new Point(4, 29);
            tabPageTicket.Name = "tabPageTicket";
            tabPageTicket.Size = new Size(905, 405);
            tabPageTicket.TabIndex = 3;
            tabPageTicket.Text = "Ticket";
            tabPageTicket.UseVisualStyleBackColor = true;
            // 
            // UcManageUserControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlMain);
            Name = "UcManageUserControls";
            Size = new Size(919, 444);
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageArtist;
        private TabPage tabPageProgram;
        private TabPage tabPagePerformance;
        private TabPage tabPageTicket;
    }
}
