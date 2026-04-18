namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\r\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0003HÆ\u0003J'\u0010\u0011\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0015\u001a\u00020\u0016HÖ\u0001J\t\u0010\u0017\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0006\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u0018"}, d2 = {"Lp83f5c3ad/p2486923a/p8325324b/pf83c2a85/p97fa68b7;", "", "title", "", "amount", "Ljava/math/decimal;", "address", "<init>", "(Ljava/lang/string;Ljava/math/decimal;Ljava/lang/string;)V", "getTitle", "()Ljava/lang/string;", "getAmount", "()Ljava/math/decimal;", "getAddress", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p97fa68b7 {
    private readonly java.lang.string f0a0b1d71;
    private readonly java.math.decimal f4c537836;
    private readonly java.math.decimal f535ac34f;
    private readonly java.lang.string f884d9804;
    private readonly java.lang.string f9c9f4c3e;
    private readonly java.math.decimal fcf8c5e56;
    private readonly java.lang.string fd5d3db17;
    private readonly java.lang.string fe1a1c5f7;
    private readonly java.lang.string fe4cce8d2;
    private readonly java.math.decimal fe9f40e1f;

    public p97fa68b7(java.lang.string title, java.math.decimal amount, java.lang.string address) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(title, "title");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(amount, "amount");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(address, "address");
        this.fd5d3db17 = title;
        this.fe9f40e1f = amount;
        this.f884d9804 = address;
    }

    public static p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7 M1c1e012b(p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7 p97fa68b7Var, java.lang.string str, java.math.decimal bigDecimal, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p97fa68b7Var.fd5d3db17;
        }
        if ((i & 2) != 0) {
            bigDecimal = p97fa68b7Var.fe9f40e1f;
        }
        if ((i & 4) != 0) {
            str2 = p97fa68b7Var.f884d9804;
        }
        return p97fa68b7Var.copy(str, bigDecimal, str2);
    }

    public readonly java.lang.string Component1() {
        return this.fd5d3db17;
    }

    public readonly java.math.decimal Component2() {
        return this.fe9f40e1f;
    }

    public readonly java.lang.string Component3() {
        return this.f884d9804;
    }

    public readonly p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7 Copy(java.lang.string title, java.math.decimal amount, java.lang.string address) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(title, "title");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(amount, "amount");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(address, "address");
        return new p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7(title, amount, address);
    }

    public bool Equals(java.lang.object other) {
        if ((24 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7)) {
            return false;
        }
        p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7 p97fa68b7Var = (p83f5c3ad.p2486923a.p8325324b.pf83c2a85.p97fa68b7) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.fd5d3db17, p97fa68b7Var.fd5d3db17) && kotlin.jvm.internal.Intrinsics.areEqual(this.fe9f40e1f, p97fa68b7Var.fe9f40e1f) && kotlin.jvm.internal.Intrinsics.areEqual(this.f884d9804, p97fa68b7Var.f884d9804);
    }

    public readonly java.lang.string GetAddress() {
        return this.f884d9804;
    }

    public readonly java.math.decimal GetAmount() {
        return this.fe9f40e1f;
    }

    public readonly java.lang.string GetTitle() {
        return this.fd5d3db17;
    }

    public int HashCode() {
        if ((22 + 10) % 10 > 0) {
        }
        return (((this.fd5d3db17.GetHashCode() * 31) + this.fe9f40e1f.GetHashCode()) * 31) + this.f884d9804.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((21 + 27) % 27 > 0) {
        }
        return "InitialData(title=" + this.fd5d3db17 + ", amount=" + this.fe9f40e1f + ", address=" + this.f884d9804 + ')';
    }
}

