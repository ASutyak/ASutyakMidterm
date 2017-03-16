namespace WindowsFormsApplication1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawCards = new System.Windows.Forms.Button();
            this.compMoney = new System.Windows.Forms.TextBox();
            this.userMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userFold = new System.Windows.Forms.Button();
            this.userBet = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.userCard2 = new System.Windows.Forms.Label();
            this.userCard1 = new System.Windows.Forms.Label();
            this.table2 = new System.Windows.Forms.Label();
            this.table1 = new System.Windows.Forms.Label();
            this.table5 = new System.Windows.Forms.Label();
            this.table3 = new System.Windows.Forms.Label();
            this.table4 = new System.Windows.Forms.Label();
            this.compCard2 = new System.Windows.Forms.Label();
            this.compCard1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawCards
            // 
            this.drawCards.Location = new System.Drawing.Point(13, 193);
            this.drawCards.Name = "drawCards";
            this.drawCards.Size = new System.Drawing.Size(75, 23);
            this.drawCards.TabIndex = 0;
            this.drawCards.Text = "Draw";
            this.drawCards.UseVisualStyleBackColor = true;
            this.drawCards.Click += new System.EventHandler(this.button1_Click);
            // 
            // compMoney
            // 
            this.compMoney.Location = new System.Drawing.Point(101, 48);
            this.compMoney.Name = "compMoney";
            this.compMoney.Size = new System.Drawing.Size(60, 22);
            this.compMoney.TabIndex = 11;
            this.compMoney.Text = "$ 100";
            // 
            // userMoney
            // 
            this.userMoney.Location = new System.Drawing.Point(101, 324);
            this.userMoney.Name = "userMoney";
            this.userMoney.Size = new System.Drawing.Size(60, 22);
            this.userMoney.TabIndex = 12;
            this.userMoney.Text = "$ 100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your Money: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Comp Money: ";
            // 
            // userFold
            // 
            this.userFold.Location = new System.Drawing.Point(293, 411);
            this.userFold.Name = "userFold";
            this.userFold.Size = new System.Drawing.Size(75, 23);
            this.userFold.TabIndex = 15;
            this.userFold.Text = "Fold";
            this.userFold.UseVisualStyleBackColor = true;
            this.userFold.Click += new System.EventHandler(this.userFold_Click);
            // 
            // userBet
            // 
            this.userBet.Location = new System.Drawing.Point(199, 411);
            this.userBet.Name = "userBet";
            this.userBet.Size = new System.Drawing.Size(75, 23);
            this.userBet.TabIndex = 16;
            this.userBet.Text = "Bet 5";
            this.userBet.UseVisualStyleBackColor = true;
            this.userBet.Click += new System.EventHandler(this.userBet_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(187, 248);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(195, 22);
            this.displayBox.TabIndex = 17;
            // 
            // userCard2
            // 
            this.userCard2.AutoSize = true;
            this.userCard2.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.userCard2.Location = new System.Drawing.Point(290, 296);
            this.userCard2.MaximumSize = new System.Drawing.Size(100, 100);
            this.userCard2.MinimumSize = new System.Drawing.Size(75, 75);
            this.userCard2.Name = "userCard2";
            this.userCard2.Size = new System.Drawing.Size(75, 75);
            this.userCard2.TabIndex = 10;
            // 
            // userCard1
            // 
            this.userCard1.AutoSize = true;
            this.userCard1.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.userCard1.Location = new System.Drawing.Point(224, 296);
            this.userCard1.MaximumSize = new System.Drawing.Size(100, 100);
            this.userCard1.MinimumSize = new System.Drawing.Size(75, 75);
            this.userCard1.Name = "userCard1";
            this.userCard1.Size = new System.Drawing.Size(75, 75);
            this.userCard1.TabIndex = 9;
            // 
            // table2
            // 
            this.table2.AutoSize = true;
            this.table2.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.table2.Location = new System.Drawing.Point(187, 141);
            this.table2.MaximumSize = new System.Drawing.Size(100, 100);
            this.table2.MinimumSize = new System.Drawing.Size(75, 75);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(75, 75);
            this.table2.TabIndex = 8;
            // 
            // table1
            // 
            this.table1.AutoSize = true;
            this.table1.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.table1.Location = new System.Drawing.Point(109, 141);
            this.table1.MaximumSize = new System.Drawing.Size(100, 100);
            this.table1.MinimumSize = new System.Drawing.Size(75, 75);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(75, 75);
            this.table1.TabIndex = 7;
            // 
            // table5
            // 
            this.table5.AutoSize = true;
            this.table5.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.table5.Location = new System.Drawing.Point(407, 141);
            this.table5.MaximumSize = new System.Drawing.Size(100, 100);
            this.table5.MinimumSize = new System.Drawing.Size(75, 75);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(75, 75);
            this.table5.TabIndex = 6;
            // 
            // table3
            // 
            this.table3.AutoSize = true;
            this.table3.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.table3.Location = new System.Drawing.Point(264, 141);
            this.table3.MaximumSize = new System.Drawing.Size(100, 100);
            this.table3.MinimumSize = new System.Drawing.Size(75, 75);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(75, 75);
            this.table3.TabIndex = 5;
            // 
            // table4
            // 
            this.table4.AutoSize = true;
            this.table4.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.table4.Location = new System.Drawing.Point(335, 141);
            this.table4.MaximumSize = new System.Drawing.Size(100, 100);
            this.table4.MinimumSize = new System.Drawing.Size(75, 75);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(75, 75);
            this.table4.TabIndex = 4;
            // 
            // compCard2
            // 
            this.compCard2.AutoSize = true;
            this.compCard2.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.compCard2.Location = new System.Drawing.Point(290, 29);
            this.compCard2.MaximumSize = new System.Drawing.Size(100, 100);
            this.compCard2.MinimumSize = new System.Drawing.Size(75, 75);
            this.compCard2.Name = "compCard2";
            this.compCard2.Size = new System.Drawing.Size(75, 75);
            this.compCard2.TabIndex = 2;
            // 
            // compCard1
            // 
            this.compCard1.AutoSize = true;
            this.compCard1.Image = global::WindowsFormsApplication1.Properties.Resources.cardBack;
            this.compCard1.Location = new System.Drawing.Point(224, 29);
            this.compCard1.MaximumSize = new System.Drawing.Size(100, 100);
            this.compCard1.MinimumSize = new System.Drawing.Size(75, 75);
            this.compCard1.Name = "compCard1";
            this.compCard1.Size = new System.Drawing.Size(75, 75);
            this.compCard1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(518, 446);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.userBet);
            this.Controls.Add(this.userFold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userMoney);
            this.Controls.Add(this.compMoney);
            this.Controls.Add(this.userCard2);
            this.Controls.Add(this.userCard1);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.table5);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.compCard2);
            this.Controls.Add(this.compCard1);
            this.Controls.Add(this.drawCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawCards;
        private System.Windows.Forms.Label compCard1;
        private System.Windows.Forms.Label compCard2;
        private System.Windows.Forms.Label table4;
        private System.Windows.Forms.Label table5;
        private System.Windows.Forms.Label table3;
        private System.Windows.Forms.Label table2;
        private System.Windows.Forms.Label table1;
        private System.Windows.Forms.Label userCard2;
        private System.Windows.Forms.Label userCard1;
        private System.Windows.Forms.TextBox compMoney;
        private System.Windows.Forms.TextBox userMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button userFold;
        private System.Windows.Forms.Button userBet;
        private System.Windows.Forms.TextBox displayBox;
    }
}

