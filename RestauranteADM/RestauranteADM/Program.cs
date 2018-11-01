using RestauranteADM.TELAS;
using RestauranteADM.TELAS._1._0._1;
using RestauranteADM.TELAS.Alterar;
using RestauranteADM.TELAS.Cadastro;
using RestauranteADM.TELAS.Consulta;
using RestauranteADM.TELAS.Financeiro;
using RestauranteADM.TELAS.recuperaçao;
using RestauranteADM.TELAS.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new ConsultarVendas());
        }
    }
}
