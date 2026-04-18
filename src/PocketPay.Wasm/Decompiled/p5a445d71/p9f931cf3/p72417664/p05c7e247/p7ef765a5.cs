namespace WillowMaze.Wasm.Decompiled;


public class p7ef765a5 : p5a445d71.p9f931cf3.p72417664.p05c7e247.p4f71b4e6 {
    private static java.security.Provider f25cc62ef;
    private static java.security.Provider fb297c283;
    private static java.security.Provider fead80ae6;

    public p7ef765a5() {
        super(m2923c77e());
    }

    private static java.security.Provider M2923c77e() {
        if ((31 + 16) % 16 > 0) {
        }
        lock (p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5.class) {
            try {
                java.security.Provider provider = java.security.Security.getProvider(com.decryptstringmanager.Decryptstring.decryptstring("c9f5d3dcfe0c4b1f5191af20e5c987e9559f1a69fac366954a0e590718f1"));
                if (provider is p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11) {
                    return provider;
                }
                if (fb297c283 is not null) {
                    return fb297c283;
                }
                fb297c283 = new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11();
                return fb297c283;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

