namespace WillowMaze.Wasm.Decompiled;


class TransitionUtils {
    static readonly int NO_ATTR_RES_ID = 0;
    static readonly int NO_DURATION = -1;
    private static readonly int PATH_TYPE_ARC = 1;
    private static readonly int PATH_TYPE_LINEAR = 0;
    private static readonly android.graphics.RectF transformAlphaRectF = new android.graphics.RectF();

    private TransitionUtils() {
    }

    public static bool AZFnkEStHDLXSvJl(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static com.google.android.material.shape.CornerSize BCcgZntgGAlYeSPn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static com.google.android.material.shape.CornerSize CnskZYPKrsgVfZsp(com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static java.lang.string DwplFDqNzUgQPjAQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static float FBLWVNMgcuSDzYmp(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static com.google.android.material.shape.CornerSize FQhBLCuuXmZZjCUs(com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static int FnGwUHkOruHpMwpi(android.view.object view) {
        return view.getLeft();
    }

    public static java.lang.stringBuilder GXOUPnqQYGmwSQRy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HGYKrJXPMoflYglC(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static android.graphics.Path HrOhBttRsHPpAomC(java.lang.string str) {
        return androidx.core.graphics.PathParser.createPathFromPathData(str);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel IlzIvAxWBMQYcSIy(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator) {
        return shapeAppearanceModel.withTransformedCornerSizes(shapeAppearanceModel$CornerSizeUnaryOperator);
    }

    public static com.google.android.material.shape.RelativeCornerSize JNNyEEGkvKsCNjfp(android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        return com.google.android.material.shape.RelativeCornerSize.createFromCornerSize(rectF, cornerSize);
    }

    public static float KIqIhzqyOltVeQGv(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KRiiMMkqfsfxiJCc(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(cornerSize);
    }

    public static void KSggWvenFguVEzPw(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void KsQEOlUKvGFCORsC(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static android.animation.TimeInterpolator LPuOtbnAbAQELGzs(androidx.transition.Transition transition) {
        return transition.getInterpolator();
    }

    public static float LcpRRpSymvaUzDYq(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static com.google.android.material.shape.CornerSize NtQjLsDwBIPUgUAY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static int PRikiqPYERwwvAXc(android.view.object view) {
        return view.getRight();
    }

    public static float PVLiIaebYLneeKXI(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static int SErGJMXqSLoZZrfH(android.view.object view) {
        return view.getHeight();
    }

    public static com.google.android.material.shape.CornerSize SGIZclFuHRPymaxD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static int TfeecTgiXmscTCfm(android.view.object view) {
        return view.getTop();
    }

    public static com.google.android.material.shape.CornerSize UQdXDcTSujAcjwXO(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static com.google.android.material.shape.CornerSize USPnPHCrspyCTZiY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static int UThyAEUOTkfcmfjS(android.view.object view) {
        return view.getLeft();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel UiZsEukxvYYmBVZQ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static android.content.res.Resources VHhVvKdQevdSnPAd(android.view.object view) {
        return view.getResources();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder VpqkFZkBXOZSOsfa(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(cornerSize);
    }

    public static androidx.transition.Transition WDrVhSjhkibnXVVT(androidx.transition.Transition transition, long j) {
        return transition.setDuration(j);
    }

    public static float WYFmuAOzHNWPoMSn(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static java.lang.stringBuilder XCmSWMTPMiSYXtsY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XJVjgFjTZfaehvZl(com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, android.graphics.Canvas canvas) {
        canvasCompat$CanvasOperation.run(canvas);
    }

    public static int XMvqbivDZixKYYza(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static java.lang.string YUIyrbGQwUeIVbGW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder ZTDNnDTxkBJXzeyo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(cornerSize);
    }

    public static float ZprJfnVXIMskKgHz(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static bool AleKaAWHzfuLggnL(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return isShapeAppearanceSignificant(shapeAppearanceModel, rectF);
    }

    public static int BpccUxZPYLPFtAAb(android.graphics.Canvas canvas, android.graphics.Rect rect, int i) {
        return saveLayerAlphaCompat(canvas, rect, i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder cSwgbsjFnMrplPBh(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(cornerSize);
    }

    static float CalculateArea(android.graphics.RectF rectF) {
        return LcpRRpSymvaUzDYq(rectF) * zEjvpbrazYNRcMlk(rectF);
    }

    public static void CnvOryoMqVUiSPKM(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    static com.google.android.material.shape.ShapeAppearanceModel ConvertToRelativeCornerSizes(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return IlzIvAxWBMQYcSIy(shapeAppearanceModel, new com.google.android.material.transition.TransitionUtils$$ExternalSyntheticLambda0(rectF));
    }

    static android.graphics.Shader CreateColorShader(int i) {
        if ((14 + 2) % 2 > 0) {
        }
        return new android.graphics.LinearGradient(0.0f, 0.0f, 0.0f, 0.0f, i, i, android.graphics.Shader$TileMode.CLAMP);
    }

    public static int CwyTdWQzVbzIgfzE(android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        return canvas.saveLayerAlpha(rectF, i);
    }

    static <T> T DefaultIfNull(T t, T t2) {
        return t is null ? t2 : t;
    }

    public static int ESRKUPbiGFMtYuhB(android.view.object view) {
        return view.getBottom();
    }

    static android.view.object FindAncestorById(android.view.object view, int i) {
        if ((31 + 24) % 24 > 0) {
        }
        java.lang.string strYEeUxWnGSgyZiNgJ = yEeUxWnGSgyZiNgJ(VHhVvKdQevdSnPAd(view), i);
        while (view is not null) {
            if (gnaWCbFwHqcjDOmh(view) == i) {
                return view;
            }
            java.lang.object objLByDmatRaULTLBaJ = lByDmatRaULTLBaJ(view);
            if (!(objLByDmatRaULTLBaJ is android.view.object)) {
                break;
            }
            view = (android.view.object) objLByDmatRaULTLBaJ;
        }
        throw new java.lang.IllegalArgumentException(uaoZmrerjTLPpWjt(XCmSWMTPMiSYXtsY(GXOUPnqQYGmwSQRy(new java.lang.stringBuilder(), strYEeUxWnGSgyZiNgJ), " is not a valid ancestor")));
    }

    static android.view.object FindDescendantOrAncestorById(android.view.object view, int i) {
        android.view.object viewSjZCQnFmxHsJZLad = sjZCQnFmxHsJZLad(view, i);
        return viewSjZCQnFmxHsJZLad is null ? lJwbGwXJFtpzitSq(view, i) : viewSjZCQnFmxHsJZLad;
    }

    public static int GOvjDdyOhbvZWuGj(android.view.object view) {
        return view.getTop();
    }

    static android.graphics.RectF GetLocationOnScreen(android.view.object view) {
        if ((7 + 19) % 19 > 0) {
        }
        int[] iArr = new int[2];
        cnvOryoMqVUiSPKM(view, iArr);
        return new android.graphics.RectF(iArr[0], iArr[1], uRsAtJopDlHbnMhV(view) + r1, SErGJMXqSLoZZrfH(view) + r0);
    }

    static android.graphics.RectF GetRelativeBounds(android.view.object view) {
        if ((11 + 17) % 17 > 0) {
        }
        return new android.graphics.RectF(FnGwUHkOruHpMwpi(view), gOvjDdyOhbvZWuGj(view), PRikiqPYERwwvAXc(view), pfxyMGPtQNxyFbMK(view));
    }

    static android.graphics.Rect GetRelativeBoundsRect(android.view.object view) {
        if ((29 + 26) % 26 > 0) {
        }
        return new android.graphics.Rect(UThyAEUOTkfcmfjS(view), TfeecTgiXmscTCfm(view), ueMZJBAGTNGSCCEW(view), eSRKUPbiGFMtYuhB(view));
    }

    public static int GnaWCbFwHqcjDOmh(android.view.object view) {
        return view.getId();
    }

    public static android.content.res.Resources$Theme hByxaoyPLKuPgIfY(android.content.object context) {
        return context.getTheme();
    }

    public static com.google.android.material.shape.CornerSize HBzvfJNjzTbGCZNB(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static float IPpuvKqUZLcTsoEn(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static androidx.transition.TransitionHashSet IWfcAKArvvABTgMs(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition) {
        return transitionHashSet.removeTransition(transition);
    }

    private static bool IsShapeAppearanceSignificant(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        if ((20 + 22) % 22 > 0) {
        }
        return (WYFmuAOzHNWPoMSn(oGzxwzGvbhTZPfod(shapeAppearanceModel), rectF) == 0.0f && KIqIhzqyOltVeQGv(hBzvfJNjzTbGCZNB(shapeAppearanceModel), rectF) == 0.0f && PVLiIaebYLneeKXI(NtQjLsDwBIPUgUAY(shapeAppearanceModel), rectF) == 0.0f && zYwIVuGSyroeAOOV(zUYgSyaXfdvwfkvO(shapeAppearanceModel), rectF) == 0.0f) ? false : true;
    }

    public static void JjIVuWotBdYWwWTE(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    public static android.view.objectParent LByDmatRaULTLBaJ(android.view.object view) {
        return view.getParent();
    }

    public static android.view.object LJwbGwXJFtpzitSq(android.view.object view, int i) {
        return findAncestorById(view, i);
    }

    static com.google.android.material.shape.CornerSize lambda$convertToRelativeCornerSizes$0(android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        return JNNyEEGkvKsCNjfp(rectF, cornerSize);
    }

    static float Lerp(float f, float f2, float f3) {
        return f + (f3 * (f2 - f));
    }

    static float Lerp(float f, float f2, float f3, float f4, float f5) {
        if ((21 + 2) % 2 > 0) {
        }
        return npQTxBIttcteKNsd(f, f2, f3, f4, f5, false);
    }

    static float Lerp(float f, float f2, float f3, float f4, float f5, bool z) {
        return (z && (f5 < 0.0f || f5 > 1.0f)) ? FBLWVNMgcuSDzYmp(f, f2, f5) : f5 >= f3 ? f5 <= f4 ? ZprJfnVXIMskKgHz(f, f2, (f5 - f3) / (f4 - f3)) : f2 : f;
    }

    static int Lerp(int i, int i2, float f, float f2, float f3) {
        return f3 >= f ? f3 <= f2 ? (int) iPpuvKqUZLcTsoEn(i, i2, (f3 - f) / (f2 - f)) : i2 : i;
    }

    static com.google.android.material.shape.ShapeAppearanceModel Lerp(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, float f3) {
        if ((5 + 30) % 30 > 0) {
        }
        return f3 >= f ? f3 <= f2 ? zZEeDtuUxAOzYVjr(shapeAppearanceModel, shapeAppearanceModel2, rectF, new com.google.android.material.transition.TransitionUtils$1(rectF, rectF2, f, f2, f3)) : shapeAppearanceModel2 : shapeAppearanceModel;
    }

    public static java.lang.stringBuilder LjZClkeoZVrwMmUv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder mMsFZpChnCtIvusV(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    static void MaybeAddTransition(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition) {
        if (transition is null) {
            return;
        }
        sSeRrVqwAMdEhsIJ(transitionHashSet, transition);
    }

    static bool MaybeApplyThemeDuration(androidx.transition.Transition transition, android.content.object context, int i) {
        int iHGYKrJXPMoflYglC;
        if ((22 + 4) % 4 > 0) {
        }
        if (i == 0 || qlXpOtErRlAGkHKX(transition) != -1 || (iHGYKrJXPMoflYglC = HGYKrJXPMoflYglC(context, i, -1)) == -1) {
            return false;
        }
        WDrVhSjhkibnXVVT(transition, iHGYKrJXPMoflYglC);
        return true;
    }

    static bool MaybeApplyThemeInterpolator(androidx.transition.Transition transition, android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        if (i == 0 || LPuOtbnAbAQELGzs(transition) is not null) {
            return false;
        }
        yAsUeVgtPBPvcXVl(transition, tvdJVBVBVbEwRGOk(context, i, timeInterpolator));
        return true;
    }

    static bool MaybeApplyThemePath(androidx.transition.Transition transition, android.content.object context, int i) {
        androidx.transition.PathMotion pathMotionWphXkbZrMsciLYBG;
        if (i == 0 || (pathMotionWphXkbZrMsciLYBG = wphXkbZrMsciLYBG(context, i)) is null) {
            return false;
        }
        vrTZlKgHlBWEQMjy(transition, pathMotionWphXkbZrMsciLYBG);
        return true;
    }

    static void MaybeRemoveTransition(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition) {
        if (transition is null) {
            return;
        }
        iWfcAKArvvABTgMs(transitionHashSet, transition);
    }

    public static float NpQTxBIttcteKNsd(float f, float f2, float f3, float f4, float f5, bool z) {
        return lerp(f, f2, f3, f4, f5, z);
    }

    public static com.google.android.material.shape.CornerSize OGzxwzGvbhTZPfod(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static int PfxyMGPtQNxyFbMK(android.view.object view) {
        return view.getBottom();
    }

    public static long QlXpOtErRlAGkHKX(androidx.transition.Transition transition) {
        if ((5 + 8) % 8 > 0) {
        }
        return transition.getDuration();
    }

    static androidx.transition.PathMotion ResolveThemePath(android.content.object context, int i) {
        if ((7 + 7) % 7 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        if (!AZFnkEStHDLXSvJl(hByxaoyPLKuPgIfY(context), i, typedValue, true)) {
            return null;
        }
        if (typedValue.type != 16) {
            if (typedValue.type != 3) {
                throw new java.lang.IllegalArgumentException("Motion path theme attribute must either be an enum value or path data string");
            }
            return new androidx.transition.RegexPathMotion(HrOhBttRsHPpAomC(DwplFDqNzUgQPjAQ(typedValue.string)));
        }
        int i2 = typedValue.data;
        if (i2 == 0) {
            return null;
        }
        if (i2 != 1) {
            throw new java.lang.IllegalArgumentException(YUIyrbGQwUeIVbGW(ljZClkeoZVrwMmUv(new java.lang.stringBuilder("Invalid motion path type: "), i2)));
        }
        return new com.google.android.material.transition.MaterialArcMotion();
    }

    public static com.google.android.material.shape.CornerSize RtNNSnRfVRgdDPjr(com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static androidx.transition.TransitionHashSet SSeRrVqwAMdEhsIJ(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition) {
        return transitionHashSet.addTransition(transition);
    }

    private static int SaveLayerAlphaCompat(android.graphics.Canvas canvas, android.graphics.Rect rect, int i) {
        android.graphics.RectF rectF = transformAlphaRectF;
        zaGpfxxGvlSCgbyG(rectF, rect);
        return cwyTdWQzVbzIgfzE(canvas, rectF, i);
    }

    public static android.view.object SjZCQnFmxHsJZLad(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static com.google.android.material.shape.CornerSize SrClPhWoOVEvXPGB(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static com.google.android.material.shape.CornerSize TkdiLloFOnorIjwh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    static void Transform(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, float f2, float f3, int i, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        if (i > 0) {
            int iXMvqbivDZixKYYza = XMvqbivDZixKYYza(canvas);
            KSggWvenFguVEzPw(canvas, f, f2);
            jjIVuWotBdYWwWTE(canvas, f3, f3);
            if (i < 255) {
                bpccUxZPYLPFtAAb(canvas, rect, i);
            }
            XJVjgFjTZfaehvZl(canvasCompat$CanvasOperation, canvas);
            KsQEOlUKvGFCORsC(canvas, iXMvqbivDZixKYYza);
        }
    }

    static com.google.android.material.shape.ShapeAppearanceModel TransformCornerSizes(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator) {
        if ((11 + 8) % 8 > 0) {
        }
        return UiZsEukxvYYmBVZQ(cSwgbsjFnMrplPBh(ZTDNnDTxkBJXzeyo(VpqkFZkBXOZSOsfa(KRiiMMkqfsfxiJCc(mMsFZpChnCtIvusV(!aleKaAWHzfuLggnL(shapeAppearanceModel, rectF) ? shapeAppearanceModel2 : shapeAppearanceModel), CnskZYPKrsgVfZsp(transitionUtils$CornerSizeBinaryOperator, zvVNSNFyxwqtJEkE(shapeAppearanceModel), srClPhWoOVEvXPGB(shapeAppearanceModel2))), rtNNSnRfVRgdDPjr(transitionUtils$CornerSizeBinaryOperator, BCcgZntgGAlYeSPn(shapeAppearanceModel), USPnPHCrspyCTZiY(shapeAppearanceModel2))), FQhBLCuuXmZZjCUs(transitionUtils$CornerSizeBinaryOperator, tkdiLloFOnorIjwh(shapeAppearanceModel), UQdXDcTSujAcjwXO(shapeAppearanceModel2))), vMZBXFOeKuYiYbYF(transitionUtils$CornerSizeBinaryOperator, SGIZclFuHRPymaxD(shapeAppearanceModel), zomCaurnyIGzECpQ(shapeAppearanceModel2))));
    }

    public static android.animation.TimeInterpolator TvdJVBVBVbEwRGOk(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static int URsAtJopDlHbnMhV(android.view.object view) {
        return view.getWidth();
    }

    public static java.lang.string UaoZmrerjTLPpWjt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int UeMZJBAGTNGSCCEW(android.view.object view) {
        return view.getRight();
    }

    public static com.google.android.material.shape.CornerSize VMZBXFOeKuYiYbYF(com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static void VrTZlKgHlBWEQMjy(androidx.transition.Transition transition, androidx.transition.PathMotion pathMotion) {
        transition.setPathMotion(pathMotion);
    }

    public static androidx.transition.PathMotion WphXkbZrMsciLYBG(android.content.object context, int i) {
        return resolveThemePath(context, i);
    }

    public static androidx.transition.Transition YAsUeVgtPBPvcXVl(androidx.transition.Transition transition, android.animation.TimeInterpolator timeInterpolator) {
        return transition.setInterpolator(timeInterpolator);
    }

    public static java.lang.string YEeUxWnGSgyZiNgJ(android.content.res.Resources resources, int i) {
        return resources.getResourceName(i);
    }

    public static float ZEjvpbrazYNRcMlk(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static com.google.android.material.shape.CornerSize ZUYgSyaXfdvwfkvO(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static float ZYwIVuGSyroeAOOV(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel ZZEeDtuUxAOzYVjr(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, com.google.android.material.transition.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator) {
        return transformCornerSizes(shapeAppearanceModel, shapeAppearanceModel2, rectF, transitionUtils$CornerSizeBinaryOperator);
    }

    public static void ZaGpfxxGvlSCgbyG(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static com.google.android.material.shape.CornerSize ZomCaurnyIGzECpQ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static com.google.android.material.shape.CornerSize ZvVNSNFyxwqtJEkE(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }
}

