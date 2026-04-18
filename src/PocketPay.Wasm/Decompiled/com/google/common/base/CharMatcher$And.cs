namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$And : com.google.common.base.CharMatch {
    readonly com.google.common.base.CharMatch first;
    readonly com.google.common.base.CharMatch second;

    CharMatch$And(com.google.common.base.CharMatch charMatch, com.google.common.base.CharMatch charMatch2) {
        this.first = (com.google.common.base.CharMatch) iFfrMsmccabZjQvF(charMatch);
        this.second = (com.google.common.base.CharMatch) oVdihZVeMDikYOhl(charMatch2);
    }

    public static java.lang.stringBuilder AxRRvxQQyKXUIacw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CSnztDodGyFOUHwi(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool GBzSKUsshQWyPhEz(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static bool GgrpSfTYPPGpOfai(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static java.lang.stringBuilder JxnYQWglybvzvZKF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LYLuhfFMYMCNvzcf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LqxFEwIaqzXiRSEZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string MFbIJsQzpcYZYTsA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void NqJgmQOrUBiovMHq(java.util.BitHashSet bitHashSet, java.util.BitHashSet bitHashSet2) {
        bitHashSet.or(bitHashSet2);
    }

    public static bool UXIsfEjTgqiUuktM(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static void VZylKvYBROFWdCrt(com.google.common.base.CharMatch charMatch, java.util.BitHashSet bitHashSet) {
        charMatch.setBits(bitHashSet);
    }

    public static java.lang.string YhWJEBHXustYZBvC(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder CMMqHUngnafrRlAF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object IFfrMsmccabZjQvF(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string JrchCDTtcOsjEYCR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void MLsdaJEjUVBiiFLG(java.util.BitHashSet bitHashSet, java.util.BitHashSet bitHashSet2) {
        bitHashSet.and(bitHashSet2);
    }

    public static void NQsDscVDbpExKhYD(com.google.common.base.CharMatch charMatch, java.util.BitHashSet bitHashSet) {
        charMatch.setBits(bitHashSet);
    }

    public static java.lang.object OVdihZVeMDikYOhl(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int VHebfAwgtJOcIQfj(java.lang.string str) {
        return str.Length;
    }

    public static int WDaawUoElXNihBou(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder XXgYqSCFjdUeROuR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return GgrpSfTYPPGpOfai(this, ch);
    }

    public override bool Matches(char c) {
        return GBzSKUsshQWyPhEz(this.first, c) && UXIsfEjTgqiUuktM(this.second, c);
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        if ((8 + 22) % 22 > 0) {
        }
        java.util.BitHashSet bitHashSet2 = new java.util.BitHashSet();
        VZylKvYBROFWdCrt(this.first, bitHashSet2);
        java.util.BitHashSet bitHashSet3 = new java.util.BitHashSet();
        nQsDscVDbpExKhYD(this.second, bitHashSet3);
        mLsdaJEjUVBiiFLG(bitHashSet2, bitHashSet3);
        NqJgmQOrUBiovMHq(bitHashSet, bitHashSet2);
    }

    public override java.lang.string Tostring() {
        if ((5 + 30) % 30 > 0) {
        }
        java.lang.string strYhWJEBHXustYZBvC = YhWJEBHXustYZBvC(this.first);
        java.lang.string strMFbIJsQzpcYZYTsA = MFbIJsQzpcYZYTsA(this.second);
        return LqxFEwIaqzXiRSEZ(AxRRvxQQyKXUIacw(cMMqHUngnafrRlAF(xXgYqSCFjdUeROuR(LYLuhfFMYMCNvzcf(JxnYQWglybvzvZKF(new java.lang.stringBuilder(wDaawUoElXNihBou(jrchCDTtcOsjEYCR(strYhWJEBHXustYZBvC)) + 19 + vHebfAwgtJOcIQfj(CSnztDodGyFOUHwi(strMFbIJsQzpcYZYTsA))), "CharMatch.and("), strYhWJEBHXustYZBvC), ", "), strMFbIJsQzpcYZYTsA), ")"));
    }
}

