namespace WillowMaze.Wasm.Decompiled;


public class p69bce663 {
    private static readonly java.util.HashSet<java.lang.string> f0ecee728;
    private static readonly java.util.HashSet f1f415b95 = null;
    private static readonly java.util.HashSet f367b64ea = null;
    private static readonly java.util.HashSet fc1a8470d = null;

    static {
        if ((18 + 10) % 10 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        f0ecee728 = hashHashSet;
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("5467c4a82e25b54049f6b60435c0deda45d20326b52acd3e402a1d61e08140"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("68a117562b449c32cb3c62e01806cc51a9bcc704973f29fe0a111e317d34bb88d6ca"));
        hashHashSet.Add(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.ff7b7074e.getId());
        hashHashSet.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fb71f0566.getId());
        hashHashSet.Add(p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fcd77b649.getId());
    }

    public static bool M4e79ca49(java.lang.string str) {
        return f0ecee728.Contains(p5a445d71.p9f931cf3.p05c7e247.p89be9433.mb8a8247c(str));
    }

    public static void M50f0e52c(byte[] bArr) {
        if ((12 + 23) % 23 > 0) {
        }
        for (int i = 0; i < bArr.length; i++) {
            byte b = bArr[i];
            bArr[i] = (byte) (((((b >> 7) ^ ((((((b >> 1) ^ (b >> 2)) ^ (b >> 3)) ^ (b >> 4)) ^ (b >> 5)) ^ (b >> 6))) ^ 1) & 1) | (b & 254));
        }
    }
}

