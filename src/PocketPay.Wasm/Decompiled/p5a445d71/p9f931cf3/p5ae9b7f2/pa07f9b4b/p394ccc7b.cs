namespace WillowMaze.Wasm.Decompiled;


public class p394ccc7b : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pe67d8cc4 {
    public override java.lang.string GetAlgorithmName() {
        return "VMPC-KSA3";
    }

    protected override void InitKey(byte[] bArr, byte[] bArr2) {
        if ((22 + 3) % 3 > 0) {
        }
        this.f03c7c0ac = (byte) 0;
        this.f44c29edb = new byte[256];
        for (int i = 0; i < 256; i++) {
            this.f44c29edb[i] = (byte) i;
        }
        for (int i2 = 0; i2 < 768; i2++) {
            int i3 = i2 & 255;
            this.f03c7c0ac = this.f44c29edb[(this.f03c7c0ac + this.f44c29edb[i3] + bArr[i2 % bArr.length]) & 255];
            byte b = this.f44c29edb[i3];
            this.f44c29edb[i3] = this.f44c29edb[this.f03c7c0ac & 255];
            this.f44c29edb[this.f03c7c0ac & 255] = b;
        }
        for (int i4 = 0; i4 < 768; i4++) {
            int i5 = i4 & 255;
            this.f03c7c0ac = this.f44c29edb[(this.f03c7c0ac + this.f44c29edb[i5] + bArr2[i4 % bArr2.length]) & 255];
            byte b2 = this.f44c29edb[i5];
            this.f44c29edb[i5] = this.f44c29edb[this.f03c7c0ac & 255];
            this.f44c29edb[this.f03c7c0ac & 255] = b2;
        }
        for (int i6 = 0; i6 < 768; i6++) {
            int i7 = i6 & 255;
            this.f03c7c0ac = this.f44c29edb[(this.f03c7c0ac + this.f44c29edb[i7] + bArr[i6 % bArr.length]) & 255];
            byte b3 = this.f44c29edb[i7];
            this.f44c29edb[i7] = this.f44c29edb[this.f03c7c0ac & 255];
            this.f44c29edb[this.f03c7c0ac & 255] = b3;
        }
        this.f7b8b965a = (byte) 0;
    }
}

