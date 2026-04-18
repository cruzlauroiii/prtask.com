namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\r\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u001f\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0005HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0015"}, d2 = {"Lp4670093c/p07214c67/p068d0b80;", "", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "credentials", "", "<init>", "(Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;Ljava/lang/string;)V", "getReceipt", "()Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "getCredentials", "()Ljava/lang/string;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-payback-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p068d0b80 {
    private readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 f1e11b989;
    private readonly java.lang.string f3c212590;
    private readonly java.lang.string f417e9204;
    private readonly java.lang.string f4d6ec4fa;
    private readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 f87d769d2;
    private readonly java.lang.string fd3ed68f7;
    private readonly java.lang.string fd53e407a;

    public p068d0b80(pad5f82e8.p07214c67.p1e11b989.p18cf5223 receipt, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        this.f1e11b989 = receipt;
        this.fd3ed68f7 = str;
    }

    public static p4670093c.p07214c67.p068d0b80 M1c1e012b(p4670093c.p07214c67.p068d0b80 p068d0b80Var, pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p18cf5223Var = p068d0b80Var.f1e11b989;
        }
        if ((i & 2) != 0) {
            str = p068d0b80Var.fd3ed68f7;
        }
        return p068d0b80Var.copy(p18cf5223Var, str);
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 Component1() {
        return this.f1e11b989;
    }

    public readonly java.lang.string Component2() {
        return this.fd3ed68f7;
    }

    public readonly p4670093c.p07214c67.p068d0b80 Copy(pad5f82e8.p07214c67.p1e11b989.p18cf5223 receipt, java.lang.string credentials) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        return new p4670093c.p07214c67.p068d0b80(receipt, credentials);
    }

    public bool Equals(java.lang.object other) {
        if ((3 + 7) % 7 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p4670093c.p07214c67.p068d0b80)) {
            return false;
        }
        p4670093c.p07214c67.p068d0b80 p068d0b80Var = (p4670093c.p07214c67.p068d0b80) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f1e11b989, p068d0b80Var.f1e11b989) && kotlin.jvm.internal.Intrinsics.areEqual(this.fd3ed68f7, p068d0b80Var.fd3ed68f7);
    }

    public readonly java.lang.string GetCredentials() {
        return this.fd3ed68f7;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 GetReceipt() {
        return this.f1e11b989;
    }

    public int HashCode() {
        int iHashCode = this.f1e11b989.GetHashCode() * 31;
        java.lang.string str = this.fd3ed68f7;
        return iHashCode + (str is not null ? str.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((26 + 19) % 19 > 0) {
        }
        return "InitReceiptInfo(receipt=" + this.f1e11b989 + ", credentials=" + this.fd3ed68f7 + ')';
    }
}

