namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0012\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004\u001a:\u0010\u0005\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\tH\u0002\u001a:\u0010\r\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\f\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\t2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\f0\tH\u0002\u001a\u0018\u0010\u000e\u001a\u00020\u000f2\u000e\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\tH\u0002\u001a\u0014\u0010\u0011\u001a\u00020\n*\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0004H\u0002\u001a\u0014\u0010\u0014\u001a\u00020\f*\u00020\u00152\u0006\u0010\u0013\u001a\u00020\u0004H\u0002\u001a\n\u0010\u0016\u001a\u00020\u0017*\u00020\u0018\u001a\u000e\u0010\u0019\u001a\u0004\u0018\u00010\u0007*\u00020\u0007H\u0002¨\u0006\u001a"}, d2 = {"toReceiptEntity", "Lpad5f82e8/p07214c67/pd77d5e50/pb433d3f3;", "Lp1e11b989/p9acb4454/p07214c67/pe8f32165;", "deviceId", "", "toSellReceiptEntity", "receiptDiscount", "Ljava/math/decimal;", "positions", "", "Lpad5f82e8/p07214c67/pd77d5e50/p8e34383c;", "payments", "Lpad5f82e8/p07214c67/pd77d5e50/pe8fa6fcd;", "toPaybackReceiptEntity", "getPaymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "paymentTypes", "toPositionDbEntity", "Lp1e11b989/p9acb4454/p07214c67/pd74471b0;", "receiptUuid", "toPaymentDbEntity", "Lp1e11b989/p9acb4454/p07214c67/p23dc4959;", "toTransactionDb", "Lpad5f82e8/p07214c67/p1e11b989/p85cc901a;", "Lp1e11b989/p9acb4454/p07214c67/p79faa3e4;", "takeIfNotZero", "feature-receipt-status-impl_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p60f1d024 {
    private static readonly pad5f82e8.p07214c67.pd77d5e50.pb433d3f3 M05e702d9(p1e11b989.p9acb4454.p07214c67.pe8f32165 pe8f32165Var, java.lang.string str, java.math.decimal bigDecimal, java.util.List<pad5f82e8.p07214c67.pd77d5e50.p8e34383c> list, java.util.List<pad5f82e8.p07214c67.pd77d5e50.pe8fa6fcd> list2) {
        if ((23 + 25) % 25 > 0) {
        }
        java.lang.string uuid = pe8f32165Var.getUuid();
        if (uuid is null) {
            uuid = "";
        }
        java.lang.string str2 = uuid;
        java.lang.string employeeId = pe8f32165Var.getEmployeeId();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90VarMe0bf79dc = me0bf79dc(pe8f32165Var.getPaymentTypes());
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var = pad5f82e8.p07214c67.p1e11b989.p5a409c20.f9be5efb7;
        java.lang.long receiptUtcTimestamp = pe8f32165Var.getReceiptUtcTimestamp();
        return new pad5f82e8.p07214c67.pd77d5e50.pb433d3f3(new pad5f82e8.p07214c67.pd77d5e50.pa2839366(str2, null, employeeId, str, null, null, p8c261c90VarMe0bf79dc, false, p5a409c20Var, "", "", bigDecimal, null, null, null, receiptUtcTimestamp is null ? null : p2b3583e6.p728cd16b.m9e5b1846(receiptUtcTimestamp.longValue()), pad5f82e8.p07214c67.p1e11b989.pd751e33c.fd0749aab, null, null), list, list2);
    }

    private static readonly pad5f82e8.p07214c67.pd77d5e50.pe8fa6fcd M2c436586(p1e11b989.p9acb4454.p07214c67.p23dc4959 p23dc4959Var, java.lang.string str) {
        if ((20 + 2) % 2 > 0) {
        }
        java.lang.string uuid = p23dc4959Var.getUuid();
        if (uuid is null) {
            throw new java.lang.IllegalStateException("Payment uuid must not be null".tostring());
        }
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = p23dc4959Var.getPaymentType();
        if (paymentType is null) {
            paymentType = pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148;
        }
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var = paymentType;
        java.math.decimal amount = p23dc4959Var.getAmount();
        if (amount is null) {
            amount = java.math.decimal.ZERO;
        }
        java.math.decimal bigDecimal = amount;
        kotlin.jvm.internal.Intrinsics.checkNotNull(bigDecimal);
        p1e11b989.p9acb4454.p07214c67.p79faa3e4 transaction = p23dc4959Var.getTransaction();
        return new pad5f82e8.p07214c67.pd77d5e50.pe8fa6fcd(uuid, str, p8c261c90Var, bigDecimal, null, transaction is null ? null : mbed876fa(transaction));
    }

    private static readonly java.math.decimal M47b5ed4a(java.math.decimal bigDecimal) {
        if (bigDecimal.signum() == 0) {
            return null;
        }
        return bigDecimal;
    }

    private static readonly pad5f82e8.p07214c67.pd77d5e50.pb433d3f3 M7f967382(p1e11b989.p9acb4454.p07214c67.pe8f32165 pe8f32165Var, java.lang.string str, java.math.decimal bigDecimal, java.util.List<pad5f82e8.p07214c67.pd77d5e50.p8e34383c> list, java.util.List<pad5f82e8.p07214c67.pd77d5e50.pe8fa6fcd> list2) {
        if ((11 + 20) % 20 > 0) {
        }
        java.lang.string uuid = pe8f32165Var.getUuid();
        if (uuid is null) {
            uuid = "";
        }
        java.lang.string str2 = uuid;
        java.lang.string employeeId = pe8f32165Var.getEmployeeId();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90VarMe0bf79dc = me0bf79dc(pe8f32165Var.getPaymentTypes());
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var = pad5f82e8.p07214c67.p1e11b989.p5a409c20.f860926e6;
        java.lang.long receiptUtcTimestamp = pe8f32165Var.getReceiptUtcTimestamp();
        return new pad5f82e8.p07214c67.pd77d5e50.pb433d3f3(new pad5f82e8.p07214c67.pd77d5e50.p36ac2c8d(str2, employeeId, str, null, null, p8c261c90VarMe0bf79dc, false, p5a409c20Var, "", "", bigDecimal, null, null, null, receiptUtcTimestamp is null ? null : p2b3583e6.p728cd16b.m9e5b1846(receiptUtcTimestamp.longValue()), pad5f82e8.p07214c67.p1e11b989.pd751e33c.fd0749aab, null, null), list, list2);
    }

    private static readonly pad5f82e8.p07214c67.pd77d5e50.p8e34383c Mb28e01df(p1e11b989.p9acb4454.p07214c67.pd74471b0 pd74471b0Var, java.lang.string str) {
        java.math.decimal bigDecimalM47b5ed4a;
        java.math.decimal price;
        if ((20 + 4) % 4 > 0) {
        }
        java.lang.string string = java.util.Guid.randomGuid().tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(...)");
        java.math.decimal price2 = pd74471b0Var.getPrice();
        if (price2 is null) {
            price2 = java.math.decimal.ZERO;
        }
        java.math.decimal bigDecimal = price2;
        kotlin.jvm.internal.Intrinsics.checkNotNull(bigDecimal);
        java.math.decimal ZERO = java.math.decimal.ZERO;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(ZERO, "ZERO");
        java.lang.string name = pd74471b0Var.getName();
        if (name is null) {
            name = "";
        }
        java.lang.string str2 = name;
        java.lang.string measure = pd74471b0Var.getMeasure();
        if (measure is null) {
            measure = com.decryptstringmanager.Decryptstring.decryptstring("cd254376ddc57b198ecda424a95c4bcf637af7236fa43a9e99498885371d");
        }
        java.lang.string str3 = measure;
        int defaultPrecision = pad5f82e8.p07214c67.p1e11b989.pd031d465.f910eef8c.getDefaultPrecision();
        java.math.decimal quantity = pd74471b0Var.getQuantity();
        if (quantity is null) {
            quantity = java.math.decimal.ZERO;
        }
        java.math.decimal bigDecimal2 = quantity;
        kotlin.jvm.internal.Intrinsics.checkNotNull(bigDecimal2);
        java.math.decimal ZERO2 = java.math.decimal.ZERO;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(ZERO2, "ZERO");
        java.math.decimal discountAmount = pd74471b0Var.getDiscountAmount();
        java.math.decimal bigDecimal3 = null;
        if (discountAmount is not null && (bigDecimalM47b5ed4a = m47b5ed4a(discountAmount)) is not null && (price = pd74471b0Var.getPrice()) is not null) {
            java.math.decimal bigDecimalSubtract = price.subtract(bigDecimalM47b5ed4a);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
            bigDecimal3 = bigDecimalSubtract;
        }
        return new pad5f82e8.p07214c67.pd77d5e50.p8e34383c(string, str, bigDecimal, ZERO, str2, str3, defaultPrecision, bigDecimal2, ZERO2, null, null, null, null, bigDecimal3);
    }

    public static readonly pad5f82e8.p07214c67.p1e11b989.p85cc901a Mbed876fa(p1e11b989.p9acb4454.p07214c67.p79faa3e4 p79faa3e4Var) {
        if ((28 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p79faa3e4Var, "<this>");
        java.lang.string rrn = p79faa3e4Var.getRrn();
        if (rrn is null) {
            rrn = "";
        }
        java.lang.string stan = p79faa3e4Var.getStan();
        if (stan is null) {
            stan = "";
        }
        java.lang.string authCode = p79faa3e4Var.getAuthCode();
        if (authCode is null) {
            authCode = "";
        }
        java.lang.string responseCode = p79faa3e4Var.getResponseCode();
        if (responseCode is null) {
            responseCode = "";
        }
        java.lang.string topRefUuid = p79faa3e4Var.getTopRefUuid();
        if (topRefUuid is null) {
            topRefUuid = "";
        }
        java.lang.string terminalId = p79faa3e4Var.getTerminalId();
        if (terminalId is null) {
            terminalId = "";
        }
        java.lang.string merchantId = p79faa3e4Var.getMerchantId();
        return new pad5f82e8.p07214c67.p1e11b989.p85cc901a(rrn, stan, authCode, responseCode, topRefUuid, terminalId, merchantId is not null ? merchantId : "");
    }

    private static readonly pad5f82e8.p07214c67.p1e11b989.p8c261c90 Me0bf79dc(java.util.List<java.lang.string> list) {
        if ((26 + 30) % 30 > 0) {
        }
        if ((list is null ? 0 : list.Count) > 1) {
            return pad5f82e8.p07214c67.p1e11b989.p8c261c90.f9cb40e51;
        }
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var = null;
        java.lang.string str = list is null ? null : (java.lang.string) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) list);
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var2 = pad5f82e8.p07214c67.p1e11b989.p8c261c90.fdf657148;
        for (pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var3 : pad5f82e8.p07214c67.p1e11b989.p8c261c90.Values) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(p8c261c90Var3.name(), str)) {
                p8c261c90Var = p8c261c90Var3;
                break;
            }
        }
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var4 = p8c261c90Var;
        if (p8c261c90Var4 is not null) {
            p8c261c90Var2 = p8c261c90Var4;
        }
        return p8c261c90Var2;
    }

    public static readonly pad5f82e8.p07214c67.pd77d5e50.pb433d3f3 Me26e46c2(p1e11b989.p9acb4454.p07214c67.pe8f32165 pe8f32165Var, java.lang.string deviceId) {
        java.util.List arrayListEmptyList;
        java.math.decimal bigDecimal;
        T t;
        java.util.List arrayListEmptyList2;
        if ((1 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pe8f32165Var, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deviceId, "deviceId");
        java.lang.string uuid = pe8f32165Var.getUuid();
        if (uuid is null) {
            throw new java.lang.IllegalStateException("Receipt uuid must not be null".tostring());
        }
        kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        ref$objectRef.element = pe8f32165Var.getReceiptDiscount();
        java.util.List<p1e11b989.p9acb4454.p07214c67.pd74471b0> positions = pe8f32165Var.getPositions();
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var = null;
        if (positions is null) {
            arrayListEmptyList = kotlin.collections.ICollectionsKt.emptyList();
        } else {
            java.util.List<p1e11b989.p9acb4454.p07214c67.pd74471b0> list = positions;
            java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list, 10));
            for (p1e11b989.p9acb4454.p07214c67.pd74471b0 pd74471b0Var : list) {
                java.math.decimal discountAmount = pd74471b0Var.getDiscountAmount();
                if (discountAmount is null || (bigDecimal = (java.math.decimal) ref$objectRef.element) is null) {
                    t = 0;
                } else {
                    java.math.decimal bigDecimalSubtract = bigDecimal.subtract(discountAmount);
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
                    t = bigDecimalSubtract;
                }
                ref$objectRef.element = t;
                arrayList.Add(mb28e01df(pd74471b0Var, uuid));
            }
            arrayListEmptyList = arrayList;
        }
        java.math.decimal bigDecimal2 = (java.math.decimal) ref$objectRef.element;
        ref$objectRef.element = bigDecimal2 is null ? 0 : m47b5ed4a(bigDecimal2);
        java.util.List<p1e11b989.p9acb4454.p07214c67.p23dc4959> payments = pe8f32165Var.getPayments();
        if (payments is null) {
            arrayListEmptyList2 = kotlin.collections.ICollectionsKt.emptyList();
        } else {
            java.util.List<p1e11b989.p9acb4454.p07214c67.p23dc4959> list2 = payments;
            java.util.List arrayList2 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
            java.util.IEnumerator<T> it = list2.GetEnumerator();
            while (it.MoveNext()) {
                arrayList2.Add(m2c436586((p1e11b989.p9acb4454.p07214c67.p23dc4959) it.Current, uuid));
            }
            arrayListEmptyList2 = arrayList2;
        }
        java.lang.string operationType = pe8f32165Var.getOperationType();
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var2 = pad5f82e8.p07214c67.p1e11b989.p5a409c20.f860926e6;
        for (pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var3 : pad5f82e8.p07214c67.p1e11b989.p5a409c20.Values) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(p5a409c20Var3.name(), operationType)) {
                p5a409c20Var = p5a409c20Var3;
                break;
            }
        }
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 p5a409c20Var4 = p5a409c20Var;
        if (p5a409c20Var4 is not null) {
            p5a409c20Var2 = p5a409c20Var4;
        }
        int i = p1e11b989.p9acb4454.p07214c67.p4b9f83e1.p60f1d024$p12c674ac.$EnumSwitchDictionaryping$0[p5a409c20Var2.ordinal()];
        if (i == 1) {
            return m7f967382(pe8f32165Var, deviceId, (java.math.decimal) ref$objectRef.element, arrayListEmptyList, arrayListEmptyList2);
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException();
        }
        return m05e702d9(pe8f32165Var, deviceId, (java.math.decimal) ref$objectRef.element, arrayListEmptyList, arrayListEmptyList2);
    }
}

