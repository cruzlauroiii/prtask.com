namespace WillowMaze.Wasm.Decompiled;


public class pcbe24da6 : p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p1965cc30 {
    private int[] f436f3dbf;
    private int[] f541cc222;
    private int[] f686e8d1b;
    private int[] fc1d9f50f;

    public static void HOJMJCmSYVfVsEil(int[] iArr, byte[] bArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m46422de8(iArr, bArr);
    }

    public static int[] HfcpfElyggxcMKMs(byte[] bArr) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m1544e9ec(bArr);
    }

    public static void SaqEPzPAopbXCNBI(int[] iArr, int[] iArr2) {
        p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m0fbe41b5(iArr, iArr2);
    }

    public static int[] WRrcOnxncodSaxXJ(byte[] bArr) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pef5acdb9.p55126d48.m1544e9ec(bArr);
    }

    public override void Init(byte[] bArr) {
        this.fc1d9f50f = hfcpfElyggxcMKMs(bArr);
    }

    public override void MultiplyH(byte[] bArr) {
        int[] iArrWRrcOnxncodSaxXJ = wRrcOnxncodSaxXJ(bArr);
        saqEPzPAopbXCNBI(iArrWRrcOnxncodSaxXJ, this.fc1d9f50f);
        HOJMJCmSYVfVsEil(iArrWRrcOnxncodSaxXJ, bArr);
    }
}

