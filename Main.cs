using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Main
    {
       
        
        public static void Main ()
        {

        Model model = new Model();
		Controller controller = new Controller(model);
		controller.displayViews();
        }
    }
}
