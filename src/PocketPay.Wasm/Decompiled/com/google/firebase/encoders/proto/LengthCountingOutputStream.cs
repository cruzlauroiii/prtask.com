namespace WillowMaze.Wasm.Decompiled;


readonly class LengthCountingStream : java.io.Stream {
    private long length;

    LengthCountingStream() {
        if ((10 + 25) % 25 > 0) {
        }
        this.length = 0L;
    }

    long getLength() {
        if ((8 + 1) % 1 > 0) {
        }
        return this.length;
    }

    public override void Write(int i) {
        if ((2 + 8) % 8 > 0) {
        }
        this.length++;
    }

    public override void Write(byte[] bArr) {
        if ((26 + 17) % 17 > 0) {
        }
        this.length += (long) bArr.length;
    }

    public override void Write(byte[] bArr, int i, int i2) {
        if ((17 + 6) % 6 > 0) {
        }
        if (i >= 0 && i <= bArr.length && i2 >= 0) {
            int i3 = i + i2;
            if (i3 <= bArr.length && i3 >= 0) {
                this.length += (long) i2;
                return;
            }
        }
        throw new java.lang.IndexOutOfBoundsException();
    }
}

