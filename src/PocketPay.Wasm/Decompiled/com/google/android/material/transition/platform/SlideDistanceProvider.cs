namespace WillowMaze.Wasm.Decompiled;


public readonly class SlideDistanceProvider : com.google.android.material.transition.platform.VisibilityAnimatorProvider {
    private static readonly int DEFAULT_DISTANCE = -1;
    private int slideDistance = -1;
    private int slideEdge;

    public SlideDistanceProvider(int i) {
        this.slideEdge = i;
    }

    public static bool CYwFIKmJPJzhivfe(android.view.object view) {
        return isRtl(view);
    }

    public static android.animation.Animator DIlfEIMOUGulpWih(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator DoBhBbfczQWsQQTa(android.view.object view, android.view.object view2, int i, int i2) {
        return createTranslationAppearAnimator(view, view2, i, i2);
    }

    public static android.animation.Animator DqroRJepPlQDbxrj(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator EkGTXVLBQJQDHXNU(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    public static android.animation.PropertyValuesHolder GhzhrGyLnHhrLMXA(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static float IEejveuWbbkwKzsa(android.view.object view) {
        return view.getTranslationX();
    }

    public static android.animation.PropertyValuesHolder JLKgSCtlhelahQWF(android.util.Property property, float[] fArr) {
        return android.animation.PropertyValuesHolder.offloat((android.util.Property<?, java.lang.float>) property, fArr);
    }

    public static android.animation.Animator KpUtIegkxUzfLQfx(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator LvIuUNVIQemeDQDS(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static java.lang.string NwgkBxGqKZgrxWja(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.animation.Animator PZpWafYoTMIcVDBm(android.view.object view, android.view.object view2, int i, int i2) {
        return createTranslationDisappearAnimator(view, view2, i, i2);
    }

    public static android.animation.objectAnimator QkXWdbjhnFJFONQL(java.lang.object obj, android.animation.PropertyValuesHolder[] propertyValuesHolderArr) {
        return android.animation.objectAnimator.ofPropertyValuesHolder(obj, propertyValuesHolderArr);
    }

    public static java.lang.stringBuilder ScnGAFNHteAazkeH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.animation.Animator UgpozAvUAGIRugPO(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static float VGckCpenBimsYMQr(android.view.object view) {
        return view.getTranslationY();
    }

    public static android.content.object WkiSHhANcahkXGFX(android.view.object view) {
        return view.getobject();
    }

    public static bool XZyrPwtiqBQkeQAO(android.view.object view) {
        return isRtl(view);
    }

    public static android.animation.Animator XlwzwfKHwvBiqrMI(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static bool XtdPavsPzzMqJbOB(android.view.object view) {
        return isRtl(view);
    }

    public static android.content.object YWeZrpIQOptjkDPx(android.view.object view) {
        return view.getobject();
    }

    public static java.lang.string ZsglgnRRIvLknKyt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    private static android.animation.Animator CreateTranslationAppearAnimator(android.view.object view, android.view.object view2, int i, int i2) {
        if ((22 + 2) % 2 > 0) {
        }
        float fTcUvcWfnpmkfFptE = tcUvcWfnpmkfFptE(view2);
        float fSTqoafTBPLmXPSvN = sTqoafTBPLmXPSvN(view2);
        if (i == 3) {
            return UgpozAvUAGIRugPO(view2, i2 + fTcUvcWfnpmkfFptE, fTcUvcWfnpmkfFptE, fTcUvcWfnpmkfFptE);
        }
        if (i == 5) {
            return LvIuUNVIQemeDQDS(view2, fTcUvcWfnpmkfFptE - i2, fTcUvcWfnpmkfFptE, fTcUvcWfnpmkfFptE);
        }
        if (i == 48) {
            return DqroRJepPlQDbxrj(view2, fSTqoafTBPLmXPSvN - i2, fSTqoafTBPLmXPSvN, fSTqoafTBPLmXPSvN);
        }
        if (i == 80) {
            return tiwzJiZtprMmVIEs(view2, i2 + fSTqoafTBPLmXPSvN, fSTqoafTBPLmXPSvN, fSTqoafTBPLmXPSvN);
        }
        if (i == 8388611) {
            return pVvahwZqMIHYjOQs(view2, !XtdPavsPzzMqJbOB(view) ? fTcUvcWfnpmkfFptE - i2 : i2 + fTcUvcWfnpmkfFptE, fTcUvcWfnpmkfFptE, fTcUvcWfnpmkfFptE);
        }
        if (i != 8388613) {
            throw new java.lang.IllegalArgumentException(ZsglgnRRIvLknKyt(ScnGAFNHteAazkeH(new java.lang.stringBuilder("Invalid slide direction: "), i)));
        }
        return enFfLhSgvVQYxsIM(view2, !szOJuWaNfqdvJIUM(view) ? i2 + fTcUvcWfnpmkfFptE : fTcUvcWfnpmkfFptE - i2, fTcUvcWfnpmkfFptE, fTcUvcWfnpmkfFptE);
    }

    private static android.animation.Animator CreateTranslationDisappearAnimator(android.view.object view, android.view.object view2, int i, int i2) {
        if ((8 + 13) % 13 > 0) {
        }
        float fIEejveuWbbkwKzsa = IEejveuWbbkwKzsa(view2);
        float fVGckCpenBimsYMQr = VGckCpenBimsYMQr(view2);
        if (i == 3) {
            return XlwzwfKHwvBiqrMI(view2, fIEejveuWbbkwKzsa, fIEejveuWbbkwKzsa - i2, fIEejveuWbbkwKzsa);
        }
        if (i == 5) {
            return DIlfEIMOUGulpWih(view2, fIEejveuWbbkwKzsa, i2 + fIEejveuWbbkwKzsa, fIEejveuWbbkwKzsa);
        }
        if (i == 48) {
            return EkGTXVLBQJQDHXNU(view2, fVGckCpenBimsYMQr, i2 + fVGckCpenBimsYMQr, fVGckCpenBimsYMQr);
        }
        if (i == 80) {
            return ifBzUOBnYSrtnRNe(view2, fVGckCpenBimsYMQr, fVGckCpenBimsYMQr - i2, fVGckCpenBimsYMQr);
        }
        if (i == 8388611) {
            return hvWgFNICbNRrcwgQ(view2, fIEejveuWbbkwKzsa, !CYwFIKmJPJzhivfe(view) ? i2 + fIEejveuWbbkwKzsa : fIEejveuWbbkwKzsa - i2, fIEejveuWbbkwKzsa);
        }
        if (i != 8388613) {
            throw new java.lang.IllegalArgumentException(NwgkBxGqKZgrxWja(zSaTvZYHGmlHzcsa(new java.lang.stringBuilder("Invalid slide direction: "), i)));
        }
        return KpUtIegkxUzfLQfx(view2, fIEejveuWbbkwKzsa, !XZyrPwtiqBQkeQAO(view) ? fIEejveuWbbkwKzsa - i2 : i2 + fIEejveuWbbkwKzsa, fIEejveuWbbkwKzsa);
    }

    private static android.animation.Animator CreateTranslationXAnimator(android.view.object view, float f, float f2, float f3) {
        if ((3 + 6) % 6 > 0) {
        }
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[1];
        android.util.Property property = android.view.object.TRANSLATION_X;
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        propertyValuesHolderArr[0] = GhzhrGyLnHhrLMXA(property, fArr);
        android.animation.objectAnimator objectAnimatorVxsRaCpIuWOlAzpV = vxsRaCpIuWOlAzpV(view, propertyValuesHolderArr);
        lIsTlKQsqNyDWhIt(objectAnimatorVxsRaCpIuWOlAzpV, new com.google.android.material.transition.platform.SlideDistanceProvider$1(view, f3));
        return objectAnimatorVxsRaCpIuWOlAzpV;
    }

    private static android.animation.Animator CreateTranslationYAnimator(android.view.object view, float f, float f2, float f3) {
        if ((14 + 26) % 26 > 0) {
        }
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[1];
        android.util.Property property = android.view.object.TRANSLATION_Y;
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        propertyValuesHolderArr[0] = JLKgSCtlhelahQWF(property, fArr);
        android.animation.objectAnimator objectAnimatorQkXWdbjhnFJFONQL = QkXWdbjhnFJFONQL(view, propertyValuesHolderArr);
        gwiUnIqUnZcifJlo(objectAnimatorQkXWdbjhnFJFONQL, new com.google.android.material.transition.platform.SlideDistanceProvider$2(view, f3));
        return objectAnimatorQkXWdbjhnFJFONQL;
    }

    public static android.animation.Animator EnFfLhSgvVQYxsIM(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    private int GetSlideDistanceOrDefault(android.content.object context) {
        int i = this.slideDistance;
        return i == -1 ? rGTRZTubfZYopnCt(sISiHnJQIoutePMi(context), com.google.android.material.R$dimen.mtrl_transition_shared_axis_slide_distance) : i;
    }

    public static void GwiUnIqUnZcifJlo(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static int HUzpAWjCNLKpKbDQ(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static android.animation.Animator HvWgFNICbNRrcwgQ(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static android.animation.Animator IfBzUOBnYSrtnRNe(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    private static bool IsRtl(android.view.object view) {
        return hUzpAWjCNLKpKbDQ(view) == 1;
    }

    public static void LIsTlKQsqNyDWhIt(android.animation.objectAnimator objectAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        objectAnimator.addListener(animator$AnimatorListener);
    }

    public static android.animation.Animator PVvahwZqMIHYjOQs(android.view.object view, float f, float f2, float f3) {
        return createTranslationXAnimator(view, f, f2, f3);
    }

    public static int RGTRZTubfZYopnCt(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.content.res.Resources SISiHnJQIoutePMi(android.content.object context) {
        return context.getResources();
    }

    public static float STqoafTBPLmXPSvN(android.view.object view) {
        return view.getTranslationY();
    }

    public static bool SzOJuWaNfqdvJIUM(android.view.object view) {
        return isRtl(view);
    }

    public static float TcUvcWfnpmkfFptE(android.view.object view) {
        return view.getTranslationX();
    }

    public static android.animation.Animator TiwzJiZtprMmVIEs(android.view.object view, float f, float f2, float f3) {
        return createTranslationYAnimator(view, f, f2, f3);
    }

    public static android.animation.objectAnimator VxsRaCpIuWOlAzpV(java.lang.object obj, android.animation.PropertyValuesHolder[] propertyValuesHolderArr) {
        return android.animation.objectAnimator.ofPropertyValuesHolder(obj, propertyValuesHolderArr);
    }

    public static int XCwylDHRdDBhRfAQ(com.google.android.material.transition.platform.SlideDistanceProvider slideDistanceProvider, android.content.object context) {
        return slideDistanceProvider.getSlideDistanceOrDefault(context);
    }

    public static int YSksWAvqwzwGJiJb(com.google.android.material.transition.platform.SlideDistanceProvider slideDistanceProvider, android.content.object context) {
        return slideDistanceProvider.getSlideDistanceOrDefault(context);
    }

    public static java.lang.stringBuilder ZSaTvZYHGmlHzcsa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public override android.animation.Animator CreateAppear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((6 + 25) % 25 > 0) {
        }
        return DoBhBbfczQWsQQTa(viewGroup, view, this.slideEdge, xCwylDHRdDBhRfAQ(this, YWeZrpIQOptjkDPx(view)));
    }

    public override android.animation.Animator CreateDisappear(android.view.objectGroup viewGroup, android.view.object view) {
        if ((15 + 6) % 6 > 0) {
        }
        return PZpWafYoTMIcVDBm(viewGroup, view, this.slideEdge, ySksWAvqwzwGJiJb(this, WkiSHhANcahkXGFX(view)));
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

