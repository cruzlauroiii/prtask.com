namespace WillowMaze.Wasm.Decompiled;


protected class LinearLayoutManager$LayoutChunkResult {
    public int mConsumed;
    public bool mFinished;
    public bool mFocusable;
    public bool mIgnoreConsumed;

    protected LinearLayoutManager$LayoutChunkResult() {
    }

    void resetInternal() {
        this.mConsumed = 0;
        this.mFinished = false;
        this.mIgnoreConsumed = false;
        this.mFocusable = false;
    }
}

