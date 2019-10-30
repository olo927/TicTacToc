﻿using System;
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

namespace TTT
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int SIZE = 9;
        Button[,] buttons = new Button[SIZE,SIZE];
        bool[] tabOfNextMove = { true, true, true, true, true, true, true, true, true };
        bool isXTurn = true;
        SolidColorBrush white, red;
        public MainWindow()
        {
            InitializeComponent();
            white = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));
            red = new SolidColorBrush(System.Windows.Media.Color.FromRgb(249, 182, 182));
        }

        private void twoPlayerStartButton_Click(object sender, RoutedEventArgs e)
        {
            SetButtonsTable();
            TwoPlayerGameStart();
        }

        private void SetButtonsTable()
        {
            buttons[0,0] = b00;
            buttons[0,1] = b01; 
            buttons[0,2] = b02;
            buttons[0,3] = b03;
            buttons[0,4] = b04;
            buttons[0,5] = b05;
            buttons[0,6] = b06;
            buttons[0,7] = b07;
            buttons[0,8] = b08;
            //
            buttons[1,0] = b10;
            buttons[1,1] = b11;
            buttons[1,2] = b12;
            buttons[1,3] = b13;
            buttons[1,4] = b14;
            buttons[1,5] = b15;
            buttons[1,6] = b16;
            buttons[1,7] = b17;
            buttons[1,8] = b18;
            //
            buttons[2,0] = b20;
            buttons[2,1] = b21;
            buttons[2,2] = b22;
            buttons[2,3] = b23;
            buttons[2,4] = b24;
            buttons[2,5] = b25;
            buttons[2,6] = b26;
            buttons[2,7] = b27;
            buttons[2,8] = b28;
            //
            buttons[3,0] = b30;
            buttons[3,1] = b31;
            buttons[3,2] = b32;
            buttons[3,3] = b33;
            buttons[3,4] = b34;
            buttons[3,5] = b35;
            buttons[3,6] = b36;
            buttons[3,7] = b37;
            buttons[3,8] = b38;
            //
            buttons[4,0] = b40;
            buttons[4,1] = b41;
            buttons[4,2] = b42;
            buttons[4,3] = b43;
            buttons[4,4] = b44;
            buttons[4,5] = b45;
            buttons[4,6] = b46;
            buttons[4,7] = b47;
            buttons[4,8] = b48;
            //
            buttons[5,0] = b50;
            buttons[5,1] = b51;
            buttons[5,2] = b52;
            buttons[5,3] = b53;
            buttons[5,4] = b54;
            buttons[5,5] = b55;
            buttons[5,6] = b56;
            buttons[5,7] = b57;
            buttons[5,8] = b58;
            //
            buttons[6,0] = b60;
            buttons[6,1] = b61;
            buttons[6,2] = b62;
            buttons[6,3] = b63;
            buttons[6,4] = b64;
            buttons[6,5] = b65;
            buttons[6,6] = b66;
            buttons[6,7] = b67;
            buttons[6,8] = b68;
            //
            buttons[7,0] = b70;
            buttons[7,1] = b71;
            buttons[7,2] = b72;
            buttons[7,3] = b73;
            buttons[7,4] = b74;
            buttons[7,5] = b75;
            buttons[7,6] = b76;
            buttons[7,7] = b77;
            buttons[7,8] = b78;
            //
            buttons[8,0] = b80;
            buttons[8,1] = b81;
            buttons[8,2] = b82;
            buttons[8,3] = b83;
            buttons[8,4] = b84;
            buttons[8,5] = b85;
            buttons[8,6] = b86;
            buttons[8,7] = b87;
            buttons[8,8] = b88;

        }

        private void TwoPlayerGameStart()
        {
            if (isXTurn)
            {
                WhichPlayerTurnLabel.Content = "Tura gracza X";
            }
            else
            {
                WhichPlayerTurnLabel.Content = "Tura gracza O";
            }
            LightButtons(tabOfNextMove, buttons);

            //Tutaj określenie następnego ruchu możliwego czyli na nowo zdefiniować tabele tabOfNextMove

            //DarkButtons(buttons);
        }

        private void DarkButtons(Button[,] buttons)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    buttons[i, j].Background = white;
                }
            }
        } //done

        private void LightButtons(bool[] tabOfNextMove, Button[,] buttons)
        {
            for(int i = 0; i<SIZE; i++)
            { 
                if (tabOfNextMove[i])
                {
                    for(int j = 0; j<SIZE;j++)
                    {
                        buttons[i,j].Background = red;
                    }
                }
                
            }
        }  //Done

        private void SetSign_Click(object sender, RoutedEventArgs e)
        {
            int big, small;
            if(Int32.TryParse(Big.Text,out big) && Int32.TryParse(Small.Text, out small) && big>=1 && big<=9 && small >= 1 && small <= 9)
            {
                big--;
                small--;
                if (tabOfNextMove[big])
                {
                    if (buttons[big,small].Content.Equals(null))  //warunek do poprawy
                    {
                        MessageBox.Show(buttons[big, small].Content.ToString());
                    }
                    else
                    {
                        MessageBox.Show("źle");
                    }
                }
                else
                {
                    MessageBox.Show("podałeś niemożliwy do wykonania ruch, złą małą planszę wybrałeś");
                }
            }
            //dopisać elsa o złym parsowaniu możliwe że wpisałeś litere


        }


    }
}
