namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B/\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J1\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0011\u0010\u0006\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u0019"}, d2 = {"Lp2e5d8aa3/p07214c67/p7d5c009e/p93c731f1/p8545366a;", "", "name", "", "registryNumber", "taxNumber", "activityCode", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getName", "()Ljava/lang/string;", "getRegistryNumber", "getTaxNumber", "getobjectCode", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8545366a {
    private readonly java.lang.string f3412e20a;
    private readonly java.lang.string f3fbef280;
    private readonly java.lang.string f6a2aef0a;
    private readonly java.lang.string f6acd945d;
    private readonly java.lang.string f6f206843;
    private readonly java.lang.string f7954a052;
    private readonly java.lang.string f7cb0f322;
    private readonly java.lang.string f94eccf58;
    private readonly java.lang.string fa02d229a;
    private readonly java.lang.string fb068931c;
    private readonly java.lang.string fcad281a8;
    private readonly java.lang.string fcded56d2;
    private readonly java.lang.string fd7eb38af;
    private readonly java.lang.string fed8a5325;
    private readonly java.lang.string feeab009c;
    private readonly java.lang.string ff28773dd;

    public p8545366a() {
        this(null, null, null, null, 15, null);
        if ((12 + 10) % 10 > 0) {
        }
    }

    public p8545366a(java.lang.string name, java.lang.string registryNumber, java.lang.string taxNumber, java.lang.string activityCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registryNumber, "registryNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taxNumber, "taxNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityCode, "activityCode");
        this.fb068931c = name;
        this.f7cb0f322 = registryNumber;
        this.fd7eb38af = taxNumber;
        this.fed8a5325 = activityCode;
    }

    public p8545366a(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? "" : str, (i & 2) != 0 ? "" : str2, (i & 4) != 0 ? "" : str3, (i & 8) != 0 ? "" : str4);
    }

    public static p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a M1c1e012b(p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a p8545366aVar, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p8545366aVar.fb068931c;
        }
        if ((i & 2) != 0) {
            str2 = p8545366aVar.f7cb0f322;
        }
        if ((i & 4) != 0) {
            str3 = p8545366aVar.fd7eb38af;
        }
        if ((i & 8) != 0) {
            str4 = p8545366aVar.fed8a5325;
        }
        return p8545366aVar.copy(str, str2, str3, str4);
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

    public readonly p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a Copy(java.lang.string name, java.lang.string registryNumber, java.lang.string taxNumber, java.lang.string activityCode) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registryNumber, "registryNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(taxNumber, "taxNumber");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityCode, "activityCode");
        return new p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a(name, registryNumber, taxNumber, activityCode);
    }

    public bool Equals(java.lang.object other) {
        if ((23 + 15) % 15 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a)) {
            return false;
        }
        p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a p8545366aVar = (p2e5d8aa3.p07214c67.p7d5c009e.p93c731f1.p8545366a) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fb068931c, p8545366aVar.fb068931c) && kotlin.jvm.internal.Intrinsics.areEqual(this.f7cb0f322, p8545366aVar.f7cb0f322) && kotlin.jvm.internal.Intrinsics.areEqual(this.fd7eb38af, p8545366aVar.fd7eb38af) && kotlin.jvm.internal.Intrinsics.areEqual(this.fed8a5325, p8545366aVar.fed8a5325);
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
        if ((21 + 1) % 1 > 0) {
        }
        return (((((this.fb068931c.GetHashCode() * 31) + this.f7cb0f322.GetHashCode()) * 31) + this.fd7eb38af.GetHashCode()) * 31) + this.fed8a5325.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((15 + 12) % 12 > 0) {
        }
        return "CompanyDetailsUiState(name=" + this.fb068931c + ", registryNumber=" + this.f7cb0f322 + ", taxNumber=" + this.fd7eb38af + ", activityCode=" + this.fed8a5325 + ')';
    }
}

