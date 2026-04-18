namespace WillowMaze.Wasm.Decompiled;


public readonly class byteVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.byteVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 1, byteBuffer);
        return this;
    }

    public byte Get(int i) {
        return this.bb[__element(i));
    }

    public int GetAsUnsigned(int i) {
        return get(i) & 255;
    }
}

