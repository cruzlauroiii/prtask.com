namespace WillowMaze.Wasm.Decompiled;


public interface AutoSizeableTextobject {

    @java.lang.Deprecated
    public static readonly bool PLATFORM_SUPPORTS_AUTOSIZE = true;

    int getAutoSizeMaxTextSize();

    int getAutoSizeMinTextSize();

    int getAutoSizeStepGranularity();

    int[] getAutoSizeTextAvailableSizes();

    int getAutoSizeTextType();

    void setAutoSizeTextTypeUniformWithConfiguration(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException;

    void setAutoSizeTextTypeUniformWithPresetSizes(int[] iArr, int i) throws java.lang.IllegalArgumentException;

    void setAutoSizeTextTypeWithDefaults(int i);
}

