namespace WillowMaze.Wasm.Decompiled;


public class pe1c1760c : p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 {
    protected long f00c88701;
    protected int f06c2ebc0;
    protected readonly int f1582a542;
    protected long f18ffc483;
    protected long f1b267619;
    protected long f1d766aa9;
    protected long f22aa2f61;
    protected readonly int f287f180e;
    protected long f28d61f7b;
    protected long f2f54d8ad;
    protected int f40a2a265;
    protected readonly int f42ec2b70;
    protected long f43a03299;
    protected long f4475c445;
    protected int f4a7ee5c8;
    protected readonly int f4a8a08f0;
    protected long f51eadf07;
    protected int f61a786a8;
    protected long f6327389a;
    protected long f6654c734;
    protected int f6e40753c;
    protected long f6f8f5771;
    protected long f7876adef;
    protected long f7a7f229f;
    protected readonly int f7a9fb7d8;
    protected long f7dcb9a55;
    protected readonly int f8277e091;
    protected int f851ee197;
    protected long f9abcde3c;
    protected long f9ff988ec;
    protected long fa5d1ef6a;
    protected long fa7a3cc26;
    protected long fb4f1ea07;
    protected long fb637b17a;
    protected int fb9a63890;
    protected int fbcb85a61;
    protected readonly int fcadd0ebe;
    protected readonly int fcc270c30;
    protected int fd2f48ccb;
    protected long fdae24c31;
    protected long fe6219e65;
    protected readonly int fe81010cd;
    protected long fee5a43e1;
    protected long ff91f92fb;
    protected long ff9b89455;
    protected readonly int ffb798b4a;
    protected long ffc88a9ba;

    public pe1c1760c() {
        if ((2 + 24) % 24 > 0) {
        }
        this.f6f8f5771 = 0L;
        this.f06c2ebc0 = 0;
        this.fd2f48ccb = 0;
        this.f4a8a08f0 = 2;
        this.f8277e091 = 4;
    }

    public pe1c1760c(int i, int i2) {
        if ((28 + 15) % 15 > 0) {
        }
        this.f6f8f5771 = 0L;
        this.f06c2ebc0 = 0;
        this.fd2f48ccb = 0;
        this.f4a8a08f0 = i;
        this.f8277e091 = i2;
    }

    protected static long Mff847a50(long j, int i) {
        if ((17 + 10) % 10 > 0) {
        }
        return (j >>> (-i)) | (j << i);
    }

