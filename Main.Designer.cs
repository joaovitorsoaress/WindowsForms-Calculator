namespace Windows_Calculator;

partial class Main
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        btn0 = new Button();
        btnPoint = new Button();
        btnEqual = new Button();
        btnAddition = new Button();
        btnSubtraction = new Button();
        btnMultiplication = new Button();
        btnDivision = new Button();
        btnClear = new Button();
        btn7 = new Button();
        btn8 = new Button();
        btn9 = new Button();
        btn4 = new Button();
        btn5 = new Button();
        btn6 = new Button();
        btn1 = new Button();
        btn2 = new Button();
        btn3 = new Button();
        txtBoxCalc = new TextBox();
        lblLastCalc = new Label();
        SuspendLayout();
        // 
        // btn0
        // 
        btn0.FlatStyle = FlatStyle.System;
        btn0.Font = new Font("Arial", 16F);
        btn0.Location = new Point(7, 380);
        btn0.Name = "btn0";
        btn0.Size = new Size(155, 50);
        btn0.TabIndex = 0;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = true;
        // 
        // btnPoint
        // 
        btnPoint.FlatStyle = FlatStyle.System;
        btnPoint.Font = new Font("Arial", 16F);
        btnPoint.Location = new Point(168, 380);
        btnPoint.Name = "btnPoint";
        btnPoint.Size = new Size(75, 50);
        btnPoint.TabIndex = 1;
        btnPoint.Text = ".";
        btnPoint.UseVisualStyleBackColor = true;
        // 
        // btnEqual
        // 
        btnEqual.BackColor = Color.Orange;
        btnEqual.FlatAppearance.BorderColor = Color.Gainsboro;
        btnEqual.FlatStyle = FlatStyle.Flat;
        btnEqual.Font = new Font("Arial", 18F);
        btnEqual.ForeColor = SystemColors.ButtonFace;
        btnEqual.Location = new Point(246, 324);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new Size(75, 106);
        btnEqual.TabIndex = 2;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = false;
        // 
        // btnAddition
        // 
        btnAddition.FlatStyle = FlatStyle.System;
        btnAddition.Font = new Font("Arial", 18F);
        btnAddition.Location = new Point(246, 213);
        btnAddition.Name = "btnAddition";
        btnAddition.Size = new Size(75, 105);
        btnAddition.TabIndex = 3;
        btnAddition.Text = "+";
        btnAddition.UseVisualStyleBackColor = true;
        // 
        // btnSubtraction
        // 
        btnSubtraction.FlatStyle = FlatStyle.System;
        btnSubtraction.Font = new Font("Arial", 16F);
        btnSubtraction.Location = new Point(250, 157);
        btnSubtraction.Name = "btnSubtraction";
        btnSubtraction.Size = new Size(75, 50);
        btnSubtraction.TabIndex = 4;
        btnSubtraction.Text = "-";
        btnSubtraction.UseVisualStyleBackColor = true;
        // 
        // btnMultiplication
        // 
        btnMultiplication.FlatStyle = FlatStyle.System;
        btnMultiplication.Font = new Font("Arial", 16F);
        btnMultiplication.Location = new Point(169, 157);
        btnMultiplication.Name = "btnMultiplication";
        btnMultiplication.Size = new Size(75, 50);
        btnMultiplication.TabIndex = 5;
        btnMultiplication.Text = "*";
        btnMultiplication.UseVisualStyleBackColor = true;
        // 
        // btnDivision
        // 
        btnDivision.FlatStyle = FlatStyle.System;
        btnDivision.Font = new Font("Arial", 16F);
        btnDivision.Location = new Point(88, 157);
        btnDivision.Name = "btnDivision";
        btnDivision.Size = new Size(75, 50);
        btnDivision.TabIndex = 6;
        btnDivision.Text = "/";
        btnDivision.UseVisualStyleBackColor = true;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.IndianRed;
        btnClear.FlatAppearance.BorderColor = SystemColors.ButtonFace;
        btnClear.FlatStyle = FlatStyle.Flat;
        btnClear.Font = new Font("Arial", 16F);
        btnClear.ForeColor = SystemColors.ButtonFace;
        btnClear.Location = new Point(7, 157);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(75, 50);
        btnClear.TabIndex = 7;
        btnClear.Text = "C";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // btn7
        // 
        btn7.FlatStyle = FlatStyle.System;
        btn7.Font = new Font("Arial", 16F);
        btn7.Location = new Point(7, 212);
        btn7.Name = "btn7";
        btn7.Size = new Size(75, 50);
        btn7.TabIndex = 8;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = true;
        // 
        // btn8
        // 
        btn8.FlatStyle = FlatStyle.System;
        btn8.Font = new Font("Arial", 16F);
        btn8.Location = new Point(88, 213);
        btn8.Name = "btn8";
        btn8.Size = new Size(75, 50);
        btn8.TabIndex = 9;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = true;
        // 
        // btn9
        // 
        btn9.FlatStyle = FlatStyle.System;
        btn9.Font = new Font("Arial", 16F);
        btn9.Location = new Point(168, 213);
        btn9.Name = "btn9";
        btn9.Size = new Size(75, 50);
        btn9.TabIndex = 10;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = true;
        // 
        // btn4
        // 
        btn4.FlatStyle = FlatStyle.System;
        btn4.Font = new Font("Arial", 16F);
        btn4.Location = new Point(6, 268);
        btn4.Name = "btn4";
        btn4.Size = new Size(75, 50);
        btn4.TabIndex = 11;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = true;
        // 
        // btn5
        // 
        btn5.FlatStyle = FlatStyle.System;
        btn5.Font = new Font("Arial", 16F);
        btn5.Location = new Point(87, 268);
        btn5.Name = "btn5";
        btn5.Size = new Size(75, 50);
        btn5.TabIndex = 12;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = true;
        // 
        // btn6
        // 
        btn6.FlatStyle = FlatStyle.System;
        btn6.Font = new Font("Arial", 16F);
        btn6.Location = new Point(168, 268);
        btn6.Name = "btn6";
        btn6.Size = new Size(75, 50);
        btn6.TabIndex = 13;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = true;
        // 
        // btn1
        // 
        btn1.FlatStyle = FlatStyle.System;
        btn1.Font = new Font("Arial", 16F);
        btn1.Location = new Point(7, 324);
        btn1.Name = "btn1";
        btn1.Size = new Size(75, 50);
        btn1.TabIndex = 14;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = true;
        // 
        // btn2
        // 
        btn2.FlatStyle = FlatStyle.System;
        btn2.Font = new Font("Arial", 16F);
        btn2.Location = new Point(87, 324);
        btn2.Name = "btn2";
        btn2.Size = new Size(75, 50);
        btn2.TabIndex = 15;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = true;
        // 
        // btn3
        // 
        btn3.FlatStyle = FlatStyle.System;
        btn3.Font = new Font("Arial", 16F);
        btn3.Location = new Point(168, 324);
        btn3.Name = "btn3";
        btn3.Size = new Size(75, 50);
        btn3.TabIndex = 16;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = true;
        // 
        // txtBoxCalc
        // 
        txtBoxCalc.BackColor = SystemColors.InactiveBorder;
        txtBoxCalc.BorderStyle = BorderStyle.None;
        txtBoxCalc.Cursor = Cursors.IBeam;
        txtBoxCalc.Enabled = false;
        txtBoxCalc.Font = new Font("Arial", 32F);
        txtBoxCalc.Location = new Point(6, 66);
        txtBoxCalc.Name = "txtBoxCalc";
        txtBoxCalc.PlaceholderText = "0";
        txtBoxCalc.RightToLeft = RightToLeft.No;
        txtBoxCalc.Size = new Size(315, 50);
        txtBoxCalc.TabIndex = 17;
        txtBoxCalc.TextAlign = HorizontalAlignment.Right;
        // 
        // lblLastCalc
        // 
        lblLastCalc.AutoSize = true;
        lblLastCalc.Font = new Font("Arial", 14F);
        lblLastCalc.Location = new Point(12, 31);
        lblLastCalc.Name = "lblLastCalc";
        lblLastCalc.Size = new Size(0, 22);
        lblLastCalc.TabIndex = 18;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.InactiveBorder;
        ClientSize = new Size(334, 446);
        Controls.Add(lblLastCalc);
        Controls.Add(txtBoxCalc);
        Controls.Add(btn3);
        Controls.Add(btn2);
        Controls.Add(btn1);
        Controls.Add(btn6);
        Controls.Add(btn5);
        Controls.Add(btn4);
        Controls.Add(btn9);
        Controls.Add(btn8);
        Controls.Add(btn7);
        Controls.Add(btnClear);
        Controls.Add(btnDivision);
        Controls.Add(btnMultiplication);
        Controls.Add(btnSubtraction);
        Controls.Add(btnAddition);
        Controls.Add(btnEqual);
        Controls.Add(btnPoint);
        Controls.Add(btn0);
        Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(350, 485);
        MinimumSize = new Size(350, 485);
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculator";
        Load += Main_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn0;
    private Button btnPoint;
    private Button btnEqual;
    private Button btnAddition;
    private Button btnSubtraction;
    private Button btnMultiplication;
    private Button btnDivision;
    private Button btnClear;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private TextBox txtBoxCalc;
    private Label lblLastCalc;
}
