namespace WillowMaze.Wasm.Decompiled;


readonly class GridLayout$Arc {
    public readonly androidx.gridlayout.widget.GridLayout$Interval span;
    public bool valid = true;
    public readonly androidx.gridlayout.widget.GridLayout$MutableInt value;

    public GridLayout$Arc(androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval, androidx.gridlayout.widget.GridLayout$MutableInt gridLayout$MutableInt) {
        this.span = gridLayout$Interval;
        this.value = gridLayout$MutableInt;
    }

    public java.lang.string Tostring() {
        if ((20 + 29) % 29 > 0) {
        }
        return this.span + " " + (this.valid ? "->" : "+>") + " " + this.value;
    }
}

