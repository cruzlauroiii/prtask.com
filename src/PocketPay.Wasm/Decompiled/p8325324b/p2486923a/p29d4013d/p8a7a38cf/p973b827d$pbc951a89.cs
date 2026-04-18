namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tJ\u0018\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\fH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp8325324b/p2486923a/p29d4013d/p8a7a38cf/p973b827d$pbc951a89;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p8325324b/p86ccec3d/pec341acd/pfbcefcd6;", "<init>", "(Lp8325324b/p2486923a/p29d4013d/p8a7a38cf/p973b827d;Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p8325324b/p86ccec3d/pec341acd/pfbcefcd6;)V", "bind", "", "paymentType", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "initPaymentType", "drawableResId", "", "textResId", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p973b827d$pbc951a89 : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 f3aaf09a9;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 f5448af97;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 f69d9b563;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 fe57e0b83;
    readonly p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d this$0;

    public p973b827d$pbc951a89(p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d p973b827dVar, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 binding) {
        super(binding.getRoot());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binding, "binding");
        this.this$0 = p973b827dVar;
        this.f001a249d = binding;
    }

    private static readonly kotlin.Unit M35e3c60a(p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d p973b827dVar, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d.m184d3e04(p973b827dVar).invoke(p8c261c90Var);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Maa5d2ba6(p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d p973b827dVar, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var, android.view.object view) {
        return m35e3c60a(p973b827dVar, p8c261c90Var, view);
    }

    private readonly void Mb520ae59(int i, int i2) {
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 pfbcefcd6Var = this.f001a249d;
        pfbcefcd6Var.fc5d04d66.setImageResource(i);
        pfbcefcd6Var.fde7e6cc4.setText(com.decryptstringmanager.Decryptstring.decryptstring(pfbcefcd6Var.getRoot().getobject().getstring(i2)));
    }

    public readonly void Bind(pad5f82e8.p07214c67.p1e11b989.p8c261c90 paymentType) {
        if ((19 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentType, "paymentType");
        int i = p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89$p12c674ac.$EnumSwitchDictionaryping$0[paymentType.ordinal()];
        if (i == 1) {
            mb520ae59(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$drawable.circle_cash, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.cash_pay_system);
        } else if (i == 2) {
            mb520ae59(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$drawable.circle_qr, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.qr_pay_system);
        } else if (i == 3) {
            mb520ae59(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$drawable.circle_toph, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.tap_on_phone_pay_system);
        } else {
            if (i != 4) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            mb520ae59(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$drawable.circle_combo, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.combo_pay_system);
        }
        android.widget.LinearLayout root = this.f001a249d.getRoot();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(root, "getRoot(...)");
        p2b3583e6.pf5e18aff.m2fa6d087(root, 0L, new p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89$pd41d8cd9$p95263d50(this.this$0, paymentType), 1, null);
    }
}

