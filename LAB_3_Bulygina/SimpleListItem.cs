using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_Bulygina
{
    /// <summary>
    /// Элемент списка
    /// </summary>
    partial class SimpleListItem<T>
    {
        ///<summary>
        ///Данные
        ///</summary>
        public T data { get; set; }
        ///<summary>
        ///Следующий элемент
        /// </summary>
        public SimpleListItem<T> next { get; set; }

        /// <summary>
        /// конструктор
        /// </summary>
        public SimpleListItem(T param)
        {
            this.data = param;
        }
    }
}

