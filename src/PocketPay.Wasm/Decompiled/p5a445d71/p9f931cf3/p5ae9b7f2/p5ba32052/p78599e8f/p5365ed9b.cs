namespace WillowMaze.Wasm.Decompiled;


public class p5365ed9b {
    private readonly java.math.Bigint f0cc175b9;
    private readonly java.lang.string f14cea2fc;
    private readonly java.math.Bigint f4a22c75f;
    private readonly java.math.Bigint[] f60cbc37d;
    private readonly java.math.Bigint[] f611673be;
    private readonly java.math.Bigint[] f6710d215;
    private readonly java.math.Bigint[] f748a73a0;
    private readonly java.lang.string f94756abc;
    private readonly java.math.Bigint[] fcc514b3b;

    public p5365ed9b(java.lang.string str, java.math.Bigint bigint, java.math.Bigint[] bigintArr) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(str, "participantId");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigint, "a");
        p5a445d71.p9f931cf3.p5ae9b7f2.p5ba32052.p78599e8f.p65585024.m44e711df(bigintArr, "knowledgeProofForX2s");
        this.f14cea2fc = str;
        this.f0cc175b9 = bigint;
        this.f748a73a0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bigintArr, bigintArr.length);
    }

    public java.math.Bigint GetA() {
        return this.f0cc175b9;
    }

    public java.math.Bigint[] GetKnowledgeProofForX2s() {
        java.math.Bigint[] bigintArr = this.f748a73a0;
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m405b6268(bigintArr, bigintArr.length);
    }

    public java.lang.string GetParticipantId() {
        return this.f14cea2fc;
    }
}

