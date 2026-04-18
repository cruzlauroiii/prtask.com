namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\n\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0012HÖ\u0003J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0005HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lp59a14a57/p388a56db/pf5e638cc/p3441f459$p61defded;", "Lp59a14a57/p388a56db/pf5e638cc/p3441f459;", "price", "Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "currency", "", "<init>", "(Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;Ljava/lang/string;)V", "getPrice", "()Lp59a14a57/p388a56db/pf5e638cc/pabf882ab;", "getCurrency", "()Ljava/lang/string;", "component1", "component2", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3441f459$p61defded : p59a14a57.p388a56db.pf5e638cc.p3441f459 {
    private readonly java.lang.string f1af03898;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f25e04a51;
    private readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab f78a5eb43;
    private readonly java.lang.string f996fa9e8;
    private readonly java.lang.string fa52ebdba;
    private readonly java.lang.string fc2a06c49;
    private readonly java.lang.string ff3f7b825;

    public p3441f459$p61defded(p59a14a57.p388a56db.pf5e638cc.pabf882ab price, java.lang.string currency) {
        super(null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(price, "price");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        this.f78a5eb43 = price;
        this.f1af03898 = currency;
    }

    public static p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded m1c1e012b(p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded p3441f459_p61defded, p59a14a57.p388a56db.pf5e638cc.pabf882ab pabf882abVar, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pabf882abVar = p3441f459_p61defded.f78a5eb43;
        }
        if ((i & 2) != 0) {
            str = p3441f459_p61defded.f1af03898;
        }
        return p3441f459_p61defded.copy(pabf882abVar, str);
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab Component1() {
        return this.f78a5eb43;
    }

    public readonly java.lang.string Component2() {
        return this.f1af03898;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded copy(p59a14a57.p388a56db.pf5e638cc.pabf882ab price, java.lang.string currency) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(price, "price");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        return new p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded(price, currency);
    }

    public bool Equals(java.lang.object other) {
        if ((1 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded)) {
            return false;
        }
        p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded p3441f459_p61defded = (p59a14a57.p388a56db.pf5e638cc.p3441f459$p61defded) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f78a5eb43, p3441f459_p61defded.f78a5eb43) && kotlin.jvm.internal.Intrinsics.areEqual(this.f1af03898, p3441f459_p61defded.f1af03898);
    }

    public readonly java.lang.string GetCurrency() {
        return this.f1af03898;
    }

    public readonly p59a14a57.p388a56db.pf5e638cc.pabf882ab GetPrice() {
        return this.f78a5eb43;
    }

    public int HashCode() {
        return (this.f78a5eb43.GetHashCode() * 31) + this.f1af03898.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((3 + 22) % 22 > 0) {
        }
        return "PositionPriceBlock(price=" + this.f78a5eb43 + ", currency=" + this.f1af03898 + ')';
    }
}

