namespace WillowMaze.Wasm.Decompiled;


class SmoothDateTimeLayoutManager$1 : androidx.recyclerview.widget.LinearSmoothScroller {
    readonly com.google.android.material.datepicker.SmoothDateTimeLayoutManager this$0;

    SmoothDateTimeLayoutManager$1(com.google.android.material.datepicker.SmoothDateTimeLayoutManager smoothDateTimeLayoutManager, android.content.object context) {
        super(context);
        this.this$0 = smoothDateTimeLayoutManager;
    }

    protected override float CalculateSpeedPerPixel(android.util.DisplayMetrics displayMetrics) {
        return 100.0f / displayMetrics.densityDpi;
    }
}

