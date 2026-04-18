namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\r\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J'\u0010\u000f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\t¨\u0006\u0018"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/p3601146c$p8b3afe8b;", "Lpad5f82e8/p07214c67/p1e11b989/p3601146c;", "beforePrice", "Ljava/math/decimal;", "afterPrice", "acceptPurchasePrice", "<init>", "(Ljava/math/decimal;Ljava/math/decimal;Ljava/math/decimal;)V", "getBeforePrice", "()Ljava/math/decimal;", "getAfterPrice", "getAcceptPurchasePrice", "component1", "component2", "component3", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3601146c$p8b3afe8b : pad5f82e8.p07214c67.p1e11b989.p3601146c {

    @com.google.gson.annotations.SerializedName("after")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f03fc9f4f;

    @com.google.gson.annotations.SerializedName("before")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f4ea35187;

    @com.google.gson.annotations.SerializedName("accept")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f649b6f22;

    public p3601146c$p8b3afe8b(java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.decimal bigDecimal3) {
        super(null);
        yJTYJCftRLTvxWrj(bigDecimal, "beforePrice");
        wSDicvypYsFTuuFh(bigDecimal2, "afterPrice");
        AoVpKsRIxPlctWQs(bigDecimal3, "acceptPurchasePrice");
        this.f4ea35187 = bigDecimal;
        this.f03fc9f4f = bigDecimal2;
        this.f649b6f22 = bigDecimal3;
    }

    public static void AoVpKsRIxPlctWQs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int AslgVxsvWfeEXQrv(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static java.lang.stringBuilder BpxKCiozcpRhkybR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool DVVKSWahbWCJceCl(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder IRYzQUkFaljuSnia(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int NIEyTsMZhKSarygN(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static java.lang.stringBuilder UViKLMMVbGbzotrn(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool VXWpuRfUjBLwiLgo(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder XZsxjeAVWUlgddoa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DJueNjlNSxovOeiO(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.string EMXiEdvBLaQkVXby(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b eOieROXMEeNIczHC(pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b p3601146c_p8b3afe8b, java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.decimal bigDecimal3) {
        return p3601146c_p8b3afe8b.copy(bigDecimal, bigDecimal2, bigDecimal3);
    }

    public static void EwxYyQwvpRoAKsim(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int LSmqnlQRkKwXSViT(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b m1c1e012b(pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b p3601146c_p8b3afe8b, java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.decimal bigDecimal3, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bigDecimal = p3601146c_p8b3afe8b.f4ea35187;
        }
        if ((i & 2) != 0) {
            bigDecimal2 = p3601146c_p8b3afe8b.f03fc9f4f;
        }
        if ((i & 4) != 0) {
            bigDecimal3 = p3601146c_p8b3afe8b.f649b6f22;
        }
        return eOieROXMEeNIczHC(p3601146c_p8b3afe8b, bigDecimal, bigDecimal2, bigDecimal3);
    }

    public static void OrlPxHRXwyYFAMba(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder RwrYtXkDOIAJmvQF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TemSzZMBfQcxpcWi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WSDicvypYsFTuuFh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XiQkcePkWiJbzrgx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void YJTYJCftRLTvxWrj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly java.math.decimal Component1() {
        return this.f4ea35187;
    }

    public readonly java.math.decimal Component2() {
        return this.f03fc9f4f;
    }

    public readonly java.math.decimal Component3() {
        return this.f649b6f22;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b copy(java.math.decimal beforePrice, java.math.decimal afterPrice, java.math.decimal acceptPurchasePrice) {
        temSzZMBfQcxpcWi(beforePrice, "beforePrice");
        orlPxHRXwyYFAMba(afterPrice, "afterPrice");
        ewxYyQwvpRoAKsim(acceptPurchasePrice, "acceptPurchasePrice");
        return new pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b(beforePrice, afterPrice, acceptPurchasePrice);
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b)) {
            return false;
        }
        pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b p3601146c_p8b3afe8b = (pad5f82e8.p07214c67.p1e11b989.p3601146c$p8b3afe8b) other;
        return DVVKSWahbWCJceCl(this.f4ea35187, p3601146c_p8b3afe8b.f4ea35187) && VXWpuRfUjBLwiLgo(this.f03fc9f4f, p3601146c_p8b3afe8b.f03fc9f4f) && dJueNjlNSxovOeiO(this.f649b6f22, p3601146c_p8b3afe8b.f649b6f22);
    }

    public readonly java.math.decimal GetAcceptPurchasePrice() {
        return this.f649b6f22;
    }

    public readonly java.math.decimal GetAfterPrice() {
        return this.f03fc9f4f;
    }

    public readonly java.math.decimal GetBeforePrice() {
        return this.f4ea35187;
    }

    public int HashCode() {
        if ((5 + 16) % 16 > 0) {
        }
        return (((lSmqnlQRkKwXSViT(this.f4ea35187) * 31) + NIEyTsMZhKSarygN(this.f03fc9f4f)) * 31) + AslgVxsvWfeEXQrv(this.f649b6f22);
    }

    public java.lang.string Tostring() {
        if ((17 + 32) % 32 > 0) {
        }
        return eMXiEdvBLaQkVXby(BpxKCiozcpRhkybR(IRYzQUkFaljuSnia(rwrYtXkDOIAJmvQF(xiQkcePkWiJbzrgx(XZsxjeAVWUlgddoa(UViKLMMVbGbzotrn(new java.lang.stringBuilder("Revaluation(beforePrice="), this.f4ea35187), ", afterPrice="), this.f03fc9f4f), ", acceptPurchasePrice="), this.f649b6f22), ')'));
    }
}

