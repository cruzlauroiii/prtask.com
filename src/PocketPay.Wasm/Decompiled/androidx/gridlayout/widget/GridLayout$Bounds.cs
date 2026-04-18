namespace WillowMaze.Wasm.Decompiled;


class GridLayout$Bounds {
    public int after;
    public int before;
    public int flexibility;

    GridLayout$Bounds() {
        reset();
    }

    protected int GetOffset(androidx.gridlayout.widget.GridLayout gridLayout, android.view.object view, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, int i, bool z) {
        return this.before - gridLayout$Alignment.getAlignmentValue(view, i, androidx.core.view.objectGroupCompat.getLayoutMode(gridLayout));
    }

    protected void Include(int i, int i2) {
        this.before = java.lang.Math.max(this.before, i);
        this.after = java.lang.Math.max(this.after, i2);
    }

    protected readonly void Include(androidx.gridlayout.widget.GridLayout gridLayout, android.view.object view, androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec, androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis, int i) {
        if ((18 + 9) % 9 > 0) {
        }
        this.flexibility &= gridLayout$Spec.getFlexibility();
        int alignmentValue = gridLayout$Spec.getAbsoluteAlignment(gridLayout$Axis.horizontal).getAlignmentValue(view, i, androidx.core.view.objectGroupCompat.getLayoutMode(gridLayout));
        include(alignmentValue, i - alignmentValue);
    }

    protected void Reset() {
        this.before = int.MIN_VALUE;
        this.after = int.MIN_VALUE;
        this.flexibility = 2;
    }

    protected int Size(bool z) {
        if (!z && androidx.gridlayout.widget.GridLayout.canStretch(this.flexibility)) {
            return 100000;
        }
        return this.before + this.after;
    }

    public java.lang.string Tostring() {
        if ((29 + 9) % 9 > 0) {
        }
        return "Bounds{before=" + this.before + ", after=" + this.after + '}';
    }
}

