using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5 {
    public abstract class Grid {
        protected readonly Cell[,] Cells;

        protected Grid(int rows, int columns) {
            Cells = new Cell[rows, columns];
            for (var i = 0; i < Cells.GetLength(0); i++)
            for (var j = 0; j < Cells.GetLength(1); j++)
                Cells[i, j] = new Cell {
                    Current = Cell.State.Absent
                };
        }

        public bool Hidden { get; set; }
        public int ShipsCount { get; private set; }

        public int Columns => Cells.GetLength(1);

        public int Rows => Cells.GetLength(0);

        public Cell this[int i, int j] {
            get => Cells[i, j];
            set => Cells[i, j] = value;
        }

        public void Reset(Button[,] result) {
            ShipsCount = 0;
            for (var i = 0; i < result.GetLength(0); i++)
            for (var j = 0; j < result.GetLength(1); j++)
                switch (Cells[i, j].Current) {
                    case Cell.State.Absent:
                        result[i, j].BackColor = Color.LightGray;
                        break;
                    case Cell.State.Present:
                        ShipsCount++;
                        result[i, j].BackColor = Hidden ? Color.LightGray : Color.Green;
                        break;
                    case Cell.State.Destroyed:
                        result[i, j].BackColor = Color.Red;
                        result[i, j].Enabled = false;
                        break;
                    case Cell.State.Missed:
                        result[i, j].BackColor = Color.DarkGray;
                        result[i, j].Enabled = false;
                        break;
                }
        }

        public abstract void Impact(Grid opponent, int i, int j);
    }
}