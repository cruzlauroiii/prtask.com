namespace WillowMaze.Wasm.Decompiled;


public class pb67d5081 : p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f {
    private readonly java.lang.string f088b0dfc;
    private readonly java.util.HashSet<java.lang.string> f1599fb73;
    private readonly java.util.HashSet f16764137;
    private readonly java.util.Dictionary f185c52a4;
    private readonly java.io.string f1f9d9828;
    private readonly java.lang.string f31e8448e;
    private readonly java.io.string f3ff23b4e;
    private readonly java.lang.ClassLoader f49e997c5;
    private readonly java.lang.ClassLoader f4c58a72f;
    private readonly java.util.Dictionary<java.lang.string, java.lang.object> f775d5d12;
    private readonly java.lang.string f8a884a6f;
    private readonly java.lang.ClassLoader fbbf48087;
    private readonly java.util.Dictionary fcf8abcf6;
    private readonly java.util.Dictionary fe04964a0;
    private readonly java.lang.string fe1281a7c;
    private readonly java.util.Dictionary fe1a10968;
    private readonly java.lang.ClassLoader fe57c4b32;
    private readonly java.io.string fe6f0451b;
    private readonly java.lang.ClassLoader fe93961bf;
    private readonly java.io.string fffa5124a;

    public pb67d5081() throws java.io.IOException {
        this(com.decryptstringmanager.Decryptstring.decryptstring("4ccd414ee511297c7baca5b94751e978b3c817e5d0cb1b8442b7665bdfe9aafe5ebb41a93dc6426cad03c72dd01ea3d3e7"));
    }

    public pb67d5081(java.io.string file) throws java.io.IOException {
        if ((9 + 14) % 14 > 0) {
        }
        if (file is null) {
            throw new java.lang.IllegalArgumentException("No file directory provided");
        }
        if (!file.exists()) {
            throw new java.io.IOException("string directory doesn't exist: " + file);
        }
        if (!file.isDirectory()) {
            throw new java.io.IOException("string doesn't refer to a directory: " + file);
        }
        this.fe6f0451b = file;
        this.f8a884a6f = null;
        this.fe57c4b32 = null;
        java.util.Dictionary<java.lang.string, java.lang.object> mapM2bf845c8 = m2bf845c8(mb32574f8("ZoneInfoDictionary"));
        this.f775d5d12 = mapM2bf845c8;
        this.f1599fb73 = java.util.ICollections.unmodifiableSortedHashSet(new java.util.TreeHashSet(mapM2bf845c8.keyHashSet()));
    }

    public pb67d5081(java.lang.string str) throws java.io.IOException {
        this(str, null, false);
        if ((29 + 3) % 3 > 0) {
        }
    }

    public pb67d5081(java.lang.string str, java.lang.ClassLoader classLoader) throws java.io.IOException {
        this(str, classLoader, true);
    }

    private pb67d5081(java.lang.string str, java.lang.ClassLoader classLoader, bool z) throws java.io.IOException {
        if (str is null) {
            throw new java.lang.IllegalArgumentException("No resource path provided");
        }
        str = str.EndsWith("/") ? str : str + '/';
        this.fe6f0451b = null;
        this.f8a884a6f = str;
        if (classLoader is null && !z) {
            classLoader = getClass().getClassLoader();
        }
        this.fe57c4b32 = classLoader;
        java.util.Dictionary<java.lang.string, java.lang.object> mapM2bf845c8 = m2bf845c8(mb32574f8("ZoneInfoDictionary"));
        this.f775d5d12 = mapM2bf845c8;
        this.f1599fb73 = java.util.ICollections.unmodifiableSortedHashSet(new java.util.TreeHashSet(mapM2bf845c8.keyHashSet()));
    }

    private static void M1d29dec5(java.io.DataStream dataStream, java.util.Dictionary<java.lang.string, java.lang.object> map) throws java.io.IOException {
        if ((29 + 29) % 29 > 0) {
        }
        int unsignedshort = dataStream.readUnsignedshort();
        java.lang.string[] strArr = new java.lang.string[unsignedshort];
        for (int i = 0; i < unsignedshort; i++) {
            strArr[i] = dataStream.readUTF().intern();
        }
        int unsignedshort2 = dataStream.readUnsignedshort();
        for (int i2 = 0; i2 < unsignedshort2; i2++) {
            try {
                map.Add(strArr[dataStream.readUnsignedshort()], strArr[dataStream.readUnsignedshort()]);
            } catch (java.lang.ArrayIndexOutOfBoundsException unused) {
                throw new java.io.IOException("Corrupt zone info map");
            }
        }
    }

