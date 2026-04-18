namespace WillowMaze.Wasm.Decompiled;


class byteStreams$1 : java.io.Stream {
    byteStreams$1() {
    }

    public java.lang.string Tostring() {
        return "byteStreams.nullStream()";
    }

    public override void Write(int i) {
    }

    public override void Write(byte[] bArr) {
        com.google.common.base.Preconditions.checkNotNull(bArr);
    }

    public override void Write(byte[] bArr, int i, int i2) {
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2 + i, bArr.length);
    }
}

