namespace WillowMaze.Wasm.Decompiled;


public class p5481c09f {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f05b7653b;
    protected java.math.Bigint f276d8292;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f363fbfcf;
    protected java.math.Bigint f44d95a03;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f875bc70b;
    protected java.math.Bigint f8d9c307c;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f8e9e377c;
    protected java.math.Bigint fb0ee780d;
    protected java.math.Bigint fb2f5ff47;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    protected java.math.Bigint fe522c106;

    public java.math.Bigint GenerateVerifier(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((7 + 16) % 16 > 0) {
        }
        return this.fb2f5ff47.modPow(p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.mb106c8d8(this.fc10f7796, this.f8d9c307c, bArr, bArr2, bArr3), this.f8d9c307c);
    }

    public void Init(java.math.Bigint bigint, java.math.Bigint bigint2, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f8d9c307c = bigint;
        this.fb2f5ff47 = bigint2;
        this.fc10f7796 = pe5cfc515Var;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb04788ab pb04788abVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f8d9c307c = pb04788abVar.getN();
        this.fb2f5ff47 = pb04788abVar.getG();
        this.fc10f7796 = pe5cfc515Var;
    }
}

