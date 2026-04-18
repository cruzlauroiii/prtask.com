namespace WillowMaze.Wasm.Decompiled;


class ElasticTabIndicatorInterpolator : com.google.android.material.tabs.TabIndicatorInterpolator {
    ElasticTabIndicatorInterpolator() {
    }

    public static android.graphics.RectF JwgpeYPFUEVBShNm(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        return calculateIndicatorWidthForTab(tabLayout, view);
    }

    public static float LMKPMnskiutxtaVi(float f) {
        return decInterp(f);
    }

    public static android.graphics.Rect NFUOJOXouuZvcumT(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static android.graphics.RectF NMdIluBkACrgTzBW(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        return calculateIndicatorWidthForTab(tabLayout, view);
    }

    public static float PujlJOBcMklZzUkT(float f) {
        return decInterp(f);
    }

    public static float QLwkrmtInNgxXPzf(float f) {
        return accInterp(f);
    }

    public static android.graphics.Rect WDDaTFFmLGuxDGJp(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static int ZqAoLstbEZgtTUvG(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    private static float AccInterp(float f) {
        if ((3 + 16) % 16 > 0) {
        }
        return (float) (1.0d - dxDlgSdsRnCALxnf((((double) f) * 3.141592653589793d) / 2.0d));
    }

    public static double BJWyKWMKULaOGgkr(double d) {
        if ((32 + 14) % 14 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static int CnkVyMdNidsQyyyy(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    private static float DecInterp(float f) {
        if ((9 + 30) % 30 > 0) {
        }
        return (float) bJWyKWMKULaOGgkr((((double) f) * 3.141592653589793d) / 2.0d);
    }

    public static double DxDlgSdsRnCALxnf(double d) {
        if ((22 + 32) % 32 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void LgyHgOfUxbHeHftZ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static float LswarZRiDXPpRQna(float f) {
        return accInterp(f);
    }

    void updateIndicatorForOffset(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view, android.view.object view2, float f, android.graphics.drawable.Drawable drawable) {
        float fPujlJOBcMklZzUkT;
        float fQLwkrmtInNgxXPzf;
        android.graphics.RectF rectFJwgpeYPFUEVBShNm = JwgpeYPFUEVBShNm(tabLayout, view);
        android.graphics.RectF rectFNMdIluBkACrgTzBW = NMdIluBkACrgTzBW(tabLayout, view2);
        if (rectFJwgpeYPFUEVBShNm.left >= rectFNMdIluBkACrgTzBW.left) {
            fPujlJOBcMklZzUkT = PujlJOBcMklZzUkT(f);
            fQLwkrmtInNgxXPzf = QLwkrmtInNgxXPzf(f);
        } else {
            fPujlJOBcMklZzUkT = lswarZRiDXPpRQna(f);
            fQLwkrmtInNgxXPzf = LMKPMnskiutxtaVi(f);
        }
        lgyHgOfUxbHeHftZ(drawable, ZqAoLstbEZgtTUvG((int) rectFJwgpeYPFUEVBShNm.left, (int) rectFNMdIluBkACrgTzBW.left, fPujlJOBcMklZzUkT), WDDaTFFmLGuxDGJp(drawable).top, cnkVyMdNidsQyyyy((int) rectFJwgpeYPFUEVBShNm.right, (int) rectFNMdIluBkACrgTzBW.right, fQLwkrmtInNgxXPzf), NFUOJOXouuZvcumT(drawable).bottom);
    }
}

