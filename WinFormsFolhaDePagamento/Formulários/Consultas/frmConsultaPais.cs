using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsFolhaDePagamento.Modelos;

namespace WinFormsFolhaDePagamento
{
    public partial class frmConsultaPais : WinFormsFolhaDePagamento.frmConsulta
    {
        Pais pais;
        frmCadastroPais frmCadastroPais;
        public frmConsultaPais()
        {
            InitializeComponent();
            frmCadastroPais = new frmCadastroPais();
        }

        public override void ConhecaObj(object obj)
        {
            pais = (Pais)obj;
        }   

        public override void Inserir()
        {
            base.Inserir();
            frmCadastroPais.ShowDialog();
        }

        public override void Alterar()
        {
            base.Alterar();
            frmCadastroPais.ConhecaObj(pais);
            frmCadastroPais.Carregar();
            frmCadastroPais.ShowDialog();
        }
    }
}
