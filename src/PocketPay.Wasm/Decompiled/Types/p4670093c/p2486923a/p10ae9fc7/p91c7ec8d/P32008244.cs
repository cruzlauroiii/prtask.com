namespace WillowMaze.Wasm.Decompiled;

public class P32008244 : BottomSheetDialogFragment
{
    private static object[] $$delegatedProperties;
    public static p32008244$p910eef8c F31fd2154;
    public static p32008244$p910eef8c F4e39ebea;
    public static p32008244$p910eef8c F910eef8c;
    private readonly peaca9a1b Binding$delegate;

    private static void M526f9ebb(p32008244 P0, object P1)
    {
        // str: "it"
        // call: Intrinsics.checkNotNullParameter
        // call: p32008244.dismiss
        // field: kotlin.Unit.INSTANCE
    }

    private static void Mb98d87c8(BottomSheetDialog P0, DialogInterface P1)
    {
        // str: "from(...)"
        // call: BottomSheetBehavior.setPeekHeight
        // call: ViewParent.requestLayout
        // call: object.getParent
        // call: BottomSheetDialog.findViewById
        // call: BottomSheetBehavior.from
        // call: object.getHeight
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.design_bottom_sheet
    }

    private p63d6d3cd Mbcff50b6()
    {
        // call: peaca9a1b.getValue
        // field: p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244.$$delegatedProperties
        // field: p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244.binding$delegate
        return default!;
    }

    public static void Me684f59f(BottomSheetDialog P0, DialogInterface P1)
    {
        // call: p32008244.mb98d87c8
    }

    public static void Mf884c4c8(p32008244 P0, object P1)
    {
        // call: p32008244.m526f9ebb
    }

    public Dialog OnCreateDialog(Dictionary<string, object> P0)
    {
        // str: "onCreateDialog(...)"
        // call: BottomSheetDialog.<init>
        // call: BottomSheetDialog.setOnShowListener
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p32008244.getActivity
        // call: BottomSheetDialogFragment.onCreateDialog
        // call: p32008244$pd41d8cd9$pcca4ef0e.<init>
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$style.ClosablePulsarBottomSheetDialog
        // type: p32008244$pd41d8cd9$pcca4ef0e
        // type: BottomSheetDialog
        return default!;
    }

    public object OnCreateView(LayoutInflater P0, ViewGroup P1, Dictionary<string, object> P2)
    {
        // str: "inflater"
        // call: Intrinsics.checkNotNullParameter
        // call: LayoutInflater.inflate
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$layout.bs_toph_start_cancel
        return default!;
    }

    public void OnViewCreated(object P0, Dictionary<string, object> P1)
    {
        // str: "gotItBtn"
        // str: "view"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p32008244.mbcff50b6
        // call: DecryptString.decryptString
        // call: BottomSheetDialogFragment.onViewCreated
        // call: Intrinsics.checkNotNullParameter
        // call: p32008244.getString
        // call: TextView.setText
        // call: Button.setText
        // call: p32008244$pd41d8cd9$p95263d50.<init>
        // call: pf5e18aff.m2fa6d087
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p63d6d3cd.fa100430a
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p63d6d3cd.fe03bf1da
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.action_ok
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p63d6d3cd.f7ff9308a
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.toph_repeated_cancel_bs_title
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.toph_repeated_cancel_bs_message
        // type: p32008244$pd41d8cd9$p95263d50
    }

}
