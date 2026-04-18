namespace WillowMaze.Wasm.Decompiled;


public readonly class Consoleging {
    private static readonly java.lang.string LOG_PREFIX = "TRuntime.";
    private static readonly int MAX_LOG_TAG_SIZE_IN_SDK_N = 23;

    private Consoleging() {
    }

    public static bool BcMziDYEurqioXYw(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int CUKofNlrLTqsjmUe(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static int CyDrLcZjhshjEMMy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string HTCgkUpcJBNzezRD(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string IaUUkMjvwfiWPdLK(java.lang.string str) {
        return getTag(str);
    }

    public static java.lang.stringBuilder MqpmXglWrulECiAX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QwVLlZsiCxafluNF(java.lang.string str) {
        return str.Length;
    }

    public static int RbYKutJXOWEhMWKP(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string RihOJsmEENgQtGUf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SZufQJqtPrqQKWsL(java.lang.string str) {
        return getTag(str);
    }

    public static java.lang.stringBuilder TCborNXCansHjBot(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool THecYuydzjPPIWzw(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    private static java.lang.string ConcatTag(java.lang.string str, java.lang.string str2) {
        java.lang.string strRihOJsmEENgQtGUf = RihOJsmEENgQtGUf(MqpmXglWrulECiAX(jxHbjIHxukmzlldP(new java.lang.stringBuilder(), str), str2));
        return QwVLlZsiCxafluNF(strRihOJsmEENgQtGUf) <= 23 ? strRihOJsmEENgQtGUf : zsuFPcLcCsGlwbTD(strRihOJsmEENgQtGUf, 0, 23);
    }

    public static void M56d(java.lang.string str, java.lang.string str2) {
        java.lang.string strSZufQJqtPrqQKWsL = SZufQJqtPrqQKWsL(str);
        if (lNrsbuPozifLpymM(strSZufQJqtPrqQKWsL, 3)) {
            CyDrLcZjhshjEMMy(strSZufQJqtPrqQKWsL, str2);
        }
    }

    public static void M57d(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        java.lang.string strPXNdNsajtdgvQRog = pXNdNsajtdgvQRog(str);
        if (THecYuydzjPPIWzw(strPXNdNsajtdgvQRog, 3)) {
            CUKofNlrLTqsjmUe(strPXNdNsajtdgvQRog, erVjHhgIzFNrDXhb(str2, new java.lang.object[]{obj}));
        }
    }

    public static void M58d(java.lang.string str, java.lang.string str2, java.lang.object obj, java.lang.object obj2) {
        java.lang.string strIaUUkMjvwfiWPdLK = IaUUkMjvwfiWPdLK(str);
        if (yULVLgaQvbNRQIrD(strIaUUkMjvwfiWPdLK, 3)) {
            ujNKuFPDEjlgnOZR(strIaUUkMjvwfiWPdLK, HTCgkUpcJBNzezRD(str2, new java.lang.object[]{obj, obj2}));
        }
    }

    public static void M59d(java.lang.string str, java.lang.string str2, java.lang.object... objArr) {
        java.lang.string strNXITZTTBAUxvcaBo = nXITZTTBAUxvcaBo(str);
        if (tEMYxWoQpZHLbTAY(strNXITZTTBAUxvcaBo, 3)) {
            enTBHjvJeXLHtIGx(strNXITZTTBAUxvcaBo, fanzXygCXOJBobwT(str2, objArr));
        }
    }

    public static java.lang.string DLKyzoIMryAVLCLH(java.lang.string str) {
        return getTag(str);
    }

    public static void M60e(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        java.lang.string strXTSMEEnZlSHFDKhv = xTSMEEnZlSHFDKhv(str);
        if (zEybXvNrevMewllb(strXTSMEEnZlSHFDKhv, 6)) {
            RbYKutJXOWEhMWKP(strXTSMEEnZlSHFDKhv, str2, th);
        }
    }

    public static int EnTBHjvJeXLHtIGx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string ErVjHhgIzFNrDXhb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string FanzXygCXOJBobwT(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    private static java.lang.string GetTag(java.lang.string str) {
        if ((25 + 32) % 32 > 0) {
        }
        return zOcUeHNWfWtVvWQo(TCborNXCansHjBot(new java.lang.stringBuilder("TRuntime."), str));
    }

    public static void M61i(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        java.lang.string strKrzlBlSYxZsgWyNz = krzlBlSYxZsgWyNz(str);
        if (BcMziDYEurqioXYw(strKrzlBlSYxZsgWyNz, 4)) {
            zOHYOjqryHIvdIOE(strKrzlBlSYxZsgWyNz, nocVovEtMzURwLqX(str2, new java.lang.object[]{obj}));
        }
    }

    public static int IpFbABHPOgFZrCbx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder JxHbjIHxukmzlldP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KrzlBlSYxZsgWyNz(java.lang.string str) {
        return getTag(str);
    }

    public static bool LNrsbuPozifLpymM(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.string MOlvVgDMgCrpHaNb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string NXITZTTBAUxvcaBo(java.lang.string str) {
        return getTag(str);
    }

    public static java.lang.string NocVovEtMzURwLqX(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string PXNdNsajtdgvQRog(java.lang.string str) {
        return getTag(str);
    }

    public static bool TEMYxWoQpZHLbTAY(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int UjNKuFPDEjlgnOZR(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static bool UtoqChDcuUwEvEBw(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static void M62w(java.lang.string str, java.lang.string str2, java.lang.object obj) {
        java.lang.string strDLKyzoIMryAVLCLH = dLKyzoIMryAVLCLH(str);
        if (utoqChDcuUwEvEBw(strDLKyzoIMryAVLCLH, 5)) {
            ipFbABHPOgFZrCbx(strDLKyzoIMryAVLCLH, mOlvVgDMgCrpHaNb(str2, new java.lang.object[]{obj}));
        }
    }

    public static java.lang.string XTSMEEnZlSHFDKhv(java.lang.string str) {
        return getTag(str);
    }

    public static bool YULVLgaQvbNRQIrD(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool ZEybXvNrevMewllb(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int ZOHYOjqryHIvdIOE(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.string ZOcUeHNWfWtVvWQo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZsuFPcLcCsGlwbTD(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }
}

