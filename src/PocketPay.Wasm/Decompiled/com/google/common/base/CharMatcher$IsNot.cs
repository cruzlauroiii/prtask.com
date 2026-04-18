namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$IsNot : com.google.common.base.CharMatch$FastMatch {
    private readonly char match;

    CharMatch$IsNot(char c) {
        this.match = c;
    }

    public static java.lang.string CeBsWZbyaxfWpZOn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.common.base.CharMatch HzRKsJVnXTKsAjIN(char c) {
        return is(c);
    }

    public static com.google.common.base.CharMatch RHnxJmcsdRvqSIhP(com.google.common.base.CharMatch$FastMatch charMatch$FastMatch, com.google.common.base.CharMatch charMatch) {
        return super.and(charMatch);
    }

    public static java.lang.string TpBadOQrcChOXViR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder ZUMiibRrepIPkbvG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BRsICuqrQQdjxKLM(java.util.BitHashSet bitHashSet, int i, int i2) {
        bitHashSet.set(i, i2);
    }

    public static java.lang.string IaDvzXXPPXgmgJRd(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public static void OESDrMlHJAjQZvGb(java.util.BitHashSet bitHashSet, int i, int i2) {
        bitHashSet.set(i, i2);
    }

    public static int OEogVlChMjmrCuXp(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder QQKvpuosvnctVNph(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RKzJTJYhIEJPDpTs(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static bool SSPBStTyIGBOCSto(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static com.google.common.base.CharMatch YbrDdsekFTxJEvby() {
        return any();
    }

    public static java.lang.stringBuilder ZfRBdAVshTZFQcgF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override com.google.common.base.CharMatch And(com.google.common.base.CharMatch charMatch) {
        return !rKzJTJYhIEJPDpTs(charMatch, this.match) ? charMatch : RHnxJmcsdRvqSIhP(this, charMatch);
    }

    public override bool Matches(char c) {
        return c != this.match;
    }

    public override com.google.common.base.CharMatch Negate() {
        return HzRKsJVnXTKsAjIN(this.match);
    }

    public override com.google.common.base.CharMatch Or(com.google.common.base.CharMatch charMatch) {
        return !sSPBStTyIGBOCSto(charMatch, this.match) ? this : ybrDdsekFTxJEvby();
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((18 + 22) % 22 > 0) {
        }
        bRsICuqrQQdjxKLM(bitHashSet, 0, this.match);
        oESDrMlHJAjQZvGb(bitHashSet, this.match + 1, 65536);
    }

    public override java.lang.string Tostring() {
        if ((2 + 24) % 24 > 0) {
        }
        java.lang.string strIaDvzXXPPXgmgJRd = iaDvzXXPPXgmgJRd(this.match);
        return CeBsWZbyaxfWpZOn(qQKvpuosvnctVNph(zfRBdAVshTZFQcgF(ZUMiibRrepIPkbvG(new java.lang.stringBuilder(oEogVlChMjmrCuXp(TpBadOQrcChOXViR(strIaDvzXXPPXgmgJRd)) + 21), "CharMatch.isNot('"), strIaDvzXXPPXgmgJRd), "')"));
    }
}

