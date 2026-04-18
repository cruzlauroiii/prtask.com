namespace WillowMaze.Wasm.Decompiled;


public readonly class p85861b5d : androidx.viewbinding.objectBinding {
    private readonly androidx.appcompat.widget.AppCompatTextobject f076d9edf;
    private readonly androidx.appcompat.widget.AppCompatTextobject f1c7698f7;
    public readonly androidx.appcompat.widget.AppCompatTextobject f23e0bb6c;
    public readonly androidx.appcompat.widget.AppCompatTextobject f47f518db;
    private readonly androidx.appcompat.widget.AppCompatTextobject f5c17e49b;
    private readonly androidx.appcompat.widget.AppCompatTextobject fdba2a88f;

    private p85861b5d(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, androidx.appcompat.widget.AppCompatTextobject appCompatTextobject2) {
        this.f076d9edf = appCompatTextobject;
        this.f23e0bb6c = appCompatTextobject2;
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p85861b5d M128477f5(android.view.object view) {
        if (view is null) {
            throw new java.lang.NullPointerException("rootobject");
        }
        androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = (androidx.appcompat.widget.AppCompatTextobject) view;
        return new pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p85861b5d(appCompatTextobject, appCompatTextobject);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p85861b5d M89daba64(android.view.LayoutInflater layoutInflater) {
        if ((17 + 19) % 19 > 0) {
        }
        return m89daba64(layoutInflater, null, false);
    }

    public static pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p85861b5d M89daba64(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, bool z) {
        if ((3 + 9) % 9 > 0) {
        }
        android.view.object viewInflate = layoutInflater.inflate(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.item_country_drop_down, viewGroup, false);
        if (z) {
            viewGroup.addobject(viewInflate);
        }
        return m128477f5(viewInflate);
    }

    public override android.view.object GetRoot() {
        return getRoot();
    }

    public override androidx.appcompat.widget.AppCompatTextobject GetRoot() {
        return this.f076d9edf;
    }
}

