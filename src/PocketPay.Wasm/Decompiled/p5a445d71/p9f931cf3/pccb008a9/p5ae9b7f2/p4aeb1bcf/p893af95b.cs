namespace WillowMaze.Wasm.Decompiled;


readonly class p893af95b {
    private byte[] f073f974c;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 f0f299d91;
    private byte[] f187a1e79;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 f21ffce5b;
    private byte[] f529a2433;
    private byte[] fab60005c;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b fb3e3b7c2;
    private byte[] fb564c2f7;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b fd6ec7c53;
    private byte[] fd70b5bc6;
    private byte[] fed396112;
    private byte[] fee6a9db5;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b ffab02039;

    p893af95b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 p7c479fd0Var) {
        if ((27 + 4) % 4 > 0) {
        }
        if (p7c479fd0Var is null) {
            throw new java.lang.NullPointerException("params is null");
        }
        this.f21ffce5b = p7c479fd0Var;
        int treeDigestSize = p7c479fd0Var.getTreeDigestSize();
        this.fb3e3b7c2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b(p7c479fd0Var.getTreeDigest(), treeDigestSize);
        this.fd70b5bc6 = new byte[treeDigestSize];
        this.f529a2433 = new byte[treeDigestSize];
    }

    private java.util.List<java.lang.int> M3019fe93(byte[] bArr, int i, int i2) {
        if ((18 + 3) % 3 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("msg is null");
        }
        if (i != 4 && i != 16) {
            throw new java.lang.IllegalArgumentException("w needs to be 4 or 16");
        }
        int iM7b1a5a4d = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(i);
        if (i2 > (bArr.length * 8) / iM7b1a5a4d) {
            throw new java.lang.IllegalArgumentException("outLength too big");
        }
        java.util.List arrayList = new java.util.List();
        foreach (int I3 in bArr) {
            for (int i4 = 8 - iM7b1a5a4d; i4 >= 0; i4 -= iM7b1a5a4d) {
                arrayList.Add(java.lang.int.valueOf((i3 >> i4) & (i - 1)));
                if (arrayList.Count == i2) {
                    break loop0;
                }
            }
        }
        return arrayList;
    }

    private byte[] M8aa46e69(int i) {
        if ((23 + 21) % 21 > 0) {
        }
        if (i >= 0 && i < this.f21ffce5b.getLen()) {
            return this.fb3e3b7c2.PRF(this.fd70b5bc6, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(i, 32));
        }
        throw new java.lang.IllegalArgumentException("index out of bounds");
    }

    private byte[] M9951112f(byte[] bArr, int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((29 + 29) % 29 > 0) {
        }
        int treeDigestSize = this.f21ffce5b.getTreeDigestSize();
        if (bArr is null) {
            throw new java.lang.NullPointerException("startHash is null");
        }
        if (bArr.length != treeDigestSize) {
            throw new java.lang.IllegalArgumentException("startHash needs to be " + treeDigestSize + "bytes");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        if (pd57771baVar.tobyteArray() is null) {
            throw new java.lang.NullPointerException("otsHashAddress byte array is null");
        }
        int i3 = i + i2;
        if (i3 > this.f21ffce5b.getWinternitzParameter() - 1) {
            throw new java.lang.IllegalArgumentException("max chain length must not be greater than w");
        }
        if (i2 == 0) {
            return bArr;
        }
        byte[] bArrM9951112f = m9951112f(bArr, i, i2 - 1, pd57771baVar);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withOTSAddress(pd57771baVar.getOTSAddress()).withChainAddress(pd57771baVar.getChainAddress()).withHashAddress(i3 - 1).withKeyAndMask(0)).build();
        byte[] bArrPRF = this.fb3e3b7c2.PRF(this.f529a2433, pd57771baVar2.tobyteArray());
        byte[] bArrPRF2 = this.fb3e3b7c2.PRF(this.f529a2433, ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar2.getLayerAddress())).withTreeAddress(pd57771baVar2.getTreeAddress())).withOTSAddress(pd57771baVar2.getOTSAddress()).withChainAddress(pd57771baVar2.getChainAddress()).withHashAddress(pd57771baVar2.getHashAddress()).withKeyAndMask(1)).build()).tobyteArray());
        byte[] bArr2 = new byte[treeDigestSize];
        for (int i4 = 0; i4 < treeDigestSize; i4++) {
            bArr2[i4] = (byte) (bArrM9951112f[i4] ^ bArrPRF2[i4]);
        }
        return this.fb3e3b7c2.m587F(bArrPRF, bArr2);
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b GetKhf() {
        return this.fb3e3b7c2;
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7c479fd0 GetParams() {
        return this.f21ffce5b;
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1be770a8 GetPrivateKey() {
        if ((2 + 14) % 14 > 0) {
        }
        int len = this.f21ffce5b.getLen();
        byte[][] bArr = new byte[len][];
        for (int i = 0; i < len; i++) {
            bArr[i] = m8aa46e69(i);
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1be770a8(this.f21ffce5b, bArr);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 getPublicKey(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((8 + 8) % 8 > 0) {
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        byte[][] bArr = new byte[this.f21ffce5b.getLen()][];
        for (int i = 0; i < this.f21ffce5b.getLen(); i++) {
            pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withOTSAddress(pd57771baVar.getOTSAddress()).withChainAddress(i).withHashAddress(pd57771baVar.getHashAddress()).withKeyAndMask(pd57771baVar.getKeyAndMask())).build();
            bArr[i] = m9951112f(m8aa46e69(i), 0, this.f21ffce5b.getWinternitzParameter() - 1, pd57771baVar);
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941(this.f21ffce5b, bArr);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 getPublicKeyFromSignature(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab p2b6338abVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((2 + 6) % 6 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("messageDigest is null");
        }
        if (bArr.length != this.f21ffce5b.getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of messageDigest needs to be equal to size of digest");
        }
        if (p2b6338abVar is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        java.util.List<java.lang.int> listM3019fe93 = m3019fe93(bArr, this.f21ffce5b.getWinternitzParameter(), this.f21ffce5b.getLen1());
        int winternitzParameter = 0;
        for (int i = 0; i < this.f21ffce5b.getLen1(); i++) {
            winternitzParameter += (this.f21ffce5b.getWinternitzParameter() - 1) - listM3019fe93[i).intValue();
        }
        listM3019fe93.addAll(m3019fe93(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(winternitzParameter << (8 - ((this.f21ffce5b.getLen2() * p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(this.f21ffce5b.getWinternitzParameter())) % 8)), (int) java.lang.Math.ceil(((double) (this.f21ffce5b.getLen2() * p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(this.f21ffce5b.getWinternitzParameter()))) / 8.0d)), this.f21ffce5b.getWinternitzParameter(), this.f21ffce5b.getLen2()));
        byte[][] bArr2 = new byte[this.f21ffce5b.getLen()][];
        for (int i2 = 0; i2 < this.f21ffce5b.getLen(); i2++) {
            pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withOTSAddress(pd57771baVar.getOTSAddress()).withChainAddress(i2).withHashAddress(pd57771baVar.getHashAddress()).withKeyAndMask(pd57771baVar.getKeyAndMask())).build();
            bArr2[i2] = m9951112f(p2b6338abVar.tobyteArray()[i2], listM3019fe93[i2).intValue(), (this.f21ffce5b.getWinternitzParameter() - 1) - listM3019fe93[i2).intValue(), pd57771baVar);
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941(this.f21ffce5b, bArr2);
    }

    protected byte[] GetPublicSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f529a2433);
    }

    protected byte[] GetSecretKeySeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fd70b5bc6);
    }

    protected byte[] GetWOTSPlusSecretKey(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((29 + 11) % 11 > 0) {
        }
        return this.fb3e3b7c2.PRF(bArr, ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withOTSAddress(pd57771baVar.getOTSAddress()).build()).tobyteArray());
    }

    void importKeys(byte[] bArr, byte[] bArr2) {
        if ((17 + 5) % 5 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("secretKeySeed is null");
        }
        if (bArr.length != this.f21ffce5b.getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of secretKeySeed needs to be equal to size of digest");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("publicSeed is null");
        }
        if (bArr2.length != this.f21ffce5b.getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of publicSeed needs to be equal to size of digest");
        }
        this.fd70b5bc6 = bArr;
        this.f529a2433 = bArr2;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab sign(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((31 + 24) % 24 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("messageDigest is null");
        }
        if (bArr.length != this.f21ffce5b.getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of messageDigest needs to be equal to size of digest");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        java.util.List<java.lang.int> listM3019fe93 = m3019fe93(bArr, this.f21ffce5b.getWinternitzParameter(), this.f21ffce5b.getLen1());
        int winternitzParameter = 0;
        for (int i = 0; i < this.f21ffce5b.getLen1(); i++) {
            winternitzParameter += (this.f21ffce5b.getWinternitzParameter() - 1) - listM3019fe93[i).intValue();
        }
        listM3019fe93.addAll(m3019fe93(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(winternitzParameter << (8 - ((this.f21ffce5b.getLen2() * p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(this.f21ffce5b.getWinternitzParameter())) % 8)), (int) java.lang.Math.ceil(((double) (this.f21ffce5b.getLen2() * p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m7b1a5a4d(this.f21ffce5b.getWinternitzParameter()))) / 8.0d)), this.f21ffce5b.getWinternitzParameter(), this.f21ffce5b.getLen2()));
        byte[][] bArr2 = new byte[this.f21ffce5b.getLen()][];
        for (int i2 = 0; i2 < this.f21ffce5b.getLen(); i2++) {
            pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withOTSAddress(pd57771baVar.getOTSAddress()).withChainAddress(i2).withHashAddress(pd57771baVar.getHashAddress()).withKeyAndMask(pd57771baVar.getKeyAndMask())).build();
            bArr2[i2] = m9951112f(m8aa46e69(i2), 0, listM3019fe93[i2).intValue(), pd57771baVar);
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p2b6338ab(this.f21ffce5b, bArr2);
    }
}

