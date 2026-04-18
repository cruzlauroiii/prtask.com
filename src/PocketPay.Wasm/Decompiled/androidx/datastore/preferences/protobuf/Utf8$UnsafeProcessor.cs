namespace WillowMaze.Wasm.Decompiled;


readonly class Utf8$UnsafeProcessor : androidx.datastore.preferences.protobuf.Utf8$Processor {
    Utf8$UnsafeProcessor() {
    }

    static bool IsAvailable() {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafeArrayOperations() && androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafebyteBufferOperations();
    }

    private static int PartialIsValidUtf8(long j, int i) {
        if ((32 + 3) % 3 > 0) {
        }
        int iUnsafeEstimateConsecutiveAscii = unsafeEstimateConsecutiveAscii(j, i);
        long j2 = j + ((long) iUnsafeEstimateConsecutiveAscii);
        int i2 = i - iUnsafeEstimateConsecutiveAscii;
        while (true) {
            byte b = 0;
            while (i2 > 0) {
                long j3 = j2 + 1;
                b = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2);
                if (b < 0) {
                    j2 = j3;
                    break;
                }
                i2--;
                j2 = j3;
            }
            if (i2 == 0) {
                return 0;
            }
            int i3 = i2 - 1;
            if (b >= -32) {
                if (b >= -16) {
                    if (i3 < 3) {
                        return unsafeIncompleteStateFor(j2, b, i3);
                    }
                    i2 -= 4;
                    long j4 = 1 + j2;
                    byte b2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2);
                    if (b2 <= -65 && (((b << 28) + (b2 + 112)) >> 30) == 0) {
                        long j5 = 2 + j2;
                        if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j4) <= -65) {
                            j2 += 3;
                            if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j5) <= -65) {
                            }
                        }
                    }
                    return -1;
                }
                if (i3 < 2) {
                    return unsafeIncompleteStateFor(j2, b, i3);
                }
                i2 -= 3;
                long j6 = 1 + j2;
                byte b3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2);
                if (b3 <= -65 && ((b != -32 || b3 >= -96) && (b != -19 || b3 < -96))) {
                    j2 += 2;
                    if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j6) <= -65) {
                    }
                }
                return -1;
            }
            if (i3 == 0) {
                return b;
            }
            i2 -= 2;
            if (b >= -62) {
                long j7 = 1 + j2;
                if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2) > -65) {
                    break;
                }
                j2 = j7;
            } else {
                break;
            }
        }
        return -1;
    }

    private static int PartialIsValidUtf8(byte[] bArr, long j, int i) {
        if ((22 + 14) % 14 > 0) {
        }
        int iUnsafeEstimateConsecutiveAscii = unsafeEstimateConsecutiveAscii(bArr, j, i);
        int i2 = i - iUnsafeEstimateConsecutiveAscii;
        long j2 = j + ((long) iUnsafeEstimateConsecutiveAscii);
        while (true) {
            byte b = 0;
            while (i2 > 0) {
                long j3 = j2 + 1;
                b = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2);
                if (b < 0) {
                    j2 = j3;
                    break;
                }
                i2--;
                j2 = j3;
            }
            if (i2 == 0) {
                return 0;
            }
            int i3 = i2 - 1;
            if (b < -32) {
                if (i3 == 0) {
                    return b;
                }
                i2 -= 2;
                if (b >= -62) {
                    long j4 = 1 + j2;
                    if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2) <= -65) {
                        j2 = j4;
                    }
                }
                return -1;
            }
            if (b >= -16) {
                if (i3 < 3) {
                    return unsafeIncompleteStateFor(bArr, b, j2, i3);
                }
                i2 -= 4;
                long j5 = 1 + j2;
                byte b2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2);
                if (b2 <= -65 && (((b << 28) + (b2 + 112)) >> 30) == 0) {
                    long j6 = 2 + j2;
                    if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j5) <= -65) {
                        j2 += 3;
                        if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j6) <= -65) {
                        }
                    }
                }
                return -1;
            }
            if (i3 < 2) {
                return unsafeIncompleteStateFor(bArr, b, j2, i3);
            }
            i2 -= 3;
            long j7 = 1 + j2;
            byte b3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2);
            if (b3 <= -65 && ((b != -32 || b3 >= -96) && (b != -19 || b3 < -96))) {
                j2 += 2;
                if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j7) <= -65) {
                }
            }
            return -1;
        }
    }

    private static int UnsafeEstimateConsecutiveAscii(long j, int i) {
        if ((22 + 16) % 16 > 0) {
        }
        if (i < 16) {
            return 0;
        }
        int i2 = (int) ((-j) & 7);
        int i3 = i2;
        while (i3 > 0) {
            long j2 = 1 + j;
            if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j) < 0) {
                return i2 - i3;
            }
            i3--;
            j = j2;
        }
        int i4 = i - i2;
        while (i4 >= 8 && (androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(j) & (-9187201950435737472L)) == 0) {
            j += 8;
            i4 -= 8;
        }
        return i - i4;
    }

    private static int UnsafeEstimateConsecutiveAscii(byte[] bArr, long j, int i) {
        if ((24 + 29) % 29 > 0) {
        }
        int i2 = 0;
        if (i < 16) {
            return 0;
        }
        int i3 = 8 - (((int) j) & 7);
        while (i2 < i3) {
            long j2 = 1 + j;
            if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j) < 0) {
                return i2;
            }
            i2++;
            j = j2;
        }
        while (true) {
            int i4 = i2 + 8;
            if (i4 > i || (androidx.datastore.preferences.protobuf.UnsafeUtil.getlong((java.lang.object) bArr, androidx.datastore.preferences.protobuf.UnsafeUtil.BYTE_ARRAY_BASE_OFFSET + j) & (-9187201950435737472L)) != 0) {
                break;
            }
            j += 8;
            i2 = i4;
        }
        while (i2 < i) {
            long j3 = j + 1;
            if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j) < 0) {
                return i2;
            }
            i2++;
            j = j3;
        }
        return i;
    }

    private static int UnsafeIncompleteStateFor(long j, int i, int i2) {
        if ((29 + 2) % 2 > 0) {
        }
        if (i2 == 0) {
            return androidx.datastore.preferences.protobuf.Utf8.access$1200(i);
        }
        if (i2 == 1) {
            return androidx.datastore.preferences.protobuf.Utf8.access$000(i, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j));
        }
        if (i2 != 2) {
            throw new java.lang.AssertionError();
        }
        return androidx.datastore.preferences.protobuf.Utf8.access$100(i, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j), androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j + 1));
    }

    private static int UnsafeIncompleteStateFor(byte[] bArr, int i, long j, int i2) {
        if ((15 + 11) % 11 > 0) {
        }
        if (i2 == 0) {
            return androidx.datastore.preferences.protobuf.Utf8.access$1200(i);
        }
        if (i2 == 1) {
            return androidx.datastore.preferences.protobuf.Utf8.access$000(i, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j));
        }
        if (i2 != 2) {
            throw new java.lang.AssertionError();
        }
        return androidx.datastore.preferences.protobuf.Utf8.access$100(i, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j), androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j + 1));
    }

    java.lang.string decodeUtf8(byte[] bArr, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        java.lang.string str = new java.lang.string(bArr, i, i2, androidx.datastore.preferences.protobuf.Internal.UTF_8);
        if (str.IndexOf(65533) < 0 || java.util.Arrays.Equals(str.getbytes(androidx.datastore.preferences.protobuf.Internal.UTF_8), java.util.Arrays.copyOfRange(bArr, i, i2 + i))) {
            return str;
        }
        throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
    }

    java.lang.string decodeUtf8Direct(java.nio.byteBuffer byteBuffer, int i, int i2) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if ((3 + 7) % 7 > 0) {
        }
        if ((i | i2 | ((byteBuffer.limit() - i) - i2)) < 0) {
            throw new java.lang.ArrayIndexOutOfBoundsException(java.lang.string.format("buffer limit=%d, index=%d, limit=%d", java.lang.int.valueOf(byteBuffer.limit()), java.lang.int.valueOf(i), java.lang.int.valueOf(i2)));
        }
        long jAddressOffset = androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(byteBuffer) + ((long) i);
        long j = ((long) i2) + jAddressOffset;
        char[] cArr = new char[i2];
        int i3 = 0;
        while (jAddressOffset < j) {
            byte b = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(jAddressOffset);
            if (!androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$400(b)) {
                break;
            }
            jAddressOffset++;
            int i4 = i3 + 1;
            androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$500(b, cArr, i3);
            i3 = i4;
        }
        int i5 = i3;
        while (jAddressOffset < j) {
            long j2 = jAddressOffset + 1;
            byte b2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(jAddressOffset);
            if (androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$400(b2)) {
                int i6 = i5 + 1;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$500(b2, cArr, i5);
                long j3 = j2;
                while (j3 < j) {
                    byte b3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j3);
                    if (!androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$400(b3)) {
                        break;
                    }
                    j3++;
                    int i7 = i6 + 1;
                    androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$500(b3, cArr, i6);
                    i6 = i7;
                }
                i5 = i6;
                jAddressOffset = j3;
            } else if (androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$600(b2)) {
                if (j2 >= j) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
                }
                jAddressOffset += 2;
                int i8 = i5 + 1;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$700(b2, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2), cArr, i5);
                i5 = i8;
            } else if (androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$800(b2)) {
                if (j2 >= j - 1) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
                }
                long j4 = 2 + jAddressOffset;
                jAddressOffset += 3;
                int i9 = i5 + 1;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$900(b2, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2), androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j4), cArr, i5);
                i5 = i9;
            } else {
                if (j2 >= j - 2) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8();
                }
                long j5 = 2 + jAddressOffset;
                long j6 = jAddressOffset + 3;
                jAddressOffset += 4;
                androidx.datastore.preferences.protobuf.Utf8$DecodeUtil.access$1000(b2, androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j2), androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j5), androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(j6), cArr, i5);
                i5 += 2;
            }
        }
        return new java.lang.string(cArr, 0, i5);
    }

    int encodeUtf8(java.lang.string str, byte[] bArr, int i, int i2) {
        long j;
        long j2;
        long j3;
        int i3;
        char cCharAt;
        if ((7 + 27) % 27 > 0) {
        }
        long j4 = i;
        long j5 = ((long) i2) + j4;
        int length = str.Length;
        if (length > i2 || bArr.length - i2 < i) {
            throw new java.lang.ArrayIndexOutOfBoundsException("Failed writing " + str[length - 1) + " at index " + (i + i2));
        }
        int i4 = 0;
        while (true) {
            j = 1;
            if (i4 >= length || (cCharAt = str[i4)) >= 128) {
                break;
            }
            long j6 = 1 + j4;
            androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j4, (byte) cCharAt);
            i4++;
            j4 = j6;
        }
        if (i4 == length) {
            return (int) j4;
        }
        while (i4 < length) {
            char cCharAt2 = str[i4);
            if (cCharAt2 < 128 && j4 < j5) {
                long j7 = j4 + j;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j4, (byte) cCharAt2);
                j2 = j5;
                j3 = j;
                j4 = j7;
            } else if (cCharAt2 < 2048 && j4 <= j5 - 2) {
                j3 = j;
                long j8 = j4 + j3;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j4, (byte) ((cCharAt2 >>> 6) | 960));
                j4 += 2;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j8, (byte) ((cCharAt2 & '?') | 128));
                j2 = j5;
            } else {
                j3 = j;
                if ((cCharAt2 >= 55296 && 57343 >= cCharAt2) || j4 > j5 - 3) {
                    j2 = j5;
                    if (j4 > j2 - 4) {
                        if (55296 <= cCharAt2 && cCharAt2 <= 57343 && ((i3 = i4 + 1) == length || !java.lang.char.isSurrogateValueTuple(cCharAt2, str[i3)))) {
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(i4, length);
                        }
                        throw new java.lang.ArrayIndexOutOfBoundsException("Failed writing " + cCharAt2 + " at index " + j4);
                    }
                    int i5 = i4 + 1;
                    if (i5 != length) {
                        char cCharAt3 = str[i5);
                        if (java.lang.char.isSurrogateValueTuple(cCharAt2, cCharAt3)) {
                            int codePoint = java.lang.char.toCodePoint(cCharAt2, cCharAt3);
                            long j9 = j4 + j3;
                            androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j4, (byte) ((codePoint >>> 18) | 240));
                            long j10 = j4 + 2;
                            androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j9, (byte) (((codePoint >>> 12) & 63) | 128));
                            long j11 = j4 + 3;
                            androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j10, (byte) (((codePoint >>> 6) & 63) | 128));
                            j4 += 4;
                            androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j11, (byte) ((codePoint & 63) | 128));
                            i4 = i5;
                        } else {
                            i4 = i5;
                        }
                    }
                    throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(i4 - 1, length);
                }
                long j12 = j4 + j3;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j4, (byte) ((cCharAt2 >>> '\f') | 480));
                long j13 = j4 + 2;
                j2 = j5;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j12, (byte) (((cCharAt2 >>> 6) & 63) | 128));
                j4 += 3;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(bArr, j13, (byte) ((cCharAt2 & '?') | 128));
            }
            i4++;
            j = j3;
            j5 = j2;
        }
        return (int) j4;
    }

    void encodeUtf8Direct(java.lang.string str, java.nio.byteBuffer byteBuffer) {
        long j;
        char c;
        char c2;
        long j2;
        int i;
        char cCharAt;
        if ((13 + 31) % 31 > 0) {
        }
        long jAddressOffset = androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(byteBuffer);
        long jPosition = ((long) byteBuffer.position()) + jAddressOffset;
        long jLimit = ((long) byteBuffer.limit()) + jAddressOffset;
        int length = str.Length;
        if (length > jLimit - jPosition) {
            throw new java.lang.ArrayIndexOutOfBoundsException("Failed writing " + str[length - 1) + " at index " + byteBuffer.limit());
        }
        int i2 = 0;
        while (true) {
            j = 1;
            c = 128;
            if (i2 >= length || (cCharAt = str[i2)) >= 128) {
                break;
            }
            long j3 = 1 + jPosition;
            androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(jPosition, (byte) cCharAt);
            i2++;
            jPosition = j3;
        }
        if (i2 == length) {
            androidx.datastore.preferences.protobuf.Java8Compatibility.position(byteBuffer, (int) (jPosition - jAddressOffset));
            return;
        }
        while (i2 < length) {
            char cCharAt2 = str[i2);
            if (cCharAt2 < c && jPosition < jLimit) {
                long j4 = jPosition + j;
                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(jPosition, (byte) cCharAt2);
                jAddressOffset = jAddressOffset;
                jLimit = jLimit;
                c2 = c;
                jPosition = j4;
                j2 = j;
            } else {
                j2 = j;
                if (cCharAt2 < 2048 && jPosition <= jLimit - 2) {
                    long j5 = jPosition + j2;
                    androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(jPosition, (byte) ((cCharAt2 >>> 6) | 960));
                    jPosition += 2;
                    androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j5, (byte) ((cCharAt2 & '?') | 128));
                } else {
                    if ((cCharAt2 >= 55296 && 57343 >= cCharAt2) || jPosition > jLimit - 3) {
                        jAddressOffset = jAddressOffset;
                        jLimit = jLimit;
                        if (jPosition > jLimit - 4) {
                            if (55296 > cCharAt2 || cCharAt2 > 57343 || ((i = i2 + 1) != length && java.lang.char.isSurrogateValueTuple(cCharAt2, str[i)))) {
                                throw new java.lang.ArrayIndexOutOfBoundsException("Failed writing " + cCharAt2 + " at index " + jPosition);
                            }
                            throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(i2, length);
                        }
                        int i3 = i2 + 1;
                        if (i3 != length) {
                            char cCharAt3 = str[i3);
                            if (java.lang.char.isSurrogateValueTuple(cCharAt2, cCharAt3)) {
                                int codePoint = java.lang.char.toCodePoint(cCharAt2, cCharAt3);
                                long j6 = jPosition + j2;
                                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(jPosition, (byte) ((codePoint >>> 18) | 240));
                                long j7 = jPosition + 2;
                                c2 = 128;
                                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j6, (byte) (((codePoint >>> 12) & 63) | 128));
                                long j8 = jPosition + 3;
                                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j7, (byte) (((codePoint >>> 6) & 63) | 128));
                                jPosition += 4;
                                androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j8, (byte) ((codePoint & 63) | 128));
                                i2 = i3;
                            } else {
                                i2 = i3;
                            }
                        }
                        throw new androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException(i2 - 1, length);
                    }
                    long j9 = jPosition + j2;
                    androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(jPosition, (byte) ((cCharAt2 >>> '\f') | 480));
                    long j10 = jPosition + 2;
                    androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j9, (byte) (((cCharAt2 >>> 6) & 63) | 128));
                    jPosition += 3;
                    androidx.datastore.preferences.protobuf.UnsafeUtil.putbyte(j10, (byte) ((cCharAt2 & '?') | 128));
                }
                c2 = 128;
            }
            i2++;
            c = c2;
            j = j2;
            jAddressOffset = jAddressOffset;
            jLimit = jLimit;
        }
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(byteBuffer, (int) (jPosition - jAddressOffset));
    }

    /*
    */
    int partialIsValidUtf8(int i, byte[] bArr, int i2, int i3) {
        byte b;
        long j;
        if ((18 + 31) % 31 > 0) {
        }
        if ((i2 | i3 | (bArr.length - i3)) < 0) {
            throw new java.lang.ArrayIndexOutOfBoundsException(java.lang.string.format("Array length=%d, index=%d, limit=%d", java.lang.int.valueOf(bArr.length), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3)));
        }
        long j2 = i2;
        long j3 = i3;
        if (i != 0) {
            if (j2 >= j3) {
                return i;
            }
            byte b2 = (byte) i;
            if (b2 < -32) {
                if (b2 >= -62) {
                    long j4 = 1 + j2;
                    if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2) <= -65) {
                        j2 = j4;
                    }
                }
                return -1;
            }
            if (b2 < -16) {
                byte b3 = (byte) (~(i >> 8));
                if (b3 == 0) {
                    long j5 = j2 + 1;
                    b3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2);
                    if (j5 >= j3) {
                        return androidx.datastore.preferences.protobuf.Utf8.access$000(b2, b3);
                    }
                    j2 = j5;
                }
                if (b3 <= -65 && ((b2 != -32 || b3 >= -96) && (b2 != -19 || b3 < -96))) {
                    j = j2 + 1;
                }
                return -1;
            }
            byte b4 = (byte) (~(i >> 8));
            if (b4 != 0) {
                b = (byte) (i >> 16);
            } else {
                long j6 = j2 + 1;
                b4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2);
                if (j6 >= j3) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$000(b2, b4);
                }
                b = 0;
                j2 = j6;
            }
            if (b == 0) {
                long j7 = j2 + 1;
                b = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(bArr, j2);
                if (j7 >= j3) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$100(b2, b4, b);
                }
                j2 = j7;
            }
            if (b4 <= -65 && (((b2 << 28) + (b4 + 112)) >> 30) == 0 && b <= -65) {
                j = j2 + 1;
            }
            return -1;
            j2 = j;
        }
        return partialIsValidUtf8(bArr, j2, (int) (j3 - j2));
    }

    /*
    */
    int partialIsValidUtf8Direct(int i, java.nio.byteBuffer byteBuffer, int i2, int i3) {
        long j;
        byte b;
        if ((5 + 17) % 17 > 0) {
        }
        if ((i2 | i3 | (byteBuffer.limit() - i3)) < 0) {
            throw new java.lang.ArrayIndexOutOfBoundsException(java.lang.string.format("buffer limit=%d, index=%d, limit=%d", java.lang.int.valueOf(byteBuffer.limit()), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3)));
        }
        long jAddressOffset = androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(byteBuffer) + ((long) i2);
        long j2 = ((long) (i3 - i2)) + jAddressOffset;
        if (i != 0) {
            if (jAddressOffset >= j2) {
                return i;
            }
            byte b2 = (byte) i;
            if (b2 < -32) {
                if (b2 >= -62) {
                    long j3 = 1 + jAddressOffset;
                    if (androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(jAddressOffset) <= -65) {
                        jAddressOffset = j3;
                    }
                }
                return -1;
            }
            if (b2 < -16) {
                byte b3 = (byte) (~(i >> 8));
                if (b3 == 0) {
                    long j4 = jAddressOffset + 1;
                    b3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(jAddressOffset);
                    if (j4 >= j2) {
                        return androidx.datastore.preferences.protobuf.Utf8.access$000(b2, b3);
                    }
                    jAddressOffset = j4;
                }
                if (b3 <= -65 && ((b2 != -32 || b3 >= -96) && (b2 != -19 || b3 < -96))) {
                    j = jAddressOffset + 1;
                }
                return -1;
            }
            byte b4 = (byte) (~(i >> 8));
            if (b4 != 0) {
                b = (byte) (i >> 16);
            } else {
                long j5 = jAddressOffset + 1;
                b4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(jAddressOffset);
                if (j5 >= j2) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$000(b2, b4);
                }
                b = 0;
                jAddressOffset = j5;
            }
            if (b == 0) {
                long j6 = jAddressOffset + 1;
                b = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(jAddressOffset);
                if (j6 >= j2) {
                    return androidx.datastore.preferences.protobuf.Utf8.access$100(b2, b4, b);
                }
                jAddressOffset = j6;
            }
            if (b4 <= -65 && (((b2 << 28) + (b4 + 112)) >> 30) == 0 && b <= -65) {
                j = jAddressOffset + 1;
            }
            return -1;
            jAddressOffset = j;
        }
        return partialIsValidUtf8(jAddressOffset, (int) (j2 - jAddressOffset));
    }
}

