namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0086\b\u0018\u00002\u00020\u0001B/\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0004\b\t\u0010\nJ\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0014\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0015\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0016\u001a\u00020\bHÆ\u0003J;\u0010\u0017\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u00032\b\b\u0002\u0010\u0007\u001a\u00020\bHÆ\u0001J\u0013\u0010\u0018\u001a\u00020\u00192\b\u0010\u001a\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001b\u001a\u00020\bHÖ\u0001J\t\u0010\u001c\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\fR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\fR\u0016\u0010\u0006\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\fR\u0016\u0010\u0007\u001a\u00020\b8\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u001d"}, d2 = {"Lp83f5c3ad/p07214c67/p1f723f91;", "", "userId", "", "phone", "fio", "inn", "regionId", "", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;I)V", "getUserId", "()Ljava/lang/string;", "getPhone", "getFio", "getInn", "getRegionId", "()I", "component1", "component2", "component3", "component4", "component5", "copy", "equals", "", "other", "hashCode", "tostring", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1f723f91 {

    @com.google.gson.annotations.SerializedName("inn")
    private readonly java.lang.string f0b9a9301;

    @com.google.gson.annotations.SerializedName("user_id")
    private readonly java.lang.string f8e44f008;

    @com.google.gson.annotations.SerializedName("region_id")
    private readonly int fa6bf3b23;

    @com.google.gson.annotations.SerializedName("name")
    private readonly java.lang.string ff003984a;

    @com.google.gson.annotations.SerializedName("phone")
    private readonly java.lang.string ff7a42fe7;

    public p1f723f91(java.lang.string userId, java.lang.string phone, java.lang.string fio, java.lang.string inn, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userId, "userId");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fio, "fio");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inn, "inn");
        this.f8e44f008 = userId;
        this.ff7a42fe7 = phone;
        this.ff003984a = fio;
        this.f0b9a9301 = inn;
        this.fa6bf3b23 = i;
    }

    public static p83f5c3ad.p07214c67.p1f723f91 M1c1e012b(p83f5c3ad.p07214c67.p1f723f91 p1f723f91Var, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            str = p1f723f91Var.f8e44f008;
        }
        if ((i2 & 2) != 0) {
            str2 = p1f723f91Var.ff7a42fe7;
        }
        if ((i2 & 4) != 0) {
            str3 = p1f723f91Var.ff003984a;
        }
        if ((i2 & 8) != 0) {
            str4 = p1f723f91Var.f0b9a9301;
        }
        if ((i2 & 16) != 0) {
            i = p1f723f91Var.fa6bf3b23;
        }
        int i3 = i;
        return p1f723f91Var.copy(str, str2, str3, str4, i3);
    }

    public readonly java.lang.string Component1() {
        return this.f8e44f008;
    }

    public readonly java.lang.string Component2() {
        return this.ff7a42fe7;
    }

    public readonly java.lang.string Component3() {
        return this.ff003984a;
    }

    public readonly java.lang.string Component4() {
        return this.f0b9a9301;
    }

    public readonly int Component5() {
        return this.fa6bf3b23;
    }

    public readonly p83f5c3ad.p07214c67.p1f723f91 Copy(java.lang.string userId, java.lang.string phone, java.lang.string fio, java.lang.string inn, int regionId) {
        if ((14 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(userId, "userId");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fio, "fio");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inn, "inn");
        return new p83f5c3ad.p07214c67.p1f723f91(userId, phone, fio, inn, regionId);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 10) % 10 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.p1f723f91)) {
            return false;
        }
        p83f5c3ad.p07214c67.p1f723f91 p1f723f91Var = (p83f5c3ad.p07214c67.p1f723f91) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f8e44f008, p1f723f91Var.f8e44f008) && kotlin.jvm.internal.Intrinsics.areEqual(this.ff7a42fe7, p1f723f91Var.ff7a42fe7) && kotlin.jvm.internal.Intrinsics.areEqual(this.ff003984a, p1f723f91Var.ff003984a) && kotlin.jvm.internal.Intrinsics.areEqual(this.f0b9a9301, p1f723f91Var.f0b9a9301) && this.fa6bf3b23 == p1f723f91Var.fa6bf3b23;
    }

    public readonly java.lang.string GetFio() {
        return this.ff003984a;
    }

    public readonly java.lang.string GetInn() {
        return this.f0b9a9301;
    }

    public readonly java.lang.string GetPhone() {
        return this.ff7a42fe7;
    }

    public readonly int GetRegionId() {
        return this.fa6bf3b23;
    }

    public readonly java.lang.string GetUserId() {
        return this.f8e44f008;
    }

    public int HashCode() {
        if ((8 + 17) % 17 > 0) {
        }
        return (((((((this.f8e44f008.GetHashCode() * 31) + this.ff7a42fe7.GetHashCode()) * 31) + this.ff003984a.GetHashCode()) * 31) + this.f0b9a9301.GetHashCode()) * 31) + java.lang.int.hashCode(this.fa6bf3b23);
    }

    public java.lang.string Tostring() {
        if ((28 + 12) % 12 > 0) {
        }
        return "TophOrderRequest(userId=" + this.f8e44f008 + ", phone=" + this.ff7a42fe7 + ", fio=" + this.ff003984a + ", inn=" + this.f0b9a9301 + ", regionId=" + this.fa6bf3b23 + ')';
    }
}

