namespace WF_DZ1
{
    partial class MainForm
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
            closeBtn = new Button();
            randomPosBtn = new Button();
            randomPosForm = new Button();
            colorBtn = new Button();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(144, 471);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(228, 95);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "закрыть";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // randomPosBtn
            // 
            randomPosBtn.Location = new Point(463, 471);
            randomPosBtn.Name = "randomPosBtn";
            randomPosBtn.Size = new Size(228, 95);
            randomPosBtn.TabIndex = 1;
            randomPosBtn.Text = "переместить кнопку";
            randomPosBtn.UseVisualStyleBackColor = true;
            randomPosBtn.Click += randomPosBtn_Click;
            // 
            // randomPosForm
            // 
            randomPosForm.Location = new Point(782, 471);
            randomPosForm.Name = "randomPosForm";
            randomPosForm.Size = new Size(228, 95);
            randomPosForm.TabIndex = 2;
            randomPosForm.Text = "переместить форму";
            randomPosForm.UseVisualStyleBackColor = true;
            randomPosForm.Click += randomPosForm_Click;
            // 
            // colorBtn
            // 
            colorBtn.Location = new Point(1134, 471);
            colorBtn.Name = "colorBtn";
            colorBtn.Size = new Size(228, 95);
            colorBtn.TabIndex = 3;
            colorBtn.Text = "другой цвет";
            colorBtn.UseVisualStyleBackColor = true;
            colorBtn.Click += colorBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 645);
            Controls.Add(colorBtn);
            Controls.Add(randomPosForm);
            Controls.Add(randomPosBtn);
            Controls.Add(closeBtn);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button closeBtn;
        private Button randomPosBtn;
        private Button randomPosForm;
        private Button colorBtn;
    }
}
