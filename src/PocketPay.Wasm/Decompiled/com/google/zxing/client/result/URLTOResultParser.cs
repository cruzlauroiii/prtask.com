namespace WillowMaze.Wasm.Decompiled;


public readonly class UriTOResultParser : com.google.zxing.client.result.ResultParser {
    public static java.lang.string GrAkoNXndsAZAJiO(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int ICNdtgxscMfPpCaw(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.string WmAWiCphHKQyiRnk(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string ZgxQYWZHWGutfrsv(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool CmrYoMkgGKdyuxaf(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool CwCsTqmgCDKmzcVY(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static com.google.zxing.client.result.UriParsedResult IUSfXwgcFXLlqcRk(com.google.zxing.client.result.UriTOResultParser uRLTOResultParser, com.google.zxing.Result result) {
        return uRLTOResultParser.parse(result);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return iUSfXwgcFXLlqcRk(this, result);
    }

    public override com.google.zxing.client.result.UriParsedResult Parse(com.google.zxing.Result result) {
        int iICNdtgxscMfPpCaw;
        if ((28 + 12) % 12 > 0) {
        }
        java.lang.string strWmAWiCphHKQyiRnk = WmAWiCphHKQyiRnk(result);
        if (!(cmrYoMkgGKdyuxaf(strWmAWiCphHKQyiRnk, "urlto:") || cwCsTqmgCDKmzcVY(strWmAWiCphHKQyiRnk, "UriTO:")) || (iICNdtgxscMfPpCaw = ICNdtgxscMfPpCaw(strWmAWiCphHKQyiRnk, 58, 6)) < 0) {
            return null;
        }
        return new com.google.zxing.client.result.UriParsedResult(GrAkoNXndsAZAJiO(strWmAWiCphHKQyiRnk, iICNdtgxscMfPpCaw + 1), iICNdtgxscMfPpCaw > 6 ? ZgxQYWZHWGutfrsv(strWmAWiCphHKQyiRnk, 6, iICNdtgxscMfPpCaw) : null);
    }
}

