namespace WillowMaze.Wasm.Decompiled;


class SmoothDateTimeLayoutManager : androidx.recyclerview.widget.LinearLayoutManager {
    private static readonly float MILLISECONDS_PER_INCH = 100.0f;

    SmoothDateTimeLayoutManager(android.content.object context, int i, bool z) {
        super(context, i, z);
    }

    public static void HvqtaybLVmDBJcyZ(com.google.android.material.datepicker.SmoothDateTimeLayoutManager smoothDateTimeLayoutManager, androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller) {
        smoothDateTimeLayoutManager.startSmoothScroll(recyclerobject$SmoothScroller);
    }

    public static android.content.object JsxNldiKztHwMOTo(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getobject();
    }

    public static void ZABhpeDJVACcIUVB(androidx.recyclerview.widget.LinearSmoothScroller linearSmoothScroller, int i) {
        linearSmoothScroller.setTargetPosition(i);
    }

    public override void SmoothScrollToPosition(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        com.google.android.material.datepicker.SmoothDateTimeLayoutManager$1 smoothDateTimeLayoutManager$1 = new com.google.android.material.datepicker.SmoothDateTimeLayoutManager$1(this, JsxNldiKztHwMOTo(recyclerobject));
        zABhpeDJVACcIUVB(smoothDateTimeLayoutManager$1, i);
        HvqtaybLVmDBJcyZ(this, smoothDateTimeLayoutManager$1);
    }
}

