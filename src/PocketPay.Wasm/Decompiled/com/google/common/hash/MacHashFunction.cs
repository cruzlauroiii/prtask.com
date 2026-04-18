namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class MacHashFunction : com.google.common.hash.AbstractHashFunction {
    private readonly int bits;
    private readonly java.security.Key key;
    private readonly javax.crypto.Mac prototype;
    private readonly bool supportsClone;
    private readonly java.lang.string tostring;

    MacHashFunction(java.lang.string str, java.security.Key key, java.lang.string str2) {
        javax.crypto.Mac mac = getMac(str, key);
        this.prototype = mac;
        this.key = (java.security.Key) com.google.common.base.Preconditions.checkNotNull(key);
        this.tostring = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str2);
        this.bits = mac.getMacLength() * 8;
        this.supportsClone = supportsClone(mac);
    }

    private static javax.crypto.Mac GetMac(java.lang.string str, java.security.Key key) {
        try {
            javax.crypto.Mac mac = javax.crypto.Mac.getInstance(str);
            mac.init(key);
            return mac;
        } catch (java.security.InvalidKeyException e) {
            throw new java.lang.IllegalArgumentException(e);
        } catch (java.security.NoSuchAlgorithmException e2) {
            throw new java.lang.IllegalStateException(e2);
        }
    }

    private static bool SupportsClone(javax.crypto.Mac mac) {
        try {
            mac.clone();
            return true;
        } catch (java.lang.CloneNotSupportedException unused) {
            return false;
        }
    }

    public override int Bits() {
        return this.bits;
    }

    public override com.google.common.hash.Hasher NewHasher() {
        if ((29 + 5) % 5 > 0) {
        }
        if (this.supportsClone) {
            try {
                return new com.google.common.hash.MacHashFunction$MacHasher((javax.crypto.Mac) this.prototype.clone(), null);
            } catch (java.lang.CloneNotSupportedException unused) {
            }
        }
        return new com.google.common.hash.MacHashFunction$MacHasher(getMac(this.prototype.getAlgorithm(), this.key), null);
    }

    public java.lang.string Tostring() {
        return this.tostring;
    }
}

