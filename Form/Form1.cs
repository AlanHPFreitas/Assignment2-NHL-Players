using System;
using System.Windows.Forms;
using Assignment2_NHL_Players.Controllers;
using Assignment2_NHL_Players.Services;
using Assignment2_NHL_Players.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Linq.Dynamic.Core;

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
            dgvPlayerStats.AutoGenerateColumns = true;  // Essa parte vai gerar colunas baseadas nos dados
            dgvPlayerStats.AllowUserToAddRows = false;  // Aqui vai impedir que os usuàrios venham a adicionar colunas.
            dgvPlayerStats.AllowUserToDeleteRows = false;  // Não permite que os usuários  excluam colunas
            dgvPlayerStats.ReadOnly = true;  // Faz com que o  DataGridView (o que eu usei para mostrar a imagem da tabela) seja somente para leitura
            dgvPlayerStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Seleciona somente linhas completas
            dgvPlayerStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // Seleciona somente colunas completas
        }


        //private void UpdateDataGridView()
        //{
        //    string filter = TxtFilter.Text; // Aqui é onde obtemos o texto do filtro
        //    string sort = TxtSort.Text; // Aqui é onde obtemos o texto da ordenação
        //    string filePath = @"..\..\data\NHL Player Stats 2017-18.csv";
        //    var playerService = new PlayerService();
        //    var listPlayerStats = playerService.LoadPlayerStats(filePath);

        //    // Aqui é onde é ordena a lista de jogadores com base na entrada
        //    var filteredAndSortedData = ApplyFilterAndSort(listPlayerStats, filter, sort);

        //    // Atualiza o DataGridView com os dados filtrados e ordenados
        //    dgvPlayerStats.DataSource = filteredAndSortedData;
        //}

        private IEnumerable<PlayerStats> ApplyFilterAndSort(IEnumerable<PlayerStats> playerStats, string filter, string sort)
        {
            var query = playerStats.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                // Converte o filtro para o formato esperado
                var conditions = filter.Split(',')
                                       .Select(cond => cond.Trim())
                                       .ToArray();
                // Constrói a string do filtro combinada
                string combinedFilter = string.Join(" AND ", conditions);

                // Aplica o filtro dinâmico ao IQueryable
                query = query.Where(combinedFilter);
            }

            if (!string.IsNullOrWhiteSpace(sort))
            {
                // Remove espaços em branco e interpreta múltiplos campos de ordenação
                var sortExpressions = sort.Split(',')
                                          .Select(s => s.Trim())
                                          .ToArray();

                // Combina as expressões de ordenação em uma única string para Dynamic LINQ
                string combinedSort = string.Join(", ", sortExpressions);

                // Aplica a ordenação dinâmica ao IQueryable
                query = query.OrderBy(combinedSort);
            }

            //Aplica o filtro
            //    if (!string.IsNullOrWhiteSpace(filter))
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("button changed");
            //UpdateDataGridView();
            LoadData();
        }

    }
}

