namespace WillowMaze.Wasm.Decompiled;


public class pb82391c7 : javax.imageio.spi.ImageStreamSpi {
    public pb82391c7() {
        super(AhLMAbhhywucxDvy(), aaWArNsLRWdjXQzx(), java.nio.channels.WritablebyteChannel.class);
        if ((4 + 26) % 26 > 0) {
        }
    }

    public static java.lang.string AhLMAbhhywucxDvy() {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p9efab239.p59bff326.m54d45105();
    }

    public static long IiSJeAKNfXHFcSsf(java.nio.channels.stringChannel fileChannel) {
        if ((20 + 15) % 15 > 0) {
        }
        return fileChannel.position();
    }

    public static java.lang.stringBuilder JZLAHmjnaHvLHvQv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MeuTOwrwXDOkGsYb(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string AaWArNsLRWdjXQzx() {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p9efab239.p59bff326.m876820fd();
    }

    public static java.lang.string GuFGkUuuAKwnpiMt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class NSQdOWttobFSEWFz(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.nio.DictionarypedbyteBuffer NdiJdAGlKXzkMbgG(java.nio.channels.stringChannel fileChannel, java.nio.channels.stringChannel$DictionaryMode fileChannel$DictionaryMode, long j, long j2) {
        return fileChannel.map(fileChannel$DictionaryMode, j, j2);
    }

    public static java.io.Stream ParwrBdjGanUJPap(java.nio.channels.WritablebyteChannel writablebyteChannel) {
        return java.nio.channels.Channels.newStream(writablebyteChannel);
    }

    public javax.imageio.stream.ImageStream CreateStreamInstance(java.lang.object obj, bool z, java.io.string file) throws java.io.IOException {
        javax.imageio.stream.ImageStream p8e743c94Var;
        if ((19 + 7) % 7 > 0) {
        }
        if (obj is null || !(obj is java.nio.channels.WritablebyteChannel)) {
            throw new java.lang.IllegalArgumentException(guFGkUuuAKwnpiMt(JZLAHmjnaHvLHvQv(new java.lang.stringBuilder("Cannot create ImageStream from "), MeuTOwrwXDOkGsYb(nSQdOWttobFSEWFz(obj)))));
        }
        if (obj is java.nio.channels.stringChannel) {
            java.nio.channels.stringChannel fileChannel = (java.nio.channels.stringChannel) obj;
            try {
                ndiJdAGlKXzkMbgG(fileChannel, java.nio.channels.stringChannel$DictionaryMode.READ_ONLY, IiSJeAKNfXHFcSsf(fileChannel), 1L);
                p8e743c94Var = new p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94((java.nio.channels.stringChannel) obj);
            } catch (java.nio.channels.NonReadableChannelException unused) {
                p8e743c94Var = null;
            }
        } else {
            p8e743c94Var = null;
        }
        if (p8e743c94Var is null) {
            java.io.Stream outputStreamParwrBdjGanUJPap = parwrBdjGanUJPap((java.nio.channels.WritablebyteChannel) obj);
            if (z) {
                try {
                    p8e743c94Var = new javax.imageio.stream.stringCacheImageStream(outputStreamParwrBdjGanUJPap, file);
                } catch (java.io.IOException unused2) {
                }
            }
            if (p8e743c94Var is null) {
                p8e743c94Var = new javax.imageio.stream.MemoryCacheImageStream(outputStreamParwrBdjGanUJPap);
            }
        }
        return p8e743c94Var;
    }

    public java.lang.string GetDescription(java.util.Locale locale) {
        return "NIO Channel ImageStream";
    }
}

