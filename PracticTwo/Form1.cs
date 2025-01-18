using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            //Объявляем переменные для передачи данныъ из текстбокса
            double xNew, eNew, aNew, yNew, bNew, vNew, xNewChart1, yNewChart1;
            

            //Обработчик ошибок, если данные введены не правильно выдаст ошибку
            try
            {
                //Тут переменные принимают значения из текстбоксов
                xNew = Convert.ToDouble(x.Text);
                eNew = Convert.ToDouble(eY.Text);
                aNew = Convert.ToDouble(a.Text);
                yNew = Convert.ToDouble(y.Text);
                bNew = Convert.ToDouble(bString.Text);
                vNew = Convert.ToDouble(v.Text);

                //Очищаем первоначальную диаграмму
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[1].Points.Clear();
                this.chart1.Series[2].Points.Clear();

                //Заполняем диаграмму
                for (double i = 0; i <= 3; i++)
                {
                    //Переменные для позиций х и у
                    xNewChart1 = xNew;
                    yNewChart1 = yNew;

                    //Обрабочик трех поколений
                    if (i == 0)
                    {   //1 поколение
                        xNewChart1 = xNew;
                    }
                    if (i == 1)
                    {   
                        
                        yNewChart1 = yNew - 50;
                    }
                    else if (i == 2)
                    {
                        //3 поколение
                        yNewChart1 = yNew - 100;
                    }
                    //Обработчик для рисования линий
                    for (double j = 0; j < 150; j++)
                    {
                        //1 поколение
                        if (i == 0)
                        {
                            this.chart1.Series[0].Points.AddXY(xNewChart1, yNewChart1);
                            xNewChart1 = (eNew - aNew * yNewChart1) * xNewChart1 + xNewChart1;
                            yNewChart1 = (bNew * xNewChart1 - vNew) * yNewChart1 + yNewChart1;
                        }
                        //2 поколение
                        else if (i == 1)
                        {
                            this.chart1.Series[1].Points.AddXY(xNewChart1, yNewChart1);
                            xNewChart1 = (eNew - aNew * yNewChart1) * xNewChart1 + xNewChart1;
                            yNewChart1 = (bNew * xNewChart1 - vNew) * yNewChart1 + yNewChart1;
                        }
                        //3 поколение
                        else if (i == 2)
                        {
                            this.chart1.Series[2].Points.AddXY(xNewChart1, yNewChart1);
                            xNewChart1 = (eNew - aNew * yNewChart1) * xNewChart1 + xNewChart1;
                            yNewChart1 = (bNew * xNewChart1 - vNew) * yNewChart1 + yNewChart1;
                        }
                    }
                }
            

            }
            //Сообщение при ошибке
            catch
            {
                MessageBox.Show("Ошибка данных!!!");
                
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
