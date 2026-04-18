namespace WillowMaze.Wasm.Decompiled;


public class p10545ac6 {
    protected java.math.Bigint f02b02c2a;
    protected java.math.Bigint f0c93a93f;
    protected java.math.Bigint f0cc175b9;
    protected java.math.Bigint f18398183;
    protected java.math.Bigint f239fff55;
    protected java.security.SecureRandom f2d5978ba;
    protected java.math.Bigint f2de1316c;
    protected java.math.Bigint f33c546ca;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f408c88d3;
    protected java.math.Bigint f4f464dbf;
    protected java.math.Bigint f546c9016;
    protected java.math.Bigint f54942286;
    protected java.math.Bigint f55c3bb4d;
    protected java.math.Bigint f5dbc98dc;
    protected java.math.Bigint f5e08f6bd;
    protected java.math.Bigint f641fa10c;
    protected java.math.Bigint f652df8d2;
    protected java.math.Bigint f6728c220;
    protected java.math.Bigint f698265cf;
    protected java.math.Bigint f79cd7698;
    protected java.math.Bigint f7b774eff;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7dc622ce;
    protected java.security.SecureRandom f7ddf32e1;
    protected java.math.Bigint f7fc56270;
    protected java.math.Bigint f89735695;
    protected java.security.SecureRandom f8a90f116;
    protected java.math.Bigint f8d9c307c;
    protected java.math.Bigint f930b1167;
    protected java.math.Bigint f998f67fc;
    protected java.security.SecureRandom f9b436fdb;
    protected java.math.Bigint f9cfea029;
    protected java.math.Bigint f9d5ed678;
    protected java.math.Bigint f9d832253;
    protected java.math.Bigint f9dd4e461;
    protected java.math.Bigint fa03f0961;
    protected java.math.Bigint fa0a444d7;
    protected java.math.Bigint fa4fc6014;
    protected java.math.Bigint fa84d2b85;
    protected java.math.Bigint fae28c4fd;
    protected java.math.Bigint fb2f5ff47;
    protected java.security.SecureRandom fb30e0c88;
    protected java.math.Bigint fb485e122;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    protected java.math.Bigint fc297fb40;
    protected java.math.Bigint fc660a3d9;
    protected java.math.Bigint fcd2102c0;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fd23f4c01;
    protected java.math.Bigint fd4ec4132;
    protected java.math.Bigint fdd0c47f3;
    protected java.math.Bigint fdf450862;
    protected java.math.Bigint fdf69b560;
    protected java.math.Bigint fe50f0000;
    protected java.math.Bigint febbd2c3f;
    protected java.math.Bigint ff31e1eef;
    protected java.math.Bigint ff41f86f0;
    protected java.math.Bigint ff7dd2c14;

    private java.math.Bigint Me37de398() {
        if ((15 + 2) % 2 > 0) {
        }
        java.math.Bigint bigintMee4e4ba6 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.mee4e4ba6(this.fc10f7796, this.f8d9c307c, this.fb2f5ff47);
        return this.f9d5ed678.subtract(this.fb2f5ff47.modPow(this.f9dd4e461, this.f8d9c307c).multiply(bigintMee4e4ba6).mod(this.f8d9c307c)).mod(this.f8d9c307c).modPow(this.f7b774eff.multiply(this.f9dd4e461).Add(this.f0cc175b9), this.f8d9c307c);
    }

    public java.math.Bigint CalculateClientEvidenceMessage() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        java.math.Bigint bigint;
        java.math.Bigint bigint2;
        if ((11 + 22) % 22 > 0) {
        }
        java.math.Bigint bigint3 = this.f7fc56270;
        if (bigint3 is null || (bigint = this.f9d5ed678) is null || (bigint2 = this.f5dbc98dc) is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Impossible to compute M1: some data are missing from the previous operations (A,B,S)");
        }
        java.math.Bigint bigintMb9c46919 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.mb9c46919(this.fc10f7796, this.f8d9c307c, bigint3, bigint, bigint2);
        this.ff31e1eef = bigintMb9c46919;
        return bigintMb9c46919;
    }

    public java.math.Bigint CalculateSecret(java.math.Bigint bigint) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((7 + 9) % 9 > 0) {
        }
        java.math.Bigint bigintM991ef433 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m991ef433(this.f8d9c307c, bigint);
        this.f9d5ed678 = bigintM991ef433;
        this.f7b774eff = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m076fc050(this.fc10f7796, this.f8d9c307c, this.f7fc56270, bigintM991ef433);
        java.math.Bigint bigintMe37de398 = me37de398();
        this.f5dbc98dc = bigintMe37de398;
        return bigintMe37de398;
    }

    public java.math.Bigint CalculateSessionKey() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((2 + 14) % 14 > 0) {
        }
        java.math.Bigint bigint = this.f5dbc98dc;
        if (bigint is null || this.ff31e1eef is null || this.f9d832253 is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Impossible to compute Key: some data are missing from the previous operations (S,M1,M2)");
        }
        java.math.Bigint bigintMaf26c2e6 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.maf26c2e6(this.fc10f7796, this.f8d9c307c, bigint);
        this.f89735695 = bigintMaf26c2e6;
        return bigintMaf26c2e6;
    }

    public java.math.Bigint GenerateClientCredentials(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((30 + 1) % 1 > 0) {
        }
        this.f9dd4e461 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.mb106c8d8(this.fc10f7796, this.f8d9c307c, bArr, bArr2, bArr3);
        java.math.Bigint bigintSelectPrivateValue = selectPrivateValue();
        this.f0cc175b9 = bigintSelectPrivateValue;
        java.math.Bigint bigintModPow = this.fb2f5ff47.modPow(bigintSelectPrivateValue, this.f8d9c307c);
        this.f7fc56270 = bigintModPow;
        return bigintModPow;
    }

    public void Init(java.math.Bigint bigint, java.math.Bigint bigint2, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.security.SecureRandom secureRandom) {
        this.f8d9c307c = bigint;
        this.fb2f5ff47 = bigint2;
        this.fc10f7796 = pe5cfc515Var;
        this.f7ddf32e1 = secureRandom;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb04788ab pb04788abVar, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.security.SecureRandom secureRandom) {
        init(pb04788abVar.getN(), pb04788abVar.getG(), pe5cfc515Var, secureRandom);
    }

    protected java.math.Bigint SelectPrivateValue() {
        if ((12 + 19) % 19 > 0) {
        }
        return p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m34362738(this.fc10f7796, this.f8d9c307c, this.fb2f5ff47, this.f7ddf32e1);
    }

    public bool VerifyServerEvidenceMessage(java.math.Bigint bigint) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        java.math.Bigint bigint2;
        java.math.Bigint bigint3;
        if ((24 + 6) % 6 > 0) {
        }
        java.math.Bigint bigint4 = this.f7fc56270;
        if (bigint4 is null || (bigint2 = this.ff31e1eef) is null || (bigint3 = this.f5dbc98dc) is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Impossible to compute and verify M2: some data are missing from the previous operations (A,M1,S)");
        }
        if (!p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m9a1a84bb(this.fc10f7796, this.f8d9c307c, bigint4, bigint2, bigint3).Equals(bigint)) {
            return false;
        }
        this.f9d832253 = bigint;
        return true;
    }
}

