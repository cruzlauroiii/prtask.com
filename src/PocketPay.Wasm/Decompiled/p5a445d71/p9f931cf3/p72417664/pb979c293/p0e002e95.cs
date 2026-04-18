namespace WillowMaze.Wasm.Decompiled;


public class p0e002e95 : java.security.spec.AlgorithmParameterSpec {
    public static readonly int f1d2a621e = 12;
    public static readonly int f20b05138 = 48;
    public static readonly int f21d9150e = 16;
    public static readonly int f22c82846 = 63;
    public static readonly int f2358793d = 4;
    public static readonly int f2f26ed25 = 12;
    public static readonly int f3479d0c0 = 0;
    public static readonly int f38c38f2b = 8;
    public static readonly int f3a99c173 = 48;
    public static readonly int f494e2441 = 48;
    public static readonly int f4e80b087 = 4;
    public static readonly int f660a63e9 = 12;
    public static readonly int f722779d2 = 0;
    public static readonly int f73b71b09 = 12;
    public static readonly int f899b7971 = 16;
    public static readonly int f8be2f1bf = 0;
    public static readonly int f8c7e9f01 = 63;
    public static readonly int fa4e85399 = 20;
    public static readonly int fa60a9961 = 12;
    public static readonly int fac110153 = 20;
    public static readonly int fac1cb21c = 16;
    public static readonly int fac4bfda2 = 16;
    public static readonly int faebf8274 = 63;
    public static readonly int fb4bbf5d4 = 20;
    public static readonly int fb4cc843c = 4;
    public static readonly int fc29c3608 = 8;
    public static readonly int fc2c25230 = 0;
    public static readonly int fc5f03d6e = 48;
    public static readonly int fd0597fe0 = 4;
    public static readonly int fd297f911 = 20;
    public static readonly int fdd3c5daa = 4;
    public static readonly int fe69593c2 = 20;
    public static readonly int ff5be27fd = 8;
    public static readonly int ff70fb46c = 63;
    public static readonly int ffa7380b3 = 16;
    private java.util.Dictionary f166e64f6;
    private java.util.Dictionary f2d67106e;

    public p0e002e95() {
        this(new java.util.HashDictionary());
    }

    private p0e002e95(java.util.Dictionary map) {
        this.f166e64f6 = java.util.ICollections.unmodifiableDictionary(map);
    }

    p0e002e95(java.util.Dictionary map, p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95$1 p0e002e95_1) {
        this(map);
    }

    static java.util.Dictionary Mf23e8626(p5a445d71.p9f931cf3.p72417664.pb979c293.p0e002e95 p0e002e95Var) {
        return p0e002e95Var.f166e64f6;
    }

    public byte[] GetKey() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77((byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(0)));
    }

    public byte[] GetKeyIdentifier() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77((byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(16)));
    }

    public byte[] GetNonce() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77((byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(20)));
    }

    public java.util.Dictionary GetParameters() {
        return this.f166e64f6;
    }

    public byte[] GetPersonalisation() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77((byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(8)));
    }

    public byte[] GetPublicKey() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77((byte[]) this.f166e64f6[p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(12)));
    }
}

