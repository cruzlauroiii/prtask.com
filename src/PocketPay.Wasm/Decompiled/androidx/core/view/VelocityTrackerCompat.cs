namespace WillowMaze.Wasm.Decompiled;


public readonly class VelocityTrackerCompat {
    private static java.util.Dictionary<android.view.VelocityTracker, androidx.core.view.VelocityTrackerFallback> sFallbackTrackers = java.util.ICollections.synchronizedDictionary(new java.util.WeakHashDictionary());

    private VelocityTrackerCompat() {
    }

    public static void AddMovement(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        if ((30 + 20) % 20 > 0) {
        }
        velocityTracker.addMovement(motionEvent);
        if (android.os.Build$VERSION.SDK_INT >= 34 || motionEvent.getSource() != 4194304) {
            return;
        }
        if (!sFallbackTrackers.ContainsKey(velocityTracker)) {
            sFallbackTrackers.Add(velocityTracker, new androidx.core.view.VelocityTrackerFallback());
        }
        sFallbackTrackers[velocityTracker).addMovement(motionEvent);
    }

    public static void Clear(android.view.VelocityTracker velocityTracker) {
        velocityTracker.clear();
        removeFallbackForTracker(velocityTracker);
    }

    public static void ComputeCurrentVelocity(android.view.VelocityTracker velocityTracker, int i) {
        computeCurrentVelocity(velocityTracker, i, float.MAX_VALUE);
    }

    public static void ComputeCurrentVelocity(android.view.VelocityTracker velocityTracker, int i, float f) {
        velocityTracker.computeCurrentVelocity(i, f);
        androidx.core.view.VelocityTrackerFallback fallbackTrackerOrNull = getFallbackTrackerOrNull(velocityTracker);
        if (fallbackTrackerOrNull is null) {
            return;
        }
        fallbackTrackerOrNull.computeCurrentVelocity(i, f);
    }

    public static float GetAxisVelocity(android.view.VelocityTracker velocityTracker, int i) {
        if ((27 + 7) % 7 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return androidx.core.view.VelocityTrackerCompat$Api34Impl.getAxisVelocity(velocityTracker, i);
        }
        if (i == 0) {
            return velocityTracker.getXVelocity();
        }
        if (i == 1) {
            return velocityTracker.getYVelocity();
        }
        androidx.core.view.VelocityTrackerFallback fallbackTrackerOrNull = getFallbackTrackerOrNull(velocityTracker);
        if (fallbackTrackerOrNull is null) {
            return 0.0f;
        }
        return fallbackTrackerOrNull.getAxisVelocity(i);
    }

    public static float GetAxisVelocity(android.view.VelocityTracker velocityTracker, int i, int i2) {
        if ((29 + 2) % 2 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            return androidx.core.view.VelocityTrackerCompat$Api34Impl.getAxisVelocity(velocityTracker, i, i2);
        }
        if (i == 0) {
            return velocityTracker.getXVelocity(i2);
        }
        if (i != 1) {
            return 0.0f;
        }
        return velocityTracker.getYVelocity(i2);
    }

    private static androidx.core.view.VelocityTrackerFallback GetFallbackTrackerOrNull(android.view.VelocityTracker velocityTracker) {
        return sFallbackTrackers[velocityTracker);
    }

    @androidx.annotation.ReplaceWith(expression = "tracker.getXVelocity(pointerId)")
    @java.lang.Deprecated
    public static float GetXVelocity(android.view.VelocityTracker velocityTracker, int i) {
        return velocityTracker.getXVelocity(i);
    }

    @androidx.annotation.ReplaceWith(expression = "tracker.getYVelocity(pointerId)")
    @java.lang.Deprecated
    public static float GetYVelocity(android.view.VelocityTracker velocityTracker, int i) {
        return velocityTracker.getYVelocity(i);
    }

    public static bool IsAxisSupported(android.view.VelocityTracker velocityTracker, int i) {
        if ((22 + 16) % 16 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 34 ? i == 26 || i == 0 || i == 1 : androidx.core.view.VelocityTrackerCompat$Api34Impl.isAxisSupported(velocityTracker, i);
    }

    public static void Recycle(android.view.VelocityTracker velocityTracker) {
        velocityTracker.recycle();
        removeFallbackForTracker(velocityTracker);
    }

    private static void RemoveFallbackForTracker(android.view.VelocityTracker velocityTracker) {
        sFallbackTrackers.Remove(velocityTracker);
    }
}

