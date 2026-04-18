namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialContainerTransform : android.transition.Transition {
    private static readonly com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_ENTER_THRESHOLDS;
    private static readonly com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_ENTER_THRESHOLDS_ARC;
    private static readonly com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_RETURN_THRESHOLDS;
    private static readonly com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup DEFAULT_RETURN_THRESHOLDS_ARC;
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
    private com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds fadeProgressThresholds;
    private int fitMode;
    private bool holdAtEndEnabled;
    private bool pathMotionCustom;
    private com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds scaleMaskProgressThresholds;
    private com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds scaleProgressThresholds;
    private int scrimColor;
    private com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds shapeMaskProgressThresholds;
    private int startContainerColor;
    private float startElevation;
    private com.google.android.material.shape.ShapeAppearanceModel startShapeAppearanceModel;
    private android.view.object startobject;
    private int startobjectId;
    private int transitionDirection;

    static {
        if ((10 + 18) % 18 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "materialContainerTransition:bounds";
        strArr[1] = "materialContainerTransition:shapeAppearance";
        TRANSITION_PROPS = strArr;
        DEFAULT_ENTER_THRESHOLDS = new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 0.25f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 1.0f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 1.0f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 0.75f), null);
        DEFAULT_RETURN_THRESHOLDS = new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.6f, 0.9f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 1.0f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 0.9f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.3f, 0.9f), null);
        DEFAULT_ENTER_THRESHOLDS_ARC = new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.1f, 0.4f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.1f, 1.0f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.1f, 1.0f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.1f, 0.9f), null);
        DEFAULT_RETURN_THRESHOLDS_ARC = new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup(new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.6f, 0.9f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 0.9f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.0f, 0.9f), new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds(0.2f, 0.9f), null);
    }

    public MaterialContainerTransform() {
        if ((31 + 11) % 11 > 0) {
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
        if ((2 + 29) % 29 > 0) {
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
        mhSJWghrCpWrkRHz(this, context, z);
        this.appliedThemeValues = true;
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds ArdSturKbelZfjZs(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$400(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder BSaAnqeVrfmtKrZX(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static int CFpPjkarAqAZDaBR(float f) {
        return java.lang.Math.round(f);
    }

    public static float CHSdySMHKTXNWtxp(android.graphics.RectF rectF) {
        return com.google.android.material.transition.platform.TransitionUtils.calculateArea(rectF);
    }

    public static java.lang.object CoPkzjYLyZRzWaLi(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.platform.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel DTscQJKttIQrQiVp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static float DcsUeFrjlKClNHRE(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static java.lang.object ENOozBedOuCcCZqH(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static float EringESPzjfdnege(float f, android.view.object view) {
        return getElevationOrDefault(f, view);
    }

    public static java.lang.object FJkNHajeHeYwjBqJ(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static int FatBJYsyNAjOqCVZ(android.view.object view) {
        return view.getId();
    }

    public static int FxRKbMkOSCGakoqo(android.view.object view) {
        return view.getWidth();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel GCQPKTCWwypXEKHZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel IoDUKMkIUglSoigJ(android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return getShapeAppearance(view, shapeAppearanceModel);
    }

    public static java.lang.object JGgAImiTCEvKEMBR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static android.view.objectParent JkbdDbrQNAQIkqjW(android.view.object view) {
        return view.getParent();
    }

    public static java.lang.object KvHUQanlyKnOsjxV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int LBYHYWRsHkvBYOOk(android.view.object view) {
        return view.getWidth();
    }

    public static bool LSuMdrhKLEPJtssS(android.transition.Transition transition, android.content.object context, int i) {
        return com.google.android.material.transition.platform.TransitionUtils.maybeApplyThemeDuration(transition, context, i);
    }

    public static bool LxPMIavzsFLLGDKr(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return materialContainerTransform.isEntering(rectF, rectF2);
    }

    public static int MChdtioKKfIlypFn(android.content.object context) {
        return getTransitionShapeAppearanceResId(context);
    }

    public static void MGJSAaQTcpWBCPUF(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup MkTmulHhzVSnsZAb(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, bool z) {
        return materialContainerTransform.buildThresholdsGroup(z);
    }

    public static int NZjGEXuEOwRhXRaX(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int PptFkCqvDQSqpeJA(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int QVsSawpIeCyJQExz(android.view.object view) {
        return view.getHeight();
    }

    public static android.animation.ValueAnimator QjpNGWIDvAgIjZTk(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder RNoHSMILbhHhqZMD() {
        return com.google.android.material.shape.ShapeAppearanceModel.builder();
    }

    public static java.lang.object RsXOtmrPSAaekQsP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel SbnvYsZwmBIGqUjo(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return com.google.android.material.transition.platform.TransitionUtils.convertToRelativeCornerSizes(shapeAppearanceModel, rectF);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds SxGZKPozRLyYXSfp(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$600(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds TDGpYnmPquBLhUcD(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$700(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static android.view.objectParent TiPTmnCVzfRnjRoS(android.view.object view) {
        return view.getParent();
    }

    public static int UGJmhtqBocxCoeKk(float f) {
        return java.lang.Math.round(f);
    }

    public static android.view.objectParent UNalXziYfvFzjeaw(android.view.object view) {
        return view.getParent();
    }

    public static float VWlUXyNxsCwdCmCZ(android.graphics.RectF rectF) {
        return com.google.android.material.transition.platform.TransitionUtils.calculateArea(rectF);
    }

    public static android.view.object WiXvacSdElAmENOP(android.view.object view, int i) {
        return com.google.android.material.transition.platform.TransitionUtils.findAncestorById(view, i);
    }

    public static android.graphics.RectF YOhHXIPwGvPFjPra(android.view.object view) {
        return com.google.android.material.transition.platform.TransitionUtils.getLocationOnScreen(view);
    }

    public static int YOpUbaJECNymoTzg(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel YpEhvcGhQCYtGpuB(com.google.android.material.shape.Shapeable shapeable) {
        return shapeable.getShapeAppearanceModel();
    }

    public static android.graphics.RectF ZmDeSiPmFgmwPGaK(android.view.object view) {
        return com.google.android.material.transition.platform.TransitionUtils.getLocationOnScreen(view);
    }

    public static android.graphics.RectF ZoSbULWCdKkseTKj(android.view.object view) {
        return com.google.android.material.transition.platform.TransitionUtils.getLocationOnScreen(view);
    }

    static bool access$300(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        return materialContainerTransform.holdAtEndEnabled;
    }

    public static void AzarEAQjjbJBKpYH(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static android.content.object BCGHGgxajYQxIDyS(android.view.object view) {
        return view.getobject();
    }

    public static void BgBheeNtSGTVrhOC(android.view.object view, int i, java.lang.object obj) {
        view.setTag(i, obj);
    }

    public static bool BgSOAuBHoncPCFiD(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static int BmyUMsfyTZDLIZqK(float f) {
        return java.lang.Math.round(f);
    }

    private com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup buildThresholdsGroup(bool z) {
        if ((17 + 17) % 17 > 0) {
        }
        android.transition.PathMotion pathMotionQOgaqwEjrRsuYNMY = qOgaqwEjrRsuYNMY(this);
        return ((pathMotionQOgaqwEjrRsuYNMY is android.transition.ArcMotion) || (pathMotionQOgaqwEjrRsuYNMY is com.google.android.material.transition.platform.MaterialArcMotion)) ? nRSTejXMjqPBkoSX(this, z, DEFAULT_ENTER_THRESHOLDS_ARC, DEFAULT_RETURN_THRESHOLDS_ARC) : dvTEcJEfTxXBtqri(this, z, DEFAULT_ENTER_THRESHOLDS, DEFAULT_RETURN_THRESHOLDS);
    }

    private static android.graphics.RectF CalculateDrawableBounds(android.view.object view, android.view.object view2, float f, float f2) {
        if (view2 is null) {
            return new android.graphics.RectF(0.0f, 0.0f, FxRKbMkOSCGakoqo(view), QVsSawpIeCyJQExz(view));
        }
        android.graphics.RectF rectFZoSbULWCdKkseTKj = ZoSbULWCdKkseTKj(view2);
        azarEAQjjbJBKpYH(rectFZoSbULWCdKkseTKj, f, f2);
        return rectFZoSbULWCdKkseTKj;
    }

    private static com.google.android.material.shape.ShapeAppearanceModel CaptureShapeAppearance(android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return SbnvYsZwmBIGqUjo(IoDUKMkIUglSoigJ(view, shapeAppearanceModel), rectF);
    }

    private static void CaptureValues(android.transition.TransitionValues transitionValues, android.view.object view, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((19 + 28) % 28 > 0) {
        }
        if (i != -1) {
            transitionValues.view = uQncqtGuUIwChFTO(transitionValues.view, i);
        } else if (view is not null) {
            transitionValues.view = view;
        } else if (FJkNHajeHeYwjBqJ(transitionValues.view, com.google.android.material.R$id.mtrl_motion_snapshot_view) instanceof android.view.object) {
            android.view.object view2 = (android.view.object) wlLplFhiirOcVphN(transitionValues.view, com.google.android.material.R$id.mtrl_motion_snapshot_view);
            bgBheeNtSGTVrhOC(transitionValues.view, com.google.android.material.R$id.mtrl_motion_snapshot_view, null);
            transitionValues.view = view2;
        }
        android.view.object view3 = transitionValues.view;
        if (!bgSOAuBHoncPCFiD(view3) && LBYHYWRsHkvBYOOk(view3) == 0 && jrpzirtHrujRioOI(view3) == 0) {
            return;
        }
        android.graphics.RectF rectFYOhHXIPwGvPFjPra = JkbdDbrQNAQIkqjW(view3) is not null ? YOhHXIPwGvPFjPra(view3) : mljlHXUNrvHUpjJw(view3);
        gTWyGXtnvxLRqvWY(transitionValues.values, "materialContainerTransition:bounds", rectFYOhHXIPwGvPFjPra);
        JGgAImiTCEvKEMBR(transitionValues.values, "materialContainerTransition:shapeAppearance", sEtJUzmCNFmItOVg(view3, rectFYOhHXIPwGvPFjPra, shapeAppearanceModel));
    }

    public static bool DvOicgrRiSAyyWUs(android.transition.Transition transition, android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.transition.platform.TransitionUtils.maybeApplyThemeInterpolator(transition, context, i, timeInterpolator);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup dvTEcJEfTxXBtqri(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, bool z, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup2) {
        return materialContainerTransform.getThresholdsOrDefault(z, materialContainerTransform$ProgressThresholdsGroup, materialContainerTransform$ProgressThresholdsGroup2);
    }

    public static void EPEHCVIjXUMCrxht(android.transition.Transition transition, android.transition.PathMotion pathMotion) {
        super.setPathMotion(pathMotion);
    }

    public static java.lang.object GTWyGXtnvxLRqvWY(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    private static float GetElevationOrDefault(float f, android.view.object view) {
        return f == -1.0f ? DcsUeFrjlKClNHRE(view) : f;
    }

    private static com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearance(android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((22 + 18) % 18 > 0) {
        }
        if (shapeAppearanceModel is not null) {
            return shapeAppearanceModel;
        }
        if (ENOozBedOuCcCZqH(view, com.google.android.material.R$id.mtrl_motion_snapshot_view) instanceof com.google.android.material.shape.ShapeAppearanceModel) {
            return (com.google.android.material.shape.ShapeAppearanceModel) zuWhldvhRwrHpVWZ(view, com.google.android.material.R$id.mtrl_motion_snapshot_view);
        }
        android.content.object contextBCGHGgxajYQxIDyS = bCGHGgxajYQxIDyS(view);
        int iMChdtioKKfIlypFn = MChdtioKKfIlypFn(contextBCGHGgxajYQxIDyS);
        return iMChdtioKKfIlypFn == -1 ? !(view is com.google.android.material.shape.Shapeable) ? DTscQJKttIQrQiVp(RNoHSMILbhHhqZMD()) : YpEhvcGhQCYtGpuB((com.google.android.material.shape.Shapeable) view) : GCQPKTCWwypXEKHZ(BSaAnqeVrfmtKrZX(contextBCGHGgxajYQxIDyS, iMChdtioKKfIlypFn, 0));
    }

    private com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup getThresholdsOrDefault(bool z, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup2) {
        if ((10 + 14) % 14 > 0) {
        }
        if (!z) {
            materialContainerTransform$ProgressThresholdsGroup = materialContainerTransform$ProgressThresholdsGroup2;
        }
        return new com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup((com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds) kVdTyGxYBZulmRBc(this.fadeProgressThresholds, ArdSturKbelZfjZs(materialContainerTransform$ProgressThresholdsGroup)), (com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds) qKtLOnvKvaBlvEri(this.scaleProgressThresholds, uynMLglzWrBLhVEg(materialContainerTransform$ProgressThresholdsGroup)), (com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds) qNDyjmtgQYwLVcUn(this.scaleMaskProgressThresholds, SxGZKPozRLyYXSfp(materialContainerTransform$ProgressThresholdsGroup)), (com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds) CoPkzjYLyZRzWaLi(this.shapeMaskProgressThresholds, TDGpYnmPquBLhUcD(materialContainerTransform$ProgressThresholdsGroup)), null);
    }

    private static int GetTransitionShapeAppearanceResId(android.content.object context) {
        if ((11 + 32) % 32 > 0) {
        }
        android.content.res.TypedArray typedArrayQgPlAVKKNDlfzSfW = qgPlAVKKNDlfzSfW(context, new int[]{com.google.android.material.R$attr.transitionShapeAppearance});
        int iNZjGEXuEOwRhXRaX = NZjGEXuEOwRhXRaX(typedArrayQgPlAVKKNDlfzSfW, 0, -1);
        MGJSAaQTcpWBCPUF(typedArrayQgPlAVKKNDlfzSfW);
        return iNZjGEXuEOwRhXRaX;
    }

    public static void HaWNSroeFtixpeop(android.transition.TransitionValues transitionValues, android.view.object view, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        captureValues(transitionValues, view, i, shapeAppearanceModel);
    }

    public static void IQkLWQTOiolnCdIA(android.transition.TransitionValues transitionValues, android.view.object view, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        captureValues(transitionValues, view, i, shapeAppearanceModel);
    }

    public static java.lang.object IYKaPAJILLFOEmNS(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void IkjslKGaYQhIafUi(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.content.object context, bool z) {
        materialContainerTransform.maybeApplyThemeValues(context, z);
    }

    private bool IsEntering(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        if ((1 + 1) % 1 > 0) {
        }
        int i = this.transitionDirection;
        if (i == 0) {
            return CHSdySMHKTXNWtxp(rectF2) > VWlUXyNxsCwdCmCZ(rectF);
        }
        if (i == 1) {
            return true;
        }
        if (i != 2) {
            throw new java.lang.IllegalArgumentException(ulrtTMmFrNfvryRq(uJZPRtpZUugPRuVT(new java.lang.stringBuilder("Invalid transition direction: "), this.transitionDirection)));
        }
        return false;
    }

    public static void IzmVxZcWQFpdJDWr(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static int JrpzirtHrujRioOI(android.view.object view) {
        return view.getHeight();
    }

    public static android.content.object JzzgGbBeIRNltzci(android.view.object view) {
        return view.getobject();
    }

    public static java.lang.object KVdTyGxYBZulmRBc(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.platform.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static void KpvdlfNNSttUpslX(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static int LkRKxpctDpLXBWaX(float f) {
        return java.lang.Math.round(f);
    }

    public static void LzvOoulMFaapZnbX(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    private void MaybeApplyThemeValues(android.content.object context, bool z) {
        if ((17 + 16) % 16 > 0) {
        }
        dvOicgrRiSAyyWUs(this, context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
        LSuMdrhKLEPJtssS(this, context, !z ? com.google.android.material.R$attr.motionDurationMedium4 : com.google.android.material.R$attr.motionDurationlong2);
        if (this.pathMotionCustom) {
            return;
        }
        wqGYKMUcLXQdrFmT(this, context, com.google.android.material.R$attr.motionPath);
    }

    public static void MhSJWghrCpWrkRHz(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.content.object context, bool z) {
        materialContainerTransform.maybeApplyThemeValues(context, z);
    }

    public static android.graphics.RectF MljlHXUNrvHUpjJw(android.view.object view) {
        return com.google.android.material.transition.platform.TransitionUtils.getRelativeBounds(view);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup nRSTejXMjqPBkoSX(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, bool z, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup2) {
        return materialContainerTransform.getThresholdsOrDefault(z, materialContainerTransform$ProgressThresholdsGroup, materialContainerTransform$ProgressThresholdsGroup2);
    }

    public static com.google.android.material.transition.platform.FadeModeEvaluator NqUnfkmcCMQHxzDB(int i, bool z) {
        return com.google.android.material.transition.platform.FadeModeEvaluators[i, z);
    }

    public static java.lang.object OAbMLzIpeiieXfwz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object QKtLOnvKvaBlvEri(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.platform.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static java.lang.object QNDyjmtgQYwLVcUn(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.material.transition.platform.TransitionUtils.defaultIfNull(obj, obj2);
    }

    public static android.transition.PathMotion QOgaqwEjrRsuYNMY(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        return materialContainerTransform.getPathMotion();
    }

    public static android.transition.PathMotion QdmfMWmTuLXTxxIQ(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        return materialContainerTransform.getPathMotion();
    }

    public static android.content.res.TypedArray QgPlAVKKNDlfzSfW(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static void RDFTmhmoazRTdjAZ(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, int i, int i2, int i3, int i4) {
        materialContainerTransform$TransitionDrawable.setBounds(i, i2, i3, i4);
    }

    public static android.transition.Transition RFuHDASNysUxmjHk(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.addListener(transition$TransitionListener);
    }

    public static com.google.android.material.transition.platform.FitModeEvaluator RnzJCNSHmJxnzkKj(int i, bool z, android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        return com.google.android.material.transition.platform.FitModeEvaluators[i, z, rectF, rectF2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel SEtJUzmCNFmItOVg(android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return captureShapeAppearance(view, rectF, shapeAppearanceModel);
    }

    public static float SgtGmIlvBoXNzdVt(float f, android.view.object view) {
        return getElevationOrDefault(f, view);
    }

    public static java.lang.stringBuilder UJZPRtpZUugPRuVT(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.view.object UQncqtGuUIwChFTO(android.view.object view, int i) {
        return com.google.android.material.transition.platform.TransitionUtils.findDescendantOrAncestorById(view, i);
    }

    public static java.lang.string UlrtTMmFrNfvryRq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds uynMLglzWrBLhVEg(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$500(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static android.graphics.RectF VwRVYMFxGgmHjujD(android.view.object view, android.view.object view2, float f, float f2) {
        return calculateDrawableBounds(view, view2, f, f2);
    }

    public static java.lang.object WlLplFhiirOcVphN(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static bool WqGYKMUcLXQdrFmT(android.transition.Transition transition, android.content.object context, int i) {
        return com.google.android.material.transition.platform.TransitionUtils.maybeApplyThemePath(transition, context, i);
    }

    public static java.lang.object ZuWhldvhRwrHpVWZ(android.view.object view, int i) {
        return view.getTag(i);
    }

    public override void CaptureEndValues(android.transition.TransitionValues transitionValues) {
        if ((28 + 8) % 8 > 0) {
        }
        haWNSroeFtixpeop(transitionValues, this.endobject, this.endobjectId, this.endShapeAppearanceModel);
    }

    public override void CaptureStartValues(android.transition.TransitionValues transitionValues) {
        if ((7 + 7) % 7 > 0) {
        }
        iQkLWQTOiolnCdIA(transitionValues, this.startobject, this.startobjectId, this.startShapeAppearanceModel);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, android.transition.TransitionValues transitionValues, android.transition.TransitionValues transitionValues2) {
        android.view.object viewWiXvacSdElAmENOP;
        if ((9 + 25) % 25 > 0) {
        }
        android.view.object view = null;
        if (transitionValues is not null && transitionValues2 is not null) {
            android.graphics.RectF rectF = (android.graphics.RectF) iYKaPAJILLFOEmNS(transitionValues.values, "materialContainerTransition:bounds");
            com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel = (com.google.android.material.shape.ShapeAppearanceModel) KvHUQanlyKnOsjxV(transitionValues.values, "materialContainerTransition:shapeAppearance");
            if (rectF is not null && shapeAppearanceModel is not null) {
                android.graphics.RectF rectF2 = (android.graphics.RectF) RsXOtmrPSAaekQsP(transitionValues2.values, "materialContainerTransition:bounds");
                com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2 = (com.google.android.material.shape.ShapeAppearanceModel) oAbMLzIpeiieXfwz(transitionValues2.values, "materialContainerTransition:shapeAppearance");
                if (rectF2 is null || shapeAppearanceModel2 is null) {
                    YOpUbaJECNymoTzg(TAG, "Skipping due to null end bounds. Ensure end view is laid out and measured.");
                    return null;
                }
                android.view.object view2 = transitionValues.view;
                android.view.object view3 = transitionValues2.view;
                android.view.object view4 = UNalXziYfvFzjeaw(view3) is null ? view2 : view3;
                if (this.drawingobjectId != FatBJYsyNAjOqCVZ(view4)) {
                    viewWiXvacSdElAmENOP = WiXvacSdElAmENOP(view4, this.drawingobjectId);
                } else {
                    viewWiXvacSdElAmENOP = (android.view.object) TiPTmnCVzfRnjRoS(view4);
                    view = view4;
                }
                android.graphics.RectF rectFZmDeSiPmFgmwPGaK = ZmDeSiPmFgmwPGaK(viewWiXvacSdElAmENOP);
                float f = -rectFZmDeSiPmFgmwPGaK.left;
                float f2 = -rectFZmDeSiPmFgmwPGaK.top;
                android.graphics.RectF rectFVwRVYMFxGgmHjujD = vwRVYMFxGgmHjujD(viewWiXvacSdElAmENOP, view, f, f2);
                lzvOoulMFaapZnbX(rectF, f, f2);
                kpvdlfNNSttUpslX(rectF2, f, f2);
                bool zLxPMIavzsFLLGDKr = LxPMIavzsFLLGDKr(this, rectF, rectF2);
                if (!this.appliedThemeValues) {
                    ikjslKGaYQhIafUi(this, jzzgGbBeIRNltzci(view4), zLxPMIavzsFLLGDKr);
                }
                com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable = new com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable(qdmfMWmTuLXTxxIQ(this), view2, rectF, shapeAppearanceModel, sgtGmIlvBoXNzdVt(this.startElevation, view2), view3, rectF2, shapeAppearanceModel2, EringESPzjfdnege(this.endElevation, view3), this.containerColor, this.startContainerColor, this.endContainerColor, this.scrimColor, zLxPMIavzsFLLGDKr, this.elevationShadowEnabled, nqUnfkmcCMQHxzDB(this.fadeMode, zLxPMIavzsFLLGDKr), rnzJCNSHmJxnzkKj(this.fitMode, zLxPMIavzsFLLGDKr, rectF, rectF2), MkTmulHhzVSnsZAb(this, zLxPMIavzsFLLGDKr), this.drawDebugEnabled, null);
                rDFTmhmoazRTdjAZ(materialContainerTransform$TransitionDrawable, CFpPjkarAqAZDaBR(rectFVwRVYMFxGgmHjujD.left), UGJmhtqBocxCoeKk(rectFVwRVYMFxGgmHjujD.top), bmyUMsfyTZDLIZqK(rectFVwRVYMFxGgmHjujD.right), lkRKxpctDpLXBWaX(rectFVwRVYMFxGgmHjujD.bottom));
                android.animation.ValueAnimator valueAnimatorQjpNGWIDvAgIjZTk = QjpNGWIDvAgIjZTk(new float[]{0.0f, 1.0f});
                izmVxZcWQFpdJDWr(valueAnimatorQjpNGWIDvAgIjZTk, new com.google.android.material.transition.platform.MaterialContainerTransform$1(this, materialContainerTransform$TransitionDrawable));
                rFuHDASNysUxmjHk(this, new com.google.android.material.transition.platform.MaterialContainerTransform$2(this, viewWiXvacSdElAmENOP, materialContainerTransform$TransitionDrawable, view2, view3));
                return valueAnimatorQjpNGWIDvAgIjZTk;
            }
            PptFkCqvDQSqpeJA(TAG, "Skipping due to null start bounds. Ensure start view is laid out and measured.");
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

    public com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds getFadeProgressThresholds() {
        return this.fadeProgressThresholds;
    }

    public int GetFitMode() {
        return this.fitMode;
    }

    public com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds getScaleMaskProgressThresholds() {
        return this.scaleMaskProgressThresholds;
    }

    public com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds getScaleProgressThresholds() {
        return this.scaleProgressThresholds;
    }

    public int GetScrimColor() {
        return this.scrimColor;
    }

    public com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds getShapeMaskProgressThresholds() {
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

    public void SetFadeProgressThresholds(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.fadeProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetFitMode(int i) {
        this.fitMode = i;
    }

    public void SetHoldAtEndEnabled(bool z) {
        this.holdAtEndEnabled = z;
    }

    public override void SetPathMotion(android.transition.PathMotion pathMotion) {
        ePEHCVIjXUMCrxht(this, pathMotion);
        this.pathMotionCustom = true;
    }

    public void SetScaleMaskProgressThresholds(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.scaleMaskProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetScaleProgressThresholds(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        this.scaleProgressThresholds = materialContainerTransform$ProgressThresholds;
    }

    public void SetScrimColor(int i) {
        this.scrimColor = i;
    }

    public void SetShapeMaskProgressThresholds(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
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

