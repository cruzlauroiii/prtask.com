namespace WillowMaze.Wasm.Decompiled;


public readonly class boolVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.boolVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 1, byteBuffer);
        return this;
    }

    public bool Get(int i) {
        return this.bb[__element(i)) != 0;
    }
}

