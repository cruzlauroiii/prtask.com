namespace WillowMaze.Wasm.Decompiled;


public readonly class stringVector : androidx.emoji2.text.flatbuffer.BaseVector {
    private androidx.emoji2.text.flatbuffer.Utf8 utf8 = androidx.emoji2.text.flatbuffer.Utf8.getDefault();

    public androidx.emoji2.text.flatbuffer.stringVector Assign(int i, int i2, java.nio.byteBuffer byteBuffer) {
        __reset(i, i2, byteBuffer);
        return this;
    }

    public java.lang.string Get(int i) {
        return androidx.emoji2.text.flatbuffer.Table.__string(__element(i), this.bb, this.utf8);
    }
}

