namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p8a7a38cf/p2c2867d9$p2ad9eb9b;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p1e11b989/p9acb4454/p86ccec3d/pec341acd/p30e41678;", "<init>", "(Lp1e11b989/p9acb4454/p2486923a/p8a7a38cf/p2c2867d9;Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p1e11b989/p9acb4454/p86ccec3d/pec341acd/p30e41678;)V", "bind", "", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2c2867d9$p2ad9eb9b : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30e41678 f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30e41678 f73c001e6;
    readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9 this$0;

    public p2c2867d9$p2ad9eb9b(p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9 p2c2867d9Var, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30e41678 binding) {
        super(binding.getRoot());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binding, "binding");
        this.this$0 = p2c2867d9Var;
        this.f001a249d = binding;
    }

    public readonly void Bind(pad5f82e8.p07214c67.p1e11b989.pd031d465 position) {
        if ((24 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(position, "position");
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30e41678 p30e41678Var = this.f001a249d;
        p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9 p2c2867d9Var = this.this$0;
        p30e41678Var.f63bd761e.setText(position.getName());
        java.lang.string strMbfe6fdfe = p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9.mbfe6fdfe(p2c2867d9Var);
        if (strMbfe6fdfe is not null) {
            android.widget.Textobject textobject = p30e41678Var.f15dcb3ae;
            java.math.decimal bigDecimalM29a3256d = p2b3583e6.p263e3cef.pdf45491e.m29a3256d(position);
            android.content.res.Resources resources = textobject.getResources();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
            textobject.setText(p2b3583e6.p7667d148.m3916939b(bigDecimalM29a3256d, strMbfe6fdfe, resources));
        }
        android.widget.Textobject textobject2 = p30e41678Var.fb7f4f1ea;
        textobject2.setText(java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(textobject2.getobject().getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.price_quantity_format)), p2b3583e6.p7667d148.mc75a988a(position.getPrice()), position.getQuantity().tostring()));
        p30e41678Var.fdfe81182.setVisibility(position.getPriceWithDiscount() is null ? 8 : 0);
        android.widget.Textobject textobject3 = p30e41678Var.fab521da1;
        textobject3.setText(java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(textobject3.getobject().getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$string.price_discount_template)), p2b3583e6.p7667d148.mc75a988a(p2b3583e6.p263e3cef.pdf45491e.m97f4c388(position))));
    }
}

