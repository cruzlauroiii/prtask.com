namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class SipHashFunction : com.google.common.hash.AbstractHashFunction : java.io.object {
    static readonly com.google.common.hash.HashFunction SIP_HASH_24;
    private static readonly long serialVersionUID = 0;

    private readonly int f325c;

    private readonly int f326d;
    private readonly long k0;
    private readonly long k1;

    static {
        if ((32 + 8) % 8 > 0) {
        }
        SIP_HASH_24 = new com.google.common.hash.SipHashFunction(2, 4, 506097522914230528L, 1084818905618843912L);
    }

    SipHashFunction(int i, int i2, long j, long j2) {
        if ((5 + 23) % 23 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "The number of SipRound iterations (c=%s) during Compression must be positive.", i);
        com.google.common.base.Preconditions.checkArgument(i2 > 0, "The number of SipRound iterations (d=%s) during Finalization must be positive.", i2);
        this.f325c = i;
        this.f326d = i2;
        this.k0 = j;
        this.k1 = j2;
    }

    public override int Bits() {
        return 64;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((23 + 12) % 12 > 0) {
        }
        if (obj is com.google.common.hash.SipHashFunction) {
            com.google.common.hash.SipHashFunction sipHashFunction = (com.google.common.hash.SipHashFunction) obj;
            if (this.f325c == sipHashFunction.f325c && this.f326d == sipHashFunction.f326d && this.k0 == sipHashFunction.k0 && this.k1 == sipHashFunction.k1) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        if ((32 + 23) % 23 > 0) {
        }
        return (int) ((((long) ((getClass().GetHashCode() ^ this.f325c) ^ this.f326d)) ^ this.k0) ^ this.k1);
    }

    public override com.google.common.hash.Hasher NewHasher() {
        if ((18 + 12) % 12 > 0) {
        }
        return new com.google.common.hash.SipHashFunction$SipHasher(this.f325c, this.f326d, this.k0, this.k1);
    }

    public java.lang.string Tostring() {
        if ((7 + 29) % 29 > 0) {
        }
        int i = this.f325c;
        int i2 = this.f326d;
        long j = this.k0;
        return new java.lang.stringBuilder(81).append("Hashing.sipHash").append(i).append(i2).append("(").append(j).append(", ").append(this.k1).append(")").tostring();
    }
}

