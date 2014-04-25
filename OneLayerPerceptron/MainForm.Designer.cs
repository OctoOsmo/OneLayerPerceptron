namespace OneLayerPerceptron
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.trackBarBrushSize = new System.Windows.Forms.TrackBar();
            this.buttonAddToSample = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            this.pictureBoxInput.Click += new System.EventHandler(this.pictureBoxInput_Click);
            this.pictureBoxInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInput_MouseDown);
            this.pictureBoxInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInput_MouseMove);
            this.pictureBoxInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInput_MouseUp);
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(352, 47);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(75, 23);
            this.buttonTrain.TabIndex = 1;
            this.buttonTrain.Text = "Обучить";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(352, 90);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Очистить изображение";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // trackBarBrushSize
            // 
            this.trackBarBrushSize.Location = new System.Drawing.Point(12, 318);
            this.trackBarBrushSize.Name = "trackBarBrushSize";
            this.trackBarBrushSize.Size = new System.Drawing.Size(300, 45);
            this.trackBarBrushSize.TabIndex = 3;
            // 
            // buttonAddToSample
            // 
            this.buttonAddToSample.Location = new System.Drawing.Point(352, 131);
            this.buttonAddToSample.Name = "buttonAddToSample";
            this.buttonAddToSample.Size = new System.Drawing.Size(75, 55);
            this.buttonAddToSample.TabIndex = 4;
            this.buttonAddToSample.Text = "Добавить в обучающую выборку";
            this.buttonAddToSample.UseVisualStyleBackColor = true;
            this.buttonAddToSample.Click += new System.EventHandler(this.buttonAddToSample_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 372);
            this.Controls.Add(this.buttonAddToSample);
            this.Controls.Add(this.trackBarBrushSize);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonTrain);
            this.Controls.Add(this.pictureBoxInput);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInput;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.TrackBar trackBarBrushSize;
        private System.Windows.Forms.Button buttonAddToSample;
    }
}

