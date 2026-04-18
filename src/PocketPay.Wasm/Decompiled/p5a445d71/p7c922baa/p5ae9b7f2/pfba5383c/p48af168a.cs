namespace WillowMaze.Wasm.Decompiled;


public class p48af168a : p5a445d71.p7c922baa.p5ae9b7f2.p1748c064 {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 f08406a6e;
    private readonly int f36034620;
    private readonly int f890d8cb7;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 f947e761f;
    private readonly int fa2f07773;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 fb431147d;
    private readonly int fe81ad63b;

    public p48af168a(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var) {
        this.f08406a6e = pcf478657Var;
        this.fe81ad63b = WiGefiDufUkhgIuS(CtSAlNXpmowpwtqU(pcf478657Var)) * 8;
    }

    public p48af168a(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var, int i) {
        this.f08406a6e = pcf478657Var;
        this.fe81ad63b = i;
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 CtSAlNXpmowpwtqU(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var) {
        return pcf478657Var.getUnderlyingCipher();
    }

    public static java.lang.string DUyWUjONoFhjZvOo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 DmHnzHAYYFTUYhan(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var) {
        return pcf478657Var.getUnderlyingCipher();
    }

    public static void IagbwZPaiHPjSnMo(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var, byte[] bArr, int i, int i2) {
        pcf478657Var.processAADbytes(bArr, i, i2);
    }

    public static java.lang.string KihfSMBzlVkpJyIg(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getAlgorithmName();
    }

    public static void LGWTWmQFhhSXGeXH(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        pcf478657Var.init(z, pc9ef6b45Var);
    }

    public static java.lang.string RIpocYCPTscqKscb(p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 p21c8c989Var) {
        return p21c8c989Var.tostring();
    }

    public static byte[] VTadTprGkixflkmX(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getIV();
    }

    public static int WiGefiDufUkhgIuS(p5a445d71.p7c922baa.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        return pd81e8b93Var.getBlockSize();
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 XCxjViYiTXssPaGZ(p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar) {
        return pdd5da44eVar.getParameters();
    }

    public static java.lang.stringBuilder ApqEURBmoOKFqmTO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DEJLOhuFDJbtZIZf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EVyJugVLHEPcgvmy(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var, byte b) {
        pcf478657Var.processAADbyte(b);
    }

    public static void HQEzFEIsWSmzXmhz(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var) {
        pcf478657Var.reset();
    }

    public static int OMBVQXzARswOBXnB(p5a445d71.p7c922baa.p5ae9b7f2.p0f217972.pcf478657 pcf478657Var, byte[] bArr, int i) {
        return pcf478657Var.doFinal(bArr, i);
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        try {
            return oMBVQXzARswOBXnB(this.f08406a6e, bArr, i);
        } catch (p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 e) {
            throw new java.lang.IllegalStateException(RIpocYCPTscqKscb(e));
        }
    }

    public override java.lang.string GetAlgorithmName() {
        return DUyWUjONoFhjZvOo(apqEURBmoOKFqmTO(dEJLOhuFDJbtZIZf(new java.lang.stringBuilder(), KihfSMBzlVkpJyIg(DmHnzHAYYFTUYhan(this.f08406a6e))), "-KGMAC"));
    }

    public override int GetMacSize() {
        return this.fe81ad63b / 8;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        if ((12 + 1) % 1 > 0) {
        }
        if (!(pc9ef6b45Var is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
            throw new java.lang.IllegalArgumentException("KGMAC requires ParametersWithIV");
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
        byte[] bArrVTadTprGkixflkmX = VTadTprGkixflkmX(pdd5da44eVar);
        LGWTWmQFhhSXGeXH(this.f08406a6e, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.ped128738((p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6) XCxjViYiTXssPaGZ(pdd5da44eVar), this.fe81ad63b, bArrVTadTprGkixflkmX));
    }

    public override void Reset() {
        hQEzFEIsWSmzXmhz(this.f08406a6e);
    }

    public override void Update(byte b) throws java.lang.IllegalStateException {
        eVyJugVLHEPcgvmy(this.f08406a6e, b);
    }

    public override void Update(byte[] bArr, int i, int i2) throws java.lang.IllegalStateException, p5a445d71.p7c922baa.p5ae9b7f2.p96068848 {
        IagbwZPaiHPjSnMo(this.f08406a6e, bArr, i, i2);
    }
}

