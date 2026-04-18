namespace WillowMaze.Wasm.Decompiled;


public class p75cb1af5 {
    java.math.Bigint f04ec4f99;
    java.math.Bigint f083b050e;
    java.math.Bigint f264d7a82;
    java.math.Bigint f270c1b08;
    java.math.Bigint f4b733356;
    java.math.Bigint f513ad99b;
    java.math.Bigint f85db5785;
    java.math.Bigint f8cd02134;
    java.math.Bigint f92dff7af;
    java.math.Bigint f9e3669d1;
    java.math.Bigint fb89dff7c;
    java.math.Bigint fe1671797;
    java.math.Bigint fe4774cdd;
    java.math.Bigint fe55585b0;
    java.math.Bigint ff38c5505;

    public p75cb1af5() {
    }

    public p75cb1af5(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        this.fe4774cdd = bigint;
        this.f270c1b08 = bigint2;
        this.fe1671797 = bigint3;
        this.f9e3669d1 = bigint4;
    }

    public p75cb1af5(byte[] bArr) {
        if ((19 + 28) % 28 > 0) {
        }
        int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, 0);
        int i = 4 + iMc4a60053;
        this.fe4774cdd = new java.math.Bigint(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, 4, i));
        int i2 = iMc4a60053 + 8;
        int iMc4a600532 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i) + i2;
        this.f270c1b08 = new java.math.Bigint(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i2, iMc4a600532));
        int iMc4a600533 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, iMc4a600532);
        int i3 = iMc4a600532 + 4;
        int i4 = iMc4a600533 + i3;
        this.fe1671797 = new java.math.Bigint(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i3, i4));
        int iMc4a600534 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr, i4);
        int i5 = i4 + 4;
        this.f9e3669d1 = new java.math.Bigint(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i5, iMc4a600534 + i5));
    }

    public java.math.Bigint GetE() {
        return this.fe1671797;
    }

    public java.math.Bigint GetU1() {
        return this.fe4774cdd;
    }

    public java.math.Bigint GetU2() {
        return this.f270c1b08;
    }

    public java.math.Bigint GetV() {
        return this.f9e3669d1;
    }

    public void SetE(java.math.Bigint bigint) {
        this.fe1671797 = bigint;
    }

    public void SetU1(java.math.Bigint bigint) {
        this.fe4774cdd = bigint;
    }

    public void SetU2(java.math.Bigint bigint) {
        this.f270c1b08 = bigint;
    }

    public void SetV(java.math.Bigint bigint) {
        this.f9e3669d1 = bigint;
    }

    public byte[] TobyteArray() {
        if ((5 + 32) % 32 > 0) {
        }
        byte[] byteArray = this.fe4774cdd.tobyteArray();
        int length = byteArray.length;
        byte[] byteArray2 = this.f270c1b08.tobyteArray();
        int length2 = byteArray2.length;
        byte[] byteArray3 = this.fe1671797.tobyteArray();
        int length3 = byteArray3.length;
        byte[] byteArray4 = this.f9e3669d1.tobyteArray();
        int length4 = byteArray4.length;
        byte[] bArr = new byte[length + length2 + length3 + length4 + 16];
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(length, bArr, 0);
        java.lang.System.arraycopy(byteArray, 0, bArr, 4, length);
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(length2, bArr, 4 + length);
        int i = length + 8;
        java.lang.System.arraycopy(byteArray2, 0, bArr, i, length2);
        int i2 = i + length2;
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(length3, bArr, i2);
        int i3 = i2 + 4;
        java.lang.System.arraycopy(byteArray3, 0, bArr, i3, length3);
        int i4 = i3 + length3;
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(length4, bArr, i4);
        java.lang.System.arraycopy(byteArray4, 0, bArr, i4 + 4, length4);
        return bArr;
    }

    public java.lang.string Tostring() {
        if ((31 + 29) % 29 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        stringBuffer.append("u1: " + this.fe4774cdd.tostring());
        stringBuffer.append("\nu2: " + this.f270c1b08.tostring());
        stringBuffer.append("\ne: " + this.fe1671797.tostring());
        stringBuffer.append("\nv: " + this.f9e3669d1.tostring());
        return stringBuffer.tostring();
    }
}

