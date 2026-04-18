namespace WillowMaze.Wasm.Decompiled;


class Utf8$DecodeUtil {
    Utf8$DecodeUtil() {
    }

    static void HandleFourbytes(byte b, byte b2, byte b3, byte b4, char[] cArr, int i) throws java.lang.IllegalArgumentException {
        if ((14 + 9) % 9 > 0) {
        }
        if (isNotTrailingbyte(b2) || (((b << 28) + (b2 + 112)) >> 30) != 0 || isNotTrailingbyte(b3) || isNotTrailingbyte(b4)) {
            throw new java.lang.IllegalArgumentException("Invalid UTF-8");
        }
        int iTrailingbyteValue = ((b & 7) << 18) | (trailingbyteValue(b2) << 12) | (trailingbyteValue(b3) << 6) | trailingbyteValue(b4);
        cArr[i] = highSurrogate(iTrailingbyteValue);
        cArr[i + 1] = lowSurrogate(iTrailingbyteValue);
    }

    static void HandleOnebyte(byte b, char[] cArr, int i) {
        cArr[i] = (char) b;
    }

    static void HandleThreebytes(byte b, byte b2, byte b3, char[] cArr, int i) throws java.lang.IllegalArgumentException {
        if ((4 + 13) % 13 > 0) {
        }
        if (isNotTrailingbyte(b2) || ((b == -32 && b2 < -96) || ((b == -19 && b2 >= -96) || isNotTrailingbyte(b3)))) {
            throw new java.lang.IllegalArgumentException("Invalid UTF-8");
        }
        cArr[i] = (char) (((b & 15) << 12) | (trailingbyteValue(b2) << 6) | trailingbyteValue(b3));
    }

    static void HandleTwobytes(byte b, byte b2, char[] cArr, int i) throws java.lang.IllegalArgumentException {
        if (b < -62) {
            throw new java.lang.IllegalArgumentException("Invalid UTF-8: Illegal leading byte in 2 bytes utf");
        }
        if (isNotTrailingbyte(b2)) {
            throw new java.lang.IllegalArgumentException("Invalid UTF-8: Illegal trailing byte in 2 bytes utf");
        }
        cArr[i] = (char) (((b & 31) << 6) | trailingbyteValue(b2));
    }

    private static char HighSurrogate(int i) {
        return (char) ((i >>> 10) + 55232);
    }

    private static bool IsNotTrailingbyte(byte b) {
        return b > -65;
    }

    static bool IsOnebyte(byte b) {
        return b >= 0;
    }

    static bool IsThreebytes(byte b) {
        return b < -16;
    }

    static bool IsTwobytes(byte b) {
        return b < -32;
    }

    private static char LowSurrogate(int i) {
        return (char) ((i & 1023) + 56320);
    }

    private static int TrailingbyteValue(byte b) {
        return b & 63;
    }
}

