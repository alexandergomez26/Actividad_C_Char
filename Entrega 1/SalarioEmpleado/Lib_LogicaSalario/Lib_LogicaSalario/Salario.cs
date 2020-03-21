using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_LogicaSalario
{
    public class Salario
    {
        #region Atributos

        private double sueldo;
        private double dias;
        private double salario;
        private String error;
        #endregion

        #region Metodo publico

        public Salario()
        {
            dias= 0;
            sueldo = 0;
            salario = 0;
            error = "";
        }

        public bool Calcular()
        {
            if (!Validar())
                return false;
            try
            {
                salario = sueldo / dias;
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
            if (sueldo < 0 || dias < 0)
            {
                error = "No es permitido ingresar un valor negativo";
                return false;
            }

            return true;
        }
        #endregion

        #region Propiedades

        public double setSueldo
        {
            set
            {
                sueldo = value;
            }
        }

        public double setDias
        {
            set
            {
                dias = value;
            }
        }

        public double getSalario
        {
            get
            {
                return salario;
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
