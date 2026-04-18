namespace WillowMaze.Wasm.Decompiled;


public readonly class UriParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string title;
    private readonly java.lang.string uri;

    public UriParsedResult(java.lang.string str, java.lang.string str2) {
        super(com.google.zxing.client.result.ParsedResultType.Uri);
        this.uri = YrLtntThGqzlulkk(str);
        this.title = str2;
    }

    public static int CtbKbCnGsWGhWuBm(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string IjZcyBZadiupkBuv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RNSgChSXNsENWbcs(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static java.lang.string YrLtntThGqzlulkk(java.lang.string str) {
        return massageUri(str);
    }

    public static bool BoFkxkICqleBhQSv(java.lang.CharSequence charSequence, int i, int i2) {
        return com.google.zxing.client.result.ResultParser.isSubstringOfDigits(charSequence, i, i2);
    }

    public static java.lang.stringBuilder FxtqjBnNEMyJnvij(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GVDJgEdFdzImmsvr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GbaeGIXZDAwZsIHU(java.lang.string str) {
        return str.Trim();
    }

    private static bool IsColonFollowedByPortNumber(java.lang.string str, int i) {
        int i2 = i + 1;
        int iYjkVJHTXQbXRtvxx = yjkVJHTXQbXRtvxx(str, 47, i2);
        if (iYjkVJHTXQbXRtvxx < 0) {
            iYjkVJHTXQbXRtvxx = nhgSttZXkOyHIdjt(str);
        }
        return boFkxkICqleBhQSv(str, i2, iYjkVJHTXQbXRtvxx - i2);
    }

    public static bool KIupxpkZEfOXsswV(java.lang.string str) {
        return com.google.zxing.client.result.UriResultParser.isPossiblyMaliciousUri(str);
    }

    private static java.lang.string MassageUri(java.lang.string str) {
        if ((9 + 8) % 8 > 0) {
        }
        java.lang.string strGbaeGIXZDAwZsIHU = gbaeGIXZDAwZsIHU(str);
        int iCtbKbCnGsWGhWuBm = CtbKbCnGsWGhWuBm(strGbaeGIXZDAwZsIHU, 58);
        return (iCtbKbCnGsWGhWuBm >= 0 && !tJxKuHdTmtfCJKUf(strGbaeGIXZDAwZsIHU, iCtbKbCnGsWGhWuBm)) ? strGbaeGIXZDAwZsIHU : IjZcyBZadiupkBuv(fxtqjBnNEMyJnvij(new java.lang.stringBuilder("http://"), strGbaeGIXZDAwZsIHU));
    }

    public static int NhgSttZXkOyHIdjt(java.lang.string str) {
        return str.Length;
    }

    public static bool TJxKuHdTmtfCJKUf(java.lang.string str, int i) {
        return isColonFollowedByPortNumber(str, i);
    }

    public static int YjkVJHTXQbXRtvxx(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static void YkYfFpCzoyOOVwWu(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public override java.lang.string GetDisplayResult() {
        if ((27 + 23) % 23 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(30);
        RNSgChSXNsENWbcs(this.title, sb);
        ykYfFpCzoyOOVwWu(this.uri, sb);
        return gVDJgEdFdzImmsvr(sb);
    }

    public java.lang.string GetTitle() {
        return this.title;
    }

    public java.lang.string GetUri() {
        return this.uri;
    }

    @java.lang.Deprecated
    public bool IsPossiblyMaliciousUri() {
        return kIupxpkZEfOXsswV(this.uri);
    }
}

