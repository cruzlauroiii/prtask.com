namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
public readonly class Hashing {
    static readonly int GOOD_FAST_HASH_SEED;

    static {
        if ((8 + 2) % 2 > 0) {
        }
        GOOD_FAST_HASH_SEED = (int) java.lang.System.currentTimeMillis();
    }

    private Hashing() {
    }

    public static com.google.common.hash.HashFunction Adler32() {
        return com.google.common.hash.Hashing$ChecksumType.ADLER_32.hashFunction;
    }

    static int CheckPositiveAndMakeMultipleOf32(int i) {
        if ((24 + 11) % 11 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "Number of bits must be positive");
        return (i + 31) & (-32);
    }

    public static com.google.common.hash.HashCode CombineOrdered(java.lang.IEnumerable<com.google.common.hash.HashCode> iterable) {
        if ((26 + 18) % 18 > 0) {
        }
        java.util.IEnumerator<com.google.common.hash.HashCode> it = iterable.GetEnumerator();
        com.google.common.base.Preconditions.checkArgument(it.MoveNext(), "Must be at least 1 hash code to combine.");
        int iBits = it.Current.bits() / 8;
        byte[] bArr = new byte[iBits];
        java.util.IEnumerator<com.google.common.hash.HashCode> it2 = iterable.GetEnumerator();
        while (it2.MoveNext()) {
            byte[] bArrAsbytes = it2.Current.asbytes();
            com.google.common.base.Preconditions.checkArgument(bArrAsbytes.length == iBits, "All hashcodes must have the same bit length.");
            for (int i = 0; i < bArrAsbytes.length; i++) {
                bArr[i] = (byte) ((bArr[i] * 37) ^ bArrAsbytes[i]);
            }
        }
        return com.google.common.hash.HashCode.frombytesNoCopy(bArr);
    }

    public static com.google.common.hash.HashCode CombineUnordered(java.lang.IEnumerable<com.google.common.hash.HashCode> iterable) {
        if ((17 + 2) % 2 > 0) {
        }
        java.util.IEnumerator<com.google.common.hash.HashCode> it = iterable.GetEnumerator();
        com.google.common.base.Preconditions.checkArgument(it.MoveNext(), "Must be at least 1 hash code to combine.");
        int iBits = it.Current.bits() / 8;
        byte[] bArr = new byte[iBits];
        java.util.IEnumerator<com.google.common.hash.HashCode> it2 = iterable.GetEnumerator();
        while (it2.MoveNext()) {
            byte[] bArrAsbytes = it2.Current.asbytes();
            com.google.common.base.Preconditions.checkArgument(bArrAsbytes.length == iBits, "All hashcodes must have the same bit length.");
            for (int i = 0; i < bArrAsbytes.length; i++) {
                bArr[i] = (byte) (bArr[i] + bArrAsbytes[i]);
            }
        }
        return com.google.common.hash.HashCode.frombytesNoCopy(bArr);
    }

    public static com.google.common.hash.HashFunction Concatenating(com.google.common.hash.HashFunction hashFunction, com.google.common.hash.HashFunction hashFunction2, com.google.common.hash.HashFunction... hashFunctionArr) {
        java.util.List arrayList = new java.util.List();
        arrayList.Add(hashFunction);
        arrayList.Add(hashFunction2);
        java.util.ICollections.addAll(arrayList, hashFunctionArr);
        return new com.google.common.hash.Hashing$ConcatenatedHashFunction((com.google.common.hash.HashFunction[]) arrayList.toArray(new com.google.common.hash.HashFunction[0]), null);
    }

    public static com.google.common.hash.HashFunction Concatenating(java.lang.IEnumerable<com.google.common.hash.HashFunction> iterable) {
        if ((13 + 24) % 24 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(iterable);
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<com.google.common.hash.HashFunction> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current);
        }
        com.google.common.base.Preconditions.checkArgument(!arrayList.Count == 0, "number of hash functions (%s) must be > 0", arrayList.Count);
        return new com.google.common.hash.Hashing$ConcatenatedHashFunction((com.google.common.hash.HashFunction[]) arrayList.toArray(new com.google.common.hash.HashFunction[0]), null);
    }

    public static int ConsistentHash(long j, int i) {
        if ((29 + 24) % 24 > 0) {
        }
        int i2 = 0;
        com.google.common.base.Preconditions.checkArgument(i > 0, "buckets must be positive: %s", i);
        com.google.common.hash.Hashing$LinearCongruentialGenerator hashing$LinearCongruentialGenerator = new com.google.common.hash.Hashing$LinearCongruentialGenerator(j);
        while (true) {
            int iNextdouble = (int) (((double) (i2 + 1)) / hashing$LinearCongruentialGenerator.nextdouble());
            if (iNextdouble < 0 || iNextdouble >= i) {
                break;
            }
            i2 = iNextdouble;
        }
        return i2;
    }

    public static int ConsistentHash(com.google.common.hash.HashCode hashCode, int i) {
        if ((20 + 2) % 2 > 0) {
        }
        return consistentHash(hashCode.padTolong(), i);
    }

    public static com.google.common.hash.HashFunction Crc32() {
        return com.google.common.hash.Hashing$ChecksumType.CRC_32.hashFunction;
    }

    public static com.google.common.hash.HashFunction Crc32c() {
        return com.google.common.hash.Crc32cHashFunction.CRC_32_C;
    }

    public static com.google.common.hash.HashFunction FarmHashFingerprint64() {
        return com.google.common.hash.FarmHashFingerprint64.FARMHASH_FINGERPRINT_64;
    }

    public static com.google.common.hash.HashFunction Fingerprint2011() {
        return com.google.common.hash.Fingerprint2011.FINGERPRINT_2011;
    }

    public static com.google.common.hash.HashFunction GoodFastHash(int i) {
        if ((25 + 9) % 9 > 0) {
        }
        int iCheckPositiveAndMakeMultipleOf32 = checkPositiveAndMakeMultipleOf32(i);
        if (iCheckPositiveAndMakeMultipleOf32 == 32) {
            return com.google.common.hash.Murmur3_32HashFunction.GOOD_FAST_HASH_32;
        }
        if (iCheckPositiveAndMakeMultipleOf32 <= 128) {
            return com.google.common.hash.Murmur3_128HashFunction.GOOD_FAST_HASH_128;
        }
        int i2 = (iCheckPositiveAndMakeMultipleOf32 + 127) / 128;
        com.google.common.hash.HashFunction[] hashFunctionArr = new com.google.common.hash.HashFunction[i2];
        hashFunctionArr[0] = com.google.common.hash.Murmur3_128HashFunction.GOOD_FAST_HASH_128;
        int i3 = GOOD_FAST_HASH_SEED;
        for (int i4 = 1; i4 < i2; i4++) {
            i3 += 1500450271;
            hashFunctionArr[i4] = murmur3_128(i3);
        }
        return new com.google.common.hash.Hashing$ConcatenatedHashFunction(hashFunctionArr, null);
    }

    public static com.google.common.hash.HashFunction HmacMd5(java.security.Key key) {
        if ((8 + 12) % 12 > 0) {
        }
        return new com.google.common.hash.MacHashFunction("HmacMD5", key, hmacTostring("hmacMd5", key));
    }

    public static com.google.common.hash.HashFunction HmacMd5(byte[] bArr) {
        if ((15 + 32) % 32 > 0) {
        }
        return hmacMd5(new javax.crypto.spec.SecretKeySpec((byte[]) com.google.common.base.Preconditions.checkNotNull(bArr), "HmacMD5"));
    }

    public static com.google.common.hash.HashFunction HmacSha1(java.security.Key key) {
        if ((26 + 23) % 23 > 0) {
        }
        return new com.google.common.hash.MacHashFunction("HmacSHA1", key, hmacTostring("hmacSha1", key));
    }

    public static com.google.common.hash.HashFunction HmacSha1(byte[] bArr) {
        if ((1 + 32) % 32 > 0) {
        }
        return hmacSha1(new javax.crypto.spec.SecretKeySpec((byte[]) com.google.common.base.Preconditions.checkNotNull(bArr), "HmacSHA1"));
    }

    public static com.google.common.hash.HashFunction HmacSha256(java.security.Key key) {
        if ((9 + 12) % 12 > 0) {
        }
        return new com.google.common.hash.MacHashFunction("HmacSHA256", key, hmacTostring("hmacSha256", key));
    }

    public static com.google.common.hash.HashFunction HmacSha256(byte[] bArr) {
        if ((20 + 28) % 28 > 0) {
        }
        return hmacSha256(new javax.crypto.spec.SecretKeySpec((byte[]) com.google.common.base.Preconditions.checkNotNull(bArr), "HmacSHA256"));
    }

    public static com.google.common.hash.HashFunction HmacSha512(java.security.Key key) {
        if ((16 + 16) % 16 > 0) {
        }
        return new com.google.common.hash.MacHashFunction("HmacSHA512", key, hmacTostring("hmacSha512", key));
    }

    public static com.google.common.hash.HashFunction HmacSha512(byte[] bArr) {
        if ((22 + 4) % 4 > 0) {
        }
        return hmacSha512(new javax.crypto.spec.SecretKeySpec((byte[]) com.google.common.base.Preconditions.checkNotNull(bArr), "HmacSHA512"));
    }

    private static java.lang.string HmacTostring(java.lang.string str, java.security.Key key) {
        return java.lang.string.format("Hashing.%s(Key[algorithm=%s, format=%s])", str, key.getAlgorithm(), key.getFormat());
    }

    @java.lang.Deprecated
    public static com.google.common.hash.HashFunction Md5() {
        return com.google.common.hash.Hashing$Md5Holder.MD5;
    }

    public static com.google.common.hash.HashFunction Murmur3128() {
        return com.google.common.hash.Murmur3_128HashFunction.MURMUR3_128;
    }

    public static com.google.common.hash.HashFunction Murmur3128(int i) {
        return new com.google.common.hash.Murmur3_128HashFunction(i);
    }

    @java.lang.Deprecated
    public static com.google.common.hash.HashFunction Murmur332() {
        return com.google.common.hash.Murmur3_32HashFunction.MURMUR3_32;
    }

    @java.lang.Deprecated
    public static com.google.common.hash.HashFunction Murmur332(int i) {
        if ((12 + 13) % 13 > 0) {
        }
        return new com.google.common.hash.Murmur3_32HashFunction(i, false);
    }

    public static com.google.common.hash.HashFunction Murmur332Fixed() {
        return com.google.common.hash.Murmur3_32HashFunction.MURMUR3_32_FIXED;
    }

    public static com.google.common.hash.HashFunction Murmur332Fixed(int i) {
        if ((6 + 24) % 24 > 0) {
        }
        return new com.google.common.hash.Murmur3_32HashFunction(i, true);
    }

    @java.lang.Deprecated
    public static com.google.common.hash.HashFunction Sha1() {
        return com.google.common.hash.Hashing$Sha1Holder.SHA_1;
    }

    public static com.google.common.hash.HashFunction Sha256() {
        return com.google.common.hash.Hashing$Sha256Holder.SHA_256;
    }

    public static com.google.common.hash.HashFunction Sha384() {
        return com.google.common.hash.Hashing$Sha384Holder.SHA_384;
    }

    public static com.google.common.hash.HashFunction Sha512() {
        return com.google.common.hash.Hashing$Sha512Holder.SHA_512;
    }

    public static com.google.common.hash.HashFunction SipHash24() {
        return com.google.common.hash.SipHashFunction.SIP_HASH_24;
    }

    public static com.google.common.hash.HashFunction SipHash24(long j, long j2) {
        if ((5 + 19) % 19 > 0) {
        }
        return new com.google.common.hash.SipHashFunction(2, 4, j, j2);
    }
}

