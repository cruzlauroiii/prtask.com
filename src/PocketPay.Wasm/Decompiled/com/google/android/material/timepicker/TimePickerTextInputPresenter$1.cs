namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputPresenter$1 : com.google.android.material.internal.TextWatcherAdapter {
    readonly com.google.android.material.timepicker.TimePickerTextInputPresenter this$0;

    TimePickerTextInputPresenter$1(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        this.this$0 = timePickerTextInputPresenter;
    }

    public static int AqCRFiJkllPnIODy(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static com.google.android.material.timepicker.TimeModel ZyzBVoVLOHnQsLFJ(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        return com.google.android.material.timepicker.TimePickerTextInputPresenter.access$000(timePickerTextInputPresenter);
    }

    public static bool ExzugoiXTWcxXmVE(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string KyMZblBoYlzpcorL(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.android.material.timepicker.TimeModel NKPhDZevcmcqRQHZ(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        return com.google.android.material.timepicker.TimePickerTextInputPresenter.access$000(timePickerTextInputPresenter);
    }

    public static void PvTVbkTTfIQaQvOr(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    public static void QEOGNMhgUlinDvNd(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        if (exzugoiXTWcxXmVE(editable)) {
            pvTVbkTTfIQaQvOr(ZyzBVoVLOHnQsLFJ(this.this$0), 0);
        } else {
            qEOGNMhgUlinDvNd(nKPhDZevcmcqRQHZ(this.this$0), AqCRFiJkllPnIODy(kyMZblBoYlzpcorL(editable)));
        }
    }
}

