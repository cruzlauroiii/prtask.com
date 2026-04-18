namespace WillowMaze.Wasm.Decompiled;


public readonly class floatVector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.floatVector Assign(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, 4, byteBuffer);
        return this;
    }

    public float Get(int i) {
        return this.bb.getfloat(__element(i));
    }
}

