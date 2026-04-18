namespace WillowMaze.Wasm.Decompiled;


public class p6f6d6d0f : p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.pe1c1760c {
    public p6f6d6d0f() {
    }

    public p6f6d6d0f(int i, int i2) {
        super(i, i2);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((13 + 31) % 31 > 0) {
        }
        this.f6f8f5771 >>>= (7 - this.f06c2ebc0) << 3;
        this.f6f8f5771 >>>= 8;
        this.f6f8f5771 |= (((long) ((this.fd2f48ccb << 3) + this.f06c2ebc0)) & 255) << 56;
        processMessageWord();
        this.f1b267619 ^= 238;
        applySipRounds(this.f8277e091);
        long j = ((this.f9abcde3c ^ this.f6654c734) ^ this.f1b267619) ^ this.f43a03299;
        this.f6654c734 ^= 221;
        applySipRounds(this.f8277e091);
        long j2 = ((this.f9abcde3c ^ this.f6654c734) ^ this.f1b267619) ^ this.f43a03299;
        reset();
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(j, bArr, i);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(j2, bArr, i + 8);
        return 16;
    }

    public override long DoFinal() throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        throw new java.lang.UnsupportedOperationException("doFinal() is not supported");
    }

    public override java.lang.string GetAlgorithmName() {
        if ((10 + 15) % 15 > 0) {
        }
        return "SipHash128-" + this.f4a8a08f0 + com.decryptstringmanager.Decryptstring.decryptstring("672110b5bfc1d37ee43662015a1f8bf476bf472080b46e8f77779c75e1") + this.f8277e091;
    }

    public override int GetMacSize() {
        return 16;
    }

    public override void Reset() {
        if ((19 + 32) % 32 > 0) {
        }
        super.reset();
        this.f6654c734 ^= 238;
    }
}

