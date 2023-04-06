using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaPweb
{
    internal class Fabricante
    {
        #region Propriedades

        private string _nomeFabricante;

		public string NomeFabricante
		{
			get { return _nomeFabricante; }
			set { _nomeFabricante = value; }
		}

		private int _idFabricante;

		public int IdFabricante
		{
			get { return _idFabricante; }
			set { _idFabricante = value; }
		}

        #endregion

        #region Constructors

        public Fabricante(string nome, int id) 
		{
			this._nomeFabricante = nome;
			this._idFabricante = id;
		}

        #endregion

    }
}
