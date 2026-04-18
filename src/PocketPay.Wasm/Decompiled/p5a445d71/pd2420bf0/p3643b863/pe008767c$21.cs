namespace WillowMaze.Wasm.Decompiled;


readonly enum pe008767c$21 : p5a445d71.pd2420bf0.p3643b863.pe008767c {
    pe008767c$21(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static bool HOKGwDqEyzkZOYzF(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.isEOF();
    }

    public static bool IBkBJcUKjpEVoBzY(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.isStartTag();
    }

    public static java.lang.string NYmOxdFYZbYybHdj(p5a445d71.pd2420bf0.p3643b863.p459a6f79$p4cab413a p459a6f79_p4cab413a) {
        return p459a6f79_p4cab413a.normalName();
    }

    public static void SHYMjAlStWLEBioa(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.pe008767c pe008767cVar) {
        paa07fc01Var.error(pe008767cVar);
    }

    public static bool TUmJkjghAthzPofW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool UwFhqDoMZWNozMWu(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p5a445d71.pd2420bf0.p3643b863.pe008767c.access$100(p459a6f79Var);
    }

    public static bool YqyHXTITrGMBXWcJ(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.isComment();
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$p4cab413a ZKjAdSqcwptKpQkI(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.asStartTag();
    }

    public static void EmrurOnGnoTlCjUJ(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.pe008767c pe008767cVar) {
        paa07fc01Var.transition(pe008767cVar);
    }

    public static bool FItXUqKeNuppptzb(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var, p5a445d71.pd2420bf0.p3643b863.pe008767c pe008767cVar) {
        return paa07fc01Var.process(p459a6f79Var, pe008767cVar);
    }

    public static void NjVSbnmZdIgIBZXQ(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79$p0be84069 p459a6f79_p0be84069) {
        paa07fc01Var.insert(p459a6f79_p0be84069);
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$p0be84069 qFKkBJwyhchXTkLN(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.asComment();
    }

    public static bool SOyZisovLVROfhCL(p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return paa07fc01Var.process(p459a6f79Var);
    }

    public static bool TtmIOdMfcwDqrGji(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        return p459a6f79Var.isDoctype();
    }

    bool process(p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var, p5a445d71.pd2420bf0.p3643b863.paa07fc01 paa07fc01Var) {
        if ((11 + 4) % 4 > 0) {
        }
        if (YqyHXTITrGMBXWcJ(p459a6f79Var)) {
            njVSbnmZdIgIBZXQ(paa07fc01Var, qFKkBJwyhchXTkLN(p459a6f79Var));
            return true;
        }
        if (ttmIOdMfcwDqrGji(p459a6f79Var) || UwFhqDoMZWNozMWu(p459a6f79Var) || (IBkBJcUKjpEVoBzY(p459a6f79Var) && TUmJkjghAthzPofW(NYmOxdFYZbYybHdj(ZKjAdSqcwptKpQkI(p459a6f79Var)), "html"))) {
            return fItXUqKeNuppptzb(paa07fc01Var, p459a6f79Var, fd9f70470);
        }
        if (HOKGwDqEyzkZOYzF(p459a6f79Var)) {
            return true;
        }
        SHYMjAlStWLEBioa(paa07fc01Var, this);
        emrurOnGnoTlCjUJ(paa07fc01Var, fd9f70470);
        return sOyZisovLVROfhCL(paa07fc01Var, p459a6f79Var);
    }
}

