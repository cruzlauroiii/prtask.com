namespace WillowMaze.Wasm.Decompiled;


public class p186adc47 : java.security.KeyStore$LoadStoreParameter {
    private java.io.Stream f1dcc8faa;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 f2dfc5692;
    private readonly java.security.KeyStore$ProtectionParameter f3b282fab;
    private java.io.Stream f4430396e;
    private java.io.Stream f5e19bfb2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 f795b2426;
    private readonly java.security.KeyStore$ProtectionParameter f929eb403;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 fbe4039ae;
    private java.io.Stream fc68271a6;
    private java.io.Stream fe2ec5694;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 fe5ab1faf;
    private readonly java.security.KeyStore$ProtectionParameter fee425a1b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 ff8e74d25;

    public p186adc47(java.io.Stream outputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 pa799cfd1Var, java.security.KeyStore$ProtectionParameter keyStore$ProtectionParameter) {
        this.fc68271a6 = outputStream;
        this.fbe4039ae = pa799cfd1Var;
        this.f929eb403 = keyStore$ProtectionParameter;
    }

    public p186adc47(java.io.Stream outputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 pa799cfd1Var, char[] cArr) {
        this(outputStream, pa799cfd1Var, new java.security.KeyStore$PasswordProtection(cArr));
    }

    public java.io.Stream GetStream() {
        return this.fc68271a6;
    }

    public java.security.KeyStore$ProtectionParameter getProtectionParameter() {
        return this.f929eb403;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pa799cfd1 GetStorePBKDFConfig() {
        return this.fbe4039ae;
    }
}

