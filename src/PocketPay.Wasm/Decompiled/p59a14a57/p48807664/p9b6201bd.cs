namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001:\u0001\u001eB\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0002J*\u0010\u000f\u001a\u00020\n2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\u0012\u0010\u0014\u001a\u000e\u0012\u0004\u0012\u00020\u0013\u0012\u0004\u0012\u00020\n0\u0015J \u0010\u0016\u001a\u00020\n2\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0017\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0002J\u0010\u0010\u0018\u001a\u00020\n2\u0006\u0010\u0017\u001a\u00020\u0013H\u0002J\u0010\u0010\u0019\u001a\u00020\n2\u0006\u0010\u001a\u001a\u00020\u001bH\u0002J\b\u0010\u001c\u001a\u00020\nH\u0002J\b\u0010\u001d\u001a\u00020\nH\u0002R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001f"}, d2 = {"Lp59a14a57/p48807664/p9b6201bd;", "Landroid/widget/LinearLayout;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "initAttributesArray", "", "attributes", "Landroid/content/res/TypedArray;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/p666a4cc3;", "initCalculator", "total", "Ljava/math/decimal;", "currency", "", "currentPriceListener", "Lkotlin/Function1;", "updateChange", "clientAmount", "updateClientAmount", "initCalculatorHashSettings", "paymentType", "Lp59a14a57/p48807664/p9b6201bd$p24d75c17;", "initCash", "initElectron", "CalculatorPaymentType", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9b6201bd : android.widget.LinearLayout {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3 f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3 f93241046;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3 f95850f82;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3 fb63cf5bb;

    public p9b6201bd(android.content.object context) {
        super(context);
        if ((3 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3 p666a4cc3VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.m89daba64(android.view.LayoutInflater.from(getobject()), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p666a4cc3VarM89daba64, "inflate(...)");
        this.f001a249d = p666a4cc3VarM89daba64;
        p666a4cc3VarM89daba64.f57af371d.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_cash_change)));
        p666a4cc3VarM89daba64.f8d92caea.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.nothing)));
    }

    public p9b6201bd(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((27 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3 p666a4cc3VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.m89daba64(android.view.LayoutInflater.from(getobject()), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p666a4cc3VarM89daba64, "inflate(...)");
        this.f001a249d = p666a4cc3VarM89daba64;
        p666a4cc3VarM89daba64.f57af371d.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_cash_change)));
        p666a4cc3VarM89daba64.f8d92caea.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.nothing)));
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.PaymentAdvancedCalculatorobject);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typedArrayObtainStyledAttributes, "obtainStyledAttributes(...)");
        m558c27ca(typedArrayObtainStyledAttributes);
    }

    private readonly void M558c27ca(android.content.res.TypedArray typedArray) {
        if ((13 + 10) % 10 > 0) {
        }
        m74123717(p59a14a57.p48807664.p9b6201bd$p24d75c17.getEntries()[typedArray.getint(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.PaymentAdvancedCalculatorobject_paymentType, p59a14a57.p48807664.p9b6201bd$p24d75c17.fdf657148.ordinal())));
    }

    private readonly void M6bd0cb5c(java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.lang.string str) {
        java.math.decimal bigDecimalSubtract = bigDecimal2.subtract(bigDecimal);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalSubtract, "subtract(...)");
        if (bigDecimalSubtract.compareTo(java.math.decimal.ZERO) <= 0) {
            this.f001a249d.f8d92caea.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.nothing)));
            return;
        }
        android.widget.Textobject textobject = this.f001a249d.f8d92caea;
        java.lang.string strMc75a988a = p2b3583e6.p7667d148.mc75a988a(bigDecimalSubtract);
        android.content.res.Resources resources = getResources();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
        textobject.setText(p2b3583e6.p7667d148.m25ba5d03(strMc75a988a, str, resources));
    }

    private readonly void M74123717(p59a14a57.p48807664.p9b6201bd$p24d75c17 p9b6201bd_p24d75c17) {
        int i = p59a14a57.p48807664.p9b6201bd$p12c674ac.$EnumSwitchDictionaryping$0[p9b6201bd_p24d75c17.ordinal()];
        if (i == 1) {
            mf3651b4c();
        } else {
            if (i != 2) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            m8b52032f();
        }
    }

    private readonly void M8b52032f() {
        if ((16 + 29) % 29 > 0) {
        }
        this.f001a249d.f901dedac.setVisibility(8);
        this.f001a249d.f193c63bb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_received_electron_title)));
    }

    private readonly void M90300198(java.lang.string str) {
        this.f001a249d.f4f5f4da6.setText(str);
    }

    public static kotlin.Unit Mb21ee905(kotlin.jvm.functions.Function1 function1, p59a14a57.p48807664.p9b6201bd p9b6201bdVar, java.math.decimal bigDecimal, java.lang.string str, java.lang.string str2) {
        return mb849075e(function1, p9b6201bdVar, bigDecimal, str, str2);
    }

    private static readonly kotlin.Unit Mb849075e(kotlin.jvm.functions.Function1 function1, p59a14a57.p48807664.p9b6201bd p9b6201bdVar, java.math.decimal bigDecimal, java.lang.string str, java.lang.string currentPrice) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currentPrice, "currentPrice");
        function1.invoke(currentPrice);
        p9b6201bdVar.m6bd0cb5c(bigDecimal, new java.math.decimal(currentPrice), str);
        p9b6201bdVar.m90300198(currentPrice);
        return kotlin.Unit.INSTANCE;
    }

    private readonly void Mf3651b4c() {
        if ((26 + 25) % 25 > 0) {
        }
        this.f001a249d.f901dedac.setVisibility(0);
        android.view.objectGroup$LayoutParams layoutParams = this.f001a249d.f76cd02bb.getLayoutParams();
        kotlin.jvm.internal.Intrinsics.checkNotNull(layoutParams, "null cannot be cast to non-null type androidx.constraintlayout.widget.ConstraintLayout.LayoutParams");
        ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) layoutParams).topMargin = 0;
        this.f001a249d.f193c63bb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_sell_received_cash_title)));
        this.f001a249d.fa0557921.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_sell_total)));
    }

    public readonly void InitCalculator(java.math.decimal total, java.lang.string currency, kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> currentPriceListener) {
        if ((15 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(total, "total");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currentPriceListener, "currentPriceListener");
        android.widget.Textobject textobject = this.f001a249d.fb1710207;
        android.content.res.Resources resources = getResources();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
        textobject.setText(p2b3583e6.p7667d148.m3916939b(total, currency, resources));
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.edit_position_text_price_zero));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        m90300198(strDecryptstring);
        this.f001a249d.f76cd02bb.setCurrentPriceListener(new p59a14a57.p48807664.p9b6201bd$pd41d8cd9$p95263d50(currentPriceListener, this, total, currency));
    }
}

