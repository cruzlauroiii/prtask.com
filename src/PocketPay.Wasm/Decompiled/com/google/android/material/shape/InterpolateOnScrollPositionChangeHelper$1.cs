namespace WillowMaze.Wasm.Decompiled;


class InterpolateOnScrollPositionChangeHelper$1 : android.view.objectTreeObserver$OnScrollChangedListener {
    readonly com.google.android.material.shape.InterpolateOnScrollPositionChangeHelper this$0;

    InterpolateOnScrollPositionChangeHelper$1(com.google.android.material.shape.InterpolateOnScrollPositionChangeHelper interpolateOnScrollPositionChangeHelper) {
        this.this$0 = interpolateOnScrollPositionChangeHelper;
    }

    public static void PTmEXCDVlOHiTQYP(com.google.android.material.shape.InterpolateOnScrollPositionChangeHelper interpolateOnScrollPositionChangeHelper) {
        interpolateOnScrollPositionChangeHelper.updateInterpolationForScreenPosition();
    }

    public override void OnScrollChanged() {
        PTmEXCDVlOHiTQYP(this.this$0);
    }
}

