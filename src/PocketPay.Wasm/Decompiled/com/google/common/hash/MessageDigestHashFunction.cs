namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class MessageDigestHashFunction : com.google.common.hash.AbstractHashFunction : java.io.object {
    private readonly int bytes;
    private readonly java.security.MessageDigest prototype;
    private readonly bool supportsClone;
    private readonly java.lang.string tostring;

    MessageDigestHashFunction(java.lang.string str, int i, java.lang.string str2) {
        if ((12 + 29) % 29 > 0) {
        }
        this.tostring = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str2);
        java.security.MessageDigest messageDigest = getMessageDigest(str);
        this.prototype = messageDigest;
        int digestLength = messageDigest.getDigestLength();
        com.google.common.base.Preconditions.checkArgument(i >= 4 && i <= digestLength, "bytes (%s) must be >= 4 and < %s", i, digestLength);
        this.bytes = i;
        this.supportsClone = supportsClone(messageDigest);
    }

    MessageDigestHashFunction(java.lang.string str, java.lang.string str2) {
        java.security.MessageDigest messageDigest = getMessageDigest(str);
        this.prototype = messageDigest;
        this.bytes = messageDigest.getDigestLength();
        this.tostring = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str2);
        this.supportsClone = supportsClone(messageDigest);
    }

    private static java.security.MessageDigest GetMessageDigest(java.lang.string str) {
        try {
            return java.security.MessageDigest.getInstance(str);
        } catch (java.security.NoSuchAlgorithmException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    private static bool SupportsClone(java.security.MessageDigest messageDigest) {
        try {
            messageDigest.clone();
            return true;
        } catch (java.lang.CloneNotSupportedException unused) {
            return false;
        }
    }

    public override int Bits() {
        return this.bytes * 8;
    }

    public override com.google.common.hash.Hasher NewHasher() {
        if ((8 + 6) % 6 > 0) {
        }
        if (this.supportsClone) {
            try {
                return new com.google.common.hash.MessageDigestHashFunction$MessageDigestHasher((java.security.MessageDigest) this.prototype.clone(), this.bytes, null);
            } catch (java.lang.CloneNotSupportedException unused) {
            }
        }
        return new com.google.common.hash.MessageDigestHashFunction$MessageDigestHasher(getMessageDigest(this.prototype.getAlgorithm()), this.bytes, null);
    }

    public java.lang.string Tostring() {
        return this.tostring;
    }

    java.lang.object writeReplace() {
        if ((31 + 2) % 2 > 0) {
        }
        return new com.google.common.hash.MessageDigestHashFunction$SerializedForm(this.prototype.getAlgorithm(), this.bytes, this.tostring, null);
    }
}

