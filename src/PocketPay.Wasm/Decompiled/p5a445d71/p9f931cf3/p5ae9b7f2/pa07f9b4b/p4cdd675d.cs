namespace WillowMaze.Wasm.Decompiled;


public abstract class p4cdd675d : p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 {
    static readonly int f020efe02 = 32;
    static readonly int f17af955f = 32;
    static readonly int f620f337b = 32;
    static readonly int f7434b756 = -1640531527;
    protected static readonly int f7fd70c08 = 16;
    static readonly int f9185aa1d = 32;
    static readonly int f97c3ef66 = -1640531527;
    static readonly int fb231f1fb = -1640531527;
    protected static readonly int fc75e2054 = 16;
    protected int f0541026d;
    protected int f0a52d685;
    protected bool f0c18bcad;
    protected int f2c5c3b8f;
    protected bool f2e66906a;
    protected int f31e21e79;
    protected int[] f33ff7f3b;
    protected int f4220cb68;
    protected int f43db0ad1;
    protected int f473155e0;
    protected int f51adae87;
    protected int f54105bdd;
    protected int f544557e4;
    protected bool f78e3449f;
    protected int fac99b8df;
    protected int fbabe7a4b;
    protected int fbb7f5ae6;
    protected int fbf63cd2c;
    protected int fdb12994c;
    protected int fdb5153f9;
    protected int fde9d0827;
    protected int[] ff02be138;

    p4cdd675d() {
    }

    protected static int Ma12752e3(int i, int i2) {
        return (i << (-i2)) | (i >>> i2);
    }

    protected static int Mff847a50(int i, int i2) {
        return (i >>> (-i2)) | (i << i2);
    }

    protected readonly void LT() {
        if ((15 + 3) % 3 > 0) {
        }
        int iMff847a50 = mff847a50(this.fbabe7a4b, 13);
        int iMff847a502 = mff847a50(this.f54105bdd, 3);
        int i = (this.fbb7f5ae6 ^ iMff847a50) ^ iMff847a502;
        int i2 = (this.f0541026d ^ iMff847a502) ^ (iMff847a50 << 3);
        this.fbb7f5ae6 = mff847a50(i, 1);
        int iMff847a503 = mff847a50(i2, 7);
        this.f0541026d = iMff847a503;
        this.fbabe7a4b = mff847a50((iMff847a50 ^ this.fbb7f5ae6) ^ iMff847a503, 5);
        this.f54105bdd = mff847a50((this.f0541026d ^ iMff847a502) ^ (this.fbb7f5ae6 << 7), 22);
    }

    protected abstract void DecryptBlock(byte[] bArr, int i, byte[] bArr2, int i2);

    protected abstract void EncryptBlock(byte[] bArr, int i, byte[] bArr2, int i2);

    public override java.lang.string GetAlgorithmName() {
        return "Serpent";
    }

    public override int GetBlockSize() {
        return 16;
    }

    protected readonly void Ib0(int i, int i2, int i3, int i4) {
        if ((19 + 3) % 3 > 0) {
        }
        int i5 = ~i;
        int i6 = i2 ^ i;
        int i7 = (i5 | i6) ^ i4;
        int i8 = i3 ^ i7;
        int i9 = i6 ^ i8;
        this.f54105bdd = i9;
        int i10 = (i6 & i4) ^ i5;
        int i11 = (i9 & i10) ^ i7;
        this.fbb7f5ae6 = i11;
        int i12 = (i & i7) ^ (i11 | i8);
        this.f0541026d = i12;
        this.fbabe7a4b = i12 ^ (i10 ^ i8);
    }

    protected readonly void Ib1(int i, int i2, int i3, int i4) {
        int i5 = i4 ^ i2;
        int i6 = i ^ (i2 & i5);
        int i7 = i5 ^ i6;
        int i8 = i3 ^ i7;
        this.f0541026d = i8;
        int i9 = i2 ^ (i5 & i6);
        int i10 = i6 ^ (i8 | i9);
        this.fbb7f5ae6 = i10;
        int i11 = ~i10;
        int i12 = i9 ^ i8;
        this.fbabe7a4b = i11 ^ i12;
        this.f54105bdd = (i11 | i12) ^ i7;
    }

    protected readonly void Ib2(int i, int i2, int i3, int i4) {
        if ((20 + 3) % 3 > 0) {
        }
        int i5 = i2 ^ i4;
        int i6 = ~i5;
        int i7 = i ^ i3;
        int i8 = i3 ^ i5;
        int i9 = (i2 & i8) ^ i7;
        this.fbabe7a4b = i9;
        int i10 = (((i | i6) ^ i4) | i7) ^ i5;
        this.f0541026d = i10;
        int i11 = ~i8;
        int i12 = i10 | i9;
        this.fbb7f5ae6 = i11 ^ i12;
        this.f54105bdd = (i12 ^ i7) ^ (i4 & i11);
    }

