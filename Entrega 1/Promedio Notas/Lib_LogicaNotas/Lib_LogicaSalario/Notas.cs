using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_LogicaSalario
{
    public class Notas
    {
        #region Atributos

        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double promedio;
        private String error;

        #endregion

        #region Metodo publico

        public Notas()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            nota4 = 0;
            promedio = 0;
            error = "";
        }

        public bool Multiplicar()
        {
            if (!Validar())
                return false;
            try
            {
                promedio = (nota1 + nota2 + nota3 + nota4)/4;
                return true;
            }

            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }

        }
        #endregion


        #region Metodo privado

        private bool Validar()
        {
            if (nota1 < 0 || nota1 >  5 || nota2 < 0 || nota2 > 5 || nota3 < 0 || nota3 > 5 ||
                nota4 < 0 || nota4 > 5 )
            {
                error = "Nota fuera de rango permitido";
                return false;
            }

            return true;
        }
        #endregion

        #region Propiedades

        public double setNota1
        {
            set
            {
                nota1 = value;
            }
        }

        public double setNota2
        {
            set
            {
                nota2 = value;
            }
        }

        public double setNota3
        {
            set
            {
                nota3 = value;
            }
        }

        public double setNota4
        {
            set
            {
                nota4 = value;
            }
        }

        public double getPromedio
        {
            get
            {
                return promedio;
            }
        }

        public String geterror
        {
            get
            {
                return error;
            }
        }

        #endregion
    }
}
