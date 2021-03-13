using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WF_WebAPI
{
    public partial class Atualizar : Form
    {
        Thread cadastrar;
        Thread update;
        Thread consultar;
        Thread deletar;
        public Atualizar()
        {
            InitializeComponent();
        }

        private void buttonCadastar_Click(object sender, EventArgs e)
        {

            this.Close();
            cadastrar = new Thread(abrirJanelaCadastro);
            cadastrar.SetApartmentState(ApartmentState.STA);
            cadastrar.Start();
            //Cadastro cadastro = new Cadastro();
            //cadastro.Show();
            ////this.Hide();
        }

        private void abrirJanelaCadastro(object obj)
        {
            Application.Run(new Cadastro());
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            //Deletar deletar = new Deletar();
            //deletar.Show();
            //this.Hide();
            this.Close();
            deletar = new Thread(abrirJanelaDeletar);
            deletar.SetApartmentState(ApartmentState.STA);
            deletar.Start();
        }

        private void abrirJanelaDeletar(object obj)
        {
            Application.Run(new Deletar());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
            update = new Thread(abrirJanelaUpdate);
            update.SetApartmentState(ApartmentState.STA);
            update.Start();
        }

        private void abrirJanelaUpdate(object obj)
        {
            Application.Run(new Update());
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            consultar = new Thread(abrirJanelaConsultar);
            consultar.SetApartmentState(ApartmentState.STA);
            consultar.Start();
        }

        private void abrirJanelaConsultar(object obj)
        {
            Application.Run(new Consultar());
        }
    }
    
}
