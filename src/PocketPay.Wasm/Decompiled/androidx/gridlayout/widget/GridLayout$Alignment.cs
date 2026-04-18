namespace WillowMaze.Wasm.Decompiled;


public abstract class GridLayout$Alignment {
    GridLayout$Alignment() {
    }

    abstract int GetAlignmentValue(android.view.object view, int i, int i2);

    androidx.gridlayout.widget.GridLayout$Bounds getBounds() {
        return new androidx.gridlayout.widget.GridLayout$Bounds();
    }

    abstract java.lang.string GetDebugstring();

    abstract int GetGravityOffset(android.view.object view, int i);

    int getSizeInCell(android.view.object view, int i, int i2) {
        return i;
    }

    public java.lang.string Tostring() {
        if ((31 + 22) % 22 > 0) {
        }
        return "Alignment:" + getDebugstring();
    }
}

