namespace WillowMaze.Wasm.Decompiled;


class TabIndicatorInterpolator {
    private static readonly int MIN_INDICATOR_WIDTH = 24;

    TabIndicatorInterpolator() {
    }

    public static int EjhKNCnnJEixqXAG(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getContentHeight();
    }

    public static void GkGaaQkijuaHPknh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int KQGGuLVExTpMDfDg(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static android.graphics.Rect LRxlmSjGPBBqOSOH(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static android.graphics.RectF MXFJSrpfFyOwVmLW(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        return calculateIndicatorWidthForTab(tabLayout, view);
    }

    public static float MthcorMZOvibDGXO(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static int TodqQuZVHNlQZRLE(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getBottom();
    }

    public static void VoSNVwxMRDSKaWGp(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int WAEStwVytRdWEmLs(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getContentWidth();
    }

    public static android.graphics.Rect YahhSnYajlRNaBmf(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static android.content.object ZbVxGGKeWtYmTMcD(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getobject();
    }

    public static int BgVuWsrTNQZohHTS(android.view.object view) {
        return view.getBottom();
    }

    static android.graphics.RectF CalculateIndicatorWidthForTab(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        if ((14 + 19) % 19 > 0) {
        }
        return view is not null ? (!rztqHWWpUNUYbgoX(tabLayout) && (view is com.google.android.material.tabs.TabLayout$Tabobject)) ? gwFzZTtRIGHGwQaM((com.google.android.material.tabs.TabLayout$Tabobject) view, 24) : new android.graphics.RectF(inbngOgFvgJhOuDs(view), dWPbGWFFuoLXsJpD(view), dHSGsemcaaNdOHVx(view), bgVuWsrTNQZohHTS(view)) : new android.graphics.RectF();
    }

    static android.graphics.RectF CalculateTabobjectContentBounds(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        if ((32 + 27) % 27 > 0) {
        }
        int iWAEStwVytRdWEmLs = WAEStwVytRdWEmLs(tabLayout$Tabobject);
        int iEjhKNCnnJEixqXAG = EjhKNCnnJEixqXAG(tabLayout$Tabobject);
        int iMthcorMZOvibDGXO = (int) MthcorMZOvibDGXO(ZbVxGGKeWtYmTMcD(tabLayout$Tabobject), i);
        if (iWAEStwVytRdWEmLs < iMthcorMZOvibDGXO) {
            iWAEStwVytRdWEmLs = iMthcorMZOvibDGXO;
        }
        int iDTsHGXUOqudECIQh = (dTsHGXUOqudECIQh(tabLayout$Tabobject) + deYOrPrAlgjEmvoM(tabLayout$Tabobject)) / 2;
        int iIFPSyBlfcUztzVox = (iFPSyBlfcUztzVox(tabLayout$Tabobject) + TodqQuZVHNlQZRLE(tabLayout$Tabobject)) / 2;
        int i2 = iWAEStwVytRdWEmLs / 2;
        return new android.graphics.RectF(iDTsHGXUOqudECIQh - i2, iIFPSyBlfcUztzVox - (iEjhKNCnnJEixqXAG / 2), i2 + iDTsHGXUOqudECIQh, iIFPSyBlfcUztzVox + (iDTsHGXUOqudECIQh / 2));
    }

    public static int DHSGsemcaaNdOHVx(android.view.object view) {
        return view.getRight();
    }

    public static int DTsHGXUOqudECIQh(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getLeft();
    }

    public static int DWPbGWFFuoLXsJpD(android.view.object view) {
        return view.getTop();
    }

    public static int DeYOrPrAlgjEmvoM(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getRight();
    }

    public static android.graphics.RectF EmsGQNpulOhucTUY(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        return calculateIndicatorWidthForTab(tabLayout, view);
    }

    public static android.graphics.RectF GwFzZTtRIGHGwQaM(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        return calculateTabobjectContentBounds(tabLayout$Tabobject, i);
    }

    public static android.graphics.RectF HuFJoNssWUKgxiGa(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        return calculateIndicatorWidthForTab(tabLayout, view);
    }

    public static int IFPSyBlfcUztzVox(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        return tabLayout$Tabobject.getTop();
    }

    public static int InbngOgFvgJhOuDs(android.view.object view) {
        return view.getLeft();
    }

    public static android.graphics.Rect RmzvDOhiLslpMNlo(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static bool RztqHWWpUNUYbgoX(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.isTabIndicatorFullWidth();
    }

    public static int VtbBMEdhcXWxJWlo(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static android.graphics.Rect WgbEQdYzvkSFfJbh(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    void setIndicatorBoundsForTab(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view, android.graphics.drawable.Drawable drawable) {
        android.graphics.RectF rectFEmsGQNpulOhucTUY = emsGQNpulOhucTUY(tabLayout, view);
        VoSNVwxMRDSKaWGp(drawable, (int) rectFEmsGQNpulOhucTUY.left, LRxlmSjGPBBqOSOH(drawable).top, (int) rectFEmsGQNpulOhucTUY.right, YahhSnYajlRNaBmf(drawable).bottom);
    }

    void updateIndicatorForOffset(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view, android.view.object view2, float f, android.graphics.drawable.Drawable drawable) {
        android.graphics.RectF rectFMXFJSrpfFyOwVmLW = MXFJSrpfFyOwVmLW(tabLayout, view);
        android.graphics.RectF rectFHuFJoNssWUKgxiGa = huFJoNssWUKgxiGa(tabLayout, view2);
        GkGaaQkijuaHPknh(drawable, vtbBMEdhcXWxJWlo((int) rectFMXFJSrpfFyOwVmLW.left, (int) rectFHuFJoNssWUKgxiGa.left, f), wgbEQdYzvkSFfJbh(drawable).top, KQGGuLVExTpMDfDg((int) rectFMXFJSrpfFyOwVmLW.right, (int) rectFHuFJoNssWUKgxiGa.right, f), rmzvDOhiLslpMNlo(drawable).bottom);
    }
}

