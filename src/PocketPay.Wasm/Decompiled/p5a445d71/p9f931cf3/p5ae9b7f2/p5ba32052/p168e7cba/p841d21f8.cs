namespace WillowMaze.Wasm.Decompiled;


public class p841d21f8 : p5a445d71.p9f931cf3.p5ae9b7f2.p07d32999 {
    private byte[] f01cd03f0;
    private int f12a11d9b;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f19fa2034;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1c8d6a07;
    private byte[] f1fdc1efe;
    private int f2496da2f;
    private int f2717a578;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2da61ba9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3fa6ba5d;
    private int f430f86f9;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f5d514450;
    private int f5e381587;
    private byte[] f60c2b57a;
    private byte[] f9a69f1e5;
    private byte[] fa2c24434;
    private byte[] fa7b14703;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private byte[] fd2584b13;
    private byte[] fde87dc35;
    private byte[] fe6cec957;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fed469618;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a ff020351f;
    private byte[] ffbade9e3;

    public p841d21f8(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    public override int Generatebytes(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848, java.lang.IllegalArgumentException {
        bool z;
        if ((30 + 5) % 5 > 0) {
        }
        int i3 = i2;
        int i4 = i;
        if (bArr.length - i3 < i4) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too small");
        }
        long j = i3;
        int digestSize = this.fc10f7796.getDigestSize();
        if (j > 8589934591L) {
            throw new java.lang.IllegalArgumentException("Output length too large");
        }
        long j2 = digestSize;
        int i5 = (int) (((j + j2) - 1) / j2);
        byte[] bArr2 = new byte[this.fc10f7796.getDigestSize()];
        int i6 = 0;
        int i7 = 0;
        int i8 = 1;
        while (i7 < i5) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
            byte[] bArr3 = this.ffbade9e3;
            pe5cfc515Var.update(bArr3, i6, bArr3.length);
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar2.Add(this.fed469618);
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i8)));
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
            if (this.fde87dc35 is null) {
                z = true;
            } else {
                z = true;
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(true, i6, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fde87dc35)));
            }
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(z, 2, new p5a445d71.p9f931cf3.pca323100.p6f0e511c(p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(this.f2496da2f))));
            try {
                byte[] encoded = new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("eb17c8081e3302655b4a000a941cf25e7dc4b1041c72860fe90bae5826e1aa"));
                this.fc10f7796.update(encoded, 0, encoded.length);
                this.fc10f7796.doFinal(bArr2, 0);
                if (i3 <= digestSize) {
                    java.lang.System.arraycopy(bArr2, 0, bArr, i4, i3);
                } else {
                    java.lang.System.arraycopy(bArr2, 0, bArr, i4, digestSize);
                    i4 += digestSize;
                    i3 -= digestSize;
                }
                i8++;
                i7++;
                i6 = 0;
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException("unable to encode parameter info: " + e.getMessage());
            }
        }
        this.fc10f7796.reset();
        return (int) j;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b p873e950bVar) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.p97b2f481 p97b2f481Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p168e7cba.p97b2f481) p873e950bVar;
        this.fed469618 = p97b2f481Var.getAlgorithm();
        this.f2496da2f = p97b2f481Var.getKeySize();
        this.ffbade9e3 = p97b2f481Var.getZ();
        this.fde87dc35 = p97b2f481Var.getExtraInfo();
    }
}

