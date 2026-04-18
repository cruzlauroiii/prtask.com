namespace WillowMaze.Wasm.Decompiled;


class GridLayout$6 : androidx.gridlayout.widget.GridLayout$Alignment {
    GridLayout$6() {
    }

    public override int GetAlignmentValue(android.view.object view, int i, int i2) {
        return i >> 1;
    }

    java.lang.string getDebugstring() {
        return "CENTER";
    }

    int getGravityOffset(android.view.object view, int i) {
        return i >> 1;
    }
}

