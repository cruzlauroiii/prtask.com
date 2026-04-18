namespace WillowMaze.Wasm.Decompiled;


class MonthsPagerAdapter$1 : android.widget.Adapterobject$OnItemClickListener {
    readonly com.google.android.material.datepicker.MonthsPagerAdapter this$0;
    readonly com.google.android.material.datepicker.MaterialDateTimeGridobject val$monthGrid;

    MonthsPagerAdapter$1(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter, com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        this.this$0 = monthsPagerAdapter;
        this.val$monthGrid = materialDateTimeGridobject;
    }

    public static long IUzahUfOTBaaHCSj(java.lang.long l) {
        if ((21 + 28) % 28 > 0) {
        }
        return l.longValue();
    }

    public static com.google.android.material.datepicker.MaterialDateTime$OnDayClickListener QvBObDmbUOkjjWbP(com.google.android.material.datepicker.MonthsPagerAdapter monthsPagerAdapter) {
        return com.google.android.material.datepicker.MonthsPagerAdapter.access$000(monthsPagerAdapter);
    }

    public static com.google.android.material.datepicker.MonthAdapter SaTzGZrZZkaRvNSR(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static com.google.android.material.datepicker.MonthAdapter XOjmUFjbxaErbrMA(com.google.android.material.datepicker.MaterialDateTimeGridobject materialDateTimeGridobject) {
        return materialDateTimeGridobject.getAdapter();
    }

    public static bool SzVKlmgkTcwTDFbG(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.withinMonth(i);
    }

    public static java.lang.long YDdEthLyNCkxrLnm(com.google.android.material.datepicker.MonthAdapter monthAdapter, int i) {
        return monthAdapter.getItem(i);
    }

    public static void YmHUtcuLttEafNCZ(com.google.android.material.datepicker.MaterialDateTime$OnDayClickListener materialDateTime$OnDayClickListener, long j) {
        materialDateTime$OnDayClickListener.onDayClick(j);
    }

    public override void OnItemClick(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        if (szVKlmgkTcwTDFbG(SaTzGZrZZkaRvNSR(this.val$monthGrid), i)) {
            ymHUtcuLttEafNCZ(QvBObDmbUOkjjWbP(this.this$0), IUzahUfOTBaaHCSj(yDdEthLyNCkxrLnm(XOjmUFjbxaErbrMA(this.val$monthGrid), i)));
        }
    }
}

