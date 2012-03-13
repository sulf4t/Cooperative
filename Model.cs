using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Model
    {
        ClientManager _clientManager;
        ProducteurManager _producteurManager;
        ShopManager _shopManager;
        
        public Model()
        {
            _clientManager = new ClientManager(this);
            _producteurManager = new ProducteurManager(this);
            _shopManager = new ShopManager(this);


        }

        public void fireNewClient()
        { 
        }



    }
}
