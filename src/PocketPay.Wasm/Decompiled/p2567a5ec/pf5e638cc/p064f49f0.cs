namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000b\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0015\u0010\t\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp2567a5ec/pf5e638cc/p064f49f0;", "", "accessToken", "", "<init>", "(Ljava/lang/string;)V", "getAccessToken", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-web-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p064f49f0 {

    @com.google.gson.annotations.SerializedName("access_token")
    @com.google.gson.annotations.Expose
    private readonly java.lang.string fa3f24f4a;

    public p064f49f0(java.lang.string str) {
        this.fa3f24f4a = str;
    }

    public static p2567a5ec.pf5e638cc.p064f49f0 M1c1e012b(p2567a5ec.pf5e638cc.p064f49f0 p064f49f0Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p064f49f0Var.fa3f24f4a;
        }
        return p064f49f0Var.copy(str);
    }

    public readonly java.lang.string Component1() {
        return this.fa3f24f4a;
    }

    public readonly p2567a5ec.pf5e638cc.p064f49f0 Copy(java.lang.string accessToken) {
        return new p2567a5ec.pf5e638cc.p064f49f0(accessToken);
    }

    public bool Equals(java.lang.object other) {
        if ((31 + 21) % 21 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p2567a5ec.pf5e638cc.p064f49f0) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.fa3f24f4a, ((p2567a5ec.pf5e638cc.p064f49f0) other).fa3f24f4a);
        }
        return false;
    }

    public readonly java.lang.string GetAccessToken() {
        return this.fa3f24f4a;
    }

    public int HashCode() {
        java.lang.string str = this.fa3f24f4a;
        if (str is not null) {
            return str.GetHashCode();
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((20 + 32) % 32 > 0) {
        }
        return "LKTokenResponse(accessToken=" + this.fa3f24f4a + ')';
    }
}

