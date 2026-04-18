namespace WillowMaze.Wasm.Decompiled;


class CustomEndIconDelegate : com.google.android.material.textfield.EndIconDelegate {
    CustomEndIconDelegate(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        super(endCompoundLayout);
    }

    public static void XYnnZoIlTXeRDDOL(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnlongClickListener view$OnlongClickListener) {
        endCompoundLayout.setEndIconOnlongClickListener(view$OnlongClickListener);
    }

    void setUp() {
        XYnnZoIlTXeRDDOL(this.endLayout, null);
    }
}

