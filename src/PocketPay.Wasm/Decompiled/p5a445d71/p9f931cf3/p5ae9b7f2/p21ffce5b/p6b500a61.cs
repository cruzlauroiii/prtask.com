namespace WillowMaze.Wasm.Decompiled;


public class p6b500a61 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private java.math.Bigint f0120a4f9;
    private java.math.Bigint f2c3fd828;
    private java.math.Bigint f32a1ec9d;
    private java.math.Bigint f3a1a7540;
    private java.math.Bigint f42f69a9b;
    private java.math.Bigint f60f5bf18;
    private java.math.Bigint f73444849;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7baa0a5d;
    private java.math.Bigint f83878c91;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f856f22d7;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fb1f7a8a0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc1d9f50f;
    private java.math.Bigint fc7eeb66b;
    private java.math.Bigint fe1c80488;

    public p6b500a61(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f83878c91 = bigint;
        this.f0120a4f9 = bigint2;
        this.fe1c80488 = bigint3;
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = (p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515) ((p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) pe5cfc515Var).copy();
        this.fc1d9f50f = pe5cfc515Var2;
        pe5cfc515Var2.reset();
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 11) % 11 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61 p6b500a61Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p6b500a61) obj;
        return p6b500a61Var.getP().Equals(this.f83878c91) && p6b500a61Var.getG1().Equals(this.f0120a4f9) && p6b500a61Var.getG2().Equals(this.fe1c80488);
    }

    public java.math.Bigint GetG1() {
        return this.f0120a4f9;
    }

    public java.math.Bigint GetG2() {
        return this.fe1c80488;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetH() {
        return (p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515) ((p5a445d71.p9f931cf3.p05c7e247.p4d7fdfb1) this.fc1d9f50f).copy();
    }

    public java.math.Bigint GetP() {
        return this.f83878c91;
    }

    public int HashCode() {
        if ((17 + 8) % 8 > 0) {
        }
        return getG2().GetHashCode() ^ (getP().GetHashCode() ^ getG1().GetHashCode());
    }
}

