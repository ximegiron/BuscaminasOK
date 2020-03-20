using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Mine : ICell
    {
        private int x;
        private int y;

        private Celda.Status status;

        public Celda.Status GetStatus()
        {

            return this.status;
        }

        public int GetValue()
        {
            throw new NotImplementedException();    
        }

        public bool IsHidden()
        {
            throw new NotImplementedException();
        }

        public void LeftClick()
        {
            throw new NotImplementedException();
        }

        public void RightClick()
        {
            throw new NotImplementedException();
        }
    }
}
