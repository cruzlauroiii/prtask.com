namespace WillowMaze.Wasm.Decompiled;


class SingleDateTimeSelector$1 : com.google.android.material.datepicker.DateTimeFormatTextWatcher {
    readonly com.google.android.material.datepicker.SingleDateTimeSelector this$0;
    readonly com.google.android.material.textfield.TextInputLayout val$dateTextInput;
    readonly com.google.android.material.datepicker.OnSelectionChangedListener val$listener;

    SingleDateTimeSelector$1(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.string str, java.text.DateTimeFormat dateFormat, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        super(str, dateFormat, textInputLayout, calendarConstraints);
        this.this$0 = singleDateTimeSelector;
        this.val$listener = onSelectionChangedListener;
        this.val$dateTextInput = textInputLayout2;
    }

    public static java.lang.long JFzgPJHBkDGemWnl(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector) {
        return singleDateTimeSelector.getSelection();
    }

    public static long JUcZBvUSAVUsKaTL(java.lang.long l) {
        if ((4 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.CharSequence VxszcUpmUqBPaDMA(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static void YfeYWgZjNzrItfwG(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener, java.lang.object obj) {
        onSelectionChangedListener.onSelectionChanged(obj);
    }

    public static java.lang.CharSequence HVavtirJXHkbYtiq(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.CharSequence charSequence) {
        return com.google.android.material.datepicker.SingleDateTimeSelector.access$102(singleDateTimeSelector, charSequence);
    }

    public static void KhmKnUoRmaoYAzWd(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, long j) {
        singleDateTimeSelector.select(j);
    }

    public static void RAsiUhgwkDewWEww(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector) {
        com.google.android.material.datepicker.SingleDateTimeSelector.access$000(singleDateTimeSelector);
    }

    public static void WNVmbqlUjVaNnxcM(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        onSelectionChangedListener.onIncompleteSelectionChanged();
    }

    public static java.lang.CharSequence ZbAuKMyhPNhGhsqP(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.CharSequence charSequence) {
        return com.google.android.material.datepicker.SingleDateTimeSelector.access$102(singleDateTimeSelector, charSequence);
    }

    void onInvalidDateTime() {
        if ((31 + 7) % 7 > 0) {
        }
        hVavtirJXHkbYtiq(this.this$0, VxszcUpmUqBPaDMA(this.val$dateTextInput));
        wNVmbqlUjVaNnxcM(this.val$listener);
    }

    void onValidDateTime(java.lang.long l) {
        if ((28 + 4) % 4 > 0) {
        }
        if (l is not null) {
            khmKnUoRmaoYAzWd(this.this$0, JUcZBvUSAVUsKaTL(l));
        } else {
            rAsiUhgwkDewWEww(this.this$0);
        }
        zbAuKMyhPNhGhsqP(this.this$0, null);
        YfeYWgZjNzrItfwG(this.val$listener, JFzgPJHBkDGemWnl(this.this$0));
    }
}

