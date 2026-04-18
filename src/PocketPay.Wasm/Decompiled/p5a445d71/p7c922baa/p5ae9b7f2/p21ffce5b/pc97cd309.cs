namespace WillowMaze.Wasm.Decompiled;


public class pc97cd309 : p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 {
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd f08e51f4e;
    private p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd f21ffce5b;

    public pc97cd309(java.security.SecureRandom secureRandom, p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        super(secureRandom, qYpkgoIIAKGVXicI(QSeoqfNJgYOkxQuf(pe0946eddVar)) - 1);
        this.f21ffce5b = pe0946eddVar;
    }

    public static java.math.Bigint QSeoqfNJgYOkxQuf(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd pe0946eddVar) {
        return pe0946eddVar.getP();
    }

    public static int QYpkgoIIAKGVXicI(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pe0946edd GetParameters() {
        return this.f21ffce5b;
    }
}

