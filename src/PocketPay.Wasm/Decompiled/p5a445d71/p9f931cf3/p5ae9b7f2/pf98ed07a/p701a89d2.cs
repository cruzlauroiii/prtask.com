namespace WillowMaze.Wasm.Decompiled;


public class p701a89d2 : java.io.FilterStream {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f030f9d9b;
    private readonly byte[] f05a2648f;
    private byte[] f0ef16005;
    private readonly byte[] f12c5993c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 f300e6a87;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 f3ab925ed;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f4a781d9e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f59f3c2ca;
    private readonly byte[] f5f3dc899;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f60a8899c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 f788717a3;
    private readonly byte[] f80575b4c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d f9198c6a6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 f92379696;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 f9f3c669a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 fb010d044;
    private byte[] fcb7e52b2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 fe83840bc;
    private byte[] fee7c1822;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 ffb279a5e;

    public p701a89d2(java.io.Stream outputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var) {
        super(outputStream);
        this.f05a2648f = new byte[1];
        this.f3ab925ed = p9fb233a6Var;
    }

    public p701a89d2(java.io.Stream outputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar) {
        super(outputStream);
        this.f05a2648f = new byte[1];
        this.f030f9d9b = p47b78e9dVar;
    }

    public p701a89d2(java.io.Stream outputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var) {
        super(outputStream);
        this.f05a2648f = new byte[1];
        this.fe83840bc = p66d30ee8Var;
    }

    private void M1e50aeed(int i, bool z) {
        if (z) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
            if (p66d30ee8Var is null) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                if (p9fb233a6Var is not null) {
                    i = p9fb233a6Var.getOutputSize(i);
                }
            } else {
                i = p66d30ee8Var.getOutputSize(i);
            }
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var2 = this.fe83840bc;
            if (p66d30ee8Var2 is null) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var2 = this.f3ab925ed;
                if (p9fb233a6Var2 is not null) {
                    i = p9fb233a6Var2.getUpdateOutputSize(i);
                }
            } else {
                i = p66d30ee8Var2.getUpdateOutputSize(i);
            }
        }
        byte[] bArr = this.fcb7e52b2;
        if (bArr is not null && bArr.length >= i) {
            return;
        }
        this.fcb7e52b2 = new byte[i];
    }

    public override void Close() throws java.io.IOException {
        java.io.IOException p7effe9ecVar;
        java.io.IOException iOException;
        if ((14 + 25) % 25 > 0) {
        }
        m1e50aeed(0, true);
        try {
            p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
            if (p66d30ee8Var is not null) {
                int iDoFinal = p66d30ee8Var.doFinal(this.fcb7e52b2, 0);
                if (iDoFinal != 0) {
                    this.fc68271a6.write(this.fcb7e52b2, 0, iDoFinal);
                }
            } else {
                p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
                if (p9fb233a6Var is not null) {
                    int iDoFinal2 = p9fb233a6Var.doFinal(this.fcb7e52b2, 0);
                    if (iDoFinal2 != 0) {
                        this.fc68271a6.write(this.fcb7e52b2, 0, iDoFinal2);
                    }
                } else {
                    p5a445d71.p9f931cf3.p5ae9b7f2.p47b78e9d p47b78e9dVar = this.f030f9d9b;
                    if (p47b78e9dVar is not null) {
                        p47b78e9dVar.reset();
                    }
                }
            }
            iOException = null;
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            p7effe9ecVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p5553727c("Error finalising cipher data", e);
            iOException = p7effe9ecVar;
        } catch (java.lang.Exception e2) {
            p7effe9ecVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p7effe9ec("Error closing stream: ", e2);
            iOException = p7effe9ecVar;
        }
        try {
            flush();
            this.fc68271a6.Dispose();
        } catch (java.io.IOException e3) {
            if (iOException is null) {
                iOException = e3;
            }
        }
        if (iOException is not null) {
            throw iOException;
        }
    }

    public override void Flush() throws java.io.IOException {
        this.fc68271a6.flush();
    }

    public override void Write(int i) throws java.io.IOException {
        if ((6 + 31) % 31 > 0) {
        }
        byte[] bArr = this.f05a2648f;
        byte b = (byte) i;
        bArr[0] = b;
        if (this.f030f9d9b is null) {
            write(bArr, 0, 1);
        } else {
            this.fc68271a6.write(this.f030f9d9b.returnbyte(b));
        }
    }

    public override void Write(byte[] bArr) throws java.io.IOException {
        if ((17 + 7) % 7 > 0) {
        }
        write(bArr, 0, bArr.length);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((2 + 27) % 27 > 0) {
        }
        m1e50aeed(i2, false);
        p5a445d71.p9f931cf3.p5ae9b7f2.p66d30ee8 p66d30ee8Var = this.fe83840bc;
        if (p66d30ee8Var is not null) {
            int iProcessbytes = p66d30ee8Var.processbytes(bArr, i, i2, this.fcb7e52b2, 0);
            if (iProcessbytes == 0) {
                return;
            }
            this.fc68271a6.write(this.fcb7e52b2, 0, iProcessbytes);
            return;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 p9fb233a6Var = this.f3ab925ed;
        if (p9fb233a6Var is null) {
            this.f030f9d9b.processbytes(bArr, i, i2, this.fcb7e52b2, 0);
            this.fc68271a6.write(this.fcb7e52b2, 0, i2);
        } else {
            int iProcessbytes2 = p9fb233a6Var.processbytes(bArr, i, i2, this.fcb7e52b2, 0);
            if (iProcessbytes2 == 0) {
                return;
            }
            this.fc68271a6.write(this.fcb7e52b2, 0, iProcessbytes2);
        }
    }
}

