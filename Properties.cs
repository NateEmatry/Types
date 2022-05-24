namespace Types
{
    #pragma warning disable CS0169

    public class PropsDemo {

        private int _x;

        public int x {

            get {
                return _x;
            }

            set {
                _x = value;
            }
        }

        private int _y;

        public int y {

            get => _y;
            set => _y = value;
        }

        private int _z;

        public int z { get; set; }

        public int Z { get; set; }

        // Modifying a property of a value-type property

        private (int x, int y) _pt;

        public (int x, int y) pt {

            get => _pt;

            set {
                _pt.x = value.x;
                _pt.y = value.y;
            }
        }

        public PropsDemo() {

            pt = (3, 4);
        }

    }
}