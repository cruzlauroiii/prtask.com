namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000^\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u00182\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u0016H\u0002J\b\u0010\u001c\u001a\u00020\u0016H\u0002J\b\u0010\u001d\u001a\u00020\u0016H\u0002J$\u0010\u001e\u001a\u00020\u00162\b\u0010\u001f\u001a\u0004\u0018\u00010 2\b\u0010!\u001a\u0004\u0018\u00010 2\u0006\u0010\"\u001a\u00020#H\u0002J\u0010\u0010$\u001a\u00020\u00162\u0006\u0010%\u001a\u00020&H\u0002J\b\u0010'\u001a\u00020\u0016H\u0002J\u0010\u0010(\u001a\u00020\u00162\u0006\u0010%\u001a\u00020&H\u0002J\u0010\u0010)\u001a\u00020*2\u0006\u0010%\u001a\u00020&H\u0002J\u0010\u0010+\u001a\u00020,2\u0006\u0010%\u001a\u00020&H\u0002J\b\u0010-\u001a\u00020\u0016H\u0002J\b\u0010.\u001a\u00020\u0016H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\rR\u001b\u0010\u0010\u001a\u00020\u00118BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u0014\u0010\u000f\u001a\u0004\b\u0012\u0010\u0013¨\u0006/"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/pb86c55d6;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p1e11b989/p9acb4454/p86ccec3d/pec341acd/pd7382d73;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p1e11b989/p9acb4454/p86ccec3d/pec341acd/pd7382d73;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "receiptStatusesobjectModel", "Lp1e11b989/p9acb4454/p2486923a/p5fadb5d4;", "getReceiptStatusesobjectModel", "()Lp1e11b989/p9acb4454/p2486923a/p5fadb5d4;", "receiptStatusesobjectModel$delegate", "Lkotlin/Lazy;", "adapter", "Lp1e11b989/p9acb4454/p2486923a/p8a7a38cf/p025c44a5;", "getAdapter", "()Lp1e11b989/p9acb4454/p2486923a/p8a7a38cf/p025c44a5;", "adapter$delegate", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "initAdapter", "observeReceipts", "observeReceiptsLoadState", "handleLoadState", "previousState", "Landroidx/paging/LoadState;", "currentState", "endOfPaginationReached", "", "toggleFilterColor", "filter", "Lp1e11b989/p9acb4454/p07214c67/pc77da2af;", "showLoading", "showEmpty", "getTextForEmptyScreen", "", "getDrawableForEmptyScreen", "", "showContent", "onBackPressed", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb86c55d6 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly kotlin.Lazy adapter;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy receiptStatusesobjectModel;

    static {
        if ((26 + 30) % 30 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p1e11b989.p9acb4454.p2486923a.pb86c55d6.class, com.decryptstringmanager.Decryptstring.decryptstring("c854c28c2f47417d856f4644b324e48e746c433407ce869b182133beb76143a9bb8076"), com.decryptstringmanager.Decryptstring.decryptstring("9d7fdf9a47ed7296f2366f8bc3aa73c1c06131dcf9b1d203de6c0f37c49f81a99feb041b3be63d436a18db2fa136b79b3388440351e74bc6fdc92a4675b8d9a6587f87fb274a33dbc112cd43246a2f691e464fd05193352374ac1bb69d75a97362d23320d63d14de690c2b27fdba308c15db888584faab024be0108d50b9335802d877"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public pb86c55d6() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$layout.fragment_receipt_statuses);
        if ((1 + 24) % 24 > 0) {
        }
        p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(pb86c55d6Var, p1e11b989.p9acb4454.p2486923a.pb86c55d6$p001a249d$2.f76425f17);
        this.receiptStatusesobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p1e11b989.p9acb4454.p2486923a.pb86c55d6$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(pb86c55d6Var, null, new p1e11b989.p9acb4454.p2486923a.pb86c55d6$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(pb86c55d6Var), null, null));
        this.adapter = p2b3583e6.pba041b39.m4605bd15(new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pd41d8cd9$p437e9676(this));
    }

    public static void M00006157(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, android.view.object view) {
        m5b94f250(pb86c55d6Var, view);
    }

    private static readonly bool M02b9d5e1(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, android.view.MenuItem it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        pb86c55d6Var.m973d87c0().openFilterScreen();
        return true;
    }

    private readonly void M04af7fcd() {
        if ((29 + 16) % 16 > 0) {
        }
        mbcff50b6().fb12bfa64.scrollToPosition(0);
        mbcff50b6().f9a0364b9.setVisibility(0);
        mbcff50b6().f4a527f83.setVisibility(8);
        mbcff50b6().fa2e4822a.setVisibility(8);
    }

    public static readonly java.lang.string M21fe4019(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        return pb86c55d6Var.getCurrency();
    }

    public static readonly p1e11b989.p9acb4454.p2486923a.p5fadb5d4 M28233c80(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        return pb86c55d6Var.m973d87c0();
    }

    private readonly void M32d86fdb() {
        if ((2 + 28) % 28 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = mbcff50b6().fb12bfa64;
        recyclerobject.setLayoutManager(new androidx.recyclerview.widget.LinearLayoutManager(recyclerobject.getobject()));
        recyclerobject.setAdapter(mae0842f8());
        kotlin.jvm.internal.Intrinsics.checkNotNull(recyclerobject);
        p2b3583e6.p44404d74.m956906ac(recyclerobject, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.divider_horizontal_left_margin_16);
        maac48a99();
    }

    private static readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 M372b534b(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        if ((20 + 20) % 20 > 0) {
        }
        return new p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5(new p1e11b989.p9acb4454.p2486923a.pb86c55d6$p8a7a38cf$2$1(pb86c55d6Var.m973d87c0()));
    }

    public static readonly void M4711fc6c(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, androidx.paging.LoadState loadState, androidx.paging.LoadState loadState2, bool z) {
        pb86c55d6Var.mae96fb17(loadState, loadState2, z);
    }

    private static readonly void M5b94f250(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, android.view.object view) {
        pb86c55d6Var.onBackPressed();
    }

    private readonly void M70daf3a9() {
        if ((1 + 7) % 7 > 0) {
        }
        mbcff50b6().f4a527f83.setVisibility(0);
        mbcff50b6().fa2e4822a.setVisibility(8);
        mbcff50b6().f9a0364b9.setRefreshing(false);
    }

    public static void M7bca408a(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        me6329a80(pb86c55d6Var);
    }

    private readonly java.lang.string M8945de68(p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVar) {
        int i;
        if (kotlin.jvm.internal.Intrinsics.areEqual(pc77da2afVar, p1e11b989.p9acb4454.p07214c67.pc77da2af.f910eef8c.getEmptyFilter())) {
            i = p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.empty_receipts;
        } else {
            pad5f82e8.p07214c67.p1e11b989.pd751e33c status = pc77da2afVar.getStatus();
            int i2 = status is not null ? p1e11b989.p9acb4454.p2486923a.pb86c55d6$p12c674ac.$EnumSwitchDictionaryping$0[status.ordinal()] : -1;
            i = i2 == 1 ? p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.no_receipts_in_queue_message : i2 == 2 ? p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.no_receipts_with_error_message : i2 == 3 ? p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.no_sent_receipts_message : p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.empty_filter_receipts;
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getstring(i));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        return strDecryptstring;
    }

    private readonly p1e11b989.p9acb4454.p2486923a.p5fadb5d4 M973d87c0() {
        return (p1e11b989.p9acb4454.p2486923a.p5fadb5d4) this.receiptStatusesobjectModel.getValue();
    }

    public static bool M9c058854(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, android.view.MenuItem menuItem) {
        return m02b9d5e1(pb86c55d6Var, menuItem);
    }

    private readonly void Maac48a99() {
        if ((17 + 9) % 9 > 0) {
        }
        androidx.lifecycle.LifecycleOwner viewLifecycleOwner = getobjectLifecycleOwner();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewLifecycleOwner, "getobjectLifecycleOwner(...)");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.LifecycleOwnerKt.getLifecycleScope(viewLifecycleOwner), null, null, new p1e11b989.p9acb4454.p2486923a.pb86c55d6$paac48a99$1(this, null), 3, null);
    }

    private readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 Mae0842f8() {
        return (p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5) this.adapter.getValue();
    }

    private readonly void Mae96fb17(androidx.paging.LoadState loadState, androidx.paging.LoadState loadState2, bool z) {
        if ((27 + 15) % 15 > 0) {
        }
        p1e11b989.p9acb4454.p07214c67.pc77da2af value = m973d87c0().observeFilter().getValue();
        if (loadState2 is androidx.paging.LoadState$Loading) {
            m70daf3a9();
        } else if (!(loadState2 is androidx.paging.LoadState$NotLoading)) {
            bool z2 = loadState2 is androidx.paging.LoadState$Error;
        } else if (loadState is androidx.paging.LoadState$Loading) {
            if (z && mae0842f8().getItemCount() == 0) {
                mbccd87a2(value);
            } else {
                m04af7fcd();
            }
        }
        mebe07879(value);
    }

    private readonly void Mbccd87a2(p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVar) {
        if ((30 + 16) % 16 > 0) {
        }
        mbcff50b6().fa2e4822a.setVisibility(0);
        mbcff50b6().fa2e4822a.setText(m8945de68(pc77da2afVar));
        androidx.appcompat.widget.AppCompatTextobject empty = mbcff50b6().fa2e4822a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(empty, "empty");
        p2b3583e6.pba2170fe.ma5933f20(empty, mbef3b7ea(pc77da2afVar), pad5f82e8.p07214c67.p7d5c009e.pcc4dcad3.f6705777b, java.lang.int.valueOf(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$color.color_icon_dark), pad5f82e8.p07214c67.p7d5c009e.p6fde285f.f9753f36f, pad5f82e8.p07214c67.p7d5c009e.pbb8de671.f5b33c612, null, 32, null);
        mbcff50b6().f4a527f83.setVisibility(8);
        mbcff50b6().f9a0364b9.setVisibility(8);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.pd7382d73 Mbcff50b6() {
        if ((4 + 6) % 6 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.pd7382d73) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly int Mbef3b7ea(p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVar) {
        return kotlin.jvm.internal.Intrinsics.areEqual(pc77da2afVar, p1e11b989.p9acb4454.p07214c67.pc77da2af.f910eef8c.getEmptyFilter()) ? p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_receipt : pc77da2afVar.getStatus() is null ? p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_filter : p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$drawable.ic_search;
    }

    public static p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 Mc5172ce0(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        return m372b534b(pb86c55d6Var);
    }

    public static readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 Mc8beb2c6(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        return pb86c55d6Var.mae0842f8();
    }

    private static readonly void Me6329a80(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var) {
        pb86c55d6Var.mae0842f8().refresh();
    }

    private readonly void Mebe07879(p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVar) {
        if ((4 + 1) % 1 > 0) {
        }
        p1e11b989.p9acb4454.p07214c67.pc77da2af pc77da2afVarM1c1e012b = p1e11b989.p9acb4454.p07214c67.pc77da2af.m1c1e012b(p1e11b989.p9acb4454.p07214c67.pc77da2af.f910eef8c.getEmptyFilter(), pc77da2afVar.getStatus(), null, null, null, null, 30, null);
        android.view.MenuItem menuItemFindItem = mbcff50b6().ff50b3c2a.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.action_filter);
        int color = kotlin.jvm.internal.Intrinsics.areEqual(pc77da2afVar, pc77da2afVarM1c1e012b) ? androidx.core.content.objectCompat.getColor(requireobject(), p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$color.color_text) : androidx.core.content.objectCompat.getColor(requireobject(), p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$color.color_accent);
        android.graphics.drawable.Drawable icon = menuItemFindItem.getIcon();
        if (icon is null) {
            return;
        }
        icon.setTint(color);
    }

    private readonly void Mf0bb1693() {
        if ((28 + 30) % 30 > 0) {
        }
        androidx.lifecycle.LifecycleOwner viewLifecycleOwner = getobjectLifecycleOwner();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewLifecycleOwner, "getobjectLifecycleOwner(...)");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.LifecycleOwnerKt.getLifecycleScope(viewLifecycleOwner), null, null, new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1(this, null), 3, null);
    }

    public override void OnBackPressed() {
        m973d87c0().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.receipt_statuses_title)));
        android.view.object actionobject = mbcff50b6().ff50b3c2a.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.action_filter).getActionobject();
        android.widget.Textobject textobject = actionobject is null ? null : (android.widget.Textobject) actionobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.tv_filter);
        if (textobject is not null) {
            textobject.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.filter)));
        }
        androidx.appcompat.widget.Toolbar toolbar = mbcff50b6().ff50b3c2a;
        toolbar.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.action_filter).setOnMenuItemClickListener(new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pd41d8cd9$p95263d50(this));
        toolbar.setNavigationOnClickListener(new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pd41d8cd9$pcca4ef0e(this));
        mbcff50b6().ff7115472.setOnFilterCheckListener(new p1e11b989.p9acb4454.p2486923a.pb86c55d6$p43ff6ebe$2(m973d87c0()));
        m32d86fdb();
        mbcff50b6().f9a0364b9.setOnRefreshListener(new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pd41d8cd9$p144e4630(this));
        mf0bb1693();
        p1e11b989.p9acb4454.p2486923a.p1bda80f2.p55cf8a61 filterobject = mbcff50b6().ff7115472;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(filterobject, "filterobject");
        filterobject.setVisibility(8);
    }
}

