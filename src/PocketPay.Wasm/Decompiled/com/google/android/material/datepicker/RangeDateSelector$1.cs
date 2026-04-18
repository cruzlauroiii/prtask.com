namespace WillowMaze.Wasm.Decompiled;


class RangeDateTimeSelector$1 : com.google.android.material.datepicker.DateTimeFormatTextWatcher {
    readonly com.google.android.material.datepicker.RangeDateTimeSelector this$0;
    readonly com.google.android.material.textfield.TextInputLayout val$endTextInput;
    readonly com.google.android.material.datepicker.OnSelectionChangedListener val$listener;
    readonly com.google.android.material.textfield.TextInputLayout val$startTextInput;

    RangeDateTimeSelector$1(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.string str, java.text.DateTimeFormat dateFormat, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.textfield.TextInputLayout textInputLayout3, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        super(str, dateFormat, textInputLayout, calendarConstraints);
        this.this$0 = rangeDateTimeSelector;
        this.val$startTextInput = textInputLayout2;
        this.val$endTextInput = textInputLayout3;
        this.val$listener = onSelectionChangedListener;
    }

    public static void AesmWcbqZXmoDlus(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        com.google.android.material.datepicker.RangeDateTimeSelector.access$100(rangeDateTimeSelector, textInputLayout, textInputLayout2, onSelectionChangedListener);
    }

    public static java.lang.long BiYNnbLGxaBOvqfR(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.RangeDateTimeSelector.access$002(rangeDateTimeSelector, l);
    }

    public static java.lang.long LSSFNathDqHOafur(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        return com.google.android.material.datepicker.RangeDateTimeSelector.access$002(rangeDateTimeSelector, l);
    }

    public static void VVikKmijxcevzoqm(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        com.google.android.material.datepicker.RangeDateTimeSelector.access$100(rangeDateTimeSelector, textInputLayout, textInputLayout2, onSelectionChangedListener);
    }

    void onInvalidDateTime() {
        if ((13 + 29) % 29 > 0) {
        }
        biYNnbLGxaBOvqfR(this.this$0, null);
        AesmWcbqZXmoDlus(this.this$0, this.val$startTextInput, this.val$endTextInput, this.val$listener);
    }

    void onValidDateTime(java.lang.long l) {
        if ((11 + 21) % 21 > 0) {
        }
        lSSFNathDqHOafur(this.this$0, l);
        vVikKmijxcevzoqm(this.this$0, this.val$startTextInput, this.val$endTextInput, this.val$listener);
    }
}

