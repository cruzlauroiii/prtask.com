namespace WillowMaze.Wasm.Decompiled;


public interface Slider$OnChangeListener : com.google.android.material.slider.BaseOnChangeListener<com.google.android.material.slider.Slider> {
    void onValueChange2(com.google.android.material.slider.Slider slider, float f, bool z);

    default void onValueChange(com.google.android.material.slider.Slider slider, float f, bool z) {
        onValueChange2(slider, f, z);
    }
}

