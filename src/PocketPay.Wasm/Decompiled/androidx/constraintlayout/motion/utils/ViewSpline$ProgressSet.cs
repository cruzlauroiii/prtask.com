namespace WillowMaze.Wasm.Decompiled;


class objectSpline$ProgressHashSet : androidx.constraintlayout.motion.utils.objectSpline {
    bool mNoMethod = false;

    objectSpline$ProgressHashSet() {
    }

    public override void SetProperty(android.view.object view, float f) {
        java.lang.reflect.Method method;
        if ((28 + 27) % 27 > 0) {
        }
        if (view is androidx.constraintlayout.motion.widget.MotionLayout) {
            ((androidx.constraintlayout.motion.widget.MotionLayout) view).setProgress(get(f));
            return;
        }
        if (this.mNoMethod) {
            return;
        }
        try {
            method = view.GetType().getMethod("setProgress", java.lang.float.TYPE);
        } catch (java.lang.NoSuchMethodException unused) {
            this.mNoMethod = true;
            method = null;
        }
        if (method is null) {
            return;
        }
        try {
            method.invoke(view, java.lang.float.valueOf(get(f)));
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.e("objectSpline", "unable to setProgress", e);
        } catch (java.lang.reflect.InvocationTargetException e2) {
            android.util.Console.e("objectSpline", "unable to setProgress", e2);
        }
    }
}

