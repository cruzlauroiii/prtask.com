namespace WillowMaze.Wasm.Decompiled;


public readonly class pfe9e1d05 : androidx.viewbinding.objectBinding {
    public readonly android.widget.Textobject f01d574c7;
    public readonly android.widget.Textobject f053ce592;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f076d9edf;
    public readonly android.widget.Button f150214d9;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f18ab10f2;
    public readonly android.widget.Textobject f26d77544;
    public readonly android.widget.Textobject f2f59aa89;
    public readonly android.widget.Button f34813a0f;
    public readonly androidx.appcompat.widget.Toolbar f38d9265a;
    public readonly android.widget.Textobject f4c4bb0be;
    public readonly android.widget.Button f5c7368ff;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f6c0f14c6;
    public readonly android.widget.Button f6c2fad02;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f6c8eda70;
    public readonly android.widget.LinearLayout f6dab1a84;
    public readonly androidx.appcompat.widget.Toolbar f7500506d;
    public readonly android.widget.Textobject f758678a2;
    public readonly android.widget.Textobject f82bfd578;
    public readonly android.widget.Button f847847cc;
    public readonly android.widget.LinearLayout f886302cd;
    public readonly android.widget.Textobject f8a7a1058;
    public readonly android.widget.Button f8b620f54;
    public readonly android.widget.LinearLayout f9b4b3d2a;
    public readonly android.widget.Button fa37f58f4;
    public readonly android.widget.Button fa6afe3a5;
    public readonly android.widget.LinearLayout fb86e7286;
    public readonly android.widget.Textobject fb94210fa;
    public readonly android.widget.LinearLayout fbe4ba9df;
    public readonly androidx.appcompat.widget.Toolbar fc110298d;
    public readonly android.widget.Button fd08eaf21;
    public readonly android.widget.Textobject fe3fc54d0;
    public readonly androidx.appcompat.widget.Toolbar ff50b3c2a;

    private pfe9e1d05(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.widget.Button button, android.widget.Button button2, android.widget.Textobject textobject, androidx.appcompat.widget.Toolbar toolbar, android.widget.Textobject textobject2, android.widget.LinearLayout linearLayout) {
        this.f076d9edf = constraintLayout;
        this.fa37f58f4 = button;
        this.f34813a0f = button2;
        this.f053ce592 = textobject;
        this.ff50b3c2a = toolbar;
        this.f01d574c7 = textobject2;
        this.fb86e7286 = linearLayout;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pfe9e1d05 M128477f5(android.view.object view) {
        if ((11 + 29) % 29 > 0) {
        }
        int i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.btnChangeRole;
        android.widget.Button button = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
        if (button is not null) {
            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.btnNext;
            android.widget.Button button2 = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
            if (button2 is not null) {
                i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.descriptionTv;
                android.widget.Textobject textobject = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                if (textobject is not null) {
                    i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.toolbar;
                    androidx.appcompat.widget.Toolbar toolbar = (androidx.appcompat.widget.Toolbar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                    if (toolbar is not null) {
                        i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.tvPhone;
                        android.widget.Textobject textobject2 = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                        if (textobject2 is not null) {
                            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.vgButtons;
                            android.widget.LinearLayout linearLayout = (android.widget.LinearLayout) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                            if (linearLayout is not null) {
                                return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pfe9e1d05((androidx.constraintlayout.widget.ConstraintLayout) view, button, button2, textobject, toolbar, textobject2, linearLayout);
                            }
                        }
                    }
                }
            }
        }
        throw new java.lang.NullPointerException("Missing required view with ID: ".concat(view.getResources().getResourceName(i)));
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pfe9e1d05 M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((32 + 31) % 31 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pfe9e1d05 M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((24 + 22) % 22 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_account_found_cashier, viewGroup, false);
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

