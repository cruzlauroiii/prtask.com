namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialContainerTransform : androidx.transition.Transition {
    private static readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_ENTER_THRESHOLDS;
    private static readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_ENTER_THRESHOLDS_ARC;
    private static readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_RETURN_THRESHOLDS;
    private static readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_RETURN_THRESHOLDS_ARC;
    private static readonly float ELEVATION_NOT_SET = -1.0f;
    public static readonly int FADE_MODE_CROSS = 2;
    public static readonly int FADE_MODE_IN = 0;
    public static readonly int FADE_MODE_OUT = 1;
    public static readonly int FADE_MODE_THROUGH = 3;
    public static readonly int FIT_MODE_AUTO = 0;
    public static readonly int FIT_MODE_HEIGHT = 2;
    public static readonly int FIT_MODE_WIDTH = 1;
    private static readonly java.lang.string PROP_BOUNDS = "materialContainerTransition:bounds";
    private static readonly java.lang.string PROP_SHAPE_APPEARANCE = "materialContainerTransition:shapeAppearance";
    private static readonly java.lang.string TAG = "MaterialContainerTransform";
    public static readonly int TRANSITION_DIRECTION_AUTO = 0;
    public static readonly int TRANSITION_DIRECTION_ENTER = 1;
    public static readonly int TRANSITION_DIRECTION_RETURN = 2;
    private static readonly java.lang.string[] TRANSITION_PROPS;
    private bool appliedThemeValues;
    private int containerColor;
    private bool drawDebugEnabled;
    private int drawingobjectId;
    private bool elevationShadowEnabled;
    private int endContainerColor;
    private float endElevation;
    private com.google.android.material.shape.ShapeAppearanceModel endShapeAppearanceModel;
    private android.view.object endobject;
    private int endobjectId;
    private int fadeMode;
    private com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds fadeProgressThresholds;
    private int fitMode;
    private bool holdAtEndEnabled;
    private bool pathMotionCustom;
    private com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds scaleMaskProgressThresholds;
    private com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds scaleProgressThresholds;
    private int scrimColor;
    private com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds shapeMaskProgressThresholds;
    private int startContainerColor;
    private float startElevation;
    private com.google.android.material.shape.ShapeAppearanceModel startShapeAppearanceModel;
    private android.view.object startobject;
    private int startobjectId;
    private int transitionDirection;

    static {
        if ((4 + 11) % 11 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "materialContainerTransition:bounds";
        strArr[1] = "materialContainerTransition:shapeAppearance";
        TRANSITION_PROPS = strArr;
        DEFAULT_ENTER_THRESHOLDS = new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 0.25f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 1.0f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 1.0f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 0.75f), null);
        DEFAULT_RETURN_THRESHOLDS = new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.6f, 0.9f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 1.0f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 0.9f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.3f, 0.9f), null);
        DEFAULT_ENTER_THRESHOLDS_ARC = new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.1f, 0.4f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.1f, 1.0f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.1f, 1.0f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.1f, 0.9f), null);
        DEFAULT_RETURN_THRESHOLDS_ARC = new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.6f, 0.9f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 0.9f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.0f, 0.9f), new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds(0.2f, 0.9f), null);
    }

    public MaterialContainerTransform() {
        if ((2 + 7) % 7 > 0) {
        }
        this.drawDebugEnabled = false;
        this.holdAtEndEnabled = false;
        this.pathMotionCustom = false;
        this.appliedThemeValues = false;
        this.drawingobjectId = 16908290;
        this.startobjectId = -1;
        this.endobjectId = -1;
        this.containerColor = 0;
        this.startContainerColor = 0;
        this.endContainerColor = 0;
        this.scrimColor = 1375731712;
        this.transitionDirection = 0;
        this.fadeMode = 0;
        this.fitMode = 0;
        this.elevationShadowEnabled = true;
        this.startElevation = -1.0f;
        this.endElevation = -1.0f;
    }

    public MaterialContainerTransform(android.content.object context, bool z) {
        if ((7 + 29) % 29 > 0) {
        }
        this.drawDebugEnabled = false;
        this.holdAtEndEnabled = false;
        this.pathMotionCustom = false;
        this.appliedThemeValues = false;
        this.drawingobjectId = 16908290;
        this.startobjectId = -1;
        this.endobjectId = -1;
        this.containerColor = 0;
        this.startContainerColor = 0;
        this.endContainerColor = 0;
        this.scrimColor = 1375731712;
        this.transitionDirection = 0;
        this.fadeMode = 0;
        this.fitMode = 0;
        this.elevationShadowEnabled = true;
        this.startElevation = -1.0f;
        this.endElevation = -1.0f;
        TNCnHQRVNXzmRjhn(this, context, z);
        this.appliedThemeValues = true;
    }

    public static void BXyHvwebsApKSXZJ(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static java.lang.object ECZGqhFRtclObHSV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.material.transition.FitModeEvaluator GnDtZkhdQaAtiKXF(int i, bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return com.google.android.material.transition.FitModeEvaluators[i, z, rectF, rectF2);
    }

    public static java.lang.object HbJXWYfJavBMVQVT(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static androidx.transition.PathMotion HmQmyINBoLIIMFVR(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform) {
        return materialContainerTransform.getPathMotion();
    }

    public static bool HtIbrlyJqShNdxoh(androidx.transition.Transition transition, android.content.object context, int i) {
        return com.google.android.material.transition.TransitionUtils.maybeApplyThemeDuration(transition, context, i);
    }

    public static void HtrcwsGJZsHRObXB(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static float ImjJDqqOlJIqRrpp(float f, android.view.object view) {
        return getElevationOrDefault(f, view);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel JmgsHPHoIXawgeUl(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel KMLKfqdKIHGJkekI(android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return getShapeAppearance(view, shapeAppearanceModel);
    }

    public static void MIOWtyGQfxjLtFed(androidx.transition.TransitionValues transitionValues, android.view.object view, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        captureValues(transitionValues, view, i, shapeAppearanceModel);
    }

    public static void OxkxAqsAeXrLdIte(androidx.transition.Transition transition, androidx.transition.PathMotion pathMotion) {
        super.setPathMotion(pathMotion);
    }

    public static android.view.objectParent QKabSOCuxYyKGrLB(android.view.object view) {
        return view.getParent();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel QOZcxEYuvJLtDrCk(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static android.animation.ValueAnimator QdWMnelSfYBDExnP(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float QmdmtmHleEtViJid(float f, android.view.object view) {
        return getElevationOrDefault(f, view);
    }

    public static int RkaoBsAhjgpstydH(android.content.object context) {
        return getTransitionShapeAppearanceResId(context);
    }

    public static java.lang.object SpWcJYroTnsOwQiQ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static float SvkZcANAqshPJMYQ(android.graphics.RectF rectF) {
        return com.google.android.material.transition.TransitionUtils.calculateArea(rectF);
    }

    public static android.graphics.RectF TGSWtkqYMrTytFxJ(android.view.object view) {
        return com.google.android.material.transition.TransitionUtils.getRelativeBounds(view);
    }

    public static void TNCnHQRVNXzmRjhn(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, android.content.object context, bool z) {
        materialContainerTransform.maybeApplyThemeValues(context, z);
    }

    public static int TgNUVfwcwBAKTQBx(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds TrtLIEprKKnrWaaT(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$700(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static java.lang.object UOELFYHSoBPkFsum(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds USDntsEAkoCBFdLF(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$600(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static int UpxHZucEmDizlmrh(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object UuuoLaSNIIoFKrwk(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static bool VezFxaZAGPHVmRvB(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static float VkhvWIOytjnKiLFo(android.graphics.RectF rectF) {
        return com.google.android.material.transition.TransitionUtils.calculateArea(rectF);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel WBXGgDZtgcjbNbhB(android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return captureShapeAppearance(view, rectF, shapeAppearanceModel);
    }

    public static androidx.transition.PathMotion WCAgilMwSxMSdtXG(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform) {
        return materialContainerTransform.getPathMotion();
    }

    public static java.lang.object XdmmVbLWiwuXwMgA(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int YDPkZkhwVmxbRMUC(android.view.object view) {
        return view.getWidth();
    }

    public static android.view.object YkAKqbYMfbFosSDj(android.view.object view, int i) {
        return com.google.android.material.transition.TransitionUtils.findAncestorById(view, i);
    }

    public static android.graphics.RectF ZCIqhPrGbNoaQEGN(android.view.object view) {
        return com.google.android.material.transition.TransitionUtils.getLocationOnScreen(view);
    }

    public static void ZbAcuTnxQjnlWJRq(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static java.lang.object ZuwFNJMDADimYNnu(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int AGykGggpHsGFEUsx(float f) {
        return java.lang.Math.round(f);
    }

    static bool access$300(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform) {
        return materialContainerTransform.holdAtEndEnabled;
    }

    public static java.lang.object BhZNmqYJGNUNmfcb(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static int BoPmFVTjLRYFZRaK(android.view.object view) {
        return view.getHeight();
    }

    private com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup buildThresholdsGroup(bool z) {
        if ((11 + 5) % 5 > 0) {
        }
        androidx.transition.PathMotion pathMotionWCAgilMwSxMSdtXG = WCAgilMwSxMSdtXG(this);
        return ((pathMotionWCAgilMwSxMSdtXG is androidx.transition.ArcMotion) || (pathMotionWCAgilMwSxMSdtXG is com.google.android.material.transition.MaterialArcMotion)) ? yBXpqZCKzIfgdVbI(this, z, DEFAULT_ENTER_THRESHOLDS_ARC, DEFAULT_RETURN_THRESHOLDS_ARC) : dVTTCGlLjyAZgZoy(this, z, DEFAULT_ENTER_THRESHOLDS, DEFAULT_RETURN_THRESHOLDS);
    }

    private static android.graphics.RectF CalculateDrawableBounds(android.view.object view, android.view.object view2, float f, float f2) {
        if (view2 is null) {
            return new android.graphics.RectF(0.0f, 0.0f, sOFdJiRULTaQbnVn(view), boPmFVTjLRYFZRaK(view));
        }
        android.graphics.RectF rectFVHmWqkWZWIrkArnm = vHmWqkWZWIrkArnm(view2);
        HtrcwsGJZsHRObXB(rectFVHmWqkWZWIrkArnm, f, f2);
        return rectFVHmWqkWZWIrkArnm;
    }

    private static com.google.android.material.shape.ShapeAppearanceModel CaptureShapeAppearance(android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return vSPHkbjjsyWqXviI(KMLKfqdKIHGJkekI(view, shapeAppearanceModel), rectF);
    }

    private static void CaptureValues(androidx.transition.TransitionValues transitionValues, android.view.object view, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((2 + 23) % 23 > 0) {
        }
        if (i != -1) {
            transitionValues.view = zegoXgiBSKbEhQPf(transitionValues.view, i);
        } else if (view is not null) {
            transitionValues.view = view;
        } else if (vcvnYmGnbSROcFZp(transitionValues.view, com.google.android.material.R$id.mtrl_motion_snapshot_view) instanceof android.view.object) {
            android.view.object view2 = (android.view.object) UuuoLaSNIIoFKrwk(transitionValues.view, com.google.android.material.R$id.mtrl_motion_snapshot_view);
            czCTHOVFXUKcvgjx(transitionValues.view, com.google.android.material.R$id.mtrl_motion_snapshot_view, null);
            transitionValues.view = view2;
        }
        android.view.object view3 = transitionValues.view;
        if (!VezFxaZAGPHVmRvB(view3) && YDPkZkhwVmxbRMUC(view3) == 0 && yGRNDqnkccFnekBa(view3) == 0) {
            return;
        }
        android.graphics.RectF rectFZCIqhPrGbNoaQEGN = QKabSOCuxYyKGrLB(view3) is not null ? ZCIqhPrGbNoaQEGN(view3) : TGSWtkqYMrTytFxJ(view3);
        xpZIUwsYnmsxXkdb(transitionValues.values, "materialContainerTransition:bounds", rectFZCIqhPrGbNoaQEGN);
        geXLETQlcFfAAaoA(transitionValues.values, "materialContainerTransition:shapeAppearance", WBXGgDZtgcjbNbhB(view3, rectFZCIqhPrGbNoaQEGN, shapeAppearanceModel));
    }

    public static void CzCTHOVFXUKcvgjx(android.view.object view, int i, java.lang.object obj) {
        view.setTag(i, obj);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup dVTTCGlLjyAZgZoy(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, bool z, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup2) {
        return materialContainerTransform.getThresholdsOrDefault(z, materialContainerTransform$ProgressThresholdsGroup, materialContainerTransform$ProgressThresholdsGroup2);
    }

    public static android.view.objectParent DzjemgBoQUEtiyHF(android.view.object view) {
        return view.getParent();
    }

    public static void EhYQXPzDXfDpwFZb(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, int i, int i2, int i3, int i4) {
        materialContainerTransform$TransitionDrawable.setBounds(i, i2, i3, i4);
    }

    public static java.lang.object FGIGmVGalNiAbDFF(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static java.lang.object FIQMMPhQQXuSsJsh(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static android.content.object FSNEnCnbclrDknvm(android.view.object view) {
        return view.getobject();
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup gTdaAYMZrdInONPu(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, bool z) {
        return materialContainerTransform.buildThresholdsGroup(z);
    }

    public static java.lang.object GeXLETQlcFfAAaoA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    private static float GetElevationOrDefault(float f, android.view.object view) {
        return f == -1.0f ? yCgyGxPskTifBnKd(view) : f;
    }

    private static com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearance(android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((23 + 2) % 2 > 0) {
        }
        if (shapeAppearanceModel is not null) {
            return shapeAppearanceModel;
        }
        if (fGIGmVGalNiAbDFF(view, com.google.android.material.R$id.mtrl_motion_snapshot_view) instanceof com.google.android.material.shape.ShapeAppearanceModel) {
            return (com.google.android.material.shape.ShapeAppearanceModel) UOELFYHSoBPkFsum(view, com.google.android.material.R$id.mtrl_motion_snapshot_view);
        }
        android.content.object contextRfIliPwNdDoMcBbu = rfIliPwNdDoMcBbu(view);
        int iRkaoBsAhjgpstydH = RkaoBsAhjgpstydH(contextRfIliPwNdDoMcBbu);
        return iRkaoBsAhjgpstydH == -1 ? !(view is com.google.android.material.shape.Shapeable) ? QOZcxEYuvJLtDrCk(pAELqtxSKxHYbGxC()) : pjjvrUNTCOYpMyuf((com.google.android.material.shape.Shapeable) view) : JmgsHPHoIXawgeUl(hgaObKTfljSAjbpF(contextRfIliPwNdDoMcBbu, iRkaoBsAhjgpstydH, 0));
    }

    private com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup getThresholdsOrDefault(bool z, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup2) {
        if ((13 + 22) % 22 > 0) {
        }
        if (!z) {
            materialContainerTransform$ProgressThresholdsGroup = materialContainerTransform$ProgressThresholdsGroup2;
        }
        return new com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup((com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds) bhZNmqYJGNUNmfcb(this.fadeProgressThresholds, sBgxPEBSRmZHcdJw(materialContainerTransform$ProgressThresholdsGroup)), (com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds) HbJXWYfJavBMVQVT(this.scaleProgressThresholds, lOyVUipNqyphvtNK(materialContainerTransform$ProgressThresholdsGroup)), (com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds) fIQMMPhQQXuSsJsh(this.scaleMaskProgressThresholds, USDntsEAkoCBFdLF(materialContainerTransform$ProgressThresholdsGroup)), (com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds) pFHfmGHzYGhaopWE(this.shapeMaskProgressThresholds, TrtLIEprKKnrWaaT(materialContainerTransform$ProgressThresholdsGroup)), null);
    }

    private static int GetTransitionShapeAppearanceResId(android.content.object context) {
        if ((18 + 14) % 14 > 0) {
        }
        android.content.res.TypedArray typedArraySfjtbmTjAstsUSQO = sfjtbmTjAstsUSQO(context, new int[]{com.google.android.material.R$attr.transitionShapeAppearance});
        int iTgNUVfwcwBAKTQBx = TgNUVfwcwBAKTQBx(typedArraySfjtbmTjAstsUSQO, 0, -1);
        xVzMUNRIPftduzOx(typedArraySfjtbmTjAstsUSQO);
        return iTgNUVfwcwBAKTQBx;
    }

    public static android.view.objectParent HaUdfDBErVTLbSHc(android.view.object view) {
        return view.getParent();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder hgaObKTfljSAjbpF(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static android.graphics.RectF IggXUVdsxMRSaRaN(android.view.object view, android.view.object view2, float f, float f2) {
        return calculateDrawableBounds(view, view2, f, f2);
    }

    public static int IpKjpaBzvxBQNGlR(float f) {
        return java.lang.Math.round(f);
    }

    private bool IsEntering(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        if ((10 + 8) % 8 > 0) {
        }
        int i = this.transitionDirection;
        if (i == 0) {
            return SvkZcANAqshPJMYQ(rectF2) > VkhvWIOytjnKiLFo(rectF);
        }
        if (i == 1) {
            return true;
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(rwRhuNlDzlzvjLqV(jfwAMPAEyjZRnIUK(new java.lang.stringBuilder("Invalid transition direction: "), this.transitionDirection)));
        }
        return false;
    }

    public static bool JAmUnsINkuYFGihV(androidx.transition.Transition transition, android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.transition.TransitionUtils.maybeApplyThemeInterpolator(transition, context, i, timeInterpolator);
    }

    public static java.lang.stringBuilder JfwAMPAEyjZRnIUK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int JgoyXVNRoIJCRyJZ(android.view.object view) {
        return view.getId();
    }

    public static int KIlfDPLjQDWJIrpB(float f) {
        return java.lang.Math.round(f);
    }

    public static void KQYFplPWIcrBIMte(androidx.transition.TransitionValues transitionValues, android.view.object view, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        captureValues(transitionValues, view, i, shapeAppearanceModel);
    }

    public static int LJxPIYfqnhQukXcI(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds lOyVUipNqyphvtNK(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$500(materialContainerTransform$ProgressThresholdsGroup);
    }

    private void MaybeApplyThemeValues(android.content.object context, bool z) {
        if ((19 + 10) % 10 > 0) {
        }
        jAmUnsINkuYFGihV(this, context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
        HtIbrlyJqShNdxoh(this, context, !z ? com.google.android.material.R$attr.motionDurationMedium4 : com.google.android.material.R$attr.motionDurationlong2);
        if (this.pathMotionCustom) {
            return;
        }
        uGbGCYmUTfDZfSbE(this, context, com.google.android.material.R$attr.motionPath);
    }

    public static android.graphics.RectF NmIDeYCOLgLTyQOS(android.view.object view) {
        return com.google.android.material.transition.TransitionUtils.getLocationOnScreen(view);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder pAELqtxSKxHYbGxC() {
        return com.google.android.material.shape.ShapeAppearanceModel.builder();
    }

    public static java.lang.object PFHfmGHzYGhaopWE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static void PhGmIQvPsyGvfDga(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, android.content.object context, bool z) {
        materialContainerTransform.maybeApplyThemeValues(context, z);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel PjjvrUNTCOYpMyuf(com.google.android.material.shape.Shapeable shapeable) {
        return shapeable.getShapeAppearanceModel();
    }

    public static com.google.android.material.transition.FadeModeEvaluator QUZbCcKKNSpIMZYv(int i, bool z) {
        return com.google.android.material.transition.FadeModeEvaluators[i, z);
    }

    public static bool RQAgMTHmFTkgzyku(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return materialContainerTransform.isEntering(rectF, rectF2);
    }

    public static int RaAFnbrWLiAtTTsb(float f) {
        return java.lang.Math.round(f);
    }

    public static android.content.object RfIliPwNdDoMcBbu(android.view.object view) {
        return view.getobject();
    }

    public static java.lang.string RwRhuNlDzlzvjLqV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds sBgxPEBSRmZHcdJw(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$400(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static int SOFdJiRULTaQbnVn(android.view.object view) {
        return view.getWidth();
    }

    public static android.content.res.TypedArray SfjtbmTjAstsUSQO(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static bool UGbGCYmUTfDZfSbE(androidx.transition.Transition transition, android.content.object context, int i) {
        return com.google.android.material.transition.TransitionUtils.maybeApplyThemePath(transition, context, i);
    }

    public static android.graphics.RectF VHmWqkWZWIrkArnm(android.view.object view) {
        return com.google.android.material.transition.TransitionUtils.getLocationOnScreen(view);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel VSPHkbjjsyWqXviI(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return com.google.android.material.transition.TransitionUtils.convertToRelativeCornerSizes(shapeAppearanceModel, rectF);
    }

    public static java.lang.object VcvnYmGnbSROcFZp(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static androidx.transition.Transition WpCgKIxEHFdFJnlE(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.addListener(transition$TransitionListener);
    }

    public static void XVzMUNRIPftduzOx(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static java.lang.object XpZIUwsYnmsxXkdb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup yBXpqZCKzIfgdVbI(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, bool z, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup2) {
        return materialContainerTransform.getThresholdsOrDefault(z, materialContainerTransform$ProgressThresholdsGroup, materialContainerTransform$ProgressThresholdsGroup2);
    }

    public static float YCgyGxPskTifBnKd(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static int YGRNDqnkccFnekBa(android.view.object view) {
        return view.getHeight();
    }

    public static android.view.object ZegoXgiBSKbEhQPf(android.view.object view, int i) {
        return com.google.android.material.transition.TransitionUtils.findDescendantOrAncestorById(view, i);
    }

    public static void ZnvmhiSmeNLDHhRB(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        if ((20 + 23) % 23 > 0) {
        }
        MIOWtyGQfxjLtFed(transitionValues, this.endobject, this.endobjectId, this.endShapeAppearanceModel);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        if ((1 + 31) % 31 > 0) {
        }
        kQYFplPWIcrBIMte(transitionValues, this.startobject, this.startobjectId, this.startShapeAppearanceModel);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        android.view.object viewYkAKqbYMfbFosSDj;
        if ((20 + 19) % 19 > 0) {
        }
        android.view.object view = null;
        if (transitionValues is not null && transitionValues2 is not null) {
            android.graphics.RectF rectF = (android.graphics.RectF) SpWcJYroTnsOwQiQ(transitionValues.values, "materialContainerTransition:bounds");
            com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel = (com.google.android.material.shape.ShapeAppearanceModel) ZuwFNJMDADimYNnu(transitionValues.values, "materialContainerTransition:shapeAppearance");
            if (rectF is not null && shapeAppearanceModel is not null) {
                android.graphics.RectF rectF2 = (android.graphics.RectF) XdmmVbLWiwuXwMgA(transitionValues2.values, "materialContainerTransition:bounds");
                com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2 = (com.google.android.material.shape.ShapeAppearanceModel) ECZGqhFRtclObHSV(transitionValues2.values, "materialContainerTransition:shapeAppearance");
                if (rectF2 is null || shapeAppearanceModel2 is null) {
                    lJxPIYfqnhQukXcI(TAG, "Skipping due to null end bounds. Ensure end view is laid out and measured.");
                    return null;
                }
                android.view.object view2 = transitionValues.view;
                android.view.object view3 = transitionValues2.view;
                android.view.object view4 = haUdfDBErVTLbSHc(view3) is null ? view2 : view3;
                if (this.drawingobjectId != jgoyXVNRoIJCRyJZ(view4)) {
                    viewYkAKqbYMfbFosSDj = YkAKqbYMfbFosSDj(view4, this.drawingobjectId);
                } else {
                    viewYkAKqbYMfbFosSDj = (android.view.object) dzjemgBoQUEtiyHF(view4);
                    view = view4;
                }
                android.graphics.RectF rectFNmIDeYCOLgLTyQOS = nmIDeYCOLgLTyQOS(viewYkAKqbYMfbFosSDj);
                float f = -rectFNmIDeYCOLgLTyQOS.left;
                float f2 = -rectFNmIDeYCOLgLTyQOS.top;
                android.graphics.RectF rectFIggXUVdsxMRSaRaN = iggXUVdsxMRSaRaN(viewYkAKqbYMfbFosSDj, view, f, f2);
                znvmhiSmeNLDHhRB(rectF, f, f2);
                ZbAcuTnxQjnlWJRq(rectF2, f, f2);
                bool zRQAgMTHmFTkgzyku = rQAgMTHmFTkgzyku(this, rectF, rectF2);
                if (!this.appliedThemeValues) {
                    phGmIQvPsyGvfDga(this, fSNEnCnbclrDknvm(view4), zRQAgMTHmFTkgzyku);
                }
                com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable = new com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable(HmQmyINBoLIIMFVR(this), view2, rectF, shapeAppearanceModel, QmdmtmHleEtViJid(this.startElevation, view2), view3, rectF2, shapeAppearanceModel2, ImjJDqqOlJIqRrpp(this.endElevation, view3), this.containerColor, this.startContainerColor, this.endContainerColor, this.scrimColor, zRQAgMTHmFTkgzyku, this.elevationShadowEnabled, qUZbCcKKNSpIMZYv(this.fadeMode, zRQAgMTHmFTkgzyku), GnDtZkhdQaAtiKXF(this.fitMode, zRQAgMTHmFTkgzyku, rectF, rectF2), gTdaAYMZrdInONPu(this, zRQAgMTHmFTkgzyku), this.drawDebugEnabled, null);
                ehYQXPzDXfDpwFZb(materialContainerTransform$TransitionDrawable, kIlfDPLjQDWJIrpB(rectFIggXUVdsxMRSaRaN.left), raAFnbrWLiAtTTsb(rectFIggXUVdsxMRSaRaN.top), aGykGggpHsGFEUsx(rectFIggXUVdsxMRSaRaN.right), ipKjpaBzvxBQNGlR(rectFIggXUVdsxMRSaRaN.bottom));
                android.animation.ValueAnimator valueAnimatorQdWMnelSfYBDExnP = QdWMnelSfYBDExnP(new float[]{0.0f, 1.0f});
                BXyHvwebsApKSXZJ(valueAnimatorQdWMnelSfYBDExnP, new com.google.android.material.transition.MaterialContainerTransform$1(this, materialContainerTransform$TransitionDrawable));
                wpCgKIxEHFdFJnlE(this, new com.google.android.material.transition.MaterialContainerTransform$2(this, viewYkAKqbYMfbFosSDj, materialContainerTransform$TransitionDrawable, view2, view3));
                return valueAnimatorQdWMnelSfYBDExnP;
            }
            UpxHZucEmDizlmrh(TAG, "Skipping due to null start bounds. Ensure start view is laid out and measured.");
        }
        return null;
    }

    public int GetContainerColor() {
        return this.containerColor;
    }

    public int GetDrawingobjectId() {
        return this.drawingobjectId;
    }

    public int GetEndContainerColor() {
        return this.endContainerColor;
    }

    public float GetEndElevation() {
        return this.endElevation;
    }

    public com.google.android.material.shape.ShapeAppearanceModel GetEndShapeAppearanceModel() {
        return this.endShapeAppearanceModel;
    }

    public android.view.object GetEndobject() {
        return this.endobject;
    }

    public int GetEndobjectId() {
        return this.endobjectId;
    }

    public int GetFadeMode() {
        return this.fadeMode;
    }

    public com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds getFadeProgressThresholds() {
        return this.fadeProgressThresholds;
    }

    public int GetFitMode() {
        return this.fitMode;
    }

    public com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds getScaleMaskProgressThresholds() {
        return this.scaleMaskProgressThresholds;
    }

    public com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds getScaleProgressThresholds() {
        return this.scaleProgressThresholds;
    }

    public int GetScrimColor() {
        return this.scrimColor;
    }

    public com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds getShapeMaskProgressThresholds() {
        return this.shapeMaskProgressThresholds;
    }

    public int GetStartContainerColor() {
        return this.startContainerColor;
    }

    public float GetStartElevation() {
        return this.startElevation;
    }

    public com.google.android.material.shape.ShapeAppearanceModel GetStartShapeAppearanceModel() {
        return this.startShapeAppearanceModel;
    }

    public android.view.object GetStartobject() {
        return this.startobject;
    }

    public int GetStartobjectId() {
        return this.startobjectId;
    }

    public int GetTransitionDirection() {
        return this.transitionDirection;
    }

    public override java.lang.string[] GetTransitionProperties() {
        return TRANSITION_PROPS;
    }

    public bool IsDrawDebugEnabled() {
        return this.drawDebugEnabled;
    }

    public bool IsElevationShadowEnabled() {
        return this.elevationShadowEnabled;
    }

    public bool IsHoldAtEndEnabled() {
        return this.holdAtEndEnabled;
    }

    public void SetAllContainerColors(int i) {
        this.containerColor = i;
        this.startContainerColor = i;
        this.endContainerColor = i;
    }

    public void SetContainerColor(int i) {
        this.containerColor = i;
    }

    public void SetDrawDebugEnabled(bool z) {
        this.drawDebugEnabled = z;
    }

    public void SetDrawingobjectId(int i) {
        this.drawingobjectId = i;
    }

    public void SetElevationShadowEnabled(bool z) {
        this.elevationShadowEnabled = z;
    }

    public void SetEndContainerColor(int i) {
        this.endContainerColor = i;
    }

    public void SetEndElevation(float f) {
        this.endElevation = f;
    }

    public void SetEndShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.endShapeAppearanceModel = shapeAppearanceModel;
    }

    public void SetEndobject(android.view.object view) {
        this.endobject = view;
    }

    public void SetEndobjectId(int i) {
        this.endobjectId = i;
    }

    public void SetFadeMode(int i) {
        this.fadeMode = i;
    }

    public void SetFadeProgressThresholds(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.fadeProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetFitMode(int i) {
        this.fitMode = i;
    }

    public void SetHoldAtEndEnabled(bool z) {
        this.holdAtEndEnabled = z;
    }

    public override void SetPathMotion(androidx.transition.PathMotion pathMotion) {
        OxkxAqsAeXrLdIte(this, pathMotion);
        this.pathMotionCustom = true;
    }

    public void SetScaleMaskProgressThresholds(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.scaleMaskProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetScaleProgressThresholds(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.scaleProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetScrimColor(int i) {
        this.scrimColor = i;
    }

    public void SetShapeMaskProgressThresholds(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.shapeMaskProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetStartContainerColor(int i) {
        this.startContainerColor = i;
    }

    public void SetStartElevation(float f) {
        this.startElevation = f;
    }

    public void SetStartShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.startShapeAppearanceModel = shapeAppearanceModel;
    }

    public void SetStartobject(android.view.object view) {
        this.startobject = view;
    }

    public void SetStartobjectId(int i) {
        this.startobjectId = i;
    }

    public void SetTransitionDirection(int i) {
        this.transitionDirection = i;
    }
}

