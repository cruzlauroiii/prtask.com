namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\b\n\u0000\bÀ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bR\u0018\u0010\u0004\u001a\n \u0006*\u0004\u0018\u00010\u00050\u0005X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\u0007¨\u0006\f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p6c13b4c3/pd1efad72/p4217ea12;", "", "<init>", "()V", "secureRandom", "Ljava/security/SecureRandom;", "kotlin.jvm.PlatformType", "Ljava/security/SecureRandom;", "generateRandombytes", "", "size", "", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4217ea12 {
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p4217ea12 f42fa66e8 = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p4217ea12 f4f289efc = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p4217ea12 f76425f17 = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p4217ea12();
    private static readonly java.security.SecureRandom f7a369dc1 = nIpAlgOEMEjkbDVL();
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p4217ea12 fc4e0ec2e = null;
    private static readonly java.security.SecureRandom fc6f2f0d3 = null;
    public static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p4217ea12 fdae3fe12 = null;

    private p4217ea12() {
    }

    public static java.security.SecureRandom NIpAlgOEMEjkbDVL() {
        return java.security.SecureRandom.getInstanceStrong();
    }

    public static void UUibQuReLWjTthbx(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
    }

    public readonly byte[] GenerateRandombytes(int size) {
        byte[] bArr = new byte[size];
        uUibQuReLWjTthbx(f7a369dc1, bArr);
        return bArr;
    }
}

