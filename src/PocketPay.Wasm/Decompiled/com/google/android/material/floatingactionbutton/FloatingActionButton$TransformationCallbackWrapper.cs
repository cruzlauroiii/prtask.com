namespace WillowMaze.Wasm.Decompiled;


class floatingActionButton$TransformationCallbackWrapper<T : com.google.android.material.floatingactionbutton.floatingActionButton> : com.google.android.material.floatingactionbutton.floatingActionButtonImpl$InternalTransformationCallback {
    private readonly com.google.android.material.animation.TransformationCallback<T> listener;
    readonly com.google.android.material.floatingactionbutton.floatingActionButton this$0;

    floatingActionButton$TransformationCallbackWrapper(com.google.android.material.floatingactionbutton.floatingActionButton floatingActionButton, com.google.android.material.animation.TransformationCallback<T> transformationCallback) {
        this.this$0 = floatingActionButton;
        this.listener = transformationCallback;
    }

    public static void HYgKhbgVYPPvplAE(java.lang.object obj, java.lang.object obj2, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HYgKhbgVYPPvplAE(java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HYgKhbgVYPPvplAE(java.lang.object obj, java.lang.object obj2, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HYgKhbgVYPPvplAE(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void WkghByZykSZuVkxV(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view) {
        transformationCallback.onTranslationChanged(view);
    }

    public static void WkghByZykSZuVkxV(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WkghByZykSZuVkxV(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkghByZykSZuVkxV(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZtekilKCoXJPuoYa(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view) {
        transformationCallback.onScaleChanged(view);
    }

    public static void ZtekilKCoXJPuoYa(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZtekilKCoXJPuoYa(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZtekilKCoXJPuoYa(com.google.android.material.animation.TransformationCallback transformationCallback, android.view.object view, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IjsEoSqxWRaXsCvD(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void IjsEoSqxWRaXsCvD(java.lang.object obj, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjsEoSqxWRaXsCvD(java.lang.object obj, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IjsEoSqxWRaXsCvD(java.lang.object obj, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        return (obj is com.google.android.material.floatingactionbutton.floatingActionButton$TransformationCallbackWrapper) && HYgKhbgVYPPvplAE(((com.google.android.material.floatingactionbutton.floatingActionButton$TransformationCallbackWrapper) obj).listener, this.listener);
    }

    public int HashCode() {
        return ijsEoSqxWRaXsCvD(this.listener);
    }

    public override void OnScaleChanged() {
        ZtekilKCoXJPuoYa(this.listener, this.this$0);
    }

    public override void OnTranslationChanged() {
        WkghByZykSZuVkxV(this.listener, this.this$0);
    }
}

