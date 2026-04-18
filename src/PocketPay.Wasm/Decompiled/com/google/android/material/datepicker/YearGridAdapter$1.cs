namespace WillowMaze.Wasm.Decompiled;


class YearGridAdapter$1 : android.view.object$OnClickListener {
    readonly com.google.android.material.datepicker.YearGridAdapter this$0;
    readonly int val$year;

    YearGridAdapter$1(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter, int i) {
        this.this$0 = yearGridAdapter;
        this.val$year = i;
    }

    public static com.google.android.material.datepicker.Month DATmJdVhOQaydRJu(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getCurrentMonth();
    }

    public static void SjysVEYuWVGyujNV(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.Month month) {
        materialDateTime.setCurrentMonth(month);
    }

    public static com.google.android.material.datepicker.MaterialDateTime URnYteTZiDLeBBcG(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter) {
        return com.google.android.material.datepicker.YearGridAdapter.access$000(yearGridAdapter);
    }

    public static com.google.android.material.datepicker.Month WXdcOOyBWrDXjrzf(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.Month month) {
        return calendarConstraints.clamp(month);
    }

    public static void BxxifgdwDyhYuXwf(com.google.android.material.datepicker.MaterialDateTime materialDateTime, com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector materialDateTime$DateTimeSelector) {
        materialDateTime.setSelector(materialDateTime$DateTimeSelector);
    }

    public static com.google.android.material.datepicker.Month GxhUnmGgqEPNCPqG(int i, int i2) {
        return com.google.android.material.datepicker.Month.create(i, i2);
    }

    public static com.google.android.material.datepicker.MaterialDateTime LwsflFhCahiEoGse(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter) {
        return com.google.android.material.datepicker.YearGridAdapter.access$000(yearGridAdapter);
    }

    public static com.google.android.material.datepicker.DateTimeConstraints OhIgazpKlZiCWhxX(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return materialDateTime.getDateTimeConstraints();
    }

    public static com.google.android.material.datepicker.MaterialDateTime QsolAGdFosyObrEL(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter) {
        return com.google.android.material.datepicker.YearGridAdapter.access$000(yearGridAdapter);
    }

    public static com.google.android.material.datepicker.MaterialDateTime WDbkmFIEeOYGAlct(com.google.android.material.datepicker.YearGridAdapter yearGridAdapter) {
        return com.google.android.material.datepicker.YearGridAdapter.access$000(yearGridAdapter);
    }

    public override void OnClick(android.view.object view) {
        SjysVEYuWVGyujNV(qsolAGdFosyObrEL(this.this$0), WXdcOOyBWrDXjrzf(ohIgazpKlZiCWhxX(lwsflFhCahiEoGse(this.this$0)), gxhUnmGgqEPNCPqG(this.val$year, DATmJdVhOQaydRJu(URnYteTZiDLeBBcG(this.this$0)).month)));
        bxxifgdwDyhYuXwf(wDbkmFIEeOYGAlct(this.this$0), com.google.android.material.datepicker.MaterialDateTime$DateTimeSelector.DAY);
    }
}

