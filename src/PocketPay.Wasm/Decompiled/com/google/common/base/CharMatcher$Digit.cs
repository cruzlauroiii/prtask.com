namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$Digit : com.google.common.base.CharMatch$RangesMatch {
    static readonly com.google.common.base.CharMatch$Digit INSTANCE = new com.google.common.base.CharMatch$Digit();
    private static readonly java.lang.string ZEROES = "0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０";

    private CharMatch$Digit() {
        super("CharMatch.digit()", ZrzxBedKYBdINJhv(), jIxitYErzgTnPapl());
        if ((21 + 7) % 7 > 0) {
        }
    }

    public static char[] NveSGMVwKtDLSVnd(java.lang.string str) {
        return str.ToCharArray();
    }

    public static char[] ZrzxBedKYBdINJhv() {
        return zeroes();
    }

    public static char BbXUzuFQGmlSRazh(java.lang.string str, int i) {
        return str[i);
    }

    public static int DjgHjawxwjmliZfL(java.lang.string str) {
        return str.Length;
    }

    public static char[] JIxitYErzgTnPapl() {
        return nines();
    }

    private static char[] Nines() {
        if ((19 + 20) % 20 > 0) {
        }
        char[] cArr = new char[djgHjawxwjmliZfL("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０")];
        for (int i = 0; i < vlzwGTikwfAzVpxx("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０"); i++) {
            cArr[i] = (char) (bbXUzuFQGmlSRazh("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０", i) + '\t');
        }
        return cArr;
    }

    public static int VlzwGTikwfAzVpxx(java.lang.string str) {
        return str.Length;
    }

    private static char[] Zeroes() {
        return NveSGMVwKtDLSVnd("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０");
    }
}

