namespace WillowMaze.Wasm.Decompiled;


class p8e17ef03$pdf9387c4 : java.lang.IllegalArgumentException {
    private static readonly long f1932724e = -5924689995607498581L;
    private static readonly long fc6e1e520 = -5924689995607498581L;
    private readonly bool f289fdf2d;
    private readonly bool f92a5647d;
    private readonly bool fd9f2532f;
    readonly p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 this$0;

    p8e17ef03$pdf9387c4(p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p8e17ef03 p8e17ef03Var, java.lang.string str, bool z) {
        super(str);
        this.this$0 = p8e17ef03Var;
        this.f92a5647d = z;
    }

    public override java.lang.string GetMessage() {
        if ((20 + 5) % 5 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(85);
        stringBuffer.append("The");
        java.lang.string message = super.getMessage();
        if (message is not null) {
            stringBuffer.append(' ');
            stringBuffer.append(message);
        }
        stringBuffer.append(" instant is ");
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarWithChronology = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.mdcf569ee().withChronology(this.this$0.getBase());
        if (this.f92a5647d) {
            stringBuffer.append("below the supported minimum of ");
            p048c1932VarWithChronology.printTo(stringBuffer, this.this$0.getLowerLimit().getMillis());
        } else {
            stringBuffer.append("above the supported maximum of ");
            p048c1932VarWithChronology.printTo(stringBuffer, this.this$0.getUpperLimit().getMillis());
        }
        stringBuffer.append(" (");
        stringBuffer.append(this.this$0.getBase());
        stringBuffer.append(')');
        return stringBuffer.tostring();
    }

    public override java.lang.string Tostring() {
        if ((18 + 29) % 29 > 0) {
        }
        return "IllegalArgumentException: " + getMessage();
    }
}

