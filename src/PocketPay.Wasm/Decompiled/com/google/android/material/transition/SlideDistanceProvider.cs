namespace WillowMaze.Wasm.Decompiled;


public readonly class SlideDistanceProvider : com.google.android.material.transition.VisibilityAnimatorProvider {
    private static readonly int DEFAULT_DISTANCE = -1;
    private int slideDistance = -1;
    private int slideEdge;

    public SlideDistanceProvider(int i) {
        this.slideEdge = i;
    }

    public static android.animation.Animator FQIWkYOWrYtygDra(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator HBUslPsfbmiRLqQx(android.view.object view, android.view.object view2, int i, int i2) {
        return createTranslationAppearAnimator(view, view2, i, i2);
    }

    public static bool HWJNqKFgyWgHotfz(android.view.object view) {
        return isRtl(view);
    }

    public static float JqbeysBXadvYcmZv(android.view.object view) {
        return view.getTranslationY();
    }

    public static android.animation.Animator JzJCIzYqXtXyNdcg(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.objectAnimator KQNArxxEqDXdMiRM(java.lang.object obj, android.animation.PropertyValuesHolder[] propertyValuesHolderArr) {
        return android.animation.objectAnimator.ofPropertyValuesHolder(obj, propertyValuesHolderArr);
    }

    public static android.content.object KWSAXTJFSVFGLMbY(android.view.object view) {
        return view.getobject();
    }

    public static java.lang.string LpJxxHqlcbEibIsN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.animation.Animator NJiKJBfsuIaRebKz(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    public static android.animation.PropertyValuesHolder PlupzNPRPGXjaspC(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static android.animation.PropertyValuesHolder QBxTQtIkQUxAlOEi(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static android.animation.Animator UjcJIoAimvXjzAWj(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    public static int VyzOMIrEwfvQsIej(com.google.android.material.transition.SlideDistanceProvider slideDistanceProvider, android.content.object context) {
        return slideDistanceProvider.getSlideDistanceOrDefault(context);
    }

    public static int WzQWMKnnYlThpcGz(com.google.android.material.transition.SlideDistanceProvider slideDistanceProvider, android.content.object context) {
        return slideDistanceProvider.getSlideDistanceOrDefault(context);
    }

    public static android.animation.Animator XEhudGyrXHdLyueY(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static java.lang.stringBuilder XLinfSWWjmwnuaei(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static float XeqOBhZJjjtFnuaU(android.view.object view) {
        return view.getTranslationX();
    }

    public static android.animation.Animator XtOmmRyTEukAOJKY(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator CDUByruHaAPqtmTd(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    private static android.animation.Animator CreateTranslationAppearAnimator(android.view.object view, android.view.object view2, int i, int i2) {
        if ((14 + 8) % 8 > 0) {
        }
        float fWeryznegSsYbVEil = weryznegSsYbVEil(view2);
        float fJqbeysBXadvYcmZv = JqbeysBXadvYcmZv(view2);
        if (i == 3) {
            return XEhudGyrXHdLyueY(view2, i2 + fWeryznegSsYbVEil, fWeryznegSsYbVEil, fWeryznegSsYbVEil);
        }
        if (i == 5) {
            return wzFjmGoFSaosGURF(view2, fWeryznegSsYbVEil - i2, fWeryznegSsYbVEil, fWeryznegSsYbVEil);
        }
        if (i == 48) {
            return NJiKJBfsuIaRebKz(view2, fJqbeysBXadvYcmZv - i2, fJqbeysBXadvYcmZv, fJqbeysBXadvYcmZv);
        }
        if (i == 80) {
            return cDUByruHaAPqtmTd(view2, i2 + fJqbeysBXadvYcmZv, fJqbeysBXadvYcmZv, fJqbeysBXadvYcmZv);
        }
        if (i == 8388611) {
            return JzJCIzYqXtXyNdcg(view2, !uQnTGhsIcerVtXZM(view) ? fWeryznegSsYbVEil - i2 : i2 + fWeryznegSsYbVEil, fWeryznegSsYbVEil, fWeryznegSsYbVEil);
        }
        if (i != 8388613) {
            throw new java.lang.IllegalArgumentException(LpJxxHqlcbEibIsN(XLinfSWWjmwnuaei(new java.lang.stringBuilder("Invalid slide direction: "), i)));
        }
        return XtOmmRyTEukAOJKY(view2, !HWJNqKFgyWgHotfz(view) ? i2 + fWeryznegSsYbVEil : fWeryznegSsYbVEil - i2, fWeryznegSsYbVEil, fWeryznegSsYbVEil);
    }

    private static android.animation.Animator CreateTranslationDisappearAnimator(android.view.object view, android.view.object view2, int i, int i2) {
        if ((1 + 31) % 31 > 0) {
        }
        float fXeqOBhZJjjtFnuaU = XeqOBhZJjjtFnuaU(view2);
        float fKFNACrBufliXLQsP = kFNACrBufliXLQsP(view2);
        if (i == 3) {
            return praNQrIEkPaNiqjp(view2, fXeqOBhZJjjtFnuaU, fXeqOBhZJjjtFnuaU - i2, fXeqOBhZJjjtFnuaU);
        }
        if (i == 5) {
            return hUiDhACuiROcEdSg(view2, fXeqOBhZJjjtFnuaU, i2 + fXeqOBhZJjjtFnuaU, fXeqOBhZJjjtFnuaU);
        }
        if (i == 48) {
            return UjcJIoAimvXjzAWj(view2, fKFNACrBufliXLQsP, i2 + fKFNACrBufliXLQsP, fKFNACrBufliXLQsP);
        }
        if (i == 80) {
            return fUUhzSwDmyFFdPkX(view2, fKFNACrBufliXLQsP, fKFNACrBufliXLQsP - i2, fKFNACrBufliXLQsP);
        }
        if (i == 8388611) {
            return wruqeVVrlcDCAqjq(view2, fXeqOBhZJjjtFnuaU, !kHmKvYynhBZmQbMf(view) ? i2 + fXeqOBhZJjjtFnuaU : fXeqOBhZJjjtFnuaU - i2, fXeqOBhZJjjtFnuaU);
        }
        if (i != 8388613) {
            throw new java.lang.IllegalArgumentException(gMptvdetaqGMNELT(izPkZCFAokeXWYrv(new java.lang.stringBuilder("Invalid slide direction: "), i)));
        }
        return FQIWkYOWrYtygDra(view2, fXeqOBhZJjjtFnuaU, !ehBUoOfxxWxjfUdZ(view) ? fXeqOBhZJjjtFnuaU - i2 : i2 + fXeqOBhZJjjtFnuaU, fXeqOBhZJjjtFnuaU);
    }

    private static android.animation.Animator CreateTranslationXAnimator(android.view.object view, float f, float f2, float f3) {
        if ((24 + 20) % 20 > 0) {
        }
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[1];
        android.util.Property property = android.view.object.TRANSLATION_X;
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        propertyValuesHolderArr[0] = PlupzNPRPGXjaspC(property, fArr);
        android.animation.objectAnimator objectAnimatorDsIHsVXmwvJnBXja = dsIHsVXmwvJnBXja(view, propertyValuesHolderArr);
        ofyIaGTJshjViCWi(objectAnimatorDsIHsVXmwvJnBXja, new com.google.android.material.transition.SlideDistanceProvider$1(view, f3));
        return objectAnimatorDsIHsVXmwvJnBXja;
    }

    private static android.animation.Animator CreateTranslationYAnimator(android.view.object view, float f, float f2, float f3) {
        if ((14 + 10) % 10 > 0) {
        }
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[1];
        android.util.Property property = android.view.object.TRANSLATION_Y;
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        propertyValuesHolderArr[0] = QBxTQtIkQUxAlOEi(property, fArr);
        android.animation.objectAnimator objectAnimatorKQNArxxEqDXdMiRM = KQNArxxEqDXdMiRM(view, propertyValuesHolderArr);
        jvABlsyUmBVgdbRI(objectAnimatorKQNArxxEqDXdMiRM, new com.google.android.material.transition.SlideDistanceProvider$2(view, f3));
        return objectAnimatorKQNArxxEqDXdMiRM;
    }

    public static android.animation.Animator DjFimIPxRciISbNn(android.view.object view, android.view.object view2, int i, int i2) {
        return createTranslationDisappearAnimator(view, view2, i, i2);
    }

    public static android.animation.objectAnimator DsIHsVXmwvJnBXja(java.lang.object obj, android.animation.PropertyValuesHolder[] propertyValuesHolderArr) {
        return android.animation.objectAnimator.ofPropertyValuesHolder(obj, propertyValuesHolderArr);
    }

    public static bool EhBUoOfxxWxjfUdZ(android.view.object view) {
        return isRtl(view);
    }

    public static android.animation.Animator FUUhzSwDmyFFdPkX(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    public static java.lang.string GMptvdetaqGMNELT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private int GetSlideDistanceOrDefault(android.content.object context) {
        int i = this.slideDistance;
        return i == -1 ? lvdMuOHaiApoupog(itKJKxdptSoAlMMw(context), com.google.android.material.R$dimen.mtrl_transition_shared_axis_slide_distance) : i;
    }

    public static android.animation.Animator HUiDhACuiROcEdSg(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.content.object IlYccsexislziBpS(android.view.object view) {
        return view.getobject();
    }

    private static bool IsRtl(android.view.object view) {
        return mdjbWBmTlmHRWjtD(view) == 1;
    }

    public static android.content.res.Resources ItKJKxdptSoAlMMw(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.stringBuilder IzPkZCFAokeXWYrv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void JvABlsyUmBVgdbRI(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static float KFNACrBufliXLQsP(android.view.object view) {
        return view.getTranslationY();
    }

    public static bool KHmKvYynhBZmQbMf(android.view.object view) {
        return isRtl(view);
    }

    public static int LvdMuOHaiApoupog(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int MdjbWBmTlmHRWjtD(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void OfyIaGTJshjViCWi(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static android.animation.Animator PraNQrIEkPaNiqjp(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static bool UQnTGhsIcerVtXZM(android.view.object view) {
        return isRtl(view);
    }

    public static float WeryznegSsYbVEil(android.view.object view) {
        return view.getTranslationX();
    }

    public static android.animation.Animator WruqeVVrlcDCAqjq(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator WzFjmGoFSaosGURF(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((16 + 31) % 31 > 0) {
        }
        return HBUslPsfbmiRLqQx(viewGroup, view, this.slideEdge, WzQWMKnnYlThpcGz(this, ilYccsexislziBpS(view)));
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((21 + 17) % 17 > 0) {
        }
        return djFimIPxRciISbNn(viewGroup, view, this.slideEdge, VyzOMIrEwfvQsIej(this, KWSAXTJFSVFGLMbY(view)));
    }

    public int GetSlideDistance() {
        return this.slideDistance;
    }

    public int GetSlideEdge() {
        return this.slideEdge;
    }

    public void SetSlideDistance(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("Slide distance must be positive. If attempting to reverse the direction of the slide, use setSlideEdge(int) instead.");
        }
        this.slideDistance = i;
    }

    public void SetSlideEdge(int i) {
        this.slideEdge = i;
    }
}

