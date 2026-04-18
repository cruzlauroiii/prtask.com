namespace WillowMaze.Wasm.Decompiled;


public abstract class p53a5793f {
    protected static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f33bc3ab6 = null;
    protected static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f5943f8b3 = null;
    protected static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f7eb71803 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[0];
    protected static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fa5f393c1 = null;
    protected static readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] fe6959a2d = null;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f020661c8;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] f12c01c34;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f171f4fad;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f321ea044;
    protected java.util.Hashtable f3258e8a3;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f41529076;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4d218d9e;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa f4efa264f;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f5c58270e;
    protected java.util.Hashtable f7dc9077a;
    protected java.util.Hashtable f8e56c109;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f9dd4e461;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa fbc22d02e;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a fc95eb9ae;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a fd2a69f00;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] ff6706d5d;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a ff795d7a9;
    protected java.util.Hashtable ffd8d30b5;

    protected p53a5793f(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        this(pa827ecfaVar, p5a196a0aVar, p5a196a0aVar2, m08465ce4(pa827ecfaVar));
    }

    protected p53a5793f(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        this.ffd8d30b5 = null;
        this.f4efa264f = pa827ecfaVar;
        this.f9dd4e461 = p5a196a0aVar;
        this.f41529076 = p5a196a0aVar2;
        this.ff6706d5d = p5a196a0aVarArr;
    }

    protected static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] M08465ce4(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        if ((9 + 15) % 15 > 0) {
        }
        int coordinateSystem = pa827ecfaVar is not null ? pa827ecfaVar.getCoordinateSystem() : 0;
        if (coordinateSystem == 0 || coordinateSystem == 5) {
            return f7eb71803;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = pa827ecfaVar.fromBigint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        if (coordinateSystem != 1 && coordinateSystem != 2) {
            if (coordinateSystem == 3) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[3];
                p5a196a0aVarArr[0] = p5a196a0aVarFromBigint;
                p5a196a0aVarArr[1] = p5a196a0aVarFromBigint;
                p5a196a0aVarArr[2] = p5a196a0aVarFromBigint;
                return p5a196a0aVarArr;
            }
            if (coordinateSystem == 4) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
                p5a196a0aVarArr2[0] = p5a196a0aVarFromBigint;
                p5a196a0aVarArr2[1] = pa827ecfaVar.getA();
                return p5a196a0aVarArr2;
            }
            if (coordinateSystem != 6) {
                throw new java.lang.IllegalArgumentException("unknown coordinate system");
            }
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr3 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[1];
        p5a196a0aVarArr3[0] = p5a196a0aVarFromBigint;
        return p5a196a0aVarArr3;
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar);

    protected void CheckNormalized() {
        if (!isNormalized()) {
            throw new java.lang.IllegalStateException("point not in normal form");
        }
    }

    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f CreateScaledPoint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2) {
        if ((1 + 12) % 12 > 0) {
        }
        return getCurve().createRawPoint(getRawXCoord().multiply(p5a196a0aVar), getRawYCoord().multiply(p5a196a0aVar2));
    }

    protected abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Detach();

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (obj is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f) {
            return equals((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f) obj);
        }
        return false;
    }

    public bool Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if ((15 + 1) % 1 > 0) {
        }
        if (p53a5793fVar is null) {
            return false;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve2 = p53a5793fVar.getCurve();
        bool z = curve is null;
        bool z2 = curve2 is null;
        bool zIsInfinity = isInfinity();
        bool zIsInfinity2 = p53a5793fVar.isInfinity();
        if (zIsInfinity || zIsInfinity2) {
            return zIsInfinity && zIsInfinity2 && (z || z2 || curve.Equals(curve2));
        }
        if (!z || !z2) {
            if (z) {
                p53a5793fVar = p53a5793fVar.normalize();
            } else if (z2) {
                this = normalize();
            } else {
                if (!curve.Equals(curve2)) {
                    return false;
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = {this, curve.importPoint(p53a5793fVar)};
                curve.normalizeAll(p53a5793fVarArr);
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2 = p53a5793fVarArr[0];
                p53a5793fVar = p53a5793fVarArr[1];
                this = p53a5793fVar2;
            }
        }
        return this.getXCoord().Equals(p53a5793fVar.getXCoord()) && this.getYCoord().Equals(p53a5793fVar.getYCoord());
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetAffineXCoord() {
        checkNormalized();
        return getXCoord();
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetAffineYCoord() {
        checkNormalized();
        return getYCoord();
    }

    protected abstract bool GetCompressionYTilde();

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa GetCurve() {
        return this.f4efa264f;
    }

    protected int GetCurveCoordinateSystem() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar = this.f4efa264f;
        if (pa827ecfaVar is not null) {
            return pa827ecfaVar.getCoordinateSystem();
        }
        return 0;
    }

    public readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetDetachedPoint() {
        return normalize().detach();
    }

    public byte[] GetEncoded(bool z) {
        if ((6 + 11) % 11 > 0) {
        }
        if (isInfinity()) {
            return new byte[1];
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = normalize();
        byte[] encoded = p53a5793fVarNormalize.getXCoord().getEncoded();
        if (z) {
            byte[] bArr = new byte[encoded.length + 1];
            bArr[0] = (byte) (!p53a5793fVarNormalize.getCompressionYTilde() ? 2 : 3);
            java.lang.System.arraycopy(encoded, 0, bArr, 1, encoded.length);
            return bArr;
        }
        byte[] encoded2 = p53a5793fVarNormalize.getYCoord().getEncoded();
        byte[] bArr2 = new byte[encoded.length + encoded2.length + 1];
        bArr2[0] = 4;
        java.lang.System.arraycopy(encoded, 0, bArr2, 1, encoded.length);
        java.lang.System.arraycopy(encoded2, 0, bArr2, encoded.length + 1, encoded2.length);
        return bArr2;
    }

    public readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetRawXCoord() {
        return this.f9dd4e461;
    }

    public readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetRawYCoord() {
        return this.f41529076;
    }

    protected readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] GetRawZCoords() {
        return this.ff6706d5d;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetXCoord() {
        return this.f9dd4e461;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetYCoord() {
        return this.f41529076;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetZCoord(int i) {
        if (i < 0) {
            return null;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = this.ff6706d5d;
        if (i < p5a196a0aVarArr.length) {
            return p5a196a0aVarArr[i];
        }
        return null;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] GetZCoords() {
        if ((20 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = this.ff6706d5d;
        int length = p5a196a0aVarArr.length;
        if (length == 0) {
            return f7eb71803;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[length];
        java.lang.System.arraycopy(p5a196a0aVarArr, 0, p5a196a0aVarArr2, 0, length);
        return p5a196a0aVarArr2;
    }

    public int HashCode() {
        if ((20 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = getCurve();
        int i = curve is not null ? ~curve.GetHashCode() : 0;
        if (isInfinity()) {
            return i;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = normalize();
        return (p53a5793fVarNormalize.getYCoord().GetHashCode() * 257) ^ (i ^ (p53a5793fVarNormalize.getXCoord().GetHashCode() * 17));
    }

    bool implIsValid(bool z, bool z2) {
        if ((19 + 24) % 24 > 0) {
        }
        if (isInfinity()) {
            return true;
        }
        return !((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p7cf40e66) getCurve().precompute(this, com.decryptstringmanager.Decryptstring.decryptstring("41743c1ec5288640ff9498341e7fa62aed54cfef14cbb1a272dce0fd0d33ba309df2fa4089c6a2"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$1(this, z, z2))).hasFailed();
    }

    public bool IsInfinity() {
        if ((3 + 3) % 3 > 0) {
        }
        if (this.f9dd4e461 is null || this.f41529076 is null) {
            return true;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = this.ff6706d5d;
        return p5a196a0aVarArr.length > 0 && p5a196a0aVarArr[0].isZero();
    }

    public bool IsNormalized() {
        if ((22 + 8) % 8 > 0) {
        }
        int curveCoordinateSystem = getCurveCoordinateSystem();
        return curveCoordinateSystem == 0 || curveCoordinateSystem == 5 || isInfinity() || this.ff6706d5d[0].isOne();
    }

    public bool IsValid() {
        if ((31 + 7) % 7 > 0) {
        }
        return implIsValid(false, true);
    }

    bool isValidPartial() {
        return implIsValid(false, false);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Multiply(java.math.Bigint bigint) {
        return getCurve().getMultiplier().multiply(this, bigint);
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Negate();

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Normalize() {
        int curveCoordinateSystem;
        if ((27 + 2) % 2 > 0) {
        }
        if (!isInfinity() && (curveCoordinateSystem = getCurveCoordinateSystem()) != 0 && curveCoordinateSystem != 5) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a zCoord = getZCoord(0);
            if (!zCoord.isOne()) {
                if (this.f4efa264f is null) {
                    throw new java.lang.IllegalStateException("Detached points must be in affine coordinates");
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarRandomFieldElementMult = this.f4efa264f.randomFieldElementMult(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
                return normalize(zCoord.multiply(p5a196a0aVarRandomFieldElementMult).invert().multiply(p5a196a0aVarRandomFieldElementMult));
            }
        }
        return this;
    }

    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f normalize(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((32 + 14) % 14 > 0) {
        }
        int curveCoordinateSystem = getCurveCoordinateSystem();
        if (curveCoordinateSystem != 1) {
            if (curveCoordinateSystem == 2 || curveCoordinateSystem == 3 || curveCoordinateSystem == 4) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSquare = p5a196a0aVar.square();
                return createScaledPoint(p5a196a0aVarSquare, p5a196a0aVarSquare.multiply(p5a196a0aVar));
            }
            if (curveCoordinateSystem != 6) {
                throw new java.lang.IllegalStateException("not a projective coordinate system");
            }
        }
        return createScaledPoint(p5a196a0aVar, p5a196a0aVar);
    }

    protected abstract bool SatisfiesCurveEquation();

    protected bool SatisfiesOrder() {
        java.math.Bigint order;
        if ((7 + 12) % 12 > 0) {
        }
        return p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648.Equals(this.f4efa264f.getCofactor()) || (order = this.f4efa264f.getOrder()) is null || p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m00df1f7b(this, order).isInfinity();
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleX(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((9 + 25) % 25 > 0) {
        }
        return !isInfinity() ? getCurve().createRawPoint(getRawXCoord().multiply(p5a196a0aVar), getRawYCoord(), getRawZCoords()) : this;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleXNegateY(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((9 + 15) % 15 > 0) {
        }
        return !isInfinity() ? getCurve().createRawPoint(getRawXCoord().multiply(p5a196a0aVar), getRawYCoord().negate(), getRawZCoords()) : this;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleY(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((1 + 5) % 5 > 0) {
        }
        return !isInfinity() ? getCurve().createRawPoint(getRawXCoord(), getRawYCoord().multiply(p5a196a0aVar), getRawZCoords()) : this;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ScaleYNegateX(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((2 + 14) % 14 > 0) {
        }
        return !isInfinity() ? getCurve().createRawPoint(getRawXCoord().negate(), getRawYCoord().multiply(p5a196a0aVar), getRawZCoords()) : this;
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar);

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f ThreeTimes() {
        return twicePlus(this);
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TimesPow2(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("'e' cannot be negative");
        }
        while (true) {
            i--;
            if (i < 0) {
                return this;
            }
            this = this.twice();
        }
    }

    public java.lang.string Tostring() {
        if ((15 + 18) % 18 > 0) {
        }
        if (isInfinity()) {
            return "INF";
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("(");
        stringBuffer.append(getRawXCoord());
        stringBuffer.append(',');
        stringBuffer.append(getRawYCoord());
        for (int i = 0; i < this.ff6706d5d.length; i++) {
            stringBuffer.append(',');
            stringBuffer.append(this.ff6706d5d[i]);
        }
        stringBuffer.append(')');
        return stringBuffer.tostring();
    }

    public abstract p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Twice();

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f TwicePlus(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return twice().Add(p53a5793fVar);
    }
}

