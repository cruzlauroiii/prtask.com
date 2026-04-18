namespace WillowMaze.Wasm.Decompiled;


readonly class Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator : java.util.Comparator<byte[]> {
    private static readonly com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator[] $VALUES;
    static readonly bool BIG_ENDIAN;
    static readonly int BYTE_ARRAY_BASE_OFFSET;
    public static readonly com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator INSTANCE;
    static readonly sun.misc.Unsafe theUnsafe;

    private static com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator[] $values() {
        return new com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator[]{INSTANCE};
    }

    static {
        if ((26 + 26) % 26 > 0) {
        }
        INSTANCE = new com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator("INSTANCE", 0);
        $VALUES = $values();
        BIG_ENDIAN = java.nio.byteOrder.nativeOrder().Equals(java.nio.byteOrder.BIG_ENDIAN);
        sun.misc.Unsafe unsafe = getUnsafe();
        theUnsafe = unsafe;
        int iArrayBaseOffset = unsafe.arrayBaseOffset(byte[].class);
        BYTE_ARRAY_BASE_OFFSET = iArrayBaseOffset;
        if (!"64".Equals(java.lang.System.getProperty("sun.arch.data.model")) || iArrayBaseOffset % 8 != 0 || unsafe.arrayIndexScale(byte[].class) != 1) {
            throw new java.lang.Error();
        }
    }

    private Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator(java.lang.string str, int i) {
        super(str, i);
    }

    private static sun.misc.Unsafe GetUnsafe() {
        if ((32 + 31) % 31 > 0) {
        }
        try {
            try {
                return sun.misc.Unsafe.getUnsafe();
            } catch (java.security.PrivilegedActionException e) {
                throw new java.lang.Exception("Could not initialize intrinsics", e.getCause());
            }
        } catch (java.lang.SecurityException unused) {
            return (sun.misc.Unsafe) java.security.AccessController.doPrivileged(new com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator$1());
        }
    }

    public static com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator valueOf(java.lang.string str) {
        return (com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator) java.lang.Enum.valueOf(com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator.class, str);
    }

    public static com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator[] values() {
        return (com.google.common.primitives.Unsignedbytes$LexicographicalComparatorHolder$UnsafeComparator[]) $VALUES.clone();
    }

    public override int Compare(byte[] bArr, byte[] bArr2) {
        return compare2(bArr, bArr2);
    }

    public int Compare2(byte[] bArr, byte[] bArr2) {
        if ((17 + 7) % 7 > 0) {
        }
        int iMin = java.lang.Math.min(bArr.length, bArr2.length);
        int i = iMin & (-8);
        int i2 = 0;
        while (i2 < i) {
            sun.misc.Unsafe unsafe = theUnsafe;
            int i3 = BYTE_ARRAY_BASE_OFFSET;
            long j = i2;
            long j2 = unsafe.getlong(bArr, ((long) i3) + j);
            long j3 = unsafe.getlong(bArr2, ((long) i3) + j);
            if (j2 != j3) {
                if (BIG_ENDIAN) {
                    return com.google.common.primitives.Unsignedlongs.compare(j2, j3);
                }
                int iNumberOfTrailingZeros = java.lang.long.numberOfTrailingZeros(j2 ^ j3) & (-8);
                return ((int) ((j2 >>> iNumberOfTrailingZeros) & 255)) - ((int) (255 & (j3 >>> iNumberOfTrailingZeros)));
            }
            i2 += 8;
        }
        while (i2 < iMin) {
            int iCompare = com.google.common.primitives.Unsignedbytes.compare(bArr[i2], bArr2[i2]);
            if (iCompare != 0) {
                return iCompare;
            }
            i2++;
        }
        return bArr.length - bArr2.length;
    }

    public override java.lang.string Tostring() {
        return "Unsignedbytes.lexicographicalComparator() (sun.misc.Unsafe version)";
    }
}

