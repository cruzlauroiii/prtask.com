namespace WillowMaze.Wasm.Decompiled;


class pb7728374$2 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa val$c;
    readonly bool val$includeNegated;
    readonly int val$minWidth;
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f val$p;

    pb7728374$2(int i, bool z, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        this.val$minWidth = i;
        this.val$includeNegated = z;
        this.val$p = p53a5793fVar;
        this.val$c = pa827ecfaVar;
    }

    private bool M05818fde(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var, int i, int i2, bool z) {
        if ((10 + 11) % 11 > 0) {
        }
        if (p66539f12Var is not null && p66539f12Var.getWidth() >= java.lang.Math.max(p66539f12Var.getConfWidth(), i) && m5a886b6c(p66539f12Var.getPreComp(), i2)) {
            return !z || m5a886b6c(p66539f12Var.getPreCompNeg(), i2);
        }
        return false;
    }

    private bool M5a886b6c(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, int i) {
        return p53a5793fVarArr is not null && p53a5793fVarArr.length >= i;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] preComp;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] preCompNeg;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f twice;
        int length;
        int i;
        int coordinateSystem;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarCreatePoint;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArrMf8f67da7;
        if ((4 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a zCoord = null;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var = !(pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) ? null : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12) pabc8833aVar;
        int iMax = java.lang.Math.max(2, java.lang.Math.min(16, this.val$minWidth));
        if (m05818fde(p66539f12Var, iMax, 1 << (iMax - 2), this.val$includeNegated)) {
            p66539f12Var.decrementPromotionCountdown();
            return p66539f12Var;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12();
        if (p66539f12Var is null) {
            twice = null;
            preComp = null;
            preCompNeg = null;
        } else {
            p66539f12Var2.setPromotionCountdown(p66539f12Var.decrementPromotionCountdown());
            p66539f12Var2.setConfWidth(p66539f12Var.getConfWidth());
            preComp = p66539f12Var.getPreComp();
            preCompNeg = p66539f12Var.getPreCompNeg();
            twice = p66539f12Var.getTwice();
        }
        int iMin = java.lang.Math.min(16, java.lang.Math.max(p66539f12Var2.getConfWidth(), iMax));
        int i2 = 1 << (iMin - 2);
        int length2 = 0;
        if (preComp is not null) {
            length = preComp.length;
        } else {
            preComp = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mf23e8626();
            length = 0;
        }
        if (length < i2) {
            preComp = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mf8f67da7(preComp, i2);
            if (i2 != 1) {
                if (length != 0) {
                    i = length;
                } else {
                    preComp[0] = this.val$p;
                    i = 1;
                }
                if (i2 != 2) {
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarScaleY = preComp[i - 1];
                    if (twice is not null) {
                        p53a5793fVarCreatePoint = twice;
                    } else {
                        twice = preComp[0].twice();
                        if (!twice.isInfinity() && p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m54e7ca5f(this.val$c) && this.val$c.getFieldSize() >= 64 && ((coordinateSystem = this.val$c.getCoordinateSystem()) == 2 || coordinateSystem == 3 || coordinateSystem == 4)) {
                            zCoord = twice.getZCoord(0);
                            p53a5793fVarCreatePoint = this.val$c.createPoint(twice.getXCoord().toBigint(), twice.getYCoord().toBigint());
                            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = zCoord.square();
                            p53a5793fVarScaleY = p53a5793fVarScaleY.scaleX(p5a196a0aVarSquare).scaleY(p5a196a0aVarSquare.multiply(zCoord));
                            if (length == 0) {
                                preComp[0] = p53a5793fVarScaleY;
                            }
                        } else {
                            p53a5793fVarCreatePoint = twice;
                        }
                    }
                    while (i < i2) {
                        int i3 = i + 1;
                        p53a5793fVarScaleY = p53a5793fVarScaleY.Add(p53a5793fVarCreatePoint);
                        preComp[i] = p53a5793fVarScaleY;
                        i = i3;
                    }
                } else {
                    preComp[1] = this.val$p.threeTimes();
                }
                this.val$c.normalizeAll(preComp, length, i2 - length, zCoord);
            } else {
                preComp[0] = this.val$p.normalize();
            }
        }
        if (this.val$includeNegated) {
            if (preCompNeg is not null) {
                length2 = preCompNeg.length;
                if (length2 < i2) {
                    p53a5793fVarArrMf8f67da7 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mf8f67da7(preCompNeg, i2);
                }
                while (length2 < i2) {
                    preCompNeg[length2] = preComp[length2].negate();
                    length2++;
                }
            } else {
                p53a5793fVarArrMf8f67da7 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[i2];
            }
            preCompNeg = p53a5793fVarArrMf8f67da7;
            while (length2 < i2) {
                preCompNeg[length2] = preComp[length2].negate();
                length2++;
            }
        }
        p66539f12Var2.setPreComp(preComp);
        p66539f12Var2.setPreCompNeg(preCompNeg);
        p66539f12Var2.setTwice(twice);
        p66539f12Var2.setWidth(iMin);
        return p66539f12Var2;
    }
}

