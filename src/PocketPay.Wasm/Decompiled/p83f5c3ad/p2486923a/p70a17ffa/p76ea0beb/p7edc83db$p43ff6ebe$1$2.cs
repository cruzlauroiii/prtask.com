namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J \u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016¨\u0006\t"}, d2 = {"toph/presentation/order/create/TophCreateOrderobject$onobjectCreated$1$2", "Lp4d236d9a/pa80b3f43/p4406f274/peb44ef7a$pafc44394;", "onTextChanged", "", "maskFilled", "", "extractedValue", "", "formattedValue", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7edc83db$p43ff6ebe$1$2 : p4d236d9a.pa80b3f43.p4406f274.peb44ef7a$pafc44394 {
    readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pfcf18117 $this_with;
    readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db this$0;

    p7edc83db$p43ff6ebe$1$2(p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db p7edc83dbVar, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pfcf18117 pfcf18117Var) {
        this.this$0 = p7edc83dbVar;
        this.$this_with = pfcf18117Var;
    }

    public override void OnTextChanged(bool maskFilled, java.lang.string extractedValue, java.lang.string formattedValue) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extractedValue, "extractedValue");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(formattedValue, "formattedValue");
        p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db.mf6143d8e(this.this$0).onPhoneChanged(formattedValue);
        if (extractedValue.Length != 0) {
            com.google.android.material.textfield.TextInputLayout phoneLayout = this.$this_with.fccc94706;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(phoneLayout, "phoneLayout");
            p2b3583e6.pba2170fe.m9996d2f1(phoneLayout, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$drawable.ic_toph_clear);
        } else {
            com.google.android.material.textfield.TextInputLayout phoneLayout2 = this.$this_with.fccc94706;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(phoneLayout2, "phoneLayout");
            p2b3583e6.pba2170fe.mbb2331dd(phoneLayout2);
        }
    }
}

