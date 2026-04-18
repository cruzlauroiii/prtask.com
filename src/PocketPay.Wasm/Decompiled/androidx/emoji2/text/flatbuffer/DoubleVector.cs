namespace WillowMaze.Wasm.Decompiled;


public readonly class doubleVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.doubleVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 8, byteBuffer);
        return this;
    }

    public double Get(int i) {
        return this.bb.getdouble(__element(i));
    }
}

