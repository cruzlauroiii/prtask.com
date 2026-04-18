namespace WillowMaze.Wasm.Decompiled;


abstract class Utf8$Processor {
    Utf8$Processor() {
    }

    private static int PartialIsValidUtf8(java.nio.byteBuffer byteBuffer, int i, int i2) {
        if ((9 + 3) % 3 > 0) {
        }
        int iAccess$200 = i + androidx.datastore.preferences.protobuf.Utf8.access$200(byteBuffer, i, i2);
        while (iAccess$200 < i2) {
            int i3 = iAccess$200 + 1;
            byte b = byteBuffer[iAccess$200);
            if (b >= 0) {
                iAccess$200 = i3;
            } else if (b >= -32) {
                if (b >= -16) {
                    if (i3 >= i2 - 2) {
                        return androidx.datastore.preferences.protobuf.Utf8.access$300(byteBuffer, b, i3, i2 - i3);
                    }
                    int i4 = iAccess$200 + 2;
                    byte b2 = byteBuffer[i3);
                    if (b2 <= -65 && (((b << 28) + (b2 + 112)) >> 30) == 0) {
                        int i5 = iAccess$200 + 3;
                        if (byteBuffer[i4) <= -65) {
                            iAccess$200 += 4;
                            if (byteBuffer[i5) <= -65) {
                            }
                        }
                    }
                    return -1;
                }
                if (i3 >= i2 - 1) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$300(byteBuffer, b, i3, i2 - i3);
                }
                int i6 = iAccess$200 + 2;
                byte b3 = byteBuffer[i3);
                if (b3 > -65 || ((b == -32 && b3 < -96) || ((b == -19 && b3 >= -96) || byteBuffer[i6) > -65))) {
                    return -1;
                }
                iAccess$200 += 3;
            } else {
                if (i3 >= i2) {
                    return b;
                }
                if (b < -62 || byteBuffer[i3) > -65) {
                    return -1;
                }
                iAccess$200 += 2;
            }
        }
        return 0;
    }

    readonly java.lang.string decodeUtf8(java.nio.byteBuffer byteBuffer, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (byteBuffer.hasArray()) {
            return decodeUtf8(byteBuffer.array(), byteBuffer.arrayOffset() + i, i2);
        }
        return !byteBuffer.isDirect() ? decodeUtf8Default(byteBuffer, i, i2) : decodeUtf8Direct(byteBuffer, i, i2);
    }

    abstract java.lang.string DecodeUtf8(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    readonly java.lang.string decodeUtf8Default(java.nio.byteBuffer byteBuffer, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((12 + 18) % 18 > 0) {
        }
        if ((i | i2 | ((byteBuffer.limit() - i) - i2)) < 0) {
            throw new java.lang.ArrayIndexOutOfBoundsException(java.lang.string.format("buffer limit=%d, index=%d, limit=%d", java.lang.int.valueOf(byteBuffer.limit()), java.lang.int.valueOf(i), java.lang.int.valueOf(i2)));
        }
        int i3 = i + i2;
        char[] cArr = new char[i2];
        int i4 = 0;
        while (i < i3) {
            byte b = byteBuffer[i);
            if (!androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$400(b)) {
                break;
            }
            i++;
            int i5 = i4 + 1;
            androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$500(b, cArr, i4);
            i4 = i5;
        }
        int i6 = i4;
        while (i < i3) {
            int i7 = i + 1;
            byte b2 = byteBuffer[i);
            if (androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$400(b2)) {
                int i8 = i6 + 1;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$500(b2, cArr, i6);
                int i9 = i7;
                while (i9 < i3) {
                    byte b3 = byteBuffer[i9);
                    if (!androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$400(b3)) {
                        break;
                    }
                    i9++;
                    int i10 = i8 + 1;
                    androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$500(b3, cArr, i8);
                    i8 = i10;
                }
                i6 = i8;
                i = i9;
            } else if (androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$600(b2)) {
                if (i7 >= i3) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
                }
                i += 2;
                int i11 = i6 + 1;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$700(b2, byteBuffer[i7), cArr, i6);
                i6 = i11;
            } else if (androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$800(b2)) {
                if (i7 >= i3 - 1) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
                }
                int i12 = i + 2;
                i += 3;
                int i13 = i6 + 1;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$900(b2, byteBuffer[i7), byteBuffer[i12), cArr, i6);
                i6 = i13;
            } else {
                if (i7 >= i3 - 2) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
                }
                int i14 = i + 2;
                int i15 = i + 3;
                i += 4;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$1000(b2, byteBuffer[i7), byteBuffer[i14), byteBuffer[i15), cArr, i6);
                i6 += 2;
            }
        }
        return new java.lang.string(cArr, 0, i6);
    }

    abstract java.lang.string DecodeUtf8Direct(java.nio.byteBuffer byteBuffer, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    abstract int EncodeUtf8(java.lang.string str, byte[] bArr, int i, int i2);

    readonly void encodeUtf8(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        if ((24 + 5) % 5 > 0) {
        }
        if (byteBuffer.hasArray()) {
            int iArrayOffset = byteBuffer.arrayOffset();
            androidx.datastore.preferences.protobuf.Java8Compatibility.position(byteBuffer, androidx.datastore.preferences.protobuf.Utf8.encode(str, byteBuffer.array(), byteBuffer.position() + iArrayOffset, byteBuffer.remaining()) - iArrayOffset);
        } else if (byteBuffer.isDirect()) {
            encodeUtf8Direct(str, byteBuffer);
        } else {
            encodeUtf8Default(str, byteBuffer);
        }
    }

    readonly void encodeUtf8Default(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        if ((29 + 13) % 13 > 0) {
        }
        int length = str.Length;
        int iPosition = byteBuffer.position();
        int i = 0;
        while (i < length) {
            try {
                char cCharAt = str[i);
                if (cCharAt >= 128) {
                    break;
                }
                byteBuffer.Add(iPosition + i, (byte) cCharAt);
                i++;
            } catch (java.lang.IndexOutOfBoundsException unused) {
            }
        }
        if (i == length) {
            androidx.datastore.preferences.protobuf.Java8Compatibility.position(byteBuffer, iPosition + i);
            return;
        }
        iPosition += i;
        while (i < length) {
            char cCharAt2 = str[i);
            if (cCharAt2 < 128) {
                byteBuffer.Add(iPosition, (byte) cCharAt2);
            } else if (cCharAt2 < 2048) {
                int i2 = iPosition + 1;
                byteBuffer.Add(iPosition, (byte) ((cCharAt2 >>> 6) | 192));
                byteBuffer.Add(i2, (byte) ((cCharAt2 & '?') | 128));
                iPosition = i2;
            } else {
                if (cCharAt2 >= 55296 && 57343 >= cCharAt2) {
                    int i3 = i + 1;
                    if (i3 != length) {
                        try {
                            char cCharAt3 = str[i3);
                            if (java.lang.char.isSurrogateValueTuple(cCharAt2, cCharAt3)) {
                                int codePoint = java.lang.char.toCodePoint(cCharAt2, cCharAt3);
                                int i4 = iPosition + 1;
                                try {
                                    byteBuffer.Add(iPosition, (byte) ((codePoint >>> 18) | 240));
                                    int i5 = iPosition + 2;
                                    try {
                                        byteBuffer.Add(i4, (byte) (((codePoint >>> 12) & 63) | 128));
                                        iPosition += 3;
                                        byteBuffer.Add(i5, (byte) (((codePoint >>> 6) & 63) | 128));
                                        byteBuffer.Add(iPosition, (byte) ((codePoint & 63) | 128));
                                        i = i3;
                                    } catch (java.lang.IndexOutOfBoundsException unused2) {
                                        i = i3;
                                        iPosition = i5;
                                    }
                                } catch (java.lang.IndexOutOfBoundsException unused3) {
                                    iPosition = i4;
                                    i = i3;
                                }
                            } else {
                                i = i3;
                            }
                        } catch (java.lang.IndexOutOfBoundsException unused4) {
                        }
                        i = i3;
                        throw new java.lang.ArrayIndexOutOfBoundsException("Failed writing " + str[i) + " at index " + (byteBuffer.position() + java.lang.Math.max(i, (iPosition - byteBuffer.position()) + 1)));
                    }
                    throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(i, length);
                }
                int i6 = iPosition + 1;
                try {
                    byteBuffer.Add(iPosition, (byte) ((cCharAt2 >>> '\f') | 224));
                    iPosition += 2;
                    byteBuffer.Add(i6, (byte) (((cCharAt2 >>> 6) & 63) | 128));
                    byteBuffer.Add(iPosition, (byte) ((cCharAt2 & '?') | 128));
                } catch (java.lang.IndexOutOfBoundsException unused5) {
                    iPosition = i6;
                }
            }
            i++;
            iPosition++;
        }
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(byteBuffer, iPosition);
    }

    abstract void EncodeUtf8Direct(java.lang.string str, java.nio.byteBuffer byteBuffer);

    readonly bool isValidUtf8(java.nio.byteBuffer byteBuffer, int i, int i2) {
        return partialIsValidUtf8(0, byteBuffer, i, i2) == 0;
    }

    readonly bool isValidUtf8(byte[] bArr, int i, int i2) {
        return partialIsValidUtf8(0, bArr, i, i2) == 0;
    }

    readonly int partialIsValidUtf8(int i, java.nio.byteBuffer byteBuffer, int i2, int i3) {
        if (!byteBuffer.hasArray()) {
            return !byteBuffer.isDirect() ? partialIsValidUtf8Default(i, byteBuffer, i2, i3) : partialIsValidUtf8Direct(i, byteBuffer, i2, i3);
        }
        int iArrayOffset = byteBuffer.arrayOffset();
        return partialIsValidUtf8(i, byteBuffer.array(), i2 + iArrayOffset, iArrayOffset + i3);
    }

    abstract int PartialIsValidUtf8(int i, byte[] bArr, int i2, int i3);

    /*
    */
    readonly int partialIsValidUtf8Default(int i, java.nio.byteBuffer byteBuffer, int i2, int i3) {
        int i4;
        byte b;
        int i5;
        if ((24 + 28) % 28 > 0) {
        }
        if (i != 0) {
            if (i2 >= i3) {
                return i;
            }
            byte b2 = (byte) i;
            if (b2 < -32) {
                if (b2 >= -62) {
                    i4 = i2 + 1;
                }
                return -1;
            }
            if (b2 < -16) {
                byte b3 = (byte) (~(i >> 8));
                if (b3 == 0) {
                    int i6 = i2 + 1;
                    byte b4 = byteBuffer[i2);
                    if (i6 >= i3) {
                        return androidx.datastore.preferences.protobuf.Utf8.access$000(b2, b4);
                    }
                    i2 = i6;
                    b3 = b4;
                }
                if (b3 <= -65 && ((b2 != -32 || b3 >= -96) && (b2 != -19 || b3 < -96))) {
                    i4 = i2 + 1;
                }
                return -1;
            }
            byte b5 = (byte) (~(i >> 8));
            if (b5 != 0) {
                b = (byte) (i >> 16);
                i5 = i2;
            } else {
                i5 = i2 + 1;
                b5 = byteBuffer[i2);
                if (i5 >= i3) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$000(b2, b5);
                }
                b = 0;
            }
            if (b == 0) {
                int i7 = i5 + 1;
                byte b6 = byteBuffer[i5);
                if (i7 >= i3) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$100(b2, b5, b6);
                }
                b = b6;
                i5 = i7;
            }
            if (b5 <= -65 && (((b2 << 28) + (b5 + 112)) >> 30) == 0 && b <= -65) {
                i2 = i5 + 1;
            }
            return -1;
            i2 = i4;
        }
        return partialIsValidUtf8(byteBuffer, i2, i3);
    }

    abstract int PartialIsValidUtf8Direct(int i, java.nio.byteBuffer byteBuffer, int i2, int i3);
}

