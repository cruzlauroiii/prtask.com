namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$10 : android.view.object$OnClickListener {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;
    readonly com.google.android.material.datepicker.MonthsPagerAdapter val$monthsPagerAdapter;

    MaterialDateTime$10(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter) {
        this.this$0 = materialDateTime;
        this.val$monthsPagerAdapter = monthsPagerAdapter;
    }

    public static com.google.android.material.datepicker.Month CczNaMHVLBHxtkCl(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, int i) {
        return monthsPagerAdapter.getPageMonth(i);
    }

    public static androidx.recyclerview.widget.LinearLayoutManager VKXpYmxSlxOZgKte(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getLayoutManager();
    }

    public static void ZsPSaLOzrkUBHeyZ(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.Month month) {
        materialDateTime.setCurrentMonth(month);
    }

    public static int WmMBxVjSzCvQtBFg(androidx.recyclerview.widget.LinearLayoutManager linearLayoutManager) {
        return linearLayoutManager.findLastVisibleItemPosition();
    }

    public override void OnClick(android.view.object view) {
        int iWmMBxVjSzCvQtBFg = wmMBxVjSzCvQtBFg(VKXpYmxSlxOZgKte(this.this$0)) - 1;
        if (iWmMBxVjSzCvQtBFg < 0) {
            return;
        }
        ZsPSaLOzrkUBHeyZ(this.this$0, CczNaMHVLBHxtkCl(this.val$monthsPagerAdapter, iWmMBxVjSzCvQtBFg));
    }
}

