using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Controller
    {
        private Model _model = null;

        public Controller(Model model)
        {
            _model = model;

            /*
             * Création de mes vues 
             * 
             * 
             */

            addListenersToModel();
        }



        private void addListenersToModel()
        {
            //_model.addVolumeListener(fieldView);
            //_model.addVolumeListener(spinnerView);
            //_model.addVolumeListener(listView);
        }

        public void displayViews()
        {
            // data
        }


        public void closeViews()
        {
            
        }
    }
}
