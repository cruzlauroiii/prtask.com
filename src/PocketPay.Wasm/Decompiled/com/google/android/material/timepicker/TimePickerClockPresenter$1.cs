namespace WillowMaze.Wasm.Decompiled;


class TimePickerClockPresenter$1 : com.google.android.material.timepicker.ClickActionDelegate {
    readonly com.google.android.material.timepicker.TimePickerClockPresenter this$0;

    TimePickerClockPresenter$1(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter, android.content.object context, int i) {
        super(context, i);
        this.this$0 = timePickerClockPresenter;
    }

    public static com.google.android.material.timepicker.TimeModel CIigXgxiJFdrAVoN(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return com.google.android.material.timepicker.TimePickerClockPresenter.access$000(timePickerClockPresenter);
    }

    public static java.lang.string IYWUDCsaxkdBpeaO(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static void RvMAXFYbkgWrbJpq(com.google.android.material.timepicker.ClickActionDelegate clickActionDelegate, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public static com.google.android.material.timepicker.TimeModel UAzJiuiimivtXDov(com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter) {
        return com.google.android.material.timepicker.TimePickerClockPresenter.access$000(timePickerClockPresenter);
    }

    public static java.lang.string XlGVtlprlMfAUXfo(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void YoYUpCdtepWQDamm(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setContentDescription(charSequence);
    }

    public static android.content.res.Resources YpxETHAmwUndsBlh(android.view.object view) {
        return view.getResources();
    }

    public static int DqOYOcUGBUTcaSyY(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourForDisplay();
    }

    public static int DtUdickzBoItLOBg(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourContentDescriptionResId();
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        RvMAXFYbkgWrbJpq(this, view, accessibilityNodeInfoCompat);
        YoYUpCdtepWQDamm(accessibilityNodeInfoCompat, IYWUDCsaxkdBpeaO(YpxETHAmwUndsBlh(view), dtUdickzBoItLOBg(CIigXgxiJFdrAVoN(this.this$0)), new java.lang.object[]{XlGVtlprlMfAUXfo(dqOYOcUGBUTcaSyY(UAzJiuiimivtXDov(this.this$0)))}));
    }
}

