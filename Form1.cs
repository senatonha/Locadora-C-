using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIdex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }


       // [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
       // private extern static void ReleaseCapture();

       // [DllImport("user32.DLL", EntryPoint = "SendMessage")]
       // private extern static void SendMessage(System.IntPtr hWnd, int WMsg, int lParam, int v);

       // //Coisas Importantes**

       //private Color SelectClassecor()
       // {
       //    int index = random.Next(Classecor.ColorList.Count);
       //    while (tempIdex == index)
       //     {
       //        index = random.Next(Classecor.ColorList.Count);
       //     }
       // tempIdex = index;
       //     string color = Classecor.ColorList[index];
       //     return ColorTranslator.FromHtml(color);
       // }
        
      private void ActivateButton(object btnSender)
      {
          if (btnSender != null)
          {
                  DisableButton();
                  //Color Color = SelectClassecor();
                  //currentButton = (Button)btnSender;
                  //currentButton.BackColor = Color.LightPink;
                  //currentButton.ForeColor = Color.Black;
                  //currentButton.Font = new System.Drawing.Font("Candara;", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  //panelTitleBar.BackColor = Color;
                  //panelMenu.BackColor = Classecor.ChangeColorBrightness(Color, -0.3);
                  //Classecor.SecundaryColor = Classecor.ChangeColorBrightness(Color, -0.3);
                  btnClose.Visible = true;
     
     
       
      }
      }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
              if (previousBtn.GetType() == typeof(Button))
                {
        previousBtn.BackColor = Color.FromArgb(240, 185, 207);
        previousBtn.ForeColor = Color.Black;
        //Fonte e tamanho
        previousBtn.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
        }
        }


        private void OpenChildForm(Form childForm, object btnSehder)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSehder);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;


        }

        private void Reset()
        {
          DisableButton();
            lblTitulo.Text = "HOME";
           // panelTitleBar.BackColor = Color.FromArgb(255, 192, 192);
            //panelLogo.BackColor = Color.FromArgb(64, 64, 64);
            currentButton = null;
            btnClose.Visible = false;
        }


        //private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        //Sair do programa
        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //Maximizar
        private void btnMaximiza_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Minimizar
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void panelLogo1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        //Tela Cliente
        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmCliente(), sender);
        }

        //Tela Funcionário
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmFuncionario(), sender);

        }

        //Tela Automóvel
        private void btnAutomovel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmAutomovel(), sender);

        }

        //Tela Locação
        private void btnLocacao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmLocacao(), sender);
        }
        //Tela Desabilitados
        private void btndesabilitados_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FrmDesativados(), sender);
        }
    }
    }
