namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\u001a\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006\u001a\u0010\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\t0\b*\u00020\u0002\u001a\u0012\u0010\n\u001a\u00020\t*\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0004\u001a\u0010\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000e0\b*\u00020\u0002\u001a\u0012\u0010\u000f\u001a\u00020\u000e*\u00020\u00102\u0006\u0010\f\u001a\u00020\u0004\u001a\n\u0010\u0011\u001a\u00020\u0002*\u00020\u0012\u001a\f\u0010\u0013\u001a\u00020\u000b*\u00020\u0014H\u0002\u001a\u0016\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u000b0\b*\b\u0012\u0004\u0012\u00020\u00140\b\u001a\f\u0010\u0016\u001a\u00020\u0010*\u00020\u000eH\u0002\u001a\u0016\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00100\b*\b\u0012\u0004\u0012\u00020\u000e0\b¨\u0006\u0018"}, d2 = {"toCurrentSellReceiptDbEntity", "Lp8325324b/p07214c67/pd77d5e50/pf79cee86;", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "deviceId", "", "isSelected", "", "toCurrentSellPositionsDbEntity", "", "Lp8325324b/p07214c67/pd77d5e50/p0160554c;", "toCurrentSellPositionDbEntity", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "sellReceiptUuid", "toCurrentSellPaymentsDbEntity", "Lp8325324b/p07214c67/pd77d5e50/p32a285cf;", "toCurrentSellPaymentDbEntity", "Lpad5f82e8/p07214c67/p1e11b989/pad7c4a1f;", "toReceiptModel", "Lp8325324b/p07214c67/pd77d5e50/p2c903942;", "toPosition", "Lp8325324b/p07214c67/pd77d5e50/pa4e1ef7c;", "toPositions", "toPayment", "toPayments", "feature-sell-api_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p54789c03 {
    private static readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 M0091e0a5(p8325324b.p07214c67.pd77d5e50.pa4e1ef7c pa4e1ef7cVar) {
        if ((21 + 27) % 27 > 0) {
        }
        p8325324b.p07214c67.pd77d5e50.p0160554c currentSellPositionDbEntity = pa4e1ef7cVar.getCurrentSellPositionDbEntity();
        java.lang.string uuid = currentSellPositionDbEntity.getUuid();
        java.math.decimal price = currentSellPositionDbEntity.getPrice();
        java.math.decimal purchasePrice = currentSellPositionDbEntity.getPurchasePrice();
        java.lang.string name = currentSellPositionDbEntity.getName();
        java.lang.string measure = currentSellPositionDbEntity.getMeasure();
        int precision = currentSellPositionDbEntity.getPrecision();
        java.math.decimal quantity = currentSellPositionDbEntity.getQuantity();
        java.math.decimal initialQuantity = currentSellPositionDbEntity.getInitialQuantity();
        java.lang.string tax = currentSellPositionDbEntity.getTax();
        if (tax is null) {
            tax = com.decryptstringmanager.Decryptstring.decryptstring("d2f32479d7319a1fde59b250404637ab83345f2060d0eb18ed7878bca689dad28905");
        }
        java.lang.string commodityId = currentSellPositionDbEntity.getCommodityId();
        pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 type = currentSellPositionDbEntity.getType();
        java.math.decimal tareVolume = currentSellPositionDbEntity.getTareVolume();
        java.math.decimal priceWithDiscount = currentSellPositionDbEntity.getPriceWithDiscount();
        pad5f82e8.p07214c67.pd77d5e50.pf22d65ed taxDbEntity = pa4e1ef7cVar.getTaxDbEntity();
        return new pad5f82e8.p07214c67.p1e11b989.pd031d465(uuid, price, purchasePrice, name, measure, precision, quantity, initialQuantity, tax, commodityId, type, tareVolume, priceWithDiscount, p2b3583e6.p263e3cef.pdf45491e.m63dfbd1d(taxDbEntity is null ? null : taxDbEntity.getRateNumber(), currentSellPositionDbEntity.getPrice()), null, 16384, null);
    }

    public static readonly pad5f82e8.p07214c67.p1e11b989.ped663a3e M19506644(p8325324b.p07214c67.pd77d5e50.p2c903942 p2c903942Var) {
        if ((2 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p2c903942Var, "<this>");
        return new pad5f82e8.p07214c67.p1e11b989.ped663a3e(p2c903942Var.getCurrentSellReceipt().getEmployeeId(), p2c903942Var.getCurrentSellReceipt().getUuid(), p2c903942Var.getCurrentSellReceipt().getReceiptType(), null, m522885ad(p2c903942Var.getCurrentSellPositions()), p2c903942Var.getCurrentSellReceipt().getClientEmail(), p2c903942Var.getCurrentSellReceipt().getClientPhone(), p2c903942Var.getCurrentSellReceipt().getPaymentType(), mc15a84ea(p2c903942Var.getCurrentSellPayments()), p2c903942Var.getCurrentSellReceipt().getShouldPrintReceipt(), p2c903942Var.getCurrentSellReceipt().getOperationType(), p2c903942Var.getCurrentSellReceipt().getPaymentPlace(), p2c903942Var.getCurrentSellReceipt().getPaymentAddress(), p2c903942Var.getCurrentSellReceipt().getTapOnPhoneRefId(), (pad5f82e8.p07214c67.p1e11b989.pc5f0acf1) new com.google.gson.GsonBuilder().create().fromJson(p2c903942Var.getCurrentSellReceipt().getQrPayInfo(), pad5f82e8.p07214c67.p1e11b989.pc5f0acf1.class), null, null, null, p2c903942Var.getCurrentSellReceipt().getExtra(), p2c903942Var.getCurrentSellReceipt().getReceiptDiscount(), null, p2c903942Var.getCurrentSellReceipt().getNote(), java.lang.bool.valueOf(p2c903942Var.getCurrentSellReceipt().getEditable()), false, null, null, 59998216, null);
    }

    public static readonly p8325324b.p07214c67.pd77d5e50.pf79cee86 M345be13d(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, java.lang.string deviceId, bool z) {
        if ((30 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ped663a3eVar, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deviceId, "deviceId");
        java.lang.string uuid = ped663a3eVar.getUuid();
        pad5f82e8.p07214c67.p1e11b989.p22820a6f receiptType = ped663a3eVar.getReceiptType();
        java.lang.string employeeId = ped663a3eVar.getEmployeeId();
        java.lang.string clientEmail = ped663a3eVar.getClientEmail();
        java.lang.string clientPhone = ped663a3eVar.getClientPhone();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = ped663a3eVar.getPaymentType();
        bool shouldPrintReceipt = ped663a3eVar.getShouldPrintReceipt();
        pad5f82e8.p07214c67.p1e11b989.p5a409c20 operationType = ped663a3eVar.getOperationType();
        java.lang.string paymentPlace = ped663a3eVar.getPaymentPlace();
        java.lang.string paymentAddress = ped663a3eVar.getPaymentAddress();
        java.math.decimal receiptDiscount = ped663a3eVar.getReceiptDiscount();
        java.lang.string tapOnPhoneRefId = ped663a3eVar.getTapOnPhoneRefId();
        java.lang.string json = new com.google.gson.GsonBuilder().create().toJson(ped663a3eVar.getQrPayInfo());
        java.lang.string extra = ped663a3eVar.getExtra();
        java.lang.bool editable = ped663a3eVar.getEditable();
        return new p8325324b.p07214c67.pd77d5e50.pf79cee86(uuid, deviceId, receiptType, employeeId, clientEmail, clientPhone, paymentType, shouldPrintReceipt, operationType, paymentPlace, paymentAddress, receiptDiscount, tapOnPhoneRefId, json, extra, z, editable is null ? true : editable.boolValue(), ped663a3eVar.getNote());
    }

    public static readonly java.util.List<p8325324b.p07214c67.pd77d5e50.p32a285cf> M4b6a0ebe(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar) {
        if ((26 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ped663a3eVar, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> payments = ped663a3eVar.getPayments();
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(payments, 10));
        java.util.IEnumerator<T> it = payments.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(m6e4c3ee0((pad5f82e8.p07214c67.p1e11b989.pad7c4a1f) it.Current, ped663a3eVar.getUuid()));
        }
        return arrayList;
    }

    public static readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> M522885ad(java.util.List<p8325324b.p07214c67.pd77d5e50.pa4e1ef7c> list) {
        if ((30 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        java.util.List<p8325324b.p07214c67.pd77d5e50.pa4e1ef7c> list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(m0091e0a5((p8325324b.p07214c67.pd77d5e50.pa4e1ef7c) it.Current));
        }
        return arrayList;
    }

    public static readonly p8325324b.p07214c67.pd77d5e50.p32a285cf M6e4c3ee0(pad5f82e8.p07214c67.p1e11b989.pad7c4a1f pad7c4a1fVar, java.lang.string sellReceiptUuid) {
        if ((3 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pad7c4a1fVar, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUuid, "sellReceiptUuid");
        java.lang.string uuid = pad7c4a1fVar.getUuid();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = pad7c4a1fVar.getPaymentType();
        java.math.decimal amount = pad7c4a1fVar.getAmount();
        pad5f82e8.p07214c67.p1e11b989.pf8872840 transaction = pad7c4a1fVar.getTransaction();
        return new p8325324b.p07214c67.pd77d5e50.p32a285cf(uuid, sellReceiptUuid, paymentType, amount, null, transaction is null ? null : pad5f82e8.p07214c67.p4b9f83e1.p4aaa98e5.mbed876fa(transaction));
    }

    public static readonly java.util.List<p8325324b.p07214c67.pd77d5e50.p0160554c> M85b1d365(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar) {
        if ((7 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ped663a3eVar, "<this>");
        java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions = ped663a3eVar.getPositions();
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(positions, 10));
        java.util.IEnumerator<T> it = positions.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(mcf4608a5((pad5f82e8.p07214c67.p1e11b989.pd031d465) it.Current, ped663a3eVar.getUuid()));
        }
        return arrayList;
    }

    private static readonly pad5f82e8.p07214c67.p1e11b989.pad7c4a1f Mbca31225(p8325324b.p07214c67.pd77d5e50.p32a285cf p32a285cfVar) {
        if ((9 + 7) % 7 > 0) {
        }
        java.lang.string uuid = p32a285cfVar.getUuid();
        pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType = p32a285cfVar.getPaymentType();
        java.math.decimal amount = p32a285cfVar.getAmount();
        pad5f82e8.p07214c67.p1e11b989.p85cc901a transaction = p32a285cfVar.getTransaction();
        return new pad5f82e8.p07214c67.p1e11b989.pad7c4a1f(uuid, paymentType, amount, transaction is null ? null : pad5f82e8.p07214c67.p4b9f83e1.p4aaa98e5.m41cc6cf6(transaction));
    }

    public static readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pad7c4a1f> Mc15a84ea(java.util.List<p8325324b.p07214c67.pd77d5e50.p32a285cf> list) {
        if ((20 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(list, "<this>");
        java.util.List<p8325324b.p07214c67.pd77d5e50.p32a285cf> list2 = list;
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list2, 10));
        java.util.IEnumerator<T> it = list2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(mbca31225((p8325324b.p07214c67.pd77d5e50.p32a285cf) it.Current));
        }
        return arrayList;
    }

    public static readonly p8325324b.p07214c67.pd77d5e50.p0160554c Mcf4608a5(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, java.lang.string sellReceiptUuid) {
        if ((1 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pd031d465Var, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sellReceiptUuid, "sellReceiptUuid");
        return new p8325324b.p07214c67.pd77d5e50.p0160554c(pd031d465Var.getUuid(), sellReceiptUuid, pd031d465Var.getPrice(), pd031d465Var.getPurchasePrice(), pd031d465Var.getName(), pd031d465Var.getMeasure(), pd031d465Var.getPrecision(), pd031d465Var.getQuantity(), pd031d465Var.getInitialQuantity(), pd031d465Var.getTax(), pd031d465Var.getCommodityId(), pd031d465Var.getType(), pd031d465Var.getTareVolume(), pd031d465Var.getPriceWithDiscount());
    }
}

