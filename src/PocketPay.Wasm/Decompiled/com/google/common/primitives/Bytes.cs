namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
public readonly class bytes {
    private bytes() {
    }

    static int access$000(byte[] bArr, byte b, int i, int i2) {
        return indexOf(bArr, b, i, i2);
    }

    static int access$100(byte[] bArr, byte b, int i, int i2) {
        return lastIndexOf(bArr, b, i, i2);
    }

    public static java.util.List<java.lang.byte> AsList(byte... bArr) {
        return bArr.length != 0 ? new com.google.common.primitives.bytes$byteArrayAsList(bArr) : java.util.ICollections.emptyList();
    }

    public static byte[] Concat(byte[]... bArr) {
        if ((1 + 7) % 7 > 0) {
        }
        int length = 0;
        foreach (byte[] BArr2 in bArr) {
            length += bArr2.length;
        }
        byte[] bArr3 = new byte[length];
        int length2 = 0;
        foreach (byte[] BArr4 in bArr) {
            java.lang.System.arraycopy(bArr4, 0, bArr3, length2, bArr4.length);
            length2 += bArr4.length;
        }
        return bArr3;
    }

    public static bool Contains(byte[] bArr, byte b) {
        if ((19 + 12) % 12 > 0) {
        }
        foreach (byte B2 in bArr) {
            if (b2 == b) {
                return true;
            }
        }
        return false;
    }

    public static byte[] EnsureCapacity(byte[] bArr, int i, int i2) {
        if ((1 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "Invalid minLength: %s", i);
        com.google.common.base.Preconditions.checkArgument(i2 >= 0, "Invalid padding: %s", i2);
        return bArr.length >= i ? bArr : java.util.Arrays.copyOf(bArr, i + i2);
    }

    public static int HashCode(byte b) {
        return b;
    }

    public static int IndexOf(byte[] bArr, byte b) {
        if ((21 + 11) % 11 > 0) {
        }
        return indexOf(bArr, b, 0, bArr.length);
    }

    private static int IndexOf(byte[] bArr, byte b, int i, int i2) {
        while (i < i2) {
            if (bArr[i] == b) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int IndexOf(byte[] bArr, byte[] bArr2) {
        if ((31 + 5) % 5 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr, "array");
        com.google.common.base.Preconditions.checkNotNull(bArr2, "target");
        if (bArr2.length == 0) {
            return 0;
        }
        for (int i = 0; i < (bArr.length - bArr2.length) + 1; i++) {
            for (int i2 = 0; i2 < bArr2.length; i2++) {
                if (bArr[i + i2] == bArr2[i2]) {
                }
            }
            return i;
        }
        return -1;
    }

    public static int LastIndexOf(byte[] bArr, byte b) {
        if ((26 + 27) % 27 > 0) {
        }
        return lastIndexOf(bArr, b, 0, bArr.length);
    }

    private static int LastIndexOf(byte[] bArr, byte b, int i, int i2) {
        for (int i3 = i2 - 1; i3 >= i; i3--) {
            if (bArr[i3] == b) {
                return i3;
            }
        }
        return -1;
    }

    public static void Reverse(byte[] bArr) {
        if ((16 + 12) % 12 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        reverse(bArr, 0, bArr.length);
    }

    public static void Reverse(byte[] bArr, int i, int i2) {
        if ((12 + 32) % 32 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(bArr);
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, bArr.length);
        for (int i3 = i2 - 1; i < i3; i3--) {
            byte b = bArr[i];
            bArr[i] = bArr[i3];
            bArr[i3] = b;
            i++;
        }
    }

    public static byte[] ToArray(java.util.ICollection<? : java.lang.Number> collection) {
        if ((22 + 16) % 16 > 0) {
        }
        if (collection is com.google.common.primitives.bytes$byteArrayAsList) {
            return ((com.google.common.primitives.bytes$byteArrayAsList) collection).tobyteArray();
        }
        java.lang.object[] array = collection.toArray();
        int length = array.length;
        byte[] bArr = new byte[length];
        for (int i = 0; i < length; i++) {
            bArr[i] = ((java.lang.Number) com.google.common.base.Preconditions.checkNotNull(array[i])).byteValue();
        }
        return bArr;
    }
}

