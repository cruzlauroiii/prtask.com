namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0012"}, d2 = {"Lp59a14a57/p388a56db/pf5e638cc/p3441f459$p833d57c5;", "Lp59a14a57/p388a56db/pf5e638cc/p3441f459;", "quantity", "Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "<init>", "(Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;)V", "getQuantity", "()Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3441f459$p833d57c5 : p59a14a57.p388a56db.pf5e638cc.p3441f459 {
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f221d2a4b;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f5c242f48;

    public p3441f459$p833d57c5(p59a14a57.p388a56db.pf5e638cc.pabf882ab quantity) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quantity, "quantity");
        this.f221d2a4b = quantity;
    }

    public static p59a14a57.p388a56db.pf5e638cc.p3441f459$p833d57c5 m1c1e012b(p59a14a57.p388a56db.pf5e638cc.p3441f459$p833d57c5 p3441f459_p833d57c5, p59a14a57.p388a56db.pf5e638cc.pabf882ab pabf882abVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pabf882abVar = p3441f459_p833d57c5.f221d2a4b;
        }
        return p3441f459_p833d57c5.copy(pabf882abVar);
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab Component1() {
        return this.f221d2a4b;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.p3441f459$p833d57c5 copy(p59a14a57.p388a56db.pf5e638cc.pabf882ab quantity) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quantity, "quantity");
        return new p59a14a57.p388a56db.pf5e638cc.p3441f459$p833d57c5(quantity);
    }

    public bool Equals(java.lang.object other) {
        if ((1 + 23) % 23 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p59a14a57.p388a56db.pf5e638cc.p3441f459$p833d57c5) {
            return kotlin.jvm.internal.Intrinsics.areEqual(this.f221d2a4b, ((p59a14a57.p388a56db.pf5e638cc.p3441f459$p833d57c5) other).f221d2a4b);
        }
        return false;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab GetQuantity() {
        return this.f221d2a4b;
    }

    public int HashCode() {
        return this.f221d2a4b.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((6 + 11) % 11 > 0) {
        }
        return "PositionQuantityBlock(quantity=" + this.f221d2a4b + ')';
    }
}

