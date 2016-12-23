using chApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chApp.BLL
{
    public class ModelController
    {
        private ChequeBL chequeBL;
        public ChequeBL ChequeBL
        {
            get
            {
                if (chequeBL == null)
                {
                    chequeBL = new ChequeBL();
                }
                return chequeBL;
            }
        }

        private ClienteBL clienteBL;
        public ClienteBL ClienteBL
        {
            get
            {
                if (clienteBL == null)
                {
                    clienteBL = new ClienteBL();
                }
                return clienteBL;
            }
        }

        private FirmanteBL firmanteBL;
        public FirmanteBL FirmanteBL
        {
            get
            {
                if (firmanteBL == null)
                {
                    firmanteBL = new FirmanteBL();
                }
                return firmanteBL;
            }
        }

    }
}
