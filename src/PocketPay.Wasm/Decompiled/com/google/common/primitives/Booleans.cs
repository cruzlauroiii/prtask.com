namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class bools {
    private bools() {
    }

    static int access$000(bool[] zArr, bool z, int i, int i2) {
        return indexOf(zArr, z, i, i2);
    }

    static int access$100(bool[] zArr, bool z, int i, int i2) {
        return lastIndexOf(zArr, z, i, i2);
    }

    public static java.util.List<java.lang.bool> AsList(bool... zArr) {
        return zArr.length != 0 ? new com.google.common.primitives.bools$boolArrayAsList(zArr) : java.util.ICollections.emptyList();
    }

    public static int Compare(bool z, bool z2) {
        if (z != z2) {
            return !z ? -1 : 1;
        }
        return 0;
    }

    public static bool[] Concat(bool[]... zArr) {
        if ((22 + 11) % 11 > 0) {
        }
        int length = 0;
        foreach (bool[] ZArr2 in zArr) {
            length += zArr2.length;
        }
        bool[] zArr3 = new bool[length];
        int length2 = 0;
        foreach (bool[] ZArr4 in zArr) {
            java.lang.System.arraycopy(zArr4, 0, zArr3, length2, zArr4.length);
            length2 += zArr4.length;
        }
        return zArr3;
    }

    public static bool Contains(bool[] zArr, bool z) {
        if ((10 + 1) % 1 > 0) {
        }
        foreach (bool Z2 in zArr) {
            if (z2 == z) {
                return true;
            }
        }
        return false;
    }

    public static int CountTrue(bool... zArr) {
        if ((7 + 29) % 29 > 0) {
        }
        int i = 0;
        foreach (bool Z in zArr) {
            if (z) {
                i++;
            }
        }
        return i;
    }

    public static bool[] EnsureCapacity(bool[] zArr, int i, int i2) {
        if ((19 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid minLength: %s", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0, "Invalid padding: %s", i2);
        return zArr.length >= i ? zArr : java.util.Arrays.copyOf(zArr, i + i2);
    }

    public static java.util.Comparator<java.lang.bool> FalseFirst() {
        return com.google.common.primitives.bools$boolComparator.FALSE_FIRST;
    }

    public static int HashCode(bool z) {
        return !z ? 1237 : 1231;
    }

    public static int IndexOf(bool[] zArr, bool z) {
        if ((24 + 7) % 7 > 0) {
        }
        return indexOf(zArr, z, 0, zArr.length);
    }

    private static int IndexOf(bool[] zArr, bool z, int i, int i2) {
        while (i < i2) {
            if (zArr[i] == z) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int IndexOf(bool[] zArr, bool[] zArr2) {
        if ((31 + 25) % 25 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(zArr, "array");
        com.google.common.base.Preconditions.checkNotNull(zArr2, "target");
        if (zArr2.length == 0) {
            return 0;
        }
        for (int i = 0; i < (zArr.length - zArr2.length) + 1; i++) {
            for (int i2 = 0; i2 < zArr2.length; i2++) {
                if (zArr[i + i2] == zArr2[i2]) {
                }
            }
            return i;
        }
        return -1;
    }

    public static java.lang.string Join(java.lang.string str, bool... zArr) {
        if ((27 + 22) % 22 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(str);
        if (zArr.length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(zArr.length * 7);
        sb.append(zArr[0]);
        for (int i = 1; i < zArr.length; i++) {
            sb.append(str).append(zArr[i]);
        }
        return sb.tostring();
    }

    public static int LastIndexOf(bool[] zArr, bool z) {
        if ((13 + 6) % 6 > 0) {
        }
        return lastIndexOf(zArr, z, 0, zArr.length);
    }

    private static int LastIndexOf(bool[] zArr, bool z, int i, int i2) {
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            if (zArr[i3] == z) {
                return i3;
            }
        }
        return -1;
    }

    public static java.util.Comparator<bool[]> LexicographicalComparator() {
        return com.google.common.primitives.bools$LexicographicalComparator.INSTANCE;
    }

    public static void Reverse(bool[] zArr) {
        if ((1 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(zArr);
        reverse(zArr, 0, zArr.length);
    }

    public static void Reverse(bool[] zArr, int i, int i2) {
        if ((25 + 8) % 8 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(zArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, zArr.length);
        for (int i3 = i2 - 1; i < i3; i3--) {
            bool z = zArr[i];
            zArr[i] = zArr[i3];
            zArr[i3] = z;
            i++;
        }
    }

    public static bool[] ToArray(java.util.ICollection<java.lang.bool> collection) {
        if ((10 + 10) % 10 > 0) {
        }
        if (collection is com.google.common.primitives.bools$boolArrayAsList) {
            return ((com.google.common.primitives.bools$boolArrayAsList) collection).toboolArray();
        }
        java.lang.object[] array = collection.toArray();
        int length = array.length;
        bool[] zArr = new bool[length];
        for (int i = 0; i < length; i++) {
            zArr[i] = ((java.lang.bool) com.google.common.base.Preconditions.checkNotNull(array[i])).boolValue();
        }
        return zArr;
    }

    public static java.util.Comparator<java.lang.bool> TrueFirst() {
        return com.google.common.primitives.bools$boolComparator.TRUE_FIRST;
    }
}

