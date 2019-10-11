namespace Seminar2809
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtxViz1 = new System.Windows.Forms.DataGridView();
            this.rowsCount1 = new System.Windows.Forms.NumericUpDown();
            this.columnsCount1 = new System.Windows.Forms.NumericUpDown();
            this.columnsCount2 = new System.Windows.Forms.NumericUpDown();
            this.rowsCount2 = new System.Windows.Forms.NumericUpDown();
            this.getResultBtn = new System.Windows.Forms.Button();
            this.mtxViz2 = new System.Windows.Forms.DataGridView();
            this.mtxVizRes = new System.Windows.Forms.DataGridView();
            this.plusBtn = new System.Windows.Forms.Button();
            this.umnogBtn = new System.Windows.Forms.Button();
            this.transpBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mtxViz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsCount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxViz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxVizRes)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxViz1
            // 
            this.mtxViz1.AllowUserToAddRows = false;
            this.mtxViz1.AllowUserToDeleteRows = false;
            this.mtxViz1.AllowUserToResizeColumns = false;
            this.mtxViz1.AllowUserToResizeRows = false;
            this.mtxViz1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mtxViz1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mtxViz1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mtxViz1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mtxViz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtxViz1.ColumnHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxViz1.DefaultCellStyle = dataGridViewCellStyle7;
            this.mtxViz1.EnableHeadersVisualStyles = false;
            this.mtxViz1.Location = new System.Drawing.Point(12, 53);
            this.mtxViz1.Name = "mtxViz1";
            this.mtxViz1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mtxViz1.RowHeadersVisible = false;
            this.mtxViz1.Size = new System.Drawing.Size(281, 302);
            this.mtxViz1.TabIndex = 3;
            this.mtxViz1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MtxViz1_CellEndEdit);
            // 
            // rowsCount1
            // 
            this.rowsCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsCount1.Location = new System.Drawing.Point(12, 12);
            this.rowsCount1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsCount1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowsCount1.Name = "rowsCount1";
            this.rowsCount1.Size = new System.Drawing.Size(52, 26);
            this.rowsCount1.TabIndex = 5;
            this.rowsCount1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowsCount1.ValueChanged += new System.EventHandler(this.RowsCount1_ValueChanged);
            // 
            // columnsCount1
            // 
            this.columnsCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsCount1.Location = new System.Drawing.Point(70, 12);
            this.columnsCount1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.columnsCount1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnsCount1.Name = "columnsCount1";
            this.columnsCount1.Size = new System.Drawing.Size(52, 26);
            this.columnsCount1.TabIndex = 6;
            this.columnsCount1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnsCount1.ValueChanged += new System.EventHandler(this.ColumnsCount1_ValueChanged);
            // 
            // columnsCount2
            // 
            this.columnsCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsCount2.Location = new System.Drawing.Point(411, 11);
            this.columnsCount2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.columnsCount2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnsCount2.Name = "columnsCount2";
            this.columnsCount2.Size = new System.Drawing.Size(52, 26);
            this.columnsCount2.TabIndex = 9;
            this.columnsCount2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnsCount2.ValueChanged += new System.EventHandler(this.ColumnsCount2_ValueChanged);
            // 
            // rowsCount2
            // 
            this.rowsCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsCount2.Location = new System.Drawing.Point(353, 11);
            this.rowsCount2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsCount2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowsCount2.Name = "rowsCount2";
            this.rowsCount2.Size = new System.Drawing.Size(52, 26);
            this.rowsCount2.TabIndex = 8;
            this.rowsCount2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowsCount2.ValueChanged += new System.EventHandler(this.RowsCount2_ValueChanged);
            // 
            // getResultBtn
            // 
            this.getResultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getResultBtn.Location = new System.Drawing.Point(640, 162);
            this.getResultBtn.Name = "getResultBtn";
            this.getResultBtn.Size = new System.Drawing.Size(48, 44);
            this.getResultBtn.TabIndex = 11;
            this.getResultBtn.Text = "=";
            this.getResultBtn.UseVisualStyleBackColor = true;
            // 
            // mtxViz2
            // 
            this.mtxViz2.AllowUserToAddRows = false;
            this.mtxViz2.AllowUserToDeleteRows = false;
            this.mtxViz2.AllowUserToResizeColumns = false;
            this.mtxViz2.AllowUserToResizeRows = false;
            this.mtxViz2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mtxViz2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mtxViz2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mtxViz2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mtxViz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtxViz2.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxViz2.DefaultCellStyle = dataGridViewCellStyle8;
            this.mtxViz2.EnableHeadersVisualStyles = false;
            this.mtxViz2.Location = new System.Drawing.Point(353, 53);
            this.mtxViz2.Name = "mtxViz2";
            this.mtxViz2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mtxViz2.RowHeadersVisible = false;
            this.mtxViz2.Size = new System.Drawing.Size(281, 302);
            this.mtxViz2.TabIndex = 14;
            this.mtxViz2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.MtxViz2_CellEndEdit);
            // 
            // mtxVizRes
            // 
            this.mtxVizRes.AllowUserToAddRows = false;
            this.mtxVizRes.AllowUserToDeleteRows = false;
            this.mtxVizRes.AllowUserToResizeColumns = false;
            this.mtxVizRes.AllowUserToResizeRows = false;
            this.mtxVizRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mtxVizRes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mtxVizRes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mtxVizRes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mtxVizRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtxVizRes.ColumnHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxVizRes.DefaultCellStyle = dataGridViewCellStyle9;
            this.mtxVizRes.EnableHeadersVisualStyles = false;
            this.mtxVizRes.Location = new System.Drawing.Point(694, 53);
            this.mtxVizRes.Name = "mtxVizRes";
            this.mtxVizRes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mtxVizRes.RowHeadersVisible = false;
            this.mtxVizRes.Size = new System.Drawing.Size(276, 302);
            this.mtxVizRes.TabIndex = 15;
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(299, 117);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(48, 44);
            this.plusBtn.TabIndex = 16;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // umnogBtn
            // 
            this.umnogBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umnogBtn.Location = new System.Drawing.Point(299, 178);
            this.umnogBtn.Name = "umnogBtn";
            this.umnogBtn.Size = new System.Drawing.Size(48, 44);
            this.umnogBtn.TabIndex = 17;
            this.umnogBtn.Text = "*";
            this.umnogBtn.UseVisualStyleBackColor = true;
            this.umnogBtn.Click += new System.EventHandler(this.UmnogBtn_Click);
            // 
            // transpBtn
            // 
            this.transpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transpBtn.Location = new System.Drawing.Point(694, 9);
            this.transpBtn.Name = "transpBtn";
            this.transpBtn.Size = new System.Drawing.Size(48, 38);
            this.transpBtn.TabIndex = 18;
            this.transpBtn.Text = "T";
            this.transpBtn.UseVisualStyleBackColor = true;
            this.transpBtn.Click += new System.EventHandler(this.TranspBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 370);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transpBtn);
            this.Controls.Add(this.umnogBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.mtxVizRes);
            this.Controls.Add(this.mtxViz2);
            this.Controls.Add(this.getResultBtn);
            this.Controls.Add(this.columnsCount2);
            this.Controls.Add(this.rowsCount2);
            this.Controls.Add(this.columnsCount1);
            this.Controls.Add(this.rowsCount1);
            this.Controls.Add(this.mtxViz1);
            this.Name = "Form1";
            this.Text = "Калькулятор матриц";
            ((System.ComponentModel.ISupportInitialize)(this.mtxViz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsCount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsCount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxViz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxVizRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView mtxViz1;
        private System.Windows.Forms.NumericUpDown rowsCount1;
        private System.Windows.Forms.NumericUpDown columnsCount1;
        private System.Windows.Forms.NumericUpDown columnsCount2;
        private System.Windows.Forms.NumericUpDown rowsCount2;
        private System.Windows.Forms.Button getResultBtn;
        private System.Windows.Forms.DataGridView mtxViz2;
        private System.Windows.Forms.DataGridView mtxVizRes;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button umnogBtn;
        private System.Windows.Forms.Button transpBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

