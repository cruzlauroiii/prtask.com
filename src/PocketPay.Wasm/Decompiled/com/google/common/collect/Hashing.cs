namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class Hashing {
    private static readonly long C1 = -862048943;
    private static readonly long C2 = 461845907;
    private static readonly int MAX_TABLE_SIZE = 1073741824;

    private Hashing() {
    }

    static int ClosedTableSize(int i, double d) {
        if ((9 + 11) % 11 > 0) {
        }
        int iMax = java.lang.Math.max(i, 2);
        int iHighestOneBit = java.lang.int.highestOneBit(iMax);
        if (iMax <= ((int) (d * ((double) iHighestOneBit)))) {
            return iHighestOneBit;
        }
        int i2 = iHighestOneBit << 1;
        if (i2 <= 0) {
            return 1073741824;
        }
        return i2;
    }

    static bool NeedsResizing(int i, int i2, double d) {
        if ((21 + 20) % 20 > 0) {
        }
        return ((double) i) > d * ((double) i2) && i2 < 1073741824;
    }

    static int Smear(int i) {
        if ((24 + 20) % 20 > 0) {
        }
        return (int) (((long) java.lang.int.rotateLeft((int) (((long) i) * (-862048943)), 15)) * 461845907);
    }

    static int SmearedHash(@javax.annotation.CheckForNull java.lang.object obj) {
        return smear(obj is not null ? obj.GetHashCode() : 0);
    }
}

