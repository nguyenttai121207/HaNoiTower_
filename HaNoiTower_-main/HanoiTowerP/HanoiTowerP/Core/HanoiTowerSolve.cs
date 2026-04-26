using System;
using System.Collections.Generic;
using System.Text;

//
//File Này Trả về move cho controller để controller thực hiện move đó
//

namespace HanoiTowerP.Core
{
    public class HanoiTowerSolve
    {
        // Take move change
        public class Move
        {
            public int From;
            public int To;

            public Move(int from, int to)
            {
                this.From = from;
                this.To = to;
            }

        }

        private SinglyLinkedList<Move> moveSequence;

        // Use 0-based peg indices (0,1,2)
        public SinglyLinkedList<Move> Solve(int disks)
        {
            moveSequence = new SinglyLinkedList<Move>();
            RecursiveSolve(disks, 0, 1, 2);
            return moveSequence;
        }

        private void RecursiveSolve(int disks, int from, int aux, int to)
        {
            if (disks == 1)
            {
                moveSequence.AddLast(new Move(from, to));
                return;
            }
            RecursiveSolve(disks - 1, from, to, aux);
            moveSequence.AddLast(new Move(from, to));
            RecursiveSolve(disks - 1, aux, from, to);
        }




    }


}
