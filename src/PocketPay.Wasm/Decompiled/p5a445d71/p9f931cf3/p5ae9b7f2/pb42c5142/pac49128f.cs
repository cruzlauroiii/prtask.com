namespace WillowMaze.Wasm.Decompiled;


public class pac49128f : p5a445d71.p9f931cf3.p5ae9b7f2.pae380b4d {
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4a6c1060 f2d7f4c93;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4a6c1060 f3c6e0b8a;
    java.security.SecureRandom f7ddf32e1;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4a6c1060 f9e3f76d4;
    p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4a6c1060 fa52ff1cf;
    java.security.SecureRandom ffbd23c4e;

    public override java.math.Bigint[] GenerateSignature(byte[] bArr) {
        java.math.Bigint bigintM861a7ab4;
        if ((29 + 3) % 3 > 0) {
        }
        java.math.Bigint bigint = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(bArr));
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 parameters = this.f3c6e0b8a.getParameters();
        do {
            bigintM861a7ab4 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m861a7ab4(parameters.getQ().bitLength(), this.f7ddf32e1);
        } while (bigintM861a7ab4.compareTo(parameters.getQ()) >= 0);
        java.math.Bigint bigintMod = parameters.getA().modPow(bigintM861a7ab4, parameters.getP()).mod(parameters.getQ());
        java.math.Bigint bigintMod2 = bigintM861a7ab4.multiply(bigint).Add(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf) this.f3c6e0b8a).getX().multiply(bigintMod)).mod(parameters.getQ());
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintMod;
        bigintArr[1] = bigintMod2;
        return bigintArr;
    }

    public override java.math.Bigint GetOrder() {
        return this.f3c6e0b8a.getParameters().getQ();
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        if (!z) {
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8) pc9ef6b45Var;
            return;
        }
        if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007)) {
            this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf) pc9ef6b45Var;
        } else {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f7ddf32e1 = p4715f007Var.getRandom();
            this.f3c6e0b8a = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c2a10cf) p4715f007Var.getParameters();
        }
    }

    public override bool VerifySignature(byte[] bArr, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((26 + 14) % 14 > 0) {
        }
        java.math.Bigint bigint3 = new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m4d9c2073(bArr));
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c4e2d05 parameters = this.f3c6e0b8a.getParameters();
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(0L);
        if (bigintValueOf.compareTo(bigint) >= 0 || parameters.getQ().compareTo(bigint) <= 0 || bigintValueOf.compareTo(bigint2) >= 0 || parameters.getQ().compareTo(bigint2) <= 0) {
            return false;
        }
        java.math.Bigint bigintModPow = bigint3.modPow(parameters.getQ().subtract(new java.math.Bigint(com.decryptstringmanager.Decryptstring.decryptstring("779dc8fba718ff967d2decd7bfa4bf8bb77737a047c643cc8f98f3a0eb"))), parameters.getQ());
        return parameters.getA().modPow(bigint2.multiply(bigintModPow).mod(parameters.getQ()), parameters.getP()).multiply(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p23005be8) this.f3c6e0b8a).getY().modPow(parameters.getQ().subtract(bigint).multiply(bigintModPow).mod(parameters.getQ()), parameters.getP())).mod(parameters.getP()).mod(parameters.getQ()).Equals(bigint);
    }
}

