namespace WillowMaze.Wasm.Decompiled;


public class pbe9504a0 {
    private readonly java.lang.string f14cea2fc;
    private readonly java.lang.string f1bc31d95;
    private readonly java.lang.string f23ff6bb7;
    private readonly java.math.Bigint[] f28e3ee4c;
    private readonly java.lang.string f2f763deb;
    private readonly java.math.Bigint f3156b31a;
    private readonly java.math.Bigint[] f34ce8e1e;
    private readonly java.math.Bigint[] f52a6a736;
    private readonly java.math.Bigint f5af6e670;
    private readonly java.math.Bigint[] f5bbaed0f;
    private readonly java.math.Bigint f6bab8152;
    private readonly java.math.Bigint[] f816bb960;
    private readonly java.math.Bigint f8bc0445d;
    private readonly java.lang.string f8c437394;
    private readonly java.math.Bigint f9a385c9b;
    private readonly java.math.Bigint[] fa99bc9bc;
    private readonly java.math.Bigint[] fc35b0bd3;
    private readonly java.math.Bigint fe9232b5b;

    public pbe9504a0(java.lang.string str, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(str, "participantId");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigint, "gx1");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigint2, "gx2");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigintArr, "knowledgeProofForX1");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigintArr2, "knowledgeProofForX2");
        this.f14cea2fc = str;
        this.f9a385c9b = bigint;
        this.f8bc0445d = bigint2;
        this.f816bb960 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bigintArr, bigintArr.length);
        this.fa99bc9bc = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bigintArr2, bigintArr2.length);
    }

    public java.math.Bigint GetGx1() {
        return this.f9a385c9b;
    }

    public java.math.Bigint GetGx2() {
        return this.f8bc0445d;
    }

    public java.math.Bigint[] GetKnowledgeProofForX1() {
        java.math.Bigint[] bigintArr = this.f816bb960;
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bigintArr, bigintArr.length);
    }

    public java.math.Bigint[] GetKnowledgeProofForX2() {
        java.math.Bigint[] bigintArr = this.fa99bc9bc;
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bigintArr, bigintArr.length);
    }

    public java.lang.string GetParticipantId() {
        return this.f14cea2fc;
    }
}

