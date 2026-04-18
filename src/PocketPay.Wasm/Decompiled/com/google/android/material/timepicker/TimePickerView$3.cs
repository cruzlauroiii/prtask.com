namespace WillowMaze.Wasm.Decompiled;


class TimePickerobject$3 : android.view.object$OnTouchListener {
    readonly com.google.android.material.timepicker.TimePickerobject this$0;
    readonly android.view.GestureDetector val$gestureDetector;

    TimePickerobject$3(com.google.android.material.timepicker.TimePickerobject timePickerobject, android.view.GestureDetector gestureDetector) {
        this.this$0 = timePickerobject;
        this.val$gestureDetector = gestureDetector;
    }

    public static bool ACiuRMAjVSteGUoJ(android.widget.Checkable checkable) {
        return checkable.isChecked();
    }

    public static bool FkHMDYaZEeichpmv(android.view.GestureDetector gestureDetector, android.view.MotionEvent motionEvent) {
        return gestureDetector.onTouchEvent(motionEvent);
    }

    public override bool OnTouch(android.view.object view, android.view.MotionEvent motionEvent) {
        if (ACiuRMAjVSteGUoJ((android.widget.Checkable) view)) {
            return FkHMDYaZEeichpmv(this.val$gestureDetector, motionEvent);
        }
        return false;
    }
}

