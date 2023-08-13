namespace WindowsFormsApp5 {
    internal class Player : Grid {
        public Player(int i, int j) : base(i, j) {
            // здесь мне лень рандомно генерировать позиции кораблей
            Cells[0, 0].Current = Cell.State.Present;
            Cells[5, 1].Current = Cell.State.Present;
            Cells[7, 2].Current = Cell.State.Present;
            Cells[2, 3].Current = Cell.State.Present;
            Cells[6, 4].Current = Cell.State.Present;
        }

        public override void Impact(Grid opponent, int i, int j) {
            opponent[i, j].Impact();
        }
    }
}