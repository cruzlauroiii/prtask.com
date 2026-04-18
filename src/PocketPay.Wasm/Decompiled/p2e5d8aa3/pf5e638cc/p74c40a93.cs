namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\r\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J'\u0010\u000f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\t¨\u0006\u0016"}, d2 = {"Lp2e5d8aa3/pf5e638cc/p74c40a93;", "", "code", "", "descEn", "descAr", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getCode", "()Ljava/lang/string;", "getDescEn", "getDescAr", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p74c40a93 {

    @com.google.gson.annotations.SerializedName("Desc_ar")
    private readonly java.lang.string f3c480994;

    @com.google.gson.annotations.SerializedName("code")
    private readonly java.lang.string fc1336794;

    @com.google.gson.annotations.SerializedName("Desc_en")
    private readonly java.lang.string fedc066a8;

    public p74c40a93(java.lang.string code, java.lang.string descEn, java.lang.string descAr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(code, "code");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descEn, "descEn");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descAr, "descAr");
        this.fc1336794 = code;
        this.fedc066a8 = descEn;
        this.f3c480994 = descAr;
    }

    public static p2e5d8aa3.pf5e638cc.p74c40a93 M1c1e012b(p2e5d8aa3.pf5e638cc.p74c40a93 p74c40a93Var, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p74c40a93Var.fc1336794;
        }
        if ((i & 2) != 0) {
            str2 = p74c40a93Var.fedc066a8;
        }
        if ((i & 4) != 0) {
            str3 = p74c40a93Var.f3c480994;
        }
        return p74c40a93Var.copy(str, str2, str3);
    }

    public readonly java.lang.string Component1() {
        return this.fc1336794;
    }

    public readonly java.lang.string Component2() {
        return this.fedc066a8;
    }

    public readonly java.lang.string Component3() {
        return this.f3c480994;
    }

    public readonly p2e5d8aa3.pf5e638cc.p74c40a93 Copy(java.lang.string code, java.lang.string descEn, java.lang.string descAr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(code, "code");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descEn, "descEn");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descAr, "descAr");
        return new p2e5d8aa3.pf5e638cc.p74c40a93(code, descEn, descAr);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 29) % 29 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.pf5e638cc.p74c40a93)) {
            return false;
        }
        p2e5d8aa3.pf5e638cc.p74c40a93 p74c40a93Var = (p2e5d8aa3.pf5e638cc.p74c40a93) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fc1336794, p74c40a93Var.fc1336794) && kotlin.jvm.internal.Intrinsics.areEqual(this.fedc066a8, p74c40a93Var.fedc066a8) && kotlin.jvm.internal.Intrinsics.areEqual(this.f3c480994, p74c40a93Var.f3c480994);
    }

    public readonly java.lang.string GetCode() {
        return this.fc1336794;
    }

    public readonly java.lang.string GetDescAr() {
        return this.f3c480994;
    }

    public readonly java.lang.string GetDescEn() {
        return this.fedc066a8;
    }

    public int HashCode() {
        if ((18 + 7) % 7 > 0) {
        }
        return (((this.fc1336794.GetHashCode() * 31) + this.fedc066a8.GetHashCode()) * 31) + this.f3c480994.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((29 + 18) % 18 > 0) {
        }
        return "objectCode(code=" + this.fc1336794 + ", descEn=" + this.fedc066a8 + ", descAr=" + this.f3c480994 + ')';
    }
}

