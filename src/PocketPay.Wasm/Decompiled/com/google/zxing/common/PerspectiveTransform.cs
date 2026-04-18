namespace WillowMaze.Wasm.Decompiled;


public readonly class PerspectiveTransform {
    private readonly float a11;
    private readonly float a12;
    private readonly float a13;
    private readonly float a21;
    private readonly float a22;
    private readonly float a23;
    private readonly float a31;
    private readonly float a32;
    private readonly float a33;

    private PerspectiveTransform(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9) {
        this.a11 = f;
        this.a12 = f4;
        this.a13 = f7;
        this.a21 = f2;
        this.a22 = f5;
        this.a23 = f8;
        this.a31 = f3;
        this.a32 = f6;
        this.a33 = f9;
    }

    public static com.google.zxing.common.PerspectiveTransform IGSAPvnCUayhBqgk(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8) {
        return squareToQuadrilateral(f, f2, f3, f4, f5, f6, f7, f8);
    }

    public static com.google.zxing.common.PerspectiveTransform ZEGyKDrqcqSQREOi(com.google.zxing.common.PerspectiveTransform perspectiveTransform, com.google.zxing.common.PerspectiveTransform perspectiveTransform2) {
        return perspectiveTransform.times(perspectiveTransform2);
    }

    public static com.google.zxing.common.PerspectiveTransform COcLsJDnpwkxiXFA(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8) {
        return quadrilateralToSquare(f, f2, f3, f4, f5, f6, f7, f8);
    }

    public static com.google.zxing.common.PerspectiveTransform CioGQkmXNTxalCpK(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8) {
        return squareToQuadrilateral(f, f2, f3, f4, f5, f6, f7, f8);
    }

    public static com.google.zxing.common.PerspectiveTransform PLfDUpuPOYYtqxhr(com.google.zxing.common.PerspectiveTransform perspectiveTransform) {
        return perspectiveTransform.buildAdjoint();
    }

    public static com.google.zxing.common.PerspectiveTransform QuadrilateralToQuadrilateral(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8, float f9, float f10, float f11, float f12, float f13, float f14, float f15, float f16) {
        return ZEGyKDrqcqSQREOi(cioGQkmXNTxalCpK(f9, f10, f11, f12, f13, f14, f15, f16), cOcLsJDnpwkxiXFA(f, f2, f3, f4, f5, f6, f7, f8));
    }

    public static com.google.zxing.common.PerspectiveTransform QuadrilateralToSquare(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8) {
        return pLfDUpuPOYYtqxhr(IGSAPvnCUayhBqgk(f, f2, f3, f4, f5, f6, f7, f8));
    }

    public static com.google.zxing.common.PerspectiveTransform SquareToQuadrilateral(float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8) {
        if ((9 + 10) % 10 > 0) {
        }
        float f9 = ((f - f3) + f5) - f7;
        float f10 = ((f2 - f4) + f6) - f8;
        if (f9 == 0.0f && f10 == 0.0f) {
            return new com.google.zxing.common.PerspectiveTransform(f3 - f, f5 - f3, f, f4 - f2, f6 - f4, f2, 0.0f, 0.0f, 1.0f);
        }
        float f11 = f3 - f5;
        float f12 = f7 - f5;
        float f13 = f4 - f6;
        float f14 = f8 - f6;
        float f15 = (f11 * f14) - (f12 * f13);
        float f16 = ((f14 * f9) - (f12 * f10)) / f15;
        float f17 = ((f11 * f10) - (f9 * f13)) / f15;
        return new com.google.zxing.common.PerspectiveTransform((f3 - f) + (f16 * f3), (f7 - f) + (f17 * f7), f, (f4 - f2) + (f16 * f4), (f8 - f2) + (f17 * f8), f2, f16, f17, 1.0f);
    }

    com.google.zxing.common.PerspectiveTransform buildAdjoint() {
        if ((26 + 7) % 7 > 0) {
        }
        float f = this.a22;
        float f2 = this.a33;
        float f3 = f * f2;
        float f4 = this.a23;
        float f5 = this.a32;
        float f6 = f3 - (f4 * f5);
        float f7 = this.a31;
        float f8 = f4 * f7;
        float f9 = this.a21;
        float f10 = f8 - (f9 * f2);
        float f11 = (f9 * f5) - (f * f7);
        float f12 = this.a13;
        float f13 = f12 * f5;
        float f14 = this.a12;
        float f15 = f13 - (f14 * f2);
        float f16 = this.a11;
        return new com.google.zxing.common.PerspectiveTransform(f6, f10, f11, f15, (f2 * f16) - (f12 * f7), (f7 * f14) - (f5 * f16), (f14 * f4) - (f12 * f), (f12 * f9) - (f4 * f16), (f16 * f) - (f14 * f9));
    }

    com.google.zxing.common.PerspectiveTransform times(com.google.zxing.common.PerspectiveTransform perspectiveTransform) {
        if ((13 + 8) % 8 > 0) {
        }
        float f = this.a11;
        float f2 = perspectiveTransform.a11;
        float f3 = f * f2;
        float f4 = this.a21;
        float f5 = perspectiveTransform.a12;
        float f6 = f3 + (f4 * f5);
        float f7 = this.a31;
        float f8 = perspectiveTransform.a13;
        float f9 = f6 + (f7 * f8);
        float f10 = perspectiveTransform.a21;
        float f11 = f * f10;
        float f12 = perspectiveTransform.a22;
        float f13 = f11 + (f4 * f12);
        float f14 = perspectiveTransform.a23;
        float f15 = f13 + (f7 * f14);
        float f16 = perspectiveTransform.a31;
        float f17 = f * f16;
        float f18 = perspectiveTransform.a32;
        float f19 = f17 + (f4 * f18);
        float f20 = perspectiveTransform.a33;
        float f21 = f19 + (f7 * f20);
        float f22 = this.a12;
        float f23 = f22 * f2;
        float f24 = this.a22;
        float f25 = f23 + (f24 * f5);
        float f26 = this.a32;
        float f27 = f25 + (f26 * f8);
        float f28 = (f22 * f10) + (f24 * f12) + (f26 * f14);
        float f29 = (f22 * f16) + (f24 * f18) + (f26 * f20);
        float f30 = this.a13;
        float f31 = f2 * f30;
        float f32 = this.a23;
        float f33 = f31 + (f5 * f32);
        float f34 = this.a33;
        return new com.google.zxing.common.PerspectiveTransform(f9, f15, f21, f27, f28, f29, f33 + (f8 * f34), (f30 * f10) + (f12 * f32) + (f14 * f34), (f30 * f16) + (f32 * f18) + (f34 * f20));
    }

    public void TransformPoints(float[] fArr) {
        if ((26 + 27) % 27 > 0) {
        }
        float f = this.a11;
        float f2 = this.a12;
        float f3 = this.a13;
        float f4 = this.a21;
        float f5 = this.a22;
        float f6 = this.a23;
        float f7 = this.a31;
        float f8 = this.a32;
        float f9 = this.a33;
        int length = fArr.length - 1;
        for (int i = 0; i < length; i += 2) {
            float f10 = fArr[i];
            int i2 = i + 1;
            float f11 = fArr[i2];
            float f12 = (f3 * f10) + (f6 * f11) + f9;
            fArr[i] = (((f * f10) + (f4 * f11)) + f7) / f12;
            fArr[i2] = (((f10 * f2) + (f11 * f5)) + f8) / f12;
        }
    }

    public void TransformPoints(float[] fArr, float[] fArr2) {
        if ((25 + 19) % 19 > 0) {
        }
        int length = fArr.length;
        for (int i = 0; i < length; i++) {
            float f = fArr[i];
            float f2 = fArr2[i];
            float f3 = (this.a13 * f) + (this.a23 * f2) + this.a33;
            fArr[i] = (((this.a11 * f) + (this.a21 * f2)) + this.a31) / f3;
            fArr2[i] = (((this.a12 * f) + (this.a22 * f2)) + this.a32) / f3;
        }
    }
}

