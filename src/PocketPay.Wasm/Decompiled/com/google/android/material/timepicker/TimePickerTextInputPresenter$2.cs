namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputPresenter$2 : com.google.android.material.internal.TextWatcherAdapter {
    readonly com.google.android.material.timepicker.TimePickerTextInputPresenter this$0;

    TimePickerTextInputPresenter$2(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        this.this$0 = timePickerTextInputPresenter;
    }

    public static com.google.android.material.timepicker.TimeModel CoATMIiXzPymSoyh(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        return com.google.android.material.timepicker.TimePickerTextInputPresenter.access$000(timePickerTextInputPresenter);
    }

    public static bool CpQYsFDDiMdKxTRv(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string GaYqsaFqLlNLPMMw(java.lang.object obj) {
        return obj.tostring();
    }

    public static void GvqSPklUxRtdEstd(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setHour(i);
    }

    public static com.google.android.material.timepicker.TimeModel AWEsRTCmkTIfEWsn(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        return com.google.android.material.timepicker.TimePickerTextInputPresenter.access$000(timePickerTextInputPresenter);
    }

    public static void LeMGpHntxeIxAFwE(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setHour(i);
    }

    public static int QqQtfOlGfhWBhPJw(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        if (CpQYsFDDiMdKxTRv(editable)) {
            GvqSPklUxRtdEstd(aWEsRTCmkTIfEWsn(this.this$0), 0);
        } else {
            leMGpHntxeIxAFwE(CoATMIiXzPymSoyh(this.this$0), qqQtfOlGfhWBhPJw(GaYqsaFqLlNLPMMw(editable)));
        }
    }
}

