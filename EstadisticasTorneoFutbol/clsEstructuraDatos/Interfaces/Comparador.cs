using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.Interfaces
{
    public interface Comparador
    {
        bool igualQue(string q);
        bool menorQue(string q);
        bool mayorQue(string q);
        bool igualQue(int q);
        bool menorQue(int q);
        bool mayorQue(int q);
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool mayorQue(Object q);
    }
}
