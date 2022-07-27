using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces
{
    public interface IInventario
    {
        /// <summary>
        /// firma de metodo que tienen que implementar 
        /// </summary>
        /// <returns></returns>
        public string MetodoDeEntrega();

        /// <summary>
        /// firma de metodo que tienen que implementar 
        /// </summary>
        /// <returns></returns>
        public string Info();
    }
}
