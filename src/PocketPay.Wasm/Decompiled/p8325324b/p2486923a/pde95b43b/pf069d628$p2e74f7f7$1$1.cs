namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0006"}, d2 = {"sell/presentation/edit/EditSellReceiptobject$showBoarding$1$1", "Lp59a14a57/pc02fdf0f/p44573bc3;", "onCloseClick", "", "boardingReadResult", "Lpad5f82e8/p07214c67/pc02fdf0f/pf7eb354f;", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf069d628$p2e74f7f7$1$1 : p59a14a57.pc02fdf0f.p44573bc3 {
    readonly p8325324b.p2486923a.pde95b43b.pf069d628 this$0;

    pf069d628$p2e74f7f7$1$1(p8325324b.p2486923a.pde95b43b.pf069d628 pf069d628Var) {
        this.this$0 = pf069d628Var;
    }

    public override void OnCloseClick(pad5f82e8.p07214c67.pc02fdf0f.pf7eb354f boardingReadResult) {
        if ((32 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(boardingReadResult, "boardingReadResult");
        p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f9aba3abc.setVisibility(8);
        android.view.object viewMf1737ab7 = p8325324b.p2486923a.pde95b43b.pf069d628.mf1737ab7(this.this$0);
        if (viewMf1737ab7 is not null) {
            viewMf1737ab7.setBackgroundColor(androidx.core.content.objectCompat.getColor(this.this$0.requireobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$color.color_background));
        }
        p8325324b.p2486923a.pde95b43b.pf069d628.mc525a331(this.this$0).setShowNoteBoarding();
    }
}

