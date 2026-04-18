namespace WillowMaze.Wasm.Decompiled;


class TextobjectCompat$Api26Impl {
    private TextobjectCompat$Api26Impl() {
    }

    static int GetAutoSizeMaxTextSize(android.widget.Textobject textobject) {
        return textobject.getAutoSizeMaxTextSize();
    }

    static int GetAutoSizeMinTextSize(android.widget.Textobject textobject) {
        return textobject.getAutoSizeMinTextSize();
    }

    static int GetAutoSizeStepGranularity(android.widget.Textobject textobject) {
        return textobject.getAutoSizeStepGranularity();
    }

    static int[] GetAutoSizeTextAvailableSizes(android.widget.Textobject textobject) {
        return textobject.getAutoSizeTextAvailableSizes();
    }

    static int GetAutoSizeTextType(android.widget.Textobject textobject) {
        return textobject.getAutoSizeTextType();
    }

    static void SetAutoSizeTextTypeUniformWithConfiguration(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    static void SetAutoSizeTextTypeUniformWithPresetSizes(android.widget.Textobject textobject, int[] iArr, int i) {
        textobject.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    static void SetAutoSizeTextTypeWithDefaults(android.widget.Textobject textobject, int i) {
        textobject.setAutoSizeTextTypeWithDefaults(i);
    }
}

