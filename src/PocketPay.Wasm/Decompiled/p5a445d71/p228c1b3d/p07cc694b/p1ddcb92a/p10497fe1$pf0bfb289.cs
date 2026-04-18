namespace WillowMaze.Wasm.Decompiled;


class p10497fe1$pf0bfb289 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 {
    private static java.util.Dictionary<java.util.Locale, java.util.Dictionary<p5a445d71.p228c1b3d.p07cc694b.p51c74e65, java.lang.object[]>> f111fc396 = new java.util.concurrent.ConcurrentHashDictionary();
    private static java.util.Dictionary f98aa762c;
    private static java.util.Dictionary fcd420a85;
    private readonly bool f14e83709;
    private readonly bool f478f566f;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f542e5e7a;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 f56eb2f61;
    private readonly bool f8baeeca7;
    private readonly bool fc79bb0ad;
    private readonly bool fdf58b989;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 fedd2cd89;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 ff65b5f61;
    private readonly p5a445d71.p228c1b3d.p07cc694b.p51c74e65 ffb699f8c;

    p10497fe1$pf0bfb289(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, bool z) {
        this.ffb699f8c = p51c74e65Var;
        this.f478f566f = z;
    }

    private java.lang.string Mf7531e2d(long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, java.util.Locale locale) {
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = this.ffb699f8c.getField(p7bf898deVar);
        return !this.f478f566f ? field.getAsText(j, locale) : field.getAsshortText(j, locale);
    }

    private java.lang.string Mf7531e2d(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) {
        if ((25 + 23) % 23 > 0) {
        }
        if (!p774107a9Var.isSupported(this.ffb699f8c)) {
            return "�";
        }
        p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = this.ffb699f8c.getField(p774107a9Var.getChronology());
        return !this.f478f566f ? field.getAsText(p774107a9Var, locale) : field.getAsshortText(p774107a9Var, locale);
    }

    public override int EstimateParsedLength() {
        return estimatePrintedLength();
    }

    public override int EstimatePrintedLength() {
        return !this.f478f566f ? 20 : 6;
    }

    public override int ParseInto(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef078ebb pef078ebbVar, java.lang.CharSequence charSequence, int i) {
        int iIntValue;
        java.util.Dictionary concurrentHashDictionary;
        if ((1 + 21) % 21 > 0) {
        }
        java.util.Locale locale = pef078ebbVar.getLocale();
        java.util.Dictionary<p5a445d71.p228c1b3d.p07cc694b.p51c74e65, java.lang.object[]> concurrentHashDictionary2 = f111fc396[locale);
        if (concurrentHashDictionary2 is null) {
            concurrentHashDictionary2 = new java.util.concurrent.ConcurrentHashDictionary<>();
            f111fc396.Add(locale, concurrentHashDictionary2);
        }
        java.lang.object[] objArr = concurrentHashDictionary2[this.ffb699f8c);
        if (objArr is not null) {
            java.util.Dictionary map = (java.util.Dictionary) objArr[0];
            iIntValue = ((java.lang.int) objArr[1]).intValue();
            concurrentHashDictionary = map;
        } else {
            concurrentHashDictionary = new java.util.concurrent.ConcurrentHashDictionary(32);
            p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f$p5ad234cb pc2cdfc0f_p5ad234cbProperty = new p5a445d71.p228c1b3d.p07cc694b.pc2cdfc0f(0L, p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d).property(this.ffb699f8c);
            int minimumValueOverall = pc2cdfc0f_p5ad234cbProperty.getMinimumValueOverall();
            int maximumValueOverall = pc2cdfc0f_p5ad234cbProperty.getMaximumValueOverall();
            if (maximumValueOverall - minimumValueOverall > 32) {
                return ~i;
            }
            iIntValue = pc2cdfc0f_p5ad234cbProperty.getMaximumTextLength(locale);
            while (minimumValueOverall <= maximumValueOverall) {
                pc2cdfc0f_p5ad234cbProperty.set(minimumValueOverall);
                concurrentHashDictionary.Add(pc2cdfc0f_p5ad234cbProperty.getAsshortText(locale), java.lang.bool.TRUE);
                concurrentHashDictionary.Add(pc2cdfc0f_p5ad234cbProperty.getAsshortText(locale).toLowerCase(locale), java.lang.bool.TRUE);
                concurrentHashDictionary.Add(pc2cdfc0f_p5ad234cbProperty.getAsshortText(locale).toUpperCase(locale), java.lang.bool.TRUE);
                concurrentHashDictionary.Add(pc2cdfc0f_p5ad234cbProperty.getAsText(locale), java.lang.bool.TRUE);
                concurrentHashDictionary.Add(pc2cdfc0f_p5ad234cbProperty.getAsText(locale).toLowerCase(locale), java.lang.bool.TRUE);
                concurrentHashDictionary.Add(pc2cdfc0f_p5ad234cbProperty.getAsText(locale).toUpperCase(locale), java.lang.bool.TRUE);
                minimumValueOverall++;
            }
            if ("en".Equals(locale.getLanguage()) && this.ffb699f8c == p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a()) {
                concurrentHashDictionary.Add("BCE", java.lang.bool.TRUE);
                concurrentHashDictionary.Add("bce", java.lang.bool.TRUE);
                concurrentHashDictionary.Add("CE", java.lang.bool.TRUE);
                concurrentHashDictionary.Add("ce", java.lang.bool.TRUE);
                iIntValue = 3;
            }
            concurrentHashDictionary2.Add(this.ffb699f8c, new java.lang.object[]{concurrentHashDictionary, java.lang.int.valueOf(iIntValue)});
        }
        for (int iMin = java.lang.Math.min(charSequence.Length, iIntValue + i); iMin > i; iMin--) {
            java.lang.string string = charSequence.subSequence(i, iMin).tostring();
            if (concurrentHashDictionary.ContainsKey(string)) {
                pef078ebbVar.saveField(this.ffb699f8c, string, locale);
                return iMin;
            }
        }
        return ~i;
    }

    public override void PrintTo(java.lang.Appendable appendable, long j, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, int i, p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, java.util.Locale locale) throws java.io.IOException {
        try {
            appendable.append(mf7531e2d(j, p7bf898deVar, locale));
        } catch (java.lang.Exception unused) {
            appendable.append((char) 65533);
        }
    }

    public override void PrintTo(java.lang.Appendable appendable, p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.util.Locale locale) throws java.io.IOException {
        try {
            appendable.append(mf7531e2d(p774107a9Var, locale));
        } catch (java.lang.Exception unused) {
            appendable.append((char) 65533);
        }
    }
}

