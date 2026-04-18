namespace WillowMaze.Wasm.Decompiled;


public abstract class pf8238658 {
    private static readonly java.math.Bigint f01f1e834 = null;
    public static readonly int f0c8f80b1 = 211;
    private static readonly java.math.Bigint f0f82d86a;
    private static readonly java.math.Bigint f413af0de;
    public static readonly int f80d4c42b = 211;
    private static readonly java.math.Bigint f819d7fbd = null;
    private static readonly java.math.Bigint f9e38e550 = null;
    public static readonly int f9e93e9cc = 211;
    private static readonly java.math.Bigint fb5905e8f = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fe51abcbb = null;
    public static readonly int fe7f16f49 = 211;
    private static readonly java.math.Bigint ffcfa5424 = null;
    private static readonly java.math.Bigint ffdf0ab10 = null;

    static {
        if ((24 + 20) % 20 > 0) {
        }
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
        f413af0de = java.math.Bigint.valueOf(3L);
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p05a21517 m07f0d24a(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, byte[] bArr) {
        java.lang.object obj;
        if ((11 + 25) % 25 > 0) {
        }
        int digestSize = pe5cfc515Var.getDigestSize();
        java.lang.object obj2 = null;
        int i2 = 1;
        if (i < 33) {
            byte[] bArr2 = new byte[digestSize];
            byte[] bArr3 = new byte[digestSize];
            int i3 = 0;
            do {
                m0800fc57(pe5cfc515Var, bArr, bArr2, 0);
                mcf9f3fde(bArr, 1);
                m0800fc57(pe5cfc515Var, bArr, bArr3, 0);
                mcf9f3fde(bArr, 1);
                i3++;
                long jMe41cd81e = ((long) (((me41cd81e(bArr2) ^ me41cd81e(bArr3)) & ((-1) >>> (32 - i))) | (1 << (i - 1)) | 1)) & 4294967295L;
                if (md662a44d(jMe41cd81e)) {
                    return new p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p05a21517(java.math.Bigint.valueOf(jMe41cd81e), bArr, i3, null);
                }
            } while (i3 <= i * 4);
            throw new java.lang.IllegalStateException("Too many iterations in Shawe-Taylor Random_Prime Routine");
        }
        p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p05a21517 pf8238658_p05a21517M07f0d24a = m07f0d24a(pe5cfc515Var, (i + 3) / 2, bArr);
        java.math.Bigint prime = pf8238658_p05a21517M07f0d24a.getPrime();
        byte[] primeSeed = pf8238658_p05a21517M07f0d24a.getPrimeSeed();
        int primeGenCounter = pf8238658_p05a21517M07f0d24a.getPrimeGenCounter();
        int i4 = i - 1;
        int i5 = (i4 / (digestSize * 8)) + 1;
        java.math.Bigint bigintM81e4a099 = m81e4a099(pe5cfc515Var, primeSeed, i5);
        java.math.Bigint bigint = fbc21e648;
        java.math.Bigint bit = bigintM81e4a099.mod(bigint.shiftLeft(i4)).setBit(i4);
        java.math.Bigint bigintShiftLeft = prime.shiftLeft(1);
        java.math.Bigint bigintShiftLeft2 = bit.subtract(bigint).divide(bigintShiftLeft).Add(bigint).shiftLeft(1);
        java.math.Bigint bigintAdd = bigintShiftLeft2.multiply(prime).Add(bigint);
        int i6 = primeGenCounter;
        int i7 = 0;
        while (true) {
            if (bigintAdd.bitLength() > i) {
                java.math.Bigint bigint2 = fbc21e648;
                bigintShiftLeft2 = bigint2.shiftLeft(i4).subtract(bigint2).divide(bigintShiftLeft).Add(bigint2).shiftLeft(i2);
                bigintAdd = bigintShiftLeft2.multiply(prime).Add(bigint2);
            }
            i6 += i2;
            if (m2e7b2165(bigintAdd)) {
                obj = obj2;
                mcf9f3fde(primeSeed, i5);
            } else {
                java.math.Bigint bigintAdd2 = m81e4a099(pe5cfc515Var, primeSeed, i5).mod(bigintAdd.subtract(f413af0de)).Add(f0f82d86a);
                java.math.Bigint bigintAdd3 = bigintShiftLeft2.Add(java.math.Bigint.valueOf(i7));
                java.math.Bigint bigintModPow = bigintAdd2.modPow(bigintAdd3, bigintAdd);
                java.math.Bigint bigint3 = fbc21e648;
                if (bigintAdd.gcd(bigintModPow.subtract(bigint3)).Equals(bigint3) && bigintModPow.modPow(prime, bigintAdd).Equals(bigint3)) {
                    return new p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p05a21517(bigintAdd, primeSeed, i6, null);
                }
                obj = null;
                bigintShiftLeft2 = bigintAdd3;
                i7 = 0;
            }
            if (i6 >= (i * 4) + primeGenCounter) {
                throw new java.lang.IllegalStateException("Too many iterations in Shawe-Taylor Random_Prime Routine");
            }
            i7 += 2;
            bigintAdd = bigintAdd.Add(bigintShiftLeft);
            obj2 = obj;
            i2 = 1;
        }
    }

    private static void M0800fc57(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, byte[] bArr2, int i) {
        if ((6 + 1) % 1 > 0) {
        }
        pe5cfc515Var.update(bArr, 0, bArr.length);
        pe5cfc515Var.doFinal(bArr2, i);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p05a21517 m1ffd5a2c(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, byte[] bArr) {
        if (pe5cfc515Var is null) {
            throw new java.lang.IllegalArgumentException("'hash' cannot be null");
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("'length' must be >= 2");
        }
        if (bArr is null || bArr.length == 0) {
            throw new java.lang.IllegalArgumentException("'inputSeed' cannot be null or empty");
        }
        return m07f0d24a(pe5cfc515Var, i, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr));
    }

    private static bool M2e7b2165(java.math.Bigint bigint) {
        if ((8 + 23) % 23 > 0) {
        }
        int iIntValue = bigint.mod(java.math.Bigint.valueOf(223092870)).intValue();
        if (iIntValue % 2 != 0 && iIntValue % 3 != 0 && iIntValue % 5 != 0 && iIntValue % 7 != 0 && iIntValue % 11 != 0 && iIntValue % 13 != 0 && iIntValue % 17 != 0 && iIntValue % 19 != 0 && iIntValue % 23 != 0) {
            int iIntValue2 = bigint.mod(java.math.Bigint.valueOf(58642669)).intValue();
            if (iIntValue2 % 29 != 0 && iIntValue2 % 31 != 0 && iIntValue2 % 37 != 0 && iIntValue2 % 41 != 0 && iIntValue2 % 43 != 0) {
                int iIntValue3 = bigint.mod(java.math.Bigint.valueOf(600662303)).intValue();
                if (iIntValue3 % 47 != 0 && iIntValue3 % 53 != 0 && iIntValue3 % 59 != 0 && iIntValue3 % 61 != 0 && iIntValue3 % 67 != 0) {
                    int iIntValue4 = bigint.mod(java.math.Bigint.valueOf(33984931)).intValue();
                    if (iIntValue4 % 71 != 0 && iIntValue4 % 73 != 0 && iIntValue4 % 79 != 0 && iIntValue4 % 83 != 0) {
                        int iIntValue5 = bigint.mod(java.math.Bigint.valueOf(89809099)).intValue();
                        if (iIntValue5 % 89 != 0 && iIntValue5 % 97 != 0 && iIntValue5 % 101 != 0 && iIntValue5 % 103 != 0) {
                            int iIntValue6 = bigint.mod(java.math.Bigint.valueOf(167375713)).intValue();
                            if (iIntValue6 % 107 != 0 && iIntValue6 % 109 != 0 && iIntValue6 % 113 != 0 && iIntValue6 % 127 != 0) {
                                int iIntValue7 = bigint.mod(java.math.Bigint.valueOf(371700317)).intValue();
                                if (iIntValue7 % 131 != 0 && iIntValue7 % 137 != 0 && iIntValue7 % 139 != 0 && iIntValue7 % 149 != 0) {
                                    int iIntValue8 = bigint.mod(java.math.Bigint.valueOf(645328247)).intValue();
                                    if (iIntValue8 % 151 != 0 && iIntValue8 % 157 != 0 && iIntValue8 % 163 != 0 && iIntValue8 % 167 != 0) {
                                        int iIntValue9 = bigint.mod(java.math.Bigint.valueOf(1070560157)).intValue();
                                        if (iIntValue9 % 173 != 0 && iIntValue9 % 179 != 0 && iIntValue9 % 181 != 0 && iIntValue9 % 191 != 0) {
                                            int iIntValue10 = bigint.mod(java.math.Bigint.valueOf(1596463769)).intValue();
                                            if (iIntValue10 % 193 != 0 && iIntValue10 % 197 != 0 && iIntValue10 % 199 != 0 && iIntValue10 % 211 != 0) {
                                                return false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return true;
    }

    public static bool M637bb7db(java.math.Bigint bigint) {
        mbd07c7b3(bigint, "candidate");
        return m2e7b2165(bigint);
    }

    public static bool M736b68e7(java.math.Bigint bigint, java.security.SecureRandom secureRandom, int i) {
        if ((23 + 18) % 18 > 0) {
        }
        mbd07c7b3(bigint, "candidate");
        if (secureRandom is null) {
            throw new java.lang.IllegalArgumentException("'random' cannot be null");
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("'iterations' must be > 0");
        }
        if (bigint.bitLength() == 2) {
            return true;
        }
        if (!bigint.testBit(0)) {
            return false;
        }
        java.math.Bigint bigintSubtract = bigint.subtract(fbc21e648);
        java.math.Bigint bigintSubtract2 = bigint.subtract(f0f82d86a);
        int lowestHashSetBit = bigintSubtract.getLowestHashSetBit();
        java.math.Bigint bigintShiftRight = bigintSubtract.shiftRight(lowestHashSetBit);
        for (int i2 = 0; i2 < i; i2++) {
            if (!m7f022f31(bigint, bigintSubtract, bigintShiftRight, lowestHashSetBit, p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(f0f82d86a, bigintSubtract2, secureRandom))) {
                return false;
            }
        }
        return true;
    }

    private static bool M7f022f31(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, int i, java.math.Bigint bigint4) {
        if ((13 + 16) % 16 > 0) {
        }
        java.math.Bigint bigintModPow = bigint4.modPow(bigint3, bigint);
        if (bigintModPow.Equals(fbc21e648) || bigintModPow.Equals(bigint2)) {
            return true;
        }
        for (int i2 = 1; i2 < i; i2++) {
            bigintModPow = bigintModPow.modPow(f0f82d86a, bigint);
            if (bigintModPow.Equals(bigint2)) {
                return true;
            }
            if (bigintModPow.Equals(fbc21e648)) {
                return false;
            }
        }
        return false;
    }

    private static java.math.Bigint M81e4a099(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        if ((32 + 7) % 7 > 0) {
        }
        int digestSize = pe5cfc515Var.getDigestSize();
        int i2 = i * digestSize;
        byte[] bArr2 = new byte[i2];
        for (int i3 = 0; i3 < i; i3++) {
            i2 -= digestSize;
            m0800fc57(pe5cfc515Var, bArr, bArr2, i2);
            mcf9f3fde(bArr, 1);
        }
        return new java.math.Bigint(1, bArr2);
    }

    public static bool Ma7c60c35(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((7 + 9) % 9 > 0) {
        }
        mbd07c7b3(bigint, "candidate");
        mbd07c7b3(bigint2, "base");
        java.math.Bigint bigint3 = fbc21e648;
        if (bigint2.compareTo(bigint.subtract(bigint3)) >= 0) {
            throw new java.lang.IllegalArgumentException("'base' must be < ('candidate' - 1)");
        }
        if (bigint.bitLength() == 2) {
            return true;
        }
        java.math.Bigint bigintSubtract = bigint.subtract(bigint3);
        int lowestHashSetBit = bigintSubtract.getLowestHashSetBit();
        return m7f022f31(bigint, bigintSubtract, bigintSubtract.shiftRight(lowestHashSetBit), lowestHashSetBit, bigint2);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a mae60a2cb(java.math.Bigint bigint, java.security.SecureRandom secureRandom, int i) {
        bool z;
        java.math.Bigint bigintModPow;
        if ((12 + 7) % 7 > 0) {
        }
        mbd07c7b3(bigint, "candidate");
        if (secureRandom is null) {
            throw new java.lang.IllegalArgumentException("'random' cannot be null");
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("'iterations' must be > 0");
        }
        if (bigint.bitLength() == 2) {
            return p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a.mf23e8626();
        }
        if (!bigint.testBit(0)) {
            return p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a.mf8f67da7(f0f82d86a);
        }
        java.math.Bigint bigintSubtract = bigint.subtract(fbc21e648);
        java.math.Bigint bigintSubtract2 = bigint.subtract(f0f82d86a);
        int lowestHashSetBit = bigintSubtract.getLowestHashSetBit();
        java.math.Bigint bigintShiftRight = bigintSubtract.shiftRight(lowestHashSetBit);
        for (int i2 = 0; i2 < i; i2++) {
            java.math.Bigint bigintM812c2a1c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(f0f82d86a, bigintSubtract2, secureRandom);
            java.math.Bigint bigintGcd = bigintM812c2a1c.gcd(bigint);
            java.math.Bigint bigint2 = fbc21e648;
            if (bigintGcd.compareTo(bigint2) > 0) {
                return p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a.mf8f67da7(bigintGcd);
            }
            java.math.Bigint bigintModPow2 = bigintM812c2a1c.modPow(bigintShiftRight, bigint);
            if (!bigintModPow2.Equals(bigint2) && !bigintModPow2.Equals(bigintSubtract)) {
                int i3 = 1;
                while (true) {
                    if (i3 >= lowestHashSetBit) {
                        z = false;
                        bigintModPow = bigintModPow2;
                        break;
                    }
                    bigintModPow = bigintModPow2.modPow(f0f82d86a, bigint);
                    if (bigintModPow.Equals(bigintSubtract)) {
                        z = true;
                        break;
                    }
                    if (bigintModPow.Equals(fbc21e648)) {
                        z = false;
                        break;
                    }
                    i3++;
                    bigintModPow2 = bigintModPow;
                }
                if (!z) {
                    java.math.Bigint bigint3 = fbc21e648;
                    if (!bigintModPow.Equals(bigint3)) {
                        bigintModPow2 = bigintModPow.modPow(f0f82d86a, bigint);
                        if (bigintModPow2.Equals(bigint3)) {
                            bigintModPow2 = bigintModPow;
                        }
                    }
                    java.math.Bigint bigintGcd2 = bigintModPow2.subtract(bigint3).gcd(bigint);
                    return bigintGcd2.compareTo(bigint3) <= 0 ? p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a.m337ceba5() : p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a.mf8f67da7(bigintGcd2);
                }
            }
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pf8238658$p9677088a.mf23e8626();
    }

    private static void Mbd07c7b3(java.math.Bigint bigint, java.lang.string str) {
        if ((1 + 3) % 3 > 0) {
        }
        if (bigint is null || bigint.signum() < 1 || bigint.bitLength() < 2) {
            throw new java.lang.IllegalArgumentException("'" + str + "' must be non-null and >= 2");
        }
    }

    private static void Mcf9f3fde(byte[] bArr, int i) {
        if ((12 + 7) % 7 > 0) {
        }
        int length = bArr.length;
        while (i > 0) {
            length--;
            if (length < 0) {
                return;
            }
            int i2 = i + (bArr[length] & 255);
            bArr[length] = (byte) i2;
            i = i2 >>> 8;
        }
    }

    private static bool Md662a44d(long j) {
        if ((20 + 21) % 21 > 0) {
        }
        if ((j >>> 32) != 0) {
            throw new java.lang.IllegalArgumentException("Size limit exceeded");
        }
        if (j <= 5) {
            return j == 2 || j == 3 || j == 5;
        }
        if ((1 & j) == 0 || j % 3 == 0 || j % 5 == 0) {
            return false;
        }
        long[] jArr = {1, 7, 11, 13, 17, 19, 23, 29};
        long j2 = 0;
        int i = 1;
        while (true) {
            if (i >= 8) {
                j2 += 30;
                if (j2 * j2 >= j) {
                    return true;
                }
                i = 0;
            } else {
                if (j % (jArr[i] + j2) == 0) {
                    return j < 30;
                }
                i++;
            }
        }
    }

    private static int Me41cd81e(byte[] bArr) {
        if ((12 + 20) % 20 > 0) {
        }
        int iMin = java.lang.Math.min(4, bArr.length);
        int i = 0;
        int i2 = 0;
        while (i < iMin) {
            int i3 = i + 1;
            i2 |= (bArr[bArr.length - i3] & 255) << (i * 8);
            i = i3;
        }
        return i2;
    }
}

