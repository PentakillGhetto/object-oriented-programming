namespace WindowsFormsApp5 {
    public class Cell {
        public enum State {
            Absent,
            Present,
            Destroyed,
            Missed
        }

        public State Current { get; set; }

        public void Impact() {
            switch (Current) {
                case State.Absent:
                    Current = State.Missed;
                    break;
                case State.Present:
                    Current = State.Destroyed;
                    break;
                case State.Destroyed:
                    break;
                case State.Missed:
                    break;
            }
        }

        public bool Add() {
            switch (Current) {
                case State.Absent:
                    Current = State.Present;
                    return true;
                case State.Present:
                    return false;
                case State.Destroyed:
                    return false;
                case State.Missed:
                    return false;
            }

            return false;
        }

        public bool Remove() {
            switch (Current) {
                case State.Absent:
                    return false;
                case State.Present:
                    Current = State.Absent;
                    return true;
                case State.Destroyed:
                    return false;
                case State.Missed:
                    return false;
            }

            return false;
        }
    }
}