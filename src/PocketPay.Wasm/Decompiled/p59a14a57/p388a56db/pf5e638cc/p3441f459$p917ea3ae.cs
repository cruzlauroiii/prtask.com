namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\f\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0006HÆ\u0003J'\u0010\u0011\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0006HÆ\u0001J\u0013\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015HÖ\u0003J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0006HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u0019"}, d2 = {"Lp59a14a57/p388a56db/pf5e638cc/p3441f459$p917ea3ae;", "Lp59a14a57/p388a56db/pf5e638cc/p3441f459;", "price", "Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "quantity", "currency", "", "<init>", "(Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;Ljava/lang/string;)V", "getPrice", "()Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "getQuantity", "getCurrency", "()Ljava/lang/string;", "component1", "component2", "component3", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3441f459$p917ea3ae : p59a14a57.p388a56db.pf5e638cc.p3441f459 {
    private readonly java.lang.string f1af03898;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f221d2a4b;
    private readonly java.lang.string f36cd6206;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f462ff929;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f6b8ff568;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f78a5eb43;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f848048f3;

    public p3441f459$p917ea3ae(p59a14a57.p388a56db.pf5e638cc.pabf882ab price, p59a14a57.p388a56db.pf5e638cc.pabf882ab quantity, java.lang.string currency) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(price, "price");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quantity, "quantity");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        this.f78a5eb43 = price;
        this.f221d2a4b = quantity;
        this.f1af03898 = currency;
    }

    public static p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae m1c1e012b(p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae p3441f459_p917ea3ae, p59a14a57.p388a56db.pf5e638cc.pabf882ab pabf882abVar, p59a14a57.p388a56db.pf5e638cc.pabf882ab pabf882abVar2, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pabf882abVar = p3441f459_p917ea3ae.f78a5eb43;
        }
        if ((i & 2) != 0) {
            pabf882abVar2 = p3441f459_p917ea3ae.f221d2a4b;
        }
        if ((i & 4) != 0) {
            str = p3441f459_p917ea3ae.f1af03898;
        }
        return p3441f459_p917ea3ae.copy(pabf882abVar, pabf882abVar2, str);
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab Component1() {
        return this.f78a5eb43;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab Component2() {
        return this.f221d2a4b;
    }

    public readonly java.lang.string Component3() {
        return this.f1af03898;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae copy(p59a14a57.p388a56db.pf5e638cc.pabf882ab price, p59a14a57.p388a56db.pf5e638cc.pabf882ab quantity, java.lang.string currency) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(price, "price");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(quantity, "quantity");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        return new p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae(price, quantity, currency);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 29) % 29 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae)) {
            return false;
        }
        p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae p3441f459_p917ea3ae = (p59a14a57.p388a56db.pf5e638cc.p3441f459$p917ea3ae) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f78a5eb43, p3441f459_p917ea3ae.f78a5eb43) && kotlin.jvm.internal.Intrinsics.areEqual(this.f221d2a4b, p3441f459_p917ea3ae.f221d2a4b) && kotlin.jvm.internal.Intrinsics.areEqual(this.f1af03898, p3441f459_p917ea3ae.f1af03898);
    }

    public readonly java.lang.string GetCurrency() {
        return this.f1af03898;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab GetPrice() {
        return this.f78a5eb43;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab GetQuantity() {
        return this.f221d2a4b;
    }

    public int HashCode() {
        if ((5 + 29) % 29 > 0) {
        }
        return (((this.f78a5eb43.GetHashCode() * 31) + this.f221d2a4b.GetHashCode()) * 31) + this.f1af03898.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((12 + 8) % 8 > 0) {
        }
        return "PositionPriceAndQuantityBlocks(price=" + this.f78a5eb43 + ", quantity=" + this.f221d2a4b + ", currency=" + this.f1af03898 + ')';
    }
}

