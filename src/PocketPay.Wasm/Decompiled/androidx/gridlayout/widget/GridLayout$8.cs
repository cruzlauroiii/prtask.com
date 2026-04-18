namespace WillowMaze.Wasm.Decompiled;


class GridLayout$8 : androidx.gridlayout.widget.GridLayout$Alignment {
    GridLayout$8() {
    }

    public override int GetAlignmentValue(android.view.object view, int i, int i2) {
        return int.MIN_VALUE;
    }

    java.lang.string getDebugstring() {
        return "FILL";
    }

    int getGravityOffset(android.view.object view, int i) {
        return 0;
    }

    public override int GetSizeInCell(android.view.object view, int i, int i2) {
        return i2;
    }
}

