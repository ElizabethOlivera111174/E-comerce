using System;
using System.Globalization;

namespace ProjectNC.Domain.Exceptions
{
    #region About: CustomException
    /// <summary>
    /// CustomException a nivel de negocio. Regresa Exceptions de logica de negocion, dejando las de systema con Exception
    /// </summary> 
    #endregion
    public class ProjNCException : Exception
    {
        public ProjNCException() : base() { }
        public ProjNCException(string message) : base(message) { }
        public ProjNCException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args)) { }
    }
}