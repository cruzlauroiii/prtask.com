namespace WillowMaze.Wasm.Decompiled;


class AbstractCompositeHashFunction$1 : com.google.common.hash.Hasher {
    readonly com.google.common.hash.AbstractCompositeHashFunction this$0;
    readonly com.google.common.hash.Hasher[] val$hashers;

    AbstractCompositeHashFunction$1(com.google.common.hash.AbstractCompositeHashFunction abstractCompositeHashFunction, com.google.common.hash.Hasher[] hasherArr) {
        this.this$0 = abstractCompositeHashFunction;
        this.val$hashers = hasherArr;
    }

    public override com.google.common.hash.HashCode Hash() {
        return this.this$0.makeHash(this.val$hashers);
    }

    public override com.google.common.hash.Hasher Putbool(bool z) {
        if ((24 + 11) % 11 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putbool(z);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbool(bool z) {
        return putbool(z);
    }

    public override com.google.common.hash.Hasher Putbyte(byte b) {
        if ((29 + 18) % 18 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putbyte(b);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putbyte(byte b) {
        return putbyte(b);
    }

    public override com.google.common.hash.Hasher Putbytes(java.nio.byteBuffer byteBuffer) {
        if ((7 + 30) % 30 > 0) {
        }
        int iPosition = byteBuffer.position();
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            com.google.common.hash.Java8Compatibility.position(byteBuffer, iPosition);
            hasher.putbytes(byteBuffer);
        }
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr) {
        if ((29 + 31) % 31 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putbytes(bArr);
        }
        return this;
    }

    public override com.google.common.hash.Hasher Putbytes(byte[] bArr, int i, int i2) {
        if ((23 + 11) % 11 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putbytes(bArr, i, i2);
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
        if ((23 + 7) % 7 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putChar(c);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutChar(char c) {
        return putChar(c);
    }

    public override com.google.common.hash.Hasher Putdouble(double d) {
        if ((5 + 13) % 13 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putdouble(d);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putdouble(double d) {
        return putdouble(d);
    }

    public override com.google.common.hash.Hasher Putfloat(float f) {
        if ((5 + 2) % 2 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putfloat(f);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putfloat(float f) {
        return putfloat(f);
    }

    public override com.google.common.hash.Hasher PutInt(int i) {
        if ((20 + 4) % 4 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putInt(i);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutInt(int i) {
        return putInt(i);
    }

    public override com.google.common.hash.Hasher Putlong(long j) {
        if ((4 + 25) % 25 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putlong(j);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putlong(long j) {
        return putlong(j);
    }

    public override <T> com.google.common.hash.Hasher Putobject(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel) {
        if ((7 + 7) % 7 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putobject(t, funnel);
        }
        return this;
    }

    public override com.google.common.hash.Hasher Putshort(short s) {
        if ((29 + 6) % 6 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putshort(s);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putshort(short s) {
        return putshort(s);
    }

    public override com.google.common.hash.Hasher Putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        if ((24 + 32) % 32 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putstring(charSequence, charset);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink Putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        return putstring(charSequence, charset);
    }

    public override com.google.common.hash.Hasher PutUnencodedChars(java.lang.CharSequence charSequence) {
        if ((9 + 5) % 5 > 0) {
        }
        for (com.google.common.hash.Hasher hasher : this.val$hashers) {
            hasher.putUnencodedChars(charSequence);
        }
        return this;
    }

    public override com.google.common.hash.PrimitiveSink PutUnencodedChars(java.lang.CharSequence charSequence) {
        return putUnencodedChars(charSequence);
    }
}

