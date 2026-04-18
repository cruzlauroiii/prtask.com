namespace WillowMaze.Wasm.Decompiled;


public readonly class ProductResultParser : com.google.zxing.client.result.ResultParser {
    public static int IfaBYmNSdhwnpFLe(java.lang.string str) {
        return str.Length;
    }

    public static com.google.zxing.client.result.ProductParsedResult UrjCaVlhnnGZaajf(com.google.zxing.client.result.ProductResultParser productResultParser, com.google.zxing.Result result) {
        return productResultParser.parse(result);
    }

    public static com.google.zxing.BarcodeFormat VaNoEDzMevdsMTLs(com.google.zxing.Result result) {
        return result.getBarcodeFormat();
    }

    public static bool LcDFVTgNPkoefCGr(java.lang.CharSequence charSequence, int i) {
        return isstringOfDigits(charSequence, i);
    }

    public static int VHtQCWKwdbrjcTmV(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string WlRjjvoJZWdTRPBh(java.lang.string str) {
        return com.google.zxing.oned.UPCEReader.convertUPCEtoUPCA(str);
    }

    public static java.lang.string WyYetNjgUcyGumRZ(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return UrjCaVlhnnGZaajf(this, result);
    }

    public override com.google.zxing.client.result.ProductParsedResult Parse(com.google.zxing.Result result) {
        if ((15 + 7) % 7 > 0) {
        }
        com.google.zxing.BarcodeFormat barcodeFormatVaNoEDzMevdsMTLs = VaNoEDzMevdsMTLs(result);
        if (barcodeFormatVaNoEDzMevdsMTLs != com.google.zxing.BarcodeFormat.UPC_A && barcodeFormatVaNoEDzMevdsMTLs != com.google.zxing.BarcodeFormat.UPC_E && barcodeFormatVaNoEDzMevdsMTLs != com.google.zxing.BarcodeFormat.EAN_8 && barcodeFormatVaNoEDzMevdsMTLs != com.google.zxing.BarcodeFormat.EAN_13) {
            return null;
        }
        java.lang.string strWyYetNjgUcyGumRZ = wyYetNjgUcyGumRZ(result);
        if (lcDFVTgNPkoefCGr(strWyYetNjgUcyGumRZ, vHtQCWKwdbrjcTmV(strWyYetNjgUcyGumRZ))) {
            return new com.google.zxing.client.result.ProductParsedResult(strWyYetNjgUcyGumRZ, (barcodeFormatVaNoEDzMevdsMTLs == com.google.zxing.BarcodeFormat.UPC_E && IfaBYmNSdhwnpFLe(strWyYetNjgUcyGumRZ) == 8) ? wlRjjvoJZWdTRPBh(strWyYetNjgUcyGumRZ) : strWyYetNjgUcyGumRZ);
        }
        return null;
    }
}

