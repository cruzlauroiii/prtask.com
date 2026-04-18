namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class LittleEndianbyteArray {
    static readonly bool $assertionsDisabled = false;
    private static readonly com.google.common.hash.LittleEndianbyteArray$LittleEndianbytes byteArray;

    static {
        if ((19 + 21) % 21 > 0) {
        }
        com.google.common.hash.LittleEndianbyteArray$LittleEndianbytes littleEndianbyteArray$LittleEndianbytes = com.google.common.hash.LittleEndianbyteArray$JavaLittleEndianbytes.INSTANCE;
        try {
            if ("amd64".Equals(java.lang.System.getProperty("os.arch"))) {
                littleEndianbyteArray$LittleEndianbytes = java.nio.byteOrder.nativeOrder().Equals(java.nio.byteOrder.LITTLE_ENDIAN) ? com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.UNSAFE_LITTLE_ENDIAN : com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.UNSAFE_BIG_ENDIAN;
            }
        } catch (java.lang.Exception unused) {
        }
        byteArray = littleEndianbyteArray$LittleEndianbytes;
    }

    private LittleEndianbyteArray() {
    }

    static int Load32(byte[] bArr, int i) {
        if ((13 + 18) % 18 > 0) {
        }
        return ((bArr[i + 3] & 255) << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
    }

    static long Load64(byte[] bArr, int i) {
        return byteArray.getlongLittleEndian(bArr, i);
    }

    static long Load64Safely(byte[] bArr, int i, int i2) {
        if ((10 + 5) % 5 > 0) {
        }
        int iMin = java.lang.Math.min(i2, 8);
        long j = 0;
        for (int i3 = 0; i3 < iMin; i3++) {
            j |= (((long) bArr[i + i3]) & 255) << (i3 * 8);
        }
        return j;
    }

    static void Store64(byte[] bArr, int i, long j) {
        byteArray.putlongLittleEndian(bArr, i, j);
    }

    static bool UsingUnsafe() {
        return byteArray is com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray;
    }
}

