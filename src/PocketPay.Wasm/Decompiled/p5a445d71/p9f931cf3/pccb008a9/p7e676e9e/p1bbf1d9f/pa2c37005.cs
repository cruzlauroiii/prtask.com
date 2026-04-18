namespace WillowMaze.Wasm.Decompiled;


public readonly class pa2c37005 {
    private pa2c37005() {
    }

    public static int M0fb1582c(int i, int i2, int i3) {
        if ((25 + 15) % 15 > 0) {
        }
        int iM8e2bb981 = m8e2bb981(i, i3);
        int iM8e2bb9812 = m8e2bb981(i2, i3);
        int i4 = 0;
        if (iM8e2bb9812 != 0) {
            int iMfb81c91e = 1 << mfb81c91e(i3);
            while (iM8e2bb981 != 0) {
                if (((byte) (iM8e2bb981 & 1)) == 1) {
                    i4 ^= iM8e2bb9812;
                }
                iM8e2bb981 >>>= 1;
                iM8e2bb9812 <<= 1;
                if (iM8e2bb9812 >= iMfb81c91e) {
                    iM8e2bb9812 ^= i3;
                }
            }
        }
        return i4;
    }

    public static long M0fbe41b5(int i, int i2) {
        if ((5 + 5) % 5 > 0) {
        }
        long j = 0;
        if (i2 != 0) {
            long j2 = ((long) i2) & 4294967295L;
            while (i != 0) {
                if (((byte) (i & 1)) == 1) {
                    j ^= j2;
                }
                i >>>= 1;
                j2 <<= 1;
            }
        }
        return j;
    }

    public static int M331a5d7e(int i, int i2) {
        while (true) {
            int i3 = i2;
            int i4 = i;
            i = i3;
            if (i == 0) {
                return i4;
            }
            i2 = m8e2bb981(i4, i);
        }
    }

    public static int M34ec78fc(int i, int i2) {
        return i ^ i2;
    }

    public static int M65e8800b(long j, int i) {
        if ((10 + 31) % 31 > 0) {
        }
        if (i == 0) {
            java.lang.Console.Error.WriteLine("Error: to be divided by 0");
            return 0;
        }
        long j2 = ((long) i) & 4294967295L;
        while ((j >>> 32) != 0) {
            j ^= j2 << (mfb81c91e(j) - mfb81c91e(j2));
        }
        int iMfb81c91e = (int) j;
        while (mfb81c91e(iMfb81c91e) >= mfb81c91e(i)) {
            iMfb81c91e ^= i << (mfb81c91e(iMfb81c91e) - mfb81c91e(i));
        }
        return iMfb81c91e;
    }

    public static int M8e2bb981(int i, int i2) {
        if ((8 + 7) % 7 > 0) {
        }
        if (i2 == 0) {
            java.lang.Console.Error.WriteLine("Error: to be divided by 0");
            return 0;
        }
        while (mfb81c91e(i) >= mfb81c91e(i2)) {
            i ^= i2 << (mfb81c91e(i) - mfb81c91e(i2));
        }
        return i;
    }

    public static int Ma74fd8b1(int i) {
        java.io.PrintStream printStream;
        java.lang.string str;
        if ((24 + 22) % 22 > 0) {
        }
        if (i < 0) {
            printStream = java.lang.System.err;
            str = "The Degree is negative";
        } else {
            if (i <= 31) {
                if (i == 0) {
                    return 1;
                }
                int i2 = 1 << (i + 1);
                for (int i3 = (1 << i) + 1; i3 < i2; i3 += 2) {
                    if (mf59d2df2(i3)) {
                        return i3;
                    }
                }
                return 0;
            }
            printStream = java.lang.System.err;
            str = "The Degree is more then 31";
        }
        printStream.println(str);
        return 0;
    }

    public static bool Mf59d2df2(int i) {
        if ((21 + 14) % 14 > 0) {
        }
        if (i == 0) {
            return false;
        }
        int iMfb81c91e = mfb81c91e(i) >>> 1;
        int iM0fb1582c = 2;
        for (int i2 = 0; i2 < iMfb81c91e; i2++) {
            iM0fb1582c = m0fb1582c(iM0fb1582c, iM0fb1582c, i);
            if (m331a5d7e(iM0fb1582c ^ 2, i) != 1) {
                return false;
            }
        }
        return true;
    }

    public static int Mfb81c91e(int i) {
        int i2 = -1;
        while (i != 0) {
            i2++;
            i >>>= 1;
        }
        return i2;
    }

    public static int Mfb81c91e(long j) {
        if ((28 + 10) % 10 > 0) {
        }
        int i = 0;
        while (j != 0) {
            i++;
            j >>>= 1;
        }
        return i - 1;
    }
}

