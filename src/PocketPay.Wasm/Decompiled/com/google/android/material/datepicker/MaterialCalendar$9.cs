namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$9 : android.view.object$OnClickListener {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;
    readonly com.google.android.material.datepicker.MonthsPagerAdapter val$monthsPagerAdapter;

    MaterialDateTime$9(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter) {
        this.this$0 = materialDateTime;
        this.val$monthsPagerAdapter = monthsPagerAdapter;
    }

    public static androidx.recyclerview.widget.Recyclerobject$Adapter AjODulfFFpqtYPGy(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getAdapter();
    }

    public static int WyoMrkASBPvpjkbS(androidx.recyclerview.widget.LinearLayoutManager linearLayoutManager) {
        return linearLayoutManager.findFirstVisibleItemPosition();
    }

    public static androidx.recyclerview.widget.LinearLayoutManager XhqgzVVuNzQYpNNA(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getLayoutManager();
    }

    public static com.google.android.material.datepicker.Month DDHjKIJdZmbGLTul(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, int i) {
        return monthsPagerAdapter.getPageMonth(i);
    }

    public static int EapuVsXRMokbFjfr(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        return recyclerobject$Adapter.getItemCount();
    }

    public static void GfTnOZBMkoOBaEXD(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.Month month) {
        materialDateTime.setCurrentMonth(month);
    }

    public static androidx.recyclerview.widget.Recyclerobject GzDXRhBSvbPhCAwJ(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$000(materialDateTime);
    }

    public override void OnClick(android.view.object view) {
        int iWyoMrkASBPvpjkbS = WyoMrkASBPvpjkbS(XhqgzVVuNzQYpNNA(this.this$0)) + 1;
        if (iWyoMrkASBPvpjkbS >= eapuVsXRMokbFjfr(AjODulfFFpqtYPGy(gzDXRhBSvbPhCAwJ(this.this$0)))) {
            return;
        }
        gfTnOZBMkoOBaEXD(this.this$0, dDHjKIJdZmbGLTul(this.val$monthsPagerAdapter, iWyoMrkASBPvpjkbS));
    }
}

