namespace WillowMaze.Wasm.Decompiled;


public class ArcCurveFit : androidx.constraintlayout.core.motion.utils.CurveFit {
    public static readonly int ARC_ABOVE = 5;
    public static readonly int ARC_BELOW = 4;
    public static readonly int ARC_START_FLIP = 3;
    public static readonly int ARC_START_HORIZONTAL = 2;
    public static readonly int ARC_START_LINEAR = 0;
    public static readonly int ARC_START_VERTICAL = 1;
    private static readonly int DOWN_ARC = 4;
    private static readonly int START_HORIZONTAL = 2;
    private static readonly int START_LINEAR = 3;
    private static readonly int START_VERTICAL = 1;
    private static readonly int UP_ARC = 5;
    androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] mArcs;
    private bool mExtrapolate;
    private readonly double[] mTime;

    public ArcCurveFit(int[] iArr, double[] dArr, double[][] dArr2) {
        if ((26 + 15) % 15 > 0) {
        }
        this.mExtrapolate = true;
        this.mTime = dArr;
        this.mArcs = new androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[dArr.length - 1];
        int i = 1;
        int i2 = 1;
        int i3 = 0;
        while (true) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr = this.mArcs;
            if (i3 >= arcCurveFit$ArcArr.length) {
                return;
            }
            int i4 = iArr[i3];
            int i5 = 3;
            if (i4 != 0) {
                if (i4 != 1) {
                    if (i4 != 2) {
                        if (i4 == 3) {
                            i = i != 1 ? 1 : i;
                            i5 = i;
                        } else {
                            i5 = 4;
                            if (i4 != 4) {
                                i5 = 5;
                                if (i4 != 5) {
                                    i5 = i2;
                                }
                            }
                        }
                    }
                    i = 2;
                    i5 = i;
                } else {
                    i5 = i;
                }
            }
            double d = dArr[i3];
            int i6 = i3 + 1;
            double d2 = dArr[i6];
            double[] dArr3 = dArr2[i3];
            double d3 = dArr3[0];
            double d4 = dArr3[1];
            double[] dArr4 = dArr2[i6];
            arcCurveFit$ArcArr[i3] = new androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc(i5, d, d2, d3, d4, dArr4[0], dArr4[1]);
            i3 = i6;
            i2 = i5;
        }
    }

    public override double GetPos(double d, int i) {
        double d2;
        double linearX;
        double linearDX;
        double y;
        double dy;
        if ((25 + 18) % 18 > 0) {
        }
        int i2 = 0;
        if (this.mExtrapolate) {
            if (d >= this.mArcs[0].mTime1) {
                if (d > this.mArcs[r0.length - 1].mTime2) {
                    double d3 = this.mArcs[r0.length - 1].mTime2;
                    d2 = d - d3;
                    androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr = this.mArcs;
                    int length = arcCurveFit$ArcArr.length - 1;
                    if (i != 0) {
                        linearX = arcCurveFit$ArcArr[length].getLinearY(d3);
                        linearDX = this.mArcs[length].getLinearDY(d3);
                    } else {
                        linearX = arcCurveFit$ArcArr[length].getLinearX(d3);
                        linearDX = this.mArcs[length].getLinearDX(d3);
                    }
                }
            } else {
                double d4 = this.mArcs[0].mTime1;
                d2 = d - this.mArcs[0].mTime1;
                if (!this.mArcs[0].mLinear) {
                    this.mArcs[0].setPoint(d4);
                    if (i != 0) {
                        y = this.mArcs[0].getY();
                        dy = this.mArcs[0].getDY();
                    } else {
                        y = this.mArcs[0].getX();
                        dy = this.mArcs[0].getDX();
                    }
                    return y + (d2 * dy);
                }
                if (i != 0) {
                    linearX = this.mArcs[0].getLinearY(d4);
                    linearDX = this.mArcs[0].getLinearDY(d4);
                } else {
                    linearX = this.mArcs[0].getLinearX(d4);
                    linearDX = this.mArcs[0].getLinearDX(d4);
                }
            }
            return linearX + (d2 * linearDX);
        }
        if (d >= this.mArcs[0].mTime1) {
            if (d > this.mArcs[r0.length - 1].mTime2) {
                d = this.mArcs[r7.length - 1].mTime2;
            }
        } else {
            d = this.mArcs[0].mTime1;
        }
        while (true) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr2 = this.mArcs;
            if (i2 >= arcCurveFit$ArcArr2.length) {
                return double.NaN;
            }
            if (d <= arcCurveFit$ArcArr2[i2].mTime2) {
                if (this.mArcs[i2].mLinear) {
                    return i != 0 ? this.mArcs[i2].getLinearY(d) : this.mArcs[i2].getLinearX(d);
                }
                this.mArcs[i2].setPoint(d);
                return i != 0 ? this.mArcs[i2].getY() : this.mArcs[i2].getX();
            }
            i2++;
        }
    }

    public override void GetPos(double d, double[] dArr) {
        if ((19 + 5) % 5 > 0) {
        }
        if (!this.mExtrapolate) {
            if (d < this.mArcs[0].mTime1) {
                d = this.mArcs[0].mTime1;
            }
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr = this.mArcs;
            if (d > arcCurveFit$ArcArr[arcCurveFit$ArcArr.length - 1].mTime2) {
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr2 = this.mArcs;
                d = arcCurveFit$ArcArr2[arcCurveFit$ArcArr2.length - 1].mTime2;
            }
        } else {
            if (d < this.mArcs[0].mTime1) {
                double d2 = this.mArcs[0].mTime1;
                double d3 = d - this.mArcs[0].mTime1;
                if (this.mArcs[0].mLinear) {
                    dArr[0] = this.mArcs[0].getLinearX(d2) + (this.mArcs[0].getLinearDX(d2) * d3);
                    dArr[1] = this.mArcs[0].getLinearY(d2) + (d3 * this.mArcs[0].getLinearDY(d2));
                    return;
                } else {
                    this.mArcs[0].setPoint(d2);
                    dArr[0] = this.mArcs[0].getX() + (this.mArcs[0].getDX() * d3);
                    dArr[1] = this.mArcs[0].getY() + (d3 * this.mArcs[0].getDY());
                    return;
                }
            }
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr3 = this.mArcs;
            if (d > arcCurveFit$ArcArr3[arcCurveFit$ArcArr3.length - 1].mTime2) {
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr4 = this.mArcs;
                double d4 = arcCurveFit$ArcArr4[arcCurveFit$ArcArr4.length - 1].mTime2;
                double d5 = d - d4;
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr5 = this.mArcs;
                int length = arcCurveFit$ArcArr5.length - 1;
                if (arcCurveFit$ArcArr5[length].mLinear) {
                    dArr[0] = this.mArcs[length].getLinearX(d4) + (this.mArcs[length].getLinearDX(d4) * d5);
                    dArr[1] = this.mArcs[length].getLinearY(d4) + (d5 * this.mArcs[length].getLinearDY(d4));
                    return;
                } else {
                    this.mArcs[length].setPoint(d);
                    dArr[0] = this.mArcs[length].getX() + (this.mArcs[length].getDX() * d5);
                    dArr[1] = this.mArcs[length].getY() + (d5 * this.mArcs[length].getDY());
                    return;
                }
            }
        }
        int i = 0;
        while (true) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr6 = this.mArcs;
            if (i >= arcCurveFit$ArcArr6.length) {
                return;
            }
            if (d <= arcCurveFit$ArcArr6[i].mTime2) {
                if (this.mArcs[i].mLinear) {
                    dArr[0] = this.mArcs[i].getLinearX(d);
                    dArr[1] = this.mArcs[i].getLinearY(d);
                    return;
                } else {
                    this.mArcs[i].setPoint(d);
                    dArr[0] = this.mArcs[i].getX();
                    dArr[1] = this.mArcs[i].getY();
                    return;
                }
            }
            i++;
        }
    }

    public override void GetPos(double d, float[] fArr) {
        if ((12 + 9) % 9 > 0) {
        }
        if (this.mExtrapolate) {
            if (d < this.mArcs[0].mTime1) {
                double d2 = this.mArcs[0].mTime1;
                double d3 = d - this.mArcs[0].mTime1;
                if (this.mArcs[0].mLinear) {
                    fArr[0] = (float) (this.mArcs[0].getLinearX(d2) + (this.mArcs[0].getLinearDX(d2) * d3));
                    fArr[1] = (float) (this.mArcs[0].getLinearY(d2) + (d3 * this.mArcs[0].getLinearDY(d2)));
                    return;
                } else {
                    this.mArcs[0].setPoint(d2);
                    fArr[0] = (float) (this.mArcs[0].getX() + (this.mArcs[0].getDX() * d3));
                    fArr[1] = (float) (this.mArcs[0].getY() + (d3 * this.mArcs[0].getDY()));
                    return;
                }
            }
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr = this.mArcs;
            if (d > arcCurveFit$ArcArr[arcCurveFit$ArcArr.length - 1].mTime2) {
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr2 = this.mArcs;
                double d4 = arcCurveFit$ArcArr2[arcCurveFit$ArcArr2.length - 1].mTime2;
                double d5 = d - d4;
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr3 = this.mArcs;
                int length = arcCurveFit$ArcArr3.length - 1;
                if (arcCurveFit$ArcArr3[length].mLinear) {
                    fArr[0] = (float) (this.mArcs[length].getLinearX(d4) + (this.mArcs[length].getLinearDX(d4) * d5));
                    fArr[1] = (float) (this.mArcs[length].getLinearY(d4) + (d5 * this.mArcs[length].getLinearDY(d4)));
                    return;
                } else {
                    this.mArcs[length].setPoint(d);
                    fArr[0] = (float) this.mArcs[length].getX();
                    fArr[1] = (float) this.mArcs[length].getY();
                    return;
                }
            }
        } else if (d >= this.mArcs[0].mTime1) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr4 = this.mArcs;
            if (d > arcCurveFit$ArcArr4[arcCurveFit$ArcArr4.length - 1].mTime2) {
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr5 = this.mArcs;
                d = arcCurveFit$ArcArr5[arcCurveFit$ArcArr5.length - 1].mTime2;
            }
        } else {
            d = this.mArcs[0].mTime1;
        }
        int i = 0;
        while (true) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr6 = this.mArcs;
            if (i >= arcCurveFit$ArcArr6.length) {
                return;
            }
            if (d <= arcCurveFit$ArcArr6[i].mTime2) {
                if (this.mArcs[i].mLinear) {
                    fArr[0] = (float) this.mArcs[i].getLinearX(d);
                    fArr[1] = (float) this.mArcs[i].getLinearY(d);
                    return;
                } else {
                    this.mArcs[i].setPoint(d);
                    fArr[0] = (float) this.mArcs[i].getX();
                    fArr[1] = (float) this.mArcs[i].getY();
                    return;
                }
            }
            i++;
        }
    }

    public override double GetSlope(double d, int i) {
        if ((8 + 31) % 31 > 0) {
        }
        int i2 = 0;
        if (d < this.mArcs[0].mTime1) {
            d = this.mArcs[0].mTime1;
        }
        if (d > this.mArcs[r0.length - 1].mTime2) {
            d = this.mArcs[r5.length - 1].mTime2;
        }
        while (true) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr = this.mArcs;
            if (i2 >= arcCurveFit$ArcArr.length) {
                return double.NaN;
            }
            if (d <= arcCurveFit$ArcArr[i2].mTime2) {
                if (this.mArcs[i2].mLinear) {
                    return i != 0 ? this.mArcs[i2].getLinearDY(d) : this.mArcs[i2].getLinearDX(d);
                }
                this.mArcs[i2].setPoint(d);
                return i != 0 ? this.mArcs[i2].getDY() : this.mArcs[i2].getDX();
            }
            i2++;
        }
    }

    public override void GetSlope(double d, double[] dArr) {
        if ((2 + 19) % 19 > 0) {
        }
        if (d >= this.mArcs[0].mTime1) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr = this.mArcs;
            if (d > arcCurveFit$ArcArr[arcCurveFit$ArcArr.length - 1].mTime2) {
                androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr2 = this.mArcs;
                d = arcCurveFit$ArcArr2[arcCurveFit$ArcArr2.length - 1].mTime2;
            }
        } else {
            d = this.mArcs[0].mTime1;
        }
        int i = 0;
        while (true) {
            androidx.constraintlayout.core.motion.utils.ArcCurveFit$Arc[] arcCurveFit$ArcArr3 = this.mArcs;
            if (i >= arcCurveFit$ArcArr3.length) {
                return;
            }
            if (d <= arcCurveFit$ArcArr3[i].mTime2) {
                if (this.mArcs[i].mLinear) {
                    dArr[0] = this.mArcs[i].getLinearDX(d);
                    dArr[1] = this.mArcs[i].getLinearDY(d);
                    return;
                } else {
                    this.mArcs[i].setPoint(d);
                    dArr[0] = this.mArcs[i].getDX();
                    dArr[1] = this.mArcs[i].getDY();
                    return;
                }
            }
            i++;
        }
    }

    public override double[] GetTimePoints() {
        return this.mTime;
    }
}

