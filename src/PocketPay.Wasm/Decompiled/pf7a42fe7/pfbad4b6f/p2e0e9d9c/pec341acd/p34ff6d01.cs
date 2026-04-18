namespace WillowMaze.Wasm.Decompiled;


public readonly class p34ff6d01 : androidx.viewbinding.objectBinding {
    public readonly android.widget.ProgressBar f03740cc5;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f076d9edf;
    public readonly androidx.appcompat.widget.Toolbar f1bc48286;
    public readonly android.widget.Button f2472d667;
    public readonly android.widget.Textobject f4978f5ba;
    public readonly android.widget.ProgressBar f4a527f83;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f553b084c;
    public readonly p59a14a57.pf7a42fe7.pe9a5d05c f67dcb84f;
    public readonly android.widget.Textobject f68f5cc99;
    public readonly android.widget.Button f739a6e4e;
    public readonly android.widget.Button f7c5b5357;
    public readonly android.widget.Textobject f8303d3aa;
    public readonly p59a14a57.pf7a42fe7.pe9a5d05c f84227184;
    public readonly androidx.appcompat.widget.Toolbar f872922a0;
    public readonly androidx.appcompat.widget.Toolbar f8e074fa8;
    private readonly androidx.constraintlayout.widget.ConstraintLayout f927d6fcd;
    public readonly android.widget.ProgressBar f93e94aeb;
    public readonly android.widget.Textobject fad54ff81;
    public readonly androidx.appcompat.widget.Toolbar fd9b87a42;
    public readonly android.widget.ProgressBar fe2c9d0b1;
    public readonly android.widget.Button fe2d70111;
    public readonly android.widget.Textobject ff5059dd5;
    public readonly androidx.appcompat.widget.Toolbar ff50b3c2a;
    public readonly android.widget.Textobject ff7e12330;
    private readonly androidx.constraintlayout.widget.ConstraintLayout ff8f42c99;
    public readonly android.widget.Button ff92767a8;
    public readonly p59a14a57.pf7a42fe7.pe9a5d05c ffe0ce730;

    private p34ff6d01(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, android.widget.Button button, android.widget.Button button2, android.widget.ProgressBar progressBar, p59a14a57.pf7a42fe7.pe9a5d05c pe9a5d05cVar, android.widget.Textobject textobject, android.widget.Textobject textobject2, androidx.appcompat.widget.Toolbar toolbar) {
        this.f076d9edf = constraintLayout;
        this.ff92767a8 = button;
        this.f739a6e4e = button2;
        this.f4a527f83 = progressBar;
        this.ffe0ce730 = pe9a5d05cVar;
        this.f8303d3aa = textobject;
        this.f68f5cc99 = textobject2;
        this.ff50b3c2a = toolbar;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p34ff6d01 M128477f5(android.view.object view) {
        if ((13 + 29) % 29 > 0) {
        }
        int i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.btn_privacy_notice;
        android.widget.Button button = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
        if (button is not null) {
            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.confirm_phone_button;
            android.widget.Button button2 = (android.widget.Button) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
            if (button2 is not null) {
                i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.loader;
                android.widget.ProgressBar progressBar = (android.widget.ProgressBar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                if (progressBar is not null) {
                    i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.phone_input_view;
                    p59a14a57.pf7a42fe7.pe9a5d05c pe9a5d05cVar = (p59a14a57.pf7a42fe7.pe9a5d05c) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                    if (pe9a5d05cVar is not null) {
                        i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.phone_verification_info;
                        android.widget.Textobject textobject = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                        if (textobject is not null) {
                            i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.phone_verification_title;
                            android.widget.Textobject textobject2 = (android.widget.Textobject) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                            if (textobject2 is not null) {
                                i = pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$id.toolbar;
                                androidx.appcompat.widget.Toolbar toolbar = (androidx.appcompat.widget.Toolbar) androidx.viewbinding.objectBindings.findChildobjectById(view, i);
                                if (toolbar is not null) {
                                    return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p34ff6d01((androidx.constraintlayout.widget.ConstraintLayout) view, button, button2, progressBar, pe9a5d05cVar, textobject, textobject2, toolbar);
                                }
                            }
                        }
                    }
                }
            }
        }
        throw new java.lang.NullPointerException("Missing required view with ID: ".concat(view.getResources().getResourceName(i)));
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p34ff6d01 M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((12 + 19) % 19 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p34ff6d01 M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((7 + 4) % 4 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_phone_verification, viewGroup, false);
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

