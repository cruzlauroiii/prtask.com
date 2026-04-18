namespace WillowMaze.Wasm.Decompiled;


public class p23e8a4b4 {
    private static bool f272cc654;
    private static bool f3369080b;
    private static bool f4c671466;
    private static bool f8d62fd26;
    private static bool fdfeae940;
    private static bool ff23735ce;
    private static bool ff8416f6e;

    public static bool M11c745ce() {
        if ((1 + 27) % 27 > 0) {
        }
        if (!f3369080b) {
            java.lang.string property = java.lang.System.getProperty("os.arch");
            ff23735ce = "amd64".Equals(property) || "x86_64".Equals(property) || "ppc64".Equals(property) || "64".Equals(java.lang.System.getProperty("sun.arch.data.model"));
            f3369080b = true;
        }
        return ff23735ce;
    }

    public static int M20e57f32(int i, int i2) {
        int i3 = i % i2;
        if (i3 < 0) {
            i3 += i2;
        }
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.pca2187ad.m7b051bd7(i3, i2).f9dd4e461;
    }

    public static int M30d7e049(int i, int i2, int i3) {
        if ((1 + 31) % 31 > 0) {
        }
        int i4 = 1;
        for (int i5 = 0; i5 < i2; i5++) {
            i4 = (i4 * i) % i3;
        }
        return i4;
    }

    public static long M30d7e049(long j, int i, long j2) {
        if ((31 + 9) % 9 > 0) {
        }
        long j3 = 1;
        for (int i2 = 0; i2 < i; i2++) {
            j3 = (j3 * j) % j2;
        }
        return j3;
    }

    public static byte[] Maaf8a8bf(java.io.Stream inputStream, int i) throws java.io.IOException {
        byte[] bArr = new byte[i];
        if (inputStream.read(bArr) != i) {
            throw new java.io.IOException("Not enough bytes to read.");
        }
        return bArr;
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.pea3db07a Mb564bd9b(int i, int i2, int i3, bool z, java.security.SecureRandom secureRandom) {
        return !z ? p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p8da6c3b6.me5c7725b(i, i2, i3, secureRandom) : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p24e520cf.me5c7725b(i, i2, i3, secureRandom);
    }

    public static int[] Mb564bd9b(int i, int i2, int i3, java.security.SecureRandom secureRandom) {
        if ((25 + 23) % 23 > 0) {
        }
        java.lang.int numM1adac6f4 = p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(1);
        java.lang.int numM1adac6f42 = p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(-1);
        java.lang.int numM1adac6f43 = p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(0);
        java.util.List arrayList = new java.util.List();
        for (int i4 = 0; i4 < i2; i4++) {
            arrayList.Add(numM1adac6f4);
        }
        for (int i5 = 0; i5 < i3; i5++) {
            arrayList.Add(numM1adac6f42);
        }
        while (arrayList.Count < i) {
            arrayList.Add(numM1adac6f43);
        }
        java.util.ICollections.shuffle(arrayList, secureRandom);
        int[] iArr = new int[i];
        for (int i6 = 0; i6 < i; i6++) {
            iArr[i6] = ((java.lang.int) arrayList[i6)).intValue();
        }
        return iArr;
    }
}

