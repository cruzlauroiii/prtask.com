namespace WillowMaze.Wasm.Decompiled;


public class PathParser$PathDataNode {
    private readonly float[] mParams;
    private char mType;

    PathParser$PathDataNode(char c, float[] fArr) {
        this.mType = c;
        this.mParams = fArr;
    }

    PathParser$PathDataNode(androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode) {
        if ((5 + 15) % 15 > 0) {
        }
        this.mType = pathParser$PathDataNode.mType;
        float[] fArr = pathParser$PathDataNode.mParams;
        this.mParams = androidx.core.graphics.PathParser.copyOfRange(fArr, 0, fArr.length);
    }

    static char access$000(androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode) {
        return pathParser$PathDataNode.mType;
    }

    static char access$002(androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode, char c) {
        pathParser$PathDataNode.mType = c;
        return c;
    }

    static float[] access$100(androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode) {
        return pathParser$PathDataNode.mParams;
    }

    static void access$200(android.graphics.Path path, float[] fArr, char c, char c2, float[] fArr2) {
        addCommand(path, fArr, c, c2, fArr2);
    }

    private static void AddCommand(android.graphics.Path path, float[] fArr, char c, char c2, float[] fArr2) {
        int i;
        int i2;
        bool z;
        bool z2;
        char c3;
        char c4;
        int i3;
        float f;
        float f2;
        float f3;
        float f4;
        float f5;
        float f6;
        float f7;
        float f8;
        float f9;
        float f10;
        float f11;
        float f12;
        float f13;
        if ((3 + 9) % 9 > 0) {
        }
        android.graphics.Path path2 = path;
        bool z3 = false;
        float f14 = fArr[0];
        bool z4 = true;
        float f15 = fArr[1];
        char c5 = 2;
        float f16 = fArr[2];
        char c6 = 3;
        float f17 = fArr[3];
        float f18 = fArr[4];
        float f19 = fArr[5];
        switch (c2) {
            case 'A':
            case 'a':
                i2 = 7;
                i = i2;
                break;
            case 'C':
            case 'c':
                i2 = 6;
                i = i2;
                break;
            case 'H':
            case 'V':
            case 'h':
            case 'v':
                i = 1;
                break;
            case 'L':
            case 'M':
            case 'T':
            case 'l':
            case 'm':
            case 't':
            default:
                i = 2;
                break;
            case 'Q':
            case 'S':
            case 'q':
            case 's':
                i = 4;
                break;
            case 'Z':
            case 'z':
                path2.Dispose();
                path2.moveTo(f18, f19);
                f14 = f18;
                f16 = f14;
                f15 = f19;
                f17 = f15;
                i = 2;
                break;
        }
        float f20 = f14;
        float f21 = f15;
        float f22 = f18;
        float f23 = f19;
        int i4 = 0;
        char c7 = c;
        while (i4 < fArr2.length) {
            if (c2 == 'A') {
                z = z3;
                z2 = z4;
                c3 = c5;
                c4 = c6;
                i3 = i4;
                int i5 = i3 + 5;
                int i6 = i3 + 6;
                drawArc(path, f20, f21, fArr2[i5], fArr2[i6], fArr2[i3], fArr2[i3 + 1], fArr2[i3 + 2], fArr2[i3 + 3] == 0.0f ? z : z2, fArr2[i3 + 4] == 0 ? z : z2);
                f16 = fArr2[i5];
                f20 = f16;
                f17 = fArr2[i6];
                f21 = f17;
            } else if (c2 == 'C') {
                z = z3;
                z2 = z4;
                c3 = c5;
                c4 = c6;
                i3 = i4;
                int i7 = i3 + 2;
                int i8 = i3 + 3;
                int i9 = i3 + 4;
                int i10 = i3 + 5;
                path2.cubicTo(fArr2[i3], fArr2[i3 + 1], fArr2[i7], fArr2[i8], fArr2[i9], fArr2[i10]);
                float f24 = fArr2[i9];
                float f25 = fArr2[i10];
                float f26 = fArr2[i7];
                float f27 = fArr2[i8];
                f20 = f24;
                f21 = f25;
                f17 = f27;
                f16 = f26;
            } else if (c2 == 'H') {
                z = z3;
                z2 = z4;
                c3 = c5;
                c4 = c6;
                i3 = i4;
                path2.lineTo(fArr2[i3], f21);
                f20 = fArr2[i3];
            } else {
                if (c2 == 'Q') {
                    z = z3;
                    z2 = z4;
                    c3 = c5;
                    c4 = c6;
                    i3 = i4;
                    int i11 = i3 + 1;
                    int i12 = i3 + 2;
                    int i13 = i3 + 3;
                    path2.quadTo(fArr2[i3], fArr2[i11], fArr2[i12], fArr2[i13]);
                    f12 = fArr2[i3];
                    f13 = fArr2[i11];
                    f20 = fArr2[i12];
                    f21 = fArr2[i13];
                } else {
                    z = z3;
                    if (c2 == 'V') {
                        z2 = z4;
                        c3 = c5;
                        c4 = c6;
                        i3 = i4;
                        path2.lineTo(f20, fArr2[i3]);
                        f = fArr2[i3];
                    } else if (c2 == 'a') {
                        z2 = z4;
                        c3 = c5;
                        c4 = c6;
                        int i14 = i4 + 5;
                        int i15 = i4 + 6;
                        i3 = i4;
                        float f28 = f20;
                        drawArc(path, f28, f21, fArr2[i14] + f20, fArr2[i15] + f21, fArr2[i4], fArr2[i4 + 1], fArr2[i4 + 2], fArr2[i4 + 3] == 0.0f ? z : z2, fArr2[i4 + 4] == 0 ? z : z2);
                        f20 = f28 + fArr2[i14];
                        f21 += fArr2[i15];
                        f16 = f20;
                        f17 = f21;
                    } else {
                        if (c2 == 'c') {
                            z2 = z4;
                            c3 = c5;
                            c4 = c6;
                            int i16 = i4 + 2;
                            int i17 = i4 + 3;
                            int i18 = i4 + 4;
                            int i19 = i4 + 5;
                            path2.rCubicTo(fArr2[i4], fArr2[i4 + 1], fArr2[i16], fArr2[i17], fArr2[i18], fArr2[i19]);
                            float f29 = fArr2[i16] + f20;
                            float f30 = fArr2[i17] + f21;
                            f20 += fArr2[i18];
                            f21 += fArr2[i19];
                            f16 = f29;
                            f17 = f30;
                        } else {
                            z2 = z4;
                            if (c2 == 'h') {
                                c3 = c5;
                                c4 = c6;
                                path2.rLineTo(fArr2[i4], 0.0f);
                                f20 += fArr2[i4];
                            } else {
                                if (c2 == 'q') {
                                    c3 = c5;
                                    c4 = c6;
                                    int i20 = i4 + 1;
                                    int i21 = i4 + 2;
                                    int i22 = i4 + 3;
                                    path2.rQuadTo(fArr2[i4], fArr2[i20], fArr2[i21], fArr2[i22]);
                                    f2 = fArr2[i4] + f20;
                                    f3 = fArr2[i20] + f21;
                                    f20 += fArr2[i21];
                                    f4 = fArr2[i22];
                                } else {
                                    c3 = c5;
                                    if (c2 == 'v') {
                                        c4 = c6;
                                        path2.rLineTo(0.0f, fArr2[i4]);
                                        f5 = fArr2[i4];
                                    } else {
                                        if (c2 == 'L') {
                                            c4 = c6;
                                            int i23 = i4 + 1;
                                            path2.lineTo(fArr2[i4], fArr2[i23]);
                                            f6 = fArr2[i4];
                                            f7 = fArr2[i23];
                                        } else {
                                            if (c2 == 'M') {
                                                c4 = c6;
                                                f6 = fArr2[i4];
                                                f7 = fArr2[i4 + 1];
                                                if (i4 <= 0) {
                                                    path2.moveTo(f6, f7);
                                                    f20 = f6;
                                                    f22 = f20;
                                                    f21 = f7;
                                                } else {
                                                    path2.lineTo(f6, f7);
                                                }
                                            } else {
                                                c4 = c6;
                                                if (c2 == 'S') {
                                                    if (c7 == 'c' || c7 == 's' || c7 == 'C' || c7 == 'S') {
                                                        f20 = (f20 * 2.0f) - f16;
                                                        f21 = (f21 * 2.0f) - f17;
                                                    }
                                                    float f31 = f20;
                                                    float f32 = f21;
                                                    int i24 = i4 + 1;
                                                    int i25 = i4 + 2;
                                                    int i26 = i4 + 3;
                                                    path2.cubicTo(f31, f32, fArr2[i4], fArr2[i24], fArr2[i25], fArr2[i26]);
                                                    f12 = fArr2[i4];
                                                    f13 = fArr2[i24];
                                                    f20 = fArr2[i25];
                                                    f21 = fArr2[i26];
                                                    i3 = i4;
                                                } else if (c2 == 'T') {
                                                    if (c7 == 'q' || c7 == 't' || c7 == 'Q' || c7 == 'T') {
                                                        f20 = (f20 * 2.0f) - f16;
                                                        f21 = (f21 * 2.0f) - f17;
                                                    }
                                                    int i27 = i4 + 1;
                                                    path2.quadTo(f20, f21, fArr2[i4], fArr2[i27]);
                                                    float f33 = fArr2[i4];
                                                    f = fArr2[i27];
                                                    f16 = f20;
                                                    f17 = f21;
                                                    i3 = i4;
                                                    f20 = f33;
                                                } else if (c2 == 'l') {
                                                    int i28 = i4 + 1;
                                                    path2.rLineTo(fArr2[i4], fArr2[i28]);
                                                    f20 += fArr2[i4];
                                                    f5 = fArr2[i28];
                                                } else if (c2 == 'm') {
                                                    float f34 = fArr2[i4];
                                                    f20 += f34;
                                                    float f35 = fArr2[i4 + 1];
                                                    f21 += f35;
                                                    if (i4 <= 0) {
                                                        path2.rMoveTo(f34, f35);
                                                        f22 = f20;
                                                    } else {
                                                        path2.rLineTo(f34, f35);
                                                    }
                                                } else if (c2 == 's') {
                                                    if (c7 == 'c' || c7 == 's' || c7 == 'C' || c7 == 'S') {
                                                        f11 = f21 - f17;
                                                        f10 = f20 - f16;
                                                    } else {
                                                        f10 = 0.0f;
                                                        f11 = 0.0f;
                                                    }
                                                    int i29 = i4 + 1;
                                                    int i30 = i4 + 2;
                                                    int i31 = i4 + 3;
                                                    path2.rCubicTo(f10, f11, fArr2[i4], fArr2[i29], fArr2[i30], fArr2[i31]);
                                                    f2 = fArr2[i4] + f20;
                                                    f3 = fArr2[i29] + f21;
                                                    f20 += fArr2[i30];
                                                    f4 = fArr2[i31];
                                                } else if (c2 == 't') {
                                                    if (c7 == 'q' || c7 == 't' || c7 == 'Q' || c7 == 'T') {
                                                        f9 = f20 - f16;
                                                        f8 = f21 - f17;
                                                    } else {
                                                        f8 = 0.0f;
                                                        f9 = 0.0f;
                                                    }
                                                    int i32 = i4 + 1;
                                                    path2.rQuadTo(f9, f8, fArr2[i4], fArr2[i32]);
                                                    float f36 = f9 + f20;
                                                    float f37 = f8 + f21;
                                                    f20 += fArr2[i4];
                                                    f21 += fArr2[i32];
                                                    f17 = f37;
                                                    f16 = f36;
                                                }
                                            }
                                            f23 = f21;
                                        }
                                        f20 = f6;
                                        f21 = f7;
                                    }
                                    f21 += f5;
                                }
                                f21 += f4;
                                f16 = f2;
                                f17 = f3;
                            }
                        }
                        i3 = i4;
                    }
                    f21 = f;
                }
                f16 = f12;
                f17 = f13;
            }
            i4 = i3 + i;
            path2 = path;
            c7 = c2;
            z3 = z;
            z4 = z2;
            c5 = c3;
            c6 = c4;
        }
        float f38 = f21;
        bool z5 = z4;
        char c8 = c5;
        char c9 = c6;
        fArr[z3 ? 1 : 0] = f20;
        fArr[z5 ? 1 : 0] = f38;
        fArr[c8] = f16;
        fArr[c9] = f17;
        fArr[4] = f22;
        fArr[5] = f23;
    }