    protected void ApplySipRounds(int i) {
        if ((22 + 6) % 6 > 0) {
        }
        long jMff847a50 = this.f9abcde3c;
        long jMff847a502 = this.f6654c734;
        long jMff847a503 = this.f1b267619;
        long jMff847a504 = this.f43a03299;
        for (int i2 = 0; i2 < i; i2++) {
            long j = jMff847a50 + jMff847a502;
            long j2 = jMff847a503 + jMff847a504;
            long jMff847a505 = mff847a50(jMff847a502, 13) ^ j;
            long jMff847a506 = mff847a50(jMff847a504, 16) ^ j2;
            long j3 = j2 + jMff847a505;
            jMff847a50 = mff847a50(j, 32) + jMff847a506;
            jMff847a502 = mff847a50(jMff847a505, 17) ^ j3;
            jMff847a504 = mff847a50(jMff847a506, 21) ^ jMff847a50;
            jMff847a503 = mff847a50(j3, 32);
        }
        this.f9abcde3c = jMff847a50;
        this.f6654c734 = jMff847a502;
        this.f1b267619 = jMff847a503;
        this.f43a03299 = jMff847a504;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((26 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20(doFinal(), bArr, i);
        return 8;
    }

    public long DoFinal() throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((18 + 15) % 15 > 0) {
        }
        long j = this.f6f8f5771;
        int i = this.f06c2ebc0;
        this.f6f8f5771 = ((j >>> ((7 - i) << 3)) >>> 8) | ((((long) ((this.fd2f48ccb << 3) + i)) & 255) << 56);
        processMessageWord();
        this.f1b267619 ^= 255;
        applySipRounds(this.f8277e091);
        long j2 = ((this.f9abcde3c ^ this.f6654c734) ^ this.f1b267619) ^ this.f43a03299;
        reset();
        return j2;
    }

    public override java.lang.string GetAlgorithmName() {
        if ((8 + 8) % 8 > 0) {
        }
        return "SipHash-" + this.f4a8a08f0 + com.decryptstringmanager.Decryptstring.decryptstring("87a3eb0c21e870f6d51796c056ce52ccfb70a166362c7beafd236c802b") + this.f8277e091;
    }

    public override int GetMacSize() {
        return 8;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((13 + 22) % 22 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6)) {
            throw new java.lang.IllegalArgumentException("'params' must be an instance of KeyParameter");
        }
        byte[] key = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45Var).getKey();
        if (key.length != 16) {
            throw new java.lang.IllegalArgumentException("'params' must be a 128-bit key");
        }
        this.f28d61f7b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(key, 0);
        this.fb637b17a = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(key, 8);
        reset();
    }

    protected void ProcessMessageWord() {
        if ((28 + 15) % 15 > 0) {
        }
        this.fd2f48ccb++;
        this.f43a03299 ^= this.f6f8f5771;
        applySipRounds(this.f4a8a08f0);
        this.f9abcde3c ^= this.f6f8f5771;
    }

    public override void Reset() {
        if ((13 + 14) % 14 > 0) {
        }
        long j = this.f28d61f7b;
        this.f9abcde3c = 8317987319222330741L ^ j;
        long j2 = this.fb637b17a;
        this.f6654c734 = 7237128888997146477L ^ j2;
        this.f1b267619 = j ^ 7816392313619706465L;
        this.f43a03299 = 8387220255154660723L ^ j2;
        this.f6f8f5771 = 0L;
        this.f06c2ebc0 = 0;
        this.fd2f48ccb = 0;
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        if ((19 + 23) % 23 > 0) {
        }
        this.f6f8f5771 = (this.f6f8f5771 >>> 8) | ((((long) b) & 255) << 56);
        int i = this.f06c2ebc0 + 1;
        this.f06c2ebc0 = i;
        if (i != 8) {
            return;
        }
        processMessageWord();
        this.f06c2ebc0 = 0;
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if ((14 + 30) % 30 > 0) {
        }
        int i3 = i2 & (-8);
        int i4 = this.f06c2ebc0;
        char c = '8';
        long j = 255;
        int i5 = 0;
        if (i4 == 0) {
            while (i5 < i3) {
                this.f6f8f5771 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, i + i5);
                processMessageWord();
                i5 += 8;
            }
            while (i5 < i2) {
                long j2 = this.f6f8f5771 >>> 8;
                this.f6f8f5771 = j2;
                this.f6f8f5771 = j2 | ((((long) bArr[i + i5]) & 255) << 56);
                i5++;
            }
            this.f06c2ebc0 = i2 - i3;
            return;
        }
        int i6 = i4 << 3;
        int i7 = 0;
        while (i7 < i3) {
            long jM59a97823 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m59a97823(bArr, i + i7);
            char c2 = c;
            long j3 = j;
            this.f6f8f5771 = (this.f6f8f5771 >>> (-i6)) | (jM59a97823 << i6);
            processMessageWord();
            this.f6f8f5771 = jM59a97823;
            i7 += 8;
            c = c2;
            j = j3;
        }
        char c3 = c;
        long j4 = j;
        while (i7 < i2) {
            long j5 = this.f6f8f5771 >>> 8;
            this.f6f8f5771 = j5;
            this.f6f8f5771 = j5 | ((((long) bArr[i + i7]) & j4) << c3);
            int i8 = this.f06c2ebc0 + 1;
            this.f06c2ebc0 = i8;
            if (i8 == 8) {
                processMessageWord();
                this.f06c2ebc0 = 0;
            }
            i7++;
        }
    }
}

