namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u001b\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\n\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u000b\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u001f\u0010\f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0014"}, d2 = {"Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "", "value", "Ljava/math/decimal;", "maxValue", "<init>", "(Ljava/math/decimal;Ljava/math/decimal;)V", "getValue", "()Ljava/math/decimal;", "getMaxValue", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pabf882ab {
    private readonly java.math.decimal f2063c160;
    private readonly java.math.decimal f27903896;
    private readonly java.math.decimal f2e3adfb3;
    private readonly java.math.decimal f328f852a;
    private readonly java.math.decimal f7d119f48;
    private readonly java.math.decimal fa31d835f;
    private readonly java.math.decimal fe728b2d7;
    private readonly java.math.decimal fe7caf0e0;
    private readonly java.math.decimal fefabfe8a;

    public pabf882ab(java.math.decimal value, java.math.decimal bigDecimal) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        this.f2063c160 = value;
        this.fe728b2d7 = bigDecimal;
    }

    public pabf882ab(java.math.decimal bigDecimal, java.math.decimal bigDecimal2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(bigDecimal, (i & 2) != 0 ? null : bigDecimal2);
    }

    public static p59a14a57.p388a56db.pf5e638cc.pabf882ab M1c1e012b(p59a14a57.p388a56db.pf5e638cc.pabf882ab pabf882abVar, java.math.decimal bigDecimal, java.math.decimal bigDecimal2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bigDecimal = pabf882abVar.f2063c160;
        }
        if ((i & 2) != 0) {
            bigDecimal2 = pabf882abVar.fe728b2d7;
        }
        return pabf882abVar.copy(bigDecimal, bigDecimal2);
    }

    public readonly java.math.decimal Component1() {
        return this.f2063c160;
    }

    public readonly java.math.decimal Component2() {
        return this.fe728b2d7;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab Copy(java.math.decimal value, java.math.decimal maxValue) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return new p59a14a57.p388a56db.pf5e638cc.pabf882ab(value, maxValue);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 30) % 30 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p59a14a57.p388a56db.pf5e638cc.pabf882ab)) {
            return false;
        }
        p59a14a57.p388a56db.pf5e638cc.pabf882ab pabf882abVar = (p59a14a57.p388a56db.pf5e638cc.pabf882ab) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f2063c160, pabf882abVar.f2063c160) && kotlin.jvm.internal.Intrinsics.areEqual(this.fe728b2d7, pabf882abVar.fe728b2d7);
    }

    public readonly java.math.decimal GetMaxValue() {
        return this.fe728b2d7;
    }

    public readonly java.math.decimal GetValue() {
        return this.f2063c160;
    }

    public int HashCode() {
        int iHashCode = this.f2063c160.GetHashCode() * 31;
        java.math.decimal bigDecimal = this.fe728b2d7;
        return iHashCode + (bigDecimal is not null ? bigDecimal.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((31 + 15) % 15 > 0) {
        }
        return "DisplayBlock(value=" + this.f2063c160 + ", maxValue=" + this.fe728b2d7 + ')';
    }
}

