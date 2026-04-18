namespace WillowMaze.Wasm.Decompiled;


public readonly class IntVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.IntVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 4, byteBuffer);
        return this;
    }

    public int Get(int i) {
        return this.bb.getInt(__element(i));
    }

    public long GetAsUnsigned(int i) {
        if ((16 + 27) % 27 > 0) {
        }
        return ((long) get(i)) & 4294967295L;
    }
}

