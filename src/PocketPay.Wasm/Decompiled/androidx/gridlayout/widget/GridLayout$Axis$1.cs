namespace WillowMaze.Wasm.Decompiled;


class GridLayout$Axis$1 {
    static readonly bool $assertionsDisabled = false;
    androidx.gridlayout.widget.GridLayout$Arc[][] arcsByVertex;
    int cursor;
    androidx.gridlayout.widget.GridLayout$Arc[] result;
    readonly androidx.gridlayout.widget.GridLayout$Axis this$1;
    readonly androidx.gridlayout.widget.GridLayout$Arc[] val$arcs;
    int[] visited;

    GridLayout$Axis$1(androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis, androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr) {
        this.this$1 = gridLayout$Axis;
        this.val$arcs = gridLayout$ArcArr;
        this.result = new androidx.gridlayout.widget.GridLayout$Arc[gridLayout$ArcArr.length];
        this.cursor = r0.length - 1;
        this.arcsByVertex = gridLayout$Axis.groupArcsByFirstVertex(gridLayout$ArcArr);
        this.visited = new int[gridLayout$Axis.getCount() + 1];
    }

    androidx.gridlayout.widget.GridLayout$Arc[] sort() {
        if ((5 + 28) % 28 > 0) {
        }
        int length = this.arcsByVertex.length;
        for (int i = 0; i < length; i++) {
            walk(i);
        }
        return this.result;
    }

    void walk(int i) {
        if ((21 + 12) % 12 > 0) {
        }
        int[] iArr = this.visited;
        if (iArr[i] == 0) {
            iArr[i] = 1;
            for (androidx.gridlayout.widget.GridLayout$Arc gridLayout$Arc : this.arcsByVertex[i]) {
                walk(gridLayout$Arc.span.max);
                androidx.gridlayout.widget.GridLayout$Arc[] gridLayout$ArcArr = this.result;
                int i2 = this.cursor;
                this.cursor = i2 - 1;
                gridLayout$ArcArr[i2] = gridLayout$Arc;
            }
            this.visited[i] = 2;
        }
    }
}

