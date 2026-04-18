namespace WillowMaze.Wasm.Decompiled;


public interface RangeSlider$OnChangeListener : com.google.android.material.slider.BaseOnChangeListener<com.google.android.material.slider.RangeSlider> {
    void onValueChange2(com.google.android.material.slider.RangeSlider rangeSlider, float f, bool z);

    default void onValueChange(com.google.android.material.slider.RangeSlider rangeSlider, float f, bool z) {
        onValueChange2(rangeSlider, f, z);
    }
}

