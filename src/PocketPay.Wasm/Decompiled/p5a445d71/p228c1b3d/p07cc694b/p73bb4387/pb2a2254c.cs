namespace WillowMaze.Wasm.Decompiled;


public readonly class pb2a2254c : p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f {
    private static readonly java.util.HashSet f37048800 = null;
    private static readonly java.util.HashSet<java.lang.string> f4fb9a9f3 = java.util.ICollections.singleton(com.decryptstringmanager.Decryptstring.decryptstring("742bcc98da3a72489e7cc44a19ba95f4623482ac32bb97fa2f484597f0ef0e"));
    private static readonly java.util.HashSet fa306a223 = null;
    private static readonly java.util.HashSet fbbed8800 = null;

    public override java.util.HashSet<java.lang.string> GetAvailableIDs() {
        return f4fb9a9f3;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetZone(java.lang.string str) {
        if ("UTC".equalsIgnoreCase(str)) {
            return p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d;
        }
        return null;
    }
}

