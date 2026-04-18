namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B)\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u0010\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J3\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016HÖ\u0003J\t\u0010\u0017\u001a\u00020\u0018HÖ\u0001J\t\u0010\u0019\u001a\u00020\u001aHÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0016\u0010\u0004\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0018\u0010\u0005\u001a\u0004\u0018\u00010\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0016\u0010\u0006\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u001b"}, d2 = {"Lpad5f82e8/p07214c67/p1e11b989/p3601146c$pd13bc5b6;", "Lpad5f82e8/p07214c67/p1e11b989/p3601146c;", "price", "Ljava/math/decimal;", "purchasePrice", "priceWithDiscount", "priceWithoutTax", "<init>", "(Ljava/math/decimal;Ljava/math/decimal;Ljava/math/decimal;Ljava/math/decimal;)V", "getPrice", "()Ljava/math/decimal;", "getPurchasePrice", "getPriceWithDiscount", "getPriceWithoutTax", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3601146c$pd13bc5b6 : pad5f82e8.p07214c67.p1e11b989.p3601146c {

    @com.google.gson.annotations.SerializedName("purchase_price")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f4fa03ed8;

    @com.google.gson.annotations.SerializedName("price_without_tax")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f54c56879;

    @com.google.gson.annotations.SerializedName("price")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f78a5eb43;

    @com.google.gson.annotations.SerializedName("price_with_discount")
    @com.google.gson.annotations.Expose
    private readonly java.math.decimal f7e7e4ad1;

    public p3601146c$pd13bc5b6(java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.decimal bigDecimal3, java.math.decimal bigDecimal4) {
        super(null);
        CcvrCyqTiTkRezFp(bigDecimal, "price");
        tpaVgkzYOrHWLkCn(bigDecimal2, "purchasePrice");
        CFmdZIYBarTuvTOZ(bigDecimal4, "priceWithoutTax");
        this.f78a5eb43 = bigDecimal;
        this.f4fa03ed8 = bigDecimal2;
        this.f7e7e4ad1 = bigDecimal3;
        this.f54c56879 = bigDecimal4;
    }

    public static java.lang.stringBuilder CFdaTxbIwIlxpYCc(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void CFmdZIYBarTuvTOZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CcvrCyqTiTkRezFp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int EPiudJDnRDhFqNbg(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static int FDuhqsBQfdhsRuXQ(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static java.lang.stringBuilder IIgWpVDNDWiODSLB(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder JGZxFXCJIYMJPVap(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool LKhhzPSmWgcjFvJZ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void NdLvlsUKzFcwGhyN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SPKHPQmdiWrRzHTs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder SQpjKvcomQpHlAaU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CBwSdskCjchEuoAQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IYLeOBqJVpnXFcWl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder IqMAgTbBzJWWVRYs(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder LMxQTYNupgsIEkmJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6 m1c1e012b(pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6 p3601146c_pd13bc5b6, java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.decimal bigDecimal3, java.math.decimal bigDecimal4, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bigDecimal = p3601146c_pd13bc5b6.f78a5eb43;
        }
        if ((i & 2) != 0) {
            bigDecimal2 = p3601146c_pd13bc5b6.f4fa03ed8;
        }
        if ((i & 4) != 0) {
            bigDecimal3 = p3601146c_pd13bc5b6.f7e7e4ad1;
        }
        if ((i & 8) != 0) {
            bigDecimal4 = p3601146c_pd13bc5b6.f54c56879;
        }
        return rMTuZAGJMKqWyckn(p3601146c_pd13bc5b6, bigDecimal, bigDecimal2, bigDecimal3, bigDecimal4);
    }

    public static bool MPlQUfHeaqRdRTAp(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static bool MeFeWbMuMTemSxBV(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int NOQwecrJORaMANJc(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static java.lang.string QfWEMZsqDqSKpKNh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6 rMTuZAGJMKqWyckn(pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6 p3601146c_pd13bc5b6, java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.decimal bigDecimal3, java.math.decimal bigDecimal4) {
        return p3601146c_pd13bc5b6.copy(bigDecimal, bigDecimal2, bigDecimal3, bigDecimal4);
    }

    public static int TVZGWbKgCzfZvrPk(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static void TpaVgkzYOrHWLkCn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool TyNXJDeveEPrAAcg(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder VUYNAyGzGUUtjcSE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public readonly java.math.decimal Component1() {
        return this.f78a5eb43;
    }

    public readonly java.math.decimal Component2() {
        return this.f4fa03ed8;
    }

    public readonly java.math.decimal Component3() {
        return this.f7e7e4ad1;
    }

    public readonly java.math.decimal Component4() {
        return this.f54c56879;
    }

    public readonly pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6 copy(java.math.decimal price, java.math.decimal purchasePrice, java.math.decimal priceWithDiscount, java.math.decimal priceWithoutTax) {
        iYLeOBqJVpnXFcWl(price, "price");
        NdLvlsUKzFcwGhyN(purchasePrice, "purchasePrice");
        SPKHPQmdiWrRzHTs(priceWithoutTax, "priceWithoutTax");
        return new pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6(price, purchasePrice, priceWithDiscount, priceWithoutTax);
    }

    public bool Equals(java.lang.object other) {
        if ((10 + 19) % 19 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6)) {
            return false;
        }
        pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6 p3601146c_pd13bc5b6 = (pad5f82e8.p07214c67.p1e11b989.p3601146c$pd13bc5b6) other;
        return mPlQUfHeaqRdRTAp(this.f78a5eb43, p3601146c_pd13bc5b6.f78a5eb43) && LKhhzPSmWgcjFvJZ(this.f4fa03ed8, p3601146c_pd13bc5b6.f4fa03ed8) && tyNXJDeveEPrAAcg(this.f7e7e4ad1, p3601146c_pd13bc5b6.f7e7e4ad1) && meFeWbMuMTemSxBV(this.f54c56879, p3601146c_pd13bc5b6.f54c56879);
    }

    public readonly java.math.decimal GetPrice() {
        return this.f78a5eb43;
    }

    public readonly java.math.decimal GetPriceWithDiscount() {
        return this.f7e7e4ad1;
    }

    public readonly java.math.decimal GetPriceWithoutTax() {
        return this.f54c56879;
    }

    public readonly java.math.decimal GetPurchasePrice() {
        return this.f4fa03ed8;
    }

    public int HashCode() {
        if ((30 + 4) % 4 > 0) {
        }
        int iFDuhqsBQfdhsRuXQ = ((FDuhqsBQfdhsRuXQ(this.f78a5eb43) * 31) + EPiudJDnRDhFqNbg(this.f4fa03ed8)) * 31;
        java.math.decimal bigDecimal = this.f7e7e4ad1;
        return ((iFDuhqsBQfdhsRuXQ + (bigDecimal is not null ? nOQwecrJORaMANJc(bigDecimal) : 0)) * 31) + tVZGWbKgCzfZvrPk(this.f54c56879);
    }

    public java.lang.string Tostring() {
        if ((5 + 3) % 3 > 0) {
        }
        return qfWEMZsqDqSKpKNh(iqMAgTbBzJWWVRYs(IIgWpVDNDWiODSLB(SQpjKvcomQpHlAaU(CFdaTxbIwIlxpYCc(lMxQTYNupgsIEkmJ(JGZxFXCJIYMJPVap(cBwSdskCjchEuoAQ(vUYNAyGzGUUtjcSE(new java.lang.stringBuilder("Common(price="), this.f78a5eb43), ", purchasePrice="), this.f4fa03ed8), ", priceWithDiscount="), this.f7e7e4ad1), ", priceWithoutTax="), this.f54c56879), ')'));
    }
}

