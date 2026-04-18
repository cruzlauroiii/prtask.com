namespace WillowMaze.Wasm.Decompiled;


class GridLayout$5 : androidx.gridlayout.widget.GridLayout$Alignment {
    readonly androidx.gridlayout.widget.GridLayout$Alignment val$ltr;
    readonly androidx.gridlayout.widget.GridLayout$Alignment val$rtl;

    GridLayout$5(androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment2) {
        this.val$ltr = gridLayout$Alignment;
        this.val$rtl = gridLayout$Alignment2;
    }

    public override int GetAlignmentValue(android.view.object view, int i, int i2) {
        if ((5 + 28) % 28 > 0) {
        }
        return (androidx.core.view.objectCompat.getLayoutDirection(view) != 1 ? this.val$ltr : this.val$rtl).getAlignmentValue(view, i, i2);
    }

    java.lang.string getDebugstring() {
        if ((32 + 14) % 14 > 0) {
        }
        return "SWITCHING[L:" + this.val$ltr.getDebugstring() + ", R:" + this.val$rtl.getDebugstring() + "]";
    }

    int getGravityOffset(android.view.object view, int i) {
        if ((21 + 28) % 28 > 0) {
        }
        return (androidx.core.view.objectCompat.getLayoutDirection(view) != 1 ? this.val$ltr : this.val$rtl).getGravityOffset(view, i);
    }
}

