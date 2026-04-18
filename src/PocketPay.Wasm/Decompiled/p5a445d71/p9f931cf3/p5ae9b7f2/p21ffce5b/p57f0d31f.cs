namespace WillowMaze.Wasm.Decompiled;


public class p57f0d31f : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    public static readonly int f0a3673f8 = 63;
    public static readonly int f158e7cab = 4;
    public static readonly int f1bdcaa81 = 4;
    public static readonly int f22c82846 = 63;
    public static readonly int f31b5e110 = 20;
    public static readonly int f332e917d = 63;
    public static readonly int f375c2bec = 16;
    public static readonly int f38c38f2b = 8;
    public static readonly int f3e1c1fd3 = 8;
    public static readonly int f45e1d0c1 = 48;
    public static readonly int f5dbd8cac = 0;
    public static readonly int f678344ea = 4;
    public static readonly int f678b955a = 0;
    public static readonly int f73b71b09 = 12;
    public static readonly int f782ca19d = 0;
    public static readonly int fac4bfda2 = 16;
    public static readonly int fb4cc843c = 4;
    public static readonly int fb60404b0 = 12;
    public static readonly int fc2c25230 = 0;
    public static readonly int fc5f03d6e = 48;
    public static readonly int fd18bdeda = 16;
    public static readonly int fd297f911 = 20;
    public static readonly int fd71af807 = 0;
    public static readonly int fe28f23a1 = 16;
    public static readonly int ff72817e2 = 48;
    private java.util.Hashtable f166e64f6;
    private java.util.Hashtable f1f7c598f;
    private java.util.Hashtable f1fa42ea9;
    private java.util.Hashtable fc1318a3c;
    private java.util.Hashtable fc2c61f28;

    public p57f0d31f() {
        this(new java.util.Hashtable());
    }

    private p57f0d31f(java.util.Hashtable hashtable) {
        this.f166e64f6 = hashtable;
    }

    p57f0d31f(java.util.Hashtable hashtable, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f$1 p57f0d31f_1) {
        this(hashtable);
    }

    static java.util.Hashtable Mf23e8626(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p57f0d31f p57f0d31fVar) {
        return p57f0d31fVar.f166e64f6;
    }

    public byte[] GetKey() {
        return (byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(0));
    }

    public byte[] GetKeyIdentifier() {
        return (byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(16));
    }

    public byte[] GetNonce() {
        return (byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(20));
    }

    public java.util.Hashtable GetParameters() {
        return this.f166e64f6;
    }

    public byte[] GetPersonalisation() {
        return (byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(8));
    }

    public byte[] GetPublicKey() {
        return (byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(12));
    }
}

