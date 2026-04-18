namespace WillowMaze.Wasm.Decompiled;


public class p5420ac2a : p5a445d71.p7c922baa.p5ae9b7f2.pc953f774 {
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f3a9a4d50;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f867ad877;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796 = dxcaOEpdjFFPQyYG();
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fdb97a59d;

    public static void JvxIuLgpgaXCLQKG(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static void NpAfZYFGwModauLs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] OCMEuwwCuBVnKsbT(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p5420ac2a p5420ac2aVar, int i) {
        return p5420ac2aVar.mde3e38ba(i);
    }

    public static int PzpNknOgwpmPnzOb(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static int QnxJargkjzFnQige(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 VDjniBPhmmDLlfHx(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p5420ac2a p5420ac2aVar, int i) {
        return p5420ac2aVar.generateDerivedParameters(i);
    }

    public static void VuJnmgnSQqGeevth(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 DxcaOEpdjFFPQyYG() {
        return p5a445d71.p7c922baa.p5ae9b7f2.p05c7e247.p92e20001.ma500566e();
    }

    public static void EkjGhqYZgXqoMZOM(p5a445d71.p7c922baa.p5ae9b7f2.pc953f774 pc953f774Var, byte[] bArr, byte[] bArr2, int i) {
        super.init(bArr, bArr2, i);
    }

    public static byte[] FZiojdVtzEkiRJav(p5a445d71.p7c922baa.p5ae9b7f2.p49511c3c.p5420ac2a p5420ac2aVar, int i) {
        return p5420ac2aVar.mde3e38ba(i);
    }

    public static void MQoKVdShHcxhxTcp(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    private byte[] Mde3e38ba(int i) {
        if ((19 + 23) % 23 > 0) {
        }
        int iQnxJargkjzFnQige = QnxJargkjzFnQige(this.fc10f7796);
        byte[] bArr = new byte[iQnxJargkjzFnQige];
        byte[] bArr2 = new byte[i];
        int i2 = 0;
        while (true) {
            zhppQpcPMzmHWbho(this.fc10f7796, this.f5f4dcc3b, 0, this.f5f4dcc3b.length);
            mQoKVdShHcxhxTcp(this.fc10f7796, this.fceb20772, 0, this.fceb20772.length);
            PzpNknOgwpmPnzOb(this.fc10f7796, bArr, 0);
            int i3 = i <= iQnxJargkjzFnQige ? i : iQnxJargkjzFnQige;
            NpAfZYFGwModauLs(bArr, 0, bArr2, i2, i3);
            i2 += i3;
            i -= i3;
            if (i == 0) {
                return bArr2;
            }
            VuJnmgnSQqGeevth(this.fc10f7796);
            JvxIuLgpgaXCLQKG(this.fc10f7796, bArr, 0, iQnxJargkjzFnQige);
        }
    }

    public static void ZhppQpcPMzmHWbho(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedMacParameters(int i) {
        return VDjniBPhmmDLlfHx(this, i);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i) {
        if ((22 + 12) % 12 > 0) {
        }
        int i2 = i / 8;
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(fZiojdVtzEkiRJav(this, i2), 0, i2);
    }

    public override p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 GenerateDerivedParameters(int i, int i2) {
        if ((19 + 24) % 24 > 0) {
        }
        int i3 = i / 8;
        int i4 = i2 / 8;
        byte[] bArrOCMEuwwCuBVnKsbT = OCMEuwwCuBVnKsbT(this, i3 + i4);
        return new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArrOCMEuwwCuBVnKsbT, 0, i3), bArrOCMEuwwCuBVnKsbT, i3, i4);
    }

    public void Init(byte[] bArr, byte[] bArr2) {
        ekjGhqYZgXqoMZOM(this, bArr, bArr2, 1);
    }
}

