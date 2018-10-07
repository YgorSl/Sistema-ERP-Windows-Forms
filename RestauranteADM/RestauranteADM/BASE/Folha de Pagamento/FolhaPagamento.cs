using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteADM.BASE.Folha_de_Pagamento
{
    public class FolhaPagamento
    {
        public double CalcularSH(double SalarioBase)
        {

            double SH = SalarioBase / 220;
            return SH;
        }

        public double CalcularHE(double SH, double percentual, double quantidade)
        {
            double SalarioHora = SH;
            double ValorHE = SH * (percentual / 100.0);
            double HE = (ValorHE + SH) * quantidade;
            return HE;
        }

        public double CalcularAtrasos(double SH, double QuantHorasAtrasadas)
        {
            double SalarioHora = SH;
            double Atraso = SalarioHora * QuantHorasAtrasadas;
            return Atraso;
        }

        public double CalcularFaltas(double SalarioBase, double QuantFaltas, double QuantDomingos)
        {
            double SalarioDia = SalarioBase / 30;
            double Faltas = QuantFaltas + QuantDomingos;
            double Desconto = SalarioDia * Faltas;
            return Desconto;

        }
        public double CalcularDSRHE(double HE, double QuantFaltas, double QuantDomingos)
        {
            if (QuantFaltas == 0)
            {
                double DSR = (HE / 26) * 4;
                return DSR;
            }
            else
            {
                double DSRFaltas = (HE / (26 - QuantFaltas)) * (4 - QuantDomingos);
                return DSRFaltas;
            }
        }


        public double CalcularINSS(double SalarioBase, double HE, double DSR, double Faltas, double Atrasos)
        {

            double BaseINSS = (SalarioBase + HE + DSR) - (Faltas + Atrasos);
            if (BaseINSS <= 1693.72)
            {
                double INSS1 = BaseINSS * (8 / 100.0);
                return INSS1;
            }
            else if (BaseINSS >= 1693.73 && BaseINSS <= 2822.90)
            {
                double INSS2 = BaseINSS * (9 / 100.0);
                return INSS2;
            }
            else
            {
                double INSS3 = BaseINSS * (11 / 100.0);
                return INSS3;
            }


        }

        public double CalcularIRRF(double BaseINSS, double INSS)
        {

            double BaseIRRF = BaseINSS - INSS;
            if (BaseIRRF <= 1903.98)
            {
                double IRRF1 = 0;
                return IRRF1;
            }
            else if (BaseIRRF >= 1903.99 && BaseIRRF <= 2826.65)
            {
                double IRRF2 = (BaseIRRF * (7.5 / 100.0)) - 142.80;
                return IRRF2;
            }
            else if (BaseIRRF >= 2826.66 && BaseIRRF <= 3751.05)
            {
                double IRRF3 = (BaseIRRF * (15 / 100.0)) - 354.80;
                return IRRF3;

            }
            else if (BaseIRRF >= 3751.06 && BaseIRRF <= 4664.68)
            {
                double IRRF4 = (BaseIRRF * (22.5 / 100.0)) - 636.13;
                return IRRF4;

            }
            else
            {
                double IRRF5 = (BaseIRRF * (27.5 / 100.0)) - 869.36;
                return IRRF5;

            }


        }

        public double CalcularFGTS(double BaseINSS)
        {
            double FGTS = BaseINSS * (8 / 100.0);
            return FGTS;
        }


        public double CalcularVT(double SalarioBase)
        {
            double VT = SalarioBase * (6 / 100.0);
            return VT;
        }


        public double CalcularSF(double SalarioBase, double QuantDeMenor)
        {
            if (SalarioBase > 1319.18)
            {
                double SF = 0;
                return SF;
            }
            if (SalarioBase >= 877.67 && SalarioBase <= 1319.18)
            {
                double SF = QuantDeMenor * 31.71;
                return SF;
            }
            else
            {
                double SF = QuantDeMenor * 45;
                return SF;

            }



        }
        public double CalcularTotal(double SalarioBase, double HE, double DSR,  double Faltas, double Atrasos, double INSS, double IRRF, double VT, double SalarioFamilia, double Bonus, double Convenio, double CestaBasica)
        {
            double Total = (SalarioBase + HE + DSR + SalarioFamilia + Bonus) - (Faltas + Atrasos + INSS + IRRF + VT + Convenio + CestaBasica);
            return Total;
        }



    }
}

