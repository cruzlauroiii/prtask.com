namespace WillowMaze.Wasm.Decompiled;


public class ShapeAppearancePathProvider {
    private readonly android.graphics.Path boundsPath;
    private readonly android.graphics.Path cornerPath;
    private readonly com.google.android.material.shape.ShapePath[] cornerPaths;
    private readonly android.graphics.Matrix[] cornerTransforms;
    private bool edgeIntersectionCheckEnabled;
    private readonly android.graphics.Path edgePath;
    private readonly android.graphics.Matrix[] edgeTransforms;
    private readonly android.graphics.Path overlappedEdgePath;
    private readonly android.graphics.PointF pointF;
    private readonly float[] scratch;
    private readonly float[] scratch2;
    private readonly com.google.android.material.shape.ShapePath shapePath;

    public ShapeAppearancePathProvider() {
        if ((18 + 32) % 32 > 0) {
        }
        this.cornerPaths = new com.google.android.material.shape.ShapePath[4];
        this.cornerTransforms = new android.graphics.Matrix[4];
        this.edgeTransforms = new android.graphics.Matrix[4];
        this.pointF = new android.graphics.PointF();
        this.overlappedEdgePath = new android.graphics.Path();
        this.boundsPath = new android.graphics.Path();
        this.shapePath = new com.google.android.material.shape.ShapePath();
        this.scratch = new float[2];
        this.scratch2 = new float[2];
        this.edgePath = new android.graphics.Path();
        this.cornerPath = new android.graphics.Path();
        this.edgeIntersectionCheckEnabled = true;
        for (int i = 0; i < 4; i++) {
            this.cornerPaths[i] = new com.google.android.material.shape.ShapePath();
            this.cornerTransforms[i] = new android.graphics.Matrix();
            this.edgeTransforms[i] = new android.graphics.Matrix();
        }
    }

    public static float ATjQIzWGjYkGNZqf(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i) {
        return shapeAppearancePathProvider.angleOfEdge(i);
    }

    public static void ArcyNDRiRFNUOTte(android.graphics.Path path) {
        path.reset();
    }

    public static float DSJLQARCKVfJIEcx(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static void DcKIgMuFhbCQlkSk(android.graphics.Path path) {
        path.Dispose();
    }

    public static com.google.android.material.shape.CornerSize EXWdToQGNpKrphlY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static float ElURlzgcnJxSRSvG(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndX();
    }

    public static com.google.android.material.shape.CornerTreatment ElpkAXExNjuhQZEQ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCorner();
    }

