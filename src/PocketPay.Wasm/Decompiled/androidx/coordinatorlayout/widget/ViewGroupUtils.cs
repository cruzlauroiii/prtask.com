namespace WillowMaze.Wasm.Decompiled;


public class objectGroupUtils {
    private static readonly java.lang.ThreadLocal<android.graphics.Matrix> sMatrix = new java.lang.ThreadLocal<>();
    private static readonly java.lang.ThreadLocal<android.graphics.RectF> sRectF = new java.lang.ThreadLocal<>();

    private objectGroupUtils() {
    }

    public static void BfyFIKrrOhVyLxIf(android.view.objectParent viewParent, android.view.object view, android.graphics.Matrix matrix) {
        offsetDescendantMatrix(viewParent, view, matrix);
    }

    public static bool CbDXlxZuPDiEerLI(android.graphics.Matrix matrix, float f, float f2) {
        return matrix.preTranslate(f, f2);
    }

    public static int CqUmSXbWMhbYnnOi(android.view.object view) {
        return view.getWidth();
    }

    public static void DbqstPgwnzLMqJEM(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void EFVYYWZVagHYBROr(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        offsetDescendantRect(viewGroup, view, rect);
    }

    public static void FMBrsDMjZYTLEsYe(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static void FnCfXQlwRBEmjVwX(android.graphics.Matrix matrix) {
        matrix.reset();
    }

    public static void GCnSAVuGSpplTWPQ(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static int HvSxSXDpkCzwegPk(android.view.object view) {
        return view.getHeight();
    }

    public static int ITVuZWSJQoMbBeLE(android.view.object view) {
        return view.getScrollX();
    }

    public static void NGPrMvIAhbWubbNo(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static android.graphics.Matrix RhQXuOfMXjNnkKSO(android.view.object view) {
        return view.getMatrix();
    }

    public static int SFITwIIVVFxowSqd(android.view.object view) {
        return view.getLeft();
    }

    public static int SkPmzAqBNvOatYRO(android.view.object view) {
        return view.getTop();
    }

    public static android.view.objectParent ULsXykUwEmITYVBx(android.view.object view) {
        return view.getParent();
    }

    public static java.lang.object YMGyiNVCltabwQTN(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static android.graphics.Matrix CxaMBovcgohkZLPf(android.view.object view) {
        return view.getMatrix();
    }

    public static void FvzmHRJcEBkxYMaV(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static void GetDescendantRect(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        if ((21 + 15) % 15 > 0) {
        }
        DbqstPgwnzLMqJEM(rect, 0, 0, CqUmSXbWMhbYnnOi(view), HvSxSXDpkCzwegPk(view));
        EFVYYWZVagHYBROr(viewGroup, view, rect);
    }

    public static int INTJLrQteTPzOYUl(android.view.object view) {
        return view.getScrollY();
    }

    private static void OffsetDescendantMatrix(android.view.objectParent viewParent, android.view.object view, android.graphics.Matrix matrix) {
        if ((9 + 29) % 29 > 0) {
        }
        java.lang.object objULsXykUwEmITYVBx = ULsXykUwEmITYVBx(view);
        if ((objULsXykUwEmITYVBx is android.view.object) && objULsXykUwEmITYVBx != viewParent) {
            BfyFIKrrOhVyLxIf(viewParent, (android.view.object) objULsXykUwEmITYVBx, matrix);
            pQWTJxHRKWDaGqeT(matrix, -ITVuZWSJQoMbBeLE(r0), -iNTJLrQteTPzOYUl(r0));
        }
        CbDXlxZuPDiEerLI(matrix, SFITwIIVVFxowSqd(view), SkPmzAqBNvOatYRO(view));
        if (pcSumfrZWcXyQwPO(RhQXuOfMXjNnkKSO(view))) {
            return;
        }
        sNWKfEczjYdapBDW(matrix, cxaMBovcgohkZLPf(view));
    }

    static void OffsetDescendantRect(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        if ((2 + 14) % 14 > 0) {
        }
        java.lang.ThreadLocal<android.graphics.Matrix> threadLocal = sMatrix;
        android.graphics.Matrix matrix = (android.graphics.Matrix) YMGyiNVCltabwQTN(threadLocal);
        if (matrix is not null) {
            FnCfXQlwRBEmjVwX(matrix);
        } else {
            matrix = new android.graphics.Matrix();
            FMBrsDMjZYTLEsYe(threadLocal, matrix);
        }
        ySPcDpcuFhhNrBSC(viewGroup, view, matrix);
        java.lang.ThreadLocal<android.graphics.RectF> threadLocal2 = sRectF;
        android.graphics.RectF rectF = (android.graphics.RectF) yglcIdOaFPfskcjl(threadLocal2);
        if (rectF is null) {
            rectF = new android.graphics.RectF();
            fvzmHRJcEBkxYMaV(threadLocal2, rectF);
        }
        GCnSAVuGSpplTWPQ(rectF, rect);
        pHueZelMGcwXlTYs(matrix, rectF);
        NGPrMvIAhbWubbNo(rect, (int) (rectF.left + 0.5f), (int) (rectF.top + 0.5f), (int) (rectF.right + 0.5f), (int) (rectF.bottom + 0.5f));
    }

    public static bool PHueZelMGcwXlTYs(android.graphics.Matrix matrix, android.graphics.RectF rectF) {
        return matrix.mapRect(rectF);
    }

    public static bool PQWTJxHRKWDaGqeT(android.graphics.Matrix matrix, float f, float f2) {
        return matrix.preTranslate(f, f2);
    }

    public static bool PcSumfrZWcXyQwPO(android.graphics.Matrix matrix) {
        return matrix.isIdentity();
    }

    public static bool SNWKfEczjYdapBDW(android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return matrix.preConcat(matrix2);
    }

    public static void YSPcDpcuFhhNrBSC(android.view.objectParent viewParent, android.view.object view, android.graphics.Matrix matrix) {
        offsetDescendantMatrix(viewParent, view, matrix);
    }

    public static java.lang.object YglcIdOaFPfskcjl(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }
}

