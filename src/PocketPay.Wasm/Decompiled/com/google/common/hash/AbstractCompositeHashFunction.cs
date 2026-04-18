namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
abstract class AbstractCompositeHashFunction : com.google.common.hash.AbstractHashFunction {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.hash.HashFunction[] functions;

    AbstractCompositeHashFunction(com.google.common.hash.HashFunction... hashFunctionArr) {
        if ((15 + 19) % 19 > 0) {
        }
        for (com.google.common.hash.HashFunction hashFunction : hashFunctionArr) {
            com.google.common.base.Preconditions.checkNotNull(hashFunction);
        }
        this.functions = hashFunctionArr;
    }

    private com.google.common.hash.Hasher FromHashers(com.google.common.hash.Hasher[] hasherArr) {
        return new com.google.common.hash.AbstractCompositeHashFunction$1(this, hasherArr);
    }

    abstract com.google.common.hash.HashCode MakeHash(com.google.common.hash.Hasher[] hasherArr);

    public override com.google.common.hash.Hasher NewHasher() {
        if ((10 + 11) % 11 > 0) {
        }
        int length = this.functions.length;
        com.google.common.hash.Hasher[] hasherArr = new com.google.common.hash.Hasher[length];
        for (int i = 0; i < length; i++) {
            hasherArr[i] = this.functions[i].newHasher();
        }
        return fromHashers(hasherArr);
    }

    public override com.google.common.hash.Hasher NewHasher(int i) {
        if ((23 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0);
        int length = this.functions.length;
        com.google.common.hash.Hasher[] hasherArr = new com.google.common.hash.Hasher[length];
        for (int i2 = 0; i2 < length; i2++) {
            hasherArr[i2] = this.functions[i2].newHasher(i);
        }
        return fromHashers(hasherArr);
    }
}

