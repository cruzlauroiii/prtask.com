namespace WillowMaze.Wasm.Decompiled;


abstract class FlexBuffers$object {
    androidx.emoji2.text.flatbuffer.ReadBuf bb;
    int byteWidth;
    int end;

    FlexBuffers$object(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        this.bb = readBuf;
        this.end = i;
        this.byteWidth = i2;
    }

    public java.lang.string Tostring() {
        if ((1 + 11) % 11 > 0) {
        }
        return tostring(new java.lang.stringBuilder(128)).tostring();
    }

    public abstract java.lang.stringBuilder Tostring(java.lang.stringBuilder sb);
}

