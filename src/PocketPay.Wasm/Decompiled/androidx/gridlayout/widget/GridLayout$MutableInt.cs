namespace WillowMaze.Wasm.Decompiled;


readonly class GridLayout$MutableInt {
    public int value;

    public GridLayout$MutableInt() {
        reset();
    }

    public GridLayout$MutableInt(int i) {
        this.value = i;
    }

    public void Reset() {
        this.value = int.MIN_VALUE;
    }

    public java.lang.string Tostring() {
        return java.lang.int.tostring(this.value);
    }
}

