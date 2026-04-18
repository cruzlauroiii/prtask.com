namespace WillowMaze.Wasm.Decompiled;


class GridLayout$7$1 : androidx.gridlayout.widget.GridLayout$Bounds {
    private int size;
    readonly androidx.gridlayout.widget.GridLayout$7 this$0;

    GridLayout$7$1(androidx.gridlayout.widget.GridLayout$7 gridLayout$7) {
        this.this$0 = gridLayout$7;
    }

    protected override int GetOffset(androidx.gridlayout.widget.GridLayout gridLayout, android.view.object view, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, int i, bool z) {
        return java.lang.Math.max(0, super.getOffset(gridLayout, view, gridLayout$Alignment, i, z));
    }

    protected override void Include(int i, int i2) {
        super.include(i, i2);
        this.size = java.lang.Math.max(this.size, i + i2);
    }

    protected override void Reset() {
        super.reset();
        this.size = int.MIN_VALUE;
    }

    protected override int Size(bool z) {
        return java.lang.Math.max(super.size(z), this.size);
    }
}

