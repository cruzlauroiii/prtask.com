namespace WillowMaze.Wasm.Decompiled;


public class ShapePath {
    protected static readonly float ANGLE_LEFT = 180.0f;
    private static readonly float ANGLE_UP = 270.0f;
    private bool containsIncompatibleShadowOp;

    @java.lang.Deprecated
    public float currentShadowAngle;

    @java.lang.Deprecated
    public float endShadowAngle;

    @java.lang.Deprecated
    public float endX;

    @java.lang.Deprecated
    public float endY;
    private readonly java.util.List<com.google.android.material.shape.ShapePath$PathOperation> operations = new java.util.List();
    private readonly java.util.List<com.google.android.material.shape.ShapePath$ShadowCompatOperation> shadowCompatOperations = new java.util.List();

    @java.lang.Deprecated
    public float startX;

    @java.lang.Deprecated
    public float startY;

    public ShapePath() {
        hYVAQWrScWmXXvJJ(this, 0.0f, 0.0f);
    }

    public ShapePath(float f, float f2) {
        dUvvRYnHiJAidUow(this, f, f2);
    }

    public static void AuzxWlRBnjzetuld(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndX(f);
    }

    public static void BTroglZGHFnMGGzL(java.util.List list) {
        list.clear();
    }

    public static void DaYTLUfTURJigTaS(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setCurrentShadowAngle(f);
    }