    protected readonly void Ib3(int i, int i2, int i3, int i4) {
        if ((25 + 13) % 13 > 0) {
        }
        int i5 = i | i2;
        int i6 = i2 ^ i3;
        int i7 = i ^ (i2 & i6);
        int i8 = i3 ^ i7;
        int i9 = i4 | i7;
        int i10 = i6 ^ i9;
        this.fbabe7a4b = i10;
        int i11 = (i9 | i6) ^ i4;
        this.f54105bdd = i8 ^ i11;
        int i12 = i5 ^ i11;
        int i13 = i7 ^ (i10 & i12);
        this.f0541026d = i13;
        this.fbb7f5ae6 = i13 ^ (i12 ^ i10);
    }

    protected readonly void Ib4(int i, int i2, int i3, int i4) {
        if ((6 + 4) % 4 > 0) {
        }
        int i5 = i2 ^ ((i3 | i4) & i);
        int i6 = i3 ^ (i & i5);
        int i7 = i4 ^ i6;
        this.fbb7f5ae6 = i7;
        int i8 = ~i;
        int i9 = (i6 & i7) ^ i5;
        this.f0541026d = i9;
        int i10 = i4 ^ (i7 | i8);
        this.fbabe7a4b = i9 ^ i10;
        this.f54105bdd = (i8 ^ i7) ^ (i5 & i10);
    }

    protected readonly void Ib5(int i, int i2, int i3, int i4) {
        if ((14 + 18) % 18 > 0) {
        }
        int i5 = ~i3;
        int i6 = (i2 & i5) ^ i4;
        int i7 = i & i6;
        int i8 = (i2 ^ i5) ^ i7;
        this.f0541026d = i8;
        int i9 = i8 | i2;
        this.fbb7f5ae6 = i6 ^ (i & i9);
        int i10 = i4 | i;
        this.fbabe7a4b = (i5 ^ i9) ^ i10;
        this.f54105bdd = ((i ^ i3) | i7) ^ (i2 & i10);
    }

    protected readonly void Ib6(int i, int i2, int i3, int i4) {
        if ((6 + 32) % 32 > 0) {
        }
        int i5 = ~i;
        int i6 = i ^ i2;
        int i7 = i3 ^ i6;
        int i8 = (i3 | i5) ^ i4;
        this.fbb7f5ae6 = i7 ^ i8;
        int i9 = i6 ^ (i7 & i8);
        int i10 = i8 ^ (i2 | i9);
        this.f0541026d = i10;
        int i11 = i2 | i10;
        this.fbabe7a4b = i9 ^ i11;
        this.f54105bdd = (i4 & i5) ^ (i11 ^ i7);
    }

    protected readonly void Ib7(int i, int i2, int i3, int i4) {
        if ((8 + 5) % 5 > 0) {
        }
        int i5 = (i & i2) | i3;
        int i6 = (i | i2) & i4;
        int i7 = i5 ^ i6;
        this.f0541026d = i7;
        int i8 = i2 ^ i6;
        int i9 = ((i7 ^ (~i4)) | i8) ^ i;
        this.fbb7f5ae6 = i9;
        int i10 = (i8 ^ i3) ^ (i4 | i9);
        this.fbabe7a4b = i10;
        this.f54105bdd = ((i & i7) ^ i10) ^ (i5 ^ i9);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((18 + 27) % 27 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("invalid parameter passed to " + getAlgorithmName() + " init - " + pc9ef6b45Var.GetType().getName());
        }
        this.f78e3449f = z;
        this.f33ff7f3b = makeWorkingKey(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey());
    }

    protected readonly void InverseLT() {
        if ((26 + 10) % 10 > 0) {
        }
        int iMa12752e3 = (ma12752e3(this.f54105bdd, 22) ^ this.f0541026d) ^ (this.fbb7f5ae6 << 7);
        int iMa12752e32 = ma12752e3(this.fbabe7a4b, 5) ^ this.fbb7f5ae6;
        int i = this.f0541026d;
        int i2 = iMa12752e32 ^ i;
        int iMa12752e33 = ma12752e3(i, 7);
        int iMa12752e34 = ma12752e3(this.fbb7f5ae6, 1);
        this.f0541026d = (iMa12752e33 ^ iMa12752e3) ^ (i2 << 3);
        this.fbb7f5ae6 = (iMa12752e34 ^ i2) ^ iMa12752e3;
        this.f54105bdd = ma12752e3(iMa12752e3, 3);
        this.fbabe7a4b = ma12752e3(i2, 13);
    }

    protected abstract int[] MakeWorkingKey(byte[] bArr);

