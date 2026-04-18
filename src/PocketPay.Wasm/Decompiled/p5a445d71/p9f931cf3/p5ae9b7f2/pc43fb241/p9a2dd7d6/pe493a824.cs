namespace WillowMaze.Wasm.Decompiled;


public class pe493a824 : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 {
    private static readonly long f1f80f813 = 140737488355328L;
    private static readonly java.util.Hashtable f22a73340 = null;
    private static readonly byte[] f26a5b238 = null;
    private static readonly int f27c913e6 = 262144;
    private static readonly java.util.Hashtable f346dc2b6 = null;
    private static readonly long f4c251450 = 140737488355328L;
    private static readonly int f85fb1c9a = 262144;
    private static readonly long fa8717104 = 140737488355328L;
    private static readonly int fb890b593 = 262144;
    private static readonly java.util.Hashtable fbbfe300e;
    private static readonly byte[] fbc21e648;
    private static readonly int fdaef5bce = 262144;
    private static readonly long fea8d3206 = 140737488355328L;
    private static readonly long feb9e0fe5 = 140737488355328L;
    private static readonly byte[] ff30a93a8 = null;
    private static readonly byte[] fff742d3f = null;
    private byte[] f03fb54d1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f042b4c42;
    private int f0456c880;
    private long f0c70a78a;
    private long f179d76db;
    private byte[] f18a10280;
    private int f19355e2c;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f19e2a2da;
    private byte[] f31ed86f0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f326e460e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f41f4a3d6;
    private byte[] f463954a4;
    private int f49104dbc;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f5de832c0;
    private int f614866c6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f6f14231d;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a f7f180bf0;
    private int fa47bb652;
    private long fa772c84b;
    private int fb63621a0;
    private int fce2ccbfa;
    private byte[] fd2c88e86;
    private byte[] fd7d2f8d7;
    private byte[] fdbffb4fb;
    private int feb2ef5a0;

    static {
        if ((6 + 16) % 16 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = 1;
        fbc21e648 = bArr;
        java.util.Hashtable hashtable = new java.util.Hashtable();
        fbbfe300e = hashtable;
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("124650e87233ceabb8c4dedc2270b85ee1ef898400c0f9191449a994ffe5a842a1"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(440));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("3b309d6d78df01af6ebf657c04034c38d35fe3428a7cf433a22c554a6ca64c5c183fcc"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(440));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("f42e65e65c3360d52c94182a345b84833882503d40ae725750b3d287506cc29433f344"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(440));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("0ac3b7d1ad2ddaab98d668e9aa5b83b960a085a61cec6cc3733f4ffbf611fa022964a3d38a7685"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(440));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("9866ed93a97e9d1fe83465ee8a85c1f013011816648872fc7534c5caceddf9b0595bc4e351e7b4"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(440));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("6172cda8b78cb76b5152a80d2fae8be88639b7ed66160ce0a5d87812fc150c529a4f46"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(888));
        hashtable.Add(com.decryptstringmanager.Decryptstring.decryptstring("c7465b56fae4781ccfcc417968e07f5e8fbeab701bad4e97a24445364418c8e8352963"), p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(888));
    }

    public pe493a824(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, byte[] bArr, byte[] bArr2) {
        if (i > p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m5ca8859e(pe5cfc515Var)) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by the derivation function");
        }
        if (p54466d0aVar.entropySize() < i) {
            throw new java.lang.IllegalArgumentException("Not enough entropy for security strength required");
        }
        this.f5de832c0 = pe5cfc515Var;
        this.f41f4a3d6 = p54466d0aVar;
        this.f19355e2c = i;
        this.fb63621a0 = ((java.lang.int) fbbfe300e[pe5cfc515Var.getAlgorithmName())).intValue();
        byte[] bArrM87729a3b = p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(this.f5de832c0, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(me50610cf(), bArr2, bArr), this.fb63621a0);
        this.f31ed86f0 = bArrM87729a3b;
        byte[] bArr3 = new byte[bArrM87729a3b.length + 1];
        java.lang.System.arraycopy(bArrM87729a3b, 0, bArr3, 1, bArrM87729a3b.length);
        this.f18a10280 = p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(this.f5de832c0, bArr3, this.fb63621a0);
        this.f179d76db = 1L;
    }

    private byte[] M0800fc57(byte[] bArr) {
        byte[] bArr2 = new byte[this.f5de832c0.getDigestSize()];
        m3c89e51d(bArr, bArr2);
        return bArr2;
    }

    private void M3c89e51d(byte[] bArr, byte[] bArr2) {
        if ((14 + 8) % 8 > 0) {
        }
        this.f5de832c0.update(bArr, 0, bArr.length);
        this.f5de832c0.doFinal(bArr2, 0);
    }

