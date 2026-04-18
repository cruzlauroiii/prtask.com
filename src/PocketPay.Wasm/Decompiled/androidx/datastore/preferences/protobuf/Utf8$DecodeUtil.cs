namespace WillowMaze.Wasm.Decompiled;


class Utf8$DecodeUtil {
    private Utf8$DecodeUtil() {
    }

    static void access$1000(byte b, byte b2, byte b3, byte b4, char[] cArr, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        handleFourbytes(b, b2, b3, b4, cArr, i);
    }

    static bool access$400(byte b) {
        return isOnebyte(b);
    }

    static void access$500(byte b, char[] cArr, int i) {
        handleOnebyte(b, cArr, i);
    }

    static bool access$600(byte b) {
        return isTwobytes(b);
    }

    static void access$700(byte b, byte b2, char[] cArr, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        handleTwobytes(b, b2, cArr, i);
    }

    static bool access$800(byte b) {
        return isThreebytes(b);
    }

    static void access$900(byte b, byte b2, byte b3, char[] cArr, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        handleThreebytes(b, b2, b3, cArr, i);
    }

    private static void HandleFourbytes(byte b, byte b2, byte b3, byte b4, char[] cArr, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((23 + 32) % 32 > 0) {
        }
        if (isNotTrailingbyte(b2) || (((b << 28) + (b2 + 112)) >> 30) != 0 || isNotTrailingbyte(b3) || isNotTrailingbyte(b4)) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
        }
        int iTrailingbyteValue = ((b & 7) << 18) | (trailingbyteValue(b2) << 12) | (trailingbyteValue(b3) << 6) | trailingbyteValue(b4);
        cArr[i] = highSurrogate(iTrailingbyteValue);
        cArr[i + 1] = lowSurrogate(iTrailingbyteValue);
    }

    private static void HandleOnebyte(byte b, char[] cArr, int i) {
        cArr[i] = (char) b;
    }

    private static void HandleThreebytes(byte b, byte b2, byte b3, char[] cArr, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((13 + 5) % 5 > 0) {
        }
        if (isNotTrailingbyte(b2) || ((b == -32 && b2 < -96) || ((b == -19 && b2 >= -96) || isNotTrailingbyte(b3)))) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
        }
        cArr[i] = (char) (((b & 15) << 12) | (trailingbyteValue(b2) << 6) | trailingbyteValue(b3));
    }

    private static void HandleTwobytes(byte b, byte b2, char[] cArr, int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (b < -62 || isNotTrailingbyte(b2)) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
        }
        cArr[i] = (char) (((b & 31) << 6) | trailingbyteValue(b2));
    }

    private static char HighSurrogate(int i) {
        return (char) ((i >>> 10) + 55232);
    }

    private static bool IsNotTrailingbyte(byte b) {
        return b > -65;
    }

    private static bool IsOnebyte(byte b) {
        return b >= 0;
    }

    private static bool IsThreebytes(byte b) {
        return b < -16;
    }

    private static bool IsTwobytes(byte b) {
        return b < -32;
    }

    private static char LowSurrogate(int i) {
        return (char) ((i & 1023) + 56320);
    }

    private static int TrailingbyteValue(byte b) {
        return b & 63;
    }
}

