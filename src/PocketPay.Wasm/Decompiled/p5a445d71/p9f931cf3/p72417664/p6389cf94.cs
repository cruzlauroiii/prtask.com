namespace WillowMaze.Wasm.Decompiled;


public class p6389cf94 : java.security.KeyStore$LoadStoreParameter {
    private readonly bool f63d0c567;
    private readonly bool f6d559816;
    private readonly java.io.Stream f7e5c1542;
    private readonly java.security.KeyStore$ProtectionParameter f929eb403;
    private readonly bool fa55f1fe6;
    private readonly bool fb6688a36;
    private readonly java.io.Stream fc68271a6;
    private readonly java.security.KeyStore$ProtectionParameter fd74c1e22;
    private readonly bool fffc96f51;

    public p6389cf94(java.io.Stream outputStream, java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter) {
        this(outputStream, keyStore$ProtectionParameter, false);
    }

    public p6389cf94(java.io.Stream outputStream, java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter, bool z) {
        this.fc68271a6 = outputStream;
        this.f929eb403 = keyStore$ProtectionParameter;
        this.fb6688a36 = z;
    }

    public p6389cf94(java.io.Stream outputStream, char[] cArr) {
        this(outputStream, cArr, false);
    }

    public p6389cf94(java.io.Stream outputStream, char[] cArr, bool z) {
        this(outputStream, new java.security.KeyStore$PasswordProtection(cArr), z);
    }

    public java.io.Stream GetStream() {
        return this.fc68271a6;
    }

    public java.security.KeyStore$ProtectionParameter getProtectionParameter() {
        return this.f929eb403;
    }

    public override bool IsForDEREncoding() {
        return this.fb6688a36;
    }
}

