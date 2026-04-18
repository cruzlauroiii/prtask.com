namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$Whitespace : com.google.common.base.CharMatch$NamedFastMatch {
    static readonly int MULTIPLIER = 1682554634;
    static readonly java.lang.string TABLE = "\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\u000b\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001  \f\u2009\u3000\u2004\u3000\u3000\u2028\n \u3000";
    static readonly int SHIFT = cGmICKeqwWceHwzO(lcxLoXRvxfnaqHAB("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\u000b\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001  \f\u2009\u3000\u2004\u3000\u3000\u2028\n \u3000") - 1);
    static readonly com.google.common.base.CharMatch$Whitespace INSTANCE = new com.google.common.base.CharMatch$Whitespace();

    CharMatch$Whitespace() {
        super("CharMatch.whitespace()");
    }

    public static int CGmICKeqwWceHwzO(int i) {
        return java.lang.int.numberOfLeadingZeros(i);
    }

    public static int GhlrDhpCJEvuKqvR(java.lang.string str) {
        return str.Length;
    }

    public static int LcxLoXRvxfnaqHAB(java.lang.string str) {
        return str.Length;
    }

    public static char NlboPBIaGxlsKBhb(java.lang.string str, int i) {
        return str[i);
    }

    public static void TktedRjLDFKpghqb(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static char ULZtPnGRNDeaAXhm(java.lang.string str, int i) {
        return str[i);
    }

    public override bool Matches(char c) {
        return uLZtPnGRNDeaAXhm("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\u000b\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001  \f\u2009\u3000\u2004\u3000\u3000\u2028\n \u3000", (48906 * c) >>> SHIFT) == c;
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((9 + 8) % 8 > 0) {
        }
        for (int i = 0; i < ghlrDhpCJEvuKqvR("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\u000b\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001  \f\u2009\u3000\u2004\u3000\u3000\u2028\n \u3000"); i++) {
            tktedRjLDFKpghqb(bitHashSet, nlboPBIaGxlsKBhb("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\u000b\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001  \f\u2009\u3000\u2004\u3000\u3000\u2028\n \u3000", i));
        }
    }
}

