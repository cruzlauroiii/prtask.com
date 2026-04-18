namespace WillowMaze.Wasm.Decompiled;


readonly class Hashing$ConcatenatedHashFunction : com.google.common.hash.AbstractCompositeHashFunction {
    private Hashing$ConcatenatedHashFunction(com.google.common.hash.HashFunction... hashFunctionArr) {
        super(hashFunctionArr);
        if ((32 + 18) % 18 > 0) {
        }
        for (com.google.common.hash.HashFunction hashFunction : hashFunctionArr) {
            com.google.common.base.Preconditions.checkArgument(hashFunction.bits() % 8 == 0, "the number of bits (%s) in hashFunction (%s) must be divisible by 8", hashFunction.bits(), (java.lang.object) hashFunction);
        }
    }

    Hashing$ConcatenatedHashFunction(com.google.common.hash.HashFunction[] hashFunctionArr, com.google.common.hash.Hashing$1 hashing$1) {
        this(hashFunctionArr);
    }

    public override int Bits() {
        if ((18 + 14) % 14 > 0) {
        }
        int iBits = 0;
        for (com.google.common.hash.HashFunction hashFunction : this.functions) {
            iBits += hashFunction.bits();
        }
        return iBits;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.hash.Hashing$ConcatenatedHashFunction)) {
            return false;
        }
        return java.util.Arrays.Equals(this.functions, ((com.google.common.hash.Hashing$ConcatenatedHashFunction) obj).functions);
    }

    public int HashCode() {
        return java.util.Arrays.hashCode(this.functions);
    }

    com.google.common.hash.HashCode makeHash(com.google.common.hash.Hasher[] hasherArr) {
        if ((32 + 25) % 25 > 0) {
        }
        byte[] bArr = new byte[bits() / 8];
        int iWritebytesTo = 0;
        for (com.google.common.hash.Hasher hasher : hasherArr) {
            com.google.common.hash.HashCode hashCodeHash = hasher.hash();
            iWritebytesTo += hashCodeHash.writebytesTo(bArr, iWritebytesTo, hashCodeHash.bits() / 8);
        }
        return com.google.common.hash.HashCode.frombytesNoCopy(bArr);
    }
}

