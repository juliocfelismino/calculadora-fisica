using Crud;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud
{
    internal class formula
    {
    }

    public class Formula
    {
        public abstract double Calcular();
    }

    public class Velocidade Media : Formula
    {
        public double Distancia { get; set; }

        public double Tempo { get; set; }

        public override double Calcular();
        {
        if (Tempo == 0) throw new DivideByZeroException("O tempo não pode ser zero.");
        return Distancia / Tempo;

        }
    } 

    public class Aceleracao : Formula
    { 
        public double VariacaoVelocidade { get; set; }

        public double VariacaoTempo { get; set; }

        public override double Calcular()
        {

        if (VariacaoTempo == 0) throw new DivideByZeroException("O tempo não pode ser zero.");
        return VariacaoVelocidade / VariacaoTempo;

        }
    }
    
    public class Forca : Formula
    {
        public double Massa { get; set; }

        public double AceleracaoCorpo { get; set; }

    public override double Calcular()
    {

    return Massa * AceleracaoCorpo;

    }

    public class ForcaAtrito: Formula
    {
        public double CoeficienteAtrito { get; set; }
        public double ForcaNormal { get; set; }

        public override double Calcular()
        {
            return CoeficienteAtrito * ForcaNormal;
        }
    }
    public class Peso : Formula
    {
        public double Massa { get; set; }
        public double Gravidade { get; set; } = 9.8; // Valor padrão da Terra

        public override double Calcular()
        {
            return Massa * Gravidade;
        }
    }


    public class LeiOhm : Formula
    {
        public double Resistencia { get; set; }
        public double Corrente { get; set; }

        public override double Calcular()
        {
            return Resistencia * Corrente; // Retorna a Tensão (V = R * I)
        }
    }
}


}
}
