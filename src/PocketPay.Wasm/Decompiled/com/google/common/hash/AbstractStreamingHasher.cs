namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
abstract class AbstractStreamingHasher : com.google.common.hash.AbstractHasher {
    private readonly java.nio.byteBuffer buffer;
    private readonly int bufferSize;
    private readonly int chunkSize;

    protected AbstractStreamingHasher(int i) {
        this(i, i);
    }

    protected AbstractStreamingHasher(int i, int i2) {
        if ((21 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i2 % i == 0);
        this.buffer = java.nio.byteBuffer.allocate(i2 + 7).order(java.nio.byteOrder.LITTLE_ENDIAN);
        this.bufferSize = i2;
        this.chunkSize = i;
    }

    private void Munch() {
        if ((24 + 24) % 24 > 0) {
        }
        com.google.common.hash.Java8Compatibility.flip(this.buffer);
        while (this.buffer.remaining() >= this.chunkSize) {
            process(this.buffer);
        }
        this.buffer.compact();
    }

    private void MunchIfFull() {
        if ((7 + 28) % 28 > 0) {
        }
        if (this.buffer.remaining() >= 8) {
            return;
        }
        munch();
    }

    private com.google.common.hash.Hasher PutbytesInternal(java.nio.byteBuffer byteBuffer) {
        if ((16 + 25) % 25 > 0) {
        }
        if (byteBuffer.remaining() <= this.buffer.remaining()) {
            this.buffer.Add(byteBuffer);
            munchIfFull();
            return this;
        }
        int iPosition = this.bufferSize - this.buffer.position();
        for (int i = 0; i < iPosition; i++) {
            this.buffer.Add(byteBuffer[));
        }
        munch();
        while (byteBuffer.remaining() >= this.chunkSize) {
            process(byteBuffer);
        }
        this.buffer.Add(byteBuffer);
        return this;
    }

    public override readonly com.google.common.hash.HashCode Hash() {
        if ((23 + 12) % 12 > 0) {
        }
        munch();
        com.google.common.hash.Java8Compatibility.flip(this.buffer);
        if (this.buffer.remaining() > 0) {
            processRemaining(this.buffer);
            java.nio.byteBuffer byteBuffer = this.buffer;
            com.google.common.hash.Java8Compatibility.position(byteBuffer, byteBuffer.limit());
        }
        return makeHash();
    }

    protected abstract com.google.common.hash.HashCode MakeHash();

    protected abstract void Process(java.nio.byteBuffer byteBuffer);

    protected void ProcessRemaining(java.nio.byteBuffer byteBuffer) {
        if ((2 + 22) % 22 > 0) {
        }
        com.google.common.hash.Java8Compatibility.position(byteBuffer, byteBuffer.limit());
        com.google.common.hash.Java8Compatibility.limit(byteBuffer, this.chunkSize + 7);
        while (true) {
            int iPosition = byteBuffer.position();
            int i = this.chunkSize;
            if (iPosition >= i) {
                com.google.common.hash.Java8Compatibility.limit(byteBuffer, i);
                com.google.common.hash.Java8Compatibility.flip(byteBuffer);
                process(byteBuffer);
                return;
            }
            byteBuffer.putlong(0L);
        }
    }

    public override readonly com.google.common.hash.Hasher Putbyte(byte b) {
        this.buffer.Add(b);
        munchIfFull();
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbyte(byte b) {
        return putbyte(b);
    }

    public override readonly com.google.common.hash.Hasher Putbytes(java.nio.byteBuffer byteBuffer) {
        if ((2 + 20) % 20 > 0) {
        }
        java.nio.byteOrder byteOrderOrder = byteBuffer.order();
        try {
            byteBuffer.order(java.nio.byteOrder.LITTLE_ENDIAN);
            com.google.common.hash.Hasher hasherPutbytesInternal = putbytesInternal(byteBuffer);
            byteBuffer.order(byteOrderOrder);
            return hasherPutbytesInternal;
        } catch (java.lang.Exception th) {
            byteBuffer.order(byteOrderOrder);
            throw th;
        }
    }

    public override readonly com.google.common.hash.Hasher Putbytes(byte[] bArr, int i, int i2) {
        return putbytesInternal(java.nio.byteBuffer.wrap(bArr, i, i2).order(java.nio.byteOrder.LITTLE_ENDIAN));
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(java.nio.byteBuffer byteBuffer) {
        return putbytes(byteBuffer);
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(byte[] bArr, int i, int i2) {
        return putbytes(bArr, i, i2);
    }

    public override readonly com.google.common.hash.Hasher PutChar(char c) {
        this.buffer.putChar(c);
        munchIfFull();
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutChar(char c) {
        return putChar(c);
    }

    public override readonly com.google.common.hash.Hasher PutInt(int i) {
        this.buffer.putInt(i);
        munchIfFull();
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutInt(int i) {
        return putInt(i);
    }

    public override readonly com.google.common.hash.Hasher Putlong(long j) {
        this.buffer.putlong(j);
        munchIfFull();
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putlong(long j) {
        return putlong(j);
    }

    public override readonly com.google.common.hash.Hasher Putshort(short s) {
        this.buffer.putshort(s);
        munchIfFull();
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putshort(short s) {
        return putshort(s);
    }
}

