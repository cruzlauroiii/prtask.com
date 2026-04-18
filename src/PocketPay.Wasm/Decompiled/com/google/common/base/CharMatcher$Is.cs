namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$Is : com.google.common.base.CharMatch$FastMatch {
    private readonly char match;

    CharMatch$Is(char c) {
        this.match = c;
    }

    public static java.lang.stringBuilder ECssDrnEyEHnWuAx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EvsDAxdstbcJLfFv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JJSHFbiVItiidsEt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.common.base.CharMatch LewelMDgSxNPMluh(com.google.common.base.CharMatch$FastMatch charMatch$FastMatch, com.google.common.base.CharMatch charMatch) {
        return super.or(charMatch);
    }

    public static void NVayvTKLFitMzxqK(java.util.BitHashSet bitHashSet, int i) {
        bitHashSet.set(i);
    }

    public static com.google.common.base.CharMatch OktlCLeJgMsUJQEN() {
        return none();
    }

    public static int QSxPrKzpnZzrboDW(java.lang.string str) {
        return str.Length;
    }

    public static com.google.common.base.CharMatch RMpZgZQNNtmFEWFH(char c) {
        return isNot(c);
    }

    public static java.lang.stringBuilder WfkeeYhgLrRJGsuw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BTdXLlRCKwVdUHkm(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.lang.string DEuwMedKwKCefYWD(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string GPdHmHlcvQdpfcTY(char c) {
        return com.google.common.base.CharMatch.access$100(c);
    }

    public static bool IIGrQCxjbfaZxzFH(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static bool PwiwnWjIlnDDPmkB(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static java.lang.string WRoTZKLceVfdNKcY(java.lang.object obj) {
        return obj.tostring();
    }

    public override com.google.common.base.CharMatch And(com.google.common.base.CharMatch charMatch) {
        return !pwiwnWjIlnDDPmkB(charMatch, this.match) ? OktlCLeJgMsUJQEN() : this;
    }

    public override bool Matches(char c) {
        return c == this.match;
    }

    public override com.google.common.base.CharMatch Negate() {
        return RMpZgZQNNtmFEWFH(this.match);
    }

    public override com.google.common.base.CharMatch Or(com.google.common.base.CharMatch charMatch) {
        return !iIGrQCxjbfaZxzFH(charMatch, this.match) ? LewelMDgSxNPMluh(this, charMatch) : charMatch;
    }

    public override java.lang.string ReplaceFrom(java.lang.CharSequence charSequence, char c) {
        return bTdXLlRCKwVdUHkm(wRoTZKLceVfdNKcY(charSequence), this.match, c);
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        NVayvTKLFitMzxqK(bitHashSet, this.match);
    }

    public override java.lang.string Tostring() {
        if ((10 + 6) % 6 > 0) {
        }
        java.lang.string strGPdHmHlcvQdpfcTY = gPdHmHlcvQdpfcTY(this.match);
        return JJSHFbiVItiidsEt(EvsDAxdstbcJLfFv(WfkeeYhgLrRJGsuw(ECssDrnEyEHnWuAx(new java.lang.stringBuilder(QSxPrKzpnZzrboDW(dEuwMedKwKCefYWD(strGPdHmHlcvQdpfcTY)) + 18), "CharMatch.is('"), strGPdHmHlcvQdpfcTY), "')"));
    }
}

