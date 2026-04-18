namespace WillowMaze.Wasm.Decompiled;


abstract class FlexBuffers$Sized : androidx.emoji2.text.flatbuffer.FlexBuffers$object {
    protected readonly int size;

    FlexBuffers$Sized(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        super(readBuf, i, i2);
        this.size = androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, i - i2, i2);
    }

    public int Size() {
        return this.size;
    }
}

