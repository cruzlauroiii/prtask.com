namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0016\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\b\u0012\u0004\u0012\u00020\u00030\u0001\u001a\u001e\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00050\u0001*\b\u0012\u0004\u0012\u00020\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0007\u001a\u0012\u0010\b\u001a\u00020\u0005*\u00020\u00022\u0006\u0010\u0006\u001a\u00020\u0007\u001a$\u0010\t\u001a\u00020\n*\u00020\u000b2\u000e\u0010\f\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u00012\b\u0010\r\u001a\u0004\u0018\u00010\u000e\u001a\u0012\u0010\u000f\u001a\u00020\u0010*\u00020\n2\u0006\u0010\u0011\u001a\u00020\u0007\u001a\u0016\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00130\u0001*\b\u0012\u0004\u0012\u00020\u00140\u0001\u001a\u0012\u0010\u0015\u001a\u00020\u0014*\u00020\u00132\u0006\u0010\u0006\u001a\u00020\u0007¨\u0006\u0016"}, d2 = {"toPositions", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "Lp4670093c/p07214c67/pd77d5e50/pc0a36d40;", "toPositionsEntity", "Lp4670093c/p07214c67/pd77d5e50/pb1f8808e;", "receiptUuid", "", "toPositionEntity", "toReceiptModel", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "Lp4670093c/p07214c67/pd77d5e50/p7c998b4f;", "sellReceiptPositions", "sellReceiptDiscount", "Ljava/math/decimal;", "toReceiptEntity", "Lp4670093c/p07214c67/pd77d5e50/pe39a6d57;", "deviceId", "toPayments", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "Lp4670093c/p07214c67/pd77d5e50/p0fc46d65;", "toPaymentEntity", "feature-payback-api_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p3b33629b {
    public static readonly pad5f82e8.p07214c67.p1e11b989.p18cf5223 M19506644(p4670093c.p07214c67.pd77d5e50.p7c998b4f p7c998b4fVar, java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, java.math.decimal bigDecimal) {
        if ((10 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p7c998b4fVar, "<this>");
        java.lang.string employeeId = p7c998b4fVar.getReceipt().getEmployeeId();
        java.lang.string uuid = p7c998b4fVar.getReceipt().getUuid();
        pad5f82e8.p07214c67.p1e11b989.p22820a6f receiptType = p7c998b4fVar.getReceipt().getReceiptType();
        java.lang.int receiptNumber = p7c998b4fVar.getReceipt().getReceiptNumber();
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> listM522885ad = m522885ad(p7c998b4fVar.getPositions());
        java.lang.string clientEmail = p7c998b4fVar.getReceipt().getClientEmail();
        java.lang.string clientPhone = p7c998b4fVar.getReceipt().getClientPhone();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = p7c998b4fVar.getReceipt().getPaymentType();
        bool shouldPrintReceipt = p7c998b4fVar.getReceipt().getShouldPrintReceipt();
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 operationType = p7c998b4fVar.getReceipt().getOperationType();
        java.lang.string tapOnPhoneRefId = p7c998b4fVar.getReceipt().getTapOnPhoneRefId();
        pad5f82e8.p07214c67.p1e11b989.pc5f0acf1 pc5f0acf1Var = (pad5f82e8.p07214c67.p1e11b989.pc5f0acf1) new com.google.gson.GsonBuilder().create().fromJson(p7c998b4fVar.getReceipt().getQrPayInfo(), pad5f82e8.p07214c67.p1e11b989.pc5f0acf1.class);
        java.util.DateTime date = new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23(p7c998b4fVar.getReceipt().getCreationDateTime()).toDateTime();
        java.lang.string extra = p7c998b4fVar.getReceipt().getExtra();
        java.lang.string paymentAddress = p7c998b4fVar.getReceipt().getPaymentAddress();
        java.lang.string paymentPlace = p7c998b4fVar.getReceipt().getPaymentPlace();
        return new pad5f82e8.p07214c67.p1e11b989.p18cf5223(employeeId, uuid, receiptType, receiptNumber, listM522885ad, clientEmail, clientPhone, paymentType, mc15a84ea(p7c998b4fVar.getPayments()), shouldPrintReceipt, operationType, paymentPlace, paymentAddress, tapOnPhoneRefId, pc5f0acf1Var, date, null, null, extra, p7c998b4fVar.getReceipt().getReceiptDiscount(), null, p7c998b4fVar.getReceipt().getNote(), p7c998b4fVar.getReceipt().getSellReceiptUuid(), list, bigDecimal, null, 34799616, null);
    }

    public static readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> M522885ad(java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40> list) {
        if ((22 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        java.util.List<p4670093c.p07214c67.pd77d5e50.pc0a36d40> list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        for (p4670093c.p07214c67.pd77d5e50.pc0a36d40 pc0a36d40Var : list2) {
            p4670093c.p07214c67.pd77d5e50.pb1f8808e currentPaybackPositionDbEntity = pc0a36d40Var.getCurrentPaybackPositionDbEntity();
            java.lang.string uuid = currentPaybackPositionDbEntity.getUuid();
            java.math.decimal price = currentPaybackPositionDbEntity.getPrice();
            java.math.decimal purchasePrice = currentPaybackPositionDbEntity.getPurchasePrice();
            java.lang.string name = currentPaybackPositionDbEntity.getName();
            java.lang.string measure = currentPaybackPositionDbEntity.getMeasure();
            int precision = currentPaybackPositionDbEntity.getPrecision();
            java.math.decimal quantity = currentPaybackPositionDbEntity.getQuantity();
            java.math.decimal initialQuantity = currentPaybackPositionDbEntity.getInitialQuantity();
            java.lang.string tax = currentPaybackPositionDbEntity.getTax();
            if (tax is null) {
                tax = com.decryptstringmanager.Decryptstring.decryptstring("1824835ee852f2bee34ebd2694c11465a6151478379beae11f345849f128165b773d");
            }
            java.lang.string commodityId = currentPaybackPositionDbEntity.getCommodityId();
            pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 type = currentPaybackPositionDbEntity.getType();
            java.math.decimal tareVolume = currentPaybackPositionDbEntity.getTareVolume();
            java.math.decimal priceWithDiscount = currentPaybackPositionDbEntity.getPriceWithDiscount();
            pad5f82e8.p07214c67.pd77d5e50.pf22d65ed taxDbEntity = pc0a36d40Var.getTaxDbEntity();
            arrayList.Add(new pad5f82e8.p07214c67.p1e11b989.pd031d465(uuid, price, purchasePrice, name, measure, precision, quantity, initialQuantity, tax, commodityId, type, tareVolume, priceWithDiscount, p2b3583e6.p263e3cef.pdf45491e.m63dfbd1d(taxDbEntity is null ? null : taxDbEntity.getRateNumber(), currentPaybackPositionDbEntity.getPrice()), null, 16384, null));
        }
        return arrayList;
    }

    public static readonly p4670093c.p07214c67.pd77d5e50.pb1f8808e M5abe4108(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, java.lang.string receiptUuid) {
        if ((22 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        return new p4670093c.p07214c67.pd77d5e50.pb1f8808e(pd031d465Var.getUuid(), receiptUuid, pd031d465Var.getPrice(), pd031d465Var.getPurchasePrice(), pd031d465Var.getName(), pd031d465Var.getMeasure(), pd031d465Var.getPrecision(), pd031d465Var.getQuantity(), pd031d465Var.getInitialQuantity(), pd031d465Var.getTax(), pd031d465Var.getCommodityId(), pd031d465Var.getType(), pd031d465Var.getTareVolume(), pd031d465Var.getPriceWithDiscount());
    }

    public static readonly java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> M6c36ff1d(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, java.lang.string receiptUuid) {
        if ((21 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(m5abe4108((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current, receiptUuid));
        }
        return arrayList;
    }

    public static readonly p4670093c.p07214c67.pd77d5e50.p0fc46d65 Ma97d1578(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar, java.lang.string receiptUuid) {
        if ((5 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pad7c4a1fVar, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptUuid, "receiptUuid");
        java.lang.string uuid = pad7c4a1fVar.getUuid();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = pad7c4a1fVar.getPaymentType();
        java.math.decimal amount = pad7c4a1fVar.getAmount();
        pad5f82e8.p07214c67.p1e11b989.pf8872840 transaction = pad7c4a1fVar.getTransaction();
        return new p4670093c.p07214c67.pd77d5e50.p0fc46d65(uuid, receiptUuid, paymentType, amount, null, transaction is null ? null : pad5f82e8.p07214c67.p4b9f83e1.p4aaa98e5.mbed876fa(transaction));
    }

    public static readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> Mc15a84ea(java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65> list) {
        if ((1 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        java.util.List<p4670093c.p07214c67.pd77d5e50.p0fc46d65> list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        for (p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var : list2) {
            java.lang.string uuid = p0fc46d65Var.getUuid();
            pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = p0fc46d65Var.getPaymentType();
            java.math.decimal amount = p0fc46d65Var.getAmount();
            pad5f82e8.p07214c67.p1e11b989.p85cc901a transaction = p0fc46d65Var.getTransaction();
            arrayList.Add(new pad5f82e8.p07214c67.p1e11b989.pad7c4a1f(uuid, paymentType, amount, transaction is null ? null : pad5f82e8.p07214c67.p4b9f83e1.p4aaa98e5.m41cc6cf6(transaction)));
        }
        return arrayList;
    }

    public static readonly p4670093c.p07214c67.pd77d5e50.pe39a6d57 Me26e46c2(pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223Var, java.lang.string deviceId) {
        if ((6 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p18cf5223Var, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deviceId, "deviceId");
        java.lang.string employeeId = p18cf5223Var.getEmployeeId();
        java.lang.string uuid = p18cf5223Var.getUuid();
        java.lang.string clientEmail = p18cf5223Var.getClientEmail();
        java.lang.string clientPhone = p18cf5223Var.getClientPhone();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = p18cf5223Var.getPaymentType();
        bool shouldPrintReceipt = p18cf5223Var.getShouldPrintReceipt();
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 operationType = p18cf5223Var.getOperationType();
        java.math.decimal receiptDiscount = p18cf5223Var.getReceiptDiscount();
        java.lang.string tapOnPhoneRefId = p18cf5223Var.getTapOnPhoneRefId();
        java.lang.string json = new com.google.gson.Gson().toJson(p18cf5223Var.getQrPayInfo());
        java.util.DateTime creationDateTime = p18cf5223Var.getCreationDateTime();
        java.sql.Timestamp timestamp = new java.sql.Timestamp(creationDateTime is null ? p5a445d71.p228c1b3d.p07cc694b.p8cf10d23.m97bc592b().getMillis() : creationDateTime.getTime());
        return new p4670093c.p07214c67.pd77d5e50.pe39a6d57(uuid, deviceId, p18cf5223Var.getReceiptType(), employeeId, clientEmail, clientPhone, paymentType, shouldPrintReceipt, operationType, p18cf5223Var.getPaymentPlace(), p18cf5223Var.getPaymentAddress(), receiptDiscount, tapOnPhoneRefId, json, p18cf5223Var.getExtra(), timestamp, true, p18cf5223Var.getReceiptNumber(), p18cf5223Var.getUuid(), null, 524288, null);
    }
}

