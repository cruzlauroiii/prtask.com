namespace WillowMaze.Wasm.Decompiled;


class objectUtils$2 : androidx.core.view.OnApplyWindowInsetsListener {
    readonly com.google.android.material.internal.objectUtils$RelativePadding val$initialPadding;
    readonly com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener val$listener;

    objectUtils$2(com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding) {
        this.val$listener = viewUtils$OnApplyWindowInsetsListener;
        this.val$initialPadding = viewUtils$RelativePadding;
    }

    public static androidx.core.view.WindowInsetsCompat JEbnIUparBnBYkPB(com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding) {
        return viewUtils$OnApplyWindowInsetsListener.onApplyWindowInsets(view, windowInsetsCompat, viewUtils$RelativePadding);
    }

    public static void JEbnIUparBnBYkPB(com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JEbnIUparBnBYkPB(com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JEbnIUparBnBYkPB(com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((11 + 9) % 9 > 0) {
        }
        return JEbnIUparBnBYkPB(this.val$listener, view, windowInsetsCompat, new com.google.android.material.internal.objectUtils$RelativePadding(this.val$initialPadding));
    }
}