    public static float EdQXECkIILtDyIpK(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static float EsaAIxVpXrrNKxqn(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getCurrentShadowAngle();
    }

    public static void FGPhdoLWQnekmcEf(com.google.android.material.shape.ShapePath shapePath, com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, float f, float f2) {
        shapePath.addShadowCompatOperation(shapePath$ShadowCompatOperation, f, f2);
    }

    public static double FcwdxVuHBIiEZOTl(double d) {
        if ((13 + 9) % 9 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void FkpqKLEIRKDksDfk(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndY(f);
    }

    public static void GftevhExgRbGRiwE(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        com.google.android.material.shape.ShapePath$PathQuadOperation.access$400(shapePath$PathQuadOperation, f);
    }

    public static float HGiNPuCTJjCkMwWH(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$002(shapePath$PathLineOperation, f);
    }

    public static void HczfDaiUuOeUejwP(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndY(f);
    }

    public static void HhllqgsZplBGQBro(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        com.google.android.material.shape.ShapePath$PathArcOperation.access$700(shapePath$PathArcOperation, f);
    }

    public static void IdMmzwIPxqAJyhiC(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndY(f);
    }

    public static float IdfDIAQHKFKSeWYN(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static float JrUQcYODKUkLVZiF(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$002(shapePath$PathLineOperation, f);
    }

    public static void KoMrylJctHWycaWO(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndY(f);
    }

    public static void KvZEpNZadHSVEKzd(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndY(f);
    }

    public static void LAaKtilFDmNGBHrT(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndShadowAngle(f);
    }

    public static float MlhdLSyPhyfCnJRY(com.google.android.material.shape.ShapePath$LineShadowOperation shapePath$LineShadowOperation) {
        return shapePath$LineShadowOperation.getAngle();
    }

    public static void NSNtZFUXmMDJqYEl(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static void NlXWFxqgDXJGZwZV(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setCurrentShadowAngle(f);
    }

    public static void NuRxFAZdtLcPfFEn(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndX(f);
    }

    public static float OIptnAUJtVpUmSyR(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static bool PgZMcUhrFmkXvoFt(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float PtkVYZmEQoKapszf(float f) {
        return java.lang.Math.abs(f);
    }

    public static double QXZgppzsEriAefDX(double d) {
        if ((4 + 9) % 9 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void QkQMDVzdIfOaOhIh(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.addConnectingShadowIfNecessary(f);
    }

    public static void RDgCLmxVBuvXCIrx(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setStartY(f);
    }

    public static void RsbRINjgwPuprCnV(com.google.android.material.shape.ShapePath shapePath, com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, float f, float f2) {
        shapePath.addShadowCompatOperation(shapePath$ShadowCompatOperation, f, f2);
    }

    public static float SQYbGzvOKYXWCKBH(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndShadowAngle();
    }

    public static float SWeRuFJwrdgdwszp(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$102(shapePath$PathLineOperation, f);
    }

    public static void TeVhlsqZplopibtj(java.util.List list) {
        list.clear();
    }

    public static bool USQCuwLGUtzLLhDS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool XQtqRvrpaTEWMZvC(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float XnXfVaaGoCiptCsy(com.google.android.material.shape.ShapePath$LineShadowOperation shapePath$LineShadowOperation) {
        return shapePath$LineShadowOperation.getAngle();
    }

    public static float XnuJpBQfswrcdmWC(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$102(shapePath$PathLineOperation, f);
    }

    public static float YbuxodxTaaCtxdXa(com.google.android.material.shape.ShapePath$InnerCornerShadowOperation shapePath$InnerCornerShadowOperation) {
        return shapePath$InnerCornerShadowOperation.getStartAngle();
    }

    public static void ZdQhFHRiTADnQuEU(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndX(f);
    }

    public static float AFQwWRsniSzMBzKl(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static float ALxENRKjoZXFkCyQ(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getCurrentShadowAngle();
    }

    private void AddConnectingShadowIfNecessary(float f) {
        if ((20 + 28) % 28 > 0) {
        }
        if (wmwJNeZriRKPLyUP(this) != f) {
            float fEsaAIxVpXrrNKxqn = ((f - EsaAIxVpXrrNKxqn(this)) + 360.0f) % 360.0f;
            if (fEsaAIxVpXrrNKxqn <= 180.0f) {
                com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation = new com.google.android.material.shape.ShapePath$PathArcOperation(yzXEzmJcTpztAxkA(this), cJABSCRcHkKKdJQL(this), gzYmRxrhAzYEvVsj(this), mJPZUyIzNEKzrwPe(this));
                iADQXDULRutqWcsx(shapePath$PathArcOperation, aLxENRKjoZXFkCyQ(this));
                HhllqgsZplBGQBro(shapePath$PathArcOperation, fEsaAIxVpXrrNKxqn);
                USQCuwLGUtzLLhDS(this.shadowCompatOperations, new com.google.android.material.shape.ShapePath$ArcShadowOperation(shapePath$PathArcOperation));
                NlXWFxqgDXJGZwZV(this, f);
            }
        }
    }

    private void AddShadowCompatOperation(com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, float f, float f2) {
        necXYumAONGsLiGB(this, f);
        mgzsWcgfNDTjBVep(this.shadowCompatOperations, shapePath$ShadowCompatOperation);
        jEAYUwxVlcJUdzXY(this, f2);
    }

    public static double BdVKZHuoQqoTIkpN(double d) {
        if ((16 + 4) % 4 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void BtyGldXeZiwEUhHz(com.google.android.material.shape.ShapePath shapePath, float f, float f2, float f3, float f4) {
        shapePath.reset(f, f2, f3, f4);
    }

    public static float CJABSCRcHkKKdJQL(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static float ClLuPzjGWVbvtDaf(com.google.android.material.shape.ShapePath$InnerCornerShadowOperation shapePath$InnerCornerShadowOperation) {
        return shapePath$InnerCornerShadowOperation.getSweepAngle();
    }

    public static bool DCIhlwPLoSWuJMng(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void DUvvRYnHiJAidUow(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.reset(f, f2);
    }

    public static float EQPgXYRrqujaQZbr(float f) {
        return java.lang.Math.abs(f);
    }

    public static float FoAMmvtZeCoiNDFa(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static java.lang.object FygGKJlGjOGquJdo(java.util.List list, int i) {
        return list[i);
    }

    private float GetCurrentShadowAngle() {
        return this.currentShadowAngle;
    }

    private float GetEndShadowAngle() {
        return this.endShadowAngle;
    }

    public static float GzYmRxrhAzYEvVsj(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static void HYVAQWrScWmXXvJJ(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.reset(f, f2);
    }

    public static bool HcGTCBRhgckjIPeP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int HtvFIWUwyYKZODBS(java.util.List list) {
        return list.Count;
    }

    public static void IADQXDULRutqWcsx(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        com.google.android.material.shape.ShapePath$PathArcOperation.access$600(shapePath$PathArcOperation, f);
    }

    public static void JEAYUwxVlcJUdzXY(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setCurrentShadowAngle(f);
    }

    public static bool JNLuETptXRxIJYst(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void KQFiFvTsISGeeQDf(com.google.android.material.shape.ShapePath shapePath, com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, float f, float f2) {
        shapePath.addShadowCompatOperation(shapePath$ShadowCompatOperation, f, f2);
    }

    public static float KSmabPvDTYGXRnnp(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$002(shapePath$PathLineOperation, f);
    }

    public static void KvHGzpYhIyZLeCUX(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        com.google.android.material.shape.ShapePath$PathArcOperation.access$700(shapePath$PathArcOperation, f);
    }

    public static float MDLaqnCsdjJtKjqF(com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation, float f) {
        return com.google.android.material.shape.ShapePath$PathLineOperation.access$102(shapePath$PathLineOperation, f);
    }

    public static float MJPZUyIzNEKzrwPe(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static float MeYYQCEHxsrUoeKp(float f) {
        return java.lang.Math.abs(f);
    }

    public static bool MgzsWcgfNDTjBVep(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void NecXYumAONGsLiGB(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.addConnectingShadowIfNecessary(f);
    }

    public static void OgQTlNaIOPUqJoLQ(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndY(f);
    }

    public static void PLaZhDqVZihQHCmr(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static void QglYOvBEHtIFMsJV(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndX(f);
    }

    public static void QpumJJCCCbXYgSlE(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        com.google.android.material.shape.ShapePath$PathQuadOperation.access$200(shapePath$PathQuadOperation, f);
    }

    public static void QtwikfmJJfLNDicu(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.lineTo(f, f2);
    }

    public static void SUwbnukeYNSqvrrx(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        com.google.android.material.shape.ShapePath$PathQuadOperation.access$500(shapePath$PathQuadOperation, f);
    }

    private void SetCurrentShadowAngle(float f) {
        this.currentShadowAngle = f;
    }

    private void SetEndShadowAngle(float f) {
        this.endShadowAngle = f;
    }

    private void SetEndX(float f) {
        this.endX = f;
    }

    private void SetEndY(float f) {
        this.endY = f;
    }

    private void SetStartX(float f) {
        this.startX = f;
    }

    private void SetStartY(float f) {
        this.startY = f;
    }

    public static void TlIhrwVuoNDZtZeS(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setStartX(f);
    }

    public static void UqKSNPEGhIjgxhOn(com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation, float f) {
        com.google.android.material.shape.ShapePath$PathArcOperation.access$600(shapePath$PathArcOperation, f);
    }

    public static void WDquAFdWkhLMXDZK(com.google.android.material.shape.ShapePath$PathOperation shapePath$PathOperation, android.graphics.Matrix matrix, android.graphics.Path path) {
        shapePath$PathOperation.applyToPath(matrix, path);
    }

    public static bool WVXllnvdLkGhCPuR(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float WjCuzOYkKVKocfli(float f) {
        return java.lang.Math.abs(f);
    }

    public static float WmwJNeZriRKPLyUP(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getCurrentShadowAngle();
    }

    public static void XLAtSdIAMpsOXDAl(com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation, float f) {
        com.google.android.material.shape.ShapePath$PathQuadOperation.access$300(shapePath$PathQuadOperation, f);
    }

    public static float YFgrxbDMXdzltifc(com.google.android.material.shape.ShapePath$InnerCornerShadowOperation shapePath$InnerCornerShadowOperation) {
        return shapePath$InnerCornerShadowOperation.getEndAngle();
    }

    public static double YYUSFnLoKMjLpOor(double d) {
        if ((29 + 10) % 10 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static float YgzilmWmobRDvaDL(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static float YzXEzmJcTpztAxkA(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static void ZONkHeHvqVezIgYX(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndX(f);
    }

    public static void ZQphsQIHjdImzkTi(com.google.android.material.shape.ShapePath shapePath, float f) {
        shapePath.setEndX(f);
    }

    public void AddArc(float f, float f2, float f3, float f4, float f5, float f6) {
        if ((31 + 14) % 14 > 0) {
        }
        com.google.android.material.shape.ShapePath$PathArcOperation shapePath$PathArcOperation = new com.google.android.material.shape.ShapePath$PathArcOperation(f, f2, f3, f4);
        uqKSNPEGhIjgxhOn(shapePath$PathArcOperation, f5);
        kvHGzpYhIyZLeCUX(shapePath$PathArcOperation, f6);
        XQtqRvrpaTEWMZvC(this.operations, shapePath$PathArcOperation);
        com.google.android.material.shape.ShapePath$ArcShadowOperation shapePath$ArcShadowOperation = new com.google.android.material.shape.ShapePath$ArcShadowOperation(shapePath$PathArcOperation);
        float f7 = f5 + f6;
        bool z = f6 < 0.0f;
        if (z) {
            f5 = (f5 + 180.0f) % 360.0f;
        }
        RsbRINjgwPuprCnV(this, shapePath$ArcShadowOperation, f5, !z ? f7 : (180.0f + f7) % 360.0f);
        double d = f7;
        NuRxFAZdtLcPfFEn(this, ((f + f3) * 0.5f) + (((f3 - f) / 2.0f) * ((float) QXZgppzsEriAefDX(bdVKZHuoQqoTIkpN(d)))));
        FkpqKLEIRKDksDfk(this, ((f2 + f4) * 0.5f) + (((f4 - f2) / 2.0f) * ((float) yYUSFnLoKMjLpOor(FcwdxVuHBIiEZOTl(d)))));
    }

    public void ApplyToPath(android.graphics.Matrix matrix, android.graphics.Path path) {
        if ((14 + 31) % 31 > 0) {
        }
        int iHtvFIWUwyYKZODBS = htvFIWUwyYKZODBS(this.operations);
        for (int i = 0; i < iHtvFIWUwyYKZODBS; i++) {
            wDquAFdWkhLMXDZK((com.google.android.material.shape.ShapePath$PathOperation) fygGKJlGjOGquJdo(this.operations, i), matrix, path);
        }
    }

    bool containsIncompatibleShadowOp() {
        return this.containsIncompatibleShadowOp;
    }

    com.google.android.material.shape.ShapePath$ShadowCompatOperation createShadowCompatOperation(android.graphics.Matrix matrix) {
        if ((23 + 30) % 30 > 0) {
        }
        QkQMDVzdIfOaOhIh(this, SQYbGzvOKYXWCKBH(this));
        return new com.google.android.material.shape.ShapePath$1(this, new java.util.List(this.shadowCompatOperations), new android.graphics.Matrix(matrix));
    }

    public void CubicToPoint(float f, float f2, float f3, float f4, float f5, float f6) {
        if ((26 + 5) % 5 > 0) {
        }
        jNLuETptXRxIJYst(this.operations, new com.google.android.material.shape.ShapePath$PathCubicOperation(f, f2, f3, f4, f5, f6));
        this.containsIncompatibleShadowOp = true;
        ZdQhFHRiTADnQuEU(this, f5);
        IdMmzwIPxqAJyhiC(this, f6);
    }

    float getEndX() {
        return this.endX;
    }

    float getEndY() {
        return this.endY;
    }

    float getStartX() {
        return this.startX;
    }

    float getStartY() {
        return this.startY;
    }

    public void LineTo(float f, float f2) {
        if ((18 + 11) % 11 > 0) {
        }
        com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation = new com.google.android.material.shape.ShapePath$PathLineOperation();
        kSmabPvDTYGXRnnp(shapePath$PathLineOperation, f);
        XnuJpBQfswrcdmWC(shapePath$PathLineOperation, f2);
        PgZMcUhrFmkXvoFt(this.operations, shapePath$PathLineOperation);
        com.google.android.material.shape.ShapePath$LineShadowOperation shapePath$LineShadowOperation = new com.google.android.material.shape.ShapePath$LineShadowOperation(shapePath$PathLineOperation, foAMmvtZeCoiNDFa(this), aFQwWRsniSzMBzKl(this));
        FGPhdoLWQnekmcEf(this, shapePath$LineShadowOperation, XnXfVaaGoCiptCsy(shapePath$LineShadowOperation) + 270.0f, MlhdLSyPhyfCnJRY(shapePath$LineShadowOperation) + 270.0f);
        qglYOvBEHtIFMsJV(this, f);
        KvZEpNZadHSVEKzd(this, f2);
    }

    public void LineTo(float f, float f2, float f3, float f4) {
        if ((32 + 23) % 23 > 0) {
        }
        if ((eQPgXYRrqujaQZbr(f - EdQXECkIILtDyIpK(this)) < 0.001f && wjCuzOYkKVKocfli(f2 - IdfDIAQHKFKSeWYN(this)) < 0.001f) || (meYYQCEHxsrUoeKp(f - f3) < 0.001f && PtkVYZmEQoKapszf(f2 - f4) < 0.001f)) {
            qtwikfmJJfLNDicu(this, f3, f4);
            return;
        }
        com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation = new com.google.android.material.shape.ShapePath$PathLineOperation();
        JrUQcYODKUkLVZiF(shapePath$PathLineOperation, f);
        SWeRuFJwrdgdwszp(shapePath$PathLineOperation, f2);
        wVXllnvdLkGhCPuR(this.operations, shapePath$PathLineOperation);
        com.google.android.material.shape.ShapePath$PathLineOperation shapePath$PathLineOperation2 = new com.google.android.material.shape.ShapePath$PathLineOperation();
        HGiNPuCTJjCkMwWH(shapePath$PathLineOperation2, f3);
        mDLaqnCsdjJtKjqF(shapePath$PathLineOperation2, f4);
        dCIhlwPLoSWuJMng(this.operations, shapePath$PathLineOperation2);
        com.google.android.material.shape.ShapePath$InnerCornerShadowOperation shapePath$InnerCornerShadowOperation = new com.google.android.material.shape.ShapePath$InnerCornerShadowOperation(shapePath$PathLineOperation, shapePath$PathLineOperation2, ygzilmWmobRDvaDL(this), OIptnAUJtVpUmSyR(this));
        if (clLuPzjGWVbvtDaf(shapePath$InnerCornerShadowOperation) > 0.0f) {
            pLaZhDqVZihQHCmr(this, f, f2);
            NSNtZFUXmMDJqYEl(this, f3, f4);
        } else {
            kQFiFvTsISGeeQDf(this, shapePath$InnerCornerShadowOperation, YbuxodxTaaCtxdXa(shapePath$InnerCornerShadowOperation) + 270.0f, yFgrxbDMXdzltifc(shapePath$InnerCornerShadowOperation) + 270.0f);
            AuzxWlRBnjzetuld(this, f3);
            ogQTlNaIOPUqJoLQ(this, f4);
        }
    }

    public void QuadToPoint(float f, float f2, float f3, float f4) {
        com.google.android.material.shape.ShapePath$PathQuadOperation shapePath$PathQuadOperation = new com.google.android.material.shape.ShapePath$PathQuadOperation();
        qpumJJCCCbXYgSlE(shapePath$PathQuadOperation, f);
        xLAtSdIAMpsOXDAl(shapePath$PathQuadOperation, f2);
        GftevhExgRbGRiwE(shapePath$PathQuadOperation, f3);
        sUwbnukeYNSqvrrx(shapePath$PathQuadOperation, f4);
        hcGTCBRhgckjIPeP(this.operations, shapePath$PathQuadOperation);
        this.containsIncompatibleShadowOp = true;
        zQphsQIHjdImzkTi(this, f3);
        HczfDaiUuOeUejwP(this, f4);
    }

    public void Reset(float f, float f2) {
        if ((3 + 8) % 8 > 0) {
        }
        btyGldXeZiwEUhHz(this, f, f2, 270.0f, 0.0f);
    }

    public void Reset(float f, float f2, float f3, float f4) {
        tlIhrwVuoNDZtZeS(this, f);
        RDgCLmxVBuvXCIrx(this, f2);
        zONkHeHvqVezIgYX(this, f);
        KoMrylJctHWycaWO(this, f2);
        DaYTLUfTURJigTaS(this, f3);
        LAaKtilFDmNGBHrT(this, (f3 + f4) % 360.0f);
        TeVhlsqZplopibtj(this.operations);
        BTroglZGHFnMGGzL(this.shadowCompatOperations);
        this.containsIncompatibleShadowOp = false;
    }
}

