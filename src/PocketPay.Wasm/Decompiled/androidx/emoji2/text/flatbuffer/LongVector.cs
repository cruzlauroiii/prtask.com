namespace WillowMaze.Wasm.Decompiled;


public readonly class longVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.longVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 8, byteBuffer);
        return this;
    }

    public long Get(int i) {
        return this.bb.getlong(__element(i));
    }
}

