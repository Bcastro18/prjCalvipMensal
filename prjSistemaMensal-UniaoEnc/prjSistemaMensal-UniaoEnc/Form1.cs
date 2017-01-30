using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace prjSistemaMensal_UniaoEnc
{
    public partial class Mensal : Form
    {

        //atenção com os statics
        public List<Frete> ctes = new List<Frete>();
        public List<Frete> ctesEmis = new List<Frete>();
        public List<Frete> ctesRec = new List<Frete>();
        static Microsoft.Office.Interop.Excel.Application XcelApp;
        static object misValue;
        static Workbook xlWorkBook;
        static Worksheet xlWorkSheet;

        private int op = 1;



        public Mensal()
        {
            InitializeComponent();
            atualizaTabela();
            LimpaCampos();
        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if(txtDestinatário.Text != "" && txtRemetente.Text != "" && txtNCTE.Text != "" && txtValor.Text != "")
            {
                Frete ft = new Frete();
                ft.ano = cmbAno.SelectedItem.ToString();  
                ft.dia = cmbDia.SelectedItem.ToString();
                ft.mes = cmbMes.SelectedItem.ToString();
                ft.destinatario = txtDestinatário.Text;
                ft.cidade = cmbCidades.SelectedItem.ToString();
                ft.ncte = txtNCTE.Text;
                ft.remetente = txtRemetente.Text;
                ft.valor = Convert.ToDouble(txtValor.Text);

                if (rdbPagamentoApagar.Checked)
                {
                    ft.pagamento = 2;
                } else
                {
                    ft.pagamento = 1;
                }

                ft.somaValor(ft.pagamento, ft.valor);
                ctes.Add(ft);

                LimpaCampos();
                atualizaTabela();

            } else
            {
                MessageBox.Show("Inserir todos os campos válidos, por favor!");
            }
        }

        public void LimpaCampos()
        {

            cmbAno.SelectedIndex = 0;
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            txtDestinatário.Text = "";
            cmbCidades.SelectedIndex = 0;
            txtNCTE.Text = "";
            txtRemetente.Text = "";
            txtValor.Text = "0";

        }

         public void atualizaTabela()
        {
            
            //Create a New DataTable to store the Data
            System.Data.DataTable Fte = new System.Data.DataTable("Fretes");
            //Create the Columns in the DataTable

            DataColumn cData = new DataColumn("Data");
            DataColumn cCte = new DataColumn("CTE");
            DataColumn cRem = new DataColumn("Remetente");
            DataColumn cDes = new DataColumn("Destinatario");
            DataColumn cCid = new DataColumn("Cidade");
            DataColumn cTip = new DataColumn("Tipo");
            DataColumn cVal = new DataColumn("Valor");

            Fte.Columns.Add(cData);
            Fte.Columns.Add(cCte);
            Fte.Columns.Add(cRem);
            Fte.Columns.Add(cDes);
            Fte.Columns.Add(cCid);
            Fte.Columns.Add(cTip);
            Fte.Columns.Add(cVal);

            foreach (Frete ft in ctes)
            {
                DataRow row = Fte.NewRow();
                row["Data"] = ft.dia + "/" + ft.mes + "/" + ft.ano;
                row["CTE"] = ft.ncte.ToString();
                row["Remetente"] = ft.remetente.ToString();
                row["Destinatario"] = ft.destinatario.ToString();
                row["Cidade"] = ft.cidade.ToString();
                if(ft.pagamento == 1)
                    row["Tipo"] = "CIF";
                else
                row["Tipo"] = "FOB";
                row["Valor"] = ft.valor.ToString();

                Fte.Rows.Add(row);
            }
            dgvCtes.DataSource = Fte;

            if(ctes.Count > 0)
            {
                int num = ctes.Count;
                txtNCTE.Text = (Convert.ToInt32(ctes[num - 1].ncte) + 1).ToString();
            }

        }

        private double calculaCif(List<Frete> cs)
        {
            double result = 0;
            foreach(Frete i in cs)
            {
                if(i.pagamento == 1)
                {
                    result += i.valor;
                }
            }

            return result;
        }

        private double calculaFob(List<Frete> cs)
        {
            double result = 0;
            foreach (Frete i in cs)
            {
                if (i.pagamento == 2)
                {
                    result += i.valor;
                }
            }

            return result;
        }

        private void gera(DataGridView dgvCtes)
        {
            XcelApp = new Microsoft.Office.Interop.Excel.Application();
            misValue = System.Reflection.Missing.Value;
            xlWorkBook = XcelApp.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //XcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dgvCtes.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i] = dgvCtes.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvCtes.Rows.Count; i++)
            {
                for (int j = 0; j < dgvCtes.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dgvCtes.Rows[i].Cells[j].Value.ToString();
                    xlWorkSheet.Cells[i + 2, j + 1].HorizontalAlignment = 3;
                    xlWorkSheet.Cells[i + 2, j + 1].HorizontalAlignment = 3;

                }
            }
            //final do relatório - totais
            int contaLinhas = dgvCtes.RowCount;

            //total cif
            xlWorkSheet.Cells[contaLinhas + 2, 6] = "Somas fretes CIFs:";
            xlWorkSheet.Cells[contaLinhas + 2, 6].Font.Bold = true;
            xlWorkSheet.Cells[contaLinhas + 2, 7] = calculaCif(ctes).ToString();
            //xlWorkSheet.Cells[contaLinhas + 2, 7].NumberFormat = "$ #,###,###.00";
            xlWorkSheet.Cells[contaLinhas + 2, 7].Font.Bold = true;

            //total fob
            xlWorkSheet.Cells[contaLinhas + 3, 6] = "Somas fretes FOBs:";
            xlWorkSheet.Cells[contaLinhas + 3, 6].Font.Bold = true;
            xlWorkSheet.Cells[contaLinhas + 3, 7] = calculaFob(ctes).ToString();
            //xlWorkSheet.Cells[contaLinhas + 3, 7].NumberFormat = "$ #,###,###.00";
            xlWorkSheet.Cells[contaLinhas + 3, 7].Font.Bold = true;


            //cabeçalho
            Range formatRange1;
            formatRange1 = xlWorkSheet.get_Range("a1", "g1");
            Range cell = formatRange1;
            Borders border = cell.Borders;
            border.LineStyle = XlLineStyle.xlContinuous;
            border.Weight = 4d;
            formatRange1.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            formatRange1.EntireRow.Font.Bold = true;
            formatRange1.Font.Size = 15;
            formatRange1.HorizontalAlignment = 3;
            formatRange1.VerticalAlignment = 3;

            //formato moeda na coluna valor
            Range formatRange;
            formatRange = xlWorkSheet.get_Range("g2", "g" + Convert.ToString(dgvCtes.RowCount + 1));
            formatRange.NumberFormat = "$ #,###,###.00";

            xlWorkSheet.Columns.AutoFit();
            XcelApp.Visible = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            //btnAdc.Visible = false;
            if (dgvCtes.Rows.Count > 0)
            {
                try
                {                  
                    if (op == 1)
                    {
                        gera(dgvCtes);
                        ctesEmis = ctes;
                        ctes = new List<Frete>();
                        lblTipoResp.Text = "REGIÃO";
                        atualizaTabela();
                        op = 2;
                        MessageBox.Show("Fretes emitidos da sua base concluído. Prossiga com os recebidos de outras bases!");

                    } else if (op == 2)
                    {
                        gera(dgvCtes);
                        ctesRec = ctes;
                        btnFechamento.Visible = true;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void btnFechamento_Click(object sender, EventArgs e)
        {
            wfaFechamento fec = new wfaFechamento(ctesEmis, ctesRec);
            fec.ShowDialog();

        }

        private void txtNCTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)8)
                e.Handled = false;
        }

        private void cmbDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8)
                e.Handled = false;            //Allow Backspace
        }

        private void cmbMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8)
                e.Handled = false;            //Allow Backspace
        }

        private void cmbAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8)
                e.Handled = false;            //Allow Backspace
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8)
                e.Handled = false;            //Allow Backspace
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8)
                e.Handled = false;            //Allow Backspace
        }

        private List<Frete> Pesquisar(string op)
        {
            List<Frete> fts = new List<Frete>();

            foreach (Frete ft in ctes)
            {
                if (op == ft.ncte.ToString())
                {
                    fts.Add(ft);
                }

            }

            return fts;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtExcluir.Text != "")
            {
                string op = txtExcluir.Text;
                List<Frete> fts = Pesquisar(op);
                if (fts != null)
                {
                    foreach(Frete ft in fts)
                        ctes.Remove(ft);
                }
                atualizaTabela();

            }else
            {
                MessageBox.Show("Insira um número de cte válido!");

            }
        }
    }
}
