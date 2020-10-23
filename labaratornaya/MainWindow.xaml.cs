Gu﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labaratornaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n;
            n = int.Parse(Vvod.Text);

            int result = n % 10; //Получаем последнюю цифру числа, от которой зависит форма слова "копейка"
            if (n >= 20 || n < 10) // Числа от 11 до 19 включительно, попадют в else. Поэтому >= 20
            {
                switch (result)
                {
                    case 0:
                        Result.Text = ($"{n} копеек");
                        break;
                    case 5:
                        Result.Text = ($"{n} копеек");
                        break;
                    case 6:
                        Result.Text = ($"{n} копеек");
                        break;
                    case 7:
                        Result.Text = ($"{n} копеек");
                        break;
                    case 8:
                        Result.Text = ($"{n} копеек");
                        break;
                    case 9:
                        Result.Text = ($"{n} копеек");
                        break;
                    case 1:
                        Result.Text = ($"{n} копейка");
                        break;
                    case 2:
                        Result.Text = ($"{n} копейки");
                        break;
                    case 3:
                        Result.Text = ($"{n} копейки");
                        break;
                    case 4:
                        Result.Text = ($"{n} копейки");
                        break;

                }
            }
            else
            {
                Result.Text = ($"{n} копеек");
            }
            }

        }
    }
