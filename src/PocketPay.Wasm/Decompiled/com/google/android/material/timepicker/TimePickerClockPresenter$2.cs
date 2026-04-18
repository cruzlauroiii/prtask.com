namespace WillowMaze.Wasm.Decompiled;


class TimePickerClockPresenter$2 : com.google.android.material.timepicker.ClickActionDelegate {
    readonly com.google.android.material.timepicker.TimePickerClockPresenter this$0;

    TimePickerClockPresenter$2(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, android.content.object context, int i) {
        super(context, i);
        this.this$0 = timePickerClockPresenter;
    }

    public static com.google.android.material.timepicker.TimeModel FsesODtjHsfwdBVd(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return com.google.android.material.timepicker.TimePickerClockPresenter.access$000(timePickerClockPresenter);
    }

    public static android.content.res.Resources RfydpqekCaxlTbNW(android.view.object view) {
        return view.getResources();
    }

    public static java.lang.string PYCxeYbEXjFVYsqe(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static void WeKClPVgwLElsDEy(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setContentDescription(charSequence);
    }

    public static void XLHUjLVcrDlIbuJF(com.google.android.material.timepicker.ClickActionDelegate clickActionDelegate, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public static java.lang.string XXwjUymvUGSFqnmT(int i) {
        return java.lang.string.valueOf(i);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        xLHUjLVcrDlIbuJF(this, view, accessibilityNodeInfoCompat);
        weKClPVgwLElsDEy(accessibilityNodeInfoCompat, pYCxeYbEXjFVYsqe(RfydpqekCaxlTbNW(view), com.google.android.material.R$string.material_minute_suffix, new java.lang.object[]{xXwjUymvUGSFqnmT(FsesODtjHsfwdBVd(this.this$0).minute)}));
    }
}

