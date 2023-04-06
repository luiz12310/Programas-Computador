using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaPweb
{
    internal class Computador
    {
        #region Propriedades

        private string _modeloProcessador;

        public string getModeloProcessador()
        {
            return _modeloProcessador;
        }

        public void setModeloProcessador(string modeloPro)
        {
            _modeloProcessador = modeloPro;
        }

        private double _qtMemoria;
        
        public double getQtMemoria() 
        {
            return _qtMemoria;
        }

        public void setQtMemoria(double qtMemory)
        {
            _qtMemoria = qtMemory;
        }

        public Fabricante fabricante;

        public Programa programa;

        #endregion

        #region Métodos

        public string mostrarDados()
        {
            return "modelo: " + getModeloProcessador() + ", memoria: " + converterMemoria() + " tera de memória, fabricante: " + fabricante.NomeFabricante;
        }

        public double converterMemoria()
        {            
            if(getQtMemoria() == 1024)
            {
                return 1;
            }
            else
            {
                return getQtMemoria() / 1024; 
            }
        }

        public double memoriaSendoUsadaMomento(double memoriaApp, double memoriaComputador)
        {
            return memoriaComputador - memoriaApp;
        }

        public void removerPrograma()
        {
            programa = null;
            return;
        }

        public string checarProgramaUsando()
        {
            if(programa != null)
            {
                return "Usando programa";
            }
            else
            {
                return "Sem programas";
            }
        }

        public void addPrograma(Programa program)
        {
            programa = program;
        }

        #endregion

        #region Constructors

        public Computador(string modeloPro, double qtMemory, Fabricante fabricante, Programa programa)
        {
            setModeloProcessador(modeloPro);
            setQtMemoria(qtMemory);
            this.fabricante = fabricante;
            this.programa = programa;
        }

        #endregion
    }
}
