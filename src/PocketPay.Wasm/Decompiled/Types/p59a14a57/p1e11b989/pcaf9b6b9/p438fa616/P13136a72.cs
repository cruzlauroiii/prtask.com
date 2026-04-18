namespace WillowMaze.Wasm.Decompiled;

public class P13136a72 : Pbad8ca6f
{
    public static void Mbd5ec78b(p13136a72 P0, p8c261c90 P1, p5a409c20 P2, string P3, string P4, string P5, string P6, string P7, string P8, string P9, int P10, object P11)
    {
        // call: p13136a72.setReceiptInfo
        // field: android.graphics.Bitmap$Config.ARGB_8888
    }

    private void Mcea05811(string P0)
    {
        // str: "getString(...)"
        // str: "getContext(...)"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: DecryptString.decryptString
        // call: Resources.getDimension
        // call: p13136a72.getResources
        // call: pe20ed6fb$p910eef8c.m6a981d91
        // call: p13136a72.getContext
        // call: p13136a72.addView
        // call: Resources.getString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.intermediate_header_receipt_digital_copy
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_16
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_24
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c
    }

    private void Mee3a144a(string P0, string P1)
    {
        // str: "getString(...)"
        // str: "getResources(...)"
        // str: "getContext(...)"
        // call: Resources.getDimension
        // call: Intrinsics.checkNotNullExpressionValue
        // call: DecryptString.decryptString
        // call: p7667d148.m25ba5d03
        // call: pe20ed6fb$p910eef8c.createItem
        // call: p13136a72.getResources
        // call: Resources.getString
        // call: p13136a72.getContext
        // call: p13136a72.addView
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.intermediate_header_receipt_customer
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb.f910eef8c
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd.fc87f3be6
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_20
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_8
    }

    public object GetNoteView(string P0)
    {
        // str: "getContext(...)"
        // str: "getString(...)"
        // str: "note"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p13136a72.getContext
        // call: p0c1ae1b4$p910eef8c.m6a981d91
        // call: p13136a72.getResources
        // call: Intrinsics.checkNotNullParameter
        // call: Resources.getString
        // call: DecryptString.decryptString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.intermediate_header_title_note
        // field: p59a14a57.p1e11b989.pcaf9b6b9.p0c1ae1b4.f910eef8c
        return default!;
    }

    public float GetPaymentTypePaddingBottom()
    {
        // call: Resources.getDimension
        // call: p13136a72.getResources
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_padding_8
        return 0;
    }

    public float GetPaymentTypeTextSize()
    {
        // call: p13136a72.getResources
        // call: Resources.getDimension
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_text_size_20
        return 0;
    }

    public pe20ed6fb$p7e601cfd GetSubHeaderTypefaceStyle()
    {
        // field: p59a14a57.p1e11b989.pcaf9b6b9.pe20ed6fb$p7e601cfd.fc87f3be6
        return default!;
    }

    public void SetReceiptInfo(p8c261c90 P0, p5a409c20 P1, string P2, string P3, string P4, string P5, string P6, string P7, string P8)
    {
        // str: "getString(...)"
        // str: "paymentType"
        // str: "currency"
        // str: "operationType"
        // str: "subTotal"
        // call: Intrinsics.checkNotNullParameter
        // call: object.getString
        // call: p13136a72.getContext
        // call: p13136a72.setPaymentType
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p13136a72.mcea05811
        // call: p13136a72.setSubTotal
        // call: p13136a72.setNote
        // call: p13136a72.setDiscount
        // call: p13136a72.mee3a144a
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_position_discount
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.receipt_info_header_receipt_discount
    }

}
