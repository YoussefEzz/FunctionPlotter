namespace FunctionPlotter
{
    partial class FunctionPlotter_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.functiontextBox = new System.Windows.Forms.TextBox();
            this.functionlabel = new System.Windows.Forms.Label();
            this.Plotbutton = new System.Windows.Forms.Button();
            this.mintextBox = new System.Windows.Forms.TextBox();
            this.maxtextBox = new System.Windows.Forms.TextBox();
            this.minlabel = new System.Windows.Forms.Label();
            this.maxlabel = new System.Windows.Forms.Label();
            this.plotchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.functionpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.plotchart)).BeginInit();
            this.functionpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // functiontextBox
            // 
            this.functiontextBox.Location = new System.Drawing.Point(102, 130);
            this.functiontextBox.Name = "functiontextBox";
            this.functiontextBox.Size = new System.Drawing.Size(622, 20);
            this.functiontextBox.TabIndex = 0;
            // 
            // functionlabel
            // 
            this.functionlabel.AutoSize = true;
            this.functionlabel.Location = new System.Drawing.Point(99, 102);
            this.functionlabel.Name = "functionlabel";
            this.functionlabel.Size = new System.Drawing.Size(46, 13);
            this.functionlabel.TabIndex = 1;
            this.functionlabel.Text = "function";
            // 
            // Plotbutton
            // 
            this.Plotbutton.Location = new System.Drawing.Point(332, 170);
            this.Plotbutton.Name = "Plotbutton";
            this.Plotbutton.Size = new System.Drawing.Size(113, 35);
            this.Plotbutton.TabIndex = 2;
            this.Plotbutton.Text = "Plot";
            this.Plotbutton.UseVisualStyleBackColor = true;
            this.Plotbutton.Click += new System.EventHandler(this.Plotbutton_Click);
            // 
            // mintextBox
            // 
            this.mintextBox.Location = new System.Drawing.Point(254, 69);
            this.mintextBox.Name = "mintextBox";
            this.mintextBox.Size = new System.Drawing.Size(100, 20);
            this.mintextBox.TabIndex = 4;
            this.mintextBox.Text = "-10";
            // 
            // maxtextBox
            // 
            this.maxtextBox.Location = new System.Drawing.Point(411, 69);
            this.maxtextBox.Name = "maxtextBox";
            this.maxtextBox.Size = new System.Drawing.Size(100, 20);
            this.maxtextBox.TabIndex = 5;
            this.maxtextBox.Text = "10";
            // 
            // minlabel
            // 
            this.minlabel.AutoSize = true;
            this.minlabel.Location = new System.Drawing.Point(291, 53);
            this.minlabel.Name = "minlabel";
            this.minlabel.Size = new System.Drawing.Size(23, 13);
            this.minlabel.TabIndex = 6;
            this.minlabel.Text = "min";
            // 
            // maxlabel
            // 
            this.maxlabel.AutoSize = true;
            this.maxlabel.Location = new System.Drawing.Point(453, 53);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(27, 13);
            this.maxlabel.TabIndex = 7;
            this.maxlabel.Text = "max";
            // 
            // plotchart
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.Title = "y";
            chartArea1.Name = "ChartArea1";
            this.plotchart.ChartAreas.Add(chartArea1);
            this.plotchart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "function plot";
            legend1.Title = "function";
            this.plotchart.Legends.Add(legend1);
            this.plotchart.Location = new System.Drawing.Point(0, 0);
            this.plotchart.Name = "plotchart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "function plot";
            series1.Name = "Function Series";
            this.plotchart.Series.Add(series1);
            this.plotchart.Size = new System.Drawing.Size(795, 219);
            this.plotchart.TabIndex = 10;
            this.plotchart.Text = "plotchart";
            // 
            // functionpanel
            // 
            this.functionpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionpanel.Controls.Add(this.plotchart);
            this.functionpanel.Location = new System.Drawing.Point(0, 224);
            this.functionpanel.Name = "functionpanel";
            this.functionpanel.Size = new System.Drawing.Size(799, 223);
            this.functionpanel.TabIndex = 11;
            // 
            // FunctionPlotter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.functionpanel);
            this.Controls.Add(this.maxlabel);
            this.Controls.Add(this.minlabel);
            this.Controls.Add(this.maxtextBox);
            this.Controls.Add(this.mintextBox);
            this.Controls.Add(this.Plotbutton);
            this.Controls.Add(this.functionlabel);
            this.Controls.Add(this.functiontextBox);
            this.Name = "FunctionPlotter_Form";
            this.Text = "Function Plotter";
            ((System.ComponentModel.ISupportInitialize)(this.plotchart)).EndInit();
            this.functionpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox functiontextBox;
        private System.Windows.Forms.Label functionlabel;
        private System.Windows.Forms.Button Plotbutton;
        private System.Windows.Forms.TextBox mintextBox;
        private System.Windows.Forms.TextBox maxtextBox;
        private System.Windows.Forms.Label minlabel;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotchart;
        private System.Windows.Forms.Panel functionpanel;
    }
}

