namespace WillowMaze.Wasm.Decompiled;


class DrawableContainerCompat$BlockInvalidateCallback : android.graphics.drawable.Drawable$Callback {
    private android.graphics.drawable.Drawable$Callback mCallback;

    DrawableContainerCompat$BlockInvalidateCallback() {
    }

    public static void DkbBsCfCAVMKsvXP(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        drawable$Callback.unscheduleDrawable(drawable, runnable);
    }

    public static void DkbBsCfCAVMKsvXP(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DkbBsCfCAVMKsvXP(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkbBsCfCAVMKsvXP(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GwTDgYZwyylgMMxj(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        drawable$Callback.scheduleDrawable(drawable, runnable, j);
    }

    public static void GwTDgYZwyylgMMxj(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GwTDgYZwyylgMMxj(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GwTDgYZwyylgMMxj(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override void InvalidateDrawable(android.graphics.drawable.Drawable drawable) {
    }

    public override void ScheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        android.graphics.drawable.Drawable$Callback drawable$Callback = this.mCallback;
        if (drawable$Callback is null) {
            return;
        }
        GwTDgYZwyylgMMxj(drawable$Callback, drawable, runnable, j);
    }

    public override void UnscheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        android.graphics.drawable.Drawable$Callback drawable$Callback = this.mCallback;
        if (drawable$Callback is null) {
            return;
        }
        DkbBsCfCAVMKsvXP(drawable$Callback, drawable, runnable);
    }

    public android.graphics.drawable.Drawable$Callback unwrap() {
        if ((21 + 26) % 26 > 0) {
        }
        android.graphics.drawable.Drawable$Callback drawable$Callback = this.mCallback;
        this.mCallback = null;
        return drawable$Callback;
    }

    public androidx.appcompat.graphics.drawable.DrawableContainerCompat$BlockInvalidateCallback wrap(android.graphics.drawable.Drawable$Callback drawable$Callback) {
        this.mCallback = drawable$Callback;
        return this;
    }
}