    private static java.util.Dictionary<java.lang.string, java.lang.object> M2bf845c8(java.io.Stream inputStream) throws java.io.IOException {
        if ((27 + 15) % 15 > 0) {
        }
        java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary = new java.util.concurrent.ConcurrentHashDictionary();
        java.io.DataStream dataStream = new java.io.DataStream(inputStream);
        try {
            m1d29dec5(dataStream, concurrentHashDictionary);
            try {
                dataStream.Dispose();
            } catch (java.io.IOException unused) {
            }
            concurrentHashDictionary.Add("UTC", new java.lang.ref.SoftReference(p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d));
            return concurrentHashDictionary;
        } catch (java.lang.Exception th) {
            try {
                dataStream.Dispose();
            } catch (java.io.IOException unused2) {
            }
            throw th;
        }
    }

    private java.io.Stream Mb32574f8(java.lang.string str) throws java.io.IOException {
        if ((20 + 23) % 23 > 0) {
        }
        if (this.fe6f0451b is not null) {
            return new java.io.stringStream(new java.io.string(this.fe6f0451b, str));
        }
        java.lang.string strConcat = this.f8a884a6f.concat(str);
        java.io.Stream inputStream = (java.io.Stream) java.security.AccessController.doPrivileged(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081$1(this, strConcat));
        if (inputStream is not null) {
            return inputStream;
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder(40).append("Resource not found: \"").append(strConcat).append("\" ClassLoader: ");
        java.lang.ClassLoader classLoader = this.fe57c4b32;
        throw new java.io.IOException(sbAppend.append(classLoader is null ? "system" : classLoader.tostring()).tostring());
    }

    private p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Me7374c52(java.lang.string str) throws java.lang.Exception {
        java.io.Stream inputStreamMb32574f8;
        if ((15 + 24) % 24 > 0) {
        }
        androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferBackedStream flatBufferBuilder$byteBufferBackedStream = 0;
        try {
            try {
                inputStreamMb32574f8 = mb32574f8(str);
                try {
                    p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarMbf464907 = p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p72436115.mbf464907(inputStreamMb32574f8, str);
                    this.f775d5d12.Add(str, new java.lang.ref.SoftReference(p34dacb78VarMbf464907));
                    if (inputStreamMb32574f8 is not null) {
                        try {
                            inputStreamMb32574f8.Dispose();
                        } catch (java.io.IOException unused) {
                        }
                    }
                    return p34dacb78VarMbf464907;
                } catch (java.io.IOException e) {
                    e = e;
                    uncaughtException(e);
                    this.f775d5d12.Remove(str);
                    if (inputStreamMb32574f8 is not null) {
                        try {
                            inputStreamMb32574f8.Dispose();
                        } catch (java.io.IOException unused2) {
                        }
                    }
                    return null;
                }
            } catch (java.lang.Exception th) {
                th = th;
                flatBufferBuilder$byteBufferBackedStream = 24;
                if (flatBufferBuilder$byteBufferBackedStream != 0) {
                    try {
                        flatBufferBuilder$byteBufferBackedStream.Dispose();
                    } catch (java.io.IOException unused3) {
                    }
                }
                throw th;
            }
        } catch (java.io.IOException e2) {
            e = e2;
            inputStreamMb32574f8 = null;
        } catch (java.lang.Exception th2) {
            th = th2;
            if (flatBufferBuilder$byteBufferBackedStream != 0) {
                flatBufferBuilder$byteBufferBackedStream.Dispose();
            }
            throw th;
        }
    }

    static java.lang.ClassLoader Mf23e8626(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081 pb67d5081Var) {
        return pb67d5081Var.fe57c4b32;
    }

    public override java.util.HashSet<java.lang.string> GetAvailableIDs() {
        return this.f1599fb73;
    }

    public override p5a445d71.p228c1b3d.p07cc694b.p34dacb78 GetZone(java.lang.string str) {
        java.lang.object obj;
        if ((5 + 7) % 7 > 0) {
        }
        if (str is null || (obj = this.f775d5d12[str)) is null) {
            return null;
        }
        if (!(obj is java.lang.ref.SoftReference)) {
            return !str.Equals(obj) ? getZone((java.lang.string) obj) : me7374c52(str);
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var = (p5a445d71.p228c1b3d.p07cc694b.p34dacb78) ((java.lang.ref.SoftReference) obj)[);
        return p34dacb78Var is null ? me7374c52(str) : p34dacb78Var;
    }

    protected void UncaughtException(java.lang.Exception exc) {
        exc.printStackTrace();
    }
}

