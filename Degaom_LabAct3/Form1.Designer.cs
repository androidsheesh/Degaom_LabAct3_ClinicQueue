namespace Degaom_LabAct3
{
    partial class Form1
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
            label1 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            txtage = new TextBox();
            label3 = new Label();
            txtreasonforvisit = new TextBox();
            label4 = new Label();
            txttype = new TextBox();
            addtoqueue = new Button();
            clear = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 92);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 54);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtname
            // 
            txtname.Location = new Point(272, 102);
            txtname.Margin = new Padding(5, 4, 5, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(337, 26);
            txtname.TabIndex = 1;
            txtname.Click += txtname_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 147);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 54);
            label2.TabIndex = 2;
            label2.Text = "Age:";
            // 
            // txtage
            // 
            txtage.Location = new Point(272, 162);
            txtage.Margin = new Padding(5, 4, 5, 4);
            txtage.Name = "txtage";
            txtage.Size = new Size(337, 26);
            txtage.TabIndex = 3;
            txtage.Click += txtage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 223);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 54);
            label3.TabIndex = 4;
            label3.Text = "Reason for visit:";
            label3.Click += label3_Click;
            // 
            // txtreasonforvisit
            // 
            txtreasonforvisit.Location = new Point(272, 238);
            txtreasonforvisit.Margin = new Padding(5, 4, 5, 4);
            txtreasonforvisit.Name = "txtreasonforvisit";
            txtreasonforvisit.Size = new Size(337, 26);
            txtreasonforvisit.TabIndex = 5;
            txtreasonforvisit.Click += txtreasonforvisit_Click;
            txtreasonforvisit.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(70, 299);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 54);
            label4.TabIndex = 6;
            label4.Text = "Type:";
            label4.Click += label4_Click;
            // 
            // txttype
            // 
            txttype.Location = new Point(272, 307);
            txttype.Margin = new Padding(5, 4, 5, 4);
            txttype.Name = "txttype";
            txttype.Size = new Size(337, 26);
            txttype.TabIndex = 7;
            txttype.Click += txttype_Click;
            // 
            // addtoqueue
            // 
            addtoqueue.BackColor = Color.Gray;
            addtoqueue.ForeColor = SystemColors.ControlLightLight;
            addtoqueue.Location = new Point(132, 383);
            addtoqueue.Margin = new Padding(5, 4, 5, 4);
            addtoqueue.Name = "addtoqueue";
            addtoqueue.Size = new Size(212, 66);
            addtoqueue.TabIndex = 8;
            addtoqueue.Text = "Add to Queue";
            addtoqueue.UseVisualStyleBackColor = false;
            addtoqueue.Click += addtoqueue_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Red;
            clear.ForeColor = SystemColors.ControlLight;
            clear.Location = new Point(360, 383);
            clear.Margin = new Padding(5, 4, 5, 4);
            clear.Name = "clear";
            clear.Size = new Size(212, 66);
            clear.TabIndex = 9;
            clear.Text = "Clear ";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(132, 41);
            label5.Name = "label5";
            label5.Size = new Size(440, 26);
            label5.TabIndex = 10;
            label5.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 570);
            Controls.Add(label5);
            Controls.Add(clear);
            Controls.Add(addtoqueue);
            Controls.Add(txttype);
            Controls.Add(label4);
            Controls.Add(txtreasonforvisit);
            Controls.Add(label3);
            Controls.Add(txtage);
            Controls.Add(label2);
            Controls.Add(txtname);
            Controls.Add(label1);
            Font = new Font("Perpetua Titling MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Patient details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private Label label2;
        private TextBox txtage;
        private Label label3;
        private TextBox txtreasonforvisit;
        private Label label4;
        private TextBox txttype;
        private Button addtoqueue;
        private Button clear;
        private Label label5;
    }
}
