namespace WillowMaze.Wasm.Decompiled;


readonly enum pe008767c$8 : p5a445d71.pd2420bf0.p3643b863.pe008767c {
    pe008767c$8(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static bool TCYfDTSnTLmYQjRO(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.ischar();
    }

    public static p5a445d71.pd2420bf0.p3643b863.pe008767c AgInnCksxWJRwnTP(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var) {
        return paa07fc01Var.originalState();
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p231afe47 DggLetjeQZErbCEm(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var) {
        return paa07fc01Var.pop();
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p231afe47 DkgkxkSEWBvDZrYs(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var) {
        return paa07fc01Var.pop();
    }

    public static bool EkOXfDVYlUFkWitu(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return paa07fc01Var.process(p459a6f79Var);
    }

    public static void FgNRvuFYYoVhokCL(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79$p76a40e4f p459a6f79_p76a40e4f) {
        paa07fc01Var.insert(p459a6f79_p76a40e4f);
    }

    public static void JHofPagJakAFsvPY(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.pe008767c pe008767cVar) {
        paa07fc01Var.error(pe008767cVar);
    }

    public static bool LUMgdBvATLqEhQtv(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.isEOF();
    }

    public static void OpmBHFDYwXFlqYFb(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.pe008767c pe008767cVar) {
        paa07fc01Var.transition(pe008767cVar);
    }

    public static bool PLhcKQwMJipFbAWD(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.isEndTag();
    }

    public static void SaHJdRIwJWuqEarS(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.pe008767c pe008767cVar) {
        paa07fc01Var.transition(pe008767cVar);
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$p76a40e4f xfWkYDCOFPVCiLrg(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.aschar();
    }

    public static p5a445d71.pd2420bf0.p3643b863.pe008767c XymNheGYfagGznpV(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var) {
        return paa07fc01Var.originalState();
    }

    bool process(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var, p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var) {
        if (TCYfDTSnTLmYQjRO(p459a6f79Var)) {
            fgNRvuFYYoVhokCL(paa07fc01Var, xfWkYDCOFPVCiLrg(p459a6f79Var));
            return true;
        }
        if (lUMgdBvATLqEhQtv(p459a6f79Var)) {
            jHofPagJakAFsvPY(paa07fc01Var, this);
            dkgkxkSEWBvDZrYs(paa07fc01Var);
            opmBHFDYwXFlqYFb(paa07fc01Var, agInnCksxWJRwnTP(paa07fc01Var));
            return ekOXfDVYlUFkWitu(paa07fc01Var, p459a6f79Var);
        }
        if (!pLhcKQwMJipFbAWD(p459a6f79Var)) {
            return true;
        }
        dggLetjeQZErbCEm(paa07fc01Var);
        saHJdRIwJWuqEarS(paa07fc01Var, xymNheGYfagGznpV(paa07fc01Var));
        return true;
    }
}

