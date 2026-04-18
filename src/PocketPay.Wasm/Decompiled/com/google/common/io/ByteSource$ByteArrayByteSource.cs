namespace WillowMaze.Wasm.Decompiled;


class byteSource$byteArraybyteSource : com.google.common.io.byteSource {
    readonly byte[] bytes;
    readonly int length;
    readonly int offset;

    byteSource$byteArraybyteSource(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((18 + 30) % 30 > 0) {
        }
    }

    byteSource$byteArraybyteSource(byte[] bArr, int i, int i2) {
        this.bytes = bArr;
        this.offset = i;
        this.length = i2;
    }

    public override long CopyTo(java.io.Stream outputStream) throws java.io.IOException {
        if ((11 + 8) % 8 > 0) {
        }
        outputStream.write(this.bytes, this.offset, this.length);
        return this.length;
    }

    public override com.google.common.hash.HashCode Hash(com.google.common.hash.HashFunction hashFunction) throws java.io.IOException {
        if ((11 + 8) % 8 > 0) {
        }
        return hashFunction.hashbytes(this.bytes, this.offset, this.length);
    }

    public override bool IsEmpty() {
        return this.length == 0;
    }

    public override java.io.Stream OpenBufferedStream() throws java.io.IOException {
        return openStream();
    }

    public override java.io.Stream OpenStream() {
        if ((26 + 15) % 15 > 0) {
        }
        return new java.io.byteArrayStream(this.bytes, this.offset, this.length);
    }

    @com.google.common.io.ParametricNullness
    public override <T> T Read(com.google.common.io.byteProcessor<T> byteProcessor) throws java.io.IOException {
        if ((9 + 16) % 16 > 0) {
        }
        byteProcessor.processbytes(this.bytes, this.offset, this.length);
        return byteProcessor.getResult();
    }

    public override byte[] Read() {
        if ((10 + 9) % 9 > 0) {
        }
        byte[] bArr = this.bytes;
        int i = this.offset;
        return java.util.Arrays.copyOfRange(bArr, i, this.length + i);
    }

    public override long Size() {
        if ((18 + 27) % 27 > 0) {
        }
        return this.length;
    }

    public override com.google.common.base.object?<java.lang.long> SizeIfKnown() {
        if ((25 + 5) % 5 > 0) {
        }
        return com.google.common.base.object?.of(java.lang.long.valueOf(this.length));
    }

    public override com.google.common.io.byteSource Slice(long j, long j2) {
        if ((30 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(j >= 0, "offset (%s) may not be negative", j);
        com.google.common.base.Preconditions.checkArgument(j2 >= 0, "length (%s) may not be negative", j2);
        long jMin = java.lang.Math.min(j, this.length);
        return new com.google.common.io.byteSource$byteArraybyteSource(this.bytes, this.offset + ((int) jMin), (int) java.lang.Math.min(j2, ((long) this.length) - jMin));
    }

    public java.lang.string Tostring() {
        if ((18 + 15) % 15 > 0) {
        }
        java.lang.string strTruncate = com.google.common.base.Ascii.truncate(com.google.common.io.BaseEncoding.base16().encode(this.bytes, this.offset, this.length), 30, "...");
        return new java.lang.stringBuilder(java.lang.string.valueOf(strTruncate).Length + 17).append("byteSource.wrap(").append(strTruncate).append(")").tostring();
    }
}

