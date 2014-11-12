using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<List<int>> matrica = new List<List<int>>();
            List<string> lines;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            Stream myStream = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myStream = openFileDialog1.OpenFile();
                using (StreamReader sr = new StreamReader(myStream))
                    try
                    {
                        List<int[]> existIndex = new List<int[]>();
                        var text = sr.ReadToEnd().Replace("\r", "");
                        lines = text.Split('\n').ToList();
                        for (int i = 0; i < lines.Count; i++)
                        {
                            matrica.Add(new List<int>());
                            string[] number = lines[i].Split(' ');
                            foreach (var numb in number)
                            {
                                matrica[i].Add(Int32.Parse(numb));
                            }
                            existIndex.Add(new int[matrica[i].Count]);
                        }
                        int width = matrica[0].Count;
                        int height = matrica.Count;
                        int n = 2;
                        int m = 2;
                        int currentN = 0;
                        int currentM = 0;
                        try
                        {
                            n = Int32.Parse(textBox3.Text);
                            m = Int32.Parse(textBox4.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Вы не ввели параметры ");
                        }
                        foreach (var line in existIndex)
                        {
                            for (int i = 0; i < line.Length; i++)
                            {
                                line[i] = -1;
                            }
                        }
                        bool flagM = true;
                        bool flagN = true;
                        List<int> array = new List<int>();
                        //int countM = 0;
                        //int countN = 0;
                        array.Add(matrica[currentM][currentN]);

                        while (currentM + m + 1 <= height)
                        {
                            int initM = currentM;
                            do
                            {
                                for (int i = 0; i < m; i++)
                                {
                                    currentM = flagM ? currentM + 1 : currentM - 1;
                                    array.Add(matrica[currentM][currentN]);
                                    existIndex[currentM][currentN] = 1;
                                }
                                if (flagN)
                                {
                                    if (currentM == initM + m && currentN + n >= width - 1)
                                    {
                                        currentM++;
                                        if (currentM + m + 1 < height)
                                        {
                                            array.Add(matrica[currentM][currentN]);
                                            existIndex[currentM][currentN] = 1;
                                        }
                                        break;
                                    }
                                    //if (currentM == initM && currentN + n * 2 >= width - 1)
                                    //{
                                    //    currentM++;
                                    //    if (currentM + m + 1 < height)
                                    //        array.Add(matrica[currentM][currentN]);
                                    //    break;
                                    //}
                                }
                                else
                                {
                                    if (currentM == initM + m && currentN - n < 0)
                                    {
                                        currentM++;
                                        if (currentM + m + 1 < height)
                                        {
                                            array.Add(matrica[currentM][currentN]);
                                            existIndex[currentM][currentN] = 1;
                                        }
                                        break;
                                    }
                                }
                                flagM = !flagM;
                                for (int i = 0; i < n; i++)
                                {
                                    currentN = flagN ? currentN + 1 : currentN - 1;
                                    //currentN++;
                                    array.Add(matrica[currentM][currentN]);
                                    existIndex[currentM][currentN] = 1;
                                }
                            }
                            while (true);
                            flagN = !flagN;

                        }
                        textBox1.Text = "";
                        textBox2.Text = "";
                        foreach (var line in matrica)
                        {
                            foreach (var element in line)
                            {
                                textBox1.Text += element.ToString() + " ";
                            }
                            textBox1.Text += "\r\n";
                        }
                        foreach (var element in array)
                        {
                            textBox2.Text += element.ToString() + " ";
                        }
                        for (int i = 0; i < matrica.Count; i++)
                        {
                            for (int j = 0; j < matrica[i].Count; j++)
                            {
                                if (existIndex[i][j] == -1)
                                {
                                    textBox2.Text += matrica[i][j].ToString() + " ";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
