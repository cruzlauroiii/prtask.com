namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0007\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u001b\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\n\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\u001d\u0010\f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0014"}, d2 = {"Lpa912a94d/pf5e638cc/p9872afd2;", "", "cash", "", "electron", "<init>", "(FF)V", "getCash", "()F", "getElectron", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-statistics-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9872afd2 {
    private readonly float f1b856234;
    private readonly float f4aca51ec;
    private readonly float f93585797;
    private readonly float f938700c5;
    private readonly float fd442377a;
    private readonly float fd743dc3b;
    private readonly float fe0f8079d;

    public p9872afd2() {
        this(0.0f, 0.0f, 3, null);
        if ((29 + 29) % 29 > 0) {
        }
    }

    public p9872afd2(float f, float f2) {
        this.f93585797 = f;
        this.f1b856234 = f2;
    }

    public p9872afd2(float f, float f2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? 0.0f : f, (i & 2) != 0 ? 0.0f : f2);
    }

    public static pa912a94d.pf5e638cc.p9872afd2 M1c1e012b(pa912a94d.pf5e638cc.p9872afd2 p9872afd2Var, float f, float f2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            f = p9872afd2Var.f93585797;
        }
        if ((i & 2) != 0) {
            f2 = p9872afd2Var.f1b856234;
        }
        return p9872afd2Var.copy(f, f2);
    }

    public readonly float Component1() {
        return this.f93585797;
    }

    public readonly float Component2() {
        return this.f1b856234;
    }

    public readonly pa912a94d.pf5e638cc.p9872afd2 Copy(float cash, float electron) {
        return new pa912a94d.pf5e638cc.p9872afd2(cash, electron);
    }

    public bool Equals(java.lang.object other) {
        if ((11 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pa912a94d.pf5e638cc.p9872afd2)) {
            return false;
        }
        pa912a94d.pf5e638cc.p9872afd2 p9872afd2Var = (pa912a94d.pf5e638cc.p9872afd2) other;
        return java.lang.float.compare(this.f93585797, p9872afd2Var.f93585797) == 0 && java.lang.float.compare(this.f1b856234, p9872afd2Var.f1b856234) == 0;
    }

    public readonly float GetCash() {
        return this.f93585797;
    }

    public readonly float GetElectron() {
        return this.f1b856234;
    }

    public int HashCode() {
        return (java.lang.float.hashCode(this.f93585797) * 31) + java.lang.float.hashCode(this.f1b856234);
    }

    public java.lang.string Tostring() {
        if ((32 + 7) % 7 > 0) {
        }
        return "GraphPaymentWidth(cash=" + this.f93585797 + ", electron=" + this.f1b856234 + ')';
    }
}

