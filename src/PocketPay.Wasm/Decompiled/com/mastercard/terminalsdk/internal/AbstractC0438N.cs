namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractC0438N {

    private byte[] f411a;

    private java.lang.string f412b;

    private readonly int f413c;

    private byte[] f414d;

    private byte f415e;

    private byte f416g;

    private bool f417i;

    public AbstractC0438N(byte b, byte b2, byte b3, byte b4, byte b5) {
        this.f413c = 4;
        this.f412b = "";
        this.f417i = false;
        kuFnVQMYWeaooHDX(this, b, b2, b3, b4);
        this.f416g = b5;
        this.f417i = true;
    }

    public AbstractC0438N(byte b, byte b2, byte b3, byte b4, byte[] bArr) {
        this.f413c = 4;
        this.f412b = "";
        this.f417i = false;
        IELGYFCMgXqGulkm(this, b, b2, b3, b4);
        QnQNzjvTbtObwFkB(this, bArr);
    }

    public AbstractC0438N(byte b, byte b2, byte b3, byte b4, byte[] bArr, byte b5) {
        this.f413c = 4;
        this.f412b = "";
        this.f417i = false;
        gQsmcYldjvHELPnc(this, b, b2, b3, b4);
        FfEODVctIOzHvQdy(this, bArr);
        this.f416g = b5;
        this.f417i = true;
    }

    public static void FfEODVctIOzHvQdy(com.mastercard.terminalsdk.internal.AbstractC0438N abstractC0438N, byte[] bArr) {
        abstractC0438N.m424b(bArr);
    }

    public static void IELGYFCMgXqGulkm(com.mastercard.terminalsdk.internal.AbstractC0438N abstractC0438N, byte b, byte b2, byte b3, byte b4) {
        abstractC0438N.m425d(b, b2, b3, b4);
    }

    public static void QnQNzjvTbtObwFkB(com.mastercard.terminalsdk.internal.AbstractC0438N abstractC0438N, byte[] bArr) {
        abstractC0438N.m424b(bArr);
    }

    public static void AgyDumwmREQuJFzh(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private void M424b(byte[] bArr) {
        this.f415e = (byte) bArr.length;
        this.f414d = bArr;
    }

    public static void CwjQvMpUsEIQQwwl(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    private readonly void M425d(byte b, byte b2, byte b3, byte b4) {
        byte[] bArr = new byte[4];
        this.f411a = bArr;
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
    }

    public static void GQsmcYldjvHELPnc(com.mastercard.terminalsdk.internal.AbstractC0438N abstractC0438N, byte b, byte b2, byte b3, byte b4) {
        abstractC0438N.m425d(b, b2, b3, b4);
    }

    public static java.lang.string KESTzImOHURYhGOW(java.lang.object obj) {
        return super.tostring();
    }

    public static void KuFnVQMYWeaooHDX(com.mastercard.terminalsdk.internal.AbstractC0438N abstractC0438N, byte b, byte b2, byte b3, byte b4) {
        abstractC0438N.m425d(b, b2, b3, b4);
    }

    public readonly byte[] M426e() {
        if ((22 + 15) % 15 > 0) {
        }
        byte[] bArr = this.f414d;
        int length = bArr is null ? 4 : bArr.length + 5;
        if (this.f417i) {
            length++;
        }
        byte[] bArr2 = new byte[length];
        agyDumwmREQuJFzh(this.f411a, 0, bArr2, 0, 4);
        byte[] bArr3 = this.f414d;
        if (bArr3 is not null) {
            byte b = this.f415e;
            bArr2[4] = b;
            cwjQvMpUsEIQQwwl(bArr3, 0, bArr2, 5, b & 255);
        }
        if (this.f417i) {
            bArr2[length - 1] = this.f416g;
        }
        return bArr2;
    }

    public readonly java.lang.string Tostring() {
        return kESTzImOHURYhGOW(this);
    }
}

