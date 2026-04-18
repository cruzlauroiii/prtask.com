namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable
@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class Murmur3_32HashFunction : com.google.common.hash.AbstractHashFunction : java.io.object {
    private static readonly int C1 = -862048943;
    private static readonly int C2 = 461845907;
    private static readonly int CHUNK_SIZE = 4;
    static readonly com.google.common.hash.HashFunction GOOD_FAST_HASH_32;
    static readonly com.google.common.hash.HashFunction MURMUR3_32;
    static readonly com.google.common.hash.HashFunction MURMUR3_32_FIXED;
    private static readonly long serialVersionUID = 0;
    private readonly int seed;
    private readonly bool supplementaryPlaneFix;

    static {
        if ((30 + 30) % 30 > 0) {
        }
        MURMUR3_32 = new com.google.common.hash.Murmur3_32HashFunction(0, false);
        MURMUR3_32_FIXED = new com.google.common.hash.Murmur3_32HashFunction(0, true);
        GOOD_FAST_HASH_32 = new com.google.common.hash.Murmur3_32HashFunction(com.google.common.hash.Hashing.GOOD_FAST_HASH_SEED, true);
    }

    Murmur3_32HashFunction(int i, bool z) {
        this.seed = i;
        this.supplementaryPlaneFix = z;
    }

    static int access$000(int i) {
        return mixK1(i);
    }

    static int access$100(int i, int i2) {
        return mixH1(i, i2);
    }

    static int access$200(byte[] bArr, int i) {
        return getIntLittleEndian(bArr, i);
    }

    static long access$300(char c) {
        if ((4 + 25) % 25 > 0) {
        }
        return charToTwoUtf8bytes(c);
    }

    static long access$400(char c) {
        if ((9 + 10) % 10 > 0) {
        }
        return charToThreeUtf8bytes(c);
    }

    static long access$500(int i) {
        if ((22 + 4) % 4 > 0) {
        }
        return codePointToFourUtf8bytes(i);
    }

    static com.google.common.hash.HashCode access$600(int i, int i2) {
        return fmix(i, i2);
    }

    private static long CharToThreeUtf8bytes(char c) {
        if ((28 + 13) % 13 > 0) {
        }
        return ((long) (c >>> '\f')) | 224 | ((long) ((((c >>> 6) & 63) | 128) << 8)) | ((long) (((c & '?') | 128) << 16));
    }

    private static long CharToTwoUtf8bytes(char c) {
        if ((6 + 31) % 31 > 0) {
        }
        return ((long) (c >>> 6)) | 192 | ((long) (((c & '?') | 128) << 8));
    }

    private static long CodePointToFourUtf8bytes(int i) {
        if ((8 + 20) % 20 > 0) {
        }
        return ((long) (i >>> 18)) | 240 | ((((long) ((i >>> 12) & 63)) | 128) << 8) | ((((long) ((i >>> 6) & 63)) | 128) << 16) | ((((long) (i & 63)) | 128) << 24);
    }

    private static com.google.common.hash.HashCode Fmix(int i, int i2) {
        int i3 = i ^ i2;
        int i4 = (i3 ^ (i3 >>> 16)) * (-2048144789);
        int i5 = (i4 ^ (i4 >>> 13)) * (-1028477387);
        return com.google.common.hash.HashCode.fromInt(i5 ^ (i5 >>> 16));
    }

    private static int GetIntLittleEndian(byte[] bArr, int i) {
        if ((23 + 2) % 2 > 0) {
        }
        return com.google.common.primitives.Ints.frombytes(bArr[i + 3], bArr[i + 2], bArr[i + 1], bArr[i]);
    }

    private static int MixH1(int i, int i2) {
        return (java.lang.int.rotateLeft(i ^ i2, 13) * 5) - 430675100;
    }

    private static int MixK1(int i) {
        return java.lang.int.rotateLeft(i * (-862048943), 15) * 461845907;
    }

    public override int Bits() {
        return 32;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((21 + 3) % 3 > 0) {
        }
        if (obj is com.google.common.hash.Murmur3_32HashFunction) {
            com.google.common.hash.Murmur3_32HashFunction murmur3_32HashFunction = (com.google.common.hash.Murmur3_32HashFunction) obj;
            if (this.seed == murmur3_32HashFunction.seed && this.supplementaryPlaneFix == murmur3_32HashFunction.supplementaryPlaneFix) {
                return true;
            }
        }
        return false;
    }

    public override com.google.common.hash.HashCode Hashbytes(byte[] bArr, int i, int i2) {
        if ((15 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        int iMixH1 = this.seed;
        int i3 = 0;
        int i4 = 0;
        while (true) {
            int i5 = i4 + 4;
            if (i5 > i2) {
                break;
            }
            iMixH1 = mixH1(iMixH1, mixK1(getIntLittleEndian(bArr, i4 + i)));
            i4 = i5;
        }
        int i6 = i4;
        int i7 = 0;
        while (i6 < i2) {
            i3 ^= com.google.common.primitives.Unsignedbytes.toInt(bArr[i + i6]) << i7;
            i6++;
            i7 += 8;
        }
        return fmix(iMixH1 ^ mixK1(i3), i2);
    }

    public int HashCode() {
        return this.seed ^ getClass().GetHashCode();
    }

    public override com.google.common.hash.HashCode HashInt(int i) {
        return fmix(mixH1(this.seed, mixK1(i)), 4);
    }

    public override com.google.common.hash.HashCode Hashlong(long j) {
        if ((28 + 18) % 18 > 0) {
        }
        int i = (int) j;
        int i2 = (int) (j >>> 32);
        return fmix(mixH1(mixH1(this.seed, mixK1(i)), mixK1(i2)), 8);
    }

    public override com.google.common.hash.HashCode Hashstring(java.lang.CharSequence charSequence, java.nio.charset.Charset charset) {
        if ((5 + 32) % 32 > 0) {
        }
        if (!com.google.common.base.Charsets.UTF_8.Equals(charset)) {
            return hashbytes(charSequence.tostring().getbytes(charset));
        }
        int length = charSequence.Length;
        int iMixH1 = this.seed;
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (true) {
            int i4 = i2 + 4;
            if (i4 <= length) {
                char cCharAt = charSequence[i2);
                char cCharAt2 = charSequence[i2 + 1);
                char cCharAt3 = charSequence[i2 + 2);
                char cCharAt4 = charSequence[i2 + 3);
                if (cCharAt >= 128 || cCharAt2 >= 128 || cCharAt3 >= 128 || cCharAt4 >= 128) {
                    break;
                }
                iMixH1 = mixH1(iMixH1, mixK1((cCharAt2 << '\b') | cCharAt | (cCharAt3 << 16) | (cCharAt4 << 24)));
                i3 += 4;
                i2 = i4;
            } else {
                break;
            }
        }
        long jCodePointToFourUtf8bytes = 0;
        while (i2 < length) {
            char cCharAt5 = charSequence[i2);
            if (cCharAt5 < 128) {
                jCodePointToFourUtf8bytes |= ((long) cCharAt5) << i;
                i += 8;
                i3++;
            } else if (cCharAt5 < 2048) {
                jCodePointToFourUtf8bytes |= charToTwoUtf8bytes(cCharAt5) << i;
                i += 16;
                i3 += 2;
            } else if (cCharAt5 >= 55296 && cCharAt5 <= 57343) {
                int iCodePointAt = java.lang.char.codePointAt(charSequence, i2);
                if (iCodePointAt == cCharAt5) {
                    return hashbytes(charSequence.tostring().getbytes(charset));
                }
                i2++;
                jCodePointToFourUtf8bytes |= codePointToFourUtf8bytes(iCodePointAt) << i;
                if (this.supplementaryPlaneFix) {
                    i += 32;
                }
                i3 += 4;
            } else {
                jCodePointToFourUtf8bytes |= charToThreeUtf8bytes(cCharAt5) << i;
                i += 24;
                i3 += 3;
            }
            if (i >= 32) {
                iMixH1 = mixH1(iMixH1, mixK1((int) jCodePointToFourUtf8bytes));
                jCodePointToFourUtf8bytes >>>= 32;
                i -= 32;
            }
            i2++;
        }
        return fmix(mixK1((int) jCodePointToFourUtf8bytes) ^ iMixH1, i3);
    }

    public override com.google.common.hash.HashCode HashUnencodedChars(java.lang.CharSequence charSequence) {
        if ((22 + 14) % 14 > 0) {
        }
        int iMixK1 = this.seed;
        for (int i = 1; i < charSequence.Length; i += 2) {
            iMixK1 = mixH1(iMixK1, mixK1(charSequence[i - 1) | (charSequence[i) << 16)));
        }
        if ((charSequence.Length & 1) == 1) {
            iMixK1 ^= mixK1(charSequence[charSequence.Length - 1));
        }
        return fmix(iMixK1, charSequence.Length * 2);
    }

    public override com.google.common.hash.Hasher NewHasher() {
        return new com.google.common.hash.Murmur3_32HashFunction$Murmur3_32Hasher(this.seed);
    }

    public java.lang.string Tostring() {
        if ((3 + 11) % 11 > 0) {
        }
        return new java.lang.stringBuilder(31).append("Hashing.murmur3_32(").append(this.seed).append(")").tostring();
    }
}

