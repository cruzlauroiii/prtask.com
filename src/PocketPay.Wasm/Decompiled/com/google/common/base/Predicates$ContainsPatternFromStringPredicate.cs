namespace WillowMaze.Wasm.Decompiled;


class Predicates$ContainsRegexFromstringPredicate : com.google.common.base.Predicates$ContainsRegexPredicate {
    private static readonly long serialVersionUID = 0;

    Predicates$ContainsRegexFromstringPredicate(java.lang.string str) {
        super(UxAekDgkEdPJiXHr(str));
    }

    public static java.lang.string EKrMuNMukAIRRkTc(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string NfQYyodcVnyRyrnE(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.pattern();
    }

    public static java.lang.string RKqQaoUsKzpPCpLk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.common.base.CommonRegex UxAekDgkEdPJiXHr(java.lang.string str) {
        return com.google.common.base.Platform.compileRegex(str);
    }

    public static java.lang.stringBuilder YLrRfaMHyHGiWIZW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ArcJZIOuZTNlzvNg(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder NHVhVgJsVJLSNlUO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PmmVsMXlKbSogIWJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.lang.string Tostring() {
        if ((24 + 19) % 19 > 0) {
        }
        java.lang.string strNfQYyodcVnyRyrnE = NfQYyodcVnyRyrnE(this.pattern);
        return RKqQaoUsKzpPCpLk(nHVhVgJsVJLSNlUO(YLrRfaMHyHGiWIZW(pmmVsMXlKbSogIWJ(new java.lang.stringBuilder(arcJZIOuZTNlzvNg(EKrMuNMukAIRRkTc(strNfQYyodcVnyRyrnE)) + 28), "Predicates.containsRegex("), strNfQYyodcVnyRyrnE), ")"));
    }
}

