﻿namespace Calculator
{
    partial class CalcForm
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
            panelShowMain = new Panel();
            tableLayoutPanelChooseFunction = new TableLayoutPanel();
            buttonFindAbs = new Button();
            buttonFindFactorial = new Button();
            buttonFindPowerOfNumbers = new Button();
            buttonFindPowerOfTen = new Button();
            buttonFindTan = new Button();
            buttonFindSin = new Button();
            buttonFindCos = new Button();
            buttonFindPi = new Button();
            buttonFindExp = new Button();
            buttonOperationDifference = new Button();
            buttonSymbolPoint = new Button();
            buttonNumberZero = new Button();
            buttonOperationResult = new Button();
            buttonOperationSumma = new Button();
            buttonNumberThree = new Button();
            buttonNumberTwo = new Button();
            buttonNumberOne = new Button();
            buttonChangeSign = new Button();
            buttonOperationMultiplication = new Button();
            buttonNumberSix = new Button();
            buttonNumberFive = new Button();
            buttonNumberFour = new Button();
            buttonOperationPercent = new Button();
            buttonOperationQuotient = new Button();
            buttonNumberNine = new Button();
            buttonNumberEight = new Button();
            buttonNumberSeven = new Button();
            buttonClearSymbol = new Button();
            buttonClearAll = new Button();
            buttonFindReciprocal = new Button();
            buttonFindSqrt = new Button();
            buttonFindSquare = new Button();
            buttonFindLn = new Button();
            panelShowResult = new Panel();
            labelShowExpression = new Label();
            textBoxShowResult = new TextBox();
            menuStripTypeOFCalc = new MenuStrip();
            ToolStripMenuItemType = new ToolStripMenuItem();
            ToolStripMenuItemOrdinary = new ToolStripMenuItem();
            ToolStripMenuItemArithmetic = new ToolStripMenuItem();
            ToolStripMenuItemInfo = new ToolStripMenuItem();
            panelShowMain.SuspendLayout();
            tableLayoutPanelChooseFunction.SuspendLayout();
            panelShowResult.SuspendLayout();
            menuStripTypeOFCalc.SuspendLayout();
            SuspendLayout();
            // 
            // panelShowMain
            // 
            panelShowMain.Controls.Add(tableLayoutPanelChooseFunction);
            panelShowMain.Controls.Add(panelShowResult);
            panelShowMain.Dock = DockStyle.Fill;
            panelShowMain.Location = new Point(0, 0);
            panelShowMain.Name = "panelShowMain";
            panelShowMain.Size = new Size(634, 561);
            panelShowMain.TabIndex = 0;
            // 
            // tableLayoutPanelChooseFunction
            // 
            tableLayoutPanelChooseFunction.BackColor = Color.Teal;
            tableLayoutPanelChooseFunction.ColumnCount = 6;
            tableLayoutPanelChooseFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelChooseFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelChooseFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelChooseFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelChooseFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelChooseFunction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindAbs, 4, 1);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindFactorial, 4, 4);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindPowerOfNumbers, 4, 2);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindPowerOfTen, 4, 3);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindTan, 5, 4);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindSin, 5, 2);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindCos, 5, 3);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindPi, 5, 1);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindExp, 5, 5);
            tableLayoutPanelChooseFunction.Controls.Add(buttonOperationDifference, 3, 3);
            tableLayoutPanelChooseFunction.Controls.Add(buttonSymbolPoint, 2, 5);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberZero, 1, 5);
            tableLayoutPanelChooseFunction.Controls.Add(buttonOperationResult, 3, 4);
            tableLayoutPanelChooseFunction.Controls.Add(buttonOperationSumma, 3, 2);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberThree, 2, 4);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberTwo, 1, 4);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberOne, 0, 4);
            tableLayoutPanelChooseFunction.Controls.Add(buttonChangeSign, 0, 5);
            tableLayoutPanelChooseFunction.Controls.Add(buttonOperationMultiplication, 3, 1);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberSix, 2, 3);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberFive, 1, 3);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberFour, 0, 3);
            tableLayoutPanelChooseFunction.Controls.Add(buttonOperationPercent, 0, 0);
            tableLayoutPanelChooseFunction.Controls.Add(buttonOperationQuotient, 2, 1);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberNine, 2, 2);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberEight, 1, 2);
            tableLayoutPanelChooseFunction.Controls.Add(buttonNumberSeven, 0, 2);
            tableLayoutPanelChooseFunction.Controls.Add(buttonClearSymbol, 3, 0);
            tableLayoutPanelChooseFunction.Controls.Add(buttonClearAll, 2, 0);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindReciprocal, 1, 0);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindSqrt, 1, 1);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindSquare, 0, 1);
            tableLayoutPanelChooseFunction.Controls.Add(buttonFindLn, 4, 5);
            tableLayoutPanelChooseFunction.Dock = DockStyle.Fill;
            tableLayoutPanelChooseFunction.Location = new Point(0, 100);
            tableLayoutPanelChooseFunction.Name = "tableLayoutPanelChooseFunction";
            tableLayoutPanelChooseFunction.RowCount = 6;
            tableLayoutPanelChooseFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelChooseFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelChooseFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelChooseFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelChooseFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelChooseFunction.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelChooseFunction.Size = new Size(634, 461);
            tableLayoutPanelChooseFunction.TabIndex = 1;
            // 
            // buttonFindAbs
            // 
            buttonFindAbs.BackColor = Color.PaleGoldenrod;
            buttonFindAbs.Dock = DockStyle.Fill;
            buttonFindAbs.FlatAppearance.BorderSize = 0;
            buttonFindAbs.FlatStyle = FlatStyle.Popup;
            buttonFindAbs.Font = new Font("Segoe UI", 15F);
            buttonFindAbs.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindAbs.Location = new Point(422, 78);
            buttonFindAbs.Margin = new Padding(2);
            buttonFindAbs.Name = "buttonFindAbs";
            buttonFindAbs.Size = new Size(101, 72);
            buttonFindAbs.TabIndex = 33;
            buttonFindAbs.Text = "|x|";
            buttonFindAbs.UseVisualStyleBackColor = false;
            buttonFindAbs.Click += buttonFindAbs_Click;
            // 
            // buttonFindFactorial
            // 
            buttonFindFactorial.BackColor = Color.PaleGoldenrod;
            buttonFindFactorial.Dock = DockStyle.Fill;
            buttonFindFactorial.FlatAppearance.BorderSize = 0;
            buttonFindFactorial.FlatStyle = FlatStyle.Popup;
            buttonFindFactorial.Font = new Font("Segoe UI", 15F);
            buttonFindFactorial.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindFactorial.Location = new Point(422, 306);
            buttonFindFactorial.Margin = new Padding(2);
            buttonFindFactorial.Name = "buttonFindFactorial";
            buttonFindFactorial.Size = new Size(101, 72);
            buttonFindFactorial.TabIndex = 32;
            buttonFindFactorial.Text = "x!";
            buttonFindFactorial.UseVisualStyleBackColor = false;
            buttonFindFactorial.Click += buttonFindFactorial_Click;
            // 
            // buttonFindPowerOfNumbers
            // 
            buttonFindPowerOfNumbers.BackColor = Color.PaleGoldenrod;
            buttonFindPowerOfNumbers.Dock = DockStyle.Fill;
            buttonFindPowerOfNumbers.FlatAppearance.BorderSize = 0;
            buttonFindPowerOfNumbers.FlatStyle = FlatStyle.Popup;
            buttonFindPowerOfNumbers.Font = new Font("Segoe UI", 15F);
            buttonFindPowerOfNumbers.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindPowerOfNumbers.Location = new Point(422, 154);
            buttonFindPowerOfNumbers.Margin = new Padding(2);
            buttonFindPowerOfNumbers.Name = "buttonFindPowerOfNumbers";
            buttonFindPowerOfNumbers.Size = new Size(101, 72);
            buttonFindPowerOfNumbers.TabIndex = 31;
            buttonFindPowerOfNumbers.Text = "x^n";
            buttonFindPowerOfNumbers.UseVisualStyleBackColor = false;
            buttonFindPowerOfNumbers.Click += buttonFindPowerOfNumbers_Click;
            // 
            // buttonFindPowerOfTen
            // 
            buttonFindPowerOfTen.BackColor = Color.PaleGoldenrod;
            buttonFindPowerOfTen.Dock = DockStyle.Fill;
            buttonFindPowerOfTen.FlatAppearance.BorderSize = 0;
            buttonFindPowerOfTen.FlatStyle = FlatStyle.Popup;
            buttonFindPowerOfTen.Font = new Font("Segoe UI", 15F);
            buttonFindPowerOfTen.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindPowerOfTen.Location = new Point(422, 230);
            buttonFindPowerOfTen.Margin = new Padding(2);
            buttonFindPowerOfTen.Name = "buttonFindPowerOfTen";
            buttonFindPowerOfTen.Size = new Size(101, 72);
            buttonFindPowerOfTen.TabIndex = 30;
            buttonFindPowerOfTen.Text = " x^10";
            buttonFindPowerOfTen.UseVisualStyleBackColor = false;
            buttonFindPowerOfTen.Click += buttonFindPowerOfTen_Click;
            // 
            // buttonFindTan
            // 
            buttonFindTan.BackColor = Color.PaleGoldenrod;
            buttonFindTan.Dock = DockStyle.Fill;
            buttonFindTan.FlatAppearance.BorderSize = 0;
            buttonFindTan.FlatStyle = FlatStyle.Popup;
            buttonFindTan.Font = new Font("Segoe UI", 15F);
            buttonFindTan.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindTan.Location = new Point(527, 306);
            buttonFindTan.Margin = new Padding(2);
            buttonFindTan.Name = "buttonFindTan";
            buttonFindTan.Size = new Size(105, 72);
            buttonFindTan.TabIndex = 29;
            buttonFindTan.Text = "Tn(x)";
            buttonFindTan.UseVisualStyleBackColor = false;
            buttonFindTan.Click += buttonFindTan_Click;
            // 
            // buttonFindSin
            // 
            buttonFindSin.BackColor = Color.PaleGoldenrod;
            buttonFindSin.Dock = DockStyle.Fill;
            buttonFindSin.FlatAppearance.BorderSize = 0;
            buttonFindSin.FlatStyle = FlatStyle.Popup;
            buttonFindSin.Font = new Font("Segoe UI", 15F);
            buttonFindSin.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindSin.Location = new Point(527, 154);
            buttonFindSin.Margin = new Padding(2);
            buttonFindSin.Name = "buttonFindSin";
            buttonFindSin.Size = new Size(105, 72);
            buttonFindSin.TabIndex = 28;
            buttonFindSin.Text = "Sin(x)";
            buttonFindSin.UseVisualStyleBackColor = false;
            buttonFindSin.Click += buttonFindSin_Click;
            // 
            // buttonFindCos
            // 
            buttonFindCos.BackColor = Color.PaleGoldenrod;
            buttonFindCos.Dock = DockStyle.Fill;
            buttonFindCos.FlatAppearance.BorderSize = 0;
            buttonFindCos.FlatStyle = FlatStyle.Popup;
            buttonFindCos.Font = new Font("Segoe UI", 15F);
            buttonFindCos.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindCos.Location = new Point(527, 230);
            buttonFindCos.Margin = new Padding(2);
            buttonFindCos.Name = "buttonFindCos";
            buttonFindCos.Size = new Size(105, 72);
            buttonFindCos.TabIndex = 27;
            buttonFindCos.Text = "Cos(x)";
            buttonFindCos.UseVisualStyleBackColor = false;
            buttonFindCos.Click += buttonFindCos_Click;
            // 
            // buttonFindPi
            // 
            buttonFindPi.BackColor = Color.PaleGoldenrod;
            buttonFindPi.Dock = DockStyle.Fill;
            buttonFindPi.FlatAppearance.BorderSize = 0;
            buttonFindPi.FlatStyle = FlatStyle.Popup;
            buttonFindPi.Font = new Font("Segoe UI", 15F);
            buttonFindPi.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindPi.Location = new Point(527, 78);
            buttonFindPi.Margin = new Padding(2);
            buttonFindPi.Name = "buttonFindPi";
            buttonFindPi.Size = new Size(105, 72);
            buttonFindPi.TabIndex = 26;
            buttonFindPi.Text = "Pi";
            buttonFindPi.UseVisualStyleBackColor = false;
            buttonFindPi.Click += buttonFindPi_Click;
            // 
            // buttonFindExp
            // 
            buttonFindExp.BackColor = Color.PaleGoldenrod;
            buttonFindExp.Dock = DockStyle.Fill;
            buttonFindExp.FlatAppearance.BorderSize = 0;
            buttonFindExp.FlatStyle = FlatStyle.Popup;
            buttonFindExp.Font = new Font("Segoe UI", 15F);
            buttonFindExp.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindExp.Location = new Point(527, 382);
            buttonFindExp.Margin = new Padding(2);
            buttonFindExp.Name = "buttonFindExp";
            buttonFindExp.Size = new Size(105, 77);
            buttonFindExp.TabIndex = 25;
            buttonFindExp.Text = "Exp(x)";
            buttonFindExp.UseVisualStyleBackColor = false;
            buttonFindExp.Click += buttonFindExp_Click;
            // 
            // buttonOperationDifference
            // 
            buttonOperationDifference.BackColor = Color.PaleGoldenrod;
            buttonOperationDifference.Dock = DockStyle.Fill;
            buttonOperationDifference.FlatAppearance.BorderSize = 0;
            buttonOperationDifference.FlatStyle = FlatStyle.Popup;
            buttonOperationDifference.Font = new Font("Segoe UI", 25F);
            buttonOperationDifference.ForeColor = SystemColors.ActiveCaptionText;
            buttonOperationDifference.Location = new Point(317, 230);
            buttonOperationDifference.Margin = new Padding(2);
            buttonOperationDifference.Name = "buttonOperationDifference";
            buttonOperationDifference.Size = new Size(101, 72);
            buttonOperationDifference.TabIndex = 23;
            buttonOperationDifference.Text = "-";
            buttonOperationDifference.UseVisualStyleBackColor = false;
            buttonOperationDifference.Click += buttonOperationDifference_Click;
            // 
            // buttonSymbolPoint
            // 
            buttonSymbolPoint.BackColor = Color.PaleGoldenrod;
            buttonSymbolPoint.Dock = DockStyle.Fill;
            buttonSymbolPoint.FlatAppearance.BorderSize = 0;
            buttonSymbolPoint.FlatStyle = FlatStyle.Popup;
            buttonSymbolPoint.Font = new Font("Segoe UI", 25F);
            buttonSymbolPoint.ForeColor = SystemColors.ActiveCaptionText;
            buttonSymbolPoint.Location = new Point(212, 382);
            buttonSymbolPoint.Margin = new Padding(2);
            buttonSymbolPoint.Name = "buttonSymbolPoint";
            buttonSymbolPoint.Size = new Size(101, 77);
            buttonSymbolPoint.TabIndex = 22;
            buttonSymbolPoint.Text = ".";
            buttonSymbolPoint.UseVisualStyleBackColor = false;
            buttonSymbolPoint.Click += buttonSymbolPoint_Click;
            // 
            // buttonNumberZero
            // 
            buttonNumberZero.BackColor = Color.PaleGoldenrod;
            buttonNumberZero.Dock = DockStyle.Fill;
            buttonNumberZero.FlatAppearance.BorderSize = 0;
            buttonNumberZero.FlatStyle = FlatStyle.Popup;
            buttonNumberZero.Font = new Font("Segoe UI", 25F);
            buttonNumberZero.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberZero.Location = new Point(107, 382);
            buttonNumberZero.Margin = new Padding(2);
            buttonNumberZero.Name = "buttonNumberZero";
            buttonNumberZero.Size = new Size(101, 77);
            buttonNumberZero.TabIndex = 20;
            buttonNumberZero.Text = "0";
            buttonNumberZero.UseVisualStyleBackColor = false;
            buttonNumberZero.Click += buttonNumberZero_Click;
            // 
            // buttonOperationResult
            // 
            buttonOperationResult.BackColor = Color.PaleGoldenrod;
            buttonOperationResult.Dock = DockStyle.Fill;
            buttonOperationResult.FlatAppearance.BorderSize = 0;
            buttonOperationResult.FlatStyle = FlatStyle.Popup;
            buttonOperationResult.Font = new Font("Segoe UI", 25F);
            buttonOperationResult.ForeColor = SystemColors.ActiveCaptionText;
            buttonOperationResult.Location = new Point(317, 306);
            buttonOperationResult.Margin = new Padding(2);
            buttonOperationResult.Name = "buttonOperationResult";
            tableLayoutPanelChooseFunction.SetRowSpan(buttonOperationResult, 2);
            buttonOperationResult.Size = new Size(101, 153);
            buttonOperationResult.TabIndex = 19;
            buttonOperationResult.Text = "=";
            buttonOperationResult.UseVisualStyleBackColor = false;
            buttonOperationResult.Click += buttonOperationResult_Click;
            // 
            // buttonOperationSumma
            // 
            buttonOperationSumma.BackColor = Color.PaleGoldenrod;
            buttonOperationSumma.Dock = DockStyle.Fill;
            buttonOperationSumma.FlatAppearance.BorderSize = 0;
            buttonOperationSumma.FlatStyle = FlatStyle.Popup;
            buttonOperationSumma.Font = new Font("Segoe UI", 25F);
            buttonOperationSumma.ForeColor = SystemColors.ActiveCaptionText;
            buttonOperationSumma.Location = new Point(317, 154);
            buttonOperationSumma.Margin = new Padding(2);
            buttonOperationSumma.Name = "buttonOperationSumma";
            buttonOperationSumma.Size = new Size(101, 72);
            buttonOperationSumma.TabIndex = 18;
            buttonOperationSumma.Text = "+";
            buttonOperationSumma.UseVisualStyleBackColor = false;
            buttonOperationSumma.Click += buttonOperationSumma_Click;
            // 
            // buttonNumberThree
            // 
            buttonNumberThree.BackColor = Color.PaleGoldenrod;
            buttonNumberThree.Dock = DockStyle.Fill;
            buttonNumberThree.FlatAppearance.BorderSize = 0;
            buttonNumberThree.FlatStyle = FlatStyle.Popup;
            buttonNumberThree.Font = new Font("Segoe UI", 25F);
            buttonNumberThree.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberThree.Location = new Point(212, 306);
            buttonNumberThree.Margin = new Padding(2);
            buttonNumberThree.Name = "buttonNumberThree";
            buttonNumberThree.Size = new Size(101, 72);
            buttonNumberThree.TabIndex = 17;
            buttonNumberThree.Text = "3";
            buttonNumberThree.UseVisualStyleBackColor = false;
            buttonNumberThree.Click += buttonNumberThree_Click;
            // 
            // buttonNumberTwo
            // 
            buttonNumberTwo.BackColor = Color.PaleGoldenrod;
            buttonNumberTwo.Dock = DockStyle.Fill;
            buttonNumberTwo.FlatAppearance.BorderSize = 0;
            buttonNumberTwo.FlatStyle = FlatStyle.Popup;
            buttonNumberTwo.Font = new Font("Segoe UI", 25F);
            buttonNumberTwo.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberTwo.Location = new Point(107, 306);
            buttonNumberTwo.Margin = new Padding(2);
            buttonNumberTwo.Name = "buttonNumberTwo";
            buttonNumberTwo.Size = new Size(101, 72);
            buttonNumberTwo.TabIndex = 16;
            buttonNumberTwo.Text = "2";
            buttonNumberTwo.UseVisualStyleBackColor = false;
            buttonNumberTwo.Click += buttonNumberTwo_Click;
            // 
            // buttonNumberOne
            // 
            buttonNumberOne.BackColor = Color.PaleGoldenrod;
            buttonNumberOne.Dock = DockStyle.Fill;
            buttonNumberOne.FlatAppearance.BorderSize = 0;
            buttonNumberOne.FlatStyle = FlatStyle.Popup;
            buttonNumberOne.Font = new Font("Segoe UI", 25F);
            buttonNumberOne.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberOne.Location = new Point(2, 306);
            buttonNumberOne.Margin = new Padding(2);
            buttonNumberOne.Name = "buttonNumberOne";
            buttonNumberOne.Size = new Size(101, 72);
            buttonNumberOne.TabIndex = 15;
            buttonNumberOne.Text = "1";
            buttonNumberOne.UseVisualStyleBackColor = false;
            buttonNumberOne.Click += buttonNumberOne_Click;
            // 
            // buttonChangeSign
            // 
            buttonChangeSign.BackColor = Color.PaleGoldenrod;
            buttonChangeSign.Dock = DockStyle.Fill;
            buttonChangeSign.FlatAppearance.BorderSize = 0;
            buttonChangeSign.FlatStyle = FlatStyle.Popup;
            buttonChangeSign.Font = new Font("Segoe UI", 25F);
            buttonChangeSign.ForeColor = SystemColors.ActiveCaptionText;
            buttonChangeSign.Location = new Point(2, 382);
            buttonChangeSign.Margin = new Padding(2);
            buttonChangeSign.Name = "buttonChangeSign";
            buttonChangeSign.Size = new Size(101, 77);
            buttonChangeSign.TabIndex = 14;
            buttonChangeSign.Text = "±";
            buttonChangeSign.UseVisualStyleBackColor = false;
            buttonChangeSign.Click += buttonChangeSign_Click;
            // 
            // buttonOperationMultiplication
            // 
            buttonOperationMultiplication.BackColor = Color.PaleGoldenrod;
            buttonOperationMultiplication.Dock = DockStyle.Fill;
            buttonOperationMultiplication.FlatAppearance.BorderSize = 0;
            buttonOperationMultiplication.FlatStyle = FlatStyle.Popup;
            buttonOperationMultiplication.Font = new Font("Segoe UI", 25F);
            buttonOperationMultiplication.ForeColor = SystemColors.ActiveCaptionText;
            buttonOperationMultiplication.Location = new Point(317, 78);
            buttonOperationMultiplication.Margin = new Padding(2);
            buttonOperationMultiplication.Name = "buttonOperationMultiplication";
            buttonOperationMultiplication.Size = new Size(101, 72);
            buttonOperationMultiplication.TabIndex = 13;
            buttonOperationMultiplication.Text = "×";
            buttonOperationMultiplication.UseVisualStyleBackColor = false;
            buttonOperationMultiplication.Click += buttonOperationMultiplication_Click;
            // 
            // buttonNumberSix
            // 
            buttonNumberSix.BackColor = Color.PaleGoldenrod;
            buttonNumberSix.Dock = DockStyle.Fill;
            buttonNumberSix.FlatAppearance.BorderSize = 0;
            buttonNumberSix.FlatStyle = FlatStyle.Popup;
            buttonNumberSix.Font = new Font("Segoe UI", 25F);
            buttonNumberSix.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberSix.Location = new Point(212, 230);
            buttonNumberSix.Margin = new Padding(2);
            buttonNumberSix.Name = "buttonNumberSix";
            buttonNumberSix.Size = new Size(101, 72);
            buttonNumberSix.TabIndex = 12;
            buttonNumberSix.Text = "6";
            buttonNumberSix.UseVisualStyleBackColor = false;
            buttonNumberSix.Click += buttonNumberSix_Click;
            // 
            // buttonNumberFive
            // 
            buttonNumberFive.BackColor = Color.PaleGoldenrod;
            buttonNumberFive.Dock = DockStyle.Fill;
            buttonNumberFive.FlatAppearance.BorderSize = 0;
            buttonNumberFive.FlatStyle = FlatStyle.Popup;
            buttonNumberFive.Font = new Font("Segoe UI", 25F);
            buttonNumberFive.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberFive.Location = new Point(107, 230);
            buttonNumberFive.Margin = new Padding(2);
            buttonNumberFive.Name = "buttonNumberFive";
            buttonNumberFive.Size = new Size(101, 72);
            buttonNumberFive.TabIndex = 11;
            buttonNumberFive.Text = "5";
            buttonNumberFive.UseVisualStyleBackColor = false;
            buttonNumberFive.Click += buttonNumberFive_Click;
            // 
            // buttonNumberFour
            // 
            buttonNumberFour.BackColor = Color.PaleGoldenrod;
            buttonNumberFour.Dock = DockStyle.Fill;
            buttonNumberFour.FlatAppearance.BorderSize = 0;
            buttonNumberFour.FlatStyle = FlatStyle.Popup;
            buttonNumberFour.Font = new Font("Segoe UI", 25F);
            buttonNumberFour.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberFour.Location = new Point(2, 230);
            buttonNumberFour.Margin = new Padding(2);
            buttonNumberFour.Name = "buttonNumberFour";
            buttonNumberFour.Size = new Size(101, 72);
            buttonNumberFour.TabIndex = 10;
            buttonNumberFour.Text = "4";
            buttonNumberFour.UseVisualStyleBackColor = false;
            buttonNumberFour.Click += buttonNumberFour_Click;
            // 
            // buttonOperationPercent
            // 
            buttonOperationPercent.BackColor = Color.PaleGoldenrod;
            buttonOperationPercent.Dock = DockStyle.Fill;
            buttonOperationPercent.FlatAppearance.BorderSize = 0;
            buttonOperationPercent.FlatStyle = FlatStyle.Popup;
            buttonOperationPercent.Font = new Font("Segoe UI", 25F);
            buttonOperationPercent.ForeColor = SystemColors.ActiveCaptionText;
            buttonOperationPercent.Location = new Point(2, 2);
            buttonOperationPercent.Margin = new Padding(2);
            buttonOperationPercent.Name = "buttonOperationPercent";
            buttonOperationPercent.Size = new Size(101, 72);
            buttonOperationPercent.TabIndex = 9;
            buttonOperationPercent.Text = "%";
            buttonOperationPercent.UseVisualStyleBackColor = false;
            buttonOperationPercent.Click += buttonOperationPercent_Click;
            // 
            // buttonOperationQuotient
            // 
            buttonOperationQuotient.BackColor = Color.PaleGoldenrod;
            buttonOperationQuotient.Dock = DockStyle.Fill;
            buttonOperationQuotient.FlatAppearance.BorderSize = 0;
            buttonOperationQuotient.FlatStyle = FlatStyle.Popup;
            buttonOperationQuotient.Font = new Font("Segoe UI", 25F);
            buttonOperationQuotient.ForeColor = SystemColors.ActiveCaptionText;
            buttonOperationQuotient.Location = new Point(212, 78);
            buttonOperationQuotient.Margin = new Padding(2);
            buttonOperationQuotient.Name = "buttonOperationQuotient";
            buttonOperationQuotient.Size = new Size(101, 72);
            buttonOperationQuotient.TabIndex = 8;
            buttonOperationQuotient.Text = "÷";
            buttonOperationQuotient.UseVisualStyleBackColor = false;
            buttonOperationQuotient.Click += buttonOperationQuotient_Click;
            // 
            // buttonNumberNine
            // 
            buttonNumberNine.BackColor = Color.PaleGoldenrod;
            buttonNumberNine.Dock = DockStyle.Fill;
            buttonNumberNine.FlatAppearance.BorderSize = 0;
            buttonNumberNine.FlatStyle = FlatStyle.Popup;
            buttonNumberNine.Font = new Font("Segoe UI", 25F);
            buttonNumberNine.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberNine.Location = new Point(212, 154);
            buttonNumberNine.Margin = new Padding(2);
            buttonNumberNine.Name = "buttonNumberNine";
            buttonNumberNine.Size = new Size(101, 72);
            buttonNumberNine.TabIndex = 7;
            buttonNumberNine.Text = "9";
            buttonNumberNine.UseVisualStyleBackColor = false;
            buttonNumberNine.Click += buttonNumberNine_Click;
            // 
            // buttonNumberEight
            // 
            buttonNumberEight.BackColor = Color.PaleGoldenrod;
            buttonNumberEight.Dock = DockStyle.Fill;
            buttonNumberEight.FlatAppearance.BorderSize = 0;
            buttonNumberEight.FlatStyle = FlatStyle.Popup;
            buttonNumberEight.Font = new Font("Segoe UI", 25F);
            buttonNumberEight.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberEight.Location = new Point(107, 154);
            buttonNumberEight.Margin = new Padding(2);
            buttonNumberEight.Name = "buttonNumberEight";
            buttonNumberEight.Size = new Size(101, 72);
            buttonNumberEight.TabIndex = 6;
            buttonNumberEight.Text = "8";
            buttonNumberEight.UseVisualStyleBackColor = false;
            buttonNumberEight.Click += buttonNumberEight_Click;
            // 
            // buttonNumberSeven
            // 
            buttonNumberSeven.BackColor = Color.PaleGoldenrod;
            buttonNumberSeven.Dock = DockStyle.Fill;
            buttonNumberSeven.FlatAppearance.BorderSize = 0;
            buttonNumberSeven.FlatStyle = FlatStyle.Popup;
            buttonNumberSeven.Font = new Font("Segoe UI", 25F);
            buttonNumberSeven.ForeColor = SystemColors.ActiveCaptionText;
            buttonNumberSeven.Location = new Point(2, 154);
            buttonNumberSeven.Margin = new Padding(2);
            buttonNumberSeven.Name = "buttonNumberSeven";
            buttonNumberSeven.Size = new Size(101, 72);
            buttonNumberSeven.TabIndex = 5;
            buttonNumberSeven.Text = "7";
            buttonNumberSeven.UseVisualStyleBackColor = false;
            buttonNumberSeven.Click += buttonNumberSeven_Click;
            // 
            // buttonClearSymbol
            // 
            buttonClearSymbol.BackColor = Color.PaleGoldenrod;
            tableLayoutPanelChooseFunction.SetColumnSpan(buttonClearSymbol, 3);
            buttonClearSymbol.Dock = DockStyle.Fill;
            buttonClearSymbol.FlatAppearance.BorderSize = 0;
            buttonClearSymbol.FlatStyle = FlatStyle.Popup;
            buttonClearSymbol.Font = new Font("Segoe UI", 25F);
            buttonClearSymbol.ForeColor = SystemColors.ActiveCaptionText;
            buttonClearSymbol.Location = new Point(317, 2);
            buttonClearSymbol.Margin = new Padding(2);
            buttonClearSymbol.Name = "buttonClearSymbol";
            buttonClearSymbol.Size = new Size(315, 72);
            buttonClearSymbol.TabIndex = 4;
            buttonClearSymbol.Text = "←";
            buttonClearSymbol.UseVisualStyleBackColor = false;
            buttonClearSymbol.Click += buttonClearSymbol_Click;
            // 
            // buttonClearAll
            // 
            buttonClearAll.BackColor = Color.PaleGoldenrod;
            buttonClearAll.Dock = DockStyle.Fill;
            buttonClearAll.FlatAppearance.BorderSize = 0;
            buttonClearAll.FlatStyle = FlatStyle.Popup;
            buttonClearAll.Font = new Font("Segoe UI", 25F);
            buttonClearAll.ForeColor = SystemColors.ActiveCaptionText;
            buttonClearAll.Location = new Point(212, 2);
            buttonClearAll.Margin = new Padding(2);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(101, 72);
            buttonClearAll.TabIndex = 3;
            buttonClearAll.Text = "C";
            buttonClearAll.UseVisualStyleBackColor = false;
            buttonClearAll.Click += buttonClearAll_Click;
            // 
            // buttonFindReciprocal
            // 
            buttonFindReciprocal.BackColor = Color.PaleGoldenrod;
            buttonFindReciprocal.Dock = DockStyle.Fill;
            buttonFindReciprocal.FlatAppearance.BorderSize = 0;
            buttonFindReciprocal.FlatStyle = FlatStyle.Popup;
            buttonFindReciprocal.Font = new Font("Segoe UI", 25F);
            buttonFindReciprocal.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindReciprocal.Location = new Point(107, 2);
            buttonFindReciprocal.Margin = new Padding(2);
            buttonFindReciprocal.Name = "buttonFindReciprocal";
            buttonFindReciprocal.Size = new Size(101, 72);
            buttonFindReciprocal.TabIndex = 2;
            buttonFindReciprocal.Text = "⅟x\r\n";
            buttonFindReciprocal.UseVisualStyleBackColor = false;
            buttonFindReciprocal.Click += buttonFindReciprocal_Click;
            // 
            // buttonFindSqrt
            // 
            buttonFindSqrt.BackColor = Color.PaleGoldenrod;
            buttonFindSqrt.Dock = DockStyle.Fill;
            buttonFindSqrt.FlatAppearance.BorderSize = 0;
            buttonFindSqrt.FlatStyle = FlatStyle.Popup;
            buttonFindSqrt.Font = new Font("Segoe UI", 25F);
            buttonFindSqrt.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindSqrt.Location = new Point(107, 78);
            buttonFindSqrt.Margin = new Padding(2);
            buttonFindSqrt.Name = "buttonFindSqrt";
            buttonFindSqrt.Size = new Size(101, 72);
            buttonFindSqrt.TabIndex = 0;
            buttonFindSqrt.Text = "√";
            buttonFindSqrt.UseVisualStyleBackColor = false;
            buttonFindSqrt.Click += buttonFindSqrt_Click;
            // 
            // buttonFindSquare
            // 
            buttonFindSquare.BackColor = Color.PaleGoldenrod;
            buttonFindSquare.Dock = DockStyle.Fill;
            buttonFindSquare.FlatAppearance.BorderSize = 0;
            buttonFindSquare.FlatStyle = FlatStyle.Popup;
            buttonFindSquare.Font = new Font("Segoe UI", 25F);
            buttonFindSquare.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindSquare.Location = new Point(2, 78);
            buttonFindSquare.Margin = new Padding(2);
            buttonFindSquare.Name = "buttonFindSquare";
            buttonFindSquare.Size = new Size(101, 72);
            buttonFindSquare.TabIndex = 1;
            buttonFindSquare.Text = " x²";
            buttonFindSquare.UseVisualStyleBackColor = false;
            buttonFindSquare.Click += buttonFindSquare_Click;
            // 
            // buttonFindLn
            // 
            buttonFindLn.BackColor = Color.PaleGoldenrod;
            buttonFindLn.Dock = DockStyle.Fill;
            buttonFindLn.FlatAppearance.BorderSize = 0;
            buttonFindLn.FlatStyle = FlatStyle.Popup;
            buttonFindLn.Font = new Font("Segoe UI", 15F);
            buttonFindLn.ForeColor = SystemColors.ActiveCaptionText;
            buttonFindLn.Location = new Point(422, 382);
            buttonFindLn.Margin = new Padding(2);
            buttonFindLn.Name = "buttonFindLn";
            buttonFindLn.Size = new Size(101, 77);
            buttonFindLn.TabIndex = 24;
            buttonFindLn.Text = "Ln(x)";
            buttonFindLn.UseVisualStyleBackColor = false;
            buttonFindLn.Click += buttonFindLn_Click;
            // 
            // panelShowResult
            // 
            panelShowResult.Controls.Add(labelShowExpression);
            panelShowResult.Controls.Add(textBoxShowResult);
            panelShowResult.Controls.Add(menuStripTypeOFCalc);
            panelShowResult.Dock = DockStyle.Top;
            panelShowResult.Location = new Point(0, 0);
            panelShowResult.Name = "panelShowResult";
            panelShowResult.Size = new Size(634, 100);
            panelShowResult.TabIndex = 0;
            // 
            // labelShowExpression
            // 
            labelShowExpression.AutoSize = true;
            labelShowExpression.Location = new Point(0, 82);
            labelShowExpression.Name = "labelShowExpression";
            labelShowExpression.Size = new Size(0, 15);
            labelShowExpression.TabIndex = 2;
            // 
            // textBoxShowResult
            // 
            textBoxShowResult.BackColor = Color.Teal;
            textBoxShowResult.BorderStyle = BorderStyle.None;
            textBoxShowResult.Dock = DockStyle.Fill;
            textBoxShowResult.Font = new Font("Segoe UI", 25F);
            textBoxShowResult.Location = new Point(0, 24);
            textBoxShowResult.Multiline = true;
            textBoxShowResult.Name = "textBoxShowResult";
            textBoxShowResult.ReadOnly = true;
            textBoxShowResult.Size = new Size(634, 76);
            textBoxShowResult.TabIndex = 1;
            textBoxShowResult.TextAlign = HorizontalAlignment.Right;
            // 
            // menuStripTypeOFCalc
            // 
            menuStripTypeOFCalc.BackColor = Color.Teal;
            menuStripTypeOFCalc.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemType, ToolStripMenuItemInfo });
            menuStripTypeOFCalc.Location = new Point(0, 0);
            menuStripTypeOFCalc.Name = "menuStripTypeOFCalc";
            menuStripTypeOFCalc.Size = new Size(634, 24);
            menuStripTypeOFCalc.TabIndex = 0;
            menuStripTypeOFCalc.Text = "menuStrip1";
            // 
            // ToolStripMenuItemType
            // 
            ToolStripMenuItemType.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemOrdinary, ToolStripMenuItemArithmetic });
            ToolStripMenuItemType.ForeColor = SystemColors.ButtonFace;
            ToolStripMenuItemType.Name = "ToolStripMenuItemType";
            ToolStripMenuItemType.Size = new Size(39, 20);
            ToolStripMenuItemType.Text = "Тип";
            // 
            // ToolStripMenuItemOrdinary
            // 
            ToolStripMenuItemOrdinary.Name = "ToolStripMenuItemOrdinary";
            ToolStripMenuItemOrdinary.Size = new Size(154, 22);
            ToolStripMenuItemOrdinary.Text = "Стандартный";
            ToolStripMenuItemOrdinary.Click += ToolStripMenuItemOrdinary_Click;
            // 
            // ToolStripMenuItemArithmetic
            // 
            ToolStripMenuItemArithmetic.Name = "ToolStripMenuItemArithmetic";
            ToolStripMenuItemArithmetic.Size = new Size(154, 22);
            ToolStripMenuItemArithmetic.Text = "Расширенный";
            ToolStripMenuItemArithmetic.Click += ToolStripMenuItemArithmetic_Click;
            // 
            // ToolStripMenuItemInfo
            // 
            ToolStripMenuItemInfo.ForeColor = SystemColors.ButtonFace;
            ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            ToolStripMenuItemInfo.Size = new Size(65, 20);
            ToolStripMenuItemInfo.Text = "Справка";
            ToolStripMenuItemInfo.Click += ToolStripMenuItemInfo_Click;
            // 
            // CalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(634, 561);
            Controls.Add(panelShowMain);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CalcForm";
            Text = "Калькулятор";
            panelShowMain.ResumeLayout(false);
            tableLayoutPanelChooseFunction.ResumeLayout(false);
            panelShowResult.ResumeLayout(false);
            panelShowResult.PerformLayout();
            menuStripTypeOFCalc.ResumeLayout(false);
            menuStripTypeOFCalc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelShowMain;
        private Panel panelShowResult;
        private TableLayoutPanel tableLayoutPanelChooseFunction;
        private Button buttonOperationDifference;
        private Button buttonSymbolPoint;
        private Button buttonNumberZero;
        private Button buttonOperationResult;
        private Button buttonOperationSumma;
        private Button buttonNumberThree;
        private Button buttonNumberTwo;
        private Button buttonNumberOne;
        private Button buttonChangeSign;
        private Button buttonOperationMultiplication;
        private Button buttonNumberSix;
        private Button buttonNumberFive;
        private Button buttonNumberFour;
        private Button buttonOperationPercent;
        private Button buttonOperationQuotient;
        private Button buttonNumberNine;
        private Button buttonNumberEight;
        private Button buttonNumberSeven;
        private Button buttonClearSymbol;
        private Button buttonClearAll;
        private Button buttonFindReciprocal;
        private Button buttonFindSqrt;
        private Button buttonFindSquare;
        private MenuStrip menuStripTypeOFCalc;
        private ToolStripMenuItem ToolStripMenuItemType;
        private ToolStripMenuItem ToolStripMenuItemInfo;
        private ToolStripMenuItem ToolStripMenuItemOrdinary;
        private ToolStripMenuItem ToolStripMenuItemArithmetic;
        private TextBox textBoxShowResult;
        private Label labelShowExpression;
        private Button buttonFindAbs;
        private Button buttonFindFactorial;
        private Button buttonFindPowerOfNumbers;
        private Button buttonFindPowerOfTen;
        private Button buttonFindTan;
        private Button buttonFindSin;
        private Button buttonFindCos;
        private Button buttonFindPi;
        private Button buttonFindExp;
        private Button buttonFindLn;
    }
}