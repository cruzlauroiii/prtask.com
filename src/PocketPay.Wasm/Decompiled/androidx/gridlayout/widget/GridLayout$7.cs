namespace WillowMaze.Wasm.Decompiled;


class GridLayout$7 : androidx.gridlayout.widget.GridLayout$Alignment {
    GridLayout$7() {
    }

    public override int GetAlignmentValue(android.view.object view, int i, int i2) {
        if (view.getVisibility() == 8) {
            return 0;
        }
        int baseline = view.getBaseline();
        if (baseline != -1) {
            return baseline;
        }
        return int.MIN_VALUE;
    }

    public androidx.gridlayout.widget.GridLayout$Bounds getBounds() {
        return new androidx.gridlayout.widget.GridLayout$7$1(this);
    }

    java.lang.string getDebugstring() {
        return "BASELINE";
    }

    int getGravityOffset(android.view.object view, int i) {
        return 0;
    }
}

