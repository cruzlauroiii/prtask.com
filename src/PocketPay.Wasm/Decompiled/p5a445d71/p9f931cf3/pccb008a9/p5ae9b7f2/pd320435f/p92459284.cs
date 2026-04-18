namespace WillowMaze.Wasm.Decompiled;


class p92459284 {
    static readonly int f031197ff = 168;
    static readonly int f3650413d = 136;
    static readonly int f376c79ce = 168;
    static readonly int f64e86376 = 136;
    static readonly int f80287ac2 = 136;
    static readonly int f8b937b85 = 136;
    static readonly int fc59194ca = 168;
    static readonly int ff233d80e = 136;

    p92459284() {
    }

    static void M16dba0d1(byte[] bArr, int i, int i2, byte[] bArr2, int i3, int i4) {
        if ((17 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(128);
        p332ac7c7Var.update(bArr2, i3, i4);
        p332ac7c7Var.doFinal(bArr, i, i2);
    }

    static void M255cc856(byte[] bArr, int i, int i2, short s, byte[] bArr2, int i3, int i4) {
        if ((6 + 20) % 20 > 0) {
        }
        byte b = (byte) s;
        byte b2 = (byte) (s >> 8);
        byte[] bArr3 = new byte[2];
        bArr3[0] = b;
        bArr3[1] = b2;
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c p41b0f13cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(256, null, bArr3);
        p41b0f13cVar.update(bArr2, i3, i4);
        p41b0f13cVar.doFinal(bArr, i, i2);
    }

    static void Mb6d61d3b(byte[] bArr, int i, int i2, short s, byte[] bArr2, int i3, int i4) {
        if ((4 + 12) % 12 > 0) {
        }
        byte b = (byte) s;
        byte b2 = (byte) (s >> 8);
        byte[] bArr3 = new byte[2];
        bArr3[0] = b;
        bArr3[1] = b2;
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c p41b0f13cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p41b0f13c(128, null, bArr3);
        p41b0f13cVar.update(bArr2, i3, i4);
        p41b0f13cVar.doFinal(bArr, i, i2);
    }

    static void Me894f909(byte[] bArr, int i, int i2, byte[] bArr2, int i3, int i4) {
        if ((25 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256);
        p332ac7c7Var.update(bArr2, i3, i4);
        p332ac7c7Var.doFinal(bArr, i, i2);
    }
}

