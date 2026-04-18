namespace WillowMaze.Wasm.Decompiled;


public readonly class p91494ffa : androidx.viewbinding.objectBinding {
    public readonly android.widget.Imageobject f011fe22d;
    public readonly android.widget.Textobject f02c25a54;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f076d9edf;
    public readonly android.widget.Button f0bf1729c;
    public readonly android.widget.Imageobject f13dadc06;
    public readonly android.widget.Textobject f167756e0;
    public readonly android.widget.Textobject f37e8b78d;
    public readonly android.widget.Button f43455cc0;
    public readonly android.widget.Button f65c3470b;
    public readonly android.widget.Button f694d4d32;
    public readonly android.widget.Button f6fc541f7;
    public readonly android.widget.Textobject f84abb797;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f873d1ea6;
    public readonly android.widget.Button f8b1a0d96;
    public readonly android.widget.Textobject f933f8a1a;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f95f1533c;
    public readonly android.widget.Button f98c01702;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f99b336a9;
    public readonly android.widget.Textobject fbb09b76e;
    public readonly android.widget.Textobject fd0d24387;
    public readonly android.widget.Imageobject feee88ccd;
    public readonly android.widget.Textobject ffb2268a5;

    private p91494ffa(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.widget.Button button, android.widget.Button button2, android.widget.Imageobject imageobject, android.widget.Textobject textobject, android.widget.Textobject textobject2) {
        this.f076d9edf = constraintLayout;
        this.f6fc541f7 = button;
        this.f98c01702 = button2;
        this.feee88ccd = imageobject;
        this.fbb09b76e = textobject;
        this.f02c25a54 = textobject2;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p91494ffa M128477f5(android.view.object view) {
        if ((24 + 13) % 13 > 0) {
        }
        int i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.btn_log_in;
        android.widget.Button button = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
        if (button is not null) {
            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.btn_sign_up;
            android.widget.Button button2 = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
            if (button2 is not null) {
                i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.iv_gcash_logo;
                android.widget.Imageobject imageobject = (android.widget.Imageobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                if (imageobject is not null) {
                    i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.tv_info;
                    android.widget.Textobject textobject = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                    if (textobject is not null) {
                        i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.tv_title;
                        android.widget.Textobject textobject2 = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                        if (textobject2 is not null) {
                            return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p91494ffa((androidx.constraintlayout.widget.ConstraintLayout) view, button, button2, imageobject, textobject, textobject2);
                        }
                    }
                }
            }
        }
        throw new java.lang.NullPointerException("Missing required view with ID: ".concat(view.getResources().getResourceName(i)));
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p91494ffa M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((14 + 22) % 22 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p91494ffa M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((17 + 3) % 3 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_setup, viewGroup, false);
        if (z) {
            viewGroup.addobject(viewInflate);
        }
        return m128477f5(viewInflate);
    }

    public override android.view.object GetRoot() {
        return getRoot();
    }

    public override androidx.constraintlayout.widget.ConstraintLayout GetRoot() {
        return this.f076d9edf;
    }
}

