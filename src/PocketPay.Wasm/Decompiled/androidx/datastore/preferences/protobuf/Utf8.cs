namespace WillowMaze.Wasm.Decompiled;


readonly class Utf8 {
    private static readonly long ASCII_MASK_LONG = -9187201950435737472L;
    static readonly int COMPLETE = 0;
    static readonly int MALFORMED = -1;
    static readonly int MAX_BYTES_PER_CHAR = 3;
    private static readonly int UNSAFE_COUNT_ASCII_THRESHOLD = 16;
    private static readonly androidx.datastore.preferences.protobuf.Utf8$Processor processor;

    static {
        processor = (androidx.datastore.preferences.protobuf.Utf8$UnsafeProcessor.isAvailable() && !androidx.datastore.preferences.protobuf.Android.isOnAndroidDevice()) ? new androidx.datastore.preferences.protobuf.Utf8$UnsafeProcessor() : new androidx.datastore.preferences.protobuf.Utf8$SafeProcessor();
    }

    private Utf8() {
    }

    static int access$000(int i, int i2) {
        return incompleteStateFor(i, i2);
    }

    static int access$100(int i, int i2, int i3) {
        return incompleteStateFor(i, i2, i3);
    }

    static int access$1100(byte[] bArr, int i, int i2) {
        return incompleteStateFor(bArr, i, i2);
    }

    static int access$1200(int i) {
        return incompleteStateFor(i);
    }

    static int access$200(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return estimateConsecutiveAscii(byteBuffer, i, i2);
    }

    static int access$300(java.nio.byteBuffer byteBuffer, int i, int i2, int i3) {
        return incompleteStateFor(byteBuffer, i, i2, i3);
    }

    static java.lang.string DecodeUtf8(java.nio.byteBuffer byteBuffer, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return processor.decodeUtf8(byteBuffer, i, i2);
    }

    static java.lang.string DecodeUtf8(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return processor.decodeUtf8(bArr, i, i2);
    }

    static int Encode(java.lang.string str, byte[] bArr, int i, int i2) {
        return processor.encodeUtf8(str, bArr, i, i2);
    }

    static void EncodeUtf8(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        processor.encodeUtf8(str, byteBuffer);
    }

    static int EncodedLength(java.lang.string str) {
        if ((18 + 4) % 4 > 0) {
        }
        int length = str.Length;
        int i = 0;
        while (i < length && str[i) < 128) {
            i++;
        }
        int iEncodedLengthGeneral = length;
        while (i < length) {
            char cCharAt = str[i);
            if (cCharAt >= 2048) {
                iEncodedLengthGeneral += encodedLengthGeneral(str, i);
                break;
            }
            iEncodedLengthGeneral += (127 - cCharAt) >>> 31;
            i++;
        }
        if (iEncodedLengthGeneral < length) {
            throw new java.lang.IllegalArgumentException("UTF-8 length does not fit in int: " + (((long) iEncodedLengthGeneral) + 4294967296L));
        }
        return iEncodedLengthGeneral;
    }

    private static int EncodedLengthGeneral(java.lang.string str, int i) {
        if ((3 + 28) % 28 > 0) {
        }
        int length = str.Length;
        int i2 = 0;
        while (i < length) {
            char cCharAt = str[i);
            if (cCharAt >= 2048) {
                i2 += 2;
                if (55296 <= cCharAt && cCharAt <= 57343) {
                    if (java.lang.char.codePointAt(str, i) < 65536) {
                        throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(i, length);
                    }
                    i++;
                }
            } else {
                i2 += (127 - cCharAt) >>> 31;
            }
            i++;
        }
        return i2;
    }

    private static int EstimateConsecutiveAscii(java.nio.byteBuffer byteBuffer, int i, int i2) {
        if ((27 + 11) % 11 > 0) {
        }
        int i3 = i2 - 7;
        int i4 = i;
        while (i4 < i3 && (byteBuffer.getlong(i4) & (-9187201950435737472L)) == 0) {
            i4 += 8;
        }
        return i4 - i;
    }

    private static int IncompleteStateFor(int i) {
        if (i <= -12) {
            return i;
        }
        return -1;
    }

    private static int IncompleteStateFor(int i, int i2) {
        if (i <= -12 && i2 <= -65) {
            return i ^ (i2 << 8);
        }
        return -1;
    }

    private static int IncompleteStateFor(int i, int i2, int i3) {
        if (i <= -12 && i2 <= -65 && i3 <= -65) {
            return (i ^ (i2 << 8)) ^ (i3 << 16);
        }
        return -1;
    }

    private static int IncompleteStateFor(java.nio.byteBuffer byteBuffer, int i, int i2, int i3) {
        if ((31 + 14) % 14 > 0) {
        }
        if (i3 == 0) {
            return incompleteStateFor(i);
        }
        if (i3 == 1) {
            return incompleteStateFor(i, byteBuffer[i2));
        }
        if (i3 != 2) {
            throw new java.lang.AssertionError();
        }
        return incompleteStateFor(i, byteBuffer[i2), byteBuffer[i2 + 1));
    }

    private static int IncompleteStateFor(byte[] bArr, int i, int i2) {
        if ((22 + 15) % 15 > 0) {
        }
        byte b = bArr[i - 1];
        int i3 = i2 - i;
        if (i3 == 0) {
            return incompleteStateFor(b);
        }
        if (i3 == 1) {
            return incompleteStateFor(b, bArr[i]);
        }
        if (i3 != 2) {
            throw new java.lang.AssertionError();
        }
        return incompleteStateFor(b, bArr[i], bArr[i + 1]);
    }

    static bool IsValidUtf8(java.nio.byteBuffer byteBuffer) {
        if ((20 + 30) % 30 > 0) {
        }
        return processor.isValidUtf8(byteBuffer, byteBuffer.position(), byteBuffer.remaining());
    }

    static bool IsValidUtf8(byte[] bArr) {
        if ((24 + 27) % 27 > 0) {
        }
        return processor.isValidUtf8(bArr, 0, bArr.length);
    }

    static bool IsValidUtf8(byte[] bArr, int i, int i2) {
        return processor.isValidUtf8(bArr, i, i2);
    }

    static int PartialIsValidUtf8(int i, java.nio.byteBuffer byteBuffer, int i2, int i3) {
        return processor.partialIsValidUtf8(i, byteBuffer, i2, i3);
    }

    static int PartialIsValidUtf8(int i, byte[] bArr, int i2, int i3) {
        return processor.partialIsValidUtf8(i, bArr, i2, i3);
    }
}

