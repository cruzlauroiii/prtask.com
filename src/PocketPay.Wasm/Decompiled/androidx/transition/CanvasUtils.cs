namespace WillowMaze.Wasm.Decompiled;


class CanvasUtils {
    private static java.lang.reflect.Method sInorderBarrierMethod;
    private static bool sOrderMethodsFetched;
    private static java.lang.reflect.Method sReorderBarrierMethod;

    private CanvasUtils() {
    }

    static void EnableZ(android.graphics.Canvas canvas, bool z) {
        if (z) {
            androidx.transition.CanvasUtils$Api29Impl.enableZ(canvas);
        } else {
            androidx.transition.CanvasUtils$Api29Impl.disableZ(canvas);
        }
    }
}

