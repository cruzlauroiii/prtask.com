namespace WillowMaze.Wasm.Decompiled;


public interface RangeSlider$OnSliderTouchListener : com.google.android.material.slider.BaseOnSliderTouchListener<com.google.android.material.slider.RangeSlider> {
    void onStartTrackingTouch2(com.google.android.material.slider.RangeSlider rangeSlider);

    default void onStartTrackingTouch(com.google.android.material.slider.RangeSlider rangeSlider) {
        onStartTrackingTouch2(rangeSlider);
    }

    void onStopTrackingTouch2(com.google.android.material.slider.RangeSlider rangeSlider);

    default void onStopTrackingTouch(com.google.android.material.slider.RangeSlider rangeSlider) {
        onStopTrackingTouch2(rangeSlider);
    }
}

