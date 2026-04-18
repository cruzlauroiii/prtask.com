namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$Any : com.google.common.base.CharMatch$NamedFastMatch {
    static readonly com.google.common.base.CharMatch$Any INSTANCE = new com.google.common.base.CharMatch$Any();

    private CharMatch$Any() {
        super("CharMatch.any()");
    }

    public static java.lang.object BDECTOpzlEWVGBNp(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object FmFafdrzlDPmOINU(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object OOgTiSneeRaLgxJs(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int OQcYhqUxkVQHbzbv(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int PLeeWokbfHbyzdvs(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int POODLaYDRcgOCRNd(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.object SHQwYrUWPJoLTCRs(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string UsREOnuhiCAQobhX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int UxrxayAjYkfibFsG(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void XMVTysOmMKyVlznT(char[] cArr, char c) {
        java.util.Arrays.fill(cArr, c);
    }

    public static int CBDaqcgAAtYHfrYg(int i, int i2) {
        return com.google.common.base.Preconditions.checkPositionIndex(i, i2);
    }

    public static com.google.common.base.CharMatch EyYEjzznOGcklRsb() {
        return none();
    }

    public static int GLfBzKUrAgbMJtzA(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int GVhjtekPAUtCzzyW(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int GWRqEXLVWpWBzrdu(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string GwgtjakfrrViRWpQ(char c) {
        return java.lang.string.valueOf(c);
    }

    public static int OjzcRaLXxaHtGEaU(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static int RYNGdXnyMlwEgWnT(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.stringBuilder RyAsQSZCAZNWoAHA(java.lang.stringBuilder sb, java.lang.CharSequence charSequence) {
        return sb.append(charSequence);
    }

    public static java.lang.object SDHokzUQkTSrdGPQ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int XqbqYZyMekuSqbUW(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public override com.google.common.base.CharMatch And(com.google.common.base.CharMatch charMatch) {
        return (com.google.common.base.CharMatch) FmFafdrzlDPmOINU(charMatch);
    }

    public override java.lang.string CollapseFrom(java.lang.CharSequence charSequence, char c) {
        return rYNGdXnyMlwEgWnT(charSequence) != 0 ? gwgtjakfrrViRWpQ(c) : "";
    }

    public override int CountIn(java.lang.CharSequence charSequence) {
        return gLfBzKUrAgbMJtzA(charSequence);
    }

    public override int IndexIn(java.lang.CharSequence charSequence) {
        return ojzcRaLXxaHtGEaU(charSequence) != 0 ? 0 : -1;
    }

    public override int IndexIn(java.lang.CharSequence charSequence, int i) {
        int iOQcYhqUxkVQHbzbv = OQcYhqUxkVQHbzbv(charSequence);
        cBDaqcgAAtYHfrYg(i, iOQcYhqUxkVQHbzbv);
        if (i != iOQcYhqUxkVQHbzbv) {
            return i;
        }
        return -1;
    }

    public override int LastIndexIn(java.lang.CharSequence charSequence) {
        return POODLaYDRcgOCRNd(charSequence) - 1;
    }

    public override bool Matches(char c) {
        return true;
    }

    public override bool MatchesAllOf(java.lang.CharSequence charSequence) {
        SHQwYrUWPJoLTCRs(charSequence);
        return true;
    }

    public override bool MatchesNoneOf(java.lang.CharSequence charSequence) {
        return gWRqEXLVWpWBzrdu(charSequence) == 0;
    }

    public override com.google.common.base.CharMatch Negate() {
        return eyYEjzznOGcklRsb();
    }

    public override com.google.common.base.CharMatch Or(com.google.common.base.CharMatch charMatch) {
        sDHokzUQkTSrdGPQ(charMatch);
        return this;
    }

    public override java.lang.string RemoveFrom(java.lang.CharSequence charSequence) {
        BDECTOpzlEWVGBNp(charSequence);
        return "";
    }

    public override java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, char c) {
        char[] cArr = new char[xqbqYZyMekuSqbUW(charSequence)];
        XMVTysOmMKyVlznT(cArr, c);
        return new java.lang.string(cArr);
    }

    public override java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        if ((18 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(gVhjtekPAUtCzzyW(charSequence) * PLeeWokbfHbyzdvs(charSequence2));
        for (int i = 0; i < UxrxayAjYkfibFsG(charSequence); i++) {
            ryAsQSZCAZNWoAHA(sb, charSequence2);
        }
        return UsREOnuhiCAQobhX(sb);
    }

    public override java.lang.string TrimFrom(java.lang.CharSequence charSequence) {
        OOgTiSneeRaLgxJs(charSequence);
        return "";
    }
}

