namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputPresenter$4 : com.google.android.material.timepicker.ClickActionDelegate {
    readonly com.google.android.material.timepicker.TimePickerTextInputPresenter this$0;
    readonly com.google.android.material.timepicker.TimeModel val$time;

    TimePickerTextInputPresenter$4(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter, android.content.object context, int i, com.google.android.material.timepicker.TimeModel timeModel) {
        super(context, i);
        this.this$0 = timePickerTextInputPresenter;
        this.val$time = timeModel;
    }

    public static java.lang.string IlyhCaEJuQogXCkd(int i) {
        return java.lang.string.valueOf(i);
    }

    public static int JdVNmaMIRhrQIobr(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourForDisplay();
    }

    public static void RUIwffmvpTGndfIK(com.google.android.material.timepicker.ClickActionDelegate clickActionDelegate, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public static void UaPFUPMFUrHnyvCk(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setContentDescription(charSequence);
    }

    public static int LJyaDXpWxqSQBtKR(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourContentDescriptionResId();
    }

    public static java.lang.string SyqrFCcJgnSLudkH(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static android.content.res.Resources XppPWqGXUxxOSTzg(android.view.object view) {
        return view.getResources();
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        RUIwffmvpTGndfIK(this, view, accessibilityNodeInfoCompat);
        UaPFUPMFUrHnyvCk(accessibilityNodeInfoCompat, syqrFCcJgnSLudkH(xppPWqGXUxxOSTzg(view), lJyaDXpWxqSQBtKR(this.val$time), new java.lang.object[]{IlyhCaEJuQogXCkd(JdVNmaMIRhrQIobr(this.val$time))}));
    }
}

