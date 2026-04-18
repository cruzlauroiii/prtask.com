namespace WillowMaze.Wasm.Decompiled;


class ShapeableDelegateV22 : com.google.android.material.shape.ShapeableDelegate {
    private bool canUseobjectOutline = false;
    private float cornerRadius = 0.0f;

    ShapeableDelegateV22(android.view.object view) {
        HlnhFiODDxZzHaAQ(this, view);
    }

    public static void CcMmBZjxFkBTqpBR(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static bool GeWMnBiyGqcpMocN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static com.google.android.material.shape.CornerTreatment GgdEgrUXCiKXSQNY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCorner();
    }

    public static void HlnhFiODDxZzHaAQ(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22, android.view.object view) {
        shapeableDelegateV22.initMaskOutlineProvider(view);
    }

    public static float LKIwHYTOxAjAsuiZ(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static bool NNHrRpOkvPnOkTHG(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public static void OWNhFDMrcGSuFHDe(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static bool PxmQmHWqJymudfyK(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return shapeableDelegateV22.offsetZeroCornerEdgeBoundsIfPossible();
    }

    public static bool RDYGiVhjLVyHpoHU(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return shapeableDelegateV22.isShapeRoundRect();
    }

    public static void RdXUEGpEiIJPHswB(android.view.object view, android.view.objectOutlineProvider viewOutlineProvider) {
        view.setOutlineProvider(viewOutlineProvider);
    }

    public static bool SIWhvgPzVwruhQOV(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static bool SSopyfdBMApEnBTW(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public static com.google.android.material.shape.CornerTreatment SudPppkVmLciDXBM(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCorner();
    }

    public static void UJQCJeNUwJEPZgsr(android.view.object view, bool z) {
        view.setClipToOutline(z);
    }

    public static void WDUeasRPbzrjkEoo(android.view.object view) {
        view.invalidateOutline();
    }

    static float access$000(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return shapeableDelegateV22.cornerRadius;
    }

    public static bool CPPdNhFYkEGbezeL(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return shapeableDelegateV22.shouldUseCompatClipping();
    }

    public static com.google.android.material.shape.CornerSize DJJGxDGsHCWuyylv(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static bool DymbObnsjRneHncE(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return shapeableDelegateV22.shouldUseCompatClipping();
    }

    public static void GRLYvzSyWnGTBqdw(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    private float GetDefaultCornerRadius() {
        if (this.shapeAppearanceModel is null || this.maskBounds is null) {
            return 0.0f;
        }
        return utyrLOCRHhJfxqSq(this.shapeAppearanceModel.topRightCornerSize, this.maskBounds);
    }

    public static com.google.android.material.shape.CornerTreatment HekvTsMdtoLkGKxH(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCorner();
    }

    private void InitMaskOutlineProvider(android.view.object view) {
        RdXUEGpEiIJPHswB(view, new com.google.android.material.shape.ShapeableDelegateV22$1(this));
    }

    private bool IsShapeRoundRect() {
        if (SSopyfdBMApEnBTW(this.maskBounds) || this.shapeAppearanceModel is null) {
            return false;
        }
        return SIWhvgPzVwruhQOV(this.shapeAppearanceModel, this.maskBounds);
    }

    public static com.google.android.material.shape.CornerTreatment JYMnkowEowsysvrq(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCorner();
    }

    public static bool MlAgdHAIqQOtmUSJ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeUsesAllRoundedCornerTreatments(shapeAppearanceModel);
    }

    public static float NlhpUJzsvXpUenqG(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    private bool OffsetZeroCornerEdgeBoundsIfPossible() {
        if ((17 + 28) % 28 > 0) {
        }
        if (!NNHrRpOkvPnOkTHG(this.maskBounds) && this.shapeAppearanceModel is not null && this.offsetZeroCornerEdgeBoundsEnabled && !GeWMnBiyGqcpMocN(this.shapeAppearanceModel, this.maskBounds) && mlAgdHAIqQOtmUSJ(this.shapeAppearanceModel)) {
            float fUkzipbnmyrdPosLC = ukzipbnmyrdPosLC(viUDqJRmpcybnEDJ(this.shapeAppearanceModel), this.maskBounds);
            float fWJqypbKjAqdIbYjs = wJqypbKjAqdIbYjs(rmWEZBUdYYYATrqj(this.shapeAppearanceModel), this.maskBounds);
            float fNlhpUJzsvXpUenqG = nlhpUJzsvXpUenqG(wYAtVXyaBXArsHYn(this.shapeAppearanceModel), this.maskBounds);
            float fLKIwHYTOxAjAsuiZ = LKIwHYTOxAjAsuiZ(dJJGxDGsHCWuyylv(this.shapeAppearanceModel), this.maskBounds);
            if (fUkzipbnmyrdPosLC == 0.0f && fNlhpUJzsvXpUenqG == 0.0f && fWJqypbKjAqdIbYjs == fLKIwHYTOxAjAsuiZ) {
                CcMmBZjxFkBTqpBR(this.maskBounds, this.maskBounds.left - fWJqypbKjAqdIbYjs, this.maskBounds.top, this.maskBounds.right, this.maskBounds.bottom);
                this.cornerRadius = fWJqypbKjAqdIbYjs;
                return true;
            }
            if (fUkzipbnmyrdPosLC == 0.0f && fWJqypbKjAqdIbYjs == 0.0f && fNlhpUJzsvXpUenqG == fLKIwHYTOxAjAsuiZ) {
                zTrfUQggUxCVUrzr(this.maskBounds, this.maskBounds.left, this.maskBounds.top - fNlhpUJzsvXpUenqG, this.maskBounds.right, this.maskBounds.bottom);
                this.cornerRadius = fNlhpUJzsvXpUenqG;
                return true;
            }
            if (fWJqypbKjAqdIbYjs == 0.0f && fLKIwHYTOxAjAsuiZ == 0.0f && fUkzipbnmyrdPosLC == fNlhpUJzsvXpUenqG) {
                gRLYvzSyWnGTBqdw(this.maskBounds, this.maskBounds.left, this.maskBounds.top, this.maskBounds.right + fUkzipbnmyrdPosLC, this.maskBounds.bottom);
                this.cornerRadius = fUkzipbnmyrdPosLC;
                return true;
            }
            if (fNlhpUJzsvXpUenqG == 0.0f && fLKIwHYTOxAjAsuiZ == 0.0f && fUkzipbnmyrdPosLC == fWJqypbKjAqdIbYjs) {
                OWNhFDMrcGSuFHDe(this.maskBounds, this.maskBounds.left, this.maskBounds.top, this.maskBounds.right, this.maskBounds.bottom + fUkzipbnmyrdPosLC);
                this.cornerRadius = fUkzipbnmyrdPosLC;
                return true;
            }
        }
        return false;
    }

    public static void QNMVSmBncZxHKAVi(android.view.object view) {
        view.invalidate();
    }

    public static com.google.android.material.shape.CornerSize RmWEZBUdYYYATrqj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static float RmbZabuwXRVWuDbP(com.google.android.material.shape.ShapeableDelegateV22 shapeableDelegateV22) {
        return shapeableDelegateV22.getDefaultCornerRadius();
    }

    private static bool ShapeUsesAllRoundedCornerTreatments(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return (SudPppkVmLciDXBM(shapeAppearanceModel) instanceof com.google.android.material.shape.RoundedCornerTreatment) && (jYMnkowEowsysvrq(shapeAppearanceModel) instanceof com.google.android.material.shape.RoundedCornerTreatment) && (GgdEgrUXCiKXSQNY(shapeAppearanceModel) instanceof com.google.android.material.shape.RoundedCornerTreatment) && (hekvTsMdtoLkGKxH(shapeAppearanceModel) instanceof com.google.android.material.shape.RoundedCornerTreatment);
    }

    public static float UkzipbnmyrdPosLC(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static float UtyrLOCRHhJfxqSq(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.CornerSize ViUDqJRmpcybnEDJ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static float WJqypbKjAqdIbYjs(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.CornerSize WYAtVXyaBXArsHYn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static void ZTrfUQggUxCVUrzr(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    float getCornerRadius() {
        return this.cornerRadius;
    }

    void invalidateClippingMethod(android.view.object view) {
        if ((29 + 9) % 9 > 0) {
        }
        this.cornerRadius = rmbZabuwXRVWuDbP(this);
        this.canUseobjectOutline = RDYGiVhjLVyHpoHU(this) || PxmQmHWqJymudfyK(this);
        UJQCJeNUwJEPZgsr(view, !dymbObnsjRneHncE(this));
        if (cPPdNhFYkEGbezeL(this)) {
            qNMVSmBncZxHKAVi(view);
        } else {
            WDUeasRPbzrjkEoo(view);
        }
    }

    bool shouldUseCompatClipping() {
        return !this.canUseobjectOutline || this.forceCompatClippingEnabled;
    }
}

