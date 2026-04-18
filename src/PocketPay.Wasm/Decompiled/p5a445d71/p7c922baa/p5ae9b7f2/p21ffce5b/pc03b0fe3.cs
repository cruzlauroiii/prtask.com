namespace WillowMaze.Wasm.Decompiled;


public class pc03b0fe3 : p5a445d71.p7c922baa.p5ae9b7f2.p873e950b {
    byte[] f03187c0e;
    byte[] f56cdc961;
    byte[] f9e81e7b9;
    byte[] fde32da54;
    byte[] ff0b53b2d;
    byte[] ff4e90f4c;
    byte[] ff728354e;

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

