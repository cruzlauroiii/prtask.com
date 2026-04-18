namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$AnyOf : com.google.common.base.CharMatch {
    private readonly char[] chars;

    public CharMatch$AnyOf(java.lang.CharSequence charSequence) {
        char[] cArrHREESyTAXypIXbEy = hREESyTAXypIXbEy(dmYTwSNaelLncjlG(charSequence));
        this.chars = cArrHREESyTAXypIXbEy;
        zyOCaXWnOUQUCRvX(cArrHREESyTAXypIXbEy);
    }

    public static java.lang.stringBuilder JJuoKEUPGhxbXNMT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PAZaexREFlepvnfC(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public static java.lang.stringBuilder WdYbIfTbblRudkiG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DmYTwSNaelLncjlG(java.lang.object obj) {
        return obj.tostring();
    }

    public static char[] HREESyTAXypIXbEy(java.lang.string str) {
        return str.ToCharArray();
    }

    public static void QozRudSHMTCRtpxv(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static java.lang.string SUWAwtWXBemJGGov(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool TLvGXdpxomRFzwju(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static int VEGESAXxaAHaDDHS(char[] cArr, char c) {
        return java.util.Arrays.binarySearch(cArr, c);
    }

    public static void ZyOCaXWnOUQUCRvX(char[] cArr) {
        java.util.Arrays.sort(cArr);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return tLvGXdpxomRFzwju(this, ch);
    }

    public override bool Matches(char c) {
        return vEGESAXxaAHaDDHS(this.chars, c) >= 0;
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((3 + 32) % 32 > 0) {
        }
        foreach (char C in this.chars) {
            qozRudSHMTCRtpxv(bitHashSet, c);
        }
    }

    public override java.lang.string Tostring() {
        if ((31 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("CharMatch.anyOf(\"");
        foreach (char C in this.chars) {
            WdYbIfTbblRudkiG(sb, PAZaexREFlepvnfC(c));
        }
        JJuoKEUPGhxbXNMT(sb, "\")");
        return sUWAwtWXBemJGGov(sb);
    }
}

