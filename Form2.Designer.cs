﻿namespace OAO;

partial class Form2
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
        panel1 = new Panel();
        button1 = new Button();
        textBox1 = new TextBox();
        label1 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.None;
        panel1.BackgroundImageLayout = ImageLayout.Stretch;
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(407, 164);
        panel1.Name = "panel1";
        panel1.Size = new Size(1047, 494);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(128, 128, 255);
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        button1.Location = new Point(382, 293);
        button1.Name = "button1";
        button1.Size = new Size(244, 68);
        button1.TabIndex = 2;
        button1.Text = "Submit";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.BackColor = Color.FromArgb(128, 128, 255);
        textBox1.BorderStyle = BorderStyle.FixedSingle;
        textBox1.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        textBox1.Location = new Point(48, 145);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(939, 103);
        textBox1.TabIndex = 1;
        textBox1.TextAlign = HorizontalAlignment.Center;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Showcard Gothic", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(140, 43);
        label1.Name = "label1";
        label1.Size = new Size(755, 68);
        label1.TabIndex = 0;
        label1.Text = "What color is a mirror?";
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(128, 128, 255);
        ClientSize = new Size(1816, 916);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form2";
        Text = "Form2";
        WindowState = FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Button button1;
    private TextBox textBox1;
}