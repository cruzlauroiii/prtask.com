namespace WillowMaze.Wasm.Decompiled;


public class pc03b0fe3 : p5a445d71.p9f931cf3.p5ae9b7f2.p873e950b {
    byte[] f9e81e7b9;
    byte[] fafcadb34;
    byte[] fc534fb6d;
    byte[] fdf59df25;
    byte[] feef99925;
    byte[] ff0b53b2d;
    byte[] ff9c499c8;

    public pc03b0fe3(byte[] bArr, byte[] bArr2) {
        this.f9e81e7b9 = bArr;
        this.ff0b53b2d = bArr2;
    }

    public byte[] GetIV() {
        return this.ff0b53b2d;
    }

    public byte[] GetSharedSecret() {
        return this.f9e81e7b9;
    }
}

