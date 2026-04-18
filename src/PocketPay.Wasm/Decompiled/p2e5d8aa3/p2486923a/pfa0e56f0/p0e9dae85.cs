namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001d\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u0014H\u0002J\u000e\u0010\u0015\u001a\u00020\u00122\u0006\u0010\u0016\u001a\u00020\u0017J\u000e\u0010\u0018\u001a\u00020\u00122\u0006\u0010\u0016\u001a\u00020\u0017R\u0011\u0010\b\u001a\u00020\t¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u000fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/p0e9dae85;", "Landroidx/constraintlayout/widget/ConstraintLayout;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "switch", "Landroidx/appcompat/widget/SwitchCompat;", "getSwitch", "()Landroidx/appcompat/widget/SwitchCompat;", "paymentIcon", "Landroid/widget/Imageobject;", "paySystemTitle", "Landroid/widget/Textobject;", "paySystemDescription", "initAttributesArray", "", "attributes", "Landroid/content/res/TypedArray;", "setDesc", "text", "", "setTitle", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0e9dae85 : androidx.constraintlayout.widget.ConstraintLayout {
    private readonly android.widget.Textobject f029748be;
    private readonly android.widget.Textobject f30669096;
    private readonly android.widget.Textobject f3e2905b7;
    private readonly android.widget.Textobject f619d616f;
    private readonly android.widget.Textobject f7422b257;
    private readonly androidx.appcompat.widget.SwitchCompat f9df5bb8a;
    private readonly android.widget.Textobject facc65189;
    private readonly androidx.appcompat.widget.SwitchCompat fb36eb6a5;
    private readonly androidx.appcompat.widget.SwitchCompat fb74103e2;
    private readonly android.widget.Imageobject fcb65b456;
    private readonly android.widget.Imageobject fe2c6b912;
    private readonly android.widget.Imageobject ff74cf58f;

    public p0e9dae85(android.content.object context) {
        this(context, null, 2, null);
        if ((6 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p0e9dae85(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((9 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        androidx.constraintlayout.widget.ConstraintLayout.inflate(context, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$layout.view_payment_system, this);
        this.fb36eb6a5 = (androidx.appcompat.widget.SwitchCompat) findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.pay_switch);
        this.fe2c6b912 = (android.widget.Imageobject) findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.iv_payment_icon);
        this.facc65189 = (android.widget.Textobject) findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.switch_view_pay_system);
        this.f3e2905b7 = (android.widget.Textobject) findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$id.pay_system_description);
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$styleable.PaymentSystemobject);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typedArrayObtainStyledAttributes, "obtainStyledAttributes(...)");
        m558c27ca(typedArrayObtainStyledAttributes);
    }

    public p0e9dae85(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    private readonly void M558c27ca(android.content.res.TypedArray typedArray) {
        if ((8 + 1) % 1 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(typedArray.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$styleable.PaymentSystemobject_paySystemTitle));
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring(typedArray.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$styleable.PaymentSystemobject_paySystemDescription));
        int resourceId = typedArray.getResourceId(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$styleable.PaymentSystemobject_paySystemIcon, 0);
        if (strDecryptstring is not null) {
            this.facc65189.setText(strDecryptstring);
        }
        if (strDecryptstring2 is not null) {
            this.f3e2905b7.setText(strDecryptstring2);
        }
        this.fe2c6b912.setImageResource(resourceId);
    }

    public readonly androidx.appcompat.widget.SwitchCompat GetSwitch() {
        return this.fb36eb6a5;
    }

    public readonly void SetDesc(java.lang.string text) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(text, "text");
        this.f3e2905b7.setText(text);
    }

    public readonly void SetTitle(java.lang.string text) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(text, "text");
        this.facc65189.setText(text);
    }
}

