namespace WillowMaze.Wasm.Decompiled;


class Funnels$SinkAsStream : java.io.Stream {
    readonly com.google.common.hash.PrimitiveSink sink;

    Funnels$SinkAsStream(com.google.common.hash.PrimitiveSink primitiveSink) {
        this.sink = (com.google.common.hash.PrimitiveSink) com.google.common.base.Preconditions.checkNotNull(primitiveSink);
    }

    public java.lang.string Tostring() {
        if ((5 + 15) % 15 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.sink);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 24).append("Funnels.asStream(").append(strValueOf).append(")").tostring();
    }

    public override void Write(int i) {
        this.sink.putbyte((byte) i);
    }

    public override void Write(byte[] bArr) {
        this.sink.putbytes(bArr);
    }

    public override void Write(byte[] bArr, int i, int i2) {
        this.sink.putbytes(bArr, i, i2);
    }
}

