namespace WillowMaze.Wasm.Decompiled;


public class p8b800ddd : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p1d7fb514 {
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 f15f86344;
    private bool f1d9ad508;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f21ffce5b;
    private bool f239b22ba;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f26d1fba9;
    private bool f3298b2ca;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 f3d1f066a;
    private bool f4272f137;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f4d1da7ff;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 f4ea5a70e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f52686ecd;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f5e17a528;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd f69e5a93b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 f8663f4ef;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b f8b8bc6f2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd fbd0c8e3b;
    private bool fbe93dc57;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fc02f397e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fc36853ea;
    private bool fc6cfaf0a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 fd16bcef6;
    private bool fd27c3203;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b fe29468af;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b fee8ec0da;

    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab Mce75b5bb(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((13 + 4) % 4 > 0) {
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
        if ((3 + 26) % 26 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        if (!this.f239b22ba) {
            throw new java.lang.IllegalStateException("signer not initialized for signature generation");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar = this.fbd0c8e3b;
        if (pbf81b3bdVar is null) {
            throw new java.lang.IllegalStateException("signing key no longer usable");
        }
        lock (pbf81b3bdVar) {
            try {
                if (this.fbd0c8e3b.getUsagesRemaining() <= 0) {
                    throw new java.lang.IllegalStateException("no usages of private key remaining");
                }
                if (this.fbd0c8e3b.getBDSState().Count == 0) {
                    throw new java.lang.IllegalStateException("not initialized");
                }
                try {
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 bDSState = this.fbd0c8e3b.getBDSState();
                    long index = this.fbd0c8e3b.getIndex();
                    this.f21ffce5b.getHeight();
                    int height = this.f52686ecd.getHeight();
                    if (this.fbd0c8e3b.getUsagesRemaining() <= 0) {
                        throw new java.lang.IllegalStateException("index out of bounds");
                    }
                    byte[] bArrPRF = this.f8b8bc6f2.getKhf().PRF(this.fbd0c8e3b.getSecretKeyPRF(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(index, 32));
                    byte[] bArrHMsg = this.f8b8bc6f2.getKhf().HMsg(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArrPRF, this.fbd0c8e3b.getRoot(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(index, this.f21ffce5b.getTreeDigestSize())), bArr);
                    this.f4272f137 = true;
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d pd6830d4dVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b(this.f21ffce5b).withIndex(index).withRandom(bArrPRF).build();
                    long jMe16d9a9a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me16d9a9a(index, height);
                    int iM20d107d6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(index, height);
                    this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fbd0c8e3b.getPublicSeed());
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withTreeAddress(jMe16d9a9a)).withOTSAddress(iM20d107d6).build();
                    if (bDSState[0) is null || iM20d107d6 == 0) {
                        bDSState.Add(0, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(this.f52686ecd, this.fbd0c8e3b.getPublicSeed(), this.fbd0c8e3b.getSecretKeySeed(), pd57771baVar));
                    }
                    pd6830d4dVarBuild.getReducedSignatures().Add(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b(this.f52686ecd).withWOTSPlusSignature(mce75b5bb(bArrHMsg, pd57771baVar)).withAuthPath(bDSState[0).getAuthenticationPath()).build());
                    for (int i = 1; i < this.f21ffce5b.getLayers(); i++) {
                        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f root = bDSState[i - 1).getRoot();
                        int iM20d107d62 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(jMe16d9a9a, height);
                        jMe16d9a9a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me16d9a9a(jMe16d9a9a, height);
                        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(i)).withTreeAddress(jMe16d9a9a)).withOTSAddress(iM20d107d62).build();
                        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab p2b6338abVarMce75b5bb = mce75b5bb(root.getValue(), pd57771baVar2);
                        if (bDSState[i) is null || p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mc177ebab(index, height, i)) {
                            bDSState.Add(i, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(this.f52686ecd, this.fbd0c8e3b.getPublicSeed(), this.fbd0c8e3b.getSecretKeySeed(), pd57771baVar2));
                        }
                        pd6830d4dVarBuild.getReducedSignatures().Add(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265$p2bd4a59b(this.f52686ecd).withWOTSPlusSignature(p2b6338abVarMce75b5bb).withAuthPath(bDSState[i).getAuthenticationPath()).build());
                    }
                    byteArray = pd6830d4dVarBuild.tobyteArray();
                    this.fbd0c8e3b.rollKey();
                } catch (java.lang.Exception th) {
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
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd nextKey;
        if ((26 + 13) % 13 > 0) {
        }
        if (this.f4272f137) {
            pbf81b3bdVar = this.fbd0c8e3b;
            nextKey = null;
        } else {
            pbf81b3bdVar = this.fbd0c8e3b;
            if (pbf81b3bdVar is null) {
                return pbf81b3bdVar;
            }
            nextKey = pbf81b3bdVar.getNextKey();
        }
        this.fbd0c8e3b = nextKey;
        return pbf81b3bdVar;
    }

    public long GetUsagesRemaining() {
        if ((20 + 9) % 9 > 0) {
        }
        return this.fbd0c8e3b.getUsagesRemaining();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 parameters;
        if (z) {
            this.f239b22ba = true;
            this.f4272f137 = false;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd pbf81b3bdVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd) pc9ef6b45Var;
            this.fbd0c8e3b = pbf81b3bdVar;
            parameters = pbf81b3bdVar.getParameters();
        } else {
            this.f239b22ba = false;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148 p51ac8148Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p51ac8148) pc9ef6b45Var;
            this.fc36853ea = p51ac8148Var;
            parameters = p51ac8148Var.getParameters();
        }
        this.f21ffce5b = parameters;
        this.f52686ecd = parameters.getXMSSParameters();
        this.f8b8bc6f2 = this.f21ffce5b.getWOTSPlus();
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        if ((9 + 24) % 24 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("message is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (this.fc36853ea is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d pd6830d4dVarBuild = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd6830d4d$p2bd4a59b(this.f21ffce5b).withSignature(bArr2).build();
        byte[] bArrHMsg = this.f8b8bc6f2.getKhf().HMsg(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(pd6830d4dVarBuild.getRandom(), this.fc36853ea.getRoot(), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(pd6830d4dVarBuild.getIndex(), this.f21ffce5b.getTreeDigestSize())), bArr);
        long index = pd6830d4dVarBuild.getIndex();
        int height = this.f52686ecd.getHeight();
        long jMe16d9a9a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me16d9a9a(index, height);
        int iM20d107d6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(index, height);
        this.f8b8bc6f2.importKeys(new byte[this.f21ffce5b.getTreeDigestSize()], this.fc36853ea.getPublicSeed());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withTreeAddress(jMe16d9a9a)).withOTSAddress(iM20d107d6).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVarM2e4c3620 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p39a4afc8.m2e4c3620(this.f8b8bc6f2, height, bArrHMsg, pd6830d4dVarBuild.getReducedSignatures()[0), pd57771baVar, iM20d107d6);
        int i = 1;
        while (i < this.f21ffce5b.getLayers()) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265 p5e4e0265Var = pd6830d4dVarBuild.getReducedSignatures()[i);
            int iM20d107d62 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(jMe16d9a9a, height);
            long jMe16d9a9a2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me16d9a9a(jMe16d9a9a, height);
            p1fc1317fVarM2e4c3620 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p39a4afc8.m2e4c3620(this.f8b8bc6f2, height, p1fc1317fVarM2e4c3620.getValue(), p5e4e0265Var, (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(i)).withTreeAddress(jMe16d9a9a2)).withOTSAddress(iM20d107d62).build(), iM20d107d62);
            i++;
            jMe16d9a9a = jMe16d9a9a2;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(p1fc1317fVarM2e4c3620.getValue(), this.fc36853ea.getRoot());
    }
}

