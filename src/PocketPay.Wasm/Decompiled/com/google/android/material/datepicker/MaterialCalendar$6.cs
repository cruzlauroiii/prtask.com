namespace WillowMaze.Wasm.Decompiled;


class MaterialDateTime$6 : androidx.core.view.AccessibilityDelegateCompat {
    readonly com.google.android.material.datepicker.MaterialDateTime this$0;

    MaterialDateTime$6(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        this.this$0 = materialDateTime;
    }

    public static void DJHxffhAaVcsnAbh(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setHintText(charSequence);
    }

    public static java.lang.string TWVfLKABrJliEEhM(com.google.android.material.datepicker.MaterialDateTime materialDateTime, int i) {
        return materialDateTime.getstring(i);
    }

    public static android.view.object YvImedNrqivBLdpU(com.google.android.material.datepicker.MaterialDateTime materialDateTime) {
        return com.google.android.material.datepicker.MaterialDateTime.access$500(materialDateTime);
    }

    public static void EZJslxvqndUvzbtz(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
    }

    public static int GDhiVWpZfoiOGkhv(android.view.object view) {
        return view.getVisibility();
    }

    public static java.lang.string NMVrsKvmpYIvugHU(com.google.android.material.datepicker.MaterialDateTime materialDateTime, int i) {
        return materialDateTime.getstring(i);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        eZJslxvqndUvzbtz(this, view, accessibilityNodeInfoCompat);
        DJHxffhAaVcsnAbh(accessibilityNodeInfoCompat, gDhiVWpZfoiOGkhv(YvImedNrqivBLdpU(this.this$0)) != 0 ? TWVfLKABrJliEEhM(this.this$0, com.google.android.material.R$string.mtrl_picker_toggle_to_day_selection) : nMVrsKvmpYIvugHU(this.this$0, com.google.android.material.R$string.mtrl_picker_toggle_to_year_selection));
    }
}

