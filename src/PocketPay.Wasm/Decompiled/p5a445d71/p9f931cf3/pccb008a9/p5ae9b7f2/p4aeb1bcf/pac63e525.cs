namespace WillowMaze.Wasm.Decompiled;


public class pac63e525 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p1d7fb514 {
    private bool f06ca539e;
    private bool f17888afe;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f1a6400d5;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f21ffce5b;
    private bool f239b22ba;
    private bool f2656f976;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b f2c239bba;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f34026034;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f4054305b;
    private bool f4272f137;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f5468a9bc;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f56151174;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f5a149203;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 f6b5cc4eb;
    private bool f6d0eb648;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f86f0d060;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e f8b70c92e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f8b8bc6f2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fa4349eb1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b fa81d75eb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b fb3e3b7c2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 fbd0c8e3b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fc079fc4a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e fc36853ea;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 fc436d974;

    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab Mce75b5bb(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((16 + 18) % 18 > 0) {
        }
        if (bArr.length != this.f21ffce5b.getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of messageDigest needs to be equal to size of digest");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar = this.f8b8bc6f2;
        p893af95bVar.importKeys(p893af95bVar.getWOTSPlusSecretKey(this.fbd0c8e3b.getSecretKeySeed(), pd57771baVar), this.fbd0c8e3b.getPublicSeed());
        return this.f8b8bc6f2.sign(bArr, pd57771baVar);
    }

    public override byte[] GenerateSignature(byte[] bArr) {
        byte[] byteArray;
        if ((26 + 20) % 20 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        if (!this.f239b22ba) {
            throw new java.lang.IllegalStateException("signer not initialized for signature generation");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var = this.fbd0c8e3b;
        if (p823c49a3Var is null) {
            throw new java.lang.IllegalStateException("signing key no longer usable");
        }
        lock (p823c49a3Var) {
            try {
                if (this.fbd0c8e3b.getUsagesRemaining() <= 0) {
                    throw new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p88ef534c("no usages of private key remaining");
                }
                if (this.fbd0c8e3b.getBDSState().getAuthenticationPath().Count == 0) {
                    throw new java.lang.IllegalStateException("not initialized");
                }
                try {
                    int index = this.fbd0c8e3b.getIndex();
                    this.f4272f137 = true;
                    long j = index;
                    byte[] bArrPRF = this.fb3e3b7c2.PRF(this.fbd0c8e3b.getSecretKeyPRF(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(j, 32));
                    byteArray = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b(this.f21ffce5b).withIndex(index).withRandom(bArrPRF).withWOTSPlusSignature(mce75b5bb(this.fb3e3b7c2.HMsg(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArrPRF, this.fbd0c8e3b.getRoot(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(j, this.f21ffce5b.getTreeDigestSize())), bArr), (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withOTSAddress(index).build())).withAuthPath(this.fbd0c8e3b.getBDSState().getAuthenticationPath()).build().tobyteArray();
                    this.fbd0c8e3b.getBDSState().markUsed();
                    this.fbd0c8e3b.rollKey();
                } catch (java.lang.Exception th) {
                    this.fbd0c8e3b.getBDSState().markUsed();
                    this.fbd0c8e3b.rollKey();
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
        return byteArray;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetUpdatedPrivateKey() {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var;
        if ((7 + 1) % 1 > 0) {
        }
        lock (this.fbd0c8e3b) {
            try {
                if (this.f4272f137) {
                    p823c49a3Var = this.fbd0c8e3b;
                    this.fbd0c8e3b = null;
                } else {
                    p823c49a3Var = this.fbd0c8e3b;
                    if (p823c49a3Var is not null) {
                        this.fbd0c8e3b = p823c49a3Var.getNextKey();
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return p823c49a3Var;
    }

    public long GetUsagesRemaining() {
        if ((29 + 13) % 13 > 0) {
        }
        return this.fbd0c8e3b.getUsagesRemaining();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 parameters;
        if (z) {
            this.f239b22ba = true;
            this.f4272f137 = false;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3 p823c49a3Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3) pc9ef6b45Var;
            this.fbd0c8e3b = p823c49a3Var;
            parameters = p823c49a3Var.getParameters();
        } else {
            this.f239b22ba = false;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e pe1225d2eVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe1225d2e) pc9ef6b45Var;
            this.fc36853ea = pe1225d2eVar;
            parameters = pe1225d2eVar.getParameters();
        }
        this.f21ffce5b = parameters;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b wOTSPlus = this.f21ffce5b.getWOTSPlus();
        this.f8b8bc6f2 = wOTSPlus;
        this.fb3e3b7c2 = wOTSPlus.getKhf();
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        if ((25 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a pc46be95aVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pc46be95a$p2bd4a59b(this.f21ffce5b).withSignature(bArr2).build();
        int index = pc46be95aVarBuild.getIndex();
        this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fc36853ea.getPublicSeed());
        long j = index;
        byte[] bArrHMsg = this.fb3e3b7c2.HMsg(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(pc46be95aVarBuild.getRandom(), this.fc36853ea.getRoot(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(j, this.f21ffce5b.getTreeDigestSize())), bArr);
        int height = this.f21ffce5b.getHeight();
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p39a4afc8.m2e4c3620(this.f8b8bc6f2, height, bArrHMsg, pc46be95aVarBuild, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withOTSAddress(index).build(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(j, height)).getValue(), this.fc36853ea.getRoot());
    }
}

