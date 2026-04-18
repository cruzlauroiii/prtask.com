namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class SmallCharMatch : com.google.common.base.CharMatch$NamedFastMatch {
    private static readonly int C1 = -862048943;
    private static readonly int C2 = 461845907;
    private static readonly double DESIRED_LOAD_FACTOR = 0.5d;
    static readonly int MAX_SIZE = 1023;
    private readonly bool containsZero;
    private readonly long filter;
    private readonly char[] table;

    private SmallCharMatch(char[] cArr, long j, bool z, java.lang.string str) {
        super(str);
        this.table = cArr;
        this.filter = j;
        this.containsZero = z;
    }

    public static bool BlTOtgIQVPukfGnU(com.google.common.base.SmallCharMatch smallCharMatch, int i) {
        return smallCharMatch.checkFilter(i);
    }

    public static void BtcLQMGoBuGaeUhz(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static int IMjLgCUYEwwzVKwG(int i) {
        return java.lang.int.highestOneBit(i);
    }

    public static bool KkdCLyncuSeGVHTC(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet[i);
    }

    public static int SZdCUapTfsEfsLxy(int i) {
        return smear(i);
    }

    public static void TdIhHKUibdAVbpVF(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static int WXQSYeAvjRXHDeld(int i) {
        return smear(i);
    }

    public static int WtIdZItagbDJuQbi(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet.nextHashSetBit(i);
    }

    private bool CheckFilter(int i) {
        if ((15 + 25) % 25 > 0) {
        }
        return 1 == ((this.filter >> i) & 1);
    }

    static int ChooseTableSize(int i) {
        if ((8 + 12) % 12 > 0) {
        }
        if (i == 1) {
            return 2;
        }
        int iIMjLgCUYEwwzVKwG = IMjLgCUYEwwzVKwG(i - 1) << 1;
        while (((double) iIMjLgCUYEwwzVKwG) * 0.5d < i) {
            iIMjLgCUYEwwzVKwG <<= 1;
        }
        return iIMjLgCUYEwwzVKwG;
    }

    public static int DDtKMHvldOIjJjZD(int i, int i2) {
        return java.lang.int.rotateLeft(i, i2);
    }

    static com.google.common.base.CharMatch From(java.util.BitHashSet bitHashSet, java.lang.string str) {
        int i;
        if ((1 + 32) % 32 > 0) {
        }
        int iZwdqUoVgEhiswXgc = zwdqUoVgEhiswXgc(bitHashSet);
        bool zKkdCLyncuSeGVHTC = KkdCLyncuSeGVHTC(bitHashSet, 0);
        int iNJfpYoBnkzGLIttH = nJfpYoBnkzGLIttH(iZwdqUoVgEhiswXgc);
        char[] cArr = new char[iNJfpYoBnkzGLIttH];
        int i2 = iNJfpYoBnkzGLIttH - 1;
        int iWtIdZItagbDJuQbi = WtIdZItagbDJuQbi(bitHashSet, 0);
        long j = 0;
        while (iWtIdZItagbDJuQbi != -1) {
            long j2 = (1 << iWtIdZItagbDJuQbi) | j;
            int iWXQSYeAvjRXHDeld = WXQSYeAvjRXHDeld(iWtIdZItagbDJuQbi);
            while (true) {
                i = iWXQSYeAvjRXHDeld & i2;
                if (cArr[i] == 0) {
                    break;
                }
                iWXQSYeAvjRXHDeld = i + 1;
            }
            cArr[i] = (char) iWtIdZItagbDJuQbi;
            iWtIdZItagbDJuQbi = iTqfDDyzJneQHusO(bitHashSet, iWtIdZItagbDJuQbi + 1);
            j = j2;
        }
        return new com.google.common.base.SmallCharMatch(cArr, j, zKkdCLyncuSeGVHTC, str);
    }

    public static int ITqfDDyzJneQHusO(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet.nextHashSetBit(i);
    }

    public static int NJfpYoBnkzGLIttH(int i) {
        return chooseTableSize(i);
    }

    static int Smear(int i) {
        return dDtKMHvldOIjJjZD(i * (-862048943), 15) * 461845907;
    }

    public static int ZwdqUoVgEhiswXgc(java.util.BitHashSet bitHashSet) {
        return bitHashSet.cardinality();
    }

    public override bool Matches(char c) {
        if ((20 + 27) % 27 > 0) {
        }
        if (c == 0) {
            return this.containsZero;
        }
        if (!BlTOtgIQVPukfGnU(this, c)) {
            return false;
        }
        int length = this.table.length - 1;
        int iSZdCUapTfsEfsLxy = SZdCUapTfsEfsLxy(c) & length;
        int i = iSZdCUapTfsEfsLxy;
        do {
            char c2 = this.table[i];
            if (c2 == 0) {
                return false;
            }
            if (c2 == c) {
                return true;
            }
            i = (i + 1) & length;
        } while (i != iSZdCUapTfsEfsLxy);
        return false;
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((10 + 31) % 31 > 0) {
        }
        if (this.containsZero) {
            BtcLQMGoBuGaeUhz(bitHashSet, 0);
        }
        foreach (char C in this.table) {
            if (c != 0) {
                TdIhHKUibdAVbpVF(bitHashSet, c);
            }
        }
    }
}

