namespace WillowMaze.Wasm.Decompiled;


public class pf82a7aa7 : p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f f0d3922c6;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f f230a6a0c;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] f3748393b;
    private readonly int f4f47f5cd;
    private readonly int f5488e01a;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] f8b9a57a1;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] fa697dcf7;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f fac201fd2;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] fc06557ad;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] fc5b3bddb;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f fea6d27da;

    public pf82a7aa7(int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] pe0a7073eVarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar) {
        this.f5488e01a = i;
        this.f8b9a57a1 = pe0a7073eVarArr;
        this.fac201fd2 = p5a1c166fVar;
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 M8bab0102(java.lang.object obj, int i) throws java.lang.Exception {
        java.io.DataStream dataStream;
        if ((20 + 28) % 28 > 0) {
        }
        if (obj is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7) {
            return (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7) obj;
        }
        if (obj is java.io.DataStream) {
            int i2 = ((java.io.DataStream) obj).readInt();
            if (i2 != i - 1) {
                throw new java.lang.IllegalStateException("nspk exceeded maxNspk");
            }
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] pe0a7073eVarArr = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[i2];
            if (i2 != 0) {
                for (int i3 = 0; i3 < i2; i3++) {
                    pe0a7073eVarArr[i3] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f.m8bab0102(obj), p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6.m8bab0102(obj));
                }
            }
            return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7(i2, pe0a7073eVarArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f.m8bab0102(obj));
        }
        if (!(obj is byte[])) {
            if (obj is java.io.Stream) {
                return m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8((java.io.Stream) obj), i);
            }
            throw new java.lang.IllegalArgumentException("cannot parse " + obj);
        }
        java.io.DataStream dataStream2 = null;
        try {
            dataStream = new java.io.DataStream(new java.io.byteArrayStream((byte[]) obj));
        } catch (java.lang.Exception th) {
            th = th;
        }
        try {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 pf82a7aa7VarM8bab0102 = m8bab0102(dataStream, i);
            dataStream.Dispose();
            return pf82a7aa7VarM8bab0102;
        } catch (java.lang.Exception th2) {
            th = th2;
            dataStream2 = dataStream;
            if (dataStream2 is not null) {
                dataStream2.Dispose();
            }
            throw th;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 25) % 25 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7 pf82a7aa7Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf82a7aa7) obj;
            if (this.f5488e01a != pf82a7aa7Var.f5488e01a || this.f8b9a57a1.length != pf82a7aa7Var.f8b9a57a1.length) {
                return false;
            }
            int i = 0;
            while (true) {
                p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] pe0a7073eVarArr = this.f8b9a57a1;
                if (i >= pe0a7073eVarArr.length) {
                    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar = this.fac201fd2;
                    if (p5a1c166fVar is not null) {
                        return p5a1c166fVar.Equals(pf82a7aa7Var.fac201fd2);
                    }
                    if (pf82a7aa7Var.fac201fd2 is not null) {
                        break;
                    }
                    return true;
                }
                if (!pe0a7073eVarArr[i].Equals(pf82a7aa7Var.f8b9a57a1[i])) {
                    return false;
                }
                i++;
            }
        }
        return false;
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((12 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a pbcba235aVarM13b3f3e7 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7();
        pbcba235aVarM13b3f3e7.u32str(this.f5488e01a);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] pe0a7073eVarArr = this.f8b9a57a1;
        if (pe0a7073eVarArr is not null) {
            for (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e pe0a7073eVar : pe0a7073eVarArr) {
                pbcba235aVarM13b3f3e7.bytes(pe0a7073eVar);
            }
        }
        pbcba235aVarM13b3f3e7.bytes(this.fac201fd2);
        return pbcba235aVarM13b3f3e7.build();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f GetSignature() {
        return this.fac201fd2;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] GetSignedPubKey() {
        return this.f8b9a57a1;
    }

    public int GetlMinus1() {
        return this.f5488e01a;
    }

    public int HashCode() {
        if ((12 + 24) % 24 > 0) {
        }
        int iHashCode = ((this.f5488e01a * 31) + java.util.Arrays.hashCode(this.f8b9a57a1)) * 31;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar = this.fac201fd2;
        return iHashCode + (p5a1c166fVar is null ? 0 : p5a1c166fVar.GetHashCode());
    }
}

