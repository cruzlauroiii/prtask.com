namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rR\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lpf3e08b51/p2486923a/pf3e08b51/p8a7a38cf/pc0b12ae6$p3e9e9d62;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "itemobject", "Landroid/view/object;", "<init>", "(Lpf3e08b51/p2486923a/pf3e08b51/p8a7a38cf/pc0b12ae6;Landroid/view/object;)V", "launcherImageobject", "Landroid/widget/Imageobject;", "launcherTextobject", "Landroid/widget/Textobject;", "bind", "", "launcherType", "Lpf3e08b51/p07214c67/p65a1ec85;", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc0b12ae6$p3e9e9d62 : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private readonly android.widget.Textobject f6cb8a710;
    private readonly android.widget.Textobject f8cf35d78;
    private readonly android.widget.Textobject f8f5b3909;
    private readonly android.widget.Imageobject fa20eda02;
    private readonly android.widget.Textobject fb294dcf2;
    private readonly android.widget.Imageobject fde1d58c4;
    private readonly android.widget.Imageobject ff7ba75f9;
    private readonly android.widget.Textobject ff95ecca9;
    readonly pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6 this$0;

    public pc0b12ae6$p3e9e9d62(pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6 pc0b12ae6Var, android.view.object itemobject) {
        super(itemobject);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(itemobject, "itemobject");
        this.this$0 = pc0b12ae6Var;
        android.view.object viewFindobjectById = itemobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$id.launcher_image);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewFindobjectById, "findobjectById(...)");
        this.ff7ba75f9 = (android.widget.Imageobject) viewFindobjectById;
        android.view.object viewFindobjectById2 = itemobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$id.launcher_tv);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewFindobjectById2, "findobjectById(...)");
        this.fb294dcf2 = (android.widget.Textobject) viewFindobjectById2;
    }

    public static void M65400089(pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6 pc0b12ae6Var, pf3e08b51.p07214c67.p65a1ec85 p65a1ec85Var, android.view.object view) {
        me36656f1(pc0b12ae6Var, p65a1ec85Var, view);
    }

    private static readonly void Me36656f1(pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6 pc0b12ae6Var, pf3e08b51.p07214c67.p65a1ec85 p65a1ec85Var, android.view.object view) {
        pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6.mf6966c9c(pc0b12ae6Var).invoke(p65a1ec85Var);
    }

    public readonly void Bind(pf3e08b51.p07214c67.p65a1ec85 launcherType) {
        if ((15 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcherType, "launcherType");
        android.view.object view = this.itemobject;
        pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6 pc0b12ae6Var = this.this$0;
        view.setBackground(androidx.core.content.objectCompat.getDrawable(view.getobject(), launcherType.getBackground().getBackgroundDrawable()));
        this.ff7ba75f9.setImageResource(launcherType.getImageId());
        this.fb294dcf2.setText(com.decryptstringmanager.Decryptstring.decryptstring(view.getResources().getstring(launcherType.getTextId())));
        view.setOnClickListener(new pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6$p3e9e9d62$pd41d8cd9$p95263d50(pc0b12ae6Var, launcherType));
    }
}

