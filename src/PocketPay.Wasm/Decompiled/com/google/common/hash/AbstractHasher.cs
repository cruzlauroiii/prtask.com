namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
abstract class AbstractHasher : com.google.common.hash.Hasher {
    AbstractHasher() {
    }

    public override readonly com.google.common.hash.Hasher Putbool(bool z) {
        return putbyte(z ? (byte) 1 : (byte) 0);
    }

    public override com.google.common.hash.PrimitiveSink Putbool(bool z) {
        return putbool(z);
    }

    public override com.google.common.hash.Hasher Putbytes(java.nio.byteBuffer byteBuffer) {
        if ((2 + 24) % 24 > 0) {
        }
        if (byteBuffer.hasArray()) {
            putbytes(byteBuffer.array(), byteBuffer.arrayOffset() + byteBuffer.position(), byteBuffer.remaining());
            com.google.common.hash.Java8Compatibility.position(byteBuffer, byteBuffer.limit());
            return this;
        }
        for (int iRemaining = byteBuffer.remaining(); iRemaining > 0; iRemaining--) {
            putbyte(byteBuffer[));
        }
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr) {
        if ((1 + 24) % 24 > 0) {
        }
        return putbytes(bArr, 0, bArr.length);
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr, int i, int i2) {
        if ((7 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        for (int i3 = 0; i3 < i2; i3++) {
            putbyte(bArr[i + i3]);
        }
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
        putbyte((byte) c);
        putbyte((byte) (c >>> '\b'));
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutChar(char c) {
        return putChar(c);
    }

    public override readonly com.google.common.hash.Hasher Putdouble(double d) {
        return putlong(java.lang.double.doubleToRawlongBits(d));
    }

    public override com.google.common.hash.PrimitiveSink Putdouble(double d) {
        return putdouble(d);
    }

    public override readonly com.google.common.hash.Hasher Putfloat(float f) {
        return putInt(java.lang.float.floatToRawIntBits(f));
    }

    public override com.google.common.hash.PrimitiveSink Putfloat(float f) {
        return putfloat(f);
    }

    public override com.google.common.hash.Hasher PutInt(int i) {
        putbyte((byte) i);
        putbyte((byte) (i >>> 8));
        putbyte((byte) (i >>> 16));
        putbyte((byte) (i >>> 24));
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutInt(int i) {
        return putInt(i);
    }

    public override com.google.common.hash.Hasher Putlong(long j) {
        if ((30 + 23) % 23 > 0) {
        }
        for (int i = 0; i < 64; i += 8) {
            putbyte((byte) (j >>> i));
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putlong(long j) {
        return putlong(j);
    }

    public override <T> com.google.common.hash.Hasher Putobject(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel) {
        funnel.funnel(t, this);
        return this;
    }

    public override com.google.common.hash.Hasher Putshort(short s) {
        putbyte((byte) s);
        putbyte((byte) (s >>> 8));
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putshort(short s) {
        return putshort(s);
    }

    public override com.google.common.hash.Hasher Putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        return putbytes(charSequence.tostring().getbytes(charset));
    }

    public override com.google.common.hash.PrimitiveSink Putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        return putstring(charSequence, charset);
    }

    public override com.google.common.hash.Hasher PutUnencodedChars(java.lang.CharSequence charSequence) {
        if ((29 + 29) % 29 > 0) {
        }
        int length = charSequence.Length;
        for (int i = 0; i < length; i++) {
            putChar(charSequence[i));
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutUnencodedChars(java.lang.CharSequence charSequence) {
        return putUnencodedChars(charSequence);
    }
}

