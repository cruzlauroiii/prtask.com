namespace WillowMaze.Wasm.Decompiled;

public abstract class Pbad8ca6f : LinearLayout
{
    public object GetNoteView(string P0)
    {
        return default!;
    }

    public float GetPaymentTypePaddingBottom()
    {
        return 0;
    }

    public float GetPaymentTypeTextSize()
    {
        return 0;
    }

    public pe20ed6fb$p7e601cfd GetSubHeaderTypefaceStyle()
    {
        return default!;
    }

    public void SetDiscount(string P0, string P1, string P2)
    {
        // str: "discount"
        // str: "currency"
        // str: "title"
        // str: "getResources(...)"
        // str: "getContext(...)"
        // call: pbad8ca6f.getResources
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pe20ed6fb$p910eef8c.createItem
        // call: Intrinsics.checkNotNullParameter
        // call: pbad8ca6f.getContext
        // call: Resources.getDimension
        // call: p7667d148.m25ba5d03
        // call: pbad8ca6f.addView
        // call: pbad8ca6f.getSubHeaderTypefaceStyle
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_16
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_8
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c
    }

    public void SetNote(string P0)
    {
        // str: "note"
        // call: Intrinsics.checkNotNullParameter
        // call: pbad8ca6f.getNoteView
        // call: pbad8ca6f.addView
    }

    public void SetPaymentType(p8c261c90 P0, p5a409c20 P1)
    {
        // str: "getContext(...)"
        // str: "operationType"
        // str: "paymentType"
        // str: "getString(...)"
        // call: pbad8ca6f.getResources
        // call: Resources.getString
        // call: pe20ed6fb$p910eef8c.createItem
        // call: p8c261c90.ordinal
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pbad8ca6f.getPaymentTypePaddingBottom
        // call: NoWhenBranchMatchedException.<init>
        // call: DecryptString.decryptString
        // call: p5a409c20.ordinal
        // call: pbad8ca6f.getPaymentTypeTextSize
        // call: pbad8ca6f.addView
        // call: Intrinsics.checkNotNullParameter
        // call: pbad8ca6f.getContext
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_cash
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pbad8ca6f$p12c674ac.$EnumSwitchMapping$0
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_qr
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_phone
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_cash_payback
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pbad8ca6f$p12c674ac.$EnumSwitchMapping$1
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_phone_payback
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.empty
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_title_combo
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd.fc87f3be6
        // type: NoWhenBranchMatchedException
    }

    public void SetSubTotal(string P0, string P1)
    {
        // str: "getString(...)"
        // str: "subTotal"
        // str: "getContext(...)"
        // str: "currency"
        // str: "getResources(...)"
        // call: p7667d148.m25ba5d03
        // call: pbad8ca6f.getResources
        // call: DecryptString.decryptString
        // call: pe20ed6fb$p910eef8c.createItem
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Resources.getDimension
        // call: pbad8ca6f.getSubHeaderTypefaceStyle
        // call: pbad8ca6f.addView
        // call: Intrinsics.checkNotNullParameter
        // call: Resources.getString
        // call: pbad8ca6f.getContext
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_16
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_sub_total
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_8
    }

}
