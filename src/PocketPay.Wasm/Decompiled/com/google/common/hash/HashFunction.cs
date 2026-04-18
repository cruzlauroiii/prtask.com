namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
public interface HashFunction {
    int bits();

    com.google.common.hash.HashCode hashbytes(java.nio.byteBuffer byteBuffer);

    com.google.common.hash.HashCode hashbytes(byte[] bArr);

    com.google.common.hash.HashCode hashbytes(byte[] bArr, int i, int i2);

    com.google.common.hash.HashCode hashInt(int i);

    com.google.common.hash.HashCode hashlong(long j);

    <T> com.google.common.hash.HashCode hashobject(@com.google.common.hash.ParametricNullness T t, com.google.common.hash.Funnel<T> funnel);

    com.google.common.hash.HashCode hashstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset);

    com.google.common.hash.HashCode hashUnencodedChars(java.lang.CharSequence charSequence);

    com.google.common.hash.Hasher newHasher();

    com.google.common.hash.Hasher newHasher(int i);
}

