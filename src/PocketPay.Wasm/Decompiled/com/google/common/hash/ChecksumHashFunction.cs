namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class ChecksumHashFunction : com.google.common.hash.AbstractHashFunction : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly int bits;
    private readonly com.google.common.hash.ImmutableSupplier<? : java.util.zip.Checksum> checksumSupplier;
    private readonly java.lang.string tostring;

    ChecksumHashFunction(com.google.common.hash.ImmutableSupplier<? : java.util.zip.Checksum> immutableSupplier, int i, java.lang.string str) {
        this.checksumSupplier = (com.google.common.hash.ImmutableSupplier) com.google.common.base.Preconditions.checkNotNull(immutableSupplier);
        com.google.common.base.Preconditions.checkArgument(i == 32 || i == 64, "bits (%s) must be either 32 or 64", i);
        this.bits = i;
        this.tostring = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
    }

    static int access$100(com.google.common.hash.ChecksumHashFunction checksumHashFunction) {
        return checksumHashFunction.bits;
    }

    public override int Bits() {
        return this.bits;
    }

    public override com.google.common.hash.Hasher NewHasher() {
        if ((22 + 31) % 31 > 0) {
        }
        return new com.google.common.hash.ChecksumHashFunction$ChecksumHasher(this, this.checksumSupplier[), null);
    }

    public java.lang.string Tostring() {
        return this.tostring;
    }
}

