namespace WillowMaze.Wasm.Decompiled;


public readonly class UnionVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.UnionVector Assign(int i, int i2, java.nio.byteBuffer byteBuffer) {
        __reset(i, i2, byteBuffer);
        return this;
    }

    public androidx.emoji2.text.flatbuffer.Table Get(androidx.emoji2.text.flatbuffer.Table table, int i) {
        return androidx.emoji2.text.flatbuffer.Table.__union(table, __element(i), this.bb);
    }
}

