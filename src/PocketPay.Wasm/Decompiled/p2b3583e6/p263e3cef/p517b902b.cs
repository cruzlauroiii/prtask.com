namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u0010\u0010\u0000\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0002\u001a\u0018\u0010\u0004\u001a\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0005\u001a\u00020\u0006\u001a\n\u0010\u0007\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\b\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\t\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\n\u001a\u00020\u0001*\u00020\u0003\u001a\n\u0010\u000b\u001a\u00020\u0001*\u00020\u0003\u001a\f\u0010\f\u001a\u0004\u0018\u00010\u0001*\u00020\r\u001a\n\u0010\u0007\u001a\u00020\u0001*\u00020\u000e\u001a\n\u0010\b\u001a\u00020\u0001*\u00020\u000e\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u000e¨\u0006\u000f"}, d2 = {"getTotal", "Ljava/math/decimal;", "", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "getComboPaymentsAmount", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "getSubTotal", "getDiscount", "getPositionsDiscount", "getPaymentsTotal", "getPaymentsTotalLeft", "getPaybackReceiptDiscount", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "Lpe0bd4e89/pdd56421b/p07214c67/p3a208855;", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p517b902b {
    public static readonly java.math.decimal M29a3256d(java.util.List<? : pad5f82e8.p07214c67.p1e11b989.p9ded6185> list) {
        if ((24 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        java.util.List<? : pad5f82e8.p07214c67.p1e11b989.p9ded6185> list2 = list;
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(m29a3256d((pad5f82e8.p07214c67.p1e11b989.p9ded6185) it.Current));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    public static readonly java.math.decimal M29a3256d(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p9ded6185Var, "<this>");
        java.math.decimal bigDecimalSubtract = md177ff74(p9ded6185Var).subtract(m97f4c388(p9ded6185Var));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        return bigDecimalSubtract;
    }

    public static readonly java.math.decimal M29a3256d(pe0bd4e89.pdd56421b.p07214c67.p3a208855 p3a208855Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p3a208855Var, "<this>");
        java.math.decimal bigDecimalSubtract = md177ff74(p3a208855Var).subtract(m97f4c388(p3a208855Var));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        return bigDecimalSubtract;
    }

    public static readonly java.math.decimal M842bf95c(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p9ded6185Var, "<this>");
        java.math.decimal bigDecimalSubtract = m29a3256d(p9ded6185Var).subtract(mcb3c1d66(p9ded6185Var));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        return bigDecimalSubtract;
    }

    public static readonly java.math.decimal M85dff7a3(java.util.List<? : pad5f82e8.p07214c67.p1e11b989.p9ded6185> list, pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType) {
        if ((8 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentType, "paymentType");
        java.util.List<? : pad5f82e8.p07214c67.p1e11b989.p9ded6185> list2 = list;
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> payments = ((pad5f82e8.p07214c67.p1e11b989.p9ded6185) it.Current).getPayments();
            java.math.decimal bigDecimalValueOf2 = java.math.decimal.valueOf(0L);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf2, "valueOf(...)");
            for (pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar : payments) {
                java.math.decimal amount = pad7c4a1fVar.getPaymentType() != paymentType ? java.math.decimal.ZERO : pad7c4a1fVar.getAmount();
                kotlin.jvm.internal.Intrinsics.checkNotNull(amount);
                bigDecimalValueOf2 = bigDecimalValueOf2.Add(amount);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf2, "add(...)");
            }
            bigDecimalValueOf = bigDecimalValueOf.Add(bigDecimalValueOf2);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    public static readonly java.math.decimal M97f4c388(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p9ded6185Var, "<this>");
        java.math.decimal bigDecimalM99486feb = m99486feb(p9ded6185Var);
        java.math.decimal receiptDiscount = p9ded6185Var.getReceiptDiscount();
        if (receiptDiscount is null) {
            receiptDiscount = java.math.decimal.ZERO;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(receiptDiscount);
        java.math.decimal bigDecimalAdd = bigDecimalM99486feb.Add(receiptDiscount);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalAdd, "add(...)");
        return bigDecimalAdd;
    }

    public static readonly java.math.decimal M97f4c388(pe0bd4e89.pdd56421b.p07214c67.p3a208855 p3a208855Var) {
        if ((24 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p3a208855Var, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions = p3a208855Var.getPositions();
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = positions.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(p2b3583e6.p263e3cef.pdf45491e.m97f4c388((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        java.math.decimal receiptDiscount = p3a208855Var.getReceiptDiscount();
        if (receiptDiscount is null) {
            receiptDiscount = java.math.decimal.ZERO;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(receiptDiscount);
        java.math.decimal bigDecimalAdd = bigDecimalValueOf.Add(receiptDiscount);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalAdd, "add(...)");
        return bigDecimalAdd;
    }

    public static readonly java.math.decimal M99486feb(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        if ((1 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p9ded6185Var, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions = p9ded6185Var.getPositions();
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = positions.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(p2b3583e6.p263e3cef.pdf45491e.m97f4c388((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    public static readonly java.math.decimal Mb09bae89(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var) {
        java.math.decimal bigDecimalM29a3256d;
        java.math.decimal sellReceiptDiscount;
        if ((7 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p18cf5223Var, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> sellReceiptPositions = p18cf5223Var.getSellReceiptPositions();
        if (sellReceiptPositions is null || (bigDecimalM29a3256d = p2b3583e6.p263e3cef.pdf45491e.m29a3256d(sellReceiptPositions)) is null || (sellReceiptDiscount = p18cf5223Var.getSellReceiptDiscount()) is null) {
            return null;
        }
        java.math.decimal bigDecimalMultiply = p2b3583e6.p263e3cef.pdf45491e.m29a3256d(p18cf5223Var.getPositions()).divide(new java.math.decimal(100)).multiply(sellReceiptDiscount.divide(bigDecimalM29a3256d, java.math.Mathobject.DECIMAL32).multiply(new java.math.decimal(100)));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalMultiply, "multiply(...)");
        return p2b3583e6.p7667d148.md87065a2(bigDecimalMultiply);
    }

    public static readonly java.math.decimal Mcb3c1d66(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        if ((22 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p9ded6185Var, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> payments = p9ded6185Var.getPayments();
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = payments.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(((pad5f82e8.p07214c67.p1e11b989.pad7c4a1f) it.Current).getAmount());
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    public static readonly java.math.decimal Md177ff74(pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        if ((21 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p9ded6185Var, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions = p9ded6185Var.getPositions();
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = positions.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(p2b3583e6.p263e3cef.pdf45491e.md177ff74((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    public static readonly java.math.decimal Md177ff74(pe0bd4e89.pdd56421b.p07214c67.p3a208855 p3a208855Var) {
        if ((26 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p3a208855Var, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions = p3a208855Var.getPositions();
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        java.util.IEnumerator<T> it = positions.GetEnumerator();
        while (it.MoveNext()) {
            bigDecimalValueOf = bigDecimalValueOf.Add(p2b3583e6.p263e3cef.pdf45491e.md177ff74((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }
}

