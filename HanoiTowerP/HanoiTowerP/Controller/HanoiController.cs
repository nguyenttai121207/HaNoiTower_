using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using HanoiTowerP.Core;

// Take List of move change
// Make 3 pegs
// pop and push disk to pegs
// Ui update

namespace HanoiTowerP.Core
{
    public class HanoiController
    {
        public Stack<int>[] pegStack;// 3 pegs . stack này chứa disk của peg ( tức là Peg[i} chứa các disk của peg thứ i)
        private SinglyLinkedList<HanoiTowerSolve.Move> moves;// List of moves
        private Node<HanoiTowerSolve.Move> current;// Current move

        public HanoiController()
        {
            // Initialize pegs with index 0..2
            pegStack = new Stack<int>[3];
            for (int i = 0; i < 3; i++)
            {
                pegStack[i] = new Stack<int>();
            }
        }

        public void Initialize(int disks)
        {
            // reset pegs
            for (int indexpegs = 0; indexpegs < 3; indexpegs++)
            {
                pegStack[indexpegs] = new Stack<int>();
            }

            // push disks into peg 0 (source)
            for (int sizedisks = disks; sizedisks > 0; sizedisks--)
            {
                pegStack[0].Push(sizedisks);
            }

            // Lấy move từ Solver

            HanoiTowerSolve solve = new HanoiTowerSolve();
            moves = solve.Solve(disks);
            current = moves.GetHead();
        }

        public bool HasNext()
        {
            return  current != null;
        }

        public HanoiTowerSolve.Move NextStep()
        {
            if (!HasNext())
            {
                return null;
            }

            var step = current.Data;

            // Real Move

            int disk = pegStack[step.From].Pop();
            pegStack[step.To].Push(disk);

            current = current.Next;
            return step;
        }

        // Lấy trạng thái hiện tại của các peg để UI có thể cập nhật
        public Stack<int>[] GetPeg() => pegStack;
        


    }
}
