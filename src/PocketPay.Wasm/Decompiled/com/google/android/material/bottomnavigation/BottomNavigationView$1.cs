namespace WillowMaze.Wasm.Decompiled;


class BottomNavigationobject$1 : com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener {
    readonly com.google.android.material.bottomnavigation.BottomNavigationobject this$0;

    BottomNavigationobject$1(com.google.android.material.bottomnavigation.BottomNavigationobject bottomNavigationobject) {
        this.this$0 = bottomNavigationobject;
    }

    public static void NQOzjAdzgfdbZEkb(com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, android.view.object view) {
        viewUtils$RelativePadding.applyToobject(view);
    }

    public static void NQOzjAdzgfdbZEkb(com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, android.view.object view, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NQOzjAdzgfdbZEkb(com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, android.view.object view, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NQOzjAdzgfdbZEkb(com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding, android.view.object view, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NheAvQBoZmCyKegP(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static void NheAvQBoZmCyKegP(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NheAvQBoZmCyKegP(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NheAvQBoZmCyKegP(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TFdDEcRMRuAJaiYO(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static void TFdDEcRMRuAJaiYO(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFdDEcRMRuAJaiYO(androidx.core.view.WindowInsetsCompat windowInsetsCompat, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TFdDEcRMRuAJaiYO(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DAxlwpzfhxDMXhEP(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void DAxlwpzfhxDMXhEP(android.view.object view, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DAxlwpzfhxDMXhEP(android.view.object view, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DAxlwpzfhxDMXhEP(android.view.object view, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LZBeCKmNxoVZNrSz(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static void LZBeCKmNxoVZNrSz(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZBeCKmNxoVZNrSz(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LZBeCKmNxoVZNrSz(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding) {
        if ((16 + 19) % 19 > 0) {
        }
        viewUtils$RelativePadding.bottom += NheAvQBoZmCyKegP(windowInsetsCompat);
        bool z = dAxlwpzfhxDMXhEP(view) == 1;
        int iTFdDEcRMRuAJaiYO = TFdDEcRMRuAJaiYO(windowInsetsCompat);
        int iLZBeCKmNxoVZNrSz = lZBeCKmNxoVZNrSz(windowInsetsCompat);
        viewUtils$RelativePadding.start += !z ? iTFdDEcRMRuAJaiYO : iLZBeCKmNxoVZNrSz;
        int i = viewUtils$RelativePadding.end;
        if (!z) {
            iTFdDEcRMRuAJaiYO = iLZBeCKmNxoVZNrSz;
        }
        viewUtils$RelativePadding.end = i + iTFdDEcRMRuAJaiYO;
        NQOzjAdzgfdbZEkb(viewUtils$RelativePadding, view);
        return windowInsetsCompat;
    }
}

