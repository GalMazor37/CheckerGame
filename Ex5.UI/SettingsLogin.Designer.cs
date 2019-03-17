using System.Drawing;
using System.Windows.Forms;

namespace Ex5.UI
{
    public partial class SettingsLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.textBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.boardGameSmallSize = new System.Windows.Forms.RadioButton();
            this.buttonDone = new System.Windows.Forms.Button();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.boardGameMediumSize = new System.Windows.Forms.RadioButton();
            this.boardGameLargeSize = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.pictureBoxBlackSoldier = new System.Windows.Forms.PictureBox();
            this.pictureBoxRedSoldier = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackSoldier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedSoldier)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPlayer1Name
            // 
            this.textBoxPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPlayer1Name.Location = new System.Drawing.Point(131, 168);
            this.textBoxPlayer1Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPlayer1Name.Name = "textBoxPlayer1Name";
            this.textBoxPlayer1Name.Size = new System.Drawing.Size(154, 26);
            this.textBoxPlayer1Name.TabIndex = 0;
            // 
            // boardGameSmallSize
            // 
            this.boardGameSmallSize.AutoSize = true;
            this.boardGameSmallSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.boardGameSmallSize.ForeColor = System.Drawing.SystemColors.Info;
            this.boardGameSmallSize.Location = new System.Drawing.Point(17, 8);
            this.boardGameSmallSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boardGameSmallSize.Name = "boardGameSmallSize";
            this.boardGameSmallSize.Size = new System.Drawing.Size(59, 24);
            this.boardGameSmallSize.TabIndex = 0;
            this.boardGameSmallSize.TabStop = true;
            this.boardGameSmallSize.Text = "6X6";
            this.boardGameSmallSize.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDone.Location = new System.Drawing.Point(249, 250);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(83, 27);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "DONE";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxPlayer2.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(19, 209);
            this.checkBoxPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(97, 24);
            this.checkBoxPlayer2.TabIndex = 4;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = false;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // boardGameMediumSize
            // 
            this.boardGameMediumSize.AutoSize = true;
            this.boardGameMediumSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.boardGameMediumSize.ForeColor = System.Drawing.SystemColors.Info;
            this.boardGameMediumSize.Location = new System.Drawing.Point(17, 40);
            this.boardGameMediumSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boardGameMediumSize.Name = "boardGameMediumSize";
            this.boardGameMediumSize.Size = new System.Drawing.Size(59, 24);
            this.boardGameMediumSize.TabIndex = 1;
            this.boardGameMediumSize.TabStop = true;
            this.boardGameMediumSize.Text = "8X8";
            this.boardGameMediumSize.UseVisualStyleBackColor = true;
            // 
            // boardGameLargeSize
            // 
            this.boardGameLargeSize.AutoSize = true;
            this.boardGameLargeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.boardGameLargeSize.ForeColor = System.Drawing.SystemColors.Info;
            this.boardGameLargeSize.Location = new System.Drawing.Point(17, 73);
            this.boardGameLargeSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boardGameLargeSize.Name = "boardGameLargeSize";
            this.boardGameLargeSize.Size = new System.Drawing.Size(79, 24);
            this.boardGameLargeSize.TabIndex = 2;
            this.boardGameLargeSize.TabStop = true;
            this.boardGameLargeSize.Text = "10X10";
            this.boardGameLargeSize.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.boardGameLargeSize);
            this.panel1.Controls.Add(this.boardGameMediumSize);
            this.panel1.Controls.Add(this.boardGameSmallSize);
            this.panel1.Location = new System.Drawing.Point(161, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 105);
            this.panel1.TabIndex = 12;
            // 
            // textBoxPlayer2Name
            // 
            this.textBoxPlayer2Name.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxPlayer2Name.Enabled = false;
            this.textBoxPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxPlayer2Name.Location = new System.Drawing.Point(131, 209);
            this.textBoxPlayer2Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPlayer2Name.Name = "textBoxPlayer2Name";
            this.textBoxPlayer2Name.Size = new System.Drawing.Size(154, 26);
            this.textBoxPlayer2Name.TabIndex = 5;
            this.textBoxPlayer2Name.Text = "[Computer]";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.BackColor = System.Drawing.Color.Transparent;
            this.labelBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBoardSize.ForeColor = System.Drawing.SystemColors.Info;
            this.labelBoardSize.Location = new System.Drawing.Point(30, 29);
            this.labelBoardSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(125, 25);
            this.labelBoardSize.TabIndex = 14;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayers.ForeColor = System.Drawing.SystemColors.Info;
            this.labelPlayers.Location = new System.Drawing.Point(30, 136);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(91, 25);
            this.labelPlayers.TabIndex = 15;
            this.labelPlayers.Text = "Players:";
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayer1Name.ForeColor = System.Drawing.SystemColors.Info;
            this.labelPlayer1Name.Location = new System.Drawing.Point(36, 172);
            this.labelPlayer1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(78, 20);
            this.labelPlayer1Name.TabIndex = 16;
            this.labelPlayer1Name.Text = "Player 1:";
            // 
            // pictureBoxBlackSoldier
            // 
            this.pictureBoxBlackSoldier.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBlackSoldier.BackgroundImage = global::Ex5.UI.Properties.Resources.black_soldier;
            this.pictureBoxBlackSoldier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBlackSoldier.Location = new System.Drawing.Point(290, 164);
            this.pictureBoxBlackSoldier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBlackSoldier.Name = "pictureBoxBlackSoldier";
            this.pictureBoxBlackSoldier.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxBlackSoldier.TabIndex = 2;
            this.pictureBoxBlackSoldier.TabStop = false;
            // 
            // pictureBoxRedSoldier
            // 
            this.pictureBoxRedSoldier.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRedSoldier.BackgroundImage = global::Ex5.UI.Properties.Resources.red_soldier;
            this.pictureBoxRedSoldier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRedSoldier.Location = new System.Drawing.Point(290, 205);
            this.pictureBoxRedSoldier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxRedSoldier.Name = "pictureBoxRedSoldier";
            this.pictureBoxRedSoldier.Size = new System.Drawing.Size(33, 32);
            this.pictureBoxRedSoldier.TabIndex = 3;
            this.pictureBoxRedSoldier.TabStop = false;
            // 
            // SettingsLogin
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::Ex5.UI.Properties.Resources.black_marble;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 289);
            this.Controls.Add(this.labelPlayer1Name);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.textBoxPlayer2Name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxPlayer1Name);
            this.Controls.Add(this.pictureBoxRedSoldier);
            this.Controls.Add(this.pictureBoxBlackSoldier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Ex5.UI.Properties.Resources.damka_Icon;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "SettingsLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.SettingsLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackSoldier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedSoldier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxPlayer1Name;
        private RadioButton boardGameSmallSize;
        private Button buttonDone;
        private CheckBox checkBoxPlayer2;
        private RadioButton boardGameMediumSize;
        private RadioButton boardGameLargeSize;
        private Panel panel1;
        private TextBox textBoxPlayer2Name;
        private Label labelBoardSize;
        private Label labelPlayers;
        private Label labelPlayer1Name;
        private PictureBox pictureBoxBlackSoldier;
        private PictureBox pictureBoxRedSoldier;
    }
}