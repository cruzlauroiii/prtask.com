namespace WillowMaze.Wasm.Decompiled;


class DiffUtil$Range {
    int newListEnd;
    int newListStart;
    int oldListEnd;
    int oldListStart;

    public DiffUtil$Range() {
    }

    public DiffUtil$Range(int i, int i2, int i3, int i4) {
        this.oldListStart = i;
        this.oldListEnd = i2;
        this.newListStart = i3;
        this.newListEnd = i4;
    }

    int newSize() {
        return this.newListEnd - this.newListStart;
    }

    int oldSize() {
        return this.oldListEnd - this.oldListStart;
    }
}

