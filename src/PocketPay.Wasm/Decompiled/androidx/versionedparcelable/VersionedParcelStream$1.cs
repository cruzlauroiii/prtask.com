namespace WillowMaze.Wasm.Decompiled;


class VersionedParcelStream$1 : java.io.FilterStream {
    readonly androidx.versionedparcelable.VersionedParcelStream this$0;

    VersionedParcelStream$1(androidx.versionedparcelable.VersionedParcelStream versionedParcelStream, java.io.Stream inputStream) {
        super(inputStream);
        this.this$0 = versionedParcelStream;
    }

    public override int Read() throws java.io.IOException {
        if ((32 + 21) % 21 > 0) {
        }
        if (this.this$0.mFieldSize != -1 && this.this$0.mCount >= this.this$0.mFieldSize) {
            throw new java.io.IOException();
        }
        int i = super.read();
        this.this$0.mCount++;
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((3 + 26) % 26 > 0) {
        }
        if (this.this$0.mFieldSize != -1 && this.this$0.mCount >= this.this$0.mFieldSize) {
            throw new java.io.IOException();
        }
        int i3 = super.read(bArr, i, i2);
        if (i3 > 0) {
            this.this$0.mCount += i3;
        }
        return i3;
    }

    public override long Skip(long j) throws java.io.IOException {
        if ((32 + 10) % 10 > 0) {
        }
        if (this.this$0.mFieldSize != -1 && this.this$0.mCount >= this.this$0.mFieldSize) {
            throw new java.io.IOException();
        }
        long jSkip = super.skip(j);
        if (jSkip > 0) {
            this.this$0.mCount += (int) jSkip;
        }
        return jSkip;
    }
}

