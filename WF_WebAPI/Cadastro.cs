using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;


namespace WF_WebAPI
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new RestClient(@"http://127.0.0.1/api/Cliente"/*, labelCPF, labelNome, labelEmail
                , labelTelefone, labelTipoEndereco, labelLogradouro, labelNumero, labelComplemento
                , labelBairro*/);
            cliente.Timeout = -1;
            var request = new RestRequest(Method.GET);
            // se precisar de token request.AddHeader("Authorization", $"bearer XXXX");
            //ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            IRestResponse response = cliente.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //provavle que venha um json no seu codigo  então deserializa ela para um objeto especifico

                var ct = JsonConvert.DeserializeObject<IRestClient>(response.Content);

            }


        }
    }
}
