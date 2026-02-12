namespace Algorithms_lab02
{
    partial class CalculatorForm
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
            tabControl = new TabControl();
            tabCalc = new TabPage();
            panel1 = new Panel();
            btnCalcGCDLCM = new Button();
            num2TextBox = new TextBox();
            num1TextBox = new TextBox();
            num2Lb = new Label();
            num1Lb = new Label();
            tabSteps = new TabPage();
            tabVisual = new TabPage();
            GCDLabel = new Label();
            LCMLabel = new Label();
            resultGCD = new Label();
            resultLCM = new Label();
            tabControl.SuspendLayout();
            tabCalc.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCalc);
            tabControl.Controls.Add(tabSteps);
            tabControl.Controls.Add(tabVisual);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            // 
            // tabCalc
            // 
            tabCalc.Controls.Add(panel1);
            tabCalc.Location = new Point(4, 29);
            tabCalc.Name = "tabCalc";
            tabCalc.Padding = new Padding(3);
            tabCalc.Size = new Size(792, 417);
            tabCalc.TabIndex = 0;
            tabCalc.Text = "Калькулятор НОД/НОК";
            tabCalc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(resultLCM);
            panel1.Controls.Add(resultGCD);
            panel1.Controls.Add(LCMLabel);
            panel1.Controls.Add(GCDLabel);
            panel1.Controls.Add(btnCalcGCDLCM);
            panel1.Controls.Add(num2TextBox);
            panel1.Controls.Add(num1TextBox);
            panel1.Controls.Add(num2Lb);
            panel1.Controls.Add(num1Lb);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 411);
            panel1.TabIndex = 0;
            // 
            // btnCalcGCDLCM
            // 
            btnCalcGCDLCM.Location = new Point(529, 23);
            btnCalcGCDLCM.Name = "btnCalcGCDLCM";
            btnCalcGCDLCM.Size = new Size(180, 81);
            btnCalcGCDLCM.TabIndex = 4;
            btnCalcGCDLCM.Text = "Вычислить НОД И НОК";
            btnCalcGCDLCM.UseVisualStyleBackColor = true;
            btnCalcGCDLCM.Click += btnCalcGCDLCM_Click;
            // 
            // num2TextBox
            // 
            num2TextBox.Location = new Point(209, 77);
            num2TextBox.Name = "num2TextBox";
            num2TextBox.PlaceholderText = "1432";
            num2TextBox.Size = new Size(285, 27);
            num2TextBox.TabIndex = 3;
            // 
            // num1TextBox
            // 
            num1TextBox.Location = new Point(209, 23);
            num1TextBox.Name = "num1TextBox";
            num1TextBox.PlaceholderText = "754";
            num1TextBox.Size = new Size(285, 27);
            num1TextBox.TabIndex = 2;
            // 
            // num2Lb
            // 
            num2Lb.AutoSize = true;
            num2Lb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num2Lb.Location = new Point(38, 73);
            num2Lb.Name = "num2Lb";
            num2Lb.Size = new Size(165, 28);
            num2Lb.TabIndex = 1;
            num2Lb.Text = "Введите число 2:";
            // 
            // num1Lb
            // 
            num1Lb.AutoSize = true;
            num1Lb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            num1Lb.Location = new Point(38, 19);
            num1Lb.Name = "num1Lb";
            num1Lb.Size = new Size(165, 28);
            num1Lb.TabIndex = 0;
            num1Lb.Text = "Введите число 1:";
            // 
            // tabSteps
            // 
            tabSteps.Location = new Point(4, 29);
            tabSteps.Name = "tabSteps";
            tabSteps.Padding = new Padding(3);
            tabSteps.Size = new Size(792, 417);
            tabSteps.TabIndex = 1;
            tabSteps.Text = "Шаги алгоритма Евклида";
            tabSteps.UseVisualStyleBackColor = true;
            // 
            // tabVisual
            // 
            tabVisual.Location = new Point(4, 29);
            tabVisual.Name = "tabVisual";
            tabVisual.Padding = new Padding(3);
            tabVisual.Size = new Size(792, 417);
            tabVisual.TabIndex = 2;
            tabVisual.Text = "Визуализация вычитанием";
            tabVisual.UseVisualStyleBackColor = true;
            // 
            // GCDLabel
            // 
            GCDLabel.AutoSize = true;
            GCDLabel.Location = new Point(209, 151);
            GCDLabel.Name = "GCDLabel";
            GCDLabel.Size = new Size(44, 20);
            GCDLabel.TabIndex = 5;
            GCDLabel.Text = "НОД:";
            // 
            // LCMLabel
            // 
            LCMLabel.AutoSize = true;
            LCMLabel.Location = new Point(209, 201);
            LCMLabel.Name = "LCMLabel";
            LCMLabel.Size = new Size(43, 20);
            LCMLabel.TabIndex = 6;
            LCMLabel.Text = "НОК:";
            // 
            // resultGCD
            // 
            resultGCD.AutoSize = true;
            resultGCD.Location = new Point(259, 151);
            resultGCD.Name = "resultGCD";
            resultGCD.Size = new Size(0, 20);
            resultGCD.TabIndex = 7;
            resultGCD.Click += label1_Click;
            // 
            // resultLCM
            // 
            resultLCM.AutoSize = true;
            resultLCM.Location = new Point(259, 201);
            resultLCM.Name = "resultLCM";
            resultLCM.Size = new Size(0, 20);
            resultLCM.TabIndex = 8;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "CalculatorForm";
            Text = "Калькулятор НОД И НОК ";
            tabControl.ResumeLayout(false);
            tabCalc.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabCalc;
        private TabPage tabSteps;
        private TabPage tabVisual;
        private Panel panel1;
        private Label num1Lb;
        private TextBox num2TextBox;
        private TextBox num1TextBox;
        private Label num2Lb;
        private Button btnCalcGCDLCM;
        private Label resultGCD;
        private Label LCMLabel;
        private Label GCDLabel;
        private Label resultLCM;
    }
}
