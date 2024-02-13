namespace data_grid_view_checkbox_color
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
            dataGridView = new DataGridView();
            tableLayoutPanelRadios = new TableLayoutPanel();
            radioYellow = new RadioButton();
            radioDefault = new RadioButton();
            radioNone = new RadioButton();
            labelSelectionColor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tableLayoutPanelRadios.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.Azure;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 6);
            dataGridView.Margin = new Padding(4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(466, 195);
            dataGridView.TabIndex = 0;
            // 
            // tableLayoutPanelRadios
            // 
            tableLayoutPanelRadios.ColumnCount = 4;
            tableLayoutPanelRadios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.782608F));
            tableLayoutPanelRadios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.73913F));
            tableLayoutPanelRadios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.73913F));
            tableLayoutPanelRadios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.73913F));
            tableLayoutPanelRadios.Controls.Add(radioYellow, 3, 0);
            tableLayoutPanelRadios.Controls.Add(radioDefault, 2, 0);
            tableLayoutPanelRadios.Controls.Add(radioNone, 1, 0);
            tableLayoutPanelRadios.Controls.Add(labelSelectionColor, 0, 0);
            tableLayoutPanelRadios.Dock = DockStyle.Bottom;
            tableLayoutPanelRadios.Location = new Point(6, 207);
            tableLayoutPanelRadios.Name = "tableLayoutPanelRadios";
            tableLayoutPanelRadios.RowCount = 1;
            tableLayoutPanelRadios.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelRadios.Size = new Size(466, 31);
            tableLayoutPanelRadios.TabIndex = 1;
            // 
            // radioYellow
            // 
            radioYellow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioYellow.AutoSize = true;
            radioYellow.Font = new Font("Segoe UI", 8F);
            radioYellow.Location = new Point(367, 3);
            radioYellow.Name = "radioYellow";
            radioYellow.Size = new Size(96, 25);
            radioYellow.TabIndex = 0;
            radioYellow.Text = "Yellow";
            radioYellow.UseVisualStyleBackColor = true;
            // 
            // radioDefault
            // 
            radioDefault.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioDefault.AutoSize = true;
            radioDefault.Font = new Font("Segoe UI", 8F);
            radioDefault.Location = new Point(266, 3);
            radioDefault.Name = "radioDefault";
            radioDefault.Size = new Size(95, 25);
            radioDefault.TabIndex = 0;
            radioDefault.Text = "Default";
            radioDefault.UseVisualStyleBackColor = true;
            // 
            // radioNone
            // 
            radioNone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioNone.AutoSize = true;
            radioNone.Checked = true;
            radioNone.Font = new Font("Segoe UI", 8F);
            radioNone.Location = new Point(165, 3);
            radioNone.Name = "radioNone";
            radioNone.Size = new Size(95, 25);
            radioNone.TabIndex = 0;
            radioNone.TabStop = true;
            radioNone.Text = "None";
            radioNone.UseVisualStyleBackColor = true;
            // 
            // labelSelectionColor
            // 
            labelSelectionColor.AutoSize = true;
            labelSelectionColor.Font = new Font("Segoe UI", 10F);
            labelSelectionColor.Location = new Point(3, 0);
            labelSelectionColor.Name = "labelSelectionColor";
            labelSelectionColor.Size = new Size(145, 28);
            labelSelectionColor.TabIndex = 1;
            labelSelectionColor.Text = "Selection Color";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(tableLayoutPanelRadios);
            Controls.Add(dataGridView);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "MainForm";
            Padding = new Padding(6);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tableLayoutPanelRadios.ResumeLayout(false);
            tableLayoutPanelRadios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private TableLayoutPanel tableLayoutPanelRadios;
        private RadioButton radioNone;
        private RadioButton radioDefault;
        private RadioButton radioYellow;
        private Label labelSelectionColor;
    }
}
