using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Redo
    {
        private Stack<Figures> FiguresSt;
        public Redo()
        {
            FiguresSt = new Stack<Figures>();
        }

        public void Push(Figures figures)
        {
            FiguresSt.Push(figures);
        }

        public Figures Pop()
        {
            return FiguresSt.Pop();
        }

        public void ClearSt()
        {
            FiguresSt.Clear();
        }

        public bool Blank()
        {
            if (FiguresSt.Count == 0)
                return false;

            return true;
        }
    }
}
