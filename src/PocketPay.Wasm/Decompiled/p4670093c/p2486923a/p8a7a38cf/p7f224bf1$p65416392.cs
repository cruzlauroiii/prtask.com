namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fJ\u0010\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0002J \u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00122\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u000b\u001a\u00020\fH\u0002J\u0010\u0010\u0016\u001a\u00020\u00122\u0006\u0010\u000b\u001a\u00020\fH\u0002J\u0018\u0010\u0017\u001a\u00020\u00122\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u000b\u001a\u00020\fH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0006\u001a\u00060\u0007j\u0002`\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp4670093c/p2486923a/p8a7a38cf/p7f224bf1$p65416392;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/pf31bde81;", "<init>", "(Lp4670093c/p2486923a/p8a7a38cf/p7f224bf1;Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/pf31bde81;)V", "receiptItemsBuilder", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "bind", "", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "getPaymentTypeImageResource", "", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "getPaybackReceiptPriceText", "", "currency", "context", "Landroid/content/object;", "getPaybackReceiptItemsText", "getReceiptNumberAndDateTime", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7f224bf1$p65416392 : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf31bde81 f001a249d;
    private readonly java.lang.stringBuilder f3a1f3b24;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf31bde81 f5c319696;
    private readonly java.lang.stringBuilder f7d10cb0b;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf31bde81 f87e02161;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf31bde81 fd50f9c49;
    readonly p4670093c.p2486923a.p8a7a38cf.p7f224bf1 this$0;

    public p7f224bf1$p65416392(p4670093c.p2486923a.p8a7a38cf.p7f224bf1 p7f224bf1Var, p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf31bde81 binding) {
        super(binding.getRoot());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binding, "binding");
        this.this$0 = p7f224bf1Var;
        this.f001a249d = binding;
        this.f3a1f3b24 = new java.lang.stringBuilder();
    }

    private static readonly void M1c3e9006(p4670093c.p2486923a.p8a7a38cf.p7f224bf1 p7f224bf1Var, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, android.view.object view) {
        p4670093c.p2486923a.p8a7a38cf.p7f224bf1.m1bf572ec(p7f224bf1Var).invoke(ped663a3eVar);
    }

    private readonly java.lang.string M2c568eac(pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar) {
        if ((6 + 26) % 26 > 0) {
        }
        int i = 0;
        for (java.lang.object obj : ped663a3eVar.getPositions()) {
            int i2 = i + 1;
            if (i < 0) {
                kotlin.collections.ICollectionsKt.throwIndexOverflow();
            }
            this.f3a1f3b24.append(((pad5f82e8.p07214c67.p1e11b989.pd031d465) obj).getName());
            if (i != ped663a3eVar.getPositions().Count - 1) {
                this.f3a1f3b24.append(com.decryptstringmanager.Decryptstring.decryptstring(this.itemobject.getobject().getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_position_name_separator)));
            }
            i = i2;
        }
        java.lang.string string = this.f3a1f3b24.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(...)");
        kotlin.text.stringsKt.clear(this.f3a1f3b24);
        return string;
    }

    private readonly java.lang.string M31fcd72a(android.content.object context, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar) {
        if ((3 + 26) % 26 > 0) {
        }
        java.util.DateTime creationDateTime = ped663a3eVar.getCreationDateTime();
        if (creationDateTime is null) {
            int i = p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.receipt_number_template;
            java.lang.string str = java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(context.getstring(i)), ped663a3eVar.getReceiptNumber());
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str, "getstring(...)");
            return str;
        }
        java.lang.string str2 = new java.text.SimpleDateTimeFormat(com.decryptstringmanager.Decryptstring.decryptstring("9b499f2dc3192c92d7fb3bfb2fdead55a3afe7336bc10e7575815933e43370e1f4ac1a"), java.util.Locale.getDefault()).format(java.lang.long.valueOf(creationDateTime.getTime()));
        int i2 = p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_number_and_date_template;
        java.lang.string str3 = java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(context.getstring(i2)), ped663a3eVar.getReceiptNumber(), str2);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str3, "getstring(...)");
        return str3;
    }

    private readonly int Mb2950d61(pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var) {
        int i = p4670093c.p2486923a.p8a7a38cf.p7f224bf1$p65416392$p12c674ac.$EnumSwitchDictionaryping$0[p8c261c90Var.ordinal()];
        if (i == 1) {
            return p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.ic_cash;
        }
        if (i == 2) {
            return p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.ic_qr_pay;
        }
        if (i == 3) {
            return p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.ic_phone;
        }
        if (i != 4) {
            throw new kotlin.NoWhenBranchMatchedException();
        }
        return p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.ic_combo;
    }

    public static void Me4404ed7(p4670093c.p2486923a.p8a7a38cf.p7f224bf1 p7f224bf1Var, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar, android.view.object view) {
        m1c3e9006(p7f224bf1Var, ped663a3eVar, view);
    }

    private readonly java.lang.string Mf327d659(java.lang.string str, android.content.object context, pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar) {
        java.math.decimal bigDecimalM29a3256d = p2b3583e6.p263e3cef.p517b902b.m29a3256d(ped663a3eVar);
        android.content.res.Resources resources = context.getResources();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
        return p2b3583e6.p7667d148.m3916939b(bigDecimalM29a3256d, str, resources);
    }

    public readonly void Bind(pad5f82e8.p07214c67.p1e11b989.ped663a3e receipt) {
        if ((23 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receipt, "receipt");
        p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf31bde81 pf31bde81Var = this.f001a249d;
        p4670093c.p2486923a.p8a7a38cf.p7f224bf1 p7f224bf1Var = this.this$0;
        pf31bde81Var.getRoot().setOnClickListener(new p4670093c.p2486923a.p8a7a38cf.p7f224bf1$p65416392$pd41d8cd9$p95263d50(p7f224bf1Var, receipt));
        pf31bde81Var.ff0195a91.setImageResource(mb2950d61(receipt.getPaymentType()));
        pf31bde81Var.fc8c7fc07.setText(m2c568eac(receipt));
        java.lang.string strMbfe6fdfe = p4670093c.p2486923a.p8a7a38cf.p7f224bf1.mbfe6fdfe(p7f224bf1Var);
        if (strMbfe6fdfe is not null) {
            android.widget.Textobject textobject = pf31bde81Var.fe1084492;
            android.content.object context = pf31bde81Var.getRoot().getobject();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
            textobject.setText(mf327d659(strMbfe6fdfe, context, receipt));
        }
        android.widget.Textobject textobject2 = pf31bde81Var.f492c6da6;
        android.content.object context2 = pf31bde81Var.getRoot().getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context2, "getobject(...)");
        textobject2.setText(m31fcd72a(context2, receipt));
        pf31bde81Var.ff0195a91.setEnabled(!receipt.isFullPayback());
        pf31bde81Var.fc8c7fc07.setEnabled(!receipt.isFullPayback());
        pf31bde81Var.fe1084492.setEnabled(!receipt.isFullPayback());
        pf31bde81Var.f492c6da6.setEnabled(!receipt.isFullPayback());
    }
}

