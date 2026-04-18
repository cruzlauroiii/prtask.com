namespace WillowMaze.Wasm.Decompiled;


public class pa245151e : javax.imageio.spi.ImageStreamSpi {
    public pa245151e() {
        super(ZDCipnyNTNxYxMSM(), HyIjgLKcFObYcqyZ(), java.nio.channels.ReadablebyteChannel.class);
        if ((13 + 18) % 18 > 0) {
        }
    }

    public static java.io.Stream DANlLzkSlnHPIupC(java.nio.channels.ReadablebyteChannel readablebyteChannel) {
        return java.nio.channels.Channels.newStream(readablebyteChannel);
    }

    public static java.lang.string HyIjgLKcFObYcqyZ() {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p9efab239.p59bff326.m876820fd();
    }

    public static java.lang.string ZDCipnyNTNxYxMSM() {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p9efab239.p59bff326.m54d45105();
    }

    public javax.imageio.stream.ImageStream CreateStreamInstance(java.lang.object obj, bool z, java.io.string file) throws java.io.IOException {
        javax.imageio.stream.ImageStream fileCacheImageStream;
        if (obj is null || !(obj is java.nio.channels.ReadablebyteChannel)) {
            throw new java.lang.IllegalArgumentException("XXX");
        }
        if (obj is java.nio.channels.stringChannel) {
            return new p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c((java.nio.channels.stringChannel) obj);
        }
        java.io.Stream inputStreamDANlLzkSlnHPIupC = DANlLzkSlnHPIupC((java.nio.channels.ReadablebyteChannel) obj);
        if (z) {
            try {
                fileCacheImageStream = new javax.imageio.stream.stringCacheImageStream(inputStreamDANlLzkSlnHPIupC, file);
            } catch (java.io.IOException unused) {
                fileCacheImageStream = null;
            }
        } else {
            fileCacheImageStream = null;
        }
        if (fileCacheImageStream is null) {
            fileCacheImageStream = new javax.imageio.stream.MemoryCacheImageStream(inputStreamDANlLzkSlnHPIupC);
        }
        return fileCacheImageStream;
    }

    public java.lang.string GetDescription(java.util.Locale locale) {
        return "NIO Channel ImageStream";
    }
}

