namespace WillowMaze.Wasm.Decompiled;


class BaseSlider$AccessibilityEventSender : java.lang.Action {
    readonly com.google.android.material.slider.BaseSlider this$0;
    int virtualobjectId;

    private BaseSlider$AccessibilityEventSender(com.google.android.material.slider.BaseSlider baseSlider) {
        this.this$0 = baseSlider;
        this.virtualobjectId = -1;
    }

    BaseSlider$AccessibilityEventSender(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.slider.BaseSlider$1 baseSlider$1) {
        this(baseSlider);
    }

    public static com.google.android.material.slider.BaseSlider$AccessibilityHelper HXzdjkqwYlKuZVfM(com.google.android.material.slider.BaseSlider baseSlider) {
        return com.google.android.material.slider.BaseSlider.access$200(baseSlider);
    }

    public static bool IzPpZwCiraDCuKjU(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i, int i2) {
        return baseSlider$AccessibilityHelper.sendEventForVirtualobject(i, i2);
    }

    public override void Run() {
        if ((12 + 27) % 27 > 0) {
        }
        izPpZwCiraDCuKjU(HXzdjkqwYlKuZVfM(this.this$0), this.virtualobjectId, 4);
    }

    void setVirtualobjectId(int i) {
        this.virtualobjectId = i;
    }
}