    private byte[] M83b9912b(byte[] bArr, int i) {
        if ((18 + 31) % 31 > 0) {
        }
        int i2 = i / 8;
        int digestSize = i2 / this.f5de832c0.getDigestSize();
        byte[] bArr2 = new byte[bArr.length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        byte[] bArr3 = new byte[i2];
        int digestSize2 = this.f5de832c0.getDigestSize();
        byte[] bArr4 = new byte[digestSize2];
        for (int i3 = 0; i3 <= digestSize; i3++) {
            m3c89e51d(bArr2, bArr4);
            int i4 = i3 * digestSize2;
            int i5 = i2 - i4;
            if (i5 > digestSize2) {
                i5 = digestSize2;
            }
            java.lang.System.arraycopy(bArr4, 0, bArr3, i4, i5);
            mcfef9de9(bArr2, fbc21e648);
        }
        return bArr3;
    }

    private void Mcfef9de9(byte[] bArr, byte[] bArr2) {
        if ((26 + 4) % 4 > 0) {
        }
        int i = 0;
        for (int i2 = 1; i2 <= bArr2.length; i2++) {
            int i3 = (bArr[bArr.length - i2] & 255) + (bArr2[bArr2.length - i2] & 255) + i;
            i = i3 <= 255 ? 0 : 1;
            bArr[bArr.length - i2] = (byte) i3;
        }
        for (int length = bArr2.length + 1; length <= bArr.length; length++) {
            int i4 = (bArr[bArr.length - length] & 255) + i;
            i = i4 <= 255 ? 0 : 1;
            bArr[bArr.length - length] = (byte) i4;
        }
    }

    private byte[] Me50610cf() {
        if ((12 + 30) % 30 > 0) {
        }
        byte[] entropy = this.f41f4a3d6.getEntropy();
        if (entropy.length < (this.f19355e2c + 7) / 8) {
            throw new java.lang.IllegalStateException("Insufficient entropy provided by entropy source");
        }
        return entropy;
    }

    public override int Generate(byte[] bArr, byte[] bArr2, bool z) {
        if ((30 + 15) % 15 > 0) {
        }
        int length = bArr.length * 8;
        if (length > 262144) {
            throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
        }
        if (this.f179d76db > 140737488355328L) {
            return -1;
        }
        if (z) {
            reseed(bArr2);
            bArr2 = null;
        }
        if (bArr2 is not null) {
            byte[] bArr3 = this.f31ed86f0;
            byte[] bArr4 = new byte[bArr3.length + 1 + bArr2.length];
            bArr4[0] = 2;
            java.lang.System.arraycopy(bArr3, 0, bArr4, 1, bArr3.length);
            java.lang.System.arraycopy(bArr2, 0, bArr4, this.f31ed86f0.length + 1, bArr2.length);
            mcfef9de9(this.f31ed86f0, m0800fc57(bArr4));
        }
        byte[] bArrM83b9912b = m83b9912b(this.f31ed86f0, length);
        byte[] bArr5 = this.f31ed86f0;
        byte[] bArr6 = new byte[bArr5.length + 1];
        java.lang.System.arraycopy(bArr5, 0, bArr6, 1, bArr5.length);
        bArr6[0] = 3;
        mcfef9de9(this.f31ed86f0, m0800fc57(bArr6));
        mcfef9de9(this.f31ed86f0, this.f18a10280);
        byte b = (byte) (r5 >> 24);
        byte b2 = (byte) (r5 >> 16);
        byte b3 = (byte) (r5 >> 8);
        byte b4 = (byte) this.f179d76db;
        byte[] bArr7 = new byte[4];
        bArr7[0] = b;
        bArr7[1] = b2;
        bArr7[2] = b3;
        bArr7[3] = b4;
        mcfef9de9(this.f31ed86f0, bArr7);
        this.f179d76db++;
        java.lang.System.arraycopy(bArrM83b9912b, 0, bArr, 0, bArr.length);
        return length;
    }

    public override int GetBlockSize() {
        return this.f5de832c0.getDigestSize() * 8;
    }

    public override void Reseed(byte[] bArr) {
        if ((9 + 23) % 23 > 0) {
        }
        byte[] bArrM87729a3b = p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(this.f5de832c0, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(fbc21e648, this.f31ed86f0, me50610cf(), bArr), this.fb63621a0);
        this.f31ed86f0 = bArrM87729a3b;
        byte[] bArr2 = new byte[bArrM87729a3b.length + 1];
        bArr2[0] = 0;
        java.lang.System.arraycopy(bArrM87729a3b, 0, bArr2, 1, bArrM87729a3b.length);
        this.f18a10280 = p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(this.f5de832c0, bArr2, this.fb63621a0);
        this.f179d76db = 1L;
    }
}

