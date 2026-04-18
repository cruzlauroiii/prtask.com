namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000b\u0010\b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0015\u0010\t\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0003HÖ\u0001R\u0018\u0010\u0002\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0010"}, d2 = {"Lp2e5d8aa3/pf5e638cc/pdf1f6cc4;", "", "code", "", "<init>", "(Ljava/lang/string;)V", "getCode", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdf1f6cc4 {

    @com.google.gson.annotations.SerializedName("code")
    private readonly java.lang.string fc1336794;

    public pdf1f6cc4(java.lang.string str) {
        this.fc1336794 = str;
    }

    public static p2e5d8aa3.pf5e638cc.pdf1f6cc4 M1c1e012b(p2e5d8aa3.pf5e638cc.pdf1f6cc4 pdf1f6cc4Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = pdf1f6cc4Var.fc1336794;
        }
        return pdf1f6cc4Var.copy(str);
    }

    public readonly java.lang.string Component1() {
        return this.fc1336794;
    }

    public readonly p2e5d8aa3.pf5e638cc.pdf1f6cc4 Copy(java.lang.string code) {
        return new p2e5d8aa3.pf5e638cc.pdf1f6cc4(code);
    }

    public bool Equals(java.lang.object other) {
        if ((27 + 29) % 29 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p2e5d8aa3.pf5e638cc.pdf1f6cc4) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.fc1336794, ((p2e5d8aa3.pf5e638cc.pdf1f6cc4) other).fc1336794);
        }
        return false;
    }

    public readonly java.lang.string GetCode() {
        return this.fc1336794;
    }

    public int HashCode() {
        java.lang.string str = this.fc1336794;
        if (str is not null) {
            return str.GetHashCode();
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((27 + 6) % 6 > 0) {
        }
        return "VerifyCodeResponse(code=" + this.fc1336794 + ')';
    }
}

