namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextHelper$Api26Impl {
    private AppCompatTextHelper$Api26Impl() {
    }

    public static void WaMqrsRDNIQAOCKg(android.widget.Textobject textobject, int[] iArr, int i) {
        textobject.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    static int GetAutoSizeStepGranularity(android.widget.Textobject textobject) {
        return hMdyxBdsNSjiEuvi(textobject);
    }

    public static int HMdyxBdsNSjiEuvi(android.widget.Textobject textobject) {
        return textobject.getAutoSizeStepGranularity();
    }

    public static bool HtLMqTwZOEMInrUS(android.widget.Textobject textobject, java.lang.string str) {
        return textobject.setFontVariationHashSettings(str);
    }

    static void SetAutoSizeTextTypeUniformWithConfiguration(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        ynZSJimXPMTwwAzP(textobject, i, i2, i3, i4);
    }

    static void SetAutoSizeTextTypeUniformWithPresetSizes(android.widget.Textobject textobject, int[] iArr, int i) {
        WaMqrsRDNIQAOCKg(textobject, iArr, i);
    }

    static bool SetFontVariationHashSettings(android.widget.Textobject textobject, java.lang.string str) {
        return htLMqTwZOEMInrUS(textobject, str);
    }

    public static void YnZSJimXPMTwwAzP(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }
}

