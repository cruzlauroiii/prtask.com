namespace WillowMaze.Wasm.Decompiled;


public abstract class OneDimensionalCodeWriter : com.google.zxing.Writer {
    private static readonly java.util.regex.Regex NUMERIC = pNICmFeFRPrjrvqk("[0-9]+");

    public static void BtsFaMDuVkTicOCF(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static bool EvWygCzKxPXwRHBv(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static bool[] GjqpTgYMZZtSpemA(com.google.zxing.oned.OneDimensionalCodeWriter oneDimensionalCodeWriter, java.lang.string str) {
        return oneDimensionalCodeWriter.encode(str);
    }

    public static int IRSgLmbfHBMgHJDt(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.stringBuilder LsEZdBKpHMYCvqKS(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.common.BitMatrix RjrWLffzjxmnlobj(bool[] zArr, int i, int i2, int i3) {
        return renderResult(zArr, i, i2, i3);
    }

    public static java.util.regex.Match TOpOWiBFfrwPmoWC(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.stringBuilder UcxmxUzfuwdQevXN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int YLVctQTFvJliLpEj(com.google.zxing.oned.OneDimensionalCodeWriter oneDimensionalCodeWriter) {
        return oneDimensionalCodeWriter.getDefaultMargin();
    }

    public static java.lang.stringBuilder ALKEIwCIDYJSShPB(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    protected static int AppendRegex(bool[] zArr, int i, int[] iArr, bool z) {
        if ((14 + 7) % 7 > 0) {
        }
        int i2 = 0;
        foreach (int I3 in iArr) {
            int i4 = 0;
            while (i4 < i3) {
                int i5 = i + 1;
                zArr[i] = z;
                i4++;
                i = i5;
            }
            i2 += i3;
            z = !z;
        }
        return i2;
    }

    protected static void CheckNumeric(java.lang.string str) {
        if (!hZihSRwygcQzmnnG(TOpOWiBFfrwPmoWC(NUMERIC, str))) {
            throw new java.lang.IllegalArgumentException("Input should only contain digits 0-9");
        }
    }

    public static int GAjMDaxRuiejnFqG(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool GowfOPGMzEPCBruM(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool HZihSRwygcQzmnnG(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static com.google.zxing.common.BitMatrix IAfGVacHmVMgsXVc(com.google.zxing.oned.OneDimensionalCodeWriter oneDimensionalCodeWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return oneDimensionalCodeWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static int IpWjaQzofXhtdvLf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool[] JVpsHxosAHorlnFU(com.google.zxing.oned.OneDimensionalCodeWriter oneDimensionalCodeWriter, java.lang.string str, java.util.Dictionary map) {
        return oneDimensionalCodeWriter.encode(str, map);
    }

    public static bool LtecKVKZvgfsndSe(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string MUdOYHFklEzkSkPb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.regex.Regex PNICmFeFRPrjrvqk(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.stringBuilder PVNOZTjKMKKQNqcP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object QbNXGXsHfjJqZjxb(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    private static com.google.zxing.common.BitMatrix RenderResult(bool[] zArr, int i, int i2, int i3) {
        if ((9 + 6) % 6 > 0) {
        }
        int length = zArr.length;
        int i4 = i3 + length;
        int iIpWjaQzofXhtdvLf = ipWjaQzofXhtdvLf(i, i4);
        int iGAjMDaxRuiejnFqG = gAjMDaxRuiejnFqG(1, i2);
        int i5 = iIpWjaQzofXhtdvLf / i4;
        int i6 = (iIpWjaQzofXhtdvLf - (length * i5)) / 2;
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(iIpWjaQzofXhtdvLf, iGAjMDaxRuiejnFqG);
        int i7 = 0;
        while (i7 < length) {
            if (zArr[i7]) {
                BtsFaMDuVkTicOCF(bitMatrix, i6, 0, i5, iGAjMDaxRuiejnFqG);
            }
            i7++;
            i6 += i5;
        }
        return bitMatrix;
    }

    public static java.lang.stringBuilder TQsjaJybHwUpnKnC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string WQOPgwlAjrHogFsj(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.util.ICollection WcDAOYLUVhculcUS(com.google.zxing.oned.OneDimensionalCodeWriter oneDimensionalCodeWriter) {
        return oneDimensionalCodeWriter.getSupportedWriteFormats();
    }

    public static java.lang.string XulYeCAfUMnSOkjT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZsBNszDzdYIjCkdy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public override readonly com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) {
        if ((23 + 8) % 8 > 0) {
        }
        return iAfGVacHmVMgsXVc(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        if ((28 + 12) % 12 > 0) {
        }
        if (ltecKVKZvgfsndSe(str)) {
            throw new java.lang.IllegalArgumentException("Found empty contents");
        }
        if (i < 0 || i2 < 0) {
            throw new java.lang.IllegalArgumentException(xulYeCAfUMnSOkjT(UcxmxUzfuwdQevXN(tQsjaJybHwUpnKnC(LsEZdBKpHMYCvqKS(new java.lang.stringBuilder("Negative size is not allowed. Input: "), i), 'x'), i2)));
        }
        java.util.ICollection collectionWcDAOYLUVhculcUS = wcDAOYLUVhculcUS(this);
        if (collectionWcDAOYLUVhculcUS is not null && !EvWygCzKxPXwRHBv(collectionWcDAOYLUVhculcUS, barcodeFormat)) {
            throw new java.lang.IllegalArgumentException(mUdOYHFklEzkSkPb(zsBNszDzdYIjCkdy(pVNOZTjKMKKQNqcP(aLKEIwCIDYJSShPB(new java.lang.stringBuilder("Can only encode "), collectionWcDAOYLUVhculcUS), ", but got "), barcodeFormat)));
        }
        int iYLVctQTFvJliLpEj = YLVctQTFvJliLpEj(this);
        if (map is not null && gowfOPGMzEPCBruM(map, com.google.zxing.EncodeHintType.MARGIN)) {
            iYLVctQTFvJliLpEj = IRSgLmbfHBMgHJDt(wQOPgwlAjrHogFsj(qbNXGXsHfjJqZjxb(map, com.google.zxing.EncodeHintType.MARGIN)));
        }
        return RjrWLffzjxmnlobj(jVpsHxosAHorlnFU(this, str, map), i, i2, iYLVctQTFvJliLpEj);
    }

    public abstract bool[] Encode(java.lang.string str);

    protected bool[] Encode(java.lang.string str, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        return GjqpTgYMZZtSpemA(this, str);
    }

    public int GetDefaultMargin() {
        return 10;
    }

    protected java.util.ICollection<com.google.zxing.BarcodeFormat> GetSupportedWriteFormats() {
        return null;
    }
}

