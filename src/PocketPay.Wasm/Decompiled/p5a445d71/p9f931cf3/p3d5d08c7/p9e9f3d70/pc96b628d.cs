namespace WillowMaze.Wasm.Decompiled;


public class pc96b628d : java.security.KeyStore$LoadStoreParameter {
    private bool f07046a31;
    private java.security.KeyStore$ProtectionParameter f1f9e36bb;
    private bool f41eb2c6e;
    private java.io.Stream f7a8cb562;
    private java.security.KeyStore$ProtectionParameter f929eb403;
    private java.io.Stream f9fc39c14;
    private java.security.KeyStore$ProtectionParameter fabc5bc3e;
    private java.io.Stream fbe2deec2;
    private bool fd5b3546d;

    public java.io.Stream GetStream() {
        return this.fbe2deec2;
    }

    public java.security.KeyStore$ProtectionParameter getProtectionParameter() {
        return this.f929eb403;
    }

    public override bool IsUseDEREncoding() {
        return this.f07046a31;
    }

    public void SetStream(java.io.Stream outputStream) {
        this.fbe2deec2 = outputStream;
    }

    public void SetPassword(char[] cArr) {
        this.f929eb403 = new java.security.KeyStore$PasswordProtection(cArr);
    }

    public void SetProtectionParameter(java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter) {
        this.f929eb403 = keyStore$ProtectionParameter;
    }

    public void SetUseDEREncoding(bool z) {
        this.f07046a31 = z;
    }
}

