﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{ /// <summary>
/// создание формы
/// </summary>
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        string[] files, paths;

        /// <summary>
        ///    обрабочик кнопки выбора файла
        /// </summary>
      
        private void button1_Click(object sender, EventArgs e)
          

        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {

                files = openFileDialog1.SafeFileNames;

                paths = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++)

                {
                    listBox1.Items.Add(files[i]);
                }

            }

        }
        /// <summary>
        /// обработчик вывода списка воспроизведения
        /// </summary>
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        

        {

            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];

        }
    }
}
