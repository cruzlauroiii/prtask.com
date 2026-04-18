namespace WillowMaze.Wasm.Decompiled;


public readonly class p76add4ec : androidx.viewbinding.objectBinding {
    public readonly androidx.appcompat.widget.Toolbar f04c5da1e;
    public readonly android.widget.Textobject f053ce592;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f076d9edf;
    public readonly androidx.appcompat.widget.Toolbar f2dc4af5c;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f30cf9a44;
    public readonly android.widget.Textobject f55fc0714;
    public readonly android.widget.Textobject f5e7d0574;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f60d31a7c;
    public readonly androidx.appcompat.widget.Toolbar f6660f0dd;
    public readonly android.widget.Textobject f7bac4213;
    public readonly android.widget.Textobject f808ac2f1;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f9a07cc58;
    private readonly androidx.constraintlayout.widget.ConstraintLayout facfc53a9;
    public readonly androidx.appcompat.widget.Toolbar ff50b3c2a;

    private p76add4ec(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.widget.Textobject textobject, androidx.appcompat.widget.Toolbar toolbar) {
        this.f076d9edf = constraintLayout;
        this.f053ce592 = textobject;
        this.ff50b3c2a = toolbar;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p76add4ec M128477f5(android.view.object view) {
        if ((11 + 19) % 19 > 0) {
        }
        int i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.descriptionTv;
        android.widget.Textobject textobject = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
        if (textobject is not null) {
            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.toolbar;
            androidx.appcompat.widget.Toolbar toolbar = (androidx.appcompat.widget.Toolbar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
            if (toolbar is not null) {
                return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p76add4ec((androidx.constraintlayout.widget.ConstraintLayout) view, textobject, toolbar);
            }
        }
        throw new java.lang.NullPointerException("Missing required view with ID: ".concat(view.getResources().getResourceName(i)));
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p76add4ec M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((4 + 20) % 20 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p76add4ec M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((31 + 32) % 32 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_account_found_cashier_desc, viewGroup, false);
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

