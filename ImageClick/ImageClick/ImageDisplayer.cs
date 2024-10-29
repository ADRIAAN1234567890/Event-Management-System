using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageClick
{
   public class ImageDisplayer
    {
        public string DisplayImage(string command)
        {
            if (command.Equals("show image", StringComparison.OrdinalIgnoreCase))
            {
                // Logic to display the image
                return "Image displayed.";
            }
            return "Invalid command.";
        }
    }
}
