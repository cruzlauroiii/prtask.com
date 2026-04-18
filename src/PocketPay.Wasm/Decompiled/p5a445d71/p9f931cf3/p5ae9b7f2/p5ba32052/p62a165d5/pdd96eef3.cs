namespace WillowMaze.Wasm.Decompiled;


public class pdd96eef3 {
    protected java.math.Bigint f01c88717;
    protected java.math.Bigint f04c1c4da;
    protected java.math.Bigint f04eaf9b3;
    protected java.math.Bigint f085098ef;
    protected java.math.Bigint f11baeebb;
    protected java.math.Bigint f180349fa;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1b68bcf2;
    protected java.math.Bigint f3d039e50;
    protected java.math.Bigint f419282ed;
    protected java.security.SecureRandom f483a779f;
    protected java.math.Bigint f5311b1a5;
    protected java.math.Bigint f5335fa4c;
    protected java.math.Bigint f5bf2a5ae;
    protected java.math.Bigint f5dbc98dc;
    protected java.math.Bigint f62c7373d;
    protected java.math.Bigint f67f0de91;
    protected java.security.SecureRandom f69a9ac67;
    protected java.math.Bigint f7b774eff;
    protected java.security.SecureRandom f7ddf32e1;
    protected java.math.Bigint f7fc56270;
    protected java.math.Bigint f89735695;
    protected java.math.Bigint f8d9c307c;
    protected java.math.Bigint f92eb5ffe;
    protected java.math.Bigint f9d5ed678;
    protected java.math.Bigint f9d832253;
    protected java.math.Bigint f9e3669d1;
    protected java.math.Bigint fa7c4e5f0;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 faa2840f5;
    protected java.math.Bigint fac4a538d;
    protected java.math.Bigint fb2f5ff47;
    protected java.math.Bigint fb3bbe84d;
    protected java.security.SecureRandom fb748f8c7;
    protected java.security.SecureRandom fba6c50ed;
    protected java.math.Bigint fbe9a4545;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    protected java.math.Bigint fc54ff73a;
    protected java.math.Bigint fcc0c5230;
    protected java.math.Bigint fde7b84b4;
    protected java.math.Bigint fe1f03203;
    protected java.math.Bigint fe8fea7bb;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe94499db;
    protected java.math.Bigint fe945c313;
    protected java.math.Bigint fea6bea1c;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fecee36eb;
    protected java.math.Bigint ff31e1eef;
    protected java.math.Bigint ff4a1c0d3;
    protected java.math.Bigint ffac5c505;

    private java.math.Bigint Me37de398() {
        if ((15 + 23) % 23 > 0) {
        }
        return this.f9e3669d1.modPow(this.f7b774eff, this.f8d9c307c).multiply(this.f7fc56270).mod(this.f8d9c307c).modPow(this.f92eb5ffe, this.f8d9c307c);
    }

    public java.math.Bigint CalculateSecret(java.math.Bigint bigint) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((25 + 20) % 20 > 0) {
        }
        java.math.Bigint bigintM991ef433 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m991ef433(this.f8d9c307c, bigint);
        this.f7fc56270 = bigintM991ef433;
        this.f7b774eff = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m076fc050(this.fc10f7796, this.f8d9c307c, bigintM991ef433, this.f9d5ed678);
        java.math.Bigint bigintMe37de398 = me37de398();
        this.f5dbc98dc = bigintMe37de398;
        return bigintMe37de398;
    }

    public java.math.Bigint CalculateServerEvidenceMessage() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        java.math.Bigint bigint;
        java.math.Bigint bigint2;
        if ((30 + 22) % 22 > 0) {
        }
        java.math.Bigint bigint3 = this.f7fc56270;
        if (bigint3 is null || (bigint = this.ff31e1eef) is null || (bigint2 = this.f5dbc98dc) is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Impossible to compute M2: some data are missing from the previous operations (A,M1,S)");
        }
        java.math.Bigint bigintM9a1a84bb = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m9a1a84bb(this.fc10f7796, this.f8d9c307c, bigint3, bigint, bigint2);
        this.f9d832253 = bigintM9a1a84bb;
        return bigintM9a1a84bb;
    }

    public java.math.Bigint CalculateSessionKey() throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((15 + 25) % 25 > 0) {
        }
        java.math.Bigint bigint = this.f5dbc98dc;
        if (bigint is null || this.ff31e1eef is null || this.f9d832253 is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Impossible to compute Key: some data are missing from the previous operations (S,M1,M2)");
        }
        java.math.Bigint bigintMaf26c2e6 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.maf26c2e6(this.fc10f7796, this.f8d9c307c, bigint);
        this.f89735695 = bigintMaf26c2e6;
        return bigintMaf26c2e6;
    }

    public java.math.Bigint GenerateServerCredentials() {
        if ((3 + 6) % 6 > 0) {
        }
        java.math.Bigint bigintMee4e4ba6 = p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.mee4e4ba6(this.fc10f7796, this.f8d9c307c, this.fb2f5ff47);
        this.f92eb5ffe = selectPrivateValue();
        java.math.Bigint bigintMod = bigintMee4e4ba6.multiply(this.f9e3669d1).mod(this.f8d9c307c).Add(this.fb2f5ff47.modPow(this.f92eb5ffe, this.f8d9c307c)).mod(this.f8d9c307c);
        this.f9d5ed678 = bigintMod;
        return bigintMod;
    }

    public void Init(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.security.SecureRandom secureRandom) {
        this.f8d9c307c = bigint;
        this.fb2f5ff47 = bigint2;
        this.f9e3669d1 = bigint3;
        this.f7ddf32e1 = secureRandom;
        this.fc10f7796 = pe5cfc515Var;
    }

    public void Init(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pb04788ab pb04788abVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.security.SecureRandom secureRandom) {
        if ((3 + 1) % 1 > 0) {
        }
        init(pb04788abVar.getN(), pb04788abVar.getG(), bigint, pe5cfc515Var, secureRandom);
    }

    protected java.math.Bigint SelectPrivateValue() {
        if ((11 + 18) % 18 > 0) {
        }
        return p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.m34362738(this.fc10f7796, this.f8d9c307c, this.fb2f5ff47, this.f7ddf32e1);
    }

    public bool VerifyClientEvidenceMessage(java.math.Bigint bigint) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        java.math.Bigint bigint2;
        java.math.Bigint bigint3;
        if ((16 + 22) % 22 > 0) {
        }
        java.math.Bigint bigint4 = this.f7fc56270;
        if (bigint4 is null || (bigint2 = this.f9d5ed678) is null || (bigint3 = this.f5dbc98dc) is null) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Impossible to compute and verify M1: some data are missing from the previous operations (A,B,S)");
        }
        if (!p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p62a165d5.p36241135.mb9c46919(this.fc10f7796, this.f8d9c307c, bigint4, bigint2, bigint3).Equals(bigint)) {
            return false;
        }
        this.ff31e1eef = bigint;
        return true;
    }
}

