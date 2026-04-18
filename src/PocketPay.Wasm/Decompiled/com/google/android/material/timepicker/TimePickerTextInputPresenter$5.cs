namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputPresenter$5 : com.google.android.material.timepicker.ClickActionDelegate {
    readonly com.google.android.material.timepicker.TimePickerTextInputPresenter this$0;
    readonly com.google.android.material.timepicker.TimeModel val$time;

    TimePickerTextInputPresenter$5(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter, android.content.object context, int i, com.google.android.material.timepicker.TimeModel timeModel) {
        super(context, i);
        this.this$0 = timePickerTextInputPresenter;
        this.val$time = timeModel;
    }

    public static java.lang.string FITunwXuopleUUED(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void GwTQwYccOKPzxdRS(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setContentDescription(charSequence);
    }

    public static java.lang.string AmevuUyrqqBfZxuM(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static void MMxJJVnePEWUVTsP(com.google.android.material.timepicker.ClickActionDelegate clickActionDelegate, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public static android.content.res.Resources VZMtRECSKMxHSsrR(android.view.object view) {
        return view.getResources();
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        mMxJJVnePEWUVTsP(this, view, accessibilityNodeInfoCompat);
        GwTQwYccOKPzxdRS(accessibilityNodeInfoCompat, amevuUyrqqBfZxuM(vZMtRECSKMxHSsrR(view), com.google.android.material.R$string.material_minute_suffix, new java.lang.object[]{FITunwXuopleUUED(this.val$time.minute)}));
    }
}

