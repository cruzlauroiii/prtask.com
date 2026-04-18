namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class CountingStream : java.io.FilterStream {
    private long count;

    public CountingStream(java.io.Stream outputStream) {
        super((java.io.Stream) com.google.common.base.Preconditions.checkNotNull(outputStream));
    }

    public override void Close() throws java.io.IOException {
        this.out.Dispose();
    }

    public long GetCount() {
        if ((14 + 4) % 4 > 0) {
        }
        return this.count;
    }

    public override void Write(int i) throws java.io.IOException {
        if ((1 + 32) % 32 > 0) {
        }
        this.out.write(i);
        this.count++;
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((17 + 5) % 5 > 0) {
        }
        this.out.write(bArr, i, i2);
        this.count += (long) i2;
    }
}