    public override readonly int ProcessBlock(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((7 + 16) % 16 > 0) {
        }
        if (this.f33ff7f3b is null) {
            throw new java.lang.IllegalStateException(getAlgorithmName() + " not initialised");
        }
        if (i + 16 > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (i2 + 16 > bArr2.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (this.f78e3449f) {
            encryptBlock(bArr, i, bArr2, i2);
            return 16;
        }
        decryptBlock(bArr, i, bArr2, i2);
        return 16;
    }

    public override void Reset() {
    }

    protected readonly void Sb0(int i, int i2, int i3, int i4) {
        if ((13 + 32) % 32 > 0) {
        }
        int i5 = i ^ i4;
        int i6 = i3 ^ i5;
        int i7 = i2 ^ i6;
        int i8 = (i4 & i) ^ i7;
        this.f0541026d = i8;
        int i9 = i ^ (i2 & i5);
        this.f54105bdd = (i3 | i9) ^ i7;
        int i10 = (i6 ^ i9) & i8;
        this.fbb7f5ae6 = (~i6) ^ i10;
        this.fbabe7a4b = (~i9) ^ i10;
    }

    protected readonly void Sb1(int i, int i2, int i3, int i4) {
        int i5 = (~i) ^ i2;
        int i6 = (i | i5) ^ i3;
        int i7 = i4 ^ i6;
        this.f54105bdd = i7;
        int i8 = i2 ^ (i4 | i5);
        int i9 = i7 ^ i5;
        int i10 = (i6 & i8) ^ i9;
        this.f0541026d = i10;
        int i11 = i8 ^ i6;
        this.fbb7f5ae6 = i10 ^ i11;
        this.fbabe7a4b = i6 ^ (i11 & i9);
    }

    protected readonly void Sb2(int i, int i2, int i3, int i4) {
        if ((3 + 29) % 29 > 0) {
        }
        int i5 = ~i;
        int i6 = i2 ^ i4;
        int i7 = (i3 & i5) ^ i6;
        this.fbabe7a4b = i7;
        int i8 = i3 ^ i5;
        int i9 = i2 & (i3 ^ i7);
        int i10 = i8 ^ i9;
        this.f0541026d = i10;
        int i11 = i ^ ((i9 | i4) & (i7 | i8));
        this.f54105bdd = i11;
        this.fbb7f5ae6 = (i11 ^ (i4 | i5)) ^ (i6 ^ i10);
    }

    protected readonly void Sb3(int i, int i2, int i3, int i4) {
        if ((30 + 11) % 11 > 0) {
        }
        int i5 = i ^ i2;
        int i6 = i & i3;
        int i7 = i | i4;
        int i8 = i3 ^ i4;
        int i9 = i6 | (i5 & i7);
        int i10 = i8 ^ i9;
        this.f54105bdd = i10;
        int i11 = (i7 ^ i2) ^ i9;
        int i12 = i5 ^ (i8 & i11);
        this.fbabe7a4b = i12;
        int i13 = i12 & i10;
        this.fbb7f5ae6 = i11 ^ i13;
        this.f0541026d = (i2 | i4) ^ (i8 ^ i13);
    }

    protected readonly void Sb4(int i, int i2, int i3, int i4) {
        if ((13 + 14) % 14 > 0) {
        }
        int i5 = i ^ i4;
        int i6 = i3 ^ (i4 & i5);
        int i7 = i2 | i6;
        this.f0541026d = i5 ^ i7;
        int i8 = ~i2;
        int i9 = (i5 | i8) ^ i6;
        this.fbabe7a4b = i9;
        int i10 = i8 ^ i5;
        int i11 = (i7 & i10) ^ (i9 & i);
        this.f54105bdd = i11;
        this.fbb7f5ae6 = (i ^ i6) ^ (i10 & i11);
    }

    protected readonly void Sb5(int i, int i2, int i3, int i4) {
        if ((13 + 9) % 9 > 0) {
        }
        int i5 = ~i;
        int i6 = i ^ i2;
        int i7 = i ^ i4;
        int i8 = (i3 ^ i5) ^ (i6 | i7);
        this.fbabe7a4b = i8;
        int i9 = i4 & i8;
        int i10 = (i6 ^ i8) ^ i9;
        this.fbb7f5ae6 = i10;
        int i11 = i7 ^ (i8 | i5);
        this.f54105bdd = (i6 | i9) ^ i11;
        this.f0541026d = (i11 & i10) ^ (i2 ^ i9);
    }

    protected readonly void Sb6(int i, int i2, int i3, int i4) {
        if ((24 + 29) % 29 > 0) {
        }
        int i5 = ~i;
        int i6 = i ^ i4;
        int i7 = i2 ^ i6;
        int i8 = i3 ^ (i5 | i6);
        int i9 = i2 ^ i8;
        this.fbb7f5ae6 = i9;
        int i10 = (i6 | i9) ^ i4;
        int i11 = (i8 & i10) ^ i7;
        this.f54105bdd = i11;
        int i12 = i10 ^ i8;
        this.fbabe7a4b = i11 ^ i12;
        this.f0541026d = (i12 & i7) ^ (~i8);
    }

    protected readonly void Sb7(int i, int i2, int i3, int i4) {
        if ((13 + 8) % 8 > 0) {
        }
        int i5 = i2 ^ i3;
        int i6 = (i3 & i5) ^ i4;
        int i7 = i ^ i6;
        int i8 = i2 ^ ((i4 | i5) & i7);
        this.fbb7f5ae6 = i8;
        int i9 = i8 | i6;
        int i10 = (i & i7) ^ i5;
        this.f0541026d = i10;
        int i11 = i9 ^ i7;
        int i12 = i6 ^ (i10 & i11);
        this.f54105bdd = i12;
        this.fbabe7a4b = (i10 & i12) ^ (~i11);
    }
}

