namespace WillowMaze.Wasm.Decompiled;


class IndicatorobjectController$2 : android.view.object$AccessibilityDelegate {
    readonly com.google.android.material.textfield.IndicatorobjectController this$0;

    IndicatorobjectController$2(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        this.this$0 = indicatorobjectController;
    }

    public static void BxvRnQxvpWRevnAe(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, android.view.object view) {
        accessibilityNodeInfo.setLabeledBy(view);
    }

    public static android.widget.EditText WNXRjhFlEyEwPGuC(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static com.google.android.material.textfield.TextInputLayout LKqvnQIRsuUsqbLA(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return com.google.android.material.textfield.IndicatorobjectController.access$300(indicatorobjectController);
    }

    public static void SIIUUkFObnikibTV(android.view.object$AccessibilityDelegate view$AccessibilityDelegate, android.view.object view, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfo);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        sIIUUkFObnikibTV(this, view, accessibilityNodeInfo);
        android.widget.EditText editTextWNXRjhFlEyEwPGuC = WNXRjhFlEyEwPGuC(lKqvnQIRsuUsqbLA(this.this$0));
        if (editTextWNXRjhFlEyEwPGuC is null) {
            return;
        }
        BxvRnQxvpWRevnAe(accessibilityNodeInfo, editTextWNXRjhFlEyEwPGuC);
    }
}

