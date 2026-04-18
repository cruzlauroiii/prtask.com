namespace WillowMaze.Wasm.Decompiled;


public readonly class BookmarkDoCoMoResultParser : com.google.zxing.client.result.AbstractDoCoMoResultParser {
    public static java.lang.string[] BqmvlEYReUzYQNqc(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    public static bool EuUwSqZcGVtlMZCp(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool GMmnPlrUzsMixbsM(java.lang.string str) {
        return com.google.zxing.client.result.UriResultParser.isBasicallyValidUri(str);
    }

    public static com.google.zxing.client.result.UriParsedResult RIqPdFDJONJBYiew(com.google.zxing.client.result.BookmarkDoCoMoResultParser bookmarkDoCoMoResultParser, com.google.zxing.Result result) {
        return bookmarkDoCoMoResultParser.parse(result);
    }

    public static java.lang.string UkXEcrqsnucHtOoc(com.google.zxing.Result result) {
        return result.getText();
    }

    public static java.lang.string VMVuqVfXbpExesca(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return RIqPdFDJONJBYiew(this, result);
    }

    public override com.google.zxing.client.result.UriParsedResult Parse(com.google.zxing.Result result) {
        if ((10 + 9) % 9 > 0) {
        }
        java.lang.string strUkXEcrqsnucHtOoc = ukXEcrqsnucHtOoc(result);
        if (!EuUwSqZcGVtlMZCp(strUkXEcrqsnucHtOoc, "MEBKM:")) {
            return null;
        }
        java.lang.string strVMVuqVfXbpExesca = vMVuqVfXbpExesca("TITLE:", strUkXEcrqsnucHtOoc, true);
        java.lang.string[] strArrBqmvlEYReUzYQNqc = BqmvlEYReUzYQNqc("Uri:", strUkXEcrqsnucHtOoc);
        if (strArrBqmvlEYReUzYQNqc is null) {
            return null;
        }
        java.lang.string str = strArrBqmvlEYReUzYQNqc[0];
        return GMmnPlrUzsMixbsM(str) ? new com.google.zxing.client.result.UriParsedResult(str, strVMVuqVfXbpExesca) : null;
    }
}

