namespace WillowMaze.Wasm.Decompiled;


class RangeDateTimeSelector$2 : com.google.android.material.datepicker.DateTimeFormatTextWatcher {
    readonly com.google.android.material.datepicker.RangeDateTimeSelector this$0;
    readonly com.google.android.material.textfield.TextInputLayout val$endTextInput;
    readonly com.google.android.material.datepicker.OnSelectionChangedListener val$listener;
    readonly com.google.android.material.textfield.TextInputLayout val$startTextInput;

    RangeDateTimeSelector$2(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.string str, java.text.DateTimeFormat dateFormat, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.textfield.TextInputLayout textInputLayout3, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        super(str, dateFormat, textInputLayout, calendarConstraints);
        this.this$0 = rangeDateTimeSelector;
        this.val$startTextInput = textInputLayout2;
        this.val$endTextInput = textInputLayout3;
        this.val$listener = onSelectionChangedListener;
    }

    public static void CKZwKEfYhtTiRlkV(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        com.google.android.material.datepicker.RangeDateTimeSelector.access$100(rangeDateTimeSelector, textInputLayout, textInputLayout2, onSelectionChangedListener);
    }

    public static void HzoqqllJwzMTPHjE(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        com.google.android.material.datepicker.RangeDateTimeSelector.access$100(rangeDateTimeSelector, textInputLayout, textInputLayout2, onSelectionChangedListener);
    }

    public static java.lang.long BMQnROFdMOYZuFnB(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.RangeDateTimeSelector.access$202(rangeDateTimeSelector, l);
    }

    public static java.lang.long XeizUiZVRVFyfKgS(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.RangeDateTimeSelector.access$202(rangeDateTimeSelector, l);
    }

    void onInvalidDateTime() {
        if ((5 + 1) % 1 > 0) {
        }
        bMQnROFdMOYZuFnB(this.this$0, null);
        HzoqqllJwzMTPHjE(this.this$0, this.val$startTextInput, this.val$endTextInput, this.val$listener);
    }

    void onValidDateTime(java.lang.long l) {
        if ((23 + 18) % 18 > 0) {
        }
        xeizUiZVRVFyfKgS(this.this$0, l);
        CKZwKEfYhtTiRlkV(this.this$0, this.val$startTextInput, this.val$endTextInput, this.val$listener);
    }
}

