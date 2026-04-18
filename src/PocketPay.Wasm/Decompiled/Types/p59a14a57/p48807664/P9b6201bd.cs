namespace WillowMaze.Wasm.Decompiled;

public class P9b6201bd : LinearLayout
{
    private readonly p666a4cc3 F001a249d;
    private readonly p666a4cc3 F93241046;
    private readonly p666a4cc3 F95850f82;
    private readonly p666a4cc3 Fb63cf5bb;

    private void M558c27ca(TypedArray P0)
    {
        // call: p9b6201bd$p24d75c17.getEntries
        // call: p9b6201bd$p24d75c17.ordinal
        // call: EnumEntries.get
        // call: p9b6201bd.m74123717
        // call: TypedArray.getInteger
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.PaymentAdvancedCalculatorView_paymentType
        // field: p59a14a57.p48807664.p9b6201bd$p24d75c17.fdf657148
    }

    private void M6bd0cb5c(decimal P0, decimal P1, string P2)
    {
        // str: "getResources(...)"
        // str: "subtract(...)"
        // call: DecryptString.decryptString
        // call: TextView.setText
        // call: p9b6201bd.getResources
        // call: Intrinsics.checkNotNullExpressionValue
        // call: decimal.compareTo
        // call: decimal.subtract
        // call: object.getString
        // call: p7667d148.mc75a988a
        // call: p7667d148.m25ba5d03
        // call: p9b6201bd.getContext
        // field: p59a14a57.p48807664.p9b6201bd.f001a249d
        // field: java.math.BigDecimal.ZERO
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.nothing
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f8d92caea
    }

    private void M74123717(p9b6201bd$p24d75c17 P0)
    {
        // call: p9b6201bd$p24d75c17.ordinal
        // call: p9b6201bd.m8b52032f
        // call: p9b6201bd.mf3651b4c
        // call: NoWhenBranchMatchedException.<init>
        // field: p59a14a57.p48807664.p9b6201bd$p12c674ac.$EnumSwitchMapping$0
        // type: NoWhenBranchMatchedException
    }

    private void M8b52032f()
    {
        // call: object.getString
        // call: p9b6201bd.getContext
        // call: ConstraintLayout.setVisibility
        // call: DecryptString.decryptString
        // call: TextView.setText
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f901dedac
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_received_electron_title
        // field: p59a14a57.p48807664.p9b6201bd.f001a249d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f193c63bb
    }

    private void M90300198(string P0)
    {
        // call: TextView.setText
        // field: p59a14a57.p48807664.p9b6201bd.f001a249d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f4f5f4da6
    }

    public static void Mb21ee905(Func<object, object> P0, p9b6201bd P1, decimal P2, string P3, string P4)
    {
        // call: p9b6201bd.mb849075e
    }

    private static void Mb849075e(Func<object, object> P0, p9b6201bd P1, decimal P2, string P3, string P4)
    {
        // str: "currentPrice"
        // call: Func<object, object>.invoke
        // call: p9b6201bd.m6bd0cb5c
        // call: Intrinsics.checkNotNullParameter
        // call: decimal.<init>
        // call: p9b6201bd.m90300198
        // field: kotlin.Unit.INSTANCE
        // type: decimal
    }

    private void Mf3651b4c()
    {
        // str: "null cannot be cast to non-null type androidx.constraintlayout.widget.ConstraintLayout.LayoutParams"
        // call: pde7b38ac.getLayoutParams
        // call: DecryptString.decryptString
        // call: p9b6201bd.getContext
        // call: object.getString
        // call: Intrinsics.checkNotNull
        // call: TextView.setText
        // call: ConstraintLayout.setVisibility
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f901dedac
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_sell_total
        // field: androidx.constraintlayout.widget.ConstraintLayout$LayoutParams.topMargin
        // field: p59a14a57.p48807664.p9b6201bd.f001a249d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.fa0557921
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.payment_calculator_sell_received_cash_title
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f193c63bb
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f76cd02bb
    }

    public void InitCalculator(decimal P0, string P1, Func<object, object> P2)
    {
        // str: "getString(...)"
        // str: "currentPriceListener"
        // str: "getResources(...)"
        // str: "currency"
        // str: "total"
        // call: pde7b38ac.setCurrentPriceListener
        // call: p9b6201bd.getContext
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p7667d148.m3916939b
        // call: p9b6201bd.getResources
        // call: TextView.setText
        // call: p9b6201bd.m90300198
        // call: p9b6201bd$pd41d8cd9$p95263d50.<init>
        // call: DecryptString.decryptString
        // call: object.getString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.fb1710207
        // field: p59a14a57.p48807664.p9b6201bd.f001a249d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.edit_position_text_price_zero
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p666a4cc3.f76cd02bb
        // type: p9b6201bd$pd41d8cd9$p95263d50
    }

}
