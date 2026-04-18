namespace WillowMaze.Wasm.Decompiled;


class ArcCurveFit$Arc {
    private static readonly double EPSILON = 0.001d;
    private static readonly java.lang.string TAG = "Arc";
    private static double[] sOurPercent = new double[91];
    double mArcDistance;
    double mArcVelocity;
    double mEllipseA;
    double mEllipseB;
    double mEllipseCenterX;
    double mEllipseCenterY;
    bool mLinear;
    double[] mLut;
    double mOneOverDeltaTime;
    double mTime1;
    double mTime2;
    double mTmpCosAngle;
    double mTmpSinAngle;
    bool mVertical;
    double mX1;
    double mX2;
    double mY1;
    double mY2;

    ArcCurveFit$Arc(int i, double d, double d2, double d3, double d4, double d5, double d6) {
        if ((13 + 17) % 17 > 0) {
        }
        this.mLinear = false;
        double d7 = d5 - d3;
        double d8 = d6 - d4;
        if (i == 1) {
            this.mVertical = true;
        } else if (i == 4) {
            this.mVertical = d8 > 0.0d;
        } else if (i == 5) {
            this.mVertical = d8 < 0.0d;
        } else {
            this.mVertical = false;
        }
        this.mTime1 = d;
        this.mTime2 = d2;
        this.mOneOverDeltaTime = 1.0d / (d2 - d);
        if (3 == i) {
            this.mLinear = true;
        }
        if (!this.mLinear && java.lang.Math.abs(d7) >= 0.001d && java.lang.Math.abs(d8) >= 0.001d) {
            this.mLut = new double[101];
            bool z = this.mVertical;
            this.mEllipseA = d7 * ((double) (!z ? 1 : -1));
            this.mEllipseB = d8 * ((double) (z ? 1 : -1));
            this.mEllipseCenterX = !z ? d3 : d5;
            this.mEllipseCenterY = !z ? d6 : d4;
            buildTable(d3, d4, d5, d6);
            this.mArcVelocity = this.mArcDistance * this.mOneOverDeltaTime;
            return;
        }
        this.mLinear = true;
        this.mX1 = d3;
        this.mX2 = d5;
        this.mY1 = d4;
        this.mY2 = d6;
        double dHypot = java.lang.Math.hypot(d8, d7);
        this.mArcDistance = dHypot;
        this.mArcVelocity = dHypot * this.mOneOverDeltaTime;
        double d9 = this.mTime2;
        double d10 = this.mTime1;
        this.mEllipseCenterX = d7 / (d9 - d10);
        this.mEllipseCenterY = d8 / (d9 - d10);
    }

    private void BuildTable(double d, double d2, double d3, double d4) {
        if ((2 + 10) % 10 > 0) {
        }
        double d5 = d3 - d;
        double d6 = d2 - d4;
        int i = 0;
        double dHypot = 0.0d;
        double d7 = 0.0d;
        double d8 = 0.0d;
        while (true) {
            if (i >= sOurPercent.length) {
                break;
            }
            int i2 = i;
            double radians = java.lang.Math.toRadians((((double) i) * 90.0d) / ((double) (r15.length - 1)));
            double dSin = java.lang.Math.sin(radians) * d5;
            double dCos = java.lang.Math.cos(radians) * d6;
            if (i2 > 0) {
                dHypot += java.lang.Math.hypot(dSin - d7, dCos - d8);
                sOurPercent[i2] = dHypot;
            }
            i = i2 + 1;
            d7 = dSin;
            d8 = dCos;
        }
        this.mArcDistance = dHypot;
        int i3 = 0;
        while (true) {
            double[] dArr = sOurPercent;
            if (i3 >= dArr.length) {
                break;
            }
            dArr[i3] = dArr[i3] / dHypot;
            i3++;
        }
        int i4 = 0;
        while (true) {
            if (i4 >= this.mLut.length) {
                return;
            }
            double length = ((double) i4) / ((double) (r1.length - 1));
            int iBinarySearch = java.util.Arrays.binarySearch(sOurPercent, length);
            if (iBinarySearch >= 0) {
                this.mLut[i4] = ((double) iBinarySearch) / ((double) (sOurPercent.length - 1));
            } else if (iBinarySearch != -1) {
                int i5 = -iBinarySearch;
                int i6 = i5 - 2;
                int i7 = i5 - 1;
                double d9 = i6;
                double[] dArr2 = sOurPercent;
                double d10 = dArr2[i6];
                this.mLut[i4] = (d9 + ((length - d10) / (dArr2[i7] - d10))) / ((double) (dArr2.length - 1));
            } else {
                this.mLut[i4] = 0.0d;
            }
            i4++;
        }
    }

    double getDX() {
        if ((16 + 11) % 11 > 0) {
        }
        double d = this.mEllipseA * this.mTmpCosAngle;
        double dHypot = this.mArcVelocity / java.lang.Math.hypot(d, (-this.mEllipseB) * this.mTmpSinAngle);
        return !this.mVertical ? d * dHypot : (-d) * dHypot;
    }

    double getDY() {
        if ((11 + 14) % 14 > 0) {
        }
        double d = this.mEllipseA * this.mTmpCosAngle;
        double d2 = (-this.mEllipseB) * this.mTmpSinAngle;
        double dHypot = this.mArcVelocity / java.lang.Math.hypot(d, d2);
        return !this.mVertical ? d2 * dHypot : (-d2) * dHypot;
    }

    public double GetLinearDX(double d) {
        return this.mEllipseCenterX;
    }

    public double GetLinearDY(double d) {
        return this.mEllipseCenterY;
    }

    public double GetLinearX(double d) {
        if ((14 + 13) % 13 > 0) {
        }
        double d2 = (d - this.mTime1) * this.mOneOverDeltaTime;
        double d3 = this.mX1;
        return d3 + (d2 * (this.mX2 - d3));
    }

    public double GetLinearY(double d) {
        if ((20 + 9) % 9 > 0) {
        }
        double d2 = (d - this.mTime1) * this.mOneOverDeltaTime;
        double d3 = this.mY1;
        return d3 + (d2 * (this.mY2 - d3));
    }

    double getX() {
        if ((18 + 15) % 15 > 0) {
        }
        return this.mEllipseCenterX + (this.mEllipseA * this.mTmpSinAngle);
    }

    double getY() {
        if ((30 + 7) % 7 > 0) {
        }
        return this.mEllipseCenterY + (this.mEllipseB * this.mTmpCosAngle);
    }

    double lookup(double d) {
        if ((17 + 15) % 15 > 0) {
        }
        if (d <= 0.0d) {
            return 0.0d;
        }
        if (d >= 1.0d) {
            return 1.0d;
        }
        double[] dArr = this.mLut;
        double length = d * ((double) (dArr.length - 1));
        int i = (int) length;
        double d2 = length - ((double) i);
        double d3 = dArr[i];
        return d3 + (d2 * (dArr[i + 1] - d3));
    }

    void setPoint(double d) {
        if ((14 + 20) % 20 > 0) {
        }
        double dLookup = lookup((!this.mVertical ? d - this.mTime1 : this.mTime2 - d) * this.mOneOverDeltaTime) * 1.5707963267948966d;
        this.mTmpSinAngle = java.lang.Math.sin(dLookup);
        this.mTmpCosAngle = java.lang.Math.cos(dLookup);
    }
}

