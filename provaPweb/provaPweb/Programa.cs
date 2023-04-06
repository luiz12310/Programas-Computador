using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaPweb
{
    internal class Programa
    {
        #region Propriedades

		private string _nomePrograma;

		public string getNomePrograma()
		{
			return _nomePrograma;
		}

		public void setNomePrograma(string nomeProgram)
		{
			_nomePrograma = nomeProgram;
		}



		private string _dsPrograma;

		public string getDsPrograma()
		{
			return _dsPrograma;
		}

		public void setDsPrograma(string dsProgram)
		{
			_dsPrograma = dsProgram;
		}



		private string _endereco;

		public string getEndereco()
		{
			return _endereco;
		}

		public void setEndereco(string endereco)
		{
			_endereco = endereco;
		}



		private int _id;

		public int getId()
		{
			return _id;
		}

		public void setId(int id)
		{
			_id = id;
		}



		private double _memoriaUsa;

		public double getMemoria()
		{
			return _memoriaUsa;
		}

		public void setMemoria(double memoria)
		{
			_memoriaUsa = memoria;
		}

        #endregion

        #region Métodos

		public string mostrarDados()
		{
			return "Nome do Programa: " + getNomePrograma() + " || Memória do programa: " + getMemoria();
		}

        #endregion

        #region Constructors

        public Programa(string nome, string descricao, string enreco,int id, double MemoriaUsa)
		{
			this.setNomePrograma(nome);
			this.setDsPrograma(descricao);
			this.setEndereco(enreco);
			this.setId(id);
			this.setMemoria(MemoriaUsa);
		}

        #endregion
    }
}
