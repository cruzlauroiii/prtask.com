namespace WillowMaze.Wasm.Decompiled;

public class P5f119d58 : P0742d3f9, P52e9d650
{
    private static object[] $$delegatedProperties;
    public static p5f119d58$p910eef8c F17942aea;
    public static p5f119d58$p910eef8c F910eef8c;
    private readonly peaca9a1b Binding$delegate;
    private readonly ReadWriteProperty IsBoarding$delegate;
    private readonly Lazy<object> LanguageSettingsViewModel$delegate;

    public static void M2bfdb6ea(p5f119d58 P0, List<object> P1, int P2, object P3)
    {
        // call: p5f119d58.m40756765
    }

    public static void M38421a92(p5f119d58 P0, object P1)
    {
        // call: p5f119d58.m9ba4fe43
    }

    private static void M40756765(p5f119d58 P0, List<object> P1, int P2, object P3)
    {
        // str: "it"
        // str: "null cannot be cast to non-null type android.app.Activity"
        // call: peec9a3f1.startSplash
        // call: p5f119d58.mb7a5ad6f
        // call: Intrinsics.checkNotNull
        // call: p5f119d58.getActivity
        // call: pf3d67c3a.getLocale
        // call: peec9a3f1.replaceLanguageSettings
        // call: peec9a3f1.selectLanguage
        // call: Intrinsics.checkNotNullParameter
        // call: p5f119d58.mab136eb9
        // call: List<object>.get
        // field: kotlin.Unit.INSTANCE
    }

    private void M8c963709()
    {
        // str: "inflate(...)"
        // str: "getRoot(...)"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pf9b5106e.getRoot
        // call: peec9a3f1.getLocales
        // call: pf3d67c3a.getLocaleName
        // call: ICollection<object>.size
        // call: p5f119d58.mbcff50b6
        // call: List<object>.get
        // call: LinearLayout.removeAllViews
        // call: p5f119d58.mb7a5ad6f
        // call: p5f119d58$pd41d8cd9$p95263d50.<init>
        // call: LinearLayout.addView
        // call: LayoutInflater.from
        // call: p5f119d58.getContext
        // call: pf5e18aff.m2fa6d087
        // call: pf9b5106e.m89daba64
        // call: TextView.setText
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.p4ae54c78.fa5f320a2
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.pf9b5106e.f0534626f
        // type: p5f119d58$pd41d8cd9$p95263d50
    }

    public static void M92860a80(p5f119d58 P0, bool P1)
    {
        // call: p5f119d58.me6be9c2c
    }

    private static void M9ba4fe43(p5f119d58 P0, object P1)
    {
        // call: p5f119d58.onBackPressed
    }

    private bool Mab136eb9()
    {
        // call: ReadWriteProperty.getValue
        // call: bool.booleanValue
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.isBoarding$delegate
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.$$delegatedProperties
        return false;
    }

    private peec9a3f1 Mb7a5ad6f()
    {
        // call: Lazy<object>.getValue
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.languageSettingsViewModel$delegate
        return default!;
    }

    private p4ae54c78 Mbcff50b6()
    {
        // call: peaca9a1b.getValue
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.binding$delegate
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.$$delegatedProperties
        return default!;
    }

    private void Me6be9c2c(bool P0)
    {
        // call: ReadWriteProperty.setValue
        // call: bool.valueOf
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.isBoarding$delegate
        // field: p2e5d8aa3.p2486923a.p8512ae7d.p5f119d58.$$delegatedProperties
    }

    public void OnBackPressed()
    {
        // call: peec9a3f1.openPreviousScreen
        // call: p5f119d58.mb7a5ad6f
    }

    public void OnViewCreated(object P0, Dictionary<string, object> P1)
    {
        // str: "view"
        // call: p5f119d58.m8c963709
        // call: Toolbar.setVisibility
        // call: p5f119d58.getString
        // call: Toolbar.setNavigationOnClickListener
        // call: p5f119d58$pd41d8cd9$pcca4ef0e.<init>
        // call: DecryptString.decryptString
        // call: p0742d3f9.onViewCreated
        // call: p5f119d58.mab136eb9
        // call: p5f119d58.mbcff50b6
        // call: Intrinsics.checkNotNullParameter
        // call: Toolbar.setTitle
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.p4ae54c78.ff50b3c2a
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_language
        // type: p5f119d58$pd41d8cd9$pcca4ef0e
    }

}
