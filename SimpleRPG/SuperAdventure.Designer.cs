namespace SimpleRPG
{
    partial class SuperAdventure
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.tcDataViewer = new System.Windows.Forms.TabControl();
            this.tpInventory = new System.Windows.Forms.TabPage();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tpQuests = new System.Windows.Forms.TabPage();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.pControlPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnFindLoot = new System.Windows.Forms.Button();
            this.tcDataViewer.SuspendLayout();
            this.tpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tpQuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            this.pControlPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здоровье:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Золото:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Опыт:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Уровень:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 19);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 13);
            this.lblHitPoints.TabIndex = 0;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 0;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(110, 73);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 13);
            this.lblExperience.TabIndex = 0;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 99);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 13);
            this.lblLevel.TabIndex = 0;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(594, 355);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 2;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(594, 326);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 3;
            this.cboWeapons.SelectedIndexChanged += new System.EventHandler(this.cboWeapons_SelectedIndexChanged);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(784, 355);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(90, 23);
            this.btnUsePotion.TabIndex = 8;
            this.btnUsePotion.Text = "Исп. снадобье";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(784, 326);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(90, 23);
            this.btnUseWeapon.TabIndex = 9;
            this.btnUseWeapon.Text = "Исп. оружие";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbLocation.Location = new System.Drawing.Point(594, 12);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(284, 202);
            this.rtbLocation.TabIndex = 10;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtbMessages.Location = new System.Drawing.Point(275, 12);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(313, 361);
            this.rtbMessages.TabIndex = 11;
            this.rtbMessages.Text = "";
            // 
            // tcDataViewer
            // 
            this.tcDataViewer.Controls.Add(this.tpInventory);
            this.tcDataViewer.Controls.Add(this.tpQuests);
            this.tcDataViewer.Location = new System.Drawing.Point(12, 118);
            this.tcDataViewer.Name = "tcDataViewer";
            this.tcDataViewer.SelectedIndex = 0;
            this.tcDataViewer.Size = new System.Drawing.Size(264, 258);
            this.tcDataViewer.TabIndex = 22;
            // 
            // tpInventory
            // 
            this.tpInventory.Controls.Add(this.dgvInventory);
            this.tpInventory.Location = new System.Drawing.Point(4, 22);
            this.tpInventory.Name = "tpInventory";
            this.tpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tpInventory.Size = new System.Drawing.Size(256, 232);
            this.tpInventory.TabIndex = 0;
            this.tpInventory.Text = "Инвентарь";
            this.tpInventory.UseVisualStyleBackColor = true;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(3, 3);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(250, 226);
            this.dgvInventory.TabIndex = 15;
            // 
            // tpQuests
            // 
            this.tpQuests.Controls.Add(this.dgvQuests);
            this.tpQuests.Location = new System.Drawing.Point(4, 22);
            this.tpQuests.Name = "tpQuests";
            this.tpQuests.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuests.Size = new System.Drawing.Size(256, 232);
            this.tpQuests.TabIndex = 1;
            this.tpQuests.Text = "Квесты";
            this.tpQuests.UseVisualStyleBackColor = true;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(3, 3);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(250, 226);
            this.dgvQuests.TabIndex = 24;
            // 
            // pControlPanel
            // 
            this.pControlPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pControlPanel.Controls.Add(this.tableLayoutPanel1);
            this.pControlPanel.Location = new System.Drawing.Point(594, 220);
            this.pControlPanel.Name = "pControlPanel";
            this.pControlPanel.Size = new System.Drawing.Size(284, 100);
            this.pControlPanel.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnFindLoot, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNorth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEast, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSouth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnWest, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTrade, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnNorth
            // 
            this.btnNorth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNorth.Location = new System.Drawing.Point(97, 3);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(88, 27);
            this.btnNorth.TabIndex = 25;
            this.btnNorth.Text = "Север";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEast.Location = new System.Drawing.Point(191, 36);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(90, 27);
            this.btnEast.TabIndex = 24;
            this.btnEast.Text = "Восток";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSouth.Location = new System.Drawing.Point(97, 69);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(88, 28);
            this.btnSouth.TabIndex = 23;
            this.btnSouth.Text = "Юг";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWest.Location = new System.Drawing.Point(3, 36);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(88, 27);
            this.btnWest.TabIndex = 22;
            this.btnWest.Text = "Запад";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTrade.Location = new System.Drawing.Point(97, 36);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(88, 27);
            this.btnTrade.TabIndex = 26;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // btnFindLoot
            // 
            this.btnFindLoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindLoot.Location = new System.Drawing.Point(3, 69);
            this.btnFindLoot.Name = "btnFindLoot";
            this.btnFindLoot.Size = new System.Drawing.Size(88, 28);
            this.btnFindLoot.TabIndex = 27;
            this.btnFindLoot.Text = "Искать";
            this.btnFindLoot.UseVisualStyleBackColor = true;
            this.btnFindLoot.Click += new System.EventHandler(this.btnFindLoot_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(886, 385);
            this.Controls.Add(this.pControlPanel);
            this.Controls.Add(this.tcDataViewer);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SuperAdventure";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My first RPG game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SuperAdventure_FormClosing);
            this.tcDataViewer.ResumeLayout(false);
            this.tpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tpQuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            this.pControlPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.TabControl tcDataViewer;
        private System.Windows.Forms.TabPage tpInventory;
        private System.Windows.Forms.TabPage tpQuests;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.Panel pControlPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnFindLoot;
    }
}

