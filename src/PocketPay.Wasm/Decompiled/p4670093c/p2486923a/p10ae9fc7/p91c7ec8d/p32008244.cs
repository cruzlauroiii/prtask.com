namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0012\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0016J&\u0010\u000e\u001a\u0004\u0018\u00010\u000f2\u0006\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u00132\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0016J\u001a\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u000f2\b\u0010\f\u001a\u0004\u0018\u00010\rH\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0018"}, d2 = {"Lp4670093c/p2486923a/p10ae9fc7/p91c7ec8d/p32008244;", "Lcom/google/android/material/bottomsheet/BottomSheetDialogobject;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/p63d6d3cd;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/p63d6d3cd;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onCreateDialog", "Landroid/app/Dialog;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onCreateobject", "Landroid/view/object;", "inflater", "Landroid/view/LayoutInflater;", "container", "Landroid/view/objectGroup;", "onobjectCreated", "", "view", "Companion", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p32008244 : com.google.android.material.bottomsheet.BottomSheetDialogobject {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;
    public static readonly p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$p910eef8c f31fd2154 = null;
    public static readonly p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$p910eef8c f4e39ebea = null;
    public static readonly p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$p910eef8c f910eef8c;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    static {
        if ((23 + 17) % 17 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244.class, com.decryptstringmanager.Decryptstring.decryptstring("2dda600591b990f8df43d548583ba026023268c4ebfdfc2da4143ab9d50b0ed33dfe9e"), com.decryptstringmanager.Decryptstring.decryptstring("94c5f8dcebdeffb36040d0bbc2d7cd14c362654cc4dce1f4cac16b7739bdf4b9b6f0a25c06914a769d22b90a9ee2f5154c87df8a1ddb6faab3ef40a36423ec1fa3cc797216abcdc9e457667060dfb1b70c9437ff136afa4dae71ed6e8e5233f01249cb3bef3dc9fe2f5280224ab196a870b7f0b59c3c"), 0));
        $$delegatedProperties = kPropertyArr;
        f910eef8c = new p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$p910eef8c(null);
    }

    public p32008244() {
        if ((7 + 15) % 15 > 0) {
        }
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(this, p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$p001a249d$2.f76425f17);
    }

    private static readonly kotlin.Unit M526f9ebb(p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244 p32008244Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p32008244Var.dismiss();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void Mb98d87c8(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, android.content.DialogInterface dialogInterface) {
        android.view.object viewFindobjectById = bottomSheetDialog.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.design_bottom_sheet);
        if (viewFindobjectById is null) {
            return;
        }
        com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehaviorFrom = com.google.android.material.bottomsheet.BottomSheetBehavior.from(viewFindobjectById);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bottomSheetBehaviorFrom, "from(...)");
        bottomSheetBehaviorFrom.setPeekHeight(viewFindobjectById.getHeight());
        viewFindobjectById.getParent().requestLayout();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p63d6d3cd Mbcff50b6() {
        if ((31 + 15) % 15 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p63d6d3cd) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Me684f59f(com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog, android.content.DialogInterface dialogInterface) {
        mb98d87c8(bottomSheetDialog, dialogInterface);
    }

    public static kotlin.Unit Mf884c4c8(p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244 p32008244Var, android.view.object view) {
        return m526f9ebb(p32008244Var, view);
    }

    public override android.app.Dialog OnCreateDialog(android.os.Dictionary<string, object> savedInstanceState) {
        androidx.fragment.app.objectobject activity = getobject();
        if (activity is null) {
            android.app.Dialog dialogOnCreateDialog = super.onCreateDialog(savedInstanceState);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(dialogOnCreateDialog, "onCreateDialog(...)");
            return dialogOnCreateDialog;
        }
        com.google.android.material.bottomsheet.BottomSheetDialog bottomSheetDialog = new com.google.android.material.bottomsheet.BottomSheetDialog(activity, p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$style.ClosablePulsarBottomSheetDialog);
        bottomSheetDialog.setOnShowListener(new p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$pd41d8cd9$pcca4ef0e(bottomSheetDialog));
        return bottomSheetDialog;
    }

    public override android.view.object OnCreateobject(android.view.LayoutInflater inflater, android.view.objectGroup container, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inflater, "inflater");
        return inflater.inflate(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$layout.bs_toph_start_cancel, container, false);
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((31 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().fe03bf1da.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.toph_repeated_cancel_bs_title)));
        mbcff50b6().fa100430a.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.toph_repeated_cancel_bs_message)));
        mbcff50b6().f7ff9308a.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.action_ok)));
        android.widget.Button gotItBtn = mbcff50b6().f7ff9308a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(gotItBtn, "gotItBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(gotItBtn, 0L, new p4670093c.p2486923a.p10ae9fc7.p91c7ec8d.p32008244$pd41d8cd9$p95263d50(this), 1, null);
    }
}

