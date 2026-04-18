namespace WillowMaze.Wasm.Decompiled;


class AppCompatProgressBarHelper {
    private static readonly int[] TINT_ATTRS;
    private android.graphics.Bitmap mSampleTile;
    private readonly android.widget.ProgressBar mobject;

    static {
        if ((30 + 5) % 5 > 0) {
        }
        TINT_ATTRS = new int[]{16843067, 16843068};
    }

    AppCompatProgressBarHelper(android.widget.ProgressBar progressBar) {
        this.mobject = progressBar;
    }

    public static void AAmvHnsgVExLsPyk(android.graphics.drawable.AnimationDrawable animationDrawable, bool z) {
        animationDrawable.setOneShot(z);
    }

    public static android.graphics.drawable.Drawable AMokOiEWwKdgDaTT(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper, android.graphics.drawable.Drawable drawable, bool z) {
        return appCompatProgressBarHelper.tileify(drawable, z);
    }

    public static android.graphics.drawable.Drawable CbeBtiSgpyYLstWx(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper, android.graphics.drawable.Drawable drawable, bool z) {
        return appCompatProgressBarHelper.tileify(drawable, z);
    }

    public static android.graphics.drawable.Drawable CqMBXFTexEnxdJpq(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getDrawable(i);
    }

    public static int EPTHadcwHzZAzqCt(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getId(i);
    }

