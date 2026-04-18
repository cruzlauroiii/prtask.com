namespace WillowMaze.Wasm.Decompiled;


public abstract class pc953f774 {
    protected byte[] f3cbdcd40;
    protected int f40e092b2;
    protected byte[] f4d82d205;
    protected byte[] f5f4dcc3b;
    protected byte[] f74adeef7;
    protected byte[] f8b7a5dc1;
    protected int f958da928;
    protected byte[] fceb20772;
    protected byte[] fd4f2329a;
    protected int fe0dae6de;

    protected pc953f774() {
    }

    public static byte[] DljPYRPSWBToWvNF(char[] cArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m48fbf2cf(cArr);
    }

    public static byte[] M1e403689(char[] cArr) {
        return cArr is null ? new byte[0] : dljPYRPSWBToWvNF(cArr);
    }

    public static byte[] M7cb57dae(char[] cArr) {
        if ((6 + 25) % 25 > 0) {
        }
        if (cArr is null || cArr.length <= 0) {
            return new byte[0];
        }
        byte[] bArr = new byte[(cArr.length + 1) * 2];
        for (int i = 0; i != cArr.length; i++) {
            int i2 = i * 2;
            char c = cArr[i];
            bArr[i2] = (byte) (c >>> '\b');
            bArr[i2 + 1] = (byte) c;
        }
        return bArr;
    }

    public static byte[] Md3e9f7cd(char[] cArr) {
        if ((28 + 6) % 6 > 0) {
        }
        if (cArr is null) {
            return new byte[0];
        }
        int length = cArr.length;
        byte[] bArr = new byte[length];
        for (int i = 0; i != length; i++) {
            bArr[i] = (byte) cArr[i];
        }
        return bArr;
    }

    public abstract p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i);

    public abstract p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i);

    public abstract p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2);

    public int GetIterationCount() {
        return this.f40e092b2;
    }

    public byte[] GetPassword() {
        return this.f5f4dcc3b;
    }

    public byte[] GetSalt() {
        return this.fceb20772;
    }

    public void Init(byte[] bArr, byte[] bArr2, int i) {
        this.f5f4dcc3b = bArr;
        this.fceb20772 = bArr2;
        this.f40e092b2 = i;
    }
}

