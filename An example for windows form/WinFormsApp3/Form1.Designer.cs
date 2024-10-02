namespace WinFormsApp3
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
            buttonDraw = new Button();
            buttonRotate = new Button();
            buttonRandomize = new Button();
            listBoxEdgeCoordinates = new ListBox();
            textBoxNumberOfEdges = new TextBox();
            textBoxRotationAngle = new TextBox();
            textBoxLength = new TextBox();
            textBoxCenterY = new TextBox();
            textBoxCenterX = new TextBox();
            pictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(38, 328);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(94, 29);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "buttonDraw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // buttonRotate
            // 
            buttonRotate.Location = new Point(38, 363);
            buttonRotate.Name = "buttonRotate";
            buttonRotate.Size = new Size(94, 29);
            buttonRotate.TabIndex = 1;
            buttonRotate.Text = "buttonRotate";
            buttonRotate.UseVisualStyleBackColor = true;
            buttonRotate.Click += buttonRotate_Click;
            // 
            // buttonRandomize
            // 
            buttonRandomize.Location = new Point(43, 398);
            buttonRandomize.Name = "buttonRandomize";
            buttonRandomize.Size = new Size(94, 29);
            buttonRandomize.TabIndex = 2;
            buttonRandomize.Text = "buttonRandomize";
            buttonRandomize.UseVisualStyleBackColor = true;
            buttonRandomize.Click += buttonRandomize_Click;
            // 
            // listBoxEdgeCoordinates
            // 
            listBoxEdgeCoordinates.FormattingEnabled = true;
            listBoxEdgeCoordinates.ItemHeight = 20;
            listBoxEdgeCoordinates.Location = new Point(29, 202);
            listBoxEdgeCoordinates.Name = "listBoxEdgeCoordinates";
            listBoxEdgeCoordinates.Size = new Size(150, 104);
            listBoxEdgeCoordinates.TabIndex = 3;
            // 
            // textBoxNumberOfEdges
            // 
            textBoxNumberOfEdges.Location = new Point(109, 126);
            textBoxNumberOfEdges.Name = "textBoxNumberOfEdges";
            textBoxNumberOfEdges.Size = new Size(125, 27);
            textBoxNumberOfEdges.TabIndex = 4;
            // 
            // textBoxRotationAngle
            // 
            textBoxRotationAngle.Location = new Point(109, 159);
            textBoxRotationAngle.Name = "textBoxRotationAngle";
            textBoxRotationAngle.Size = new Size(125, 27);
            textBoxRotationAngle.TabIndex = 5;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(109, 93);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(125, 27);
            textBoxLength.TabIndex = 6;
            // 
            // textBoxCenterY
            // 
            textBoxCenterY.Location = new Point(109, 57);
            textBoxCenterY.Name = "textBoxCenterY";
            textBoxCenterY.Size = new Size(125, 27);
            textBoxCenterY.TabIndex = 7;
            // 
            // textBoxCenterX
            // 
            textBoxCenterX.Location = new Point(109, 21);
            textBoxCenterX.Name = "textBoxCenterX";
            textBoxCenterX.Size = new Size(125, 27);
            textBoxCenterX.TabIndex = 8;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(240, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(548, 426);
            pictureBox.TabIndex = 9;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 64);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 10;
            label1.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "LENGHT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 133);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 12;
            label3.Text = "EDGES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 166);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 13;
            label4.Text = "ANGLE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 28);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 14;
            label5.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Controls.Add(textBoxCenterX);
            Controls.Add(textBoxCenterY);
            Controls.Add(textBoxLength);
            Controls.Add(textBoxRotationAngle);
            Controls.Add(textBoxNumberOfEdges);
            Controls.Add(listBoxEdgeCoordinates);
            Controls.Add(buttonRandomize);
            Controls.Add(buttonRotate);
            Controls.Add(buttonDraw);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDraw;
        private Button buttonRotate;
        private Button buttonRandomize;
        private ListBox listBoxEdgeCoordinates;
        private TextBox textBoxNumberOfEdges;
        private TextBox textBoxRotationAngle;
        private TextBox textBoxLength;
        private TextBox textBoxCenterY;
        private TextBox textBoxCenterX;
        private PictureBox pictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}