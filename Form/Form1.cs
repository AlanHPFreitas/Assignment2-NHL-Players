using System;
using System.Windows.Forms;
using Assignment2_NHL_Players.Controllers;
using Assignment2_NHL_Players.Services;
using Assignment2_NHL_Players.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Assignment2_NHL_Players.Forms
{
    public partial class Form1 : Form
    {
        private readonly AppController _controller;
        private BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            _controller = new AppController(@"..\..\data\NHL Player Stats 2017-18.csv");
            
            LoadDataStart();

            //string filePath = @"..\..\data\NHL Player Stats 2017-18.csv"; // ou seu caminho
            //string cwd = System.IO.Directory.GetCurrentDirectory();
            //if (!File.Exists(filePath))
            //{
            //    MessageBox.Show("O arquivo não foi encontrado: " + filePath);
            //    MessageBox.Show("cwd: " + cwd);
            //}
            //else
            //{
            //    MessageBox.Show("O arquivo  foi encontrado: " + filePath);
            //    MessageBox.Show("cwd: " + cwd);

            //}



        }

        private void LoadDataStart()
        {
            var players = _controller.GetFilteredAndSortedPlayers("","");

          

            dgvPlayerStats.DataSource = players;

           
        }


        private void LoadData()
        {
            var players = _controller.GetFilteredAndSortedPlayers(TxtFilter.Text, TxtSort.Text);

            foreach (PlayerStats p in players)
            {
                bindingSource1.Add(p);
            }

            dgvPlayerStats.DataSource = players;

           
        }

        //private void BbtnUpdate_Click(object sender, EventArgs e)
        //{
        //    LoadData();
        //}

        //private void TxtFilter_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter) LoadData();
        //}

        //private void TxtSort_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter) LoadData();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

            string filePath = @"..\..\data\NHL Player Stats 2017-18.csv"; 
            var playerService = new PlayerService();
            var listPlayerStats = playerService.LoadPlayerStats(filePath);

           

            dgvPlayerStats.DataSource = listPlayerStats;
        }



        private void InitializeDataGridView()
        {
            dgvPlayerStats.AutoGenerateColumns = true;  // Automatically generate columns based on data
            dgvPlayerStats.AllowUserToAddRows = false;  // Prevent users from adding rows
            dgvPlayerStats.AllowUserToDeleteRows = false;  // Prevent users from deleting rows
            dgvPlayerStats.ReadOnly = true;  // Make the DataGridView read-only
            dgvPlayerStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Select full rows only
            dgvPlayerStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Fill the columns to fit the control
        }

        private void TxtSort_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(); // Chama o método para atualizar o DataGridView quando o texto de ordenação muda
        }

        private void TxtFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGridView(); // Chama o método para atualizar o DataGridView quando o texto de filtro muda
        }

        private void UpdateDataGridView()
        {
            string filter = TxtFilter.Text; // Obtém o texto do filtro
            string sort = TxtSort.Text; // Obtém o texto da ordenação
            string filePath = @"..\..\data\NHL Player Stats 2017-18.csv";
            var playerService = new PlayerService();
            var listPlayerStats = playerService.LoadPlayerStats(filePath);

            // Filtra e ordena a lista de jogadores com base na entrada
            var filteredAndSortedData = ApplyFilterAndSort(listPlayerStats, filter, sort);

            // Atualiza o DataGridView com os dados filtrados e ordenados
            dgvPlayerStats.DataSource = filteredAndSortedData;
        }

        private IEnumerable<PlayerStats> ApplyFilterAndSort(IEnumerable<PlayerStats> playerStats, string filter, string sort)
        {
            var query = playerStats.AsQueryable();

            // Aplica o filtro
            //if (!string.IsNullOrWhiteSpace(filter))
            //{
            //    // Aqui você deve implementar a lógica para interpretar e aplicar o filtro
            //    // Isso pode incluir parsing do texto de filtro e aplicação de condições
            //    // Exemplo simples:
            //    query = query.Where(p => p.G >= 50); // Isso é um exemplo; você precisará de uma lógica dinâmica para o filtro
            //}

            //// Aplica a ordenação
            //if (!string.IsNullOrWhiteSpace(sort))
            //{
            //    // Aqui você deve implementar a lógica para interpretar e aplicar a ordenação
            //    // Isso pode incluir parsing do texto de ordenação e aplicação de condições
            //    // Exemplo simples:
            //    query = query.OrderBy(p => p.Team); // Isso é um exemplo; você precisará de uma lógica dinâmica para a ordenação
            //}

            return query;
        }

    }
}

