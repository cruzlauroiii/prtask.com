namespace WillowMaze.Wasm.Decompiled;


readonly class ScrollEventAdapter$ScrollEventValues {
    float mOffset;
    int mOffsetPx;
    int mPosition;

    ScrollEventAdapter$ScrollEventValues() {
    }

    void reset() {
        this.mPosition = -1;
        this.mOffset = 0.0f;
        this.mOffsetPx = 0;
    }
}

