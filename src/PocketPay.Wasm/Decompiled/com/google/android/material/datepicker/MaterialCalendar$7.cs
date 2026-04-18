namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$7 : androidx.recyclerview.widget.Recyclerobject$OnScrollListener {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;
    readonly com.google.android.material.button.MaterialButton val$monthDropSelect;
    readonly com.google.android.material.datepicker.MonthsPagerAdapter val$monthsPagerAdapter;

    MaterialDateTime$7(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, com.google.android.material.button.MaterialButton materialButton) {
        this.this$0 = materialDateTime;
        this.val$monthsPagerAdapter = monthsPagerAdapter;
        this.val$monthDropSelect = materialButton;
    }

    public static void DVTaakPqbEhyquCd(com.google.android.material.button.MaterialButton materialButton, java.lang.CharSequence charSequence) {
        materialButton.setText(charSequence);
    }

    public static java.lang.CharSequence GKizbIyKFfRWBHGG(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, int i) {
        return monthsPagerAdapter.getPageTitle(i);
    }

    public static com.google.android.material.datepicker.Month KeHLcXwmrFXKtkSx(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, int i) {
        return monthsPagerAdapter.getPageMonth(i);
    }

    public static int LUSQKtYRWwMMRDPF(androidx.recyclerview.widget.LinearLayoutManager linearLayoutManager) {
        return linearLayoutManager.findFirstVisibleItemPosition();
    }

    public static void HHZsPkJSOIWCHGBl(androidx.recyclerview.widget.Recyclerobject recyclerobject, java.lang.CharSequence charSequence) {
        recyclerobject.announceForAccessibility(charSequence);
    }

    public static java.lang.CharSequence IAQLqKGIvOrNnVUR(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getText();
    }

    public static com.google.android.material.datepicker.Month ICmgMwBONKPouDWm(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.Month month) {
        return com.google.android.material.datepicker.MaterialDateTime.access$602(materialDateTime, month);
    }

    public static int JqiQetRZMhIbJtaH(androidx.recyclerview.widget.LinearLayoutManager linearLayoutManager) {
        return linearLayoutManager.findLastVisibleItemPosition();
    }

    public static androidx.recyclerview.widget.LinearLayoutManager RZyXdnVhYDFugHum(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getLayoutManager();
    }

    public static androidx.recyclerview.widget.LinearLayoutManager VXKiUYfCiTFBTICN(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getLayoutManager();
    }

    public override void OnScrollStateChanged(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        if (i != 0) {
            return;
        }
        hHZsPkJSOIWCHGBl(recyclerobject, iAQLqKGIvOrNnVUR(this.val$monthDropSelect));
    }

    public override void OnScrolled(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        int iJqiQetRZMhIbJtaH = i >= 0 ? jqiQetRZMhIbJtaH(rZyXdnVhYDFugHum(this.this$0)) : LUSQKtYRWwMMRDPF(vXKiUYfCiTFBTICN(this.this$0));
        iCmgMwBONKPouDWm(this.this$0, KeHLcXwmrFXKtkSx(this.val$monthsPagerAdapter, iJqiQetRZMhIbJtaH));
        DVTaakPqbEhyquCd(this.val$monthDropSelect, GKizbIyKFfRWBHGG(this.val$monthsPagerAdapter, iJqiQetRZMhIbJtaH));
    }
}

