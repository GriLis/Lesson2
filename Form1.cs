using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar2809
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BuildMtx(1, Convert.ToInt32(rowsCount1.Value), Convert.ToInt32(columnsCount1.Value));
            BuildMtx(2, Convert.ToInt32(rowsCount2.Value), Convert.ToInt32(columnsCount2.Value));
        }

        enum Operation
        {
            Summ,
            Umnog,
            Transp
        }

        MyMatrix matrx1, matrx2, mres;

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (rowsCount1.Value == rowsCount2.Value && columnsCount1.Value == columnsCount2.Value)
                GetResult(Operation.Summ);
        }

        private void UmnogBtn_Click(object sender, EventArgs e)
        {
            if (columnsCount1.Value == rowsCount2.Value)
                GetResult(Operation.Umnog);
        }

        private void TranspBtn_Click(object sender, EventArgs e)
        {
            GetResult(Operation.Transp);
        }

        private void RowsCount1_ValueChanged(object sender, EventArgs e)
        {
            BuildMtx(1, Convert.ToInt32(rowsCount1.Value), Convert.ToInt32(columnsCount1.Value));
        }

        private void ColumnsCount1_ValueChanged(object sender, EventArgs e)
        {
            BuildMtx(1, Convert.ToInt32(rowsCount1.Value), Convert.ToInt32(columnsCount1.Value));
        }

        private void RowsCount2_ValueChanged(object sender, EventArgs e)
        {
            BuildMtx(2, Convert.ToInt32(rowsCount2.Value), Convert.ToInt32(columnsCount2.Value));
        }

        private void ColumnsCount2_ValueChanged(object sender, EventArgs e)
        {
            BuildMtx(2, Convert.ToInt32(rowsCount2.Value), Convert.ToInt32(columnsCount2.Value));
        }

        private void MtxViz1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ReadMtx(1);
        }

        private void MtxViz2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ReadMtx(2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BuildMtx(1, Convert.ToInt32(rowsCount1.Value), Convert.ToInt32(columnsCount1.Value));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            BuildMtx(2, Convert.ToInt32(rowsCount2.Value), Convert.ToInt32(columnsCount2.Value));
        }

        void BuildMtx(int id, int rows, int columns)
        {
            Random rnd = new Random();

            switch (id)
            {
                case 1:

                    mtxViz1.RowCount = rows;
                    mtxViz1.ColumnCount = columns;

                    matrx1 = new MyMatrix(rows, columns);

                    for (int i = 0; i < matrx1.matrix.GetLength(0); i++)
                        for (int j = 0; j < matrx1.matrix.GetLength(1); j++)
                        {
                            matrx1.matrix[i, j] = rnd.Next(0, 10);
                            mtxViz1.Rows[i].Cells[j].Value = matrx1.matrix[i, j];
                        }

                    break;

                case 2:

                    mtxViz2.RowCount = rows;
                    mtxViz2.ColumnCount = columns;

                    matrx2 = new MyMatrix(rows, columns);

                    for (int i = 0; i < matrx2.matrix.GetLength(0); i++)
                        for (int j = 0; j < matrx2.matrix.GetLength(1); j++)
                        {
                            matrx2.matrix[i, j] = rnd.Next(0, 10);
                            mtxViz2.Rows[i].Cells[j].Value = matrx2.matrix[i, j];
                        }

                    break;
            }
        }

        void ReadMtx(int id)
        {
            switch (id)
            {
                case 1:

                    for (int i = 0; i < matrx1.matrix.GetLength(0); i++)
                        for (int j = 0; j < matrx1.matrix.GetLength(1); j++)
                            matrx1.matrix[i, j] = Convert.ToInt32(mtxViz1.Rows[i].Cells[j].Value);

                    break;

                case 2:

                    for (int i = 0; i < matrx2.matrix.GetLength(0); i++)
                        for (int j = 0; j < matrx2.matrix.GetLength(1); j++)
                            matrx2.matrix[i, j] = Convert.ToInt32(mtxViz2.Rows[i].Cells[j].Value);

                    break;

                case 3:

                    for (int i = 0; i < mres.matrix.GetLength(0); i++)
                        for (int j = 0; j < mres.matrix.GetLength(1); j++)
                            mres.matrix[i, j] = Convert.ToInt32(mtxVizRes.Rows[i].Cells[j].Value);

                    break;
            }
        }

        void GetResult(Operation oper)
        {
            switch (oper)
            {
                case Operation.Summ:

                    mres = matrx1 + matrx2;

                    mtxVizRes.RowCount = Convert.ToInt32(rowsCount2.Value);
                    mtxVizRes.ColumnCount = Convert.ToInt32(columnsCount2.Value);

                    for (int i = 0; i < mres.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < mres.matrix.GetLength(1); j++)
                        {
                            mtxVizRes.Rows[i].Cells[j].Value = mres.matrix[i, j];
                        }
                    }

                    break;

                case Operation.Umnog:

                    mres = matrx1 * matrx2;

                    mtxVizRes.RowCount = Convert.ToInt32(rowsCount1.Value);
                    mtxVizRes.ColumnCount = Convert.ToInt32(columnsCount2.Value);

                    for (int i = 0; i < mres.matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < mres.matrix.GetLength(1); j++)
                        {
                            mtxVizRes.Rows[i].Cells[j].Value = mres.matrix[i, j];
                        }
                    }

                    break;

                case Operation.Transp:

                    ReadMtx(3);
                    mres = !mres;

                    mtxVizRes.RowCount = Convert.ToInt32(mres.matrix.GetLength(0));
                    mtxVizRes.ColumnCount = Convert.ToInt32(mres.matrix.GetLength(1));

                    for (int i = 0; i < mres.matrix.GetLength(0); i++)
                        for (int j = 0; j < mres.matrix.GetLength(1); j++)
                            mtxVizRes.Rows[i].Cells[j].Value = mres.matrix[i, j];

                    break;
            }
        }
    }
}
