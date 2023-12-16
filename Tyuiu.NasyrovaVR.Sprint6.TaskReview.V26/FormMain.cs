using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NasyrovaVR.Sprint6.TaskReview.V26.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.TaskReview.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        Random rnd = new Random();

        private void buttonInfo_NVR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_NVR_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxN1_NVR.Text) < Convert.ToInt32(textBoxN2_NVR.Text) && Convert.ToInt32(textBoxK_NVR.Text) < Convert.ToInt32(textBoxL_NVR.Text) && Convert.ToInt32(textBoxChoice_NVR.Text) < Convert.ToInt32(textBoxLength_NVR.Text))
            {
                int N = Convert.ToInt32(textBoxLength_NVR.Text);
                int M = Convert.ToInt32(textBoxWidth_NVR.Text);
                int K = Convert.ToInt32(textBoxK_NVR.Text);
                int L = Convert.ToInt32(textBoxL_NVR.Text);
                int R = Convert.ToInt32(textBoxChoice_NVR.Text);
                int n1 = Convert.ToInt32(textBoxN1_NVR.Text);
                int n2 = Convert.ToInt32(textBoxN2_NVR.Text);
                int[,] mrtx = new int[N, M];



                //Заполнение массива mrtx случайными числами в диапазоне от n1 до n2
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        mrtx[i, j] = rnd.Next(n1, n2);
                      
                    }
                }

               

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (mrtx[i, j] < 0)
                        {
                            mrtx[i, j] = mrtx[i, j] * -1;
                        }
                    }
                }

                for (int j = 0; j < M; j++)
                {
                    for (int i = 0; i < N; i = i + 2)
                    {
                        if (j % 2 == 0)
                        {
                            mrtx[i, j] = mrtx[i, j] * -1;
                        }
                        else
                            for (int p = 1; p < N; p = p + 2)
                            {
                                {
                                    mrtx[p, j] = mrtx[p, j] * -1;
                                }
                            }

                    }
                }
                textBoxResult_NVR.Text = Convert.ToString(ds.GetMatrix(mrtx, R, K, L));

                // Установка размеров и заполнение значениями ячеек DataGridViewMain_NVR
                DataGridViewMain_NVR.RowCount = N;
                DataGridViewMain_NVR.ColumnCount = M;

                for (int i = 0; i < N; i++)
                {
                    DataGridViewMain_NVR.Columns[i].Width = 100;
                }

                for (int r = 0; r < N; r++)
                {
                    for (int c = 0; c < M; c++)
                    {
                        DataGridViewMain_NVR.Rows[r].Cells[c].Value = mrtx[r, c];
                    }
                }

            }

            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    
    }
}
        
