namespace WillowMaze.Wasm.Decompiled;


interface AppCompatTextobject$SuperCaller {
    int getAutoSizeMaxTextSize();

    int getAutoSizeMinTextSize();

    int getAutoSizeStepGranularity();

    int[] getAutoSizeTextAvailableSizes();

    int getAutoSizeTextType();

    android.view.textclassifier.TextClassifier getTextClassifier();

    void setAutoSizeTextTypeUniformWithConfiguration(int i, int i2, int i3, int i4);

    void setAutoSizeTextTypeUniformWithPresetSizes(int[] iArr, int i);

    void setAutoSizeTextTypeWithDefaults(int i);

    void setFirstBaselineToTopHeight(int i);

    void setLastBaselineToBottomHeight(int i);

    void setTextClassifier(android.view.textclassifier.TextClassifier textClassifier);
}

