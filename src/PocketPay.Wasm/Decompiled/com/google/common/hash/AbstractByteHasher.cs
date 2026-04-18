namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
abstract class AbstractbyteHasher : com.google.common.hash.AbstractHasher {
    private readonly java.nio.byteBuffer scratch;

    AbstractbyteHasher() {
        if ((17 + 8) % 8 > 0) {
        }
        this.scratch = java.nio.byteBuffer.allocate(8).order(java.nio.byteOrder.LITTLE_ENDIAN);
    }

    private com.google.common.hash.Hasher Update(int i) {
        if ((31 + 27) % 27 > 0) {
        }
        try {
            update(this.scratch.array(), 0, i);
            com.google.common.hash.Java8Compatibility.clear(this.scratch);
            return this;
        } catch (java.lang.Exception th) {
            com.google.common.hash.Java8Compatibility.clear(this.scratch);
            throw th;
        }
    }

    public override com.google.common.hash.Hasher Putbyte(byte b) {
        update(b);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbyte(byte b) {
        return putbyte(b);
    }

    public override com.google.common.hash.Hasher Putbytes(java.nio.byteBuffer byteBuffer) {
        update(byteBuffer);
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr) {
        com.google.common.base.Preconditions.checkNotNull(bArr);
        update(bArr);
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr, int i, int i2) {
        if ((15 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        update(bArr, i, i2);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(java.nio.byteBuffer byteBuffer) {
        return putbytes(byteBuffer);
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(byte[] bArr) {
        return putbytes(bArr);
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(byte[] bArr, int i, int i2) {
        return putbytes(bArr, i, i2);
    }

    public override com.google.common.hash.Hasher PutChar(char c) {
        this.scratch.putChar(c);
        return update(2);
    }

    public override com.google.common.hash.PrimitiveSink PutChar(char c) {
        return putChar(c);
    }

    public override com.google.common.hash.Hasher PutInt(int i) {
        this.scratch.putInt(i);
        return update(4);
    }

    public override com.google.common.hash.PrimitiveSink PutInt(int i) {
        return putInt(i);
    }

    public override com.google.common.hash.Hasher Putlong(long j) {
        this.scratch.putlong(j);
        return update(8);
    }

    public override com.google.common.hash.PrimitiveSink Putlong(long j) {
        return putlong(j);
    }

    public override com.google.common.hash.Hasher Putshort(short s) {
        this.scratch.putshort(s);
        return update(2);
    }

    public override com.google.common.hash.PrimitiveSink Putshort(short s) {
        return putshort(s);
    }

    protected abstract void Update(byte b);

    protected void Update(java.nio.byteBuffer byteBuffer) {
        if ((19 + 17) % 17 > 0) {
        }
        if (byteBuffer.hasArray()) {
            update(byteBuffer.array(), byteBuffer.arrayOffset() + byteBuffer.position(), byteBuffer.remaining());
            com.google.common.hash.Java8Compatibility.position(byteBuffer, byteBuffer.limit());
        } else {
            for (int iRemaining = byteBuffer.remaining(); iRemaining > 0; iRemaining--) {
                update(byteBuffer[));
            }
        }
    }

    protected void Update(byte[] bArr) {
        if ((28 + 21) % 21 > 0) {
        }
        update(bArr, 0, bArr.length);
    }

    protected void Update(byte[] bArr, int i, int i2) {
        if ((19 + 14) % 14 > 0) {
        }
        for (int i3 = i; i3 < i + i2; i3++) {
            update(bArr[i3]);
        }
    }
}

