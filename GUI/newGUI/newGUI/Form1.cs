using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using System.Windows.Forms;

namespace newGUI
{
    public partial class newGUI : Form
    {
        public newGUI()
        {
            InitializeComponent();
            GetDados();
        }

        // class sendID
        class SendId
        {
            public string id { get; set; }

            public SendId(string id)
            {
                this.id = id;
            }
        }

        // method POST
        private void PostarDados(Produto p)
        {
            try
            {
                var client = new RestClient(@"http://localhost:3000/products");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Accept", "application/json");
                request.RequestFormat = DataFormat.Json;
                string json = JsonConvert.SerializeObject(p);
                request.AddJsonBody(json);
                client.Execute(request);
            }
            catch (Exception e)
            {
                ExibeAlerta(e);
            }
        }

        // method GET
        private void GetDados()
        {
            try
            {
                txtGrid.Text = "";

                var client = new RestClient(@"http://localhost:3000/products");
                var request = new RestRequest(Method.GET);
                request.AddHeader("Accept", "application/json");
                IRestResponse response = client.Execute(request);

                IList<Produto> produtos = JsonConvert.DeserializeObject<IList<Produto>>(response.Content);
                foreach (var produto in produtos)
                {
                    txtGrid.AppendText($"[{produto.id}] | {produto.name} | R${produto.price} | {produto.description}\n");
                }
            }
            catch (Exception e)
            {
                ExibeAlerta(e);
            }
        }

        // method DELETE
        private void Remove(string id)
        {
            try
            {
                var client = new RestClient(@"http://localhost:3000/products");
                var request = new RestRequest(Method.DELETE);
                request.AddHeader("Accept", "application/json");
                request.RequestFormat = DataFormat.Json;

                string json = JsonConvert.SerializeObject(new SendId(id));
                request.AddJsonBody(json);
                client.Execute(request);
            }
            catch (Exception e)
            {
                ExibeAlerta(e);
            }
        }

        // botão power
        private void BttnPower_Click(object sender, EventArgs e)
        {
            newGUI.ActiveForm.Close();
        }

        // botão minimize 
        private void BttnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // botão adicionar 
        private void BttnAdd_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(txtName.Text, txtValue.Text, txtDescription.Text, txtBrand.Text);
            PostarDados(produto);
            GetDados();
        }

        // botão remove 
        private void BttnRemove_Click(object sender, EventArgs e)
        {
            Remove(txtID.Text);
            GetDados();
        }

        private void ExibeAlerta(Exception e)
        {
            string message = "API OFFLINE (localhost:3000/products)"+ "\n" + e.Message;
            string caption = "Ocorreu um erro!";
            MessageBoxButtons button = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, button);
        }
    }
}
