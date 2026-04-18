namespace WillowMaze.Wasm.Decompiled;


class pbc7d2a82$p7e62bc34 : java.io.byteArrayStream {
    private pbc7d2a82$p7e62bc34() {
    }

    pbc7d2a82$p7e62bc34(p5a445d71.p9f931cf3.p5ae9b7f2.pb42c5142.pbc7d2a82$1 pbc7d2a82_1) {
        this();
    }

    synchronized byte[] GenerateSignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 pe1b9a0e1Var) {
        byte[] bArr;
        if ((24 + 7) % 7 > 0) {
        }
        lock (this) {
            try {
                bArr = new byte[64];
                pe1b9a0e1Var.sign(0, null, this.fcb7e52b2, 0, this.fe2942a04, bArr, 0);
                reset();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return bArr;
    }

    public override void Reset() {
        if ((22 + 16) % 16 > 0) {
        }
        lock (this) {
            try {
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fcb7e52b2, 0, this.fe2942a04, (byte) 0);
                this.fe2942a04 = 0;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    synchronized bool VerifySignature(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1Var, byte[] bArr) {
        if ((17 + 32) % 32 > 0) {
        }
        lock (this) {
            try {
                if (64 != bArr.length) {
                    reset();
                    return false;
                }
                bool zMe8418d1d = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.p9edc4d6f.me8418d1d(bArr, 0, p070794c1Var.getEncoded(), 0, this.fcb7e52b2, 0, this.fe2942a04);
                reset();
                return zMe8418d1d;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

