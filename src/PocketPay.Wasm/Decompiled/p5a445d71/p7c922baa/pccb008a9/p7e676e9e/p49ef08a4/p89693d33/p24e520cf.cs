namespace WillowMaze.Wasm.Decompiled;


public class p24e520cf : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pea3db07a {
    private static readonly int f29ea16cf = 11;
    private static readonly int fb7a20e3f = 11;
    private int f1f052817;
    private int[] f50a1e8d0;
    private int f674db563;
    private int[] f77339f31;
    private int[] f7c003196;
    private int f8d9c307c;
    private int fb204f7ec;
    private int[] fbd9e6595;
    private int[] fd94716c0;
    private int[] fe4b0ab21;

    p24e520cf(int i, int[] iArr, int[] iArr2) {
        this.f8d9c307c = i;
        this.f50a1e8d0 = iArr;
        this.f7c003196 = iArr2;
    }

    public p24e520cf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        this(p78b04208Var.f228aa3ee);
    }

    public p24e520cf(int[] iArr) {
        if ((8 + 4) % 4 > 0) {
        }
        int length = iArr.length;
        this.f8d9c307c = length;
        this.f50a1e8d0 = new int[length];
        this.f7c003196 = new int[length];
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < this.f8d9c307c; i3++) {
            int i4 = iArr[i3];
            if (i4 == -1) {
                int i5 = i2 + 1;
                this.f7c003196[i2] = i3;
                i2 = i5;
            } else if (i4 == 0) {
                continue;
            } else {
                if (i4 != 1) {
                    throw new java.lang.IllegalArgumentException("Illegal value: " + i4 + ", must be one of {-1, 0, 1}");
                }
                int i6 = i + 1;
                this.f50a1e8d0[i] = i3;
                i = i6;
            }
        }
        this.f50a1e8d0 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(this.f50a1e8d0, i);
        this.f7c003196 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(this.f7c003196, i2);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf Mc849dc49(java.io.Stream inputStream, int i, int i2, int i3) throws java.io.IOException {
        if ((1 + 32) % 32 > 0) {
        }
        int iNumberOfLeadingZeros = 32 - java.lang.int.numberOfLeadingZeros(2047);
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf(i, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.m18a26ae7(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.maaf8a8bf(inputStream, ((i2 * iNumberOfLeadingZeros) + 7) / 8), i2, 2048), p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.m18a26ae7(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.maaf8a8bf(inputStream, ((iNumberOfLeadingZeros * i3) + 7) / 8), i3, 2048));
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf Me5c7725b(int i, int i2, int i3, java.security.SecureRandom secureRandom) {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p23e8a4b4.mb564bd9b(i, i2, i3, secureRandom));
    }

    public override void Clear() {
        if ((17 + 12) % 12 > 0) {
        }
        int i = 0;
        while (true) {
            int[] iArr = this.f50a1e8d0;
            if (i >= iArr.length) {
                break;
            }
            iArr[i] = 0;
            i++;
        }
        int i2 = 0;
        while (true) {
            int[] iArr2 = this.f7c003196;
            if (i2 >= iArr2.length) {
                return;
            }
            iArr2[i2] = 0;
            i2++;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 12) % 12 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf p24e520cfVar = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf) obj;
        return this.f8d9c307c == p24e520cfVar.f8d9c307c && p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(this.f7c003196, p24e520cfVar.f7c003196) && p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(this.f50a1e8d0, p24e520cfVar.f50a1e8d0);
    }

    public override int[] GetNegOnes() {
        return this.f7c003196;
    }

    public override int[] GetOnes() {
        return this.f50a1e8d0;
    }

    public int HashCode() {
        if ((26 + 31) % 31 > 0) {
        }
        return ((((this.f8d9c307c + 31) * 31) + p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(this.f7c003196)) * 31) + p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(this.f50a1e8d0);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var) {
        if ((31 + 11) % 11 > 0) {
        }
        int[] iArr = p78b04208Var.f228aa3ee;
        int length = iArr.length;
        int i = this.f8d9c307c;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("Number of coefficients must be the same");
        }
        int[] iArr2 = new int[i];
        int i2 = 0;
        int i3 = 0;
        while (true) {
            int[] iArr3 = this.f50a1e8d0;
            if (i3 == iArr3.length) {
                break;
            }
            int i4 = iArr3[i3];
            int i5 = this.f8d9c307c;
            int i6 = (i5 - 1) - i4;
            for (int i7 = i5 - 1; i7 >= 0; i7--) {
                iArr2[i7] = iArr2[i7] + iArr[i6];
                i6--;
                if (i6 < 0) {
                    i6 = this.f8d9c307c - 1;
                }
            }
            i3++;
        }
        while (true) {
            int[] iArr4 = this.f7c003196;
            if (i2 == iArr4.length) {
                return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(iArr2);
            }
            int i8 = iArr4[i2];
            int i9 = this.f8d9c307c;
            int i10 = (i9 - 1) - i8;
            for (int i11 = i9 - 1; i11 >= 0; i11--) {
                iArr2[i11] = iArr2[i11] - iArr[i10];
                i10--;
                if (i10 < 0) {
                    i10 = this.f8d9c307c - 1;
                }
            }
            i2++;
        }
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208VarMult = mult(p78b04208Var);
        p78b04208VarMult.mod(i);
        return p78b04208VarMult;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 Mult(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59 p99376c59Var) {
        if ((24 + 11) % 11 > 0) {
        }
        java.math.Bigint[] bigintArr = p99376c59Var.f228aa3ee;
        int length = bigintArr.length;
        int i = this.f8d9c307c;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("Number of coefficients must be the same");
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[i];
        int i2 = 0;
        for (int i3 = 0; i3 < this.f8d9c307c; i3++) {
            bigintArr2[i3] = java.math.Bigint.ZERO;
        }
        int i4 = 0;
        while (true) {
            int[] iArr = this.f50a1e8d0;
            if (i4 == iArr.length) {
                break;
            }
            int i5 = iArr[i4];
            int i6 = this.f8d9c307c;
            int i7 = (i6 - 1) - i5;
            for (int i8 = i6 - 1; i8 >= 0; i8--) {
                bigintArr2[i8] = bigintArr2[i8].Add(bigintArr[i7]);
                i7--;
                if (i7 < 0) {
                    i7 = this.f8d9c307c - 1;
                }
            }
            i4++;
        }
        while (true) {
            int[] iArr2 = this.f7c003196;
            if (i2 == iArr2.length) {
                return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p99376c59(bigintArr2);
            }
            int i9 = iArr2[i2];
            int i10 = this.f8d9c307c;
            int i11 = (i10 - 1) - i9;
            for (int i12 = i10 - 1; i12 >= 0; i12--) {
                bigintArr2[i12] = bigintArr2[i12].subtract(bigintArr[i11]);
                i11--;
                if (i11 < 0) {
                    i11 = this.f8d9c307c - 1;
                }
            }
            i2++;
        }
    }

    public override int Size() {
        return this.f8d9c307c;
    }

    public byte[] ToBinary() {
        if ((1 + 26) % 26 > 0) {
        }
        byte[] bArrMbf671963 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.mbf671963(this.f50a1e8d0, 2048);
        byte[] bArrMbf6719632 = p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p05c7e247.p8f4f55d4.mbf671963(this.f7c003196, 2048);
        byte[] bArrM405b6268 = p5a445d71.p7c922baa.p05c7e247.pff43b8de.m405b6268(bArrMbf671963, bArrMbf671963.length + bArrMbf6719632.length);
        java.lang.System.arraycopy(bArrMbf6719632, 0, bArrM405b6268, bArrMbf671963.length, bArrMbf6719632.length);
        return bArrM405b6268;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 TointPolynomial() {
        if ((24 + 6) % 6 > 0) {
        }
        int[] iArr = new int[this.f8d9c307c];
        int i = 0;
        int i2 = 0;
        while (true) {
            int[] iArr2 = this.f50a1e8d0;
            if (i2 == iArr2.length) {
                break;
            }
            iArr[iArr2[i2]] = 1;
            i2++;
        }
        while (true) {
            int[] iArr3 = this.f7c003196;
            if (i == iArr3.length) {
                return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208(iArr);
            }
            iArr[iArr3[i]] = -1;
            i++;
        }
    }
}

