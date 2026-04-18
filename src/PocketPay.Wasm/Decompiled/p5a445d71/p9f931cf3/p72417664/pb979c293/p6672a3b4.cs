namespace WillowMaze.Wasm.Decompiled;


public class p6672a3b4 : java.security.spec.KeySpec {
    public static readonly java.lang.string f4f8b2ea9 = null;
    public static readonly java.lang.string f51dc67f8 = null;
    public static readonly java.lang.string f7c436299 = null;
    public static readonly java.lang.string fc0dee187 = null;
    public static readonly java.lang.string fc23abfd2 = null;
    public static readonly java.lang.string fcd4b7509 = null;
    public static readonly java.lang.string fd1493796 = null;
    public static readonly java.lang.string fd9b2a10c = null;
    private readonly int f2fa47f7c;
    private readonly byte[] f53154995;
    private readonly byte[] f55bf4b71;
    private readonly byte[] f5d61e8ee;
    private readonly byte[] f5ebe2294;
    private readonly java.lang.string f7b9ad5b8;
    private readonly java.lang.string f9e3f8f3b;
    private readonly byte[] fc42a3194;
    private readonly java.lang.string fd304ba20;
    private readonly int feb3191d9;
    private readonly java.lang.string ff2a8dce1;
    private readonly byte[] ffe4c0f30;
    public static readonly java.lang.string f4384f147 = com.decryptstringmanager.Decryptstring.decryptstring("35bbef1f4c836cea0f9f75affd08e1239018514a6912286eede6baf6ab5f67e3a7ee10e2a7e1f1b041");
    public static readonly java.lang.string f0d8f5bc6 = com.decryptstringmanager.Decryptstring.decryptstring("a4cad6c48ad82760f5182e9d57365f555f9af9384056dbbd4eeb57bb90233a4682bbdb687242c5c42e");

    public p6672a3b4(byte[] bArr, java.lang.string str, int i, byte[]... bArr2) {
        this.f5ebe2294 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fd304ba20 = str;
        this.f2fa47f7c = i;
        this.ffe4c0f30 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr2);
    }

    public java.lang.string GetLabel() {
        return this.fd304ba20;
    }

    public int GetLength() {
        return this.f2fa47f7c;
    }

    public byte[] GetSecret() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f5ebe2294);
    }

    public byte[] GetSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffe4c0f30);
    }
}