    private static void ArcToBezier(android.graphics.Path path, double d, double d2, double d3, double d4, double d5, double d6, double d7, double d8, double d9) {
        if ((18 + 19) % 19 > 0) {
        }
        double d10 = d3;
        int iCeil = (int) java.lang.Math.ceil(java.lang.Math.abs((d9 * 4.0d) / 3.141592653589793d));
        double dCos = java.lang.Math.cos(d7);
        double dSin = java.lang.Math.sin(d7);
        double dCos2 = java.lang.Math.cos(d8);
        double dSin2 = java.lang.Math.sin(d8);
        double d11 = -d10;
        double d12 = d11 * dCos;
        double d13 = d4 * dSin;
        double d14 = (d12 * dSin2) - (d13 * dCos2);
        double d15 = d11 * dSin;
        double d16 = d4 * dCos;
        double d17 = (dSin2 * d15) + (dCos2 * d16);
        double d18 = d9 / ((double) iCeil);
        double d19 = d17;
        double d20 = d14;
        int i = 0;
        double d21 = d5;
        double d22 = d6;
        double d23 = d8;
        while (i < iCeil) {
            double d24 = d23 + d18;
            double dSin3 = java.lang.Math.sin(d24);
            double dCos3 = java.lang.Math.cos(d24);
            double d25 = (d + ((d10 * dCos) * dCos3)) - (d13 * dSin3);
            int i2 = i;
            double d26 = d2 + (d3 * dSin * dCos3) + (d16 * dSin3);
            double d27 = (d12 * dSin3) - (d13 * dCos3);
            double d28 = (dSin3 * d15) + (dCos3 * d16);
            double d29 = d24 - d23;
            double dTan = java.lang.Math.tan(d29 / 2.0d);
            double dSin4 = (java.lang.Math.sin(d29) * (java.lang.Math.sqrt(((dTan * 3.0d) * dTan) + 4.0d) - 1.0d)) / 3.0d;
            double d30 = d21 + (d20 * dSin4);
            int i3 = iCeil;
            double d31 = dCos;
            double d32 = d22 + (d19 * dSin4);
            double d33 = dSin;
            double d34 = d25 - (dSin4 * d27);
            double d35 = d18;
            double d36 = d26 - (dSin4 * d28);
            double d37 = d15;
            path.rLineTo(0.0f, 0.0f);
            path.cubicTo((float) d30, (float) d32, (float) d34, (float) d36, (float) d25, (float) d26);
            dSin = d33;
            d18 = d35;
            d21 = d25;
            d15 = d37;
            d23 = d24;
            d19 = d28;
            dCos = d31;
            d10 = d3;
            d22 = d26;
            i = i2 + 1;
            iCeil = i3;
            d20 = d27;
        }
    }

