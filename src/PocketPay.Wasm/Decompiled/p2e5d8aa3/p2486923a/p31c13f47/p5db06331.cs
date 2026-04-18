namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\u0010\u0010\u0016\u001a\u00020\u00112\u0006\u0010\u0017\u001a\u00020\u0018H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\b\u0010\u001b\u001a\u00020\u0011H\u0002J\b\u0010\u001c\u001a\u00020\u0011H\u0002J\b\u0010\u001d\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001e"}, d2 = {"Lp2e5d8aa3/p2486923a/p31c13f47/p5db06331;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p2e5d8aa3/p86ccec3d/pec341acd/pfd8b0c2d;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p2e5d8aa3/p86ccec3d/pec341acd/pfd8b0c2d;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lp2e5d8aa3/p2486923a/p31c13f47/pf460c609;", "getobjectModel", "()Lp2e5d8aa3/p2486923a/p31c13f47/pf460c609;", "viewModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "selectInventoryDesign", "type", "Lp2e5d8aa3/pf5e638cc/pe95cecb3;", "onInventoryListSelected", "onInventoryBigSelected", "onInventorySmallSelected", "unselectInventoryDesign", "onBackPressed", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5db06331 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((12 + 27) % 27 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p2e5d8aa3.p2486923a.p31c13f47.p5db06331.class, com.decryptstringmanager.Decryptstring.decryptstring("e179e0bd981d9f7059d10a853853cdcb07e819f3addac83b250145ec617aa2ce73b897"), com.decryptstringmanager.Decryptstring.decryptstring("5582eb4bdbfc7fdefd53e0f549177a461af914cf858afe6c272b55b2f410b7a210eabfa6daa55e45a8b2693330e9e8e345f40c7aac4f694c4d70c04a7ad5bde908e0880c396b8c551c1c4cd22fdb10197a9d9504538acd19625bb4f23c83cce34de73fcf17dddf48a458d436e03e7cd79334f14d8967446db58da321f39b"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p5db06331() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$layout.fragment_design);
        if ((2 + 18) % 18 > 0) {
        }
        p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p5db06331Var, p2e5d8aa3.p2486923a.p31c13f47.p5db06331$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p2e5d8aa3.p2486923a.p31c13f47.p5db06331$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p5db06331Var, null, new p2e5d8aa3.p2486923a.p31c13f47.p5db06331$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p5db06331Var), null, null));
    }

    public static kotlin.Unit M1806c238(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object view) {
        return m526f9ebb(p5db06331Var, view);
    }

    public static void M2415ef73(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object view) {
        m9ba4fe43(p5db06331Var, view);
    }

    private static readonly kotlin.Unit M30f6522b(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p5db06331Var.m8aa184d7(p2e5d8aa3.pf5e638cc.pe95cecb3.f298cb254);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M4f32f367(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object view) {
        return me6329a80(p5db06331Var, view);
    }

    private static readonly kotlin.Unit M526f9ebb(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p5db06331Var.m8aa184d7(p2e5d8aa3.pf5e638cc.pe95cecb3.f4c42c575);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M577f8ba3(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object view) {
        return m30f6522b(p5db06331Var, view);
    }

    private readonly void M79fb282c() {
        if ((28 + 3) % 3 > 0) {
        }
        mbcff50b6().fe1560596.check(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.inventoryBigRb);
        mbcff50b6().f2069bc58.setSelected(true);
        mbcff50b6().f5b155153.setImageResource(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$drawable.ic_inventory_big_preview);
    }

    private readonly void M7d8319e0() {
        if ((25 + 31) % 31 > 0) {
        }
        mbcff50b6().f2c29f045.setSelected(false);
        mbcff50b6().f2069bc58.setSelected(false);
        mbcff50b6().f71ba9d4b.setSelected(false);
        mbcff50b6().fe1560596.clearCheck();
    }

    private readonly void M8aa184d7(p2e5d8aa3.pf5e638cc.pe95cecb3 pe95cecb3Var) {
        if ((9 + 11) % 11 > 0) {
        }
        m7d8319e0();
        int i = p2e5d8aa3.p2486923a.p31c13f47.p5db06331$p12c674ac.$EnumSwitchDictionaryping$0[pe95cecb3Var.ordinal()];
        if (i == 1) {
            mefbb442c();
        } else if (i == 2) {
            m79fb282c();
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            mc38dc08a();
        }
        mac404cc3().selectInventoryDesign(pe95cecb3Var);
    }

    private static readonly void M9ba4fe43(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object view) {
        p5db06331Var.onBackPressed();
    }

    private readonly p2e5d8aa3.p2486923a.p31c13f47.pf460c609 Mac404cc3() {
        return (p2e5d8aa3.p2486923a.p31c13f47.pf460c609) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.pfd8b0c2d Mbcff50b6() {
        if ((17 + 10) % 10 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.pfd8b0c2d) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly void Mc38dc08a() {
        if ((26 + 15) % 15 > 0) {
        }
        mbcff50b6().fe1560596.check(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.inventorySmallRb);
        mbcff50b6().f71ba9d4b.setSelected(true);
        mbcff50b6().f5b155153.setImageResource(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$drawable.ic_inventory_small_preview);
    }

    private static readonly kotlin.Unit Me6329a80(p2e5d8aa3.p2486923a.p31c13f47.p5db06331 p5db06331Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p5db06331Var.m8aa184d7(p2e5d8aa3.pf5e638cc.pe95cecb3.f9a474768);
        return kotlin.Unit.INSTANCE;
    }

    private readonly void Mefbb442c() {
        if ((22 + 29) % 29 > 0) {
        }
        mbcff50b6().fe1560596.check(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.inventoryListRb);
        mbcff50b6().f2c29f045.setSelected(true);
        mbcff50b6().f5b155153.setImageResource(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$drawable.ic_inventory_list_preview);
    }

    public override void OnBackPressed() {
        mac404cc3().back();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((26 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_design_title)));
        mbcff50b6().f469144e4.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_design_inventory)));
        mbcff50b6().f2c29f045.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_design_list)));
        mbcff50b6().f2069bc58.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_design_big)));
        mbcff50b6().f71ba9d4b.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_design_small)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p2e5d8aa3.p2486923a.p31c13f47.p5db06331$pd41d8cd9$p95263d50(this));
        android.widget.LinearLayout inventoryListVg = mbcff50b6().f70e5aa3b;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(inventoryListVg, "inventoryListVg");
        p2b3583e6.pf5e18aff.m2fa6d087(inventoryListVg, 0L, new p2e5d8aa3.p2486923a.p31c13f47.p5db06331$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.LinearLayout inventoryBigVg = mbcff50b6().f4cdd093c;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(inventoryBigVg, "inventoryBigVg");
        p2b3583e6.pf5e18aff.m2fa6d087(inventoryBigVg, 0L, new p2e5d8aa3.p2486923a.p31c13f47.p5db06331$pd41d8cd9$p144e4630(this), 1, null);
        android.widget.LinearLayout inventorySmallVg = mbcff50b6().f6151e00a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(inventorySmallVg, "inventorySmallVg");
        p2b3583e6.pf5e18aff.m2fa6d087(inventorySmallVg, 0L, new p2e5d8aa3.p2486923a.p31c13f47.p5db06331$pd41d8cd9$p437e9676(this), 1, null);
        m8aa184d7(mac404cc3().getInventoryDesignType());
    }
}

