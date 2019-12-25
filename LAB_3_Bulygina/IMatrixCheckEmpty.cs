using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_Bulygina
{
    //методы данного интерфейса используются при создании разреженной матрицы
    public interface IMatrixCheckEmpty<T>
    {
        //возвращает пустой элемент
        T getEmptyElement();
        //проверка, что элемент является пустым
        bool CheckEmptyElement(T element);
    }
}

