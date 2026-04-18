namespace WillowMaze.Wasm.Decompiled;


public readonly class pca420dd6 : androidx.viewbinding.objectBinding {
    private readonly androidx.constraintlayout.widget.ConstraintLayout f076d9edf;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f18709123;
    public readonly androidx.appcompat.widget.Toolbar f1dbbe592;
    public readonly p59a14a57.pfbad4b6f.pdcdbf7d8 f2da9d4ca;
    public readonly android.widget.ProgressBar f2e218f58;
    public readonly p59a14a57.pfbad4b6f.pdcdbf7d8 f3034bd38;
    public readonly android.widget.ProgressBar f35e7fedb;
    public readonly android.widget.ProgressBar f446bc84b;
    public readonly android.widget.ProgressBar f4a527f83;
    public readonly android.widget.Textobject f56b46c99;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f5beeb1d2;
    public readonly android.widget.ProgressBar f6aa7482a;
    public readonly p59a14a57.pfbad4b6f.pdcdbf7d8 f776d340f;
    public readonly p59a14a57.pfbad4b6f.pdcdbf7d8 f79429f8f;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f854dae5f;
    public readonly android.widget.Textobject fa9549f76;
    private readonly androidx.constraintlayout.widget.ConstraintLayout ff12706a8;
    public readonly androidx.appcompat.widget.Toolbar ff50b3c2a;
    public readonly p59a14a57.pfbad4b6f.pdcdbf7d8 ff80c812a;

    private pca420dd6(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.widget.Textobject textobject, p59a14a57.pfbad4b6f.pdcdbf7d8 pdcdbf7d8Var, android.widget.ProgressBar progressBar, androidx.appcompat.widget.Toolbar toolbar) {
        this.f076d9edf = constraintLayout;
        this.fa9549f76 = textobject;
        this.f3034bd38 = pdcdbf7d8Var;
        this.f4a527f83 = progressBar;
        this.ff50b3c2a = toolbar;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pca420dd6 M128477f5(android.view.object view) {
        if ((18 + 21) % 21 > 0) {
        }
        int i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.application_version_view;
        android.widget.Textobject textobject = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
        if (textobject is not null) {
            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.confirm_code_view;
            p59a14a57.pfbad4b6f.pdcdbf7d8 pdcdbf7d8Var = (p59a14a57.pfbad4b6f.pdcdbf7d8) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
            if (pdcdbf7d8Var is not null) {
                i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.loader;
                android.widget.ProgressBar progressBar = (android.widget.ProgressBar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                if (progressBar is not null) {
                    i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.toolbar;
                    androidx.appcompat.widget.Toolbar toolbar = (androidx.appcompat.widget.Toolbar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                    if (toolbar is not null) {
                        return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pca420dd6((androidx.constraintlayout.widget.ConstraintLayout) view, textobject, pdcdbf7d8Var, progressBar, toolbar);
                    }
                }
            }
        }
        throw new java.lang.NullPointerException("Missing required view with ID: ".concat(view.getResources().getResourceName(i)));
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pca420dd6 M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((14 + 5) % 5 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.pca420dd6 M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((22 + 20) % 20 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_sms_verification, viewGroup, false);
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

