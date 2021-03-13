using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;


namespace API_WinFormsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click()
        {
            var client = new RestClient(@"http://127.0.0.1/meuapi/rota");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            // se precisar de token request.AddHeader("Authorization", $"bearer XXXX");
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //provavle que venha um json no seu codigo  então deserializa ela para um objeto especifico                  
                var ct = JsonConvert.DeserializeObject<MeuOBJ>(response.Content);
            }
        }
}
