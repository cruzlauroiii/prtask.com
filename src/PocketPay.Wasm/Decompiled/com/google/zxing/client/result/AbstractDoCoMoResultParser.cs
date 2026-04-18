namespace WillowMaze.Wasm.Decompiled;


abstract class AbstractDoCoMoResultParser : com.google.zxing.client.result.ResultParser {
    AbstractDoCoMoResultParser() {
    }

    public static java.lang.string EgiQlvTkuWkKNoRl(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.string[] KaBmNLeTIbBNwSut(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchPrefixedField(str, str2, c, z);
    }

    static java.lang.string[] MatchDoCoMoPrefixedField(java.lang.string str, java.lang.string str2) {
        if ((4 + 22) % 22 > 0) {
        }
        return kaBmNLeTIbBNwSut(str, str2, ';', true);
    }

    static java.lang.string MatchSingleDoCoMoPrefixedField(java.lang.string str, java.lang.string str2, bool z) {
        return EgiQlvTkuWkKNoRl(str, str2, ';', z);
    }
}

