namespace WillowMaze.Wasm.Decompiled;

public class P300f4ed1 : P0742d3f9
{
    private static object[] $$delegatedProperties;
    private readonly Lazy<object> AccountNotFoundViewModel$delegate;
    private readonly peaca9a1b Binding$delegate;

    public static void M2f06d2d0(p300f4ed1 P0, object P1)
    {
        // call: p300f4ed1.m30f6522b
    }

    private static void M30f6522b(p300f4ed1 P0, object P1)
    {
        // str: "it"
        // call: p300f4ed1.m34d42d94
        // call: ped219d43.returnToPhone
        // call: Intrinsics.checkNotNullParameter
        // field: kotlin.Unit.INSTANCE
    }

    private ped219d43 M34d42d94()
    {
        // call: Lazy<object>.getValue
        // field: p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1.accountNotFoundViewModel$delegate
        return default!;
    }

    private static void M9ba4fe43(p300f4ed1 P0, object P1)
    {
        // call: p300f4ed1.onBackPressed
    }

    private pceb4142e Mbcff50b6()
    {
        // call: peaca9a1b.getValue
        // field: p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1.binding$delegate
        // field: p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1.$$delegatedProperties
        return default!;
    }

    public static void Mc5a5b9a5(p300f4ed1 P0, object P1)
    {
        // call: p300f4ed1.m9ba4fe43
    }

    private void Mdb1edd3f()
    {
        // call: ped219d43.getUserPhone
        // call: p300f4ed1.mbcff50b6
        // call: string.format
        // call: DecryptString.decryptString
        // call: TextView.setText
        // call: p300f4ed1.getString
        // call: p300f4ed1.m34d42d94
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.pceb4142e.fe28d7fe3
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.cashier_not_found_desc
    }

    public void OnBackPressed()
    {
        // call: ped219d43.openPreviousScreen
        // call: p300f4ed1.m34d42d94
    }

    public void OnViewCreated(object P0, Dictionary<string, object> P1)
    {
        // str: "btnReturnToPhone"
        // str: "view"
        // call: p300f4ed1$pd41d8cd9$p95263d50.<init>
        // call: DecryptString.decryptString
        // call: p0742d3f9.onViewCreated
        // call: Button.setText
        // call: p300f4ed1.mdb1edd3f
        // call: p300f4ed1$pd41d8cd9$pcca4ef0e.<init>
        // call: Toolbar.setNavigationOnClickListener
        // call: p300f4ed1.mbcff50b6
        // call: Intrinsics.checkNotNullParameter
        // call: pf5e18aff.m2fa6d087
        // call: Toolbar.setTitle
        // call: p300f4ed1.getString
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.pceb4142e.ff50b3c2a
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.cashier_not_found_return_to_phone
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.pceb4142e.fbf2be00d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.cashier_not_found_title
        // type: p300f4ed1$pd41d8cd9$pcca4ef0e
        // type: p300f4ed1$pd41d8cd9$p95263d50
    }

}
