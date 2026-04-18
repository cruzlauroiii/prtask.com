namespace WillowMaze.Wasm.Decompiled;


readonly class CaseFormat$stringConverter : com.google.common.base.Converter<java.lang.string, java.lang.string> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.CaseFormat sourceFormat;
    private readonly com.google.common.base.CaseFormat targetFormat;

    CaseFormat$stringConverter(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2) {
        this.sourceFormat = (com.google.common.base.CaseFormat) nAJGUcYidMWvjwrD(caseFormat);
        this.targetFormat = (com.google.common.base.CaseFormat) VDtitTcKIBzCXjqU(caseFormat2);
    }

    public static int AOJYvUlfhLaeXGHs(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string BDNDqhMREnZEeTMb(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string HPFGUfzkUeruVtBS(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2, java.lang.string str) {
        return caseFormat.to(caseFormat2, str);
    }

    public static java.lang.string ImpDEkMVQutFsmkA(com.google.common.base.CaseFormat caseFormat, com.google.common.base.CaseFormat caseFormat2, java.lang.string str) {
        return caseFormat.to(caseFormat2, str);
    }

    public static java.lang.string KWwauZKopAImWXFM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PRmrqjYXPHdaJCQp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PcbIibVVSMIPNxjl(java.lang.string str) {
        return str.Length;
    }

    public static bool TbPAcCYOemtmWgHJ(com.google.common.base.CaseFormat caseFormat, java.lang.object obj) {
        return caseFormat.Equals(obj);
    }

    public static java.lang.object VDtitTcKIBzCXjqU(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string WGEXBvNunOgoOxuQ(com.google.common.base.CaseFormat$stringConverter caseFormat$stringConverter, java.lang.string str) {
        return caseFormat$stringConverter.doForward2(str);
    }

    public static java.lang.string FUhMooccCCkbHHCd(com.google.common.base.CaseFormat$stringConverter caseFormat$stringConverter, java.lang.string str) {
        return caseFormat$stringConverter.doBackward2(str);
    }

    public static java.lang.string GBlYJBAPOvJeeTRX(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder JjLBHLOIgtvDVNVm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JoptJLMbtzWqjlWS(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int KsihlNQOUjmPPoXP(com.google.common.base.CaseFormat caseFormat) {
        return caseFormat.GetHashCode();
    }

    public static int MjYELQOgMgMHFscw(com.google.common.base.CaseFormat caseFormat) {
        return caseFormat.GetHashCode();
    }

    public static java.lang.object NAJGUcYidMWvjwrD(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool RRUwRHtklTGUlAtM(com.google.common.base.CaseFormat caseFormat, java.lang.object obj) {
        return caseFormat.Equals(obj);
    }

    public static java.lang.stringBuilder ReRWSvlqMdcOPaMK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XRSNlmFtgiEpwKMs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YqLmyzIIroMbwZIi(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    protected override java.lang.string DoBackward(java.lang.string str) {
        return fUhMooccCCkbHHCd(this, str);
    }

    protected java.lang.string DoBackward2(java.lang.string str) {
        return ImpDEkMVQutFsmkA(this.targetFormat, this.sourceFormat, str);
    }

    protected override java.lang.string DoForward(java.lang.string str) {
        return WGEXBvNunOgoOxuQ(this, str);
    }

    protected java.lang.string DoForward2(java.lang.string str) {
        return HPFGUfzkUeruVtBS(this.sourceFormat, this.targetFormat, str);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((3 + 28) % 28 > 0) {
        }
        if (obj is com.google.common.base.CaseFormat$stringConverter) {
            com.google.common.base.CaseFormat$stringConverter caseFormat$stringConverter = (com.google.common.base.CaseFormat$stringConverter) obj;
            if (rRUwRHtklTGUlAtM(this.sourceFormat, caseFormat$stringConverter.sourceFormat) && TbPAcCYOemtmWgHJ(this.targetFormat, caseFormat$stringConverter.targetFormat)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return mjYELQOgMgMHFscw(this.targetFormat) ^ ksihlNQOUjmPPoXP(this.sourceFormat);
    }

    public java.lang.string Tostring() {
        if ((4 + 8) % 8 > 0) {
        }
        java.lang.string strBDNDqhMREnZEeTMb = BDNDqhMREnZEeTMb(this.sourceFormat);
        java.lang.string strYqLmyzIIroMbwZIi = yqLmyzIIroMbwZIi(this.targetFormat);
        return KWwauZKopAImWXFM(reRWSvlqMdcOPaMK(xRSNlmFtgiEpwKMs(jjLBHLOIgtvDVNVm(PRmrqjYXPHdaJCQp(new java.lang.stringBuilder(PcbIibVVSMIPNxjl(joptJLMbtzWqjlWS(strBDNDqhMREnZEeTMb)) + 14 + AOJYvUlfhLaeXGHs(gBlYJBAPOvJeeTRX(strYqLmyzIIroMbwZIi))), strBDNDqhMREnZEeTMb), ".converterTo("), strYqLmyzIIroMbwZIi), ")"));
    }
}

