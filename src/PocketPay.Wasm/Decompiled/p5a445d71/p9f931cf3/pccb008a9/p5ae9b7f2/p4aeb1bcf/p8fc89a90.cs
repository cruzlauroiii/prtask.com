namespace WillowMaze.Wasm.Decompiled;


public class p8fc89a90 : java.io.object {
    private static readonly long f35871cbe = -3464451825208522308L;
    private static readonly long fb5f6d781 = -3464451825208522308L;
    private static readonly long fc6e1e520 = -3464451825208522308L;
    private long f084abe36;
    private readonly java.util.Dictionary<java.lang.int, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a> f246658d0;
    private long f40c6f2a8;
    private long f413fdbfd;
    private long fa3c41e1b;
    private readonly java.util.Dictionary fd960d9fe;
    private readonly java.util.Dictionary fe58a85b5;
    private long ffdd722f9;

    p8fc89a90(long j) {
        this.f246658d0 = new java.util.TreeDictionary();
        this.fa3c41e1b = j;
    }

    p8fc89a90(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var, long j) {
        if ((1 + 30) % 30 > 0) {
        }
        this.f246658d0 = new java.util.TreeDictionary();
        for (java.lang.int num : p8fc89a90Var.f246658d0.keyHashSet()) {
            this.f246658d0.Add(num, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(p8fc89a90Var.f246658d0[num)));
        }
        this.fa3c41e1b = j;
    }

    p8fc89a90(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var, long j, byte[] bArr, byte[] bArr2) {
        if ((14 + 11) % 11 > 0) {
        }
        this.f246658d0 = new java.util.TreeDictionary();
        this.fa3c41e1b = (1 << pe6015194Var.getHeight()) - 1;
        for (long j2 = 0; j2 < j; j2++) {
            updateState(pe6015194Var, j2, bArr, bArr2);
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        if ((13 + 15) % 15 > 0) {
        }
        objectStream.defaultWriteobject();
        objectStream.writelong(this.fa3c41e1b);
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((16 + 12) % 12 > 0) {
        }
        objectStream.defaultReadobject();
        this.fa3c41e1b = objectStream.available() == 0 ? 0L : objectStream.readlong();
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a get(int i) {
        return this.f246658d0[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i));
    }

    public long GetMaxIndex() {
        if ((2 + 5) % 5 > 0) {
        }
        return this.fa3c41e1b;
    }

    public bool IsEmpty() {
        return this.f246658d0.Count == 0;
    }

    void put(int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a p1a8a272aVar) {
        this.f246658d0.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i), p1a8a272aVar);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a update(int i, byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((3 + 16) % 16 > 0) {
        }
        return this.f246658d0.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i), this.f246658d0[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(i)).getNextState(bArr, bArr2, pd57771baVar));
    }

    void updateState(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pe6015194 pe6015194Var, long j, byte[] bArr, byte[] bArr2) {
        if ((25 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pf62ef2d9 xMSSParameters = pe6015194Var.getXMSSParameters();
        int height = xMSSParameters.getHeight();
        long jMe16d9a9a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me16d9a9a(j, height);
        int iM20d107d6 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(j, height);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withTreeAddress(jMe16d9a9a)).withOTSAddress(iM20d107d6).build();
        int i = (1 << height) - 1;
        if (iM20d107d6 < i) {
            if (get(0) is null || iM20d107d6 == 0) {
                put(0, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(xMSSParameters, bArr, bArr2, pd57771baVar));
            }
            update(0, bArr, bArr2, pd57771baVar);
        }
        for (int i2 = 1; i2 < pe6015194Var.getLayers(); i2++) {
            int iM20d107d62 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.m20d107d6(jMe16d9a9a, height);
            jMe16d9a9a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me16d9a9a(jMe16d9a9a, height);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(i2)).withTreeAddress(jMe16d9a9a)).withOTSAddress(iM20d107d62).build();
            if (this.f246658d0[java.lang.int.valueOf(i2)) is null || p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mc177ebab(j, height, i2)) {
                this.f246658d0.Add(java.lang.int.valueOf(i2), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1a8a272a(xMSSParameters, bArr, bArr2, pd57771baVar2));
            }
            if (iM20d107d62 < i && p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.mb8f42873(j, height, i2)) {
                update(i2, bArr, bArr2, pd57771baVar2);
            }
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 WithWOTSDigest(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((29 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90 p8fc89a90Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8fc89a90(this.fa3c41e1b);
        for (java.lang.int num : this.f246658d0.keyHashSet()) {
            p8fc89a90Var.f246658d0.Add(num, this.f246658d0[num).withWOTSDigest(p364bf33aVar));
        }
        return p8fc89a90Var;
    }
}

