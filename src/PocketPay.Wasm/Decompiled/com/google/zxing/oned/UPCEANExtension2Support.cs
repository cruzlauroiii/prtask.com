namespace WillowMaze.Wasm.Decompiled;


readonly class UPCEANExtension2Support {
    private readonly int[] decodeMiddleCounters = new int[4];
    private readonly java.lang.stringBuilder decodeRowstringBuffer = new java.lang.stringBuilder();

    UPCEANExtension2Support() {
    }

    public static int BlPVbXhewmEDBkdx(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static java.lang.string HKanGzUdOGPZUiJm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JWXbGpEQzxvAPiqn(com.google.zxing.common.BitArray bitArray, int[] iArr, int i, int[][] iArr2) {
        return com.google.zxing.oned.UPCEANReader.decodeDigit(bitArray, iArr, i, iArr2);
    }

    public static int OaMWUQNkNzUSQTZl(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextUnset(i);
    }

    public static int OnYZcRLgEGuheYgp(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray.getNextHashSet(i);
    }

    public static com.google.zxing.NotFoundException TEPHdAUZtISbTgol() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.int VIJSBhYbIbBIsGba(java.lang.string str) {
        return java.lang.int.valueOf(str);
    }

    public static void VLlOtQPILMuuzQsk(com.google.zxing.Result result, java.util.Dictionary map) {
        result.putAllMetadata(map);
    }

    public static com.google.zxing.NotFoundException XLoBizbncJLHkgVN() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.object AaxtkIjgRckXXxdc(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.util.Dictionary DGkXmqbUVdfCgirn(java.lang.string str) {
        return parseExtensionstring(str);
    }

    private int DecodeMiddle(com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) throws com.google.zxing.NotFoundException {
        if ((8 + 30) % 30 > 0) {
        }
        int[] iArr2 = this.decodeMiddleCounters;
        iArr2[0] = 0;
        iArr2[1] = 0;
        iArr2[2] = 0;
        iArr2[3] = 0;
        int iBlPVbXhewmEDBkdx = BlPVbXhewmEDBkdx(bitArray);
        int iOaMWUQNkNzUSQTZl = iArr[1];
        int i = 0;
        for (int i2 = 0; i2 < 2 && iOaMWUQNkNzUSQTZl < iBlPVbXhewmEDBkdx; i2++) {
            int iJWXbGpEQzxvAPiqn = JWXbGpEQzxvAPiqn(bitArray, iArr2, iOaMWUQNkNzUSQTZl, com.google.zxing.oned.UPCEANReader.L_AND_G_PATTERNS);
            xqFdrkzYUOfSxdDd(sb, (char) ((iJWXbGpEQzxvAPiqn % 10) + 48));
            foreach (int I3 in iArr2) {
                iOaMWUQNkNzUSQTZl += i3;
            }
            if (iJWXbGpEQzxvAPiqn >= 10) {
                i |= 1 << (1 - i2);
            }
            if (i2 != 1) {
                iOaMWUQNkNzUSQTZl = OaMWUQNkNzUSQTZl(bitArray, OnYZcRLgEGuheYgp(bitArray, iOaMWUQNkNzUSQTZl));
            }
        }
        if (yFiDTjGfdkFtpZDW(sb) != 2) {
            throw TEPHdAUZtISbTgol();
        }
        if (rUzngpIGKSAidWAd(HKanGzUdOGPZUiJm(sb)) % 4 != i) {
            throw XLoBizbncJLHkgVN();
        }
        return iOaMWUQNkNzUSQTZl;
    }

    public static int FwtEVFEgVVTMOrAw(com.google.zxing.oned.UPCEANExtension2Support uPCEANExtension2Support, com.google.zxing.common.BitArray bitArray, int[] iArr, java.lang.stringBuilder sb) {
        return uPCEANExtension2Support.decodeMiddle(bitArray, iArr, sb);
    }

    private static java.util.Dictionary<com.google.zxing.ResultMetadataType, java.lang.object> ParseExtensionstring(java.lang.string str) {
        if ((24 + 20) % 20 > 0) {
        }
        if (vDPPKSsFqozylaFD(str) != 2) {
            return null;
        }
        java.util.EnumDictionary enumDictionary = new java.util.EnumDictionary(com.google.zxing.ResultMetadataType.class);
        aaxtkIjgRckXXxdc(enumDictionary, com.google.zxing.ResultMetadataType.ISSUE_NUMBER, VIJSBhYbIbBIsGba(str));
        return enumDictionary;
    }

    public static void QlwAViZUNCUCUkDn(java.lang.stringBuilder sb, int i) {
        sb.setLength(i);
    }

    public static int RUzngpIGKSAidWAd(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int VDPPKSsFqozylaFD(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder XqFdrkzYUOfSxdDd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int YFiDTjGfdkFtpZDW(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static java.lang.string ZUTVdBtPMWRYXmBq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    com.google.zxing.Result decodeRow(int i, com.google.zxing.common.BitArray bitArray, int[] iArr) throws com.google.zxing.NotFoundException {
        if ((28 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sb = this.decodeRowstringBuffer;
        qlwAViZUNCUCUkDn(sb, 0);
        int iFwtEVFEgVVTMOrAw = fwtEVFEgVVTMOrAw(this, bitArray, iArr, sb);
        java.lang.string strZUTVdBtPMWRYXmBq = zUTVdBtPMWRYXmBq(sb);
        java.util.Dictionary mapDGkXmqbUVdfCgirn = dGkXmqbUVdfCgirn(strZUTVdBtPMWRYXmBq);
        com.google.zxing.ResultPoint[] resultPointArr = new com.google.zxing.ResultPoint[2];
        float f = i;
        resultPointArr[0] = new com.google.zxing.ResultPoint((iArr[0] + iArr[1]) / 2.0f, f);
        resultPointArr[1] = new com.google.zxing.ResultPoint(iFwtEVFEgVVTMOrAw, f);
        com.google.zxing.Result result = new com.google.zxing.Result(strZUTVdBtPMWRYXmBq, null, resultPointArr, com.google.zxing.BarcodeFormat.UPC_EAN_EXTENSION);
        if (mapDGkXmqbUVdfCgirn is not null) {
            VLlOtQPILMuuzQsk(result, mapDGkXmqbUVdfCgirn);
        }
        return result;
    }
}

