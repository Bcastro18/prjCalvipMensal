using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSistemaMensal_UniaoEnc
{
    public partial class wfaFechamento : Form
    {
        public wfaFechamento()
        {
            InitializeComponent();
            
        }


        public wfaFechamento(List<Frete> ce, List<Frete> cr)
        {
            InitializeComponent();
            mostraResultados(ce, cr);

            
        }

        private double calculaCif(List<Frete> cs)
        {
            double result = 0;
            foreach (Frete i in cs)
            {
                if (i.pagamento == 1)
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

        public void mostraResultados(List<Frete> ce, List<Frete> cr)
        {
            double cife = calculaCif(ce);
            double cifr = calculaCif(cr);
            double fobe = calculaFob(ce);
            double fobr = calculaFob(cr);


            lblCifRegResp.Text = "R$ "+cifr.ToString();
            lblCifResp.Text = "R$ " + cife.ToString();
            lblFobRegResp.Text = "R$ " + fobr.ToString();
            lblFobResp.Text = "R$ " + fobe.ToString();
            lblTotEmiResp.Text = "R$ " + (cife + fobe).ToString();
            lblTotRegResp.Text = "R$ " + (cifr + fobr).ToString();
            lblComResp.Text = "R$ " + ((cife + cifr + fobe + fobr) * 0.4).ToString();
            lblTotNCaix.Text = "R$ " + (cife + fobr).ToString();
            lblTotOCaix.Text = "R$ " + (cifr + fobe).ToString();
            lblDepResp.Text = "R$ " + ((cife + fobr) - ((cife + cifr + fobe + fobr) * 0.4)).ToString();
            




        }

        private void btnGera_Click(object sender, EventArgs e)
        {
            if (txtPerid.Text != "")
            {
                
                Bitmap bmpScreenshot = new Bitmap(this.Bounds.Width, this.Bounds.Height, PixelFormat.Format32bppArgb);
                
                Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                Point p = this.PointToScreen(new Point(gpbFechamento.Bounds.X, gpbFechamento.Bounds.Y));
                gfxScreenshot.CopyFromScreen(p.X, p.Y, 0, 0, gpbFechamento.Bounds.Size, CopyPixelOperation.SourceCopy);

                SaveFileDialog saveImageDialog = new SaveFileDialog();
                saveImageDialog.Title = "Selecione onde a imagem será salva:";
                saveImageDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                
                if (saveImageDialog.ShowDialog() == DialogResult.OK)
                {
                    bmpScreenshot.Save(saveImageDialog.FileName, ImageFormat.Png);
                }






            }
        }

    }
}
