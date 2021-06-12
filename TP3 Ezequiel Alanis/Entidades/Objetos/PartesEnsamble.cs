using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class PartesEnsamble
    {

        #region Atributos

        private bool ruedas;
        private bool puertas;
        private bool motor;
        private bool pintura;

        #endregion

        #region Constructor

        public PartesEnsamble()
        {
            this.ruedas = false;
            this.puertas = false;
            this.motor = false;
            this.pintura = false;
        }

        #endregion

        #region Propiedades

        public bool Ruedas
        {
            get
            {
                return this.ruedas;
            }
            set
            {
                this.ruedas = value;
            }
        }

        public bool Puertas
        {
            get
            {
                return this.puertas;
            }
            set
            {
                this.puertas = value;
            }
        }

        public bool Motor
        {
            get
            {
                return this.motor;
            }
            set
            {
                this.motor = value;
            }
        }

        public bool Pintura
        {
            get
            {
                return this.pintura;
            }
            set
            {
                this.pintura = value;
            }
        }

        #endregion

        /// <summary>
        /// Verifica si todas las partes estan ensambladas
        /// </summary>
        /// <returns></returns>
        public bool VerificarEnsambleCompleto()
        {
            if (this.Ruedas && this.Puertas && this.Motor && this.Pintura)
            {
                return true;
            }

            return false;
        }                
    }
}
