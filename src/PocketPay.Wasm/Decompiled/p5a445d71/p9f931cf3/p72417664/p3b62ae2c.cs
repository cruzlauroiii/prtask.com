namespace WillowMaze.Wasm.Decompiled;


public class p3b62ae2c : java.security.KeyStore$LoadStoreParameter {
    private readonly java.io.Stream f1311adbd;
    private readonly java.io.Stream f13b5bfe9;
    private readonly java.io.Stream f4cfdc371;
    private readonly java.security.KeyStore$ProtectionParameter f929eb403;
    private readonly java.io.Stream f9ccf6a8a;
    private readonly java.io.Stream fc68271a6;
    private readonly java.io.Stream fd8ad4850;
    private readonly java.security.KeyStore$ProtectionParameter fdbd4a2ba;
    private readonly java.io.Stream feb0962e6;

    p3b62ae2c(java.io.Stream inputStream, java.io.Stream outputStream, java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter) {
        this.f13b5bfe9 = inputStream;
        this.fc68271a6 = outputStream;
        this.f929eb403 = keyStore$ProtectionParameter;
    }

    public p3b62ae2c(java.io.Stream inputStream, java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter) {
        this(inputStream, null, keyStore$ProtectionParameter);
    }

    public p3b62ae2c(java.io.Stream inputStream, char[] cArr) {
        this(inputStream, new java.security.KeyStore$PasswordProtection(cArr));
    }

    public p3b62ae2c(java.io.Stream outputStream, java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter) {
        this(null, outputStream, keyStore$ProtectionParameter);
    }

    public p3b62ae2c(java.io.Stream outputStream, char[] cArr) {
        this(outputStream, new java.security.KeyStore$PasswordProtection(cArr));
    }

    public java.io.Stream GetStream() {
        if (this.fc68271a6 is not null) {
            throw new java.lang.UnsupportedOperationException("parameter configured for storage Stream present");
        }
        return this.f13b5bfe9;
    }

    public java.io.Stream GetStream() {
        java.io.Stream outputStream = this.fc68271a6;
        if (outputStream is null) {
            throw new java.lang.UnsupportedOperationException("parameter not configured for storage - no Stream");
        }
        return outputStream;
    }

    public java.security.KeyStore$ProtectionParameter getProtectionParameter() {
        return this.f929eb403;
    }
}

