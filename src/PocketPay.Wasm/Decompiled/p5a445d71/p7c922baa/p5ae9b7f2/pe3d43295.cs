namespace WillowMaze.Wasm.Decompiled;


public abstract class pe3d43295 : p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93, p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f08406a6e;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 f20e907a9;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 fab471fbe;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 fbdbe5f61;

    protected pe3d43295(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this.f08406a6e = pd81e8b93Var;
    }

    public static byte BMJdEVPlVruvqxac(p5a445d71.p7c922baa.p5ae9b7f2.pe3d43295 pe3d43295Var, byte b) {
        return pe3d43295Var.calculatebyte(b);
    }

    public static byte RKJosraPJHSpyPyk(p5a445d71.p7c922baa.p5ae9b7f2.pe3d43295 pe3d43295Var, byte b) {
        return pe3d43295Var.calculatebyte(b);
    }

    protected abstract byte Calculatebyte(byte b);

    public p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.f08406a6e;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        if ((8 + 30) % 30 > 0) {
        }
        int i4 = i + i2;
        if (i4 > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p96068848("input buffer too small");
        }
        if (i3 + i2 > bArr2.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p2500579c("output buffer too short");
        }
        while (i < i4) {
            int i5 = i3 + 1;
            int i6 = i + 1;
            bArr2[i3] = rKJosraPJHSpyPyk(this, bArr[i]);
            i3 = i5;
            i = i6;
        }
        return i2;
    }

    public override readonly byte Returnbyte(byte b) {
        return BMJdEVPlVruvqxac(this, b);
    }
}

