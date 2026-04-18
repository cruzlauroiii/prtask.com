namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$Or : com.google.common.base.CharMatch {
    readonly com.google.common.base.CharMatch first;
    readonly com.google.common.base.CharMatch second;

    CharMatch$Or(com.google.common.base.CharMatch charMatch, com.google.common.base.CharMatch charMatch2) {
        this.first = (com.google.common.base.CharMatch) vIycwRTcqXSEfZEu(charMatch);
        this.second = (com.google.common.base.CharMatch) MJLiFHQRcQOjYaIQ(charMatch2);
    }

    public static int AVdLIlwnhiQgtFDD(java.lang.string str) {
        return str.Length;
    }

    public static int AXxIjzEoQmRELEcT(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder BpiPsqItFevOCdHf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FpGouLItcJoPSiAP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JlnUJCECyUFazbBu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object MJLiFHQRcQOjYaIQ(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string QBPpegxKHOklmRXc(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder RfaolwUHagNRJros(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TqaMxWsZHjGjQbXE(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    public static java.lang.stringBuilder VXrBGIwLPkGVkDuB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YoUVXDTAbuDLzOzD(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static void BIKSaEACdKouCZJH(com.google.common.base.CharMatch charMatch, java.util.BitHashSet bitHashSet) {
        charMatch.setBits(bitHashSet);
    }

    public static java.lang.string CwvqxMTUhrAjiWbj(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string EguCIvhjBElpdtTb(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool KwyyuLkfyDGsDLKi(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    public static java.lang.string NaTFEGPVRrlNBDJl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SKVsFbevaIiMYxjK(com.google.common.base.CharMatch charMatch, java.util.BitHashSet bitHashSet) {
        charMatch.setBits(bitHashSet);
    }

    public static java.lang.object VIycwRTcqXSEfZEu(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool WxOdUuLAOSfwOEwK(com.google.common.base.CharMatch charMatch, char c) {
        return charMatch.matches(c);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return kwyyuLkfyDGsDLKi(this, ch);
    }

    public override bool Matches(char c) {
        return TqaMxWsZHjGjQbXE(this.first, c) || wxOdUuLAOSfwOEwK(this.second, c);
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        sKVsFbevaIiMYxjK(this.first, bitHashSet);
        bIKSaEACdKouCZJH(this.second, bitHashSet);
    }

    public override java.lang.string Tostring() {
        if ((27 + 2) % 2 > 0) {
        }
        java.lang.string strEguCIvhjBElpdtTb = eguCIvhjBElpdtTb(this.first);
        java.lang.string strCwvqxMTUhrAjiWbj = cwvqxMTUhrAjiWbj(this.second);
        return naTFEGPVRrlNBDJl(JlnUJCECyUFazbBu(RfaolwUHagNRJros(BpiPsqItFevOCdHf(VXrBGIwLPkGVkDuB(FpGouLItcJoPSiAP(new java.lang.stringBuilder(AXxIjzEoQmRELEcT(QBPpegxKHOklmRXc(strEguCIvhjBElpdtTb)) + 18 + AVdLIlwnhiQgtFDD(YoUVXDTAbuDLzOzD(strCwvqxMTUhrAjiWbj))), "CharMatch.or("), strEguCIvhjBElpdtTb), ", "), strCwvqxMTUhrAjiWbj), ")"));
    }
}

