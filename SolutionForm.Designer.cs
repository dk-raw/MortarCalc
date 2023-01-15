namespace MortarCalc
{
    partial class SolutionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.targetLon = new System.Windows.Forms.TextBox();
            this.gunLon = new System.Windows.Forms.TextBox();
            this.gunLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targetAlt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.targetLat = new System.Windows.Forms.TextBox();
            this.autoGunPos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button60mm = new System.Windows.Forms.RadioButton();
            this.Button81mm = new System.Windows.Forms.RadioButton();
            this.Button120mm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.solutionBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adjBox = new System.Windows.Forms.GroupBox();
            this.adjDropButton = new System.Windows.Forms.RadioButton();
            this.adjAddButton = new System.Windows.Forms.RadioButton();
            this.adjTextBox = new System.Windows.Forms.TextBox();
            this.adjCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtsqFuzeButton = new System.Windows.Forms.RadioButton();
            this.pdFuzeButton = new System.Windows.Forms.RadioButton();
            this.pFuzeButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.adjBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "C&ut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.targetLon);
            this.groupBox1.Controls.Add(this.gunLon);
            this.groupBox1.Controls.Add(this.gunLat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.targetAlt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gunAlt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.targetLat);
            this.groupBox1.Controls.Add(this.autoGunPos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS";
            // 
            // targetLon
            // 
            this.targetLon.Location = new System.Drawing.Point(182, 125);
            this.targetLon.Name = "targetLon";
            this.targetLon.Size = new System.Drawing.Size(192, 23);
            this.targetLon.TabIndex = 10;
            // 
            // gunLon
            // 
            this.gunLon.Location = new System.Drawing.Point(182, 37);
            this.gunLon.Name = "gunLon";
            this.gunLon.Size = new System.Drawing.Size(123, 23);
            this.gunLon.TabIndex = 9;
            // 
            // gunLat
            // 
            this.gunLat.Location = new System.Drawing.Point(6, 37);
            this.gunLat.Name = "gunLat";
            this.gunLat.Size = new System.Drawing.Size(170, 23);
            this.gunLat.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Target Alt";
            // 
            // targetAlt
            // 
            this.targetAlt.Location = new System.Drawing.Point(6, 169);
            this.targetAlt.Name = "targetAlt";
            this.targetAlt.Size = new System.Drawing.Size(368, 23);
            this.targetAlt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gun Alt";
            // 
            // gunAlt
            // 
            this.gunAlt.Location = new System.Drawing.Point(6, 81);
            this.gunAlt.Name = "gunAlt";
            this.gunAlt.Size = new System.Drawing.Size(368, 23);
            this.gunAlt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Pos (Lat/Lon)";
            // 
            // targetLat
            // 
            this.targetLat.Location = new System.Drawing.Point(6, 125);
            this.targetLat.Name = "targetLat";
            this.targetLat.Size = new System.Drawing.Size(170, 23);
            this.targetLat.TabIndex = 3;
            // 
            // autoGunPos
            // 
            this.autoGunPos.Location = new System.Drawing.Point(311, 37);
            this.autoGunPos.Name = "autoGunPos";
            this.autoGunPos.Size = new System.Drawing.Size(63, 23);
            this.autoGunPos.TabIndex = 2;
            this.autoGunPos.Text = "AUTO";
            this.autoGunPos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gun Pos (Lat/Lon)";
            // 
            // Button60mm
            // 
            this.Button60mm.AutoSize = true;
            this.Button60mm.Checked = true;
            this.Button60mm.Location = new System.Drawing.Point(6, 22);
            this.Button60mm.Name = "Button60mm";
            this.Button60mm.Size = new System.Drawing.Size(59, 19);
            this.Button60mm.TabIndex = 2;
            this.Button60mm.TabStop = true;
            this.Button60mm.Text = "60mm";
            this.Button60mm.UseVisualStyleBackColor = true;
            // 
            // Button81mm
            // 
            this.Button81mm.AutoSize = true;
            this.Button81mm.Location = new System.Drawing.Point(71, 22);
            this.Button81mm.Name = "Button81mm";
            this.Button81mm.Size = new System.Drawing.Size(59, 19);
            this.Button81mm.TabIndex = 3;
            this.Button81mm.Text = "81mm";
            this.Button81mm.UseVisualStyleBackColor = true;
            // 
            // Button120mm
            // 
            this.Button120mm.AutoSize = true;
            this.Button120mm.Location = new System.Drawing.Point(136, 22);
            this.Button120mm.Name = "Button120mm";
            this.Button120mm.Size = new System.Drawing.Size(65, 19);
            this.Button120mm.TabIndex = 4;
            this.Button120mm.Text = "120mm";
            this.Button120mm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button120mm);
            this.groupBox2.Controls.Add(this.Button60mm);
            this.groupBox2.Controls.Add(this.Button81mm);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 51);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caliber";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 348);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(380, 42);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "CALCULATE";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // solutionBox
            // 
            this.solutionBox.Location = new System.Drawing.Point(12, 421);
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.ReadOnly = true;
            this.solutionBox.Size = new System.Drawing.Size(380, 106);
            this.solutionBox.TabIndex = 7;
            this.solutionBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Solution";
            // 
            // adjBox
            // 
            this.adjBox.Controls.Add(this.adjDropButton);
            this.adjBox.Controls.Add(this.adjAddButton);
            this.adjBox.Controls.Add(this.adjTextBox);
            this.adjBox.Enabled = false;
            this.adjBox.Location = new System.Drawing.Point(12, 558);
            this.adjBox.Name = "adjBox";
            this.adjBox.Size = new System.Drawing.Size(380, 52);
            this.adjBox.TabIndex = 9;
            this.adjBox.TabStop = false;
            this.adjBox.Text = "Adj";
            // 
            // adjDropButton
            // 
            this.adjDropButton.AutoSize = true;
            this.adjDropButton.Location = new System.Drawing.Point(323, 21);
            this.adjDropButton.Name = "adjDropButton";
            this.adjDropButton.Size = new System.Drawing.Size(51, 19);
            this.adjDropButton.TabIndex = 2;
            this.adjDropButton.TabStop = true;
            this.adjDropButton.Text = "Drop";
            this.adjDropButton.UseVisualStyleBackColor = true;
            // 
            // adjAddButton
            // 
            this.adjAddButton.AutoSize = true;
            this.adjAddButton.Checked = true;
            this.adjAddButton.Location = new System.Drawing.Point(270, 21);
            this.adjAddButton.Name = "adjAddButton";
            this.adjAddButton.Size = new System.Drawing.Size(47, 19);
            this.adjAddButton.TabIndex = 1;
            this.adjAddButton.TabStop = true;
            this.adjAddButton.Text = "Add";
            this.adjAddButton.UseVisualStyleBackColor = true;
            // 
            // adjTextBox
            // 
            this.adjTextBox.Location = new System.Drawing.Point(6, 17);
            this.adjTextBox.Name = "adjTextBox";
            this.adjTextBox.Size = new System.Drawing.Size(258, 23);
            this.adjTextBox.TabIndex = 0;
            // 
            // adjCheckBox
            // 
            this.adjCheckBox.AutoSize = true;
            this.adjCheckBox.Location = new System.Drawing.Point(12, 533);
            this.adjCheckBox.Name = "adjCheckBox";
            this.adjCheckBox.Size = new System.Drawing.Size(82, 19);
            this.adjCheckBox.TabIndex = 3;
            this.adjCheckBox.Text = "Adjust Fire";
            this.adjCheckBox.UseVisualStyleBackColor = true;
            this.adjCheckBox.CheckedChanged += new System.EventHandler(this.adjCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtsqFuzeButton);
            this.groupBox3.Controls.Add(this.pdFuzeButton);
            this.groupBox3.Controls.Add(this.pFuzeButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 51);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fuze";
            // 
            // mtsqFuzeButton
            // 
            this.mtsqFuzeButton.AutoSize = true;
            this.mtsqFuzeButton.Location = new System.Drawing.Point(90, 22);
            this.mtsqFuzeButton.Name = "mtsqFuzeButton";
            this.mtsqFuzeButton.Size = new System.Drawing.Size(57, 19);
            this.mtsqFuzeButton.TabIndex = 4;
            this.mtsqFuzeButton.Text = "MTSQ";
            this.mtsqFuzeButton.UseVisualStyleBackColor = true;
            // 
            // pdFuzeButton
            // 
            this.pdFuzeButton.AutoSize = true;
            this.pdFuzeButton.Checked = true;
            this.pdFuzeButton.Location = new System.Drawing.Point(6, 22);
            this.pdFuzeButton.Name = "pdFuzeButton";
            this.pdFuzeButton.Size = new System.Drawing.Size(40, 19);
            this.pdFuzeButton.TabIndex = 2;
            this.pdFuzeButton.TabStop = true;
            this.pdFuzeButton.Text = "PD";
            this.pdFuzeButton.UseVisualStyleBackColor = true;
            // 
            // pFuzeButton
            // 
            this.pFuzeButton.AutoSize = true;
            this.pFuzeButton.Location = new System.Drawing.Point(52, 22);
            this.pFuzeButton.Name = "pFuzeButton";
            this.pFuzeButton.Size = new System.Drawing.Size(32, 19);
            this.pFuzeButton.TabIndex = 3;
            this.pFuzeButton.Text = "P";
            this.pFuzeButton.UseVisualStyleBackColor = true;
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 622);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.adjCheckBox);
            this.Controls.Add(this.adjBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mortar Ballistic Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.adjBox.ResumeLayout(false);
            this.adjBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private GroupBox groupBox1;
        private TextBox targetLon;
        private TextBox gunLon;
        private Label label4;
        private TextBox targetAlt;
        private Label label3;
        private TextBox gunAlt;
        private Label label2;
        private TextBox targetLat;
        private Button autoGunPos;
        private Label label1;
        private TextBox gunLat;
        private RadioButton Button60mm;
        private RadioButton Button81mm;
        private RadioButton Button120mm;
        private GroupBox groupBox2;
        private Button calcButton;
        private ToolTip toolTip1;
        private RichTextBox solutionBox;
        private Label label5;
        private GroupBox adjBox;
        private RadioButton adjDropButton;
        private RadioButton adjAddButton;
        private TextBox adjTextBox;
        private CheckBox adjCheckBox;
        private GroupBox groupBox3;
        private RadioButton mtsqFuzeButton;
        private RadioButton pdFuzeButton;
        private RadioButton pFuzeButton;
    }
}