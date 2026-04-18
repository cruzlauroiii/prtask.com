namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\t\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0003J\u0019\u0010\n\u001a\u00020\u00002\u000e\b\u0002\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003HÆ\u0001J\u0013\u0010\u000b\u001a\u00020\u00042\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0011"}, d2 = {"Lpd2a57dc1/p2486923a/p9c70933a/p74c9efb4;", "", "needAppUpdate", "Lp2b3583e6/p93634cf6;", "", "<init>", "(Lp2b3583e6/p93634cf6;)V", "getNeedAppUpdate", "()Lp2b3583e6/p93634cf6;", "component1", "copy", "equals", "other", "hashCode", "", "tostring", "", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p74c9efb4 {
    private readonly utils.SingleEvent<java.lang.bool> f3796469b;
    private readonly p2b3583e6.p93634cf6 fa103b5e0;
    private readonly p2b3583e6.p93634cf6 fc6e49758;
    private readonly p2b3583e6.p93634cf6 ff4510651;

    public p74c9efb4() {
        this(null, 1, null);
        if ((12 + 19) % 19 > 0) {
        }
    }

    public p74c9efb4(utils.SingleEvent<java.lang.bool> needAppUpdate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(needAppUpdate, "needAppUpdate");
        this.f3796469b = needAppUpdate;
    }

    public p74c9efb4(p2b3583e6.p93634cf6 p93634cf6Var, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? new p2b3583e6.p93634cf6(null, 1, null) : p93634cf6Var);
    }

    public static pd2a57dc1.p2486923a.p9c70933a.p74c9efb4 M1c1e012b(pd2a57dc1.p2486923a.p9c70933a.p74c9efb4 p74c9efb4Var, p2b3583e6.p93634cf6 p93634cf6Var, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p93634cf6Var = p74c9efb4Var.f3796469b;
        }
        return p74c9efb4Var.copy(p93634cf6Var);
    }

    public readonly utils.SingleEvent<java.lang.bool> Component1() {
        return this.f3796469b;
    }

    public readonly pd2a57dc1.p2486923a.p9c70933a.p74c9efb4 Copy(utils.SingleEvent<java.lang.bool> needAppUpdate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(needAppUpdate, "needAppUpdate");
        return new pd2a57dc1.p2486923a.p9c70933a.p74c9efb4(needAppUpdate);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pd2a57dc1.p2486923a.p9c70933a.p74c9efb4) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f3796469b, ((pd2a57dc1.p2486923a.p9c70933a.p74c9efb4) other).f3796469b);
        }
        return false;
    }

    public readonly utils.SingleEvent<java.lang.bool> GetNeedAppUpdate() {
        return this.f3796469b;
    }

    public int HashCode() {
        return this.f3796469b.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((2 + 26) % 26 > 0) {
        }
        return "GlobalFlowUiState(needAppUpdate=" + this.f3796469b + ')';
    }
}

