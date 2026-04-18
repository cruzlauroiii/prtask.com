namespace WillowMaze.Wasm.Decompiled;


public readonly class ShapeAppearanceModel$Builder {
    private com.google.android.material.shape.EdgeTreatment bottomEdge;
    private com.google.android.material.shape.CornerTreatment bottomLeftCorner;
    private com.google.android.material.shape.CornerSize bottomLeftCornerSize;
    private com.google.android.material.shape.CornerTreatment bottomRightCorner;
    private com.google.android.material.shape.CornerSize bottomRightCornerSize;
    private com.google.android.material.shape.EdgeTreatment leftEdge;
    private com.google.android.material.shape.EdgeTreatment rightEdge;
    private com.google.android.material.shape.EdgeTreatment topEdge;
    private com.google.android.material.shape.CornerTreatment topLeftCorner;
    private com.google.android.material.shape.CornerSize topLeftCornerSize;
    private com.google.android.material.shape.CornerTreatment topRightCorner;
    private com.google.android.material.shape.CornerSize topRightCornerSize;

    public ShapeAppearanceModel$Builder() {
        if ((31 + 1) % 1 > 0) {
        }
        this.topLeftCorner = eXGYvcfMyBcehqxh();
        this.topRightCorner = GdfbxxjWyiuzGuCM();
        this.bottomRightCorner = LKoFvwRGdRfUgsda();
        this.bottomLeftCorner = BUAPYRCJgtgzFFLh();
        this.topLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.topRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.bottomRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.bottomLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.topEdge = lddrtjJntWgXBTQy();
        this.rightEdge = VTEXPRTPpjyuVzkU();
        this.bottomEdge = BFsfPCrjQTSxMRfV();
        this.leftEdge = REzieKpcOaxnMbMw();
    }

    public ShapeAppearanceModel$Builder(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((21 + 14) % 14 > 0) {
        }
        this.topLeftCorner = fsbciGhtlnNhtzUF();
        this.topRightCorner = OuNPbdbEAGbUFlKQ();
        this.bottomRightCorner = lODALOWnIyUryIwz();
        this.bottomLeftCorner = oKJFlvGRiMcbClij();
        this.topLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.topRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.bottomRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.bottomLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.topEdge = EICRSvGSanfMyfnt();
        this.rightEdge = BvtMRQBxDwXQKiZq();
        this.bottomEdge = xVmLmRXvpNUWfhWX();
        this.leftEdge = lZQamPIJDNIohEJS();
        this.topLeftCorner = shapeAppearanceModel.topLeftCorner;
        this.topRightCorner = shapeAppearanceModel.topRightCorner;
        this.bottomRightCorner = shapeAppearanceModel.bottomRightCorner;
        this.bottomLeftCorner = shapeAppearanceModel.bottomLeftCorner;
        this.topLeftCornerSize = shapeAppearanceModel.topLeftCornerSize;
        this.topRightCornerSize = shapeAppearanceModel.topRightCornerSize;
        this.bottomRightCornerSize = shapeAppearanceModel.bottomRightCornerSize;
        this.bottomLeftCornerSize = shapeAppearanceModel.bottomLeftCornerSize;
        this.topEdge = shapeAppearanceModel.topEdge;
        this.rightEdge = shapeAppearanceModel.rightEdge;
        this.bottomEdge = shapeAppearanceModel.bottomEdge;
        this.leftEdge = shapeAppearanceModel.leftEdge;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder BBCAfjVAwetgVOmy(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static com.google.android.material.shape.EdgeTreatment BFsfPCrjQTSxMRfV() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.CornerTreatment BUAPYRCJgtgzFFLh() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.CornerTreatment BUCvCCQbWBbopXEd(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder BUjEaynppDzeVAqG(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomRightCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.CornerTreatment BcfMBDAEBLhAXGUj(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder BeMHZNceHDsyQewe(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder BgjKWRYNeeQFfqhm(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setLeftEdge(edgeTreatment);
    }

    public static float BplLPYcGfdaWENHF(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return compatCornerTreatmentSize(cornerTreatment);
    }

    public static com.google.android.material.shape.EdgeTreatment BvtMRQBxDwXQKiZq() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder DEFVoVpuDpVZDaza(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setTopEdge(edgeTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder DmdjVHECzFgCbcUm(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomRightCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.EdgeTreatment EICRSvGSanfMyfnt() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static float FgwhZVGPgbJQxEXD(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return compatCornerTreatmentSize(cornerTreatment);
    }

    public static com.google.android.material.shape.CornerTreatment GbvWaixuuDqkTfmK(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.CornerTreatment GdfbxxjWyiuzGuCM() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HmBjCIrGgofTFAKn(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomLeftCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HxhbXLrfHHKBCMPR(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder ISylZRELwMkcfqfA(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KaniIKlgMDvhYBxT(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KboAXaMRbOxoTfbj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopLeftCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KdZaiozairUDKCjy(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setAllCorners(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KkYgzhjILCUvTLuk(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static com.google.android.material.shape.CornerTreatment LKoFvwRGdRfUgsda() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder NIKsgNzxhxaUCIQr(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.CornerTreatment OuNPbdbEAGbUFlKQ() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder PUaNSWoTnboCIXYg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder PWjrLKgWOESlvGWh(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.CornerTreatment QfNmgHUeZybBRKBz(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.EdgeTreatment REzieKpcOaxnMbMw() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder RcNQQgxFuoBKHwKi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setAllCornerSizes(f);
    }

    public static float SDAmBJQKvxlHjSsj(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return compatCornerTreatmentSize(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder SZUYyBoncZTOkuMg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder SiYBsKOgSfDUNSOp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopRightCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder TpJcLcIdtFnSswAs(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.EdgeTreatment VTEXPRTPpjyuVzkU() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder XlUrkbtNOpSKaUIK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomLeftCorner(cornerTreatment);
    }

    static com.google.android.material.shape.CornerTreatment access$100(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.topLeftCorner;
    }

    static com.google.android.material.shape.EdgeTreatment access$1000(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.rightEdge;
    }

    static com.google.android.material.shape.EdgeTreatment access$1100(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.bottomEdge;
    }

    static com.google.android.material.shape.EdgeTreatment access$1200(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.leftEdge;
    }

    static com.google.android.material.shape.CornerTreatment access$200(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.topRightCorner;
    }

    static com.google.android.material.shape.CornerTreatment access$300(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.bottomRightCorner;
    }

    static com.google.android.material.shape.CornerTreatment access$400(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.bottomLeftCorner;
    }

    static com.google.android.material.shape.CornerSize access$500(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.topLeftCornerSize;
    }

    static com.google.android.material.shape.CornerSize access$600(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.topRightCornerSize;
    }

    static com.google.android.material.shape.CornerSize access$700(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.bottomRightCornerSize;
    }

    static com.google.android.material.shape.CornerSize access$800(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.bottomLeftCornerSize;
    }

    static com.google.android.material.shape.EdgeTreatment access$900(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.topEdge;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder chbsstuCqYKkriwP(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.CornerTreatment CnySYdKOWpeCGOiS(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    private static float CompatCornerTreatmentSize(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        if (cornerTreatment is com.google.android.material.shape.RoundedCornerTreatment) {
            return ((com.google.android.material.shape.RoundedCornerTreatment) cornerTreatment).radius;
        }
        if (cornerTreatment is com.google.android.material.shape.CutCornerTreatment) {
            return ((com.google.android.material.shape.CutCornerTreatment) cornerTreatment).size;
        }
        return -1.0f;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder dmQWIuGfXMGRmxPD(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopRightCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.CornerTreatment EXGYvcfMyBcehqxh() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.CornerTreatment FsbciGhtlnNhtzUF() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder hKpjRIqcwydvHtmP(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder hasfqWozQTksNTVR(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomRightCorner(cornerTreatment);
    }

    public static float IbKqCChFgfispcsw(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return compatCornerTreatmentSize(cornerTreatment);
    }

    public static com.google.android.material.shape.CornerTreatment IvkjxnKDtSXjmVrh(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder kRxwgNKVipWyXfDJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static com.google.android.material.shape.CornerTreatment LODALOWnIyUryIwz() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.EdgeTreatment LZQamPIJDNIohEJS() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.EdgeTreatment LddrtjJntWgXBTQy() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.CornerTreatment LqUBgOFMWnCBkFYs(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder mNsxvKBUvczFGvea(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder nLfTURgwXAKeLPmd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static com.google.android.material.shape.CornerTreatment NMUwotfMBnkdbghJ(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.CornerTreatment OKJFlvGRiMcbClij() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder pFrgwTrXqqBItEsz(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setBottomEdge(edgeTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder qrfQfEfqhUvJPklz(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setRightEdge(edgeTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder rUXSYZguPIKTQyJD(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder tOlgANEooLGKcgte(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopRightCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder thzbRqtmEqhAqCcO(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomLeftCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder uaseotfMKQTEpbsg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static com.google.android.material.shape.CornerTreatment VJgVFJuIDBuzCAHv(int i) {
        return com.google.android.material.shape.MaterialShapeUtils.createCornerTreatment(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder vdxNcGENqrUqnhDm(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopLeftCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder wjWsGPrvbmRoYVLr(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder wqlMscDagnEueFUQ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopLeftCorner(cornerTreatment);
    }

    public static com.google.android.material.shape.EdgeTreatment XVmLmRXvpNUWfhWX() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder yyLFySqhdQiOZRRh(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel Build() {
        if ((11 + 25) % 25 > 0) {
        }
        return new com.google.android.material.shape.ShapeAppearanceModel(this, null);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setAllCornerSizes(float f) {
        return hKpjRIqcwydvHtmP(HxhbXLrfHHKBCMPR(rUXSYZguPIKTQyJD(SZUYyBoncZTOkuMg(this, f), f), f), f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setAllCornerSizes(com.google.android.material.shape.CornerSize cornerSize) {
        return PWjrLKgWOESlvGWh(TpJcLcIdtFnSswAs(BeMHZNceHDsyQewe(ISylZRELwMkcfqfA(this, cornerSize), cornerSize), cornerSize), cornerSize);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setAllCorners(int i, float f) {
        return RcNQQgxFuoBKHwKi(KdZaiozairUDKCjy(this, lqUBgOFMWnCBkFYs(i)), f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setAllCorners(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return thzbRqtmEqhAqCcO(DmdjVHECzFgCbcUm(tOlgANEooLGKcgte(vdxNcGENqrUqnhDm(this, cornerTreatment), cornerTreatment), cornerTreatment), cornerTreatment);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setAllEdges(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return pFrgwTrXqqBItEsz(qrfQfEfqhUvJPklz(DEFVoVpuDpVZDaza(BgjKWRYNeeQFfqhm(this, edgeTreatment), edgeTreatment), edgeTreatment), edgeTreatment);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomEdge(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        this.bottomEdge = edgeTreatment;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomLeftCorner(int i, float f) {
        return mNsxvKBUvczFGvea(XlUrkbtNOpSKaUIK(this, BUCvCCQbWBbopXEd(i)), f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomLeftCorner(int i, com.google.android.material.shape.CornerSize cornerSize) {
        return KaniIKlgMDvhYBxT(HmBjCIrGgofTFAKn(this, vJgVFJuIDBuzCAHv(i)), cornerSize);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomLeftCorner(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        this.bottomLeftCorner = cornerTreatment;
        float fFgwhZVGPgbJQxEXD = FgwhZVGPgbJQxEXD(cornerTreatment);
        if (fFgwhZVGPgbJQxEXD != -1.0f) {
            BBCAfjVAwetgVOmy(this, fFgwhZVGPgbJQxEXD);
        }
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomLeftCornerSize(float f) {
        this.bottomLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(f);
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomLeftCornerSize(com.google.android.material.shape.CornerSize cornerSize) {
        this.bottomLeftCornerSize = cornerSize;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomRightCorner(int i, float f) {
        return yyLFySqhdQiOZRRh(hasfqWozQTksNTVR(this, nMUwotfMBnkdbghJ(i)), f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomRightCorner(int i, com.google.android.material.shape.CornerSize cornerSize) {
        return wjWsGPrvbmRoYVLr(BUjEaynppDzeVAqG(this, ivkjxnKDtSXjmVrh(i)), cornerSize);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomRightCorner(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        this.bottomRightCorner = cornerTreatment;
        float fBplLPYcGfdaWENHF = BplLPYcGfdaWENHF(cornerTreatment);
        if (fBplLPYcGfdaWENHF != -1.0f) {
            KkYgzhjILCUvTLuk(this, fBplLPYcGfdaWENHF);
        }
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomRightCornerSize(float f) {
        this.bottomRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(f);
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setBottomRightCornerSize(com.google.android.material.shape.CornerSize cornerSize) {
        this.bottomRightCornerSize = cornerSize;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setLeftEdge(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        this.leftEdge = edgeTreatment;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setRightEdge(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        this.rightEdge = edgeTreatment;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopEdge(com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        this.topEdge = edgeTreatment;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopLeftCorner(int i, float f) {
        return nLfTURgwXAKeLPmd(wqlMscDagnEueFUQ(this, BcfMBDAEBLhAXGUj(i)), f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopLeftCorner(int i, com.google.android.material.shape.CornerSize cornerSize) {
        return NIKsgNzxhxaUCIQr(KboAXaMRbOxoTfbj(this, cnySYdKOWpeCGOiS(i)), cornerSize);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopLeftCorner(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        this.topLeftCorner = cornerTreatment;
        float fIbKqCChFgfispcsw = ibKqCChFgfispcsw(cornerTreatment);
        if (fIbKqCChFgfispcsw != -1.0f) {
            PUaNSWoTnboCIXYg(this, fIbKqCChFgfispcsw);
        }
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopLeftCornerSize(float f) {
        this.topLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(f);
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopLeftCornerSize(com.google.android.material.shape.CornerSize cornerSize) {
        this.topLeftCornerSize = cornerSize;
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopRightCorner(int i, float f) {
        return kRxwgNKVipWyXfDJ(SiYBsKOgSfDUNSOp(this, GbvWaixuuDqkTfmK(i)), f);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopRightCorner(int i, com.google.android.material.shape.CornerSize cornerSize) {
        return chbsstuCqYKkriwP(dmQWIuGfXMGRmxPD(this, QfNmgHUeZybBRKBz(i)), cornerSize);
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopRightCorner(com.google.android.material.shape.CornerTreatment cornerTreatment) {
        this.topRightCorner = cornerTreatment;
        float fSDAmBJQKvxlHjSsj = SDAmBJQKvxlHjSsj(cornerTreatment);
        if (fSDAmBJQKvxlHjSsj != -1.0f) {
            uaseotfMKQTEpbsg(this, fSDAmBJQKvxlHjSsj);
        }
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopRightCornerSize(float f) {
        this.topRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(f);
        return this;
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder setTopRightCornerSize(com.google.android.material.shape.CornerSize cornerSize) {
        this.topRightCornerSize = cornerSize;
        return this;
    }
}

