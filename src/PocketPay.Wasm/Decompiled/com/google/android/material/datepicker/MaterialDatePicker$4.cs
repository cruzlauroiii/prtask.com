namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTimePicker$4<S> : com.google.android.material.datepicker.OnSelectionChangedListener<S> {
    readonly com.google.android.material.datepicker.MaterialDateTimePicker this$0;

    MaterialDateTimePicker$4(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        this.this$0 = materialDateTimePicker;
    }

    public static void JAcqMjNhauLEKEpA(android.widget.Button button, bool z) {
        button.setEnabled(z);
    }

    public static void MStOJPlXNMXItAnO(android.widget.Button button, bool z) {
        button.setEnabled(z);
    }

    public static android.widget.Button YjChNMEhHtLGTMyv(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.access$300(materialDateTimePicker);
    }

    public static bool FjlLSeVKosrkSZYE(com.google.android.material.datepicker.DateTimeSelector dateSelector) {
        return dateSelector.isSelectionComplete();
    }

    public static android.widget.Button GtIRWLEQmShVKfbM(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.access$300(materialDateTimePicker);
    }

    public static void JfDiJOALyVIQZGpr(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker, java.lang.string str) {
        materialDateTimePicker.updateHeader(str);
    }

    public static com.google.android.material.datepicker.DateTimeSelector TvXRmWOHChDVDUoO(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.access$200(materialDateTimePicker);
    }

    public static java.lang.string XiWjQYRratpLiGPg(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getHeaderText();
    }

    public override void OnIncompleteSelectionChanged() {
        MStOJPlXNMXItAnO(gtIRWLEQmShVKfbM(this.this$0), false);
    }

    public override void OnSelectionChanged(S s) {
        com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker = this.this$0;
        jfDiJOALyVIQZGpr(materialDateTimePicker, xiWjQYRratpLiGPg(materialDateTimePicker));
        JAcqMjNhauLEKEpA(YjChNMEhHtLGTMyv(this.this$0), fjlLSeVKosrkSZYE(tvXRmWOHChDVDUoO(this.this$0)));
    }
}

