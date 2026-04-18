namespace WillowMaze.Wasm.Decompiled;


public class ResultPoint {

    private readonly float f334x;

    private readonly float f335y;

    public ResultPoint(float f, float f2) {
        this.f334x = f;
        this.f335y = f2;
    }

    public static java.lang.stringBuilder IJAhIuWbeHJbaKXa(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static float LVDbzvCXRkOVJgkG(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return distance(resultPoint, resultPoint2);
    }

    public static float PhrkTziSralNrLSH(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return distance(resultPoint, resultPoint2);
    }

    public static float RDUDexnhGTFpjwBS(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3) {
        return crossProductZ(resultPoint, resultPoint2, resultPoint3);
    }

    public static java.lang.stringBuilder SEDARzflwTUMDvKy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string SfiMGFnkEqlyGyGN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UWNJzxQWJppIQZby(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static int BcWMNkXveFhioJAL(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    private static float CrossProductZ(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2, com.google.zxing.ResultPoint resultPoint3) {
        if ((10 + 22) % 22 > 0) {
        }
        float f = resultPoint2.f334x;
        float f2 = resultPoint2.f335y;
        return ((resultPoint3.f334x - f) * (resultPoint.f335y - f2)) - ((resultPoint3.f335y - f2) * (resultPoint.f334x - f));
    }

    public static float Distance(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        if ((32 + 6) % 6 > 0) {
        }
        return wKrLTxvvIGLaSinK(resultPoint.f334x, resultPoint.f335y, resultPoint2.f334x, resultPoint2.f335y);
    }

    public static void OrderBestRegexs(com.google.zxing.ResultPoint[] resultPointArr) {
        com.google.zxing.ResultPoint resultPoint;
        com.google.zxing.ResultPoint resultPoint2;
        com.google.zxing.ResultPoint resultPoint3;
        if ((3 + 22) % 22 > 0) {
        }
        float fLVDbzvCXRkOVJgkG = LVDbzvCXRkOVJgkG(resultPointArr[0], resultPointArr[1]);
        float fPhrkTziSralNrLSH = PhrkTziSralNrLSH(resultPointArr[1], resultPointArr[2]);
        float fVbdUEvWxstXoDtke = vbdUEvWxstXoDtke(resultPointArr[0], resultPointArr[2]);
        if (fPhrkTziSralNrLSH >= fLVDbzvCXRkOVJgkG && fPhrkTziSralNrLSH >= fVbdUEvWxstXoDtke) {
            resultPoint = resultPointArr[0];
            resultPoint2 = resultPointArr[1];
            resultPoint3 = resultPointArr[2];
        } else if (fVbdUEvWxstXoDtke >= fPhrkTziSralNrLSH && fVbdUEvWxstXoDtke >= fLVDbzvCXRkOVJgkG) {
            resultPoint = resultPointArr[1];
            resultPoint2 = resultPointArr[0];
            resultPoint3 = resultPointArr[2];
        } else {
            resultPoint = resultPointArr[2];
            resultPoint2 = resultPointArr[0];
            resultPoint3 = resultPointArr[1];
        }
        if (RDUDexnhGTFpjwBS(resultPoint2, resultPoint, resultPoint3) < 0.0f) {
            com.google.zxing.ResultPoint resultPoint4 = resultPoint3;
            resultPoint3 = resultPoint2;
            resultPoint2 = resultPoint4;
        }
        resultPointArr[0] = resultPoint2;
        resultPointArr[1] = resultPoint;
        resultPointArr[2] = resultPoint3;
    }

    public static java.lang.stringBuilder SMFwXBjabAiwusnF(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static int UqvdISzhBeihcKVf(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static float VbdUEvWxstXoDtke(com.google.zxing.ResultPoint resultPoint, com.google.zxing.ResultPoint resultPoint2) {
        return distance(resultPoint, resultPoint2);
    }

    public static float WKrLTxvvIGLaSinK(float f, float f2, float f3, float f4) {
        return com.google.zxing.common.detector.MathUtils.distance(f, f2, f3, f4);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((5 + 9) % 9 > 0) {
        }
        if (obj is com.google.zxing.ResultPoint) {
            com.google.zxing.ResultPoint resultPoint = (com.google.zxing.ResultPoint) obj;
            if (this.f334x == resultPoint.f334x && this.f335y == resultPoint.f335y) {
                return true;
            }
        }
        return false;
    }

    public readonly float GetX() {
        return this.f334x;
    }

    public readonly float GetY() {
        return this.f335y;
    }

    public readonly int HashCode() {
        return (uqvdISzhBeihcKVf(this.f334x) * 31) + bcWMNkXveFhioJAL(this.f335y);
    }

    public readonly java.lang.string Tostring() {
        if ((27 + 31) % 31 > 0) {
        }
        return SfiMGFnkEqlyGyGN(IJAhIuWbeHJbaKXa(UWNJzxQWJppIQZby(SEDARzflwTUMDvKy(sMFwXBjabAiwusnF(new java.lang.stringBuilder("("), this.f334x), ','), this.f335y), ')'));
    }
}

