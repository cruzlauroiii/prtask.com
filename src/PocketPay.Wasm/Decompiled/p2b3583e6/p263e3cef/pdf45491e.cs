namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\b\u001a\u0010\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002\u001a\n\u0010\u0004\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\u0005\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\u0006\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\u0007\u001a\u00020\u0001*\u00020\u0003\u001a\u0018\u0010\b\u001a\u00020\u00012\b\u0010\t\u001a\u0004\u0018\u00010\u00012\u0006\u0010\n\u001a\u00020\u0001¨\u0006\u000b"}, d2 = {"getTotal", "Ljava/math/decimal;", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "getSubTotal", "getDiscount", "getPurchaseSubTotal", "getPurchaseTotal", "getPriceWithoutTax", "ratePercent", "price", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pdf45491e {
    public static readonly java.math.decimal M0800ecb4(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        java.math.decimal bigDecimalMultiply = pd031d465Var.getPurchasePrice().multiply(pd031d465Var.getQuantity());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalMultiply, "multiply(...)");
        return p2b3583e6.p7667d148.md87065a2(bigDecimalMultiply);
    }

    public static readonly java.math.decimal M29a3256d(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list) {
        if ((31 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list2 = list;
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(m29a3256d((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    public static readonly java.math.decimal M29a3256d(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        java.math.decimal bigDecimalSubtract = md177ff74(pd031d465Var).subtract(m97f4c388(pd031d465Var));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        return bigDecimalSubtract;
    }

    public static readonly java.math.decimal M63dfbd1d(java.math.decimal bigDecimal, java.math.decimal price) {
        if ((18 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(price, "price");
        java.math.decimal bigDecimal2 = new java.math.decimal(100);
        java.math.decimal bigDecimal3 = bigDecimal is not null ? bigDecimal : java.math.decimal.ZERO;
        kotlin.jvm.internal.Intrinsics.checkNotNull(bigDecimal3);
        java.math.decimal bigDecimalAdd = bigDecimal2.Add(bigDecimal3);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalAdd, "add(...)");
        java.math.decimal bigDecimalDivide = price.divide(bigDecimalAdd, 4, java.math.RoundingMode.FLOOR);
        if (bigDecimal is null) {
            bigDecimal = java.math.decimal.ZERO;
        }
        java.math.decimal bigDecimalMultiply = bigDecimalDivide.multiply(bigDecimal);
        kotlin.jvm.internal.Intrinsics.checkNotNull(bigDecimalMultiply);
        java.math.decimal bigDecimalSubtract = price.subtract(bigDecimalMultiply);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        return p2b3583e6.p7667d148.md87065a2(bigDecimalSubtract);
    }

    public static readonly java.math.decimal M97f4c388(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        if ((24 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        java.math.decimal price = pd031d465Var.getPrice();
        java.math.decimal priceWithDiscount = pd031d465Var.getPriceWithDiscount();
        if (priceWithDiscount is null) {
            priceWithDiscount = pd031d465Var.getPrice();
        }
        java.math.decimal bigDecimalSubtract = price.subtract(priceWithDiscount);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        java.math.decimal bigDecimalMultiply = bigDecimalSubtract.multiply(pd031d465Var.getQuantity());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalMultiply, "multiply(...)");
        return p2b3583e6.p7667d148.md87065a2(bigDecimalMultiply);
    }

    public static readonly java.math.decimal Mcab87631(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        java.math.decimal bigDecimalSubtract = m0800ecb4(pd031d465Var).subtract(m97f4c388(pd031d465Var));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        return bigDecimalSubtract;
    }

    public static readonly java.math.decimal Md177ff74(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        java.math.decimal bigDecimalMultiply = pd031d465Var.getPrice().multiply(pd031d465Var.getQuantity());
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalMultiply, "multiply(...)");
        return p2b3583e6.p7667d148.md87065a2(bigDecimalMultiply);
    }
}

