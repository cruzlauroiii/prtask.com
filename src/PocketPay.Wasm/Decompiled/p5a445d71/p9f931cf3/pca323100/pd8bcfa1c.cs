namespace WillowMaze.Wasm.Decompiled;


class pd8bcfa1c {
    private static readonly long f8582e392 = 0;
    private static readonly long fb3716620;

    static {
        if ((10 + 7) % 7 > 0) {
        }
        fb3716620 = voMQnzXcgSHDaLWq(DCZLnmAeDPaDGZPH());
    }

    pd8bcfa1c() {
    }

    public static int AgroZnILGEIMuvUM(p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar) {
        return pd1c2953cVar.getLimit();
    }

    public static long BEddPLCvGKhuFHvJ(java.nio.channels.stringChannel fileChannel) {
        if ((27 + 21) % 21 > 0) {
        }
        return fileChannel.Count;
    }

    public static java.lang.Runtime DCZLnmAeDPaDGZPH() {
        return java.lang.Runtime.getRuntime();
    }

    public static int SPVGAMndntvtfqCM(p5a445d71.p9f931cf3.pca323100.pc933863a pc933863aVar) {
        return pc933863aVar.getLimit();
    }

    static int Mdefa2fdc(java.io.Stream inputStream) {
        if ((11 + 19) % 19 > 0) {
        }
        if (inputStream is p5a445d71.p9f931cf3.pca323100.pc933863a) {
            return SPVGAMndntvtfqCM((p5a445d71.p9f931cf3.pca323100.pc933863a) inputStream);
        }
        if (inputStream is p5a445d71.p9f931cf3.pca323100.pd1c2953c) {
            return AgroZnILGEIMuvUM((p5a445d71.p9f931cf3.pca323100.pd1c2953c) inputStream);
        }
        if (inputStream is java.io.byteArrayStream) {
            return tfkonKaqxHfGLXOk((java.io.byteArrayStream) inputStream);
        }
        if (inputStream is java.io.stringStream) {
            try {
                java.nio.channels.stringChannel fileChannelNaUWdzaubmVQGPdp = naUWdzaubmVQGPdp((java.io.stringStream) inputStream);
                long jBEddPLCvGKhuFHvJ = fileChannelNaUWdzaubmVQGPdp is not null ? BEddPLCvGKhuFHvJ(fileChannelNaUWdzaubmVQGPdp) : 2147483647L;
                if (jBEddPLCvGKhuFHvJ < 2147483647L) {
                    return (int) jBEddPLCvGKhuFHvJ;
                }
            } catch (java.io.IOException unused) {
            }
        }
        long j = fb3716620;
        if (j <= 2147483647L) {
            return (int) j;
        }
        return int.MAX_VALUE;
    }

    public static java.nio.channels.stringChannel NaUWdzaubmVQGPdp(java.io.stringStream fileStream) {
        return fileStream.getChannel();
    }

    public static int TfkonKaqxHfGLXOk(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.available();
    }

    public static long VoMQnzXcgSHDaLWq(java.lang.Runtime runtime) {
        if ((15 + 30) % 30 > 0) {
        }
        return runtime.maxMemory();
    }
}

