using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp5 {
    public partial class Form1 : Form {
        private readonly Enemy enemy;
        private readonly Button[,] enemyButtons;
        private readonly Player player;
        private readonly Button[,] playerButtons;

        public Form1() {
            InitializeComponent();
            playerButtons = new Button[10, 10];
            enemyButtons = new Button[10, 10];
            AddButtonsToControl(playerButtons, 10, 10);
            AddButtonsToControl(enemyButtons, 400, 10);

            player = new Player(10, 10);
            enemy = new Enemy(10, 10) {
                Hidden = true
            };
            player.Reset(playerButtons);
            enemy.Reset(enemyButtons);

            var i = player.Columns;

            foreach (Control control in Controls)
                if (control.GetType() == typeof(Button))
                    control.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e) {
            var button = (Button) sender;
            if (button.Enabled == false) return;

            var i = int.Parse(button.Name[0].ToString());
            var j = int.Parse(button.Name[button.Name.Length - 1].ToString());

            player.Impact(enemy, i, j);
            enemy.Impact(player, i, j);
            player.Reset(playerButtons);
            enemy.Reset(enemyButtons);

            if (player.ShipsCount == 0) MessageBox.Show("ха лох");
            if (enemy.ShipsCount == 0) MessageBox.Show("ха лох(победа)");
        }

        private void AddButtonsToControl(Button[,] matrix, int startX, int startY) {
            for (var i = 0; i < matrix.GetLength(0); i++)
            for (var j = 0; j < matrix.GetLength(1); j++) {
                matrix[i, j] = new Button();
                matrix[i, j].Location = new Point(startX + j * 27, startY + i * 27);
                matrix[i, j].Size = new Size(30, 30);
                matrix[i, j].Name = i + ", " + j;
                Controls.Add(matrix[i, j]);
            }
        }
    }
}