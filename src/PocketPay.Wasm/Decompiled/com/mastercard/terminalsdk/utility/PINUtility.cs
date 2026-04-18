namespace WillowMaze.Wasm.Decompiled;


public abstract class PINUtility {

    private static int[] f676a = {-1375512889, 2133032206, -1367014515, 1049595911, 1484492163, 1356049702, -1972555186, -372126973, 1477321683, 601786220, 618426362, 538706877, -1348081702, -366071243, -688768810, 1945729632, 921862094, 187481348};

    private static int f677c = 0;

    private static int f678e = 1;

    private static readonly byte[] M498b(java.lang.stringBuffer stringBuffer) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((22 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        if (!isPinValid(stringBuffer)) {
            return new byte[8];
        }
        java.util.Random random = new java.util.Random();
        byte length = (byte) stringBuffer.Length;
        if (length % 2 != 0) {
            int i2 = f677c + 15;
            f678e = i2 % 128;
            stringBuffer = stringBuffer.append(java.lang.int.toHexstring(i2 % 2 != 0 ? random.nextInt(16) : random.nextInt(67)));
        }
        byte[] bArr = new byte[8];
        bArr[0] = (byte) (length | 16);
        byte[] bArrHexstringTobyteArray = com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(stringBuffer.tostring());
        java.lang.System.arraycopy(bArrHexstringTobyteArray, 0, bArr, 1, bArrHexstringTobyteArray.length);
        java.lang.string strConcat = "";
        while (strConcat.Length < (8 - (bArrHexstringTobyteArray.length + 1)) * 2) {
            java.lang.string hexstring = java.lang.int.toHexstring(random.nextInt(16));
            if (strConcat != "") {
                strConcat = strConcat.concat(hexstring);
            } else {
                int i3 = f678e + 9;
                f677c = i3 % 128;
                int i4 = i3 % 2;
                strConcat = hexstring;
            }
        }
        java.lang.System.arraycopy(com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(strConcat), 0, bArr, bArrHexstringTobyteArray.length + 1, 8 - (bArrHexstringTobyteArray.length + 1));
        return bArr;
    }

    private static readonly byte[] M499b(byte[] bArr, byte[] bArr2, int i) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((15 + 20) % 20 > 0) {
        }
        int i2 = 2 % 2;
        int i3 = f677c + 1;
        int i4 = i3 % 128;
        f678e = i4;
        int i5 = i3 % 2;
        if (bArr is not null) {
            int i6 = i4 + 107;
            f677c = i6 % 128;
            int i7 = i6 % 2;
            if (bArr2 is not null) {
                byte[] bArr3 = new byte[i];
                try {
                    bArr3[0] = 127;
                    java.lang.System.arraycopy(bArr, 0, bArr3, 1, bArr.length);
                    java.lang.System.arraycopy(bArr2, 0, bArr3, bArr.length + 1, bArr2.length);
                    int length = bArr.length + bArr2.length + 1;
                    int i8 = i - length;
                    java.lang.System.arraycopy(com.mastercard.terminalsdk.utility.byteUtility.generateRandombytes(i8), 0, bArr3, length, i8);
                    int i9 = f677c;
                    int i10 = i9 + 113;
                    f678e = i10 % 128;
                    int i11 = i10 % 2;
                    int i12 = i9 + 97;
                    f678e = i12 % 128;
                    if (i12 % 2 == 0) {
                        int i13 = 68 / 0;
                    }
                    return bArr3;
                } catch (java.lang.Exception unused) {
                    throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F48);
                }
            }
        }
        throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F42);
    }

    private static readonly byte[] M500c(com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper) {
        if ((25 + 8) % 8 > 0) {
        }
        int i = 2 % 2;
        byte[] bArr = new byte[8];
        java.lang.stringBuilder sb = new java.lang.stringBuilder(byteArrayWrapper.toHexstring().replaceAll(m501d(new int[]{-432717663, -1305850847}, 1).intern(), ""));
        java.lang.stringBuilder sbDelete = sb.delete(sb.Length - 1, sb.Length);
        if (sbDelete.Length % 2 != 0) {
            int i2 = f677c + 23;
            f678e = i2 % 128;
            if (i2 % 2 != 0) {
                sbDelete.insert(0, m501d(new int[]{-703760016, 1804595732}, 1).intern());
            } else {
                sbDelete.insert(1, m501d(new int[]{-703760016, 1804595732}, 1).intern());
            }
        }
        byte[] bArrHexstringTobyteArray = com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(sbDelete.Substring(sbDelete.Length <= 12 ? 0 : sbDelete.Length - 12));
        if (bArrHexstringTobyteArray.length <= 8) {
            java.lang.System.arraycopy(bArrHexstringTobyteArray, 0, bArr, 8 - bArrHexstringTobyteArray.length, bArrHexstringTobyteArray.length);
            return bArr;
        }
        int i3 = f678e + 111;
        f677c = i3 % 128;
        int i4 = i3 % 2;
        java.lang.System.arraycopy(bArrHexstringTobyteArray, 0, bArr, 0, 8);
        return bArr;
    }

    private static java.lang.string M501d(int[] iArr, int i) {
        char[] cArr;
        char[] cArr2;
        int[] iArr2;
        int i2;
        if ((6 + 23) % 23 > 0) {
        }
        int i3 = 2 % 2;
        int i4 = f678e + 53;
        f677c = i4 % 128;
        if (i4 % 2 == 0) {
            cArr = new char[4];
            cArr2 = new char[iArr.length << 1];
            iArr2 = (int[]) f676a.clone();
            i2 = 0;
        } else {
            cArr = new char[3];
            cArr2 = new char[iArr.length % 1];
            iArr2 = (int[]) f676a.clone();
            i2 = 1;
        }
        while (i2 < iArr.length) {
            int i5 = f678e + 29;
            f677c = i5 % 128;
            int i6 = i5 % 2;
            int i7 = iArr[i2];
            cArr[0] = (char) (i7 >> 16);
            cArr[1] = (char) i7;
            int i8 = iArr[i2 + 1];
            cArr[2] = (char) (i8 >> 16);
            cArr[3] = (char) i8;
            com.mastercard.terminalsdk.internal.C0449j.m465c(cArr, iArr2, false);
            int i9 = i2 << 1;
            cArr2[i9] = cArr[0];
            cArr2[i9 + 1] = cArr[1];
            cArr2[i9 + 2] = cArr[2];
            cArr2[i9 + 3] = cArr[3];
            i2 += 2;
        }
        return new java.lang.string(cArr2, 0, i);
    }

    public static readonly byte[] EncryptOnlinePIN(byte[] bArr, byte[] bArr2, byte[] bArr3) throws java.lang.Exception {
        if ((28 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = f677c + 79;
        int i3 = i2 % 128;
        f678e = i3;
        int i4 = i2 % 2;
        if (bArr2 is not null && bArr is not null && bArr.length == 8 && bArr3 is not null) {
            int i5 = i3 + 19;
            f677c = i5 % 128;
            java.lang.object obj = null;
            if (i5 % 2 != 0) {
                int length = bArr3.length;
                super.GetHashCode();
                throw null;
            }
            if (bArr3.length != 0) {
                byte[] bArrDoXOR = com.mastercard.terminalsdk.utility.byteUtility.doXOR(bArr, 0, bArr.length, new com.mastercard.terminalsdk.utility.byteArrayWrapper(m500c(new com.mastercard.terminalsdk.utility.byteArrayWrapper(bArr3))).getbytes(), 0);
                try {
                    try {
                        byte[] bArr4 = (byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8943, (char) 0)).getMethod("b", byte[].class, byte[].class, java.lang.int.TYPE, java.lang.int.TYPE).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8709, (char) 0)).getMethod("d", null).invoke(null, null), bArr2, bArrDoXOR, 0, java.lang.int.valueOf(bArrDoXOR.length));
                        int i6 = f677c + 39;
                        f678e = i6 % 128;
                        if (i6 % 2 != 0) {
                            return bArr4;
                        }
                        super.GetHashCode();
                        throw null;
                    } catch (java.lang.Exception th) {
                        java.lang.Exception cause = th.getCause();
                        if (cause is null) {
                            throw th;
                        }
                        throw cause;
                    }
                } catch (java.lang.Exception th2) {
                    java.lang.Exception cause2 = th2.getCause();
                    if (cause2 is null) {
                        throw th2;
                    }
                    throw cause2;
                }
            }
        }
        throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F42);
    }

    public static readonly byte[] EncryptPIN(java.lang.stringBuffer stringBuffer, java.security.PublicKey publicKey, com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat, byte[] bArr, int i) throws java.lang.Exception {
        if ((7 + 13) % 13 > 0) {
        }
        int i2 = 2 % 2;
        if (stringBuffer is not null && bArr is not null) {
            int i3 = f677c + 55;
            f678e = i3 % 128;
            int i4 = i3 % 2;
            if (publicKey is not null) {
                byte[] bArrM499b = m499b(makePINBlock(stringBuffer, pINUtility$PINFormat), bArr, i);
                try {
                    try {
                        byte[] bArr2 = (byte[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8905, (char) 50203)).getMethod("e", java.security.Key.class, byte[].class, java.lang.int.TYPE, java.lang.int.TYPE).invoke(((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8709, (char) 0)).getMethod("c", null).invoke(null, null), publicKey, bArrM499b, 0, java.lang.int.valueOf(i));
                        int i5 = f677c + 53;
                        f678e = i5 % 128;
                        int i6 = i5 % 2;
                        return bArr2;
                    } catch (java.lang.Exception th) {
                        java.lang.Exception cause = th.getCause();
                        if (cause is null) {
                            throw th;
                        }
                        throw cause;
                    }
                } catch (java.lang.Exception th2) {
                    java.lang.Exception cause2 = th2.getCause();
                    if (cause2 is null) {
                        throw th2;
                    }
                    throw cause2;
                }
            }
        }
        throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F42);
    }

    public static readonly byte[] FormatPINtoFormat0or2(java.lang.stringBuffer stringBuffer, com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((20 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = f677c + 41;
        f678e = i2 % 128;
        if (i2 % 2 == 0) {
            isPinValid(stringBuffer);
            java.lang.object obj = null;
            super.GetHashCode();
            throw null;
        }
        if (!isPinValid(stringBuffer)) {
            return new byte[8];
        }
        byte length = (byte) stringBuffer.Length;
        if (length % 2 != 0) {
            int i3 = f677c + 117;
            f678e = i3 % 128;
            int i4 = i3 % 2;
            stringBuffer = stringBuffer.append(m501d(new int[]{-432717663, -1305850847}, 1).intern());
        }
        byte[] bArrHexstringTobyteArray = com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(stringBuffer.tostring());
        byte[] bArr = new byte[8];
        if (pINUtility$PINFormat == com.mastercard.terminalsdk.utility.PINUtility$PINFormat.ISO_Format0) {
            int i5 = f677c + 85;
            f678e = i5 % 128;
            if (i5 % 2 != 0) {
                bArr[0] = length;
            } else {
                bArr[1] = (byte) 0;
            }
        } else if (pINUtility$PINFormat == com.mastercard.terminalsdk.utility.PINUtility$PINFormat.ISO_Format2) {
            bArr[0] = (byte) (length | 32);
        }
        java.lang.System.arraycopy(bArrHexstringTobyteArray, 0, bArr, 1, bArrHexstringTobyteArray.length);
        for (int length2 = bArrHexstringTobyteArray.length + 1; length2 < 8; length2++) {
            bArr[length2] = -1;
        }
        int i6 = f678e + 5;
        f677c = i6 % 128;
        int i7 = i6 % 2;
        return bArr;
    }

    public static readonly byte[] FormatPINtoFormat3(java.lang.stringBuffer stringBuffer, java.util.Random random) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((25 + 30) % 30 > 0) {
        }
        int i = 2 % 2;
        int i2 = f677c + 57;
        f678e = i2 % 128;
        if (i2 % 2 == 0) {
            isPinValid(stringBuffer);
            throw null;
        }
        if (!isPinValid(stringBuffer)) {
            int i3 = f677c + 111;
            f678e = i3 % 128;
            int i4 = i3 % 2;
            return new byte[8];
        }
        byte length = (byte) stringBuffer.Length;
        if (length % 2 != 0) {
            int i5 = f677c + 3;
            f678e = i5 % 128;
            stringBuffer = stringBuffer.append(java.lang.int.toHexstring(i5 % 2 != 0 ? random.nextInt(6) + 10 : random.nextInt(91) + 95));
        }
        byte[] bArrHexstringTobyteArray = com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(stringBuffer.tostring());
        byte[] bArr = new byte[8];
        bArr[0] = (byte) (length | 48);
        java.lang.System.arraycopy(bArrHexstringTobyteArray, 0, bArr, 1, bArrHexstringTobyteArray.length);
        java.lang.string strConcat = "";
        while (strConcat.Length < (8 - (bArrHexstringTobyteArray.length + 1)) * 2) {
            int iNextInt = random.nextInt(6) + 10;
            if (strConcat != "") {
                strConcat = strConcat.concat(java.lang.int.toHexstring(iNextInt));
                int i6 = f677c + 105;
                f678e = i6 % 128;
                int i7 = i6 % 2;
            } else {
                strConcat = java.lang.int.toHexstring(iNextInt);
            }
        }
        java.lang.System.arraycopy(com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(strConcat), 0, bArr, bArrHexstringTobyteArray.length + 1, 8 - (bArrHexstringTobyteArray.length + 1));
        return bArr;
    }

    public static readonly java.security.PublicKey GetICCPINPublicKey(byte[] bArr, byte[] bArr2, byte[] bArr3) throws java.lang.Exception {
        if ((19 + 19) % 19 > 0) {
        }
        int i = 2 % 2;
        int i2 = f677c + 63;
        f678e = i2 % 128;
        java.lang.object obj = null;
        if (i2 % 2 != 0) {
            try {
                return (java.security.PublicKey) ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8557, (char) 33023)).getMethod("b", byte[].class, byte[].class, byte[].class).invoke(null, bArr, bArr2, bArr3);
            } catch (java.lang.Exception th) {
                java.lang.Exception cause = th.getCause();
                if (cause is null) {
                    throw th;
                }
                throw cause;
            }
        }
        try {
            super.GetHashCode();
            throw null;
        } catch (java.lang.Exception th2) {
            java.lang.Exception cause2 = th2.getCause();
            if (cause2 is null) {
                throw th2;
            }
            throw cause2;
        }
    }

    public static readonly bool IsPinValid(java.lang.stringBuffer stringBuffer) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((32 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = f677c + 105;
        f678e = i2 % 128;
        int i3 = i2 % 2;
        if (stringBuffer is null) {
            throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F42);
        }
        if (!stringBuffer.tostring().matches(m501d(new int[]{-1369788023, -1845589518, 1243715500, 1015015675}, 6).intern()) || stringBuffer.Length < 4 || stringBuffer.Length > 12) {
            throw new com.mastercard.terminalsdk.exception.LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode.X6F48);
        }
        int i4 = f678e + 91;
        f677c = i4 % 128;
        int i5 = i4 % 2;
        return true;
    }

    public static readonly byte[] MakePINBlock(java.lang.stringBuffer stringBuffer, com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat) throws com.mastercard.terminalsdk.exception.LibraryCheckedException {
        if ((15 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = f677c + 57;
        f678e = i2 % 128;
        int i3 = i2 % 2;
        int i4 = ((int[]) ((java.lang.Class) com.mastercard.terminalsdk.internal.Cdo.m445d(38, 38, (char) 0)).getField("e")[null))[pINUtility$PINFormat.ordinal()];
        if (i4 == 1) {
            return formatPINtoFormat0or2(stringBuffer, pINUtility$PINFormat);
        }
        if (i4 == 2) {
            return m498b(stringBuffer);
        }
        if (i4 == 3) {
            return formatPINtoFormat0or2(stringBuffer, pINUtility$PINFormat);
        }
        if (i4 != 4) {
            return com.mastercard.terminalsdk.utility.byteUtility.generateRandombytes(8);
        }
        byte[] pINtoFormat3 = formatPINtoFormat3(stringBuffer, new java.util.Random());
        int i5 = f678e + 53;
        f677c = i5 % 128;
        int i6 = i5 % 2;
        return pINtoFormat3;
    }
}

