namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u000b\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\b\n\u0002\b\u0003\b\u0086\b\u0018\u0000 \u001a2\u00020\u0001:\u0001\u001aB'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\u0006\u0010\u000e\u001a\u00020\u000fJ\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0003HÆ\u0003J1\u0010\u0014\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0015\u001a\u00020\u000f2\b\u0010\u0016\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0017\u001a\u00020\u0018HÖ\u0001J\t\u0010\u0019\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0016\u0010\u0005\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0016\u0010\u0006\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u001b"}, d2 = {"Lp2e5d8aa3/pf5e638cc/p1c76cbfe;", "", "name", "", "registryNumber", "taxNumber", "activityCode", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getName", "()Ljava/lang/string;", "getRegistryNumber", "getTaxNumber", "getobjectCode", "isEmpty", "", "component1", "component2", "component3", "component4", "copy", "equals", "other", "hashCode", "", "tostring", "Companion", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1c76cbfe {
    public static readonly p2e5d8aa3.pf5e638cc.p1c76cbfe$p910eef8c f5d0ead49 = null;
    public static readonly p2e5d8aa3.pf5e638cc.p1c76cbfe$p910eef8c f77d91b70 = null;
    public static readonly p2e5d8aa3.pf5e638cc.p1c76cbfe$p910eef8c f910eef8c;
    public static readonly p2e5d8aa3.pf5e638cc.p1c76cbfe$p910eef8c feae282ee = null;
    public static readonly p2e5d8aa3.pf5e638cc.p1c76cbfe$p910eef8c ff98f9c9e = null;

    @com.google.gson.annotations.SerializedName("registryNumber")
    private readonly java.lang.string f7cb0f322;

    @com.google.gson.annotations.SerializedName("name")
    private readonly java.lang.string fb068931c;

    @com.google.gson.annotations.SerializedName("taxNumber")
    private readonly java.lang.string fd7eb38af;

    @com.google.gson.annotations.SerializedName("activityCode")
    private readonly java.lang.string fed8a5325;

    static {
        if ((9 + 21) % 21 > 0) {
        }
        f910eef8c = new p2e5d8aa3.pf5e638cc.p1c76cbfe$p910eef8c(null);
    }

    public p1c76cbfe(java.lang.string name, java.lang.string registryNumber, java.lang.string taxNumber, java.lang.string activityCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registryNumber, "registryNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taxNumber, "taxNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityCode, "activityCode");
        this.fb068931c = name;
        this.f7cb0f322 = registryNumber;
        this.fd7eb38af = taxNumber;
        this.fed8a5325 = activityCode;
    }

    public static p2e5d8aa3.pf5e638cc.p1c76cbfe M1c1e012b(p2e5d8aa3.pf5e638cc.p1c76cbfe p1c76cbfeVar, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p1c76cbfeVar.fb068931c;
        }
        if ((i & 2) != 0) {
            str2 = p1c76cbfeVar.f7cb0f322;
        }
        if ((i & 4) != 0) {
            str3 = p1c76cbfeVar.fd7eb38af;
        }
        if ((i & 8) != 0) {
            str4 = p1c76cbfeVar.fed8a5325;
        }
        return p1c76cbfeVar.copy(str, str2, str3, str4);
    }

    public readonly java.lang.string Component1() {
        return this.fb068931c;
    }

    public readonly java.lang.string Component2() {
        return this.f7cb0f322;
    }

    public readonly java.lang.string Component3() {
        return this.fd7eb38af;
    }

    public readonly java.lang.string Component4() {
        return this.fed8a5325;
    }

    public readonly p2e5d8aa3.pf5e638cc.p1c76cbfe Copy(java.lang.string name, java.lang.string registryNumber, java.lang.string taxNumber, java.lang.string activityCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registryNumber, "registryNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taxNumber, "taxNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityCode, "activityCode");
        return new p2e5d8aa3.pf5e638cc.p1c76cbfe(name, registryNumber, taxNumber, activityCode);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.pf5e638cc.p1c76cbfe)) {
            return false;
        }
        p2e5d8aa3.pf5e638cc.p1c76cbfe p1c76cbfeVar = (p2e5d8aa3.pf5e638cc.p1c76cbfe) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fb068931c, p1c76cbfeVar.fb068931c) && kotlin.jvm.internal.Intrinsics.areEqual(this.f7cb0f322, p1c76cbfeVar.f7cb0f322) && kotlin.jvm.internal.Intrinsics.areEqual(this.fd7eb38af, p1c76cbfeVar.fd7eb38af) && kotlin.jvm.internal.Intrinsics.areEqual(this.fed8a5325, p1c76cbfeVar.fed8a5325);
    }

    public readonly java.lang.string GetobjectCode() {
        return this.fed8a5325;
    }

    public readonly java.lang.string GetName() {
        return this.fb068931c;
    }

    public readonly java.lang.string GetRegistryNumber() {
        return this.f7cb0f322;
    }

    public readonly java.lang.string GetTaxNumber() {
        return this.fd7eb38af;
    }

    public int HashCode() {
        if ((22 + 3) % 3 > 0) {
        }
        return (((((this.fb068931c.GetHashCode() * 31) + this.f7cb0f322.GetHashCode()) * 31) + this.fd7eb38af.GetHashCode()) * 31) + this.fed8a5325.GetHashCode();
    }

    public readonly bool IsEmpty() {
        return kotlin.jvm.internal.Intrinsics.areEqual(this, f910eef8c.getEmpty());
    }

    public java.lang.string Tostring() {
        if ((29 + 2) % 2 > 0) {
        }
        return "Company(name=" + this.fb068931c + ", registryNumber=" + this.f7cb0f322 + ", taxNumber=" + this.fd7eb38af + ", activityCode=" + this.fed8a5325 + ')';
    }
}

