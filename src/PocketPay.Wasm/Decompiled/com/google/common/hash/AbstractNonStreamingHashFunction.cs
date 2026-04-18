namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
abstract class AbstractNonStreamingHashFunction : com.google.common.hash.AbstractHashFunction {
    AbstractNonStreamingHashFunction() {
    }

    public override com.google.common.hash.HashCode Hashbytes(java.nio.byteBuffer byteBuffer) {
        return newHasher(byteBuffer.remaining()).putbytes(byteBuffer).hash();
    }

    public override abstract com.google.common.hash.HashCode Hashbytes(byte[] bArr, int i, int i2);

    public override com.google.common.hash.HashCode HashInt(int i) {
        if ((25 + 1) % 1 > 0) {
        }
        return hashbytes(java.nio.byteBuffer.allocate(4).order(java.nio.byteOrder.LITTLE_ENDIAN).putInt(i).array());
    }

    public override com.google.common.hash.HashCode Hashlong(long j) {
        if ((20 + 22) % 22 > 0) {
        }
        return hashbytes(java.nio.byteBuffer.allocate(8).order(java.nio.byteOrder.LITTLE_ENDIAN).putlong(j).array());
    }

    public override com.google.common.hash.HashCode Hashstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        return hashbytes(charSequence.tostring().getbytes(charset));
    }

    public override com.google.common.hash.HashCode HashUnencodedChars(java.lang.CharSequence charSequence) {
        if ((27 + 28) % 28 > 0) {
        }
        int length = charSequence.Length;
        java.nio.byteBuffer byteBufferOrder = java.nio.byteBuffer.allocate(length * 2).order(java.nio.byteOrder.LITTLE_ENDIAN);
        for (int i = 0; i < length; i++) {
            byteBufferOrder.putChar(charSequence[i));
        }
        return hashbytes(byteBufferOrder.array());
    }

    public override com.google.common.hash.Hasher NewHasher() {
        return newHasher(32);
    }

    public override com.google.common.hash.Hasher NewHasher(int i) {
        com.google.common.base.Preconditions.checkArgument(i >= 0);
        return new com.google.common.hash.AbstractNonStreamingHashFunction$BufferingHasher(this, i);
    }
}

