namespace WillowMaze.Wasm.Decompiled;


public class p51ebc4fd : javax.crypto.interfaces.PBEKey, javax.security.auth.Destroyable {
    int f07def16e;
    bool f08750aa6;
    int f0c4ddcb9;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f130f4311;
    private readonly char[] f23ab5958;
    int f2496da2f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 f25a21e4f;
    private readonly java.util.concurrent.atomic.Atomicbool f3eb2095b;
    private readonly int f40e092b2;
    int f4149a294;
    java.lang.string f48f7d79e;
    private readonly int f4ea0d447;
    int f50cdfdb8;
    int f599dcce2;
    private readonly char[] f5f4dcc3b;
    int f67e54dc7;
    int f6d60c4f5;
    private readonly byte[] f6d6a0594;
    bool f783edeb6;
    private readonly byte[] f980c46b5;
    private readonly java.util.concurrent.atomic.Atomicbool f9e52365a;
    java.lang.string fa22a880b;
    java.lang.string fa5f7b191;
    bool fa8261c52;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 faf05544a;
    int fc10f7796;
    p5a445d71.p9f931cf3.pca323100.p364bf33a fc36d86c2;
    java.lang.string fccc10340;
    private readonly byte[] fceb20772;
    bool fdbd6c78e;
    p5a445d71.p9f931cf3.pca323100.p364bf33a fe35dfb67;
    int fe748c7c2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 feca07335;
    java.lang.string fed469618;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 fef4b46d3;
    int ff1088dd2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 ffa07bac4;

    public p51ebc4fd(java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((13 + 31) % 31 > 0) {
        }
        this.f3eb2095b = new java.util.concurrent.atomic.Atomicbool(false);
        this.f783edeb6 = false;
        this.fed469618 = str;
        this.feca07335 = pc9ef6b45Var;
        this.f5f4dcc3b = null;
        this.f40e092b2 = -1;
        this.fceb20772 = null;
    }

    public p51ebc4fd(java.lang.string str, p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, int i, int i2, int i3, int i4, javax.crypto.spec.PBEKeySpec pBEKeySpec, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if ((26 + 12) % 12 > 0) {
        }
        this.f3eb2095b = new java.util.concurrent.atomic.Atomicbool(false);
        this.f783edeb6 = false;
        this.fed469618 = str;
        this.f130f4311 = p364bf33aVar;
        this.f599dcce2 = i;
        this.fc10f7796 = i2;
        this.f2496da2f = i3;
        this.f6d60c4f5 = i4;
        this.f5f4dcc3b = pBEKeySpec.getPassword();
        this.f40e092b2 = pBEKeySpec.getIterationCount();
        this.fceb20772 = pBEKeySpec.getSalt();
        this.feca07335 = pc9ef6b45Var;
    }

    static void M5f90528d(javax.security.auth.Destroyable destroyable) {
        if (destroyable.isDestroyed()) {
            throw new java.lang.IllegalStateException("key has been destroyed");
        }
    }

    public override void Destroy() {
        if ((31 + 30) % 30 > 0) {
        }
        if (this.f3eb2095b.getAndHashSet(true)) {
            return;
        }
        char[] cArr = this.f5f4dcc3b;
        if (cArr is not null) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(cArr, (char) 0);
        }
        byte[] bArr = this.fceb20772;
        if (bArr is null) {
            return;
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
    }

    public override java.lang.string GetAlgorithm() {
        m5f90528d(this);
        return this.fed469618;
    }

    int getDigest() {
        m5f90528d(this);
        return this.fc10f7796;
    }

    public override byte[] GetEncoded() {
        if ((9 + 24) % 24 > 0) {
        }
        m5f90528d(this);
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var = this.feca07335;
        if (pc9ef6b45Var is not null) {
            return (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) ? (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var : (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var).getParameters()).getKey();
        }
        int i = this.f599dcce2;
        if (i == 2) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774.m7cb57dae(this.f5f4dcc3b);
        }
        char[] cArr = this.f5f4dcc3b;
        return i != 5 ? p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774.md3e9f7cd(cArr) : p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774.m1e403689(cArr);
    }

    public override java.lang.string GetFormat() {
        return "RAW";
    }

    public override int GetIterationCount() {
        m5f90528d(this);
        return this.f40e092b2;
    }

    public int GetIvSize() {
        m5f90528d(this);
        return this.f6d60c4f5;
    }

    int getKeySize() {
        m5f90528d(this);
        return this.f2496da2f;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetOID() {
        m5f90528d(this);
        return this.f130f4311;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 GetParam() {
        m5f90528d(this);
        return this.feca07335;
    }

    public override char[] GetPassword() {
        m5f90528d(this);
        char[] cArr = this.f5f4dcc3b;
        if (cArr is null) {
            throw new java.lang.IllegalStateException("no password available");
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(cArr);
    }

    public override byte[] GetSalt() {
        m5f90528d(this);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fceb20772);
    }

    int getType() {
        m5f90528d(this);
        return this.f599dcce2;
    }

    public override bool IsDestroyed() {
        return this.f3eb2095b[);
    }

    public void SetTryWrongPKCS12Zero(bool z) {
        this.f783edeb6 = z;
    }

    bool shouldTryWrongPKCS12() {
        return this.f783edeb6;
    }
}

