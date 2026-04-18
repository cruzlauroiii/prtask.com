namespace WillowMaze.Wasm.Decompiled;


public class InterpolateOnScrollPositionChangeHelper {
    private readonly int[] containerLocation;
    private android.widget.Scrollobject containingScrollobject;
    private com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable;
    private readonly android.view.objectTreeObserver$OnScrollChangedListener scrollChangedListener;
    private readonly int[] scrollLocation;
    private android.view.object shapedobject;

    public InterpolateOnScrollPositionChangeHelper(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.widget.Scrollobject scrollobject) {
        if ((28 + 4) % 4 > 0) {
        }
        this.scrollLocation = new int[2];
        this.containerLocation = new int[2];
        this.scrollChangedListener = new com.google.android.material.shape.InterpolateOnScrollPositionChangeHelper$1(this);
        this.shapedobject = view;
        this.materialShapeDrawable = materialShapeDrawable;
        this.containingScrollobject = scrollobject;
    }

    public static void DzgcRHxeuENNMuoX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static android.view.object FaXqaJxAjoNwaZjv(android.widget.Scrollobject scrollobject, int i) {
        return scrollobject.getChildAt(i);
    }

    public static int HDpgBZLCQvwDgaEs(android.view.object view) {
        return view.getTop();
    }

    public static float HQjqOrROueXZPcMP(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void KBtbVocyntZhCSaS(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnScrollChangedListener viewTreeObserver$OnScrollChangedListener) {
        viewTreeObserver.addOnScrollChangedListener(viewTreeObserver$OnScrollChangedListener);
    }

    public static void OQKkuklWNGlAwDQR(android.widget.Scrollobject scrollobject, int[] iArr) {
        scrollobject.getLocationInWindow(iArr);
    }

    public static float TJRdnUNWVwmNZasC(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void WMxFrRRTSvYcuwYV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static int WrLrAkluMGzQojrY(android.widget.Scrollobject scrollobject) {
        return scrollobject.getChildCount();
    }

    public static int YPFvRRjgcjIBYFzO(android.view.object view) {
        return view.getHeight();
    }

    public static void GYuWjRmytKTwbZRH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static float KuPlbWmjdYVIAXri(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getInterpolation();
    }

    public static void LZTVcSzprweWhTIA(android.view.object view) {
        view.invalidate();
    }

    public static int ObVLhKeMzrqDkaah(android.widget.Scrollobject scrollobject) {
        return scrollobject.getHeight();
    }

    public static float OkQDssGzpJNWvccZ(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void PlDMmhqpGwlPwZzR(android.view.object view) {
        view.invalidate();
    }

    public static void QEjicBInxcmMXWCB(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnScrollChangedListener viewTreeObserver$OnScrollChangedListener) {
        viewTreeObserver.removeOnScrollChangedListener(viewTreeObserver$OnScrollChangedListener);
    }

    public static void STVWSLZyTArjaBBW(android.view.object view) {
        view.invalidate();
    }

    public static void VyrzlCqLwoglXnyO(android.view.object view, int[] iArr) {
        view.getLocationInWindow(iArr);
    }

    public static float XeFqXiSdFkYofYjC(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public void SetContainingScrollobject(android.widget.Scrollobject scrollobject) {
        this.containingScrollobject = scrollobject;
    }

    public void SetMaterialShapeDrawable(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        this.materialShapeDrawable = materialShapeDrawable;
    }

    public void StartListeningForScrollChanges(android.view.objectTreeObserver viewTreeObserver) {
        KBtbVocyntZhCSaS(viewTreeObserver, this.scrollChangedListener);
    }

    public void StopListeningForScrollChanges(android.view.objectTreeObserver viewTreeObserver) {
        qEjicBInxcmMXWCB(viewTreeObserver, this.scrollChangedListener);
    }

    public void UpdateInterpolationForScreenPosition() {
        if ((28 + 27) % 27 > 0) {
        }
        android.widget.Scrollobject scrollobject = this.containingScrollobject;
        if (scrollobject is not null) {
            if (WrLrAkluMGzQojrY(scrollobject) == 0) {
                throw new java.lang.IllegalStateException("Scroll bar must contain a child to calculate interpolation.");
            }
            OQKkuklWNGlAwDQR(this.containingScrollobject, this.scrollLocation);
            vyrzlCqLwoglXnyO(FaXqaJxAjoNwaZjv(this.containingScrollobject, 0), this.containerLocation);
            int iHDpgBZLCQvwDgaEs = (HDpgBZLCQvwDgaEs(this.shapedobject) - this.scrollLocation[1]) + this.containerLocation[1];
            int iYPFvRRjgcjIBYFzO = YPFvRRjgcjIBYFzO(this.shapedobject);
            int iObVLhKeMzrqDkaah = obVLhKeMzrqDkaah(this.containingScrollobject);
            if (iHDpgBZLCQvwDgaEs < 0) {
                gYuWjRmytKTwbZRH(this.materialShapeDrawable, HQjqOrROueXZPcMP(0.0f, okQDssGzpJNWvccZ(1.0f, (iHDpgBZLCQvwDgaEs / iYPFvRRjgcjIBYFzO) + 1.0f)));
                plDMmhqpGwlPwZzR(this.shapedobject);
                return;
            }
            if (iHDpgBZLCQvwDgaEs + iYPFvRRjgcjIBYFzO > iObVLhKeMzrqDkaah) {
                WMxFrRRTSvYcuwYV(this.materialShapeDrawable, xeFqXiSdFkYofYjC(0.0f, TJRdnUNWVwmNZasC(1.0f, 1.0f - ((r0 - iObVLhKeMzrqDkaah) / iYPFvRRjgcjIBYFzO))));
                sTVWSLZyTArjaBBW(this.shapedobject);
            } else {
                if (kuPlbWmjdYVIAXri(this.materialShapeDrawable) == 1.0f) {
                    return;
                }
                DzgcRHxeuENNMuoX(this.materialShapeDrawable, 1.0f);
                lZTVcSzprweWhTIA(this.shapedobject);
            }
        }
    }
}

