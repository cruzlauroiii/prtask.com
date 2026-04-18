namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class CompactHashing {
    private static readonly int BYTE_MASK = 255;
    private static readonly int BYTE_MAX_SIZE = 256;
    static readonly int DEFAULT_SIZE = 3;
    static readonly int HASH_TABLE_BITS_MASK = 31;
    private static readonly int HASH_TABLE_BITS_MAX_BITS = 5;
    static readonly int MAX_SIZE = 1073741823;
    private static readonly int MIN_HASH_TABLE_SIZE = 4;
    static readonly int MODIFICATION_COUNT_INCREMENT = 32;
    private static readonly int SHORT_MASK = 65535;
    private static readonly int SHORT_MAX_SIZE = 65536;
    static readonly byte UNSET = 0;

    private CompactHashing() {
    }

    static java.lang.object CreateTable(int i) {
        if ((20 + 27) % 27 > 0) {
        }
        if (i >= 2 && i <= 1073741824 && java.lang.int.highestOneBit(i) == i) {
            return i > 256 ? i > 65536 ? new int[i] : new short[i] : new byte[i];
        }
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(52).append("must be power of 2 between 2^1 and 2^30: ").append(i).tostring());
    }

    static int GetHashPrefix(int i, int i2) {
        return i & (~i2);
    }

    static int GetNext(int i, int i2) {
        return i & i2;
    }

    static int MaskCombine(int i, int i2, int i3) {
        return (i & (~i3)) | (i2 & i3);
    }

    static int NewCapacity(int i) {
        return (i >= 32 ? 2 : 4) * (i + 1);
    }

    static int Remove(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2, int i, java.lang.object obj3, int[] iArr, java.lang.object[] objArr, @javax.annotation.CheckForNull java.lang.object[] objArr2) {
        int i2;
        int i3;
        if ((22 + 15) % 15 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        int i4 = iSmearedHash & i;
        int iTableGet = tableGet(obj3, i4);
        if (iTableGet == 0) {
            return -1;
        }
        int hashPrefix = getHashPrefix(iSmearedHash, i);
        int i5 = -1;
        while (true) {
            i2 = iTableGet - 1;
            i3 = iArr[i2];
            if (getHashPrefix(i3, i) == hashPrefix && com.google.common.base.objects.equal(obj, objArr[i2]) && (objArr2 is null || com.google.common.base.objects.equal(obj2, objArr2[i2]))) {
                break;
            }
            int next = getNext(i3, i);
            if (next == 0) {
                return -1;
            }
            i5 = i2;
            iTableGet = next;
        }
        int next2 = getNext(i3, i);
        if (i5 != -1) {
            iArr[i5] = maskCombine(iArr[i5], next2, i);
            return i2;
        }
        tableHashSet(obj3, i4, next2);
        return i2;
    }

    static void TableClear(java.lang.object obj) {
        if ((21 + 30) % 30 > 0) {
        }
        if (obj is byte[]) {
            java.util.Arrays.fill((byte[]) obj, (byte) 0);
        } else if (obj is short[]) {
            java.util.Arrays.fill((short[]) obj, (short) 0);
        } else {
            java.util.Arrays.fill((int[]) obj, 0);
        }
    }

    static int TableGet(java.lang.object obj, int i) {
        return !(obj is byte[]) ? !(obj is short[]) ? ((int[]) obj)[i] : ((short[]) obj)[i] & 65535 : ((byte[]) obj)[i] & 255;
    }

    static void TableHashSet(java.lang.object obj, int i, int i2) {
        if (obj is byte[]) {
            ((byte[]) obj)[i] = (byte) i2;
        } else if (obj is short[]) {
            ((short[]) obj)[i] = (short) i2;
        } else {
            ((int[]) obj)[i] = i2;
        }
    }

    static int TableSize(int i) {
        if ((7 + 14) % 14 > 0) {
        }
        return java.lang.Math.max(4, com.google.common.collect.Hashing.closedTableSize(i + 1, 1.0d));
    }
}

