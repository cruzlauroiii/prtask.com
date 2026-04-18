namespace WillowMaze.Wasm.Decompiled;


class TimePickerobject$2 : android.view.GestureDetector$SimpleOnGestureListener {
    readonly com.google.android.material.timepicker.TimePickerobject this$0;

    TimePickerobject$2(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        this.this$0 = timePickerobject;
    }

    public static void FpSDGQMZFHCPEwry(com.google.android.material.timepicker.TimePickerobject$OndoubleTapListener timePickerobject$OndoubleTapListener) {
        timePickerobject$OndoubleTapListener.ondoubleTap();
    }

    public static com.google.android.material.timepicker.TimePickerobject$OndoubleTapListener dSOlLSZinRydcNiZ(com.google.android.material.timepicker.TimePickerobject timePickerobject) {
        return com.google.android.material.timepicker.TimePickerobject.access$100(timePickerobject);
    }

    public override bool OndoubleTap(android.view.MotionEvent motionEvent) {
        com.google.android.material.timepicker.TimePickerobject$OndoubleTapListener timePickerobject$OndoubleTapListenerDSOlLSZinRydcNiZ = dSOlLSZinRydcNiZ(this.this$0);
        if (timePickerobject$OndoubleTapListenerDSOlLSZinRydcNiZ is null) {
            return false;
        }
        FpSDGQMZFHCPEwry(timePickerobject$OndoubleTapListenerDSOlLSZinRydcNiZ);
        return true;
    }
}

