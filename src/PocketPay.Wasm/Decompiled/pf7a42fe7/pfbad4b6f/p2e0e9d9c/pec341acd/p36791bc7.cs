namespace WillowMaze.Wasm.Decompiled;


public readonly class p36791bc7 : androidx.viewbinding.objectBinding {
    public readonly android.widget.Textobject f01d574c7;
    public readonly android.widget.Textobject f053ce592;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f076d9edf;
    public readonly android.widget.Textobject f1b0b297d;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f28872c6b;
    public readonly android.widget.Button f34813a0f;
    public readonly androidx.appcompat.widget.Toolbar f3b010d94;
    public readonly android.widget.Button f4176265e;
    public readonly android.widget.Textobject f56091b80;
    public readonly android.widget.Button f5db58d3d;
    public readonly android.widget.Textobject f5e8d63ff;
    public readonly android.widget.Textobject f65e343ca;
    public readonly android.widget.Textobject f6f075329;
    public readonly android.widget.Textobject f82129ce0;
    public readonly android.widget.Textobject fbf5b4da0;
    public readonly androidx.appcompat.widget.Toolbar fe8c639aa;
    public readonly androidx.appcompat.widget.Toolbar ff50b3c2a;

    private p36791bc7(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.widget.Button button, android.widget.Textobject textobject, androidx.appcompat.widget.Toolbar toolbar, android.widget.Textobject textobject2) {
        this.f076d9edf = constraintLayout;
        this.f34813a0f = button;
        this.f053ce592 = textobject;
        this.ff50b3c2a = toolbar;
        this.f01d574c7 = textobject2;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p36791bc7 M128477f5(android.view.object view) {
        if ((3 + 31) % 31 > 0) {
        }
        int i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.btnNext;
        android.widget.Button button = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
        if (button is not null) {
            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.descriptionTv;
            android.widget.Textobject textobject = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
            if (textobject is not null) {
                i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.toolbar;
                androidx.appcompat.widget.Toolbar toolbar = (androidx.appcompat.widget.Toolbar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                if (toolbar is not null) {
                    i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.tvPhone;
                    android.widget.Textobject textobject2 = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                    if (textobject2 is not null) {
                        return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p36791bc7((androidx.constraintlayout.widget.ConstraintLayout) view, button, textobject, toolbar, textobject2);
                    }
                }
            }
        }
        throw new java.lang.NullPointerException("Missing required view with ID: ".concat(view.getResources().getResourceName(i)));
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p36791bc7 M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((21 + 14) % 14 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p36791bc7 M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((5 + 15) % 15 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_account_found_business, viewGroup, false);
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

