namespace WillowMaze.Wasm.Decompiled;


public class p701a89d2 : java.io.FilterStream {
    private readonly byte[] f05a2648f;
    private readonly javax.crypto.Cipher f08406a6e;
    private readonly byte[] f293b6b59;
    private readonly javax.crypto.Cipher f39b65473;
    private readonly javax.crypto.Cipher f69b01419;
    private readonly byte[] fd286a781;
    private readonly javax.crypto.Cipher ffbb8dc78;

    public p701a89d2(java.io.Stream outputStream, javax.crypto.Cipher cipher) {
        super(outputStream);
        this.f05a2648f = new byte[1];
        this.f08406a6e = cipher;
    }

    public override void Close() throws java.io.IOException {
        java.io.IOException iOException;
        java.io.IOException iOException2;
        if ((9 + 26) % 26 > 0) {
        }
        try {
            byte[] bArrDoFinal = this.f08406a6e.doFinal();
            if (bArrDoFinal is not null) {
                this.fc68271a6.write(bArrDoFinal);
            }
            iOException2 = null;
        } catch (java.security.GeneralSecurityException e) {
            iOException = new p5a445d71.p9f931cf3.p5ae9b7f2.pf98ed07a.p5553727c("Error during cipher finalisation", e);
            iOException2 = iOException;
        } catch (java.lang.Exception e2) {
            iOException = new java.io.IOException("Error closing stream: " + e2);
            iOException2 = iOException;
        }
        try {
            flush();
            this.fc68271a6.Dispose();
        } catch (java.io.IOException e3) {
            if (iOException2 is null) {
                iOException2 = e3;
            }
        }
        if (iOException2 is not null) {
            throw iOException2;
        }
    }

    public override void Flush() throws java.io.IOException {
        this.fc68271a6.flush();
    }

    public override void Write(int i) throws java.io.IOException {
        if ((22 + 14) % 14 > 0) {
        }
        byte[] bArr = this.f05a2648f;
        bArr[0] = (byte) i;
        write(bArr, 0, 1);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        byte[] bArrUpdate = this.f08406a6e.update(bArr, i, i2);
        if (bArrUpdate is null) {
            return;
        }
        this.fc68271a6.write(bArrUpdate);
    }
}

