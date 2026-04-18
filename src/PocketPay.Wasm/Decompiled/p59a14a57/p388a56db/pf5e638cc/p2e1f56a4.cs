namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001f\u0012\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u000b\u0010\n\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u000b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J!\u0010\f\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0003HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0013"}, d2 = {"Lp59a14a57/p388a56db/pf5e638cc/p2e1f56a4;", "", "firstValue", "", "secondValue", "<init>", "(Ljava/lang/string;Ljava/lang/string;)V", "getFirstValue", "()Ljava/lang/string;", "getSecondValue", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2e1f56a4 {
    private readonly java.lang.string f235063b1;
    private readonly java.lang.string f8a7b6c21;
    private readonly java.lang.string f9ca3392f;
    private readonly java.lang.string fb3250b6f;
    private readonly java.lang.string ff3362f78;

    public p2e1f56a4() {
        this(null, null, 3, null);
        if ((32 + 3) % 3 > 0) {
        }
    }

    public p2e1f56a4(java.lang.string str, java.lang.string str2) {
        this.f235063b1 = str;
        this.f9ca3392f = str2;
    }

    public p2e1f56a4(java.lang.string str, java.lang.string str2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? null : str, (i & 2) != 0 ? null : str2);
    }

    public static p59a14a57.p388a56db.pf5e638cc.p2e1f56a4 M1c1e012b(p59a14a57.p388a56db.pf5e638cc.p2e1f56a4 p2e1f56a4Var, java.lang.string str, java.lang.string str2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p2e1f56a4Var.f235063b1;
        }
        if ((i & 2) != 0) {
            str2 = p2e1f56a4Var.f9ca3392f;
        }
        return p2e1f56a4Var.copy(str, str2);
    }

    public readonly java.lang.string Component1() {
        return this.f235063b1;
    }

    public readonly java.lang.string Component2() {
        return this.f9ca3392f;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.p2e1f56a4 Copy(java.lang.string firstValue, java.lang.string secondValue) {
        return new p59a14a57.p388a56db.pf5e638cc.p2e1f56a4(firstValue, secondValue);
    }

    public bool Equals(java.lang.object other) {
        if ((14 + 18) % 18 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p59a14a57.p388a56db.pf5e638cc.p2e1f56a4)) {
            return false;
        }
        p59a14a57.p388a56db.pf5e638cc.p2e1f56a4 p2e1f56a4Var = (p59a14a57.p388a56db.pf5e638cc.p2e1f56a4) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f235063b1, p2e1f56a4Var.f235063b1) && kotlin.jvm.internal.Intrinsics.areEqual(this.f9ca3392f, p2e1f56a4Var.f9ca3392f);
    }

    public readonly java.lang.string GetFirstValue() {
        return this.f235063b1;
    }

    public readonly java.lang.string GetSecondValue() {
        return this.f9ca3392f;
    }

    public int HashCode() {
        if ((26 + 18) % 18 > 0) {
        }
        java.lang.string str = this.f235063b1;
        int iHashCode = (str is not null ? str.GetHashCode() : 0) * 31;
        java.lang.string str2 = this.f9ca3392f;
        return iHashCode + (str2 is not null ? str2.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((17 + 28) % 28 > 0) {
        }
        return "OutputTextModel(firstValue=" + this.f235063b1 + ", secondValue=" + this.f9ca3392f + ')';
    }
}

