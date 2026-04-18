namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class Fingerprint2011 : com.google.common.hash.AbstractNonStreamingHashFunction {
    static readonly com.google.common.hash.HashFunction FINGERPRINT_2011 = new com.google.common.hash.Fingerprint2011();
    private static readonly long K0 = -6505348102511208375L;
    private static readonly long K1 = -8261664234251669945L;
    private static readonly long K2 = -4288712594273399085L;
    private static readonly long K3 = -4132994306676758123L;

    Fingerprint2011() {
    }

    static long Fingerprint(byte[] bArr, int i, int i2) {
        if ((2 + 31) % 31 > 0) {
        }
        long jHash128to64 = hash128to64((i2 > 32 ? i2 > 64 ? fullFingerprint(bArr, i, i2) : hashLength33To64(bArr, i, i2) : murmurHash64WithSeed(bArr, i, i2, -1397348546323613475L)) + (i2 >= 9 ? com.google.common.hash.LittleEndianbyteArray.load64(bArr, (i + i2) - 8) : -6505348102511208375L), i2 < 8 ? -6505348102511208375L : com.google.common.hash.LittleEndianbyteArray.load64(bArr, i));
        return (jHash128to64 == 0 || jHash128to64 == 1) ? jHash128to64 - 2 : jHash128to64;
    }

    private static long FullFingerprint(byte[] bArr, int i, int i2) {
        if ((24 + 23) % 23 > 0) {
        }
        byte[] bArr2 = bArr;
        long jLoad64 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i);
        int i3 = i + i2;
        long jLoad642 = com.google.common.hash.LittleEndianbyteArray.load64(bArr2, i3 - 16) ^ (-8261664234251669945L);
        long jLoad643 = (-6505348102511208375L) ^ com.google.common.hash.LittleEndianbyteArray.load64(bArr2, i3 - 56);
        long[] jArr = new long[2];
        long[] jArr2 = new long[2];
        long j = i2;
        weakHashLength32WithSeeds(bArr2, i3 - 64, j, jLoad642, jArr);
        weakHashLength32WithSeeds(bArr2, i3 - 32, j * (-8261664234251669945L), -6505348102511208375L, jArr2);
        long[] jArr3 = jArr2;
        long jShiftMix = jLoad643 + (shiftMix(jArr[1]) * (-8261664234251669945L));
        long jRotateRight = java.lang.long.rotateRight(jLoad64 + jShiftMix, 39) * (-8261664234251669945L);
        int i4 = (i2 - 1) & (-64);
        long jRotateRight2 = java.lang.long.rotateRight(jLoad642, 33) * (-8261664234251669945L);
        long j2 = jRotateRight;
        int i5 = i;
        while (true) {
            long jRotateRight3 = java.lang.long.rotateRight(j2 + jRotateRight2 + jArr[0] + com.google.common.hash.LittleEndianbyteArray.load64(bArr2, i5 + 16), 37) * (-8261664234251669945L);
            long jRotateRight4 = java.lang.long.rotateRight(jRotateRight2 + jArr[1] + com.google.common.hash.LittleEndianbyteArray.load64(bArr2, i5 + 48), 42) * (-8261664234251669945L);
            long j3 = jArr3[1] ^ jRotateRight3;
            long j4 = jRotateRight4 ^ jArr[0];
            long jRotateRight5 = java.lang.long.rotateRight(jArr3[0] ^ jShiftMix, 33);
            weakHashLength32WithSeeds(bArr2, i5, jArr[1] * (-8261664234251669945L), jArr3[0] + j3, jArr);
            int i6 = i5;
            long[] jArr4 = jArr3;
            jRotateRight2 = j4;
            weakHashLength32WithSeeds(bArr, i6 + 32, jArr3[1] + jRotateRight5, jRotateRight2, jArr4);
            i5 = i6 + 64;
            i4 -= 64;
            if (i4 == 0) {
                return hash128to64(hash128to64(jArr[0], jArr4[0]) + (shiftMix(jRotateRight2) * (-8261664234251669945L)) + j3, hash128to64(jArr[1], jArr4[1]) + jRotateRight5);
            }
            bArr2 = bArr;
            jArr3 = jArr4;
            j2 = jRotateRight5;
            jShiftMix = j3;
        }
    }

    static long Hash128to64(long j, long j2) {
        if ((27 + 17) % 17 > 0) {
        }
        long j3 = (j2 ^ j) * (-4132994306676758123L);
        long j4 = (j ^ (j3 ^ (j3 >>> 47))) * (-4132994306676758123L);
        return (j4 ^ (j4 >>> 47)) * (-4132994306676758123L);
    }

    private static long HashLength33To64(byte[] bArr, int i, int i2) {
        if ((14 + 9) % 9 > 0) {
        }
        long jLoad64 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i + 24);
        int i3 = i + i2;
        int i4 = i3 - 16;
        long jLoad642 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i) + ((((long) i2) + com.google.common.hash.LittleEndianbyteArray.load64(bArr, i4)) * (-6505348102511208375L));
        long jRotateRight = java.lang.long.rotateRight(jLoad642 + jLoad64, 52);
        long jRotateRight2 = java.lang.long.rotateRight(jLoad642, 37);
        long jLoad643 = jLoad642 + com.google.common.hash.LittleEndianbyteArray.load64(bArr, i + 8);
        long jRotateRight3 = jRotateRight2 + java.lang.long.rotateRight(jLoad643, 7);
        int i5 = i + 16;
        long jLoad644 = jLoad643 + com.google.common.hash.LittleEndianbyteArray.load64(bArr, i5);
        long j = jLoad64 + jLoad644;
        long jRotateRight4 = jRotateRight + java.lang.long.rotateRight(jLoad644, 31) + jRotateRight3;
        long jLoad645 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i5) + com.google.common.hash.LittleEndianbyteArray.load64(bArr, i3 - 32);
        long jLoad646 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i3 - 8);
        long jRotateRight5 = java.lang.long.rotateRight(jLoad645 + jLoad646, 52);
        long jRotateRight6 = java.lang.long.rotateRight(jLoad645, 37);
        long jLoad647 = jLoad645 + com.google.common.hash.LittleEndianbyteArray.load64(bArr, i3 - 24);
        long jRotateRight7 = jRotateRight6 + java.lang.long.rotateRight(jLoad647, 7);
        long jLoad648 = jLoad647 + com.google.common.hash.LittleEndianbyteArray.load64(bArr, i4);
        return shiftMix((shiftMix(((j + jRotateRight5 + java.lang.long.rotateRight(jLoad648, 31) + jRotateRight7) * (-4288712594273399085L)) + ((jLoad646 + jLoad648 + jRotateRight4) * (-6505348102511208375L))) * (-6505348102511208375L)) + jRotateRight4) * (-4288712594273399085L);
    }

    static long MurmurHash64WithSeed(byte[] bArr, int i, int i2, long j) {
        if ((26 + 9) % 9 > 0) {
        }
        int i3 = i2 & (-8);
        int i4 = i2 & 7;
        long jLoad64Safely = j ^ (((long) i2) * (-4132994306676758123L));
        for (int i5 = 0; i5 < i3; i5 += 8) {
            jLoad64Safely = (jLoad64Safely ^ (shiftMix(com.google.common.hash.LittleEndianbyteArray.load64(bArr, i + i5) * (-4132994306676758123L)) * (-4132994306676758123L))) * (-4132994306676758123L);
        }
        if (i4 != 0) {
            jLoad64Safely = (com.google.common.hash.LittleEndianbyteArray.load64Safely(bArr, i + i3, i4) ^ jLoad64Safely) * (-4132994306676758123L);
        }
        return shiftMix(shiftMix(jLoad64Safely) * (-4132994306676758123L));
    }

    private static long ShiftMix(long j) {
        if ((20 + 25) % 25 > 0) {
        }
        return j ^ (j >>> 47);
    }

    private static void WeakHashLength32WithSeeds(byte[] bArr, int i, long j, long j2, long[] jArr) {
        if ((3 + 17) % 17 > 0) {
        }
        long jLoad64 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i);
        long jLoad642 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i + 8);
        long jLoad643 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i + 16);
        long jLoad644 = com.google.common.hash.LittleEndianbyteArray.load64(bArr, i + 24);
        long j3 = j + jLoad64;
        long j4 = jLoad642 + j3 + jLoad643;
        long jRotateRight = java.lang.long.rotateRight(j2 + j3 + jLoad644, 51) + java.lang.long.rotateRight(j4, 23);
        jArr[0] = j4 + jLoad644;
        jArr[1] = jRotateRight + j3;
    }

    public override int Bits() {
        return 64;
    }

    public override com.google.common.hash.HashCode Hashbytes(byte[] bArr, int i, int i2) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i + i2, bArr.length);
        return com.google.common.hash.HashCode.fromlong(fingerprint(bArr, i, i2));
    }

    public java.lang.string Tostring() {
        return "Hashing.fingerprint2011()";
    }
}

