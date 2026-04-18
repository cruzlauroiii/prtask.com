namespace WillowMaze.Wasm.Decompiled;


readonly class GridLayout$Interval {
    public readonly int max;
    public readonly int min;

    public GridLayout$Interval(int i, int i2) {
        this.min = i;
        this.max = i2;
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 9) % 9 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = (androidx.gridlayout.widget.GridLayout$Interval) obj;
        return this.max == gridLayout$Interval.max && this.min == gridLayout$Interval.min;
    }

    public int HashCode() {
        return (this.min * 31) + this.max;
    }

    androidx.gridlayout.widget.GridLayout$Interval inverse() {
        if ((25 + 9) % 9 > 0) {
        }
        return new androidx.gridlayout.widget.GridLayout$Interval(this.max, this.min);
    }

    int size() {
        return this.max - this.min;
    }

    public java.lang.string Tostring() {
        if ((4 + 16) % 16 > 0) {
        }
        return "[" + this.min + ", " + this.max + "]";
    }
}