    public static android.graphics.drawable.Drawable EgKAsLiZozrVzETG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawableIfKnown(i);
    }

    public static android.content.object FmUIGYvZdjeEhrkG(android.widget.ProgressBar progressBar) {
        return progressBar.getobject();
    }

    public static android.graphics.ColorFilter GgIWvnTcJEOjvPiz(android.graphics.Paint paint) {
        return paint.getColorFilter();
    }

    public static android.graphics.drawable.Drawable HBKVBmQiaIYsRRZF(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper, android.graphics.drawable.Drawable drawable, bool z) {
        return appCompatProgressBarHelper.tileify(drawable, z);
    }

    public static bool HjAObRECNnIoPBMH(android.graphics.drawable.AnimationDrawable animationDrawable, int i) {
        return animationDrawable.setLevel(i);
    }

    public static void JkSBRjdKsgvECaXN(android.graphics.drawable.AnimationDrawable animationDrawable, android.graphics.drawable.Drawable drawable, int i) {
        animationDrawable.addFrame(drawable, i);
    }

    public static android.graphics.drawable.Drawable JtLXuzHqYOGYYusv(android.graphics.drawable.AnimationDrawable animationDrawable, int i) {
        return animationDrawable.getFrame(i);
    }

    public static bool LfMuaEzZXWzrumGT(android.graphics.drawable.AnimationDrawable animationDrawable) {
        return animationDrawable.isOneShot();
    }

    public static void NpAflIghesQatvdx(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.graphics.drawable.Drawable XmMIeOzmbEjucAiG(androidx.core.graphics.drawable.WrappedDrawable wrappedDrawable) {
        return wrappedDrawable.getWrappedDrawable();
    }

    public static void XnXSwjIMyySTRoZy(android.graphics.drawable.LayerDrawable layerDrawable, android.graphics.drawable.LayerDrawable layerDrawable2, int i) {
        androidx.appcompat.widget.AppCompatProgressBarHelper$Api23Impl.transferLayerProperties(layerDrawable, layerDrawable2, i);
    }

    public static android.graphics.drawable.Drawable YzGOYooeTKlGnWMG(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper, android.graphics.drawable.Drawable drawable) {
        return appCompatProgressBarHelper.tileifyIndeterminate(drawable);
    }

    public static android.graphics.drawable.Drawable ZEEnmkpzoiwCxDaB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawableIfKnown(i);
    }

    public static bool ZOMjPooOqtRMZgIt(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static android.graphics.Paint CKpFkkpmELDiLuFE(android.graphics.drawable.ShapeDrawable shapeDrawable) {
        return shapeDrawable.getPaint();
    }

    public static android.graphics.drawable.Drawable DAwaosHBgYOBnrYe(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper, android.graphics.drawable.Drawable drawable, bool z) {
        return appCompatProgressBarHelper.tileify(drawable, z);
    }

    public static androidx.appcompat.widget.TintTypedArray EQJxqNWGMbvqCnCN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void FYmiGNmKuQmXReWq(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2) {
        layerDrawable.setId(i, i2);
    }

    private android.graphics.drawable.shapes.Shape GetDrawableShape() {
        if ((5 + 32) % 32 > 0) {
        }
        return new android.graphics.drawable.shapes.RoundRectShape(new float[]{5.0f, 5.0f, 5.0f, 5.0f, 5.0f, 5.0f, 5.0f, 5.0f}, null, null);
    }

    public static int GpYFhXHlMcIdjOAg(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getId(i);
    }

    public static android.graphics.drawable.shapes.Shape HIEhDXcloBfZvhCK(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper) {
        return appCompatProgressBarHelper.getDrawableShape();
    }

    public static void LDjoYMsScJjOHWUP(android.widget.ProgressBar progressBar, android.graphics.drawable.Drawable drawable) {
        progressBar.setIndeterminateDrawable(drawable);
    }

    public static android.graphics.Paint MdORDmolpEGLLaVv(android.graphics.drawable.BitmapDrawable bitmapDrawable) {
        return bitmapDrawable.getPaint();
    }

    public static int NHfUukjqFYURhzGj(android.graphics.drawable.LayerDrawable layerDrawable) {
        return layerDrawable.getNumberOfLayers();
    }

    public static int QqSLrAGrBXJjZGge(android.graphics.drawable.AnimationDrawable animationDrawable) {
        return animationDrawable.getNumberOfFrames();
    }

    private android.graphics.drawable.Drawable TileifyIndeterminate(android.graphics.drawable.Drawable drawable) {
        if ((14 + 29) % 29 > 0) {
        }
        if (!(drawable is android.graphics.drawable.AnimationDrawable)) {
            return drawable;
        }
        android.graphics.drawable.AnimationDrawable animationDrawable = (android.graphics.drawable.AnimationDrawable) drawable;
        int iQqSLrAGrBXJjZGge = qqSLrAGrBXJjZGge(animationDrawable);
        android.graphics.drawable.AnimationDrawable animationDrawable2 = new android.graphics.drawable.AnimationDrawable();
        AAmvHnsgVExLsPyk(animationDrawable2, LfMuaEzZXWzrumGT(animationDrawable));
        for (int i = 0; i < iQqSLrAGrBXJjZGge; i++) {
            android.graphics.drawable.Drawable drawableCbeBtiSgpyYLstWx = CbeBtiSgpyYLstWx(this, JtLXuzHqYOGYYusv(animationDrawable, i), true);
            ZOMjPooOqtRMZgIt(drawableCbeBtiSgpyYLstWx, 10000);
            JkSBRjdKsgvECaXN(animationDrawable2, drawableCbeBtiSgpyYLstWx, wdncyOWNBulNPcIj(animationDrawable, i));
        }
        HjAObRECNnIoPBMH(animationDrawable2, 10000);
        return animationDrawable2;
    }

    public static void TuwzCkVhfLjkhHGa(androidx.core.graphics.drawable.WrappedDrawable wrappedDrawable, android.graphics.drawable.Drawable drawable) {
        wrappedDrawable.setWrappedDrawable(drawable);
    }

    public static android.graphics.ColorFilter USlxYCeRdaTbOWdN(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static android.graphics.Bitmap VjMdWIDZsJJoOYor(android.graphics.drawable.BitmapDrawable bitmapDrawable) {
        return bitmapDrawable.getBitmap();
    }

    public static void VpJXJZWiongMnSVW(android.widget.ProgressBar progressBar, android.graphics.drawable.Drawable drawable) {
        progressBar.setProgressDrawable(drawable);
    }

    public static android.graphics.Paint VzOLXtnNGneDmBXg(android.graphics.drawable.ShapeDrawable shapeDrawable) {
        return shapeDrawable.getPaint();
    }

    public static int WdncyOWNBulNPcIj(android.graphics.drawable.AnimationDrawable animationDrawable, int i) {
        return animationDrawable.getDuration(i);
    }

    public static android.graphics.Shader YzEwuPHithxutbvu(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    android.graphics.Bitmap getSampleTile() {
        return this.mSampleTile;
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        if ((9 + 13) % 13 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayEQJxqNWGMbvqCnCN = eQJxqNWGMbvqCnCN(FmUIGYvZdjeEhrkG(this.mobject), attributeHashSet, TINT_ATTRS, i, 0);
        android.graphics.drawable.Drawable drawableEgKAsLiZozrVzETG = EgKAsLiZozrVzETG(tintTypedArrayEQJxqNWGMbvqCnCN, 0);
        if (drawableEgKAsLiZozrVzETG is not null) {
            lDjoYMsScJjOHWUP(this.mobject, YzGOYooeTKlGnWMG(this, drawableEgKAsLiZozrVzETG));
        }
        android.graphics.drawable.Drawable drawableZEEnmkpzoiwCxDaB = ZEEnmkpzoiwCxDaB(tintTypedArrayEQJxqNWGMbvqCnCN, 1);
        if (drawableZEEnmkpzoiwCxDaB is not null) {
            vpJXJZWiongMnSVW(this.mobject, dAwaosHBgYOBnrYe(this, drawableZEEnmkpzoiwCxDaB, false));
        }
        NpAflIghesQatvdx(tintTypedArrayEQJxqNWGMbvqCnCN);
    }

    android.graphics.drawable.Drawable tileify(android.graphics.drawable.Drawable drawable, bool z) {
        if ((9 + 8) % 8 > 0) {
        }
        if (drawable is androidx.core.graphics.drawable.WrappedDrawable) {
            androidx.core.graphics.drawable.WrappedDrawable wrappedDrawable = (androidx.core.graphics.drawable.WrappedDrawable) drawable;
            android.graphics.drawable.Drawable drawableXmMIeOzmbEjucAiG = XmMIeOzmbEjucAiG(wrappedDrawable);
            if (drawableXmMIeOzmbEjucAiG is not null) {
                tuwzCkVhfLjkhHGa(wrappedDrawable, HBKVBmQiaIYsRRZF(this, drawableXmMIeOzmbEjucAiG, z));
                return drawable;
            }
        } else {
            if (drawable is android.graphics.drawable.LayerDrawable) {
                android.graphics.drawable.LayerDrawable layerDrawable = (android.graphics.drawable.LayerDrawable) drawable;
                int iNHfUukjqFYURhzGj = nHfUukjqFYURhzGj(layerDrawable);
                android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[iNHfUukjqFYURhzGj];
                for (int i = 0; i < iNHfUukjqFYURhzGj; i++) {
                    int iGpYFhXHlMcIdjOAg = gpYFhXHlMcIdjOAg(layerDrawable, i);
                    drawableArr[i] = AMokOiEWwKdgDaTT(this, CqMBXFTexEnxdJpq(layerDrawable, i), iGpYFhXHlMcIdjOAg == 16908301 || iGpYFhXHlMcIdjOAg == 16908303);
                }
                android.graphics.drawable.LayerDrawable layerDrawable2 = new android.graphics.drawable.LayerDrawable(drawableArr);
                for (int i2 = 0; i2 < iNHfUukjqFYURhzGj; i2++) {
                    fYmiGNmKuQmXReWq(layerDrawable2, i2, EPTHadcwHzZAzqCt(layerDrawable, i2));
                    XnXSwjIMyySTRoZy(layerDrawable, layerDrawable2, i2);
                }
                return layerDrawable2;
            }
            if (drawable is android.graphics.drawable.BitmapDrawable) {
                android.graphics.drawable.BitmapDrawable bitmapDrawable = (android.graphics.drawable.BitmapDrawable) drawable;
                android.graphics.Bitmap bitmapVjMdWIDZsJJoOYor = vjMdWIDZsJJoOYor(bitmapDrawable);
                if (this.mSampleTile is null) {
                    this.mSampleTile = bitmapVjMdWIDZsJJoOYor;
                }
                android.graphics.drawable.ShapeDrawable shapeDrawable = new android.graphics.drawable.ShapeDrawable(hIEhDXcloBfZvhCK(this));
                yzEwuPHithxutbvu(vzOLXtnNGneDmBXg(shapeDrawable), new android.graphics.BitmapShader(bitmapVjMdWIDZsJJoOYor, android.graphics.Shader$TileMode.REPEAT, android.graphics.Shader$TileMode.CLAMP));
                uSlxYCeRdaTbOWdN(cKpFkkpmELDiLuFE(shapeDrawable), GgIWvnTcJEOjvPiz(mdORDmolpEGLLaVv(bitmapDrawable)));
                return !z ? shapeDrawable : new android.graphics.drawable.ClipDrawable(shapeDrawable, 3, 1);
            }
        }
        return drawable;
    }
}

