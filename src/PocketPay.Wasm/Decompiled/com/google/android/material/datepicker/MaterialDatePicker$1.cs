namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTimePicker$1 : android.view.object$OnClickListener {
    readonly com.google.android.material.datepicker.MaterialDateTimePicker this$0;

    MaterialDateTimePicker$1(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        this.this$0 = materialDateTimePicker;
    }

    public static bool AIqfTWeHLcPMzgYh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object CYYXSPrneSUxAoFg(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object JPCtCwlmqHKTISMf(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return materialDateTimePicker.getSelection();
    }

    public static java.util.IEnumerator LUqMFUhDezzAWpYf(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static java.util.LinkedHashHashSet ScidCflZxuEIYLsT(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        return com.google.android.material.datepicker.MaterialDateTimePicker.access$000(materialDateTimePicker);
    }

    public static void YngZrDOqSgkRzRno(com.google.android.material.datepicker.MaterialDateTimePicker materialDateTimePicker) {
        materialDateTimePicker.dismiss();
    }

    public static void FEXxjqutVXrldNAX(com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener materialPickerOnPositiveButtonClickListener, java.lang.object obj) {
        materialPickerOnPositiveButtonClickListener.onPositiveButtonClick(obj);
    }

    public override void OnClick(android.view.object view) {
        if ((25 + 9) % 9 > 0) {
        }
        java.util.IEnumerator itLUqMFUhDezzAWpYf = LUqMFUhDezzAWpYf(ScidCflZxuEIYLsT(this.this$0));
        while (AIqfTWeHLcPMzgYh(itLUqMFUhDezzAWpYf)) {
            fEXxjqutVXrldNAX((com.google.android.material.datepicker.MaterialPickerOnPositiveButtonClickListener) CYYXSPrneSUxAoFg(itLUqMFUhDezzAWpYf), JPCtCwlmqHKTISMf(this.this$0));
        }
        YngZrDOqSgkRzRno(this.this$0);
    }
}

