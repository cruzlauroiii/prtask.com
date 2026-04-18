namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B!\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\u0014\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005HÆ\u0003¢\u0006\u0002\u0010\fJ(\u0010\u0010\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005HÆ\u0001¢\u0006\u0002\u0010\u0011J\u0013\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0015\u001a\u00020\u0016HÖ\u0001J\t\u0010\u0017\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u001e\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u00058\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\r\u001a\u0004\b\u000b\u0010\f¨\u0006\u0018"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/pec2d4f28;", "", "type", "", "items", "", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/p358eb325;", "<init>", "(Ljava/lang/string;[Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/p358eb325;)V", "getType", "()Ljava/lang/string;", "getItems", "()[Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/p358eb325;", "[Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/p358eb325;", "component1", "component2", "copy", "(Ljava/lang/string;[Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/p358eb325;)Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pad8a2265/pec2d4f28;", "equals", "", "other", "hashCode", "", "tostring", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pec2d4f28 {

    @com.google.gson.annotations.SerializedName("type")
    private readonly java.lang.string f599dcce2;

    @com.google.gson.annotations.SerializedName("items")
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] f691d502c;

    public pec2d4f28() {
        this(null, null, 3, null);
        if ((9 + 3) % 3 > 0) {
        }
    }

    public pec2d4f28(java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr) {
        VMFcUJaiUlSNvnWg(str, "type");
        yRPBVupUKMpycAQL(p358eb325VarArr, "items");
        this.f599dcce2 = str;
        this.f691d502c = p358eb325VarArr;
    }

    public pec2d4f28(java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? "log" : str, (i & 2) != 0 ? new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[0] : p358eb325VarArr);
    }

    public static java.lang.stringBuilder BwOSiiwfswiXVmkG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void BwOSiiwfswiXVmkG(java.lang.stringBuilder sb, char c, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BwOSiiwfswiXVmkG(java.lang.stringBuilder sb, char c, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BwOSiiwfswiXVmkG(java.lang.stringBuilder sb, char c, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 FZjoXhTapowcgZNd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr) {
        return pec2d4f28Var.copy(str, p358eb325VarArr);
    }

    public static void FZjoXhTapowcgZNd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FZjoXhTapowcgZNd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FZjoXhTapowcgZNd(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KHVaYovbzmXAxEGc(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static void KHVaYovbzmXAxEGc(java.lang.object[] objArr, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHVaYovbzmXAxEGc(java.lang.object[] objArr, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHVaYovbzmXAxEGc(java.lang.object[] objArr, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MyAJGPVLTIBCtWrU(java.lang.object obj, java.lang.object obj2, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MyAJGPVLTIBCtWrU(java.lang.object obj, java.lang.object obj2, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MyAJGPVLTIBCtWrU(java.lang.object obj, java.lang.object obj2, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MyAJGPVLTIBCtWrU(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void NlkOBntkRsYFcOEd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NlkOBntkRsYFcOEd(java.lang.object obj, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NlkOBntkRsYFcOEd(java.lang.object obj, java.lang.string str, float f, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NlkOBntkRsYFcOEd(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBlgIeleieDHHrYa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PBlgIeleieDHHrYa(java.lang.object obj, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PBlgIeleieDHHrYa(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBlgIeleieDHHrYa(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QAMvXmLduYAUXWJv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QAMvXmLduYAUXWJv(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QAMvXmLduYAUXWJv(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QAMvXmLduYAUXWJv(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SaOBPCGOyHnVYplK(java.lang.object obj, java.lang.object obj2, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SaOBPCGOyHnVYplK(java.lang.object obj, java.lang.object obj2, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SaOBPCGOyHnVYplK(java.lang.object obj, java.lang.object obj2, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SaOBPCGOyHnVYplK(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void VMFcUJaiUlSNvnWg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VMFcUJaiUlSNvnWg(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VMFcUJaiUlSNvnWg(java.lang.object obj, java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VMFcUJaiUlSNvnWg(java.lang.object obj, java.lang.string str, bool z, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XUHRmEKliUxArYwb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XUHRmEKliUxArYwb(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUHRmEKliUxArYwb(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUHRmEKliUxArYwb(java.lang.stringBuilder sb, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BJTtEeftrqbXCrfB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BJTtEeftrqbXCrfB(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJTtEeftrqbXCrfB(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BJTtEeftrqbXCrfB(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pec2d4f28Var.f599dcce2;
        }
        if ((i & 2) != 0) {
            p358eb325VarArr = pec2d4f28Var.f691d502c;
        }
        return FZjoXhTapowcgZNd(pec2d4f28Var, str, p358eb325VarArr);
    }

    public static void M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, int i, java.lang.object obj, byte b, int i2, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, int i, java.lang.object obj, byte b, bool z, java.lang.string str2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var, java.lang.string str, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] p358eb325VarArr, int i, java.lang.object obj, java.lang.string str2, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QiUecivTrMQeTgWV(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static void QiUecivTrMQeTgWV(java.lang.object[] objArr, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QiUecivTrMQeTgWV(java.lang.object[] objArr, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QiUecivTrMQeTgWV(java.lang.object[] objArr, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VvZTMaSyeLYaiTAz(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void VvZTMaSyeLYaiTAz(java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VvZTMaSyeLYaiTAz(java.lang.string str, byte b, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VvZTMaSyeLYaiTAz(java.lang.string str, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YCiXlHPcvnCvEeIy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YCiXlHPcvnCvEeIy(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YCiXlHPcvnCvEeIy(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YCiXlHPcvnCvEeIy(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRPBVupUKMpycAQL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YRPBVupUKMpycAQL(java.lang.object obj, java.lang.string str, char c, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YRPBVupUKMpycAQL(java.lang.object obj, java.lang.string str, float f, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YRPBVupUKMpycAQL(java.lang.object obj, java.lang.string str, short s, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.string Component1() {
        return this.f599dcce2;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] Component2() {
        return this.f691d502c;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 Copy(java.lang.string type, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] items) {
        NlkOBntkRsYFcOEd(type, "type");
        PBlgIeleieDHHrYa(items, "items");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28(type, items);
    }

    public bool Equals(java.lang.object other) {
        if ((20 + 17) % 17 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28)) {
            return false;
        }
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28) other;
        return MyAJGPVLTIBCtWrU(this.f599dcce2, pec2d4f28Var.f599dcce2) && SaOBPCGOyHnVYplK(this.f691d502c, pec2d4f28Var.f691d502c);
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.p358eb325[] GetItems() {
        return this.f691d502c;
    }

    public readonly java.lang.string GetType() {
        return this.f599dcce2;
    }

    public int HashCode() {
        return (vvZTMaSyeLYaiTAz(this.f599dcce2) * 31) + qiUecivTrMQeTgWV(this.f691d502c);
    }

    public java.lang.string Tostring() {
        if ((28 + 30) % 30 > 0) {
        }
        return XUHRmEKliUxArYwb(BwOSiiwfswiXVmkG(yCiXlHPcvnCvEeIy(QAMvXmLduYAUXWJv(bJTtEeftrqbXCrfB(new java.lang.stringBuilder("ConsolePacket(type="), this.f599dcce2), ", items="), KHVaYovbzmXAxEGc(this.f691d502c)), ')'));
    }
}

