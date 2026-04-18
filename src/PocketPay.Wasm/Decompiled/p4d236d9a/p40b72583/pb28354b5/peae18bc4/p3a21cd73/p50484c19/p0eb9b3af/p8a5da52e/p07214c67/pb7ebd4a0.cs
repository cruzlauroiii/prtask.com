namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\b\n\u0002\b\r\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B!\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u000b\u0010\u0010\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0012\u001a\u00020\u0007HÆ\u0003J)\u0010\u0013\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u0007HÆ\u0001J\u0013\u0010\u0014\u001a\u00020\u00152\b\u0010\u0016\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0017\u001a\u00020\u0007HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0019HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0016\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0016\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u001a"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p07214c67/pb7ebd4a0;", "", "location", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pd5189de0/pb697b2b6;", "chipData", "", "currency", "", "<init>", "(Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pd5189de0/pb697b2b6;[BI)V", "getLocation", "()Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p9efab239/p07214c67/pd5189de0/pb697b2b6;", "getChipData", "()[B", "getCurrency", "()I", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "tostring", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb7ebd4a0 {

    @com.google.gson.annotations.SerializedName("chipData")
    private readonly byte[] f04552479;

    @com.google.gson.annotations.SerializedName("currency")
    private readonly int f1af03898;

    @com.google.gson.annotations.SerializedName("location")
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 fd5189de0;

    public pb7ebd4a0(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 pb697b2b6Var, byte[] bArr, int i) {
        HUmDchXvxuEHteTk(bArr, "chipData");
        this.fd5189de0 = pb697b2b6Var;
        this.f04552479 = bArr;
        this.f1af03898 = i;
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0 CGtdDGgzQEdNDjLM(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0 pb7ebd4a0Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 pb697b2b6Var, byte[] bArr, int i) {
        return pb7ebd4a0Var.copy(pb697b2b6Var, bArr, i);
    }

    public static java.lang.string EvwaSWNlfgjeVYbs(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static void HUmDchXvxuEHteTk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HrpBdHwNaZmMkTzX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ItjMsACIkAuZfHzp(int i) {
        return java.lang.int.hashCode(i);
    }

    public static bool JkpyJyzOpZxmpnPm(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder LHCttChoLeonHxps(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OPZcLDwYoJDVwczt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ARidQoGYkHmfCYTT(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder AoaKNJVimIFIGKJQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder CatBAPxKaecagCTc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int DBVXKpoCmgCAtSNa(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 pb697b2b6Var) {
        return pb697b2b6Var.GetHashCode();
    }

    public static java.lang.stringBuilder DHbGlpQTjJEesYwF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EFWJyxkhXEuxiJCl(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static java.lang.string LXMtpSyFShmpcmZl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0 M1c1e012b(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0 pb7ebd4a0Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 pb697b2b6Var, byte[] bArr, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            pb697b2b6Var = pb7ebd4a0Var.fd5189de0;
        }
        if ((i2 & 2) != 0) {
            bArr = pb7ebd4a0Var.f04552479;
        }
        if ((i2 & 4) != 0) {
            i = pb7ebd4a0Var.f1af03898;
        }
        return CGtdDGgzQEdNDjLM(pb7ebd4a0Var, pb697b2b6Var, bArr, i);
    }

    public static java.lang.stringBuilder QckKZgtxIIATZmNo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 Component1() {
        return this.fd5189de0;
    }

    public readonly byte[] Component2() {
        return this.f04552479;
    }

    public readonly int Component3() {
        return this.f1af03898;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0 Copy(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 location, byte[] chipData, int currency) {
        HrpBdHwNaZmMkTzX(chipData, "chipData");
        return new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0(location, chipData, currency);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 7) % 7 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0)) {
            return false;
        }
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0 pb7ebd4a0Var = (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.pb7ebd4a0) other;
        return JkpyJyzOpZxmpnPm(this.fd5189de0, pb7ebd4a0Var.fd5189de0) && aRidQoGYkHmfCYTT(this.f04552479, pb7ebd4a0Var.f04552479) && this.f1af03898 == pb7ebd4a0Var.f1af03898;
    }

    public readonly byte[] GetChipData() {
        return this.f04552479;
    }

    public readonly int GetCurrency() {
        return this.f1af03898;
    }

    public readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 GetLocation() {
        return this.fd5189de0;
    }

    public int HashCode() {
        if ((23 + 32) % 32 > 0) {
        }
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pd5189de0.pb697b2b6 pb697b2b6Var = this.fd5189de0;
        return ((((pb697b2b6Var is not null ? dBVXKpoCmgCAtSNa(pb697b2b6Var) : 0) * 31) + eFWJyxkhXEuxiJCl(this.f04552479)) * 31) + ItjMsACIkAuZfHzp(this.f1af03898);
    }

    public java.lang.string Tostring() {
        if ((11 + 25) % 25 > 0) {
        }
        return lXMtpSyFShmpcmZl(LHCttChoLeonHxps(catBAPxKaecagCTc(dHbGlpQTjJEesYwF(OPZcLDwYoJDVwczt(qckKZgtxIIATZmNo(aoaKNJVimIFIGKJQ(new java.lang.stringBuilder("BalanceRequest(location="), this.fd5189de0), ", chipData="), EvwaSWNlfgjeVYbs(this.f04552479)), ", currency="), this.f1af03898), ')'));
    }
}

