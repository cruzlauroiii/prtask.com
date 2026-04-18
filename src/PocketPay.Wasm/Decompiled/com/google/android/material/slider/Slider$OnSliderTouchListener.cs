namespace WillowMaze.Wasm.Decompiled;


public interface Slider$OnSliderTouchListener : com.google.android.material.slider.BaseOnSliderTouchListener<com.google.android.material.slider.Slider> {
    void onStartTrackingTouch2(com.google.android.material.slider.Slider slider);

    default void onStartTrackingTouch(com.google.android.material.slider.Slider slider) {
        onStartTrackingTouch2(slider);
    }

    void onStopTrackingTouch2(com.google.android.material.slider.Slider slider);

    default void onStopTrackingTouch(com.google.android.material.slider.Slider slider) {
        onStopTrackingTouch2(slider);
    }
}

