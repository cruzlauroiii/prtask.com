namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$InRange : com.google.common.base.CharMatch$FastMatch {
    private readonly char endInclusive;
    private readonly char startInclusive;

    CharMatch$InRange(char c, char c2) {
        OprEHRiXllYtylMl(c2 >= c);
        this.startInclusive = c;
        this.endInclusive = c2;
    }

    public static int IBuVnzbLyaYuzPXZ(java.lang.string str) {
        return str.Length;
    }

    public static void OprEHRiXllYtylMl(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    public static java.lang.stringBuilder RygqIaoxHojNLYjt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SfRgABspKfvRXvZl(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public static java.lang.string SzVKYQAVpELrgGbM(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public static java.lang.stringBuilder DOYyuHWaAVwKiTRU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FhdBqpubwuqWpEQy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FqGwaXcQcymlkPAR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HaSsNyAzTBKEtRzO(java.lang.string str) {
        return str.Length;
    }

    public static void IZGYMHWLOvAoYZJC(java.util.BitHashSet bitHashSet, int i, int i2) {
        bitHashSet.set(i, i2);
    }

    public static java.lang.string IjhRhXmpGXRKJpLp(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder JelYmxpYRJFEdtyG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JmBAOQHsxZyGUUPN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WYlufbFxaMdZxDDt(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public override bool Matches(char c) {
        return this.startInclusive <= c && c <= this.endInclusive;
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        iZGYMHWLOvAoYZJC(bitHashSet, this.startInclusive, this.endInclusive + 1);
    }

    public override java.lang.string Tostring() {
        if ((32 + 8) % 8 > 0) {
        }
        java.lang.string strSzVKYQAVpELrgGbM = SzVKYQAVpELrgGbM(this.startInclusive);
        java.lang.string strSfRgABspKfvRXvZl = SfRgABspKfvRXvZl(this.endInclusive);
        return fqGwaXcQcymlkPAR(RygqIaoxHojNLYjt(jmBAOQHsxZyGUUPN(fhdBqpubwuqWpEQy(jelYmxpYRJFEdtyG(dOYyuHWaAVwKiTRU(new java.lang.stringBuilder(IBuVnzbLyaYuzPXZ(wYlufbFxaMdZxDDt(strSzVKYQAVpELrgGbM)) + 27 + haSsNyAzTBKEtRzO(ijhRhXmpGXRKJpLp(strSfRgABspKfvRXvZl))), "CharMatch.inRange('"), strSzVKYQAVpELrgGbM), "', '"), strSfRgABspKfvRXvZl), "')"));
    }
}