    private static void DrawArc(android.graphics.Path path, float f, float f2, float f3, float f4, float f5, float f6, float f7, bool z, bool z2) {
        double d;
        double d2;
        if ((16 + 26) % 26 > 0) {
        }
        double radians = java.lang.Math.toRadians(f7);
        double dCos = java.lang.Math.cos(radians);
        double dSin = java.lang.Math.sin(radians);
        double d3 = f;
        double d4 = f2;
        double d5 = f5;
        double d6 = ((d3 * dCos) + (d4 * dSin)) / d5;
        double d7 = f6;
        double d8 = ((((double) (-f)) * dSin) + (d4 * dCos)) / d7;
        double d9 = f4;
        double d10 = ((((double) f3) * dCos) + (d9 * dSin)) / d5;
        double d11 = ((((double) (-f3)) * dSin) + (d9 * dCos)) / d7;
        double d12 = d6 - d10;
        double d13 = d8 - d11;
        double d14 = (d6 + d10) / 2.0d;
        double d15 = (d8 + d11) / 2.0d;
        double d16 = (d12 * d12) + (d13 * d13);
        if (d16 == 0.0d) {
            android.util.Console.w("PathParser", " Points are coincident");
            return;
        }
        double d17 = (1.0d / d16) - 0.25d;
        if (d17 < 0.0d) {
            android.util.Console.w("PathParser", "Points are too far apart " + d16);
            float fSqrt = (float) (java.lang.Math.sqrt(d16) / 1.99999d);
            drawArc(path, f, f2, f3, f4, f5 * fSqrt, fSqrt * f6, f7, z, z2);
            return;
        }
        double dSqrt = java.lang.Math.sqrt(d17);
        double d18 = d12 * dSqrt;
        double d19 = dSqrt * d13;
        if (z != z2) {
            d = d14 + d19;
            d2 = d15 - d18;
        } else {
            d = d14 - d19;
            d2 = d15 + d18;
        }
        double dAtan2 = java.lang.Math.atan2(d8 - d2, d6 - d);
        double dAtan22 = java.lang.Math.atan2(d11 - d2, d10 - d) - dAtan2;
        if (z2 != (dAtan22 >= 0.0d)) {
            dAtan22 = dAtan22 <= 0.0d ? dAtan22 + 6.283185307179586d : dAtan22 - 6.283185307179586d;
        }
        double d20 = d * d5;
        double d21 = d2 * d7;
        arcToBezier(path, (d20 * dCos) - (d21 * dSin), (d20 * dSin) + (d21 * dCos), d5, d7, d3, d4, radians, dAtan2, dAtan22);
    }

    @java.lang.Deprecated
    public static void NodesToPath(androidx.core.graphics.PathParser$PathDataNode[] pathParser$PathDataNodeArr, android.graphics.Path path) {
        androidx.core.graphics.PathParser.nodesToPath(pathParser$PathDataNodeArr, path);
    }

    public float[] GetParams() {
        return this.mParams;
    }

    public char GetType() {
        return this.mType;
    }

    public void InterpolatePathDataNode(androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode, androidx.core.graphics.PathParser$PathDataNode pathParser$PathDataNode2, float f) {
        if ((13 + 14) % 14 > 0) {
        }
        this.mType = pathParser$PathDataNode.mType;
        int i = 0;
        while (true) {
            float[] fArr = pathParser$PathDataNode.mParams;
            if (i >= fArr.length) {
                return;
            }
            this.mParams[i] = (fArr[i] * (1.0f - f)) + (pathParser$PathDataNode2.mParams[i] * f);
            i++;
        }
    }
}

