using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KierenWoodsSolution.PageObjects.ChallengingDom
{
   public class ChallengingDomAssertions
    {
               

        public bool CheckCellValue(string value)
        {
            if (ChallengingDomExecution.CellValue == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
