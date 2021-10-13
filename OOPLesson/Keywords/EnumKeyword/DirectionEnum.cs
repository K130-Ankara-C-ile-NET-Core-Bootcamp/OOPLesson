using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson.Keywords.EnumKeyword
{
    // Int türünde değer tutarlar
    // Default olarak N = 0, E = 1, S = 2 olarak atanır
    // Yalnızca tamsayı türlerinden extend edilebilir. Bu enum'ın value'sinin türünü belirler
    // Örneğin DirectionEnum int türünde değer tutar (Default olarak int atar)
    // ToString("D") ile int türündeki değeri alınabilir
    enum DirectionEnum : int
    {
        N,
        E,
        S,
        W = 3,

        // Enumlar method barındıramaz
        public void SomeMethod()
        {

        }
    }
}
