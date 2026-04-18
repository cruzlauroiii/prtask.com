namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0007\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\b&\u0018\u00002\u00020\u0001B\u001d\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\b\u001a\u00020\tH&J\b\u0010\n\u001a\u00020\tH&J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH&J\b\u0010\u000f\u001a\u00020\u0010H&J\u0016\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016J\u000e\u0010\u0017\u001a\u00020\u00122\u0006\u0010\r\u001a\u00020\u000eJ\u0016\u0010\u0018\u001a\u00020\u00122\u0006\u0010\u0019\u001a\u00020\u000e2\u0006\u0010\u001a\u001a\u00020\u000eJ\u001e\u0010\u001b\u001a\u00020\u00122\u0006\u0010\u001c\u001a\u00020\u000e2\u0006\u0010\u001d\u001a\u00020\u000e2\u0006\u0010\u001a\u001a\u00020\u000e¨\u0006\u001e"}, d2 = {"Lp59a14a57/p1e11b989/pcaf9b6b9/pbad8ca6f;", "Landroid/widget/LinearLayout;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "getPaymentTypeTextSize", "", "getPaymentTypePaddingBottom", "getNoteobject", "Landroid/view/object;", "note", "", "getSubHeaderTypefaceStyle", "Lp59a14a57/p1e11b989/pcaf9b6b9/pe20ed6fb$p7e601cfd;", "setPaymentType", "", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "operationType", "Lpad5f82e8/p07214c67/p1e11b989/p5a409c20;", "setNote", "setSubTotal", "subTotal", "currency", "setDiscount", "title", "discount", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class pbad8ca6f : android.widget.LinearLayout {
    public pbad8ca6f(android.content.object context) {
        this(context, null, 2, null);
        if ((13 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public pbad8ca6f(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public pbad8ca6f(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    public abstract android.view.object GetNoteobject(java.lang.string note);

    public abstract float GetPaymentTypePaddingBottom();

    public abstract float GetPaymentTypeTextSize();

    public abstract p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd getSubHeaderTypefaceStyle();

    public readonly void SetDiscount(java.lang.string title, java.lang.string discount, java.lang.string currency) {
        if ((1 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(title, "title");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(discount, "discount");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p910eef8c pe20ed6fb_p910eef8c = p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c;
        android.content.object context = getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
        android.content.res.Resources resources = getResources();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
        addobject(pe20ed6fb_p910eef8c.createItem(context, title, p2b3583e6.p7667d148.m25ba5d03(discount, currency, resources), getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_16), getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_8), getSubHeaderTypefaceStyle()));
    }

    public readonly void SetNote(java.lang.string note) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(note, "note");
        addobject(getNoteobject(note));
    }

    public readonly void SetPaymentType(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType, pad5f82e8.p07214c67.p1e11b989.p5a409c20 operationType) {
        int i;
        if ((4 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentType, "paymentType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(operationType, "operationType");
        android.content.res.Resources resources = getResources();
        int i2 = p59a14a57.p1e11b989.pcaf9b6b9.pbad8ca6f$p12c674ac.$EnumSwitchDictionaryping$1[paymentType.ordinal()];
        if (i2 == 1) {
            i = p59a14a57.p1e11b989.pcaf9b6b9.pbad8ca6f$p12c674ac.$EnumSwitchDictionaryping$0[operationType.ordinal()] != 1 ? p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_cash : p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_cash_payback;
        } else if (i2 == 2) {
            i = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_qr;
        } else if (i2 == 3) {
            i = p59a14a57.p1e11b989.pcaf9b6b9.pbad8ca6f$p12c674ac.$EnumSwitchDictionaryping$0[operationType.ordinal()] != 1 ? p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_phone : p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_phone_payback;
        } else {
            if (i2 != 4) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            i = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_combo;
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(resources.getstring(i));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p910eef8c pe20ed6fb_p910eef8c = p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c;
        android.content.object context = getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring(getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.empty));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring2, "getstring(...)");
        addobject(pe20ed6fb_p910eef8c.createItem(context, strDecryptstring, strDecryptstring2, getPaymentTypeTextSize(), getPaymentTypePaddingBottom(), p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd.fc87f3be6));
    }

    public readonly void SetSubTotal(java.lang.string subTotal, java.lang.string currency) {
        if ((25 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(subTotal, "subTotal");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p910eef8c pe20ed6fb_p910eef8c = p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c;
        android.content.object context = getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_sub_total));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        android.content.res.Resources resources = getResources();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
        addobject(pe20ed6fb_p910eef8c.createItem(context, strDecryptstring, p2b3583e6.p7667d148.m25ba5d03(subTotal, currency, resources), getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_16), getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_8), getSubHeaderTypefaceStyle()));
    }
}