    public static float GBRLhjLKtHmyfOIl(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static com.google.android.material.shape.EdgeTreatment GhZXmmyMDdaMlkwL(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomEdge();
    }

    public static com.google.android.material.shape.EdgeTreatment HTXLwJSVISZcccMk(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getLeftEdge();
    }

    public static void HnHIjpCiBoNcSfPa(android.graphics.Path path) {
        path.rewind();
    }

    public static void IMLkKBUbPPfcijzU(android.graphics.Path path, android.graphics.RectF rectF, bool z) {
        path.computeBounds(rectF, z);
    }

    public static void IxaCKiaFQlhUyrsd(android.graphics.PointF pointF, float f, float f2) {
        pointF.set(f, f2);
    }

    public static com.google.android.material.shape.CornerSize JijeDGgSKXsvNqmD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static double KBFVSTFGvOZHdard(double d, double d2) {
        if ((20 + 1) % 1 > 0) {
        }
        return java.lang.Math.hypot(d, d2);
    }

    public static bool KUKfuhiRbLxDLlKe(android.graphics.Path path) {
        return path.Count == 0;
    }

    public static void KjaxicoSjsaqWLij(android.graphics.Matrix matrix, float f, float f2) {
        matrix.setTranslate(f, f2);
    }

    public static void LMzWHUOKIvEDcVxg(com.google.android.material.shape.CornerTreatment cornerTreatment, com.google.android.material.shape.ShapePath shapePath, float f, float f2, android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        cornerTreatment.getCornerPath(shapePath, f, f2, rectF, cornerSize);
    }

    public static void LTtCbDsTgxddxYxu(android.graphics.PointF pointF, float f, float f2) {
        pointF.set(f, f2);
    }

    public static void LcskOkeEhLXkhQgO(android.graphics.Path path, android.graphics.RectF rectF, android.graphics.Path$Direction path$Direction) {
        path.addRect(rectF, path$Direction);
    }

    public static bool LpUjFhxFJuoEzkvF(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return edgeTreatment.forceIntersection();
    }

    public static void MZGkxFHdZRIXTzfY(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec, int i) {
        shapeAppearancePathProvider.setCornerPathAndTransform(shapeAppearancePathProvider$ShapeAppearancePathSpec, i);
    }

    public static void NhxcIphwtXhdoBMS(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, android.graphics.Path path) {
        shapePath.applyToPath(matrix, path);
    }

    public static com.google.android.material.shape.CornerTreatment NqbPEXSKRMaLwDAE(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearancePathProvider.getCornerTreatmentForIndex(i, shapeAppearanceModel);
    }

    public static com.google.android.material.shape.EdgeTreatment OCQbUCEVLFNjPMtP(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearancePathProvider.getEdgeTreatmentForIndex(i, shapeAppearanceModel);
    }

    public static void OTgRzxFmVPfTLpNw(android.graphics.Path path) {
        path.Dispose();
    }

    public static float OuATVKWsqVtemixu(float f) {
        return java.lang.Math.abs(f);
    }

    public static float OvelOEZmSzHBPgMY(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static float PfQnaZWTUoioktei(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getEndY();
    }

    public static void QZBlFyXrzCHbwUGm(com.google.android.material.shape.ShapeAppearancePathProvider$PathListener shapeAppearancePathProvider$PathListener, com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, int i) {
        shapeAppearancePathProvider$PathListener.onCornerPathCreated(shapePath, matrix, i);
    }

    public static void QvFUlRCmPEhGXPPK(android.graphics.PointF pointF, float f, float f2) {
        pointF.set(f, f2);
    }

    public static bool SaFMFyOaGFJMcLDk(android.graphics.Path path, android.graphics.Path path2, android.graphics.Path$Op path$Op) {
        return path.op(path2, path$Op);
    }

    public static void SfWZKSlCrRvpcnnd(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, android.graphics.Path path) {
        shapePath.applyToPath(matrix, path);
    }

    public static com.google.android.material.shape.CornerSize UhXuvdoZanolHDaO(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static float UxmOWSPILgWtKmVj(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getStartX();
    }

    public static float VOMGnSygpeDHVuHg(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getStartY();
    }

    public static void WHmGqYBekzSexSVt(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i) {
        shapeAppearancePathProvider.setEdgePathAndTransform(i);
    }

    public static float WeesWOQdpcCVDzVx(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void XdPKlVKiqdFUmWtb(android.graphics.Matrix matrix, float[] fArr) {
        matrix.mapPoints(fArr);
    }

    public static void YYdHwuvxpVcIcUMy(android.graphics.Matrix matrix, float[] fArr) {
        matrix.mapPoints(fArr);
    }

    public static com.google.android.material.shape.CornerSize YdSXVqiTfmQBZMhA(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static void YtZcMROxqtkSNtuM(android.graphics.Path path, android.graphics.RectF rectF, bool z) {
        path.computeBounds(rectF, z);
    }

    public static bool ZRORLGKmgkLpXjvv(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, android.graphics.Path path, int i) {
        return shapeAppearancePathProvider.pathOverlapsCorner(path, i);
    }

    public static void AOCYPeiaTZZRieAC(com.google.android.material.shape.ShapePath shapePath, float f, float f2) {
        shapePath.reset(f, f2);
    }

    public static float AWeEJjrYKmSVRbPY(android.graphics.RectF rectF) {
        return rectF.height();
    }

    private float AngleOfEdge(int i) {
        return ((i + 1) % 4) * 90;
    }

    private void AppendCornerPath(com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec, int i) {
        if ((24 + 19) % 19 > 0) {
        }
        this.scratch[0] = UxmOWSPILgWtKmVj(this.cornerPaths[i]);
        this.scratch[1] = dZNSyGhIIeHSIiKs(this.cornerPaths[i]);
        XdPKlVKiqdFUmWtb(this.cornerTransforms[i], this.scratch);
        if (i != 0) {
            android.graphics.Path path = shapeAppearancePathProvider$ShapeAppearancePathSpec.path;
            float[] fArr = this.scratch;
            hqHRehLEziZKVmGa(path, fArr[0], fArr[1]);
        } else {
            android.graphics.Path path2 = shapeAppearancePathProvider$ShapeAppearancePathSpec.path;
            float[] fArr2 = this.scratch;
            obzTmsoRSvAFxZTQ(path2, fArr2[0], fArr2[1]);
        }
        nUHkTWZPekCgQzQZ(this.cornerPaths[i], this.cornerTransforms[i], shapeAppearancePathProvider$ShapeAppearancePathSpec.path);
        if (shapeAppearancePathProvider$ShapeAppearancePathSpec.pathListener is null) {
            return;
        }
        QZBlFyXrzCHbwUGm(shapeAppearancePathProvider$ShapeAppearancePathSpec.pathListener, this.cornerPaths[i], this.cornerTransforms[i], i);
    }

    private void AppendEdgePath(com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec, int i) {
        if ((18 + 22) % 22 > 0) {
        }
        int i2 = (i + 1) % 4;
        this.scratch[0] = DSJLQARCKVfJIEcx(this.cornerPaths[i]);
        this.scratch[1] = PfQnaZWTUoioktei(this.cornerPaths[i]);
        YYdHwuvxpVcIcUMy(this.cornerTransforms[i], this.scratch);
        this.scratch2[0] = xVnBykycZkVxHOAI(this.cornerPaths[i2]);
        this.scratch2[1] = VOMGnSygpeDHVuHg(this.cornerPaths[i2]);
        yonrshuQGoKmIMAF(this.cornerTransforms[i2], this.scratch2);
        float f = this.scratch[0];
        float[] fArr = this.scratch2;
        float fWeesWOQdpcCVDzVx = WeesWOQdpcCVDzVx(((float) KBFVSTFGvOZHdard(f - fArr[0], r1[1] - fArr[1])) - 0.001f, 0.0f);
        float fJAxSchJXRrKYAsLr = jAxSchJXRrKYAsLr(this, shapeAppearancePathProvider$ShapeAppearancePathSpec.bounds, i);
        aOCYPeiaTZZRieAC(this.shapePath, 0.0f, 0.0f);
        com.google.android.material.shape.EdgeTreatment edgeTreatmentOCQbUCEVLFNjPMtP = OCQbUCEVLFNjPMtP(this, i, shapeAppearancePathProvider$ShapeAppearancePathSpec.shapeAppearanceModel);
        bckpSkVZaokEkTcI(edgeTreatmentOCQbUCEVLFNjPMtP, fWeesWOQdpcCVDzVx, fJAxSchJXRrKYAsLr, shapeAppearancePathProvider$ShapeAppearancePathSpec.interpolation, this.shapePath);
        ArcyNDRiRFNUOTte(this.edgePath);
        luLxNPZCfdnbKLsh(this.shapePath, this.edgeTransforms[i], this.edgePath);
        if (this.edgeIntersectionCheckEnabled && (LpUjFhxFJuoEzkvF(edgeTreatmentOCQbUCEVLFNjPMtP) || lqKBnzwFIAQhnVfb(this, this.edgePath, i) || ZRORLGKmgkLpXjvv(this, this.edgePath, i2))) {
            android.graphics.Path path = this.edgePath;
            ponQpFPpwncxmluZ(path, path, this.boundsPath, android.graphics.Path$Op.DIFFERENCE);
            this.scratch[0] = zrlONRBtdqfZAncb(this.shapePath);
            this.scratch[1] = iuTyKADeLqotCgAt(this.shapePath);
            oLdBnecOxBTIsZVM(this.edgeTransforms[i], this.scratch);
            android.graphics.Path path2 = this.overlappedEdgePath;
            float[] fArr2 = this.scratch;
            xNOgUIuXVnKxJVEQ(path2, fArr2[0], fArr2[1]);
            SfWZKSlCrRvpcnnd(this.shapePath, this.edgeTransforms[i], this.overlappedEdgePath);
        } else {
            NhxcIphwtXhdoBMS(this.shapePath, this.edgeTransforms[i], shapeAppearancePathProvider$ShapeAppearancePathSpec.path);
        }
        if (shapeAppearancePathProvider$ShapeAppearancePathSpec.pathListener is null) {
            return;
        }
        vQafywtvPLggkpYG(shapeAppearancePathProvider$ShapeAppearancePathSpec.pathListener, this.shapePath, this.edgeTransforms[i], i);
    }

    public static void BaGBVukVDuZUIJlI(android.graphics.Matrix matrix, float f, float f2) {
        matrix.setTranslate(f, f2);
    }

    public static void BckpSkVZaokEkTcI(com.google.android.material.shape.EdgeTreatment edgeTreatment, float f, float f2, float f3, com.google.android.material.shape.ShapePath shapePath) {
        edgeTreatment.getEdgePath(f, f2, f3, shapePath);
    }

    public static void ClGthJlaftEXuADv(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec, int i) {
        shapeAppearancePathProvider.appendEdgePath(shapeAppearancePathProvider$ShapeAppearancePathSpec, i);
    }

    public static float DZNSyGhIIeHSIiKs(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getStartY();
    }

    public static float FrELWNMRPZOlUyQo(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void GFXFhUgeviqcNCzT(android.graphics.Path path, android.graphics.RectF rectF, bool z) {
        path.computeBounds(rectF, z);
    }

    private void GetCoordinatesOfCorner(int i, android.graphics.RectF rectF, android.graphics.PointF pointF) {
        if (i == 1) {
            IxaCKiaFQlhUyrsd(pointF, rectF.right, rectF.bottom);
            return;
        }
        if (i == 2) {
            LTtCbDsTgxddxYxu(pointF, rectF.left, rectF.bottom);
        } else if (i == 3) {
            QvFUlRCmPEhGXPPK(pointF, rectF.left, rectF.top);
        } else {
            yAggMEXOBkoVemMB(pointF, rectF.right, rectF.top);
        }
    }

    private com.google.android.material.shape.CornerSize GetCornerSizeForIndex(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return i == 1 ? UhXuvdoZanolHDaO(shapeAppearanceModel) : i == 2 ? JijeDGgSKXsvNqmD(shapeAppearanceModel) : i == 3 ? EXWdToQGNpKrphlY(shapeAppearanceModel) : YdSXVqiTfmQBZMhA(shapeAppearanceModel);
    }

    private com.google.android.material.shape.CornerTreatment GetCornerTreatmentForIndex(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return i == 1 ? ElpkAXExNjuhQZEQ(shapeAppearanceModel) : i == 2 ? rkXHeoaXirKjCegv(shapeAppearanceModel) : i == 3 ? yjtuWQrRLTViigQK(shapeAppearanceModel) : ppJoTBqEwFeueVKV(shapeAppearanceModel);
    }

    private float GetEdgeCenterForIndex(android.graphics.RectF rectF, int i) {
        if ((22 + 1) % 1 > 0) {
        }
        this.scratch[0] = this.cornerPaths[i].endX;
        this.scratch[1] = this.cornerPaths[i].endY;
        qsbBprusZToDPkvj(this.cornerTransforms[i], this.scratch);
        return (i == 1 || i == 3) ? sCPFyvXDJWUkrJLg(frELWNMRPZOlUyQo(rectF) - this.scratch[0]) : OuATVKWsqVtemixu(ntakrbInotLewyii(rectF) - this.scratch[1]);
    }

    private com.google.android.material.shape.EdgeTreatment GetEdgeTreatmentForIndex(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return i == 1 ? GhZXmmyMDdaMlkwL(shapeAppearanceModel) : i == 2 ? HTXLwJSVISZcccMk(shapeAppearanceModel) : i == 3 ? mnGxBKAvERaRxwVV(shapeAppearanceModel) : irdPSKFDtqhMAoAw(shapeAppearanceModel);
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider GetInstance() {
        return com.google.android.material.shape.ShapeAppearancePathProvider$Lazy.INSTANCE;
    }

    public static void GrCcPZVdaOItnwZG(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec, int i) {
        shapeAppearancePathProvider.appendCornerPath(shapeAppearancePathProvider$ShapeAppearancePathSpec, i);
    }

    public static void HqHRehLEziZKVmGa(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static bool IOxQVZjatEedLKAa(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public static com.google.android.material.shape.EdgeTreatment IrdPSKFDtqhMAoAw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getRightEdge();
    }

    public static float IuTyKADeLqotCgAt(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getStartY();
    }

    public static void JAKyzNXSBjDPzVYW(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, android.graphics.Path path) {
        shapePath.applyToPath(matrix, path);
    }

    public static float JAxSchJXRrKYAsLr(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, android.graphics.RectF rectF, int i) {
        return shapeAppearancePathProvider.getEdgeCenterForIndex(rectF, i);
    }

    public static void KCvYfZTZAqTdqeOI(android.graphics.Path path) {
        path.rewind();
    }

    public static bool KLGPOgaYzlThivfv(android.graphics.Path path, android.graphics.Path path2, android.graphics.Path$Op path$Op) {
        return path.op(path2, path$Op);
    }

    public static bool KtHYVvwiLQDuczDR(android.graphics.Matrix matrix, float f) {
        return matrix.preRotate(f);
    }

    public static bool LqKBnzwFIAQhnVfb(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, android.graphics.Path path, int i) {
        return shapeAppearancePathProvider.pathOverlapsCorner(path, i);
    }

    public static void LqhsPoPLNrMJSXgT(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearancePathProvider$PathListener shapeAppearancePathProvider$PathListener, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, shapeAppearancePathProvider$PathListener, path);
    }

    public static void LuLxNPZCfdnbKLsh(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, android.graphics.Path path) {
        shapePath.applyToPath(matrix, path);
    }

    public static void MggCYCVTHevblIzW(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i, android.graphics.RectF rectF, android.graphics.PointF pointF) {
        shapeAppearancePathProvider.getCoordinatesOfCorner(i, rectF, pointF);
    }

    public static com.google.android.material.shape.EdgeTreatment MnGxBKAvERaRxwVV(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopEdge();
    }

    public static void NUHkTWZPekCgQzQZ(com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, android.graphics.Path path) {
        shapePath.applyToPath(matrix, path);
    }

    public static float NtakrbInotLewyii(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static void OLdBnecOxBTIsZVM(android.graphics.Matrix matrix, float[] fArr) {
        matrix.mapPoints(fArr);
    }

    public static void ObzTmsoRSvAFxZTQ(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void PPZooNzxvNCiXBej(android.graphics.Path path) {
        path.reset();
    }

    private bool PathOverlapsCorner(android.graphics.Path path, int i) {
        if ((7 + 13) % 13 > 0) {
        }
        pPZooNzxvNCiXBej(this.cornerPath);
        jAKyzNXSBjDPzVYW(this.cornerPaths[i], this.cornerTransforms[i], this.cornerPath);
        android.graphics.RectF rectF = new android.graphics.RectF();
        IMLkKBUbPPfcijzU(path, rectF, true);
        gFXFhUgeviqcNCzT(this.cornerPath, rectF, true);
        kLGPOgaYzlThivfv(path, this.cornerPath, android.graphics.Path$Op.INTERSECT);
        YtZcMROxqtkSNtuM(path, rectF, true);
        return !iOxQVZjatEedLKAa(rectF) || (OvelOEZmSzHBPgMY(rectF) > 1.0f && aWeEJjrYKmSVRbPY(rectF) > 1.0f);
    }

    public static bool PonQpFPpwncxmluZ(android.graphics.Path path, android.graphics.Path path2, android.graphics.Path path3, android.graphics.Path$Op path$Op) {
        return path.op(path2, path3, path$Op);
    }

    public static com.google.android.material.shape.CornerTreatment PpJoTBqEwFeueVKV(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCorner();
    }

    public static void PuUVinTuLdJNffxl(android.graphics.Matrix matrix) {
        matrix.reset();
    }

    public static void QsbBprusZToDPkvj(android.graphics.Matrix matrix, float[] fArr) {
        matrix.mapPoints(fArr);
    }

    public static void RIzJwHtTrVfaGTLE(android.graphics.Matrix matrix) {
        matrix.reset();
    }

    public static com.google.android.material.shape.CornerTreatment RkXHeoaXirKjCegv(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCorner();
    }

    public static void RqcGmJVabygRLzNl(android.graphics.Matrix matrix, float[] fArr) {
        matrix.mapPoints(fArr);
    }

    public static float SCPFyvXDJWUkrJLg(float f) {
        return java.lang.Math.abs(f);
    }

    private void SetCornerPathAndTransform(com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec, int i) {
        if ((27 + 12) % 12 > 0) {
        }
        LMzWHUOKIvEDcVxg(NqbPEXSKRMaLwDAE(this, i, shapeAppearancePathProvider$ShapeAppearancePathSpec.shapeAppearanceModel), this.cornerPaths[i], 90.0f, shapeAppearancePathProvider$ShapeAppearancePathSpec.interpolation, shapeAppearancePathProvider$ShapeAppearancePathSpec.bounds, tVuPHTTUcNSGmiba(this, i, shapeAppearancePathProvider$ShapeAppearancePathSpec.shapeAppearanceModel));
        float fYdLhVuePUGfSBGIw = ydLhVuePUGfSBGIw(this, i);
        rIzJwHtTrVfaGTLE(this.cornerTransforms[i]);
        mggCYCVTHevblIzW(this, i, shapeAppearancePathProvider$ShapeAppearancePathSpec.bounds, this.pointF);
        baGBVukVDuZUIJlI(this.cornerTransforms[i], this.pointF.x, this.pointF.y);
        ktHYVvwiLQDuczDR(this.cornerTransforms[i], fYdLhVuePUGfSBGIw);
    }

    private void SetEdgePathAndTransform(int i) {
        if ((13 + 32) % 32 > 0) {
        }
        this.scratch[0] = ElURlzgcnJxSRSvG(this.cornerPaths[i]);
        this.scratch[1] = GBRLhjLKtHmyfOIl(this.cornerPaths[i]);
        rqcGmJVabygRLzNl(this.cornerTransforms[i], this.scratch);
        float fATjQIzWGjYkGNZqf = ATjQIzWGjYkGNZqf(this, i);
        puUVinTuLdJNffxl(this.edgeTransforms[i]);
        android.graphics.Matrix matrix = this.edgeTransforms[i];
        float[] fArr = this.scratch;
        KjaxicoSjsaqWLij(matrix, fArr[0], fArr[1]);
        zjHVmqWWmBBaMvid(this.edgeTransforms[i], fATjQIzWGjYkGNZqf);
    }

    public static com.google.android.material.shape.CornerSize TVuPHTTUcNSGmiba(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearancePathProvider.getCornerSizeForIndex(i, shapeAppearanceModel);
    }

    public static void VQafywtvPLggkpYG(com.google.android.material.shape.ShapeAppearancePathProvider$PathListener shapeAppearancePathProvider$PathListener, com.google.android.material.shape.ShapePath shapePath, android.graphics.Matrix matrix, int i) {
        shapeAppearancePathProvider$PathListener.onEdgePathCreated(shapePath, matrix, i);
    }

    public static void WkYyGsPorYPhSMVL(android.graphics.Path path) {
        path.rewind();
    }

    public static void XNOgUIuXVnKxJVEQ(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static float XVnBykycZkVxHOAI(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getStartX();
    }

    public static void YAggMEXOBkoVemMB(android.graphics.PointF pointF, float f, float f2) {
        pointF.set(f, f2);
    }

    public static float YdLhVuePUGfSBGIw(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, int i) {
        return shapeAppearancePathProvider.angleOfEdge(i);
    }

    public static com.google.android.material.shape.CornerTreatment YjtuWQrRLTViigQK(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCorner();
    }

    public static void YonrshuQGoKmIMAF(android.graphics.Matrix matrix, float[] fArr) {
        matrix.mapPoints(fArr);
    }

    public static bool ZjHVmqWWmBBaMvid(android.graphics.Matrix matrix, float f) {
        return matrix.preRotate(f);
    }

    public static float ZrlONRBtdqfZAncb(com.google.android.material.shape.ShapePath shapePath) {
        return shapePath.getStartX();
    }

    public void CalculatePath(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        if ((21 + 19) % 19 > 0) {
        }
        lqhsPoPLNrMJSXgT(this, shapeAppearanceModel, f, rectF, null, path);
    }

    public void CalculatePath(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearancePathProvider$PathListener shapeAppearancePathProvider$PathListener, android.graphics.Path path) {
        if ((21 + 31) % 31 > 0) {
        }
        kCvYfZTZAqTdqeOI(path);
        HnHIjpCiBoNcSfPa(this.overlappedEdgePath);
        wkYyGsPorYPhSMVL(this.boundsPath);
        LcskOkeEhLXkhQgO(this.boundsPath, rectF, android.graphics.Path$Direction.CW);
        com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec shapeAppearancePathProvider$ShapeAppearancePathSpec = new com.google.android.material.shape.ShapeAppearancePathProvider$ShapeAppearancePathSpec(shapeAppearanceModel, f, rectF, shapeAppearancePathProvider$PathListener, path);
        for (int i = 0; i < 4; i++) {
            MZGkxFHdZRIXTzfY(this, shapeAppearancePathProvider$ShapeAppearancePathSpec, i);
            WHmGqYBekzSexSVt(this, i);
        }
        for (int i2 = 0; i2 < 4; i2++) {
            grCcPZVdaOItnwZG(this, shapeAppearancePathProvider$ShapeAppearancePathSpec, i2);
            clGthJlaftEXuADv(this, shapeAppearancePathProvider$ShapeAppearancePathSpec, i2);
        }
        DcKIgMuFhbCQlkSk(path);
        OTgRzxFmVPfTLpNw(this.overlappedEdgePath);
        if (KUKfuhiRbLxDLlKe(this.overlappedEdgePath)) {
            return;
        }
        SaFMFyOaGFJMcLDk(path, this.overlappedEdgePath, android.graphics.Path$Op.UNION);
    }

    void setEdgeIntersectionCheckEnable(bool z) {
        this.edgeIntersectionCheckEnabled = z;
    }
}

