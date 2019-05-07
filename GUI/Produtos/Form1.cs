using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Produtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class SendId
        {
            public string id { get; set; }

            public SendId(string id)
            {
                this.id = id;
            }
        }

        // POST
        private void PostarDados(Produto p)
        {
            var client = new RestClient(@"http://localhost:3000/products");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            string json = JsonConvert.SerializeObject(p);
            request.AddJsonBody(json);
            client.Execute(request);
        }

        // GET
        private void GetDados()
        {
            var client = new RestClient(@"http://localhost:3000/products");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);

            IList<Produto> produtos = JsonConvert.DeserializeObject<IList<Produto>>(response.Content);
            foreach (var produto in produtos)
            {
                txtPrincipal.AppendText($"[{produto.id}] | {produto.name} | R${produto.price} | {produto.description}\n");
            }

        }

        // DELETE
        private void Remove(string id)
        {
            var client = new RestClient(@"http://localhost:3000/products");
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            string json = JsonConvert.SerializeObject(new SendId(id));
            request.AddJsonBody(json);
            client.Execute(request);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtNome.Text, txtValor.Text, txtDesc.Text);
            PostarDados(produto);
            txtPrincipal.Clear();
            GetDados();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            txtPrincipal.Clear();
            GetDados();
        }

        private void btmRemover_Click(object sender, EventArgs e)
        {
            Remove(txtId.Text);
            txtPrincipal.Clear();
            GetDados();
        }
    }
}
