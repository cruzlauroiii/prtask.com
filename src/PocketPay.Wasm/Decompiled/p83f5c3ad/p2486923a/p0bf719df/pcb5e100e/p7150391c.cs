namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp83f5c3ad/p2486923a/p0bf719df/pcb5e100e/p7150391c;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p2616b3c8;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p2616b3c8;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lp83f5c3ad/p2486923a/p0bf719df/pcb5e100e/pab18c47d;", "getobjectModel", "()Lp83f5c3ad/p2486923a/p0bf719df/pcb5e100e/pab18c47d;", "viewModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7150391c : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((29 + 12) % 12 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c.class, com.decryptstringmanager.Decryptstring.decryptstring("667611f1fca5e7e33fec1090b9ba3374c299f91dd308e285d526ccfd3ea7b8dda3a0d5"), com.decryptstringmanager.Decryptstring.decryptstring("ee1ab43d5563aee9a03c89156fc23d48744dd7a874e6db3319cfdab119f8cef0ea609ee0bca87dc2563d5f9795030fb8c9057ed69fee1a16369b55d49f3f1849bf5fabd07e88ae9441187db13fd32e2f67cc62d3bd02e3de3596f577ca08b18a4754953fe90079dd5f73a0d445eb3d934f772cb97822e2c2baa74f395639fb8ca4"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p7150391c() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_nfc_calibration_error);
        if ((20 + 24) % 24 > 0) {
        }
        p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c p7150391cVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p7150391cVar, p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p7150391cVar, null, new p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p7150391cVar), null, null));
    }

    private static readonly void M22d1c681(p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c p7150391cVar, android.view.object view) {
        p7150391cVar.onBackPressed();
    }

    public static kotlin.Unit M3f01574c(p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c p7150391cVar, android.view.object view) {
        return m70978268(p7150391cVar, view);
    }

    public static void M426c1b02(p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c p7150391cVar, android.view.object view) {
        m22d1c681(p7150391cVar, view);
    }

    private static readonly kotlin.Unit M70978268(p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c p7150391cVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p7150391cVar.mac404cc3().replaceTophCalibrationScreen();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.pab18c47d Mac404cc3() {
        return (p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.pab18c47d) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p2616b3c8 Mbcff50b6() {
        if ((4 + 32) % 32 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p2616b3c8) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public override void OnBackPressed() {
        mac404cc3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((19 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_error_title)));
        mbcff50b6().f05882d51.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._1)));
        mbcff50b6().f80e9725a.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_error_step1)));
        mbcff50b6().fcbdddb69.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._2)));
        mbcff50b6().fe21839eb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_error_step2)));
        mbcff50b6().f1140ba51.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._3)));
        mbcff50b6().fbde9b59d.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_error_step3)));
        mbcff50b6().f54b39254.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_error_step3_description)));
        mbcff50b6().f04d6bd46.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_error_retry)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c$pd41d8cd9$p95263d50(this));
        android.widget.Button retryBtn = mbcff50b6().f04d6bd46;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(retryBtn, "retryBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(retryBtn, 0L, new p83f5c3ad.p2486923a.p0bf719df.pcb5e100e.p7150391c$pd41d8cd9$pcca4ef0e(this), 1, null);
    }
}

