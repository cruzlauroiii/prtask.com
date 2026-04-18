namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\r\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B!\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u000e\u001a\u0004\u0018\u00010\u0003HÆ\u0003J)\u0010\u000f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tR\u0018\u0010\u0005\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\t¨\u0006\u0016"}, d2 = {"Lp563873d3/p07214c67/pe0f65408;", "", "phone", "", "androidId", "shopUuid", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getPhone", "()Ljava/lang/string;", "getAndroidId", "getShopUuid", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-registration-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe0f65408 {

    @com.google.gson.annotations.SerializedName("shop_uuid")
    private readonly java.lang.string f9417637d;

    @com.google.gson.annotations.SerializedName("phone")
    private readonly java.lang.string ff7a42fe7;

    @com.google.gson.annotations.SerializedName("device_id")
    private readonly java.lang.string ffd9705a2;

    public pe0f65408(java.lang.string phone, java.lang.string androidId, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(androidId, "androidId");
        this.ff7a42fe7 = phone;
        this.ffd9705a2 = androidId;
        this.f9417637d = str;
    }

    public static p563873d3.p07214c67.pe0f65408 M1c1e012b(p563873d3.p07214c67.pe0f65408 pe0f65408Var, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pe0f65408Var.ff7a42fe7;
        }
        if ((i & 2) != 0) {
            str2 = pe0f65408Var.ffd9705a2;
        }
        if ((i & 4) != 0) {
            str3 = pe0f65408Var.f9417637d;
        }
        return pe0f65408Var.copy(str, str2, str3);
    }

    public readonly java.lang.string Component1() {
        return this.ff7a42fe7;
    }

    public readonly java.lang.string Component2() {
        return this.ffd9705a2;
    }

    public readonly java.lang.string Component3() {
        return this.f9417637d;
    }

    public readonly p563873d3.p07214c67.pe0f65408 Copy(java.lang.string phone, java.lang.string androidId, java.lang.string shopUuid) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(androidId, "androidId");
        return new p563873d3.p07214c67.pe0f65408(phone, androidId, shopUuid);
    }

    public bool Equals(java.lang.object other) {
        if ((15 + 25) % 25 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p563873d3.p07214c67.pe0f65408)) {
            return false;
        }
        p563873d3.p07214c67.pe0f65408 pe0f65408Var = (p563873d3.p07214c67.pe0f65408) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.ff7a42fe7, pe0f65408Var.ff7a42fe7) && kotlin.jvm.internal.Intrinsics.areEqual(this.ffd9705a2, pe0f65408Var.ffd9705a2) && kotlin.jvm.internal.Intrinsics.areEqual(this.f9417637d, pe0f65408Var.f9417637d);
    }

    public readonly java.lang.string GetAndroidId() {
        return this.ffd9705a2;
    }

    public readonly java.lang.string GetPhone() {
        return this.ff7a42fe7;
    }

    public readonly java.lang.string GetShopUuid() {
        return this.f9417637d;
    }

    public int HashCode() {
        if ((28 + 1) % 1 > 0) {
        }
        int iHashCode = ((this.ff7a42fe7.GetHashCode() * 31) + this.ffd9705a2.GetHashCode()) * 31;
        java.lang.string str = this.f9417637d;
        return iHashCode + (str is not null ? str.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((27 + 29) % 29 > 0) {
        }
        return "RegisteredUserBody(phone=" + this.ff7a42fe7 + ", androidId=" + this.ffd9705a2 + ", shopUuid=" + this.f9417637d + ')';
    }
}

