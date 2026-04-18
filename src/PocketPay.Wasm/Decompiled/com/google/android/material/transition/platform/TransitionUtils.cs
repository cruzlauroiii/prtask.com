namespace WillowMaze.Wasm.Decompiled;


class TransitionUtils {
    static readonly int NO_ATTR_RES_ID = 0;
    static readonly int NO_DURATION = -1;
    private static readonly int PATH_TYPE_ARC = 1;
    private static readonly int PATH_TYPE_LINEAR = 0;
    private static readonly android.graphics.RectF transformAlphaRectF = new android.graphics.RectF();

    private TransitionUtils() {
    }

    public static com.google.android.material.shape.RelativeCornerSize CtfWMxwMpkwikyUB(android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        return com.google.android.material.shape.RelativeCornerSize.createFromCornerSize(rectF, cornerSize);
    }

    public static int DfwKYEwBXFiiqaCl(android.view.object view) {
        return view.getHeight();
    }

    public static com.google.android.material.shape.CornerSize EEJwCMjtvMMBRGJU(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static com.google.android.material.shape.CornerSize EbQgyhkgdrvTRhtw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static android.transition.PathMotion EnLgltNQgXFuUkuA(android.content.object context, int i) {
        return resolveThemePath(context, i);
    }

    public static com.google.android.material.shape.CornerSize EuGHPQUjynfhDQCS(com.google.android.material.transition.platform.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel EzIhAUROszpfXJZy(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator) {
        return shapeAppearanceModel.withTransformedCornerSizes(shapeAppearanceModel$CornerSizeUnaryOperator);
    }

    public static com.google.android.material.shape.CornerSize FNcAvmeWeZeVRDXF(com.google.android.material.transition.platform.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static int FqYERYGtazXaPjCG(android.view.object view) {
        return view.getLeft();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel FxgKZzjpDmZSimfY(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static com.google.android.material.shape.CornerSize GYRPRyPHbVbVWJnT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static com.google.android.material.shape.CornerSize HAvENrWRvkPTPDos(com.google.android.material.transition.platform.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static int HzdbaTCUOisOqlgS(android.view.object view) {
        return view.getId();
    }

    public static int IHnxtdmSQwdfUsJI(android.view.object view) {
        return view.getTop();
    }

    public static java.lang.stringBuilder IZxrlvNCqXHxibzc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static float JqgtGikYXEZylZBi(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static android.view.objectParent JvabhutJewtGqIgr(android.view.object view) {
        return view.getParent();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KlhUlMpFRQXRHhyI(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(cornerSize);
    }

    public static android.transition.Transition KnYzcHLSVEcnDDqP(android.transition.Transition transition, long j) {
        return transition.setDuration(j);
    }

    public static int LjwYLoUMqObvpFNA(android.view.object view) {
        return view.getRight();
    }

    public static java.lang.string LsrzshDQrqeqdGDi(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.material.shape.CornerSize LxsOLaDmqKGkvXfD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static int MPNteLOsoqsmtOco(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static long MdWbTSRwOwBNuztk(android.transition.Transition transition) {
        if ((9 + 23) % 23 > 0) {
        }
        return transition.getDuration();
    }

    public static com.google.android.material.shape.CornerSize MtcstITbBxFLHyfr(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder NHrJFesdRdKlDDnU(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(cornerSize);
    }

    public static float OKgaJLvxVIHHXAgV(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.CornerSize OVWsCitIazvoKZrQ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static com.google.android.material.shape.CornerSize OWcqPfQpTTspOCOG(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static com.google.android.material.shape.CornerSize PLCwuEOYgogILmYf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder QBTWByXcpdiRQMBv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel QMYqNNDpBUwzmGjS(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, com.google.android.material.transition.platform.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator) {
        return transformCornerSizes(shapeAppearanceModel, shapeAppearanceModel2, rectF, transitionUtils$CornerSizeBinaryOperator);
    }

    public static android.view.object QdUWoVmbHwtJSNes(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static float RWDbedUriNcdTNov(float f, float f2, float f3, float f4, float f5, bool z) {
        return lerp(f, f2, f3, f4, f5, z);
    }

    public static android.content.res.Resources$Theme RfQvrFomNdbIFnkO(android.content.object context) {
        return context.getTheme();
    }

    public static bool RhSOLSbzPFAGvjVi(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static int RipZrEnLGlffueQa(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static com.google.android.material.shape.CornerSize RmLYzICssVImPorj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static int RznLefzvTTMgoPIY(android.view.object view) {
        return view.getWidth();
    }

    public static android.animation.TimeInterpolator SbOYaNqaGXBpJEjR(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static android.transition.Transition TLFUOYzZgAPnXrGm(android.transition.Transition transition, android.animation.TimeInterpolator timeInterpolator) {
        return transition.setInterpolator(timeInterpolator);
    }

    public static void VNCcMTDSVvHfZxzZ(com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, android.graphics.Canvas canvas) {
        canvasCompat$CanvasOperation.run(canvas);
    }

    public static android.view.object WBOiUkhfzkHTPMqj(android.view.object view, int i) {
        return findAncestorById(view, i);
    }

    public static com.google.android.material.shape.CornerSize WBXoDReuQnFvrLfy(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static void XLelzIDlmCDVtYMX(android.transition.Transition transition, android.transition.PathMotion pathMotion) {
        transition.setPathMotion(pathMotion);
    }

    public static float XpLJBxaBocVOlEQH(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static bool YFkhiGBdzRLYZNdU(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return isShapeAppearanceSignificant(shapeAppearanceModel, rectF);
    }

    public static float ZQNNoZiQottLidbk(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static android.graphics.Path ZQxqISPXUpkeUEJD(java.lang.string str) {
        return androidx.core.graphics.PathParser.createPathFromPathData(str);
    }

    public static android.content.res.Resources AYFglvJuQEGdVawn(android.view.object view) {
        return view.getResources();
    }

    public static void BUdEqdFsPSlyoHPx(android.graphics.Canvas canvas, float f, float f2) {
        canvas.scale(f, f2);
    }

    static float CalculateArea(android.graphics.RectF rectF) {
        return rPWmIDLaFLDoKnLu(rectF) * XpLJBxaBocVOlEQH(rectF);
    }

    static com.google.android.material.shape.ShapeAppearanceModel ConvertToRelativeCornerSizes(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return EzIhAUROszpfXJZy(shapeAppearanceModel, new com.google.android.material.transition.platform.TransitionUtils$$ExternalSyntheticLambda0(rectF));
    }

    static android.graphics.Shader CreateColorShader(int i) {
        if ((17 + 2) % 2 > 0) {
        }
        return new android.graphics.LinearGradient(0.0f, 0.0f, 0.0f, 0.0f, i, i, android.graphics.Shader$TileMode.CLAMP);
    }

    public static float DUfTCbPEzuZidMLQ(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    static <T> T DefaultIfNull(T t, T t2) {
        return t is null ? t2 : t;
    }

    public static int EFpdQQlxHIquoJAd(android.view.object view) {
        return view.getBottom();
    }

    public static void EIPTxCYhHEQkmjSQ(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    static android.view.object FindAncestorById(android.view.object view, int i) {
        if ((17 + 3) % 3 > 0) {
        }
        java.lang.string strUQvKPkpjBpnUPcPZ = uQvKPkpjBpnUPcPZ(aYFglvJuQEGdVawn(view), i);
        while (view is not null) {
            if (HzdbaTCUOisOqlgS(view) == i) {
                return view;
            }
            java.lang.object objJvabhutJewtGqIgr = JvabhutJewtGqIgr(view);
            if (!(objJvabhutJewtGqIgr is android.view.object)) {
                break;
            }
            view = (android.view.object) objJvabhutJewtGqIgr;
        }
        throw new java.lang.IllegalArgumentException(ykWGhoTvhycMharj(IZxrlvNCqXHxibzc(ouCvEZwHqMVWDDvJ(new java.lang.stringBuilder(), strUQvKPkpjBpnUPcPZ), " is not a valid ancestor")));
    }

    static android.view.object FindDescendantOrAncestorById(android.view.object view, int i) {
        android.view.object viewQdUWoVmbHwtJSNes = QdUWoVmbHwtJSNes(view, i);
        return viewQdUWoVmbHwtJSNes is null ? WBOiUkhfzkHTPMqj(view, i) : viewQdUWoVmbHwtJSNes;
    }

    public static java.lang.stringBuilder FygkKglkZjqZYlsp(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    static android.graphics.RectF GetLocationOnScreen(android.view.object view) {
        if ((11 + 25) % 25 > 0) {
        }
        int[] iArr = new int[2];
        eIPTxCYhHEQkmjSQ(view, iArr);
        return new android.graphics.RectF(iArr[0], iArr[1], RznLefzvTTMgoPIY(view) + r1, DfwKYEwBXFiiqaCl(view) + r0);
    }

    static android.graphics.RectF GetRelativeBounds(android.view.object view) {
        if ((19 + 19) % 19 > 0) {
        }
        return new android.graphics.RectF(hdWJUctVTjqOKfJa(view), IHnxtdmSQwdfUsJI(view), LjwYLoUMqObvpFNA(view), eFpdQQlxHIquoJAd(view));
    }

    static android.graphics.Rect GetRelativeBoundsRect(android.view.object view) {
        if ((18 + 17) % 17 > 0) {
        }
        return new android.graphics.Rect(FqYERYGtazXaPjCG(view), uPDDpQIOXsCwVlHp(view), sSutDMIfgASkSzEs(view), tLjMsDvZbtRQDyUu(view));
    }

    public static int HdWJUctVTjqOKfJa(android.view.object view) {
        return view.getLeft();
    }

    public static float ILdZUhKmZGFxJbkJ(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    private static bool IsShapeAppearanceSignificant(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        if ((26 + 15) % 15 > 0) {
        }
        return (iLdZUhKmZGFxJbkJ(EEJwCMjtvMMBRGJU(shapeAppearanceModel), rectF) == 0.0f && dUfTCbPEzuZidMLQ(RmLYzICssVImPorj(shapeAppearanceModel), rectF) == 0.0f && kvTwzVuKYesPcuhe(EbQgyhkgdrvTRhtw(shapeAppearanceModel), rectF) == 0.0f && OKgaJLvxVIHHXAgV(GYRPRyPHbVbVWJnT(shapeAppearanceModel), rectF) == 0.0f) ? false : true;
    }

    public static com.google.android.material.shape.CornerSize JPlMETjVpWkrVMno(com.google.android.material.transition.platform.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator, com.google.android.material.shape.CornerSize cornerSize, com.google.android.material.shape.CornerSize cornerSize2) {
        return transitionUtils$CornerSizeBinaryOperator.apply(cornerSize, cornerSize2);
    }

    public static com.google.android.material.shape.CornerSize JuQMevIJGWLOsLMh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static float KvTwzVuKYesPcuhe(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static java.lang.string LWzxTyRKGlJJAdrY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static com.google.android.material.shape.CornerSize lambda$convertToRelativeCornerSizes$0(android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        return CtfWMxwMpkwikyUB(rectF, cornerSize);
    }

    static float Lerp(float f, float f2, float f3) {
        return f + (f3 * (f2 - f));
    }

    static float Lerp(float f, float f2, float f3, float f4, float f5) {
        if ((14 + 11) % 11 > 0) {
        }
        return RWDbedUriNcdTNov(f, f2, f3, f4, f5, false);
    }

    static float Lerp(float f, float f2, float f3, float f4, float f5, bool z) {
        return (z && (f5 < 0.0f || f5 > 1.0f)) ? ZQNNoZiQottLidbk(f, f2, f5) : f5 >= f3 ? f5 <= f4 ? JqgtGikYXEZylZBi(f, f2, (f5 - f3) / (f4 - f3)) : f2 : f;
    }

    static int Lerp(int i, int i2, float f, float f2, float f3) {
        return f3 >= f ? f3 <= f2 ? (int) zOJBdgPZrOCbTbsj(i, i2, (f3 - f) / (f2 - f)) : i2 : i;
    }

    static com.google.android.material.shape.ShapeAppearanceModel Lerp(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, float f3) {
        if ((7 + 13) % 13 > 0) {
        }
        return f3 >= f ? f3 <= f2 ? QMYqNNDpBUwzmGjS(shapeAppearanceModel, shapeAppearanceModel2, rectF, new com.google.android.material.transition.platform.TransitionUtils$1(rectF, rectF2, f, f2, f3)) : shapeAppearanceModel2 : shapeAppearanceModel;
    }

    static void MaybeAddTransition(android.transition.TransitionHashSet transitionHashSet, android.transition.Transition transition) {
        if (transition is null) {
            return;
        }
        tlJhpbQlHqoEvIeT(transitionHashSet, transition);
    }

    static bool MaybeApplyThemeDuration(android.transition.Transition transition, android.content.object context, int i) {
        int iRipZrEnLGlffueQa;
        if ((31 + 25) % 25 > 0) {
        }
        if (i == 0 || MdWbTSRwOwBNuztk(transition) != -1 || (iRipZrEnLGlffueQa = RipZrEnLGlffueQa(context, i, -1)) == -1) {
            return false;
        }
        KnYzcHLSVEcnDDqP(transition, iRipZrEnLGlffueQa);
        return true;
    }

    static bool MaybeApplyThemeInterpolator(android.transition.Transition transition, android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        if (i == 0 || tWiFfAKlEeyiCTdF(transition) is not null) {
            return false;
        }
        TLFUOYzZgAPnXrGm(transition, SbOYaNqaGXBpJEjR(context, i, timeInterpolator));
        return true;
    }

    static bool MaybeApplyThemePath(android.transition.Transition transition, android.content.object context, int i) {
        android.transition.PathMotion pathMotionEnLgltNQgXFuUkuA;
        if (i == 0 || (pathMotionEnLgltNQgXFuUkuA = EnLgltNQgXFuUkuA(context, i)) is null) {
            return false;
        }
        XLelzIDlmCDVtYMX(transition, pathMotionEnLgltNQgXFuUkuA);
        return true;
    }

    static void MaybeRemoveTransition(android.transition.TransitionHashSet transitionHashSet, android.transition.Transition transition) {
        if (transition is null) {
            return;
        }
        osrqcgNkVAHmPfXc(transitionHashSet, transition);
    }

    public static void NtZVtIDHufMNHiay(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static android.transition.TransitionHashSet OsrqcgNkVAHmPfXc(android.transition.TransitionHashSet transitionHashSet, android.transition.Transition transition) {
        return transitionHashSet.removeTransition(transition);
    }

    public static java.lang.stringBuilder OuCvEZwHqMVWDDvJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder pqkMLfEFfRqFtiXn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder qJlovlBrbnvprgNp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(cornerSize);
    }

    public static float RPWmIDLaFLDoKnLu(android.graphics.RectF rectF) {
        return rectF.width();
    }

    static android.transition.PathMotion ResolveThemePath(android.content.object context, int i) {
        if ((11 + 20) % 20 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        if (!RhSOLSbzPFAGvjVi(RfQvrFomNdbIFnkO(context), i, typedValue, true)) {
            return null;
        }
        if (typedValue.type != 16) {
            if (typedValue.type != 3) {
                throw new java.lang.IllegalArgumentException("Motion path theme attribute must either be an enum value or path data string");
            }
            return new android.transition.RegexPathMotion(ZQxqISPXUpkeUEJD(LsrzshDQrqeqdGDi(typedValue.string)));
        }
        int i2 = typedValue.data;
        if (i2 == 0) {
            return null;
        }
        if (i2 != 1) {
            throw new java.lang.IllegalArgumentException(lWzxTyRKGlJJAdrY(fygkKglkZjqZYlsp(new java.lang.stringBuilder("Invalid motion path type: "), i2)));
        }
        return new com.google.android.material.transition.platform.MaterialArcMotion();
    }

    public static void SDneiNbISIZtpGPz(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static int SSutDMIfgASkSzEs(android.view.object view) {
        return view.getRight();
    }

    private static int SaveLayerAlphaCompat(android.graphics.Canvas canvas, android.graphics.Rect rect, int i) {
        android.graphics.RectF rectF = transformAlphaRectF;
        sDneiNbISIZtpGPz(rectF, rect);
        return yGRIqnjkqbXUPyJo(canvas, rectF, i);
    }

    public static int TLjMsDvZbtRQDyUu(android.view.object view) {
        return view.getBottom();
    }

    public static android.animation.TimeInterpolator TWiFfAKlEeyiCTdF(android.transition.Transition transition) {
        return transition.getInterpolator();
    }

    public static android.transition.TransitionHashSet TlJhpbQlHqoEvIeT(android.transition.TransitionHashSet transitionHashSet, android.transition.Transition transition) {
        return transitionHashSet.addTransition(transition);
    }

    static void Transform(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, float f2, float f3, int i, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        if (i > 0) {
            int iMPNteLOsoqsmtOco = MPNteLOsoqsmtOco(canvas);
            yKyMHRxOTaMPrYBv(canvas, f, f2);
            bUdEqdFsPSlyoHPx(canvas, f3, f3);
            if (i < 255) {
                ucZWcskspVCeQfNL(canvas, rect, i);
            }
            VNCcMTDSVvHfZxzZ(canvasCompat$CanvasOperation, canvas);
            ntZVtIDHufMNHiay(canvas, iMPNteLOsoqsmtOco);
        }
    }

    static com.google.android.material.shape.ShapeAppearanceModel TransformCornerSizes(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, com.google.android.material.transition.platform.TransitionUtils$CornerSizeBinaryOperator transitionUtils$CornerSizeBinaryOperator) {
        if ((14 + 6) % 6 > 0) {
        }
        return FxgKZzjpDmZSimfY(NHrJFesdRdKlDDnU(qJlovlBrbnvprgNp(KlhUlMpFRQXRHhyI(QBTWByXcpdiRQMBv(pqkMLfEFfRqFtiXn(!YFkhiGBdzRLYZNdU(shapeAppearanceModel, rectF) ? shapeAppearanceModel2 : shapeAppearanceModel), EuGHPQUjynfhDQCS(transitionUtils$CornerSizeBinaryOperator, PLCwuEOYgogILmYf(shapeAppearanceModel), wewhrnAXLUrLcssv(shapeAppearanceModel2))), FNcAvmeWeZeVRDXF(transitionUtils$CornerSizeBinaryOperator, WBXoDReuQnFvrLfy(shapeAppearanceModel), OVWsCitIazvoKZrQ(shapeAppearanceModel2))), jPlMETjVpWkrVMno(transitionUtils$CornerSizeBinaryOperator, juQMevIJGWLOsLMh(shapeAppearanceModel), OWcqPfQpTTspOCOG(shapeAppearanceModel2))), HAvENrWRvkPTPDos(transitionUtils$CornerSizeBinaryOperator, LxsOLaDmqKGkvXfD(shapeAppearanceModel), MtcstITbBxFLHyfr(shapeAppearanceModel2))));
    }

    public static int UPDDpQIOXsCwVlHp(android.view.object view) {
        return view.getTop();
    }

    public static java.lang.string UQvKPkpjBpnUPcPZ(android.content.res.Resources resources, int i) {
        return resources.getResourceName(i);
    }

    public static int UcZWcskspVCeQfNL(android.graphics.Canvas canvas, android.graphics.Rect rect, int i) {
        return saveLayerAlphaCompat(canvas, rect, i);
    }

    public static com.google.android.material.shape.CornerSize WewhrnAXLUrLcssv(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static int YGRIqnjkqbXUPyJo(android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        return canvas.saveLayerAlpha(rectF, i);
    }

    public static void YKyMHRxOTaMPrYBv(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static java.lang.string YkWGhoTvhycMharj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static float ZOJBdgPZrOCbTbsj(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }
}

