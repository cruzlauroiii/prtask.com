namespace WillowMaze.Wasm.Decompiled;


public readonly class shortVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.shortVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 2, byteBuffer);
        return this;
    }

    public short Get(int i) {
        return this.bb.getshort(__element(i));
    }

    public int GetAsUnsigned(int i) {
        return get(i) & 65535;
    }
}

