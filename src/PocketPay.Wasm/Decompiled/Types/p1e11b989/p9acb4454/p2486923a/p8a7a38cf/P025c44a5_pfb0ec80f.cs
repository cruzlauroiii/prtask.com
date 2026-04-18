namespace WillowMaze.Wasm.Decompiled;

public class P025c44a5_pfb0ec80f : RecyclerView$ViewHolder
{
    private readonly p30c7a4d5 F001a249d;
    private readonly StringBuilder F3a1f3b24;
    private readonly p30c7a4d5 F942b0805;
    private readonly StringBuilder Fc943dc2c;
    private readonly p30c7a4d5 Ffd8f2118;
    private readonly p025c44a5 This$0;

    private string M2c568eac(p9ded6185 P0)
    {
        // str: "toString(...)"
        // call: object.getResources
        // call: Resources.getString
        // call: StringBuilder.append
        // call: CollectionsKt.throwIndexOverflow
        // call: IEnumerable<object>.iterator
        // call: pd031d465.getName
        // call: StringsKt.clear
        // call: List<object>.size
        // call: Intrinsics.checkNotNullExpressionValue
        // call: object.getContext
        // call: DecryptString.decryptString
        // call: p9ded6185.getPositions
        // call: IEnumerator<object>.next
        // call: StringBuilder.toString
        // call: IEnumerator<object>.hasNext
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f.f3a1f3b24
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f.itemView
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_position_name_separator
        return string.Empty;
    }

    private string M31fcd72a(object P0, p9ded6185 P1)
    {
        // str: "getString(...)"
        // str: "c18a927ec983e0e1bb7086bf2ea82fe39693327f90c05b4a7252d5dfda6bad254f3d4d"
        // call: DecryptString.decryptString
        // call: p9ded6185.getReceiptNumber
        // call: p9ded6185.getCreationDate
        // call: string.format
        // call: CultureInfo.getDefault
        // call: string.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: long.valueOf
        // call: DateTime.getTime
        // call: object.getString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_number_template
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_number_and_date_template
        // type: string
        return string.Empty;
    }

    private static void M564ec725(p025c44a5 P0, p9ded6185 P1, object P2)
    {
        // call: p025c44a5.mb4a05d1c
        // call: Func<object, object>.invoke
    }

    public static void Ma18017f7(p025c44a5 P0, p9ded6185 P1, object P2)
    {
        // call: p025c44a5$pfb0ec80f.m564ec725
    }

    private int Mb2950d61(p8c261c90 P0)
    {
        // call: p8c261c90.ordinal
        // call: NoWhenBranchMatchedException.<init>
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_qr_pay
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_cash
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_phone
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_combo
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f$p12c674ac.$EnumSwitchMapping$1
        // type: NoWhenBranchMatchedException
        return 0;
    }

    private string Mf327d659(object P0, p9ded6185 P1, string P2)
    {
        // str: "getResources(...)"
        // call: object.getResources
        // call: p517b902b.m29a3256d
        // call: p7667d148.m3916939b
        // call: Intrinsics.checkNotNullExpressionValue
        return string.Empty;
    }

    private int Mfc02277c(pd751e33c P0)
    {
        // call: pd751e33c.ordinal
        // call: NoWhenBranchMatchedException.<init>
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f$p12c674ac.$EnumSwitchMapping$0
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.circle_transparent
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_receipt_error_status
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_receipt_in_queue_status
        // type: NoWhenBranchMatchedException
        return 0;
    }

    public void Bind(p9ded6185 P0)
    {
        // str: "receipt"
        // str: "getContext(...)"
        // call: TextView.getContext
        // call: p30c7a4d5.getRoot
        // call: object.getString
        // call: DecryptString.decryptString
        // call: TextView.setText
        // call: p025c44a5$pfb0ec80f.mf327d659
        // call: LinearLayout.getContext
        // call: p025c44a5$pfb0ec80f.mb2950d61
        // call: p9ded6185.getPaymentType
        // call: TextView.setVisibility
        // call: LinearLayout.setOnClickListener
        // call: p9ded6185.getStatus
        // call: TextView.setTextColor
        // call: p025c44a5$pfb0ec80f$pd41d8cd9$p95263d50.<init>
        // call: ContextCompat.getColor
        // call: pd751e33c.ordinal
        // call: p025c44a5$pfb0ec80f.mfc02277c
        // call: pde39a00a.initView
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f.f001a249d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5.fd627b35c
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5.f368adc74
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f$p12c674ac.$EnumSwitchMapping$0
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5.f957bdd04
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5.ffc23de21
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$color.color_text
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_payback
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f.this$0
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5.f3373b6b4
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$color.color_error
        // type: p025c44a5$pfb0ec80f$pd41d8cd9$p95263d50
    }

}
