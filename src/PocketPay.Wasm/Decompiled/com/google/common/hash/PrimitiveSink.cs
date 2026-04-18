namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public interface PrimitiveSink {
    com.google.common.hash.PrimitiveSink putbool(bool z);

    com.google.common.hash.PrimitiveSink putbyte(byte b);

    com.google.common.hash.PrimitiveSink putbytes(java.nio.byteBuffer byteBuffer);

    com.google.common.hash.PrimitiveSink putbytes(byte[] bArr);

    com.google.common.hash.PrimitiveSink putbytes(byte[] bArr, int i, int i2);

    com.google.common.hash.PrimitiveSink putChar(char c);

    com.google.common.hash.PrimitiveSink putdouble(double d);

    com.google.common.hash.PrimitiveSink putfloat(float f);

    com.google.common.hash.PrimitiveSink putInt(int i);

    com.google.common.hash.PrimitiveSink putlong(long j);

    com.google.common.hash.PrimitiveSink putshort(short s);

    com.google.common.hash.PrimitiveSink putstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset);

    com.google.common.hash.PrimitiveSink putUnencodedChars(java.lang.CharSequence charSequence);
}

