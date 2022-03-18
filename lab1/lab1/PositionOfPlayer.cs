using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class PositionOfPlayer
    {
        int positionId;
        int playerId;

        public void setAll(int positionId, int playerId)
        {
            this.positionId = positionId;
            this.playerId = playerId;
        }
    }
}
