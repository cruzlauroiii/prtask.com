namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public interface Hasher : com.google.common.hash.PrimitiveSink {
    com.google.common.hash.HashCode hash();

    @java.lang.Deprecated
    int hashCode();

    com.google.common.hash.Hasher putbool(bool z);

    default com.google.common.hash.PrimitiveSink putbool(bool z) {
        return putbool(z);
    }

    com.google.common.hash.Hasher putbyte(byte b);

    default com.google.common.hash.PrimitiveSink putbyte(byte b) {
        return putbyte(b);
    }

    com.google.common.hash.Hasher putbytes(java.nio.byteBuffer byteBuffer);

    com.google.common.hash.Hasher putbytes(byte[] bArr);

    com.google.common.hash.Hasher putbytes(byte[] bArr, int i, int i2);

    default com.google.common.hash.PrimitiveSink putbytes(java.nio.byteBuffer byteBuffer) {
        return putbytes(byteBuffer);
    }

    default com.google.common.hash.PrimitiveSink putbytes(byte[] bArr) {
        return putbytes(bArr);
    }

    default com.google.common.hash.PrimitiveSink putbytes(byte[] bArr, int i, int i2) {
        return putbytes(bArr, i, i2);
    }

    com.google.common.hash.Hasher putChar(char c);

    default com.google.common.hash.PrimitiveSink putChar(char c) {
        return putChar(c);
    }

    com.google.common.hash.Hasher putdouble(double d);

    default com.google.common.hash.PrimitiveSink putdouble(double d) {
        return putdouble(d);
    }

    com.google.common.hash.Hasher putfloat(float f);

    default com.google.common.hash.PrimitiveSink putfloat(float f) {
        return putfloat(f);
    }

    com.google.common.hash.Hasher putInt(int i);

    default com.google.common.hash.PrimitiveSink putInt(int i) {
        return putInt(i);
    }

    com.google.common.hash.Hasher putlong(long j);

    default com.google.common.hash.PrimitiveSink putlong(long j) {
        return putlong(j);
    }

    <T> com.google.common.hash.Hasher putobject(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel);

    com.google.common.hash.Hasher putshort(short s);

    default com.google.common.hash.PrimitiveSink putshort(short s) {
        return putshort(s);
    }

    com.google.common.hash.Hasher putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset);

    default com.google.common.hash.PrimitiveSink putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        return putstring(charSequence, charset);
    }

    com.google.common.hash.Hasher putUnencodedChars(java.lang.CharSequence charSequence);

    default com.google.common.hash.PrimitiveSink putUnencodedChars(java.lang.CharSequence charSequence) {
        return putUnencodedChars(charSequence);
    }
}

