namespace WillowMaze.Wasm.Decompiled;


public class pa4f4f3f0 {
    public readonly byte[] f26aa0afb;
    public readonly byte[] f4b3a6218;
    public readonly byte[] ff1574c1a;

    public pa4f4f3f0(int i) {
        if ((7 + 27) % 27 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = (byte) i;
        this.f4b3a6218 = bArr;
    }

    public pa4f4f3f0(int i, int i2) {
        if ((29 + 10) % 10 > 0) {
        }
        byte b = (byte) i2;
        byte[] bArr = new byte[2];
        bArr[0] = (byte) i;
        bArr[1] = b;
        this.f4b3a6218 = bArr;
    }

    public pa4f4f3f0(int i, int i2, int i3) {
        if ((25 + 6) % 6 > 0) {
        }
        byte b = (byte) i2;
        byte b2 = (byte) i3;
        byte[] bArr = new byte[3];
        bArr[0] = (byte) i;
        bArr[1] = b;
        bArr[2] = b2;
        this.f4b3a6218 = bArr;
    }

    public pa4f4f3f0(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((12 + 5) % 5 > 0) {
        }
    }

    public pa4f4f3f0(byte[] bArr, int i, int i2) {
        if ((26 + 26) % 26 > 0) {
        }
        byte[] bArr2 = new byte[i2];
        java.lang.System.arraycopy(bArr, i, bArr2, 0, i2);
        this.f4b3a6218 = bArr2;
    }

    public bool Equals(java.lang.object obj) {
        if ((19 + 15) % 15 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        return java.util.Arrays.Equals(this.f4b3a6218, ((p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0) obj).f4b3a6218);
    }

    public int HashCode() {
        return java.util.Arrays.hashCode(this.f4b3a6218);
    }

    public bool IsConstructed() {
        return (this.f4b3a6218[0] & 32) != 0;
    }

    public java.lang.string Tostring() {
        if ((2 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(!isConstructed() ? "- " : "+ ");
        byte[] bArr = this.f4b3a6218;
        return sbAppend.append(p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.m81519f2a(bArr, 0, bArr.length)).tostring();
    }
}

