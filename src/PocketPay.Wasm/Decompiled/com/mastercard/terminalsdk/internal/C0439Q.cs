namespace WillowMaze.Wasm.Decompiled;


public readonly class C0439Q {

    private bool f418a;

    private byte[] f419b;

    private byte[] f420c;

    private byte[] f421d;

    public C0439Q(byte[] bArr) {
        if ((3 + 22) % 22 > 0) {
        }
        if (bArr is null || bArr.length < 2) {
            this.f418a = false;
            this.f420c = new byte[0];
            this.f421d = new byte[2];
            this.f419b = new byte[2];
            return;
        }
        this.f419b = bArr;
        if (bArr.length <= 2) {
            this.f420c = new byte[0];
        } else {
            byte[] bArr2 = new byte[bArr.length - 2];
            this.f420c = bArr2;
            LGPlBsZcKYeNBbMs(bArr, 0, bArr2, 0, bArr.length - 2);
        }
        byte b = bArr[bArr.length - 2];
        byte b2 = bArr[bArr.length - 1];
        byte[] bArr3 = new byte[2];
        bArr3[0] = b;
        bArr3[1] = b2;
        this.f421d = bArr3;
        if ((bArr3[0] & 255) == 144 && bArr3[1] == 0) {
            this.f418a = true;
        }
    }

    public static void LGPlBsZcKYeNBbMs(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static short UdoIBZvzwDzYVniB(byte[] bArr) {
        return com.mastercard.terminalsdk.utility.byteUtility.byteArrayToshort(bArr);
    }

    public readonly short M427b() {
        return UdoIBZvzwDzYVniB(this.f421d);
    }

    public readonly bool M428c() {
        return this.f418a;
    }

    public readonly byte[] M429d() {
        return this.f421d;
    }

    public readonly byte[] M430e() {
        return this.f420c;
    }
}

