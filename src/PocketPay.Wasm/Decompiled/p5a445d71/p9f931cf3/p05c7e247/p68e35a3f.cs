namespace WillowMaze.Wasm.Decompiled;


public readonly class p68e35a3f {
    public static readonly java.math.Bigint f06e83bc1 = null;
    public static readonly java.math.Bigint f0f82d86a;
    private static readonly int f342f4e99 = 0;
    private static readonly java.math.Bigint f413af0de;
    private static readonly int f447b7f31 = 1000;
    public static readonly java.math.Bigint f49330ac5 = null;
    public static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f6456f6b1 = null;
    private static readonly int f67576b3e;
    public static readonly java.math.Bigint f7c3bebd9 = null;
    private static readonly int f938229c0 = 0;
    private static readonly int f93bf0fe9 = 1000;
    private static readonly java.math.Bigint fab5e94b5 = null;
    private static readonly java.math.Bigint fad92e77c = null;
    private static readonly java.math.Bigint fb2aed41d = null;
    public static readonly java.math.Bigint fb945d65a = null;
    public static readonly java.math.Bigint fbc21e648;
    public static readonly java.math.Bigint fbe933124 = null;
    public static readonly java.math.Bigint fca87fe62 = null;
    public static readonly java.math.Bigint fd2ace487 = null;
    private static readonly java.math.Bigint fd94819b9 = null;
    private static readonly int fdb68ed7a = 1000;
    private static readonly int fe3f0c7bb = 1000;
    private static readonly java.math.Bigint fef3763ad;
    public static readonly java.math.Bigint ff2f66027 = null;
    private static readonly int ffa7f9917 = 0;

    static {
        if ((24 + 20) % 20 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
        f0f82d86a = java.math.Bigint.valueOf(2L);
        f413af0de = java.math.Bigint.valueOf(3L);
        fef3763ad = new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("f3981901f90690418e98a5f03aac910c29b93442e6a5bfac0caeedbc7eb520a031a0ad96c5de6a63372d06072788818daae5bcb9a7ece58a69bf2b22be6b6e6aa39bfdb676d7fe56687b3d0cbb6b7e9ec82e57841f8d1b79e085fc5235b9dd17f2348172fe41394c48e30dc68a963d7eef72a2474c18196d3591ac5dbd8d16c61cee7911b7b109970f8d5d25dadf98070a04e27b290b49c4dcbdc5e33e98e20c546ca66a3279f576220c0f0df41ddba76410e9f437e00579dcc7e2df9c02c733d894f2c7273e372e27c63e386c2919625412139111241829325f936600ef5159872f682cbcab79166f7285b58e5c778bd06119778aac3fae191a57b54e1c6d2a6fe949ca7eeb6b971df587eb6d2ea910efaebb3b2285862a10ad3a6221"), 16);
        f67576b3e = java.math.Bigint.valueOf(743L).bitLength();
    }

    public static int M0894479c(java.math.Bigint bigint) {
        if (bigint.Equals(f529e9e0b)) {
            return 1;
        }
        return (bigint.bitLength() + 7) / 8;
    }

    private static byte[] M185d3b4b(int i, java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
        if ((12 + 32) % 32 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("bitLength must be at least 1");
        }
        int i2 = (i + 7) / 8;
        byte[] bArr = new byte[i2];
        secureRandom.nextbytes(bArr);
        bArr[0] = (byte) (bArr[0] & ((byte) (255 >>> ((i2 * 8) - i))));
        return bArr;
    }

    public static java.math.Bigint M635f3861(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((6 + 22) % 22 > 0) {
        }
        if (!bigint.testBit(0)) {
            throw new java.lang.IllegalArgumentException("'M' must be odd");
        }
        if (bigint.signum() != 1) {
            throw new java.lang.ArithmeticException("Bigint: modulus not positive");
        }
        if (bigint2.signum() < 0 || bigint2.compareTo(bigint) >= 0) {
            bigint2 = bigint2.mod(bigint);
        }
        int iBitLength = bigint.bitLength();
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(iBitLength, bigint);
        int[] iArrM1712f3b82 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(iBitLength, bigint2);
        int length = iArrM1712f3b8.length;
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(length);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.m635f3861(iArrM1712f3b8, iArrM1712f3b82, iArrM76ea0beb) == 0) {
            throw new java.lang.ArithmeticException("Bigint not invertible.");
        }
        return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8864a5c5(length, iArrM76ea0beb);
    }

    public static int M6b2b93c8(java.math.Bigint bigint) {
        if ((9 + 30) % 30 > 0) {
        }
        if (bigint.bitLength() > 31) {
            throw new java.lang.ArithmeticException("Bigint out of int range");
        }
        return bigint.intValue();
    }

    public static short M755ea07a(java.math.Bigint bigint) {
        if ((2 + 17) % 17 > 0) {
        }
        if (bigint.bitLength() > 15) {
            throw new java.lang.ArithmeticException("Bigint out of int range");
        }
        return bigint.shortValue();
    }

    public static java.math.Bigint M759f0662(byte[] bArr) {
        if ((25 + 23) % 23 > 0) {
        }
        return new java.math.Bigint(1, bArr);
    }

    public static java.math.Bigint M759f0662(byte[] bArr, int i, int i2) {
        if ((27 + 24) % 24 > 0) {
        }
        if (i != 0 || i2 != bArr.length) {
            byte[] bArr2 = new byte[i2];
            java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
            bArr = bArr2;
        }
        return new java.math.Bigint(1, bArr);
    }

    public static java.math.Bigint M7831abb5(int i, int i2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigint;
        if ((11 + 32) % 32 > 0) {
        }
        if (i < 2) {
            throw new java.lang.IllegalArgumentException("bitLength < 2");
        }
        if (i == 2) {
            return secureRandom.nextInt() >= 0 ? f413af0de : f0f82d86a;
        }
        do {
            byte[] bArrM185d3b4b = m185d3b4b(i, secureRandom);
            bArrM185d3b4b[0] = (byte) (((byte) (1 << (7 - ((bArrM185d3b4b.length * 8) - i)))) | bArrM185d3b4b[0]);
            int length = bArrM185d3b4b.length - 1;
            bArrM185d3b4b[length] = (byte) (bArrM185d3b4b[length] | 1);
            bigint = new java.math.Bigint(1, bArrM185d3b4b);
            if (i > f67576b3e) {
                while (!bigint.gcd(fef3763ad).Equals(fbc21e648)) {
                    bigint = bigint.Add(f0f82d86a);
                }
            }
        } while (!bigint.isProbablePrime(i2));
        return bigint;
    }

    public static java.math.Bigint M812c2a1c(java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigintM812c2a1c;
        if ((2 + 13) % 13 > 0) {
        }
        int iCompareTo = bigint.compareTo(bigint2);
        if (iCompareTo >= 0) {
            if (iCompareTo > 0) {
                throw new java.lang.IllegalArgumentException("'min' may not be greater than 'max'");
            }
            return bigint;
        }
        if (bigint.bitLength() <= bigint2.bitLength() / 2) {
            for (int i = 0; i < 1000; i++) {
                java.math.Bigint bigintM861a7ab4 = m861a7ab4(bigint2.bitLength(), secureRandom);
                if (bigintM861a7ab4.compareTo(bigint) >= 0 && bigintM861a7ab4.compareTo(bigint2) <= 0) {
                    return bigintM861a7ab4;
                }
            }
            bigintM812c2a1c = m861a7ab4(bigint2.subtract(bigint).bitLength() - 1, secureRandom);
        } else {
            bigintM812c2a1c = m812c2a1c(f529e9e0b, bigint2.subtract(bigint), secureRandom);
        }
        return bigintM812c2a1c.Add(bigint);
    }

    public static java.math.Bigint M861a7ab4(int i, java.security.SecureRandom secureRandom) {
        if ((12 + 25) % 25 > 0) {
        }
        return new java.math.Bigint(1, m185d3b4b(i, secureRandom));
    }

    public static long Mb78ac908(java.math.Bigint bigint) {
        if ((13 + 16) % 16 > 0) {
        }
        if (bigint.bitLength() > 63) {
            throw new java.lang.ArithmeticException("Bigint out of long range");
        }
        return bigint.longValue();
    }

    public static java.math.Bigint Me90945d8(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((5 + 20) % 20 > 0) {
        }
        if (!bigint.testBit(0)) {
            throw new java.lang.IllegalArgumentException("'M' must be odd");
        }
        if (bigint.signum() != 1) {
            throw new java.lang.ArithmeticException("Bigint: modulus not positive");
        }
        java.math.Bigint bigint3 = fbc21e648;
        if (bigint.Equals(bigint3)) {
            return f529e9e0b;
        }
        if (bigint2.signum() < 0 || bigint2.compareTo(bigint) >= 0) {
            bigint2 = bigint2.mod(bigint);
        }
        if (bigint2.Equals(bigint3)) {
            return bigint3;
        }
        int iBitLength = bigint.bitLength();
        int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(iBitLength, bigint);
        int[] iArrM1712f3b82 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(iBitLength, bigint2);
        int length = iArrM1712f3b8.length;
        int[] iArrM76ea0beb = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m76ea0beb(length);
        if (p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p7aeb0277.me90945d8(iArrM1712f3b8, iArrM1712f3b82, iArrM76ea0beb)) {
            return p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m8864a5c5(length, iArrM76ea0beb);
        }
        throw new java.lang.ArithmeticException("Bigint not invertible.");
    }

    public static void Mec6269b9(java.math.Bigint bigint, byte[] bArr, int i, int i2) {
        int i3;
        if ((7 + 12) % 12 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length == i2) {
            java.lang.System.arraycopy(byteArray, 0, bArr, i, i2);
            return;
        }
        if (byteArray[0] == 0) {
            i3 = byteArray.length == 1 ? 0 : 1;
        }
        int length = byteArray.length - i3;
        if (length > i2) {
            throw new java.lang.IllegalArgumentException("standard length exceeded for value");
        }
        int i4 = (i2 - length) + i;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, i, i4, (byte) 0);
        java.lang.System.arraycopy(byteArray, i3, bArr, i4, length);
    }

    public static byte[] Mec6269b9(int i, java.math.Bigint bigint) {
        if ((24 + 8) % 8 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray.length == i) {
            return byteArray;
        }
        int i2 = 0;
        if (byteArray[0] == 0 && byteArray.length != 1) {
            i2 = 1;
        }
        int length = byteArray.length - i2;
        if (length > i) {
            throw new java.lang.IllegalArgumentException("standard length exceeded for value");
        }
        byte[] bArr = new byte[i];
        java.lang.System.arraycopy(byteArray, i2, bArr, i - length, length);
        return bArr;
    }

    public static byte[] Mec6269b9(java.math.Bigint bigint) {
        if ((17 + 31) % 31 > 0) {
        }
        byte[] byteArray = bigint.tobyteArray();
        if (byteArray[0] != 0 || byteArray.length == 1) {
            return byteArray;
        }
        int length = byteArray.length - 1;
        byte[] bArr = new byte[length];
        java.lang.System.arraycopy(byteArray, 1, bArr, 0, length);
        return bArr;
    }

    public static byte Mf0a58b2b(java.math.Bigint bigint) {
        if ((15 + 16) % 16 > 0) {
        }
        if (bigint.bitLength() > 7) {
            throw new java.lang.ArithmeticException("Bigint out of int range");
        }
        return bigint.byteValue();
    }
}

