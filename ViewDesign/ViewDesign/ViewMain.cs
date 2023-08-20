using System;
using System.Drawing;
using System.Windows.Forms;

namespace ViewDesign
{
    public partial class ViewMain : Form
    {
        private static Color BtnColorBase = Color.DarkBlue;
        private static Color BtnColorActive = Color.MidnightBlue;

        public ViewMain()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void Btn_Principal_Click(object sender, EventArgs e)
        {
            EraseButtons();

            Btn_Principal.BackColor = BtnColorActive;

            //Mandar el form...
            ViewPrincipal viewPrincipal = new ViewPrincipal();

            viewPrincipal.TopLevel = false;
            viewPrincipal.Size = View_Base.ClientSize;
            View_Base.Controls.Clear();
            View_Base.Controls.Add(viewPrincipal);
            viewPrincipal.Show();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            EraseButtons();

            Btn_1.BackColor = BtnColorActive;

            //Mandar el form...
            BaseForm baseForm = new BaseForm();

            baseForm.TopLevel = false;
            baseForm.Size = View_Base.ClientSize;
            View_Base.Controls.Clear();
            View_Base.Controls.Add(baseForm);
            baseForm.Show();
        }

        private void InitializeButtons()
        {
            EraseButtons();

            Btn_Principal.Click += Btn_Principal_Click;
            Btn_1.Click += Btn_1_Click;
        }

        private void EraseButtons()
        {
            Btn_Principal.BackColor = BtnColorBase;
            Btn_1.BackColor = BtnColorBase;
            Btn_2.BackColor = BtnColorBase;
            Btn_3.BackColor = BtnColorBase;
            Btn_4.BackColor = BtnColorBase;
        }
    }
}
