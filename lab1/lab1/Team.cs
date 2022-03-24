    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Team
    {
        int teamId;
        public String name;
        String abbr;
        String logo;

        public void setAll(int teamId,  String name, String abbr, String logo)
        {
            this.teamId = teamId;
            this.name = name;
            this.abbr = abbr;
            this.logo = logo;
    
        }
    }
}
