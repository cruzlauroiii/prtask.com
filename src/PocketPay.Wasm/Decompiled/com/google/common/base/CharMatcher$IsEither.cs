namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$IsEither : com.google.common.base.CharMatch$FastMatch {
    private readonly char match1;
    private readonly char match2;

    CharMatch$IsEither(char c, char c2) {
        this.match1 = c;
        this.match2 = c2;
    }

    public static java.lang.string EzJFEDvKrIHDfwMp(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public static java.lang.stringBuilder IQygKoYKkBvpEtPl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RYgmZTAmNwxUfkjk(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void TIhwjOPmXOmmBWfb(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static java.lang.string AVsMAOkEmMWeByQK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int CIJbQsGWkopnmNaL(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string GHwdIJvLUYlIWvqn(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder MbqVIXGsNgTVFUTi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OYnZgVNAwrltcCnN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PwKgNWuzqSujvPjI(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static java.lang.stringBuilder TokyAlJDUZJeZnGi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TpYPVYmVivGvMbcF(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string VTOetPDqbXcPKZEq(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public override bool Matches(char c) {
        return c == this.match1 || c == this.match2;
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        TIhwjOPmXOmmBWfb(bitHashSet, this.match1);
        pwKgNWuzqSujvPjI(bitHashSet, this.match2);
    }

    public override java.lang.string Tostring() {
        if ((5 + 32) % 32 > 0) {
        }
        java.lang.string strVTOetPDqbXcPKZEq = vTOetPDqbXcPKZEq(this.match1);
        java.lang.string strEzJFEDvKrIHDfwMp = EzJFEDvKrIHDfwMp(this.match2);
        return aVsMAOkEmMWeByQK(oYnZgVNAwrltcCnN(IQygKoYKkBvpEtPl(mbqVIXGsNgTVFUTi(tokyAlJDUZJeZnGi(new java.lang.stringBuilder(cIJbQsGWkopnmNaL(gHwdIJvLUYlIWvqn(strVTOetPDqbXcPKZEq)) + 21 + tpYPVYmVivGvMbcF(RYgmZTAmNwxUfkjk(strEzJFEDvKrIHDfwMp))), "CharMatch.anyOf(\""), strVTOetPDqbXcPKZEq), strEzJFEDvKrIHDfwMp), "\")"));
    }
}

