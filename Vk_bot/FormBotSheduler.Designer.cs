namespace Vk_bot
{
    partial class FormBotSheduler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBotSheduler));
            this.checkBoxBS = new System.Windows.Forms.CheckBox();
            this.timerBotMess = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxBS
            // 
            this.checkBoxBS.AutoSize = true;
            this.checkBoxBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBS.Location = new System.Drawing.Point(15, 12);
            this.checkBoxBS.Name = "checkBoxBS";
            this.checkBoxBS.Size = new System.Drawing.Size(119, 24);
            this.checkBoxBS.TabIndex = 0;
            this.checkBoxBS.Text = "Вкл./Вылк.";
            this.checkBoxBS.UseVisualStyleBackColor = true;
            this.checkBoxBS.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timerBotMess
            // 
            this.timerBotMess.Interval = 1000;
            this.timerBotMess.Tick += new System.EventHandler(this.timerBotMess_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(737, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 133);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(179, 269);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 169);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Алгебра\r\nФизика\r\nИнформатаика \r\nФизра \r\nРуская мова \r\nенглески язик \r\n";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(179, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Уроки";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 243);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 20);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "c#";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 269);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(161, 169);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "втарнык 14:00\r\nчоаятвирк 14:00\r\n\r\n";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Отправить заготовленное сообщиние человку.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "заготовленный текст на сообщение со словом";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(291, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(352, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ваш токен сообщества ВКонтакте:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormBotSheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxBS);
            this.Name = "FormBotSheduler";
            this.Text = "FormBotSheduler";
            this.Load += new System.EventHandler(this.FormBotSheduler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBS;
        private System.Windows.Forms.Timer timerBotMess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}