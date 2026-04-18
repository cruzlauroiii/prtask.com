namespace WillowMaze.Wasm.Decompiled;


public class pa4c34d72 : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 f08406a6e;
    private readonly int f2181fa1f;
    private readonly int f43a2816a;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 f94f08cdf;
    private readonly int fe81ad63b;
    private readonly int ff04c93f7;

    public pa4c34d72(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var) {
        this.f08406a6e = pe85be1b2Var;
        this.fe81ad63b = 128;
    }

    public pa4c34d72(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var, int i) {
        this.f08406a6e = pe85be1b2Var;
        this.fe81ad63b = i;
    }

    public static int EugyRhapTecPrkJd(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var, byte[] bArr, int i) {
        return pe85be1b2Var.doFinal(bArr, i);
    }

    public static byte[] EvvsoPRDnRclSiMh(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static java.lang.string FqXcgrfcIEiitGiT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IKALWrfoPpvCniRD(p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 p21c8c989Var) {
        return p21c8c989Var.tostring();
    }

    public static java.lang.string KYcrxfOBdpnACVdC(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void TJtCYFhozRtdHKaG(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pe85be1b2Var.init(z, pc9ef6b45Var);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 TdEPFecnXWcvNjpy(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static java.lang.stringBuilder WztDVzpmShlLKPRu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YPxPGOmwpzFZRJaq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FrzBJIMZUnUmEmLj(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var, byte[] bArr, int i, int i2) {
        pe85be1b2Var.processAADbytes(bArr, i, i2);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 GeZTHBUGwpyZYMGM(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var) {
        return pe85be1b2Var.getUnderlyingCipher();
    }

    public static void NNAyCdRZBnmRNWmz(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var, byte b) {
        pe85be1b2Var.processAADbyte(b);
    }

    public static void TTvwWoOjvWGsyyOC(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pe85be1b2 pe85be1b2Var) {
        pe85be1b2Var.reset();
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        try {
            return EugyRhapTecPrkJd(this.f08406a6e, bArr, i);
        } catch (p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 e) {
            throw new java.lang.IllegalStateException(IKALWrfoPpvCniRD(e));
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return FqXcgrfcIEiitGiT(WztDVzpmShlLKPRu(YPxPGOmwpzFZRJaq(new java.lang.stringBuilder(), KYcrxfOBdpnACVdC(geZTHBUGwpyZYMGM(this.f08406a6e))), "-GMAC"));
    }

    public override int GetMacSize() {
        return this.fe81ad63b / 8;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((23 + 32) % 32 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("GMAC requires ParametersWithIV");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] bArrEvvsoPRDnRclSiMh = EvvsoPRDnRclSiMh(pdd5da44eVar);
        TJtCYFhozRtdHKaG(this.f08406a6e, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) TdEPFecnXWcvNjpy(pdd5da44eVar), this.fe81ad63b, bArrEvvsoPRDnRclSiMh));
    }

    public override void Reset() {
        tTvwWoOjvWGsyyOC(this.f08406a6e);
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        nNAyCdRZBnmRNWmz(this.f08406a6e, b);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        frzBJIMZUnUmEmLj(this.f08406a6e, bArr, i, i2);
    }
}

