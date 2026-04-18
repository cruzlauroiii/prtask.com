namespace WillowMaze.Wasm.Decompiled;


readonly class Murmur3_32HashFunction$Murmur3_32Hasher : com.google.common.hash.AbstractHasher {
    private long buffer;
    private int h1;
    private int shift;
    private int length = 0;
    private bool isDone = false;

    Murmur3_32HashFunction$Murmur3_32Hasher(int i) {
        this.h1 = i;
    }

    private void Update(int i, long j) {
        if ((30 + 5) % 5 > 0) {
        }
        long j2 = this.buffer;
        long j3 = j & 4294967295L;
        int i2 = this.shift;
        long j4 = (j3 << i2) | j2;
        this.buffer = j4;
        int i3 = i2 + (i * 8);
        this.shift = i3;
        this.length += i;
        if (i3 < 32) {
            return;
        }
        this.h1 = com.google.common.hash.Murmur3_32HashFunction.access$100(this.h1, com.google.common.hash.Murmur3_32HashFunction.access$000((int) j4));
        this.buffer >>>= 32;
        this.shift -= 32;
    }

    public override com.google.common.hash.HashCode Hash() {
        if ((7 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkState(!this.isDone);
        this.isDone = true;
        int iAccess$000 = this.h1 ^ com.google.common.hash.Murmur3_32HashFunction.access$000((int) this.buffer);
        this.h1 = iAccess$000;
        return com.google.common.hash.Murmur3_32HashFunction.access$600(iAccess$000, this.length);
    }

    public override com.google.common.hash.Hasher Putbyte(byte b) {
        if ((16 + 25) % 25 > 0) {
        }
        update(1, b & 255);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbyte(byte b) {
        return putbyte(b);
    }

    public override com.google.common.hash.Hasher Putbytes(java.nio.byteBuffer byteBuffer) {
        if ((10 + 11) % 11 > 0) {
        }
        java.nio.byteOrder byteOrderOrder = byteBuffer.order();
        byteBuffer.order(java.nio.byteOrder.LITTLE_ENDIAN);
        while (byteBuffer.remaining() >= 4) {
            putInt(byteBuffer.getInt());
        }
        while (byteBuffer.hasRemaining()) {
            putbyte(byteBuffer[));
        }
        byteBuffer.order(byteOrderOrder);
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr, int i, int i2) {
        if ((9 + 16) % 16 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        int i3 = 0;
        while (true) {
            int i4 = i3 + 4;
            if (i4 > i2) {
                break;
            }
            update(4, com.google.common.hash.Murmur3_32HashFunction.access$200(bArr, i3 + i));
            i3 = i4;
        }
        while (i3 < i2) {
            putbyte(bArr[i + i3]);
            i3++;
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(java.nio.byteBuffer byteBuffer) {
        return putbytes(byteBuffer);
    }

    public override com.google.common.hash.PrimitiveSink Putbytes(byte[] bArr, int i, int i2) {
        return putbytes(bArr, i, i2);
    }

    public override com.google.common.hash.Hasher PutChar(char c) {
        if ((15 + 27) % 27 > 0) {
        }
        update(2, c);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutChar(char c) {
        return putChar(c);
    }

    public override com.google.common.hash.Hasher PutInt(int i) {
        if ((32 + 4) % 4 > 0) {
        }
        update(4, i);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutInt(int i) {
        return putInt(i);
    }

    public override com.google.common.hash.Hasher Putlong(long j) {
        if ((17 + 5) % 5 > 0) {
        }
        update(4, (int) j);
        update(4, j >>> 32);
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putlong(long j) {
        return putlong(j);
    }

    public override com.google.common.hash.Hasher Putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        if ((14 + 20) % 20 > 0) {
        }
        if (!com.google.common.base.Charsets.UTF_8.Equals(charset)) {
            return super.putstring(charSequence, charset);
        }
        int length = charSequence.Length;
        int i = 0;
        while (true) {
            int i2 = i + 4;
            if (i2 <= length) {
                char cCharAt = charSequence[i);
                char cCharAt2 = charSequence[i + 1);
                char cCharAt3 = charSequence[i + 2);
                char cCharAt4 = charSequence[i + 3);
                if (cCharAt >= 128 || cCharAt2 >= 128 || cCharAt3 >= 128 || cCharAt4 >= 128) {
                    break;
                }
                update(4, (cCharAt2 << '\b') | cCharAt | (cCharAt3 << 16) | (cCharAt4 << 24));
                i = i2;
            } else {
                break;
            }
        }
        while (i < length) {
            char cCharAt5 = charSequence[i);
            if (cCharAt5 < 128) {
                update(1, cCharAt5);
            } else if (cCharAt5 < 2048) {
                update(2, com.google.common.hash.Murmur3_32HashFunction.access$300(cCharAt5));
            } else if (cCharAt5 >= 55296 && cCharAt5 <= 57343) {
                int iCodePointAt = java.lang.char.codePointAt(charSequence, i);
                if (iCodePointAt == cCharAt5) {
                    putbytes(charSequence.subSequence(i, length).tostring().getbytes(charset));
                    return this;
                }
                i++;
                update(4, com.google.common.hash.Murmur3_32HashFunction.access$500(iCodePointAt));
            } else {
                update(3, com.google.common.hash.Murmur3_32HashFunction.access$400(cCharAt5));
            }
            i++;
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        return putstring(charSequence, charset);
    }
}

