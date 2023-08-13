using System;

namespace WindowsFormsApp5 {
    internal class Enemy : Grid {
        private readonly Random random;

        public Enemy(int i, int j) : base(i, j) {
            random = new Random();
            
            // здесь мне лень рандомно генерировать позиции кораблей
            Cells[2, 4].Current = Cell.State.Present;
            Cells[6, 2].Current = Cell.State.Present;
            Cells[7, 7].Current = Cell.State.Present;
            Cells[5, 2].Current = Cell.State.Present;
            Cells[1, 0].Current = Cell.State.Present;
        }

        public override void Impact(Grid opponent, int i, int j) {
            // да
            opponent[random.Next(opponent.Rows), random.Next(opponent.Columns)].Impact();
        }
    }
}