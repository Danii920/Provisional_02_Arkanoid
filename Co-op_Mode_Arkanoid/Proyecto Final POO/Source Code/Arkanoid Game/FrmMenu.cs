﻿using System;
using System.Windows.Forms;

namespace Arkanoid_Game
{
    public partial class FrmMenu : Form
    {
        private Menu mainMenu;
        private Scores topScores;
        public FrmMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            mainMenu = new Menu();
            topScores = new Scores();
        }

        private void OnClickToMenuUS(object sender, EventArgs e)
        {
            mainMenu.Hide();
            topScores.Show();
        }

        private void OnClickToScoresUS(object sender, EventArgs e)
        {
            topScores.Hide();
            mainMenu.Show();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Form window = new Form1();
            window.Show();
            Hide();
        }
        
        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            #region Configurando User Controls
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Width = ClientSize.Width;
            mainMenu.Height = ClientSize.Height;
            
            topScores.Dock = DockStyle.Fill;
            topScores.Width = ClientSize.Width;
            topScores.Height = ClientSize.Height;
            
            Controls.Add(mainMenu);
            Controls.Add(topScores);
            #endregion

            //Agregando Events
            mainMenu.MenuButtonCLick += StartGame;
            mainMenu.ShowScoresClick += OnClickToMenuUS;
            mainMenu.ExitGameClick += ExitGame;
            topScores.ScoresButtonCLick += OnClickToScoresUS;
        }
    }
}