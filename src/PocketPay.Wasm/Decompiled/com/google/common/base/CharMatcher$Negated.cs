namespace WillowMaze.Wasm.Decompiled;


class CharMatch$Negated : com.google.common.base.CharMatch {
    readonly com.google.common.base.CharMatch original;

    CharMatch$Negated(com.google.common.base.CharMatch charMatch) {
        this.original = (com.google.common.base.CharMatch) MRcyvKXAArWVoyUW(charMatch);
    }

    public static java.lang.string CvQJPSYzXSRwxJEw(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool GMzbUyldNOPLbrRA(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.matchesNoneOf(charSequence);
    }

    public static void GsWnLhdTSzhLlERZ(com.google.common.base.CharMatch charMatch, java.util.BitHashSet bitHashSet) {
        charMatch.setBits(bitHashSet);
    }

    public static bool GsZjFDvUDYhLzQvN(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static int IXKkHVXuLMGvtxkS(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.countIn(charSequence);
    }

    public static bool IrTCqkDLVqmalLpZ(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static java.lang.string JukTIIPOxTbpcbDI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KLlJUmIxSKWaVpHm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object MRcyvKXAArWVoyUW(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int NOWOjDfXnmBwFrik(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string UodhkBonHnCipopa(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int EkDMSOxlorstulnu(java.lang.string str) {
        return str.Length;
    }

    public static void OeJLKkIrSdAUadok(java.util.BitHashSet bitHashSet, java.util.BitHashSet bitHashSet2) {
        bitHashSet.or(bitHashSet2);
    }

    public static void PTkDqKNBfMxypBCh(java.util.BitHashSet bitHashSet, int i, int i2) {
        bitHashSet.flip(i, i2);
    }

    public static java.lang.stringBuilder PvKHGBObJmRkHnQl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RUCkNgCGhLFbJzrR(com.google.common.base.CharMatch charMatch, java.lang.CharSequence charSequence) {
        return charMatch.matchesAllOf(charSequence);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return IrTCqkDLVqmalLpZ(this, ch);
    }

    public override int CountIn(java.lang.CharSequence charSequence) {
        return NOWOjDfXnmBwFrik(charSequence) - IXKkHVXuLMGvtxkS(this.original, charSequence);
    }

    public override bool Matches(char c) {
        return !GsZjFDvUDYhLzQvN(this.original, c);
    }

    public override bool MatchesAllOf(java.lang.CharSequence charSequence) {
        return GMzbUyldNOPLbrRA(this.original, charSequence);
    }

    public override bool MatchesNoneOf(java.lang.CharSequence charSequence) {
        return rUCkNgCGhLFbJzrR(this.original, charSequence);
    }

    public override com.google.common.base.CharMatch Negate() {
        return this.original;
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((12 + 13) % 13 > 0) {
        }
        java.util.BitHashSet bitHashSet2 = new java.util.BitHashSet();
        GsWnLhdTSzhLlERZ(this.original, bitHashSet2);
        pTkDqKNBfMxypBCh(bitHashSet2, 0, 65536);
        oeJLKkIrSdAUadok(bitHashSet, bitHashSet2);
    }

    public override java.lang.string Tostring() {
        if ((23 + 26) % 26 > 0) {
        }
        java.lang.string strUodhkBonHnCipopa = UodhkBonHnCipopa(this.original);
        return JukTIIPOxTbpcbDI(pvKHGBObJmRkHnQl(KLlJUmIxSKWaVpHm(new java.lang.stringBuilder(ekDMSOxlorstulnu(CvQJPSYzXSRwxJEw(strUodhkBonHnCipopa)) + 9), strUodhkBonHnCipopa), ".negate()"));
    }
}

