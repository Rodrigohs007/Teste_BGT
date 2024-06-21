using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Tijolo_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parede_Tijolos _parede_Tijolos = new Parede_Tijolos();

            string[] array = textBox1.Text.Split(']');

            var Listagem_Array = new List<IList<int>>();

            foreach (var item in array)
            {
               
                string Limpa_Itens = item.Replace("\"", "").Replace("[", "").Replace("]", "").Trim();
                var Numeros_Linhas = Limpa_Itens.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();
                if(Numeros_Linhas.Count != 0)
                {
                    Listagem_Array.Add(Numeros_Linhas);
                }
               
            }

            lbl_Tijolos_Cortados.Text = _parede_Tijolos.Montando_Linha(Listagem_Array).ToString();

        }



     
    }
}
