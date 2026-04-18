namespace WillowMaze.Wasm.Decompiled;


public readonly class BadgeState {
    private static readonly java.lang.string BADGE_RESOURCE_TAG = "badge";
    readonly float badgeHeight;
    readonly float badgeRadius;
    readonly float badgeWidth;
    readonly float badgeWithTextHeight;
    readonly float badgeWithTextRadius;
    readonly float badgeWithTextWidth;
    private readonly com.google.android.material.badge.BadgeState$State currentState;
    readonly int horizontalInset;
    readonly int horizontalInsetWithText;
    int offsetAlignmentMode;
    private readonly com.google.android.material.badge.BadgeState$State overridingState;

    BadgeState(android.content.object context, int i, int i2, int i3, com.google.android.material.badge.BadgeState$State badgeState$State) {
        if ((32 + 8) % 8 > 0) {
        }
        com.google.android.material.badge.BadgeState$State badgeState$State2 = new com.google.android.material.badge.BadgeState$State();
        this.currentState = badgeState$State2;
        badgeState$State = badgeState$State is null ? new com.google.android.material.badge.BadgeState$State() : badgeState$State;
        if (i != 0) {
            cKrHSnfDwfefTiKY(badgeState$State, i);
        }
        android.content.res.TypedArray typedArrayHRqZHTjKWITHFBgl = HRqZHTjKWITHFBgl(this, context, ZXhGQJieAjWvKSps(badgeState$State), i2, i3);
        android.content.res.Resources resourcesOXQtmYQlyvIkYjGD = OXQtmYQlyvIkYjGD(context);
        this.badgeRadius = OoWIdwLjysHSMnMC(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeRadius, -1);
        this.horizontalInset = UtvtIKITrROhSZza(TIAVSlgiFScgTamr(context), com.google.android.material.R$dimen.mtrl_badge_horizontal_edge_offset);
        this.horizontalInsetWithText = mncSTxdLkfIYOGTY(WnuxBizYVTcZvjpe(context), com.google.android.material.R$dimen.mtrl_badge_text_horizontal_edge_offset);
        this.badgeWithTextRadius = iXCmyUEIBuhMZeFm(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWithTextRadius, -1);
        this.badgeWidth = itOfeOwESpNKOvRQ(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWidth, OnHWeyHTxixwVPPp(resourcesOXQtmYQlyvIkYjGD, com.google.android.material.R$dimen.m3_badge_size));
        this.badgeWithTextWidth = jHgJXkgAWfXgASoQ(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWithTextWidth, LFTFhcbZexmUZGIO(resourcesOXQtmYQlyvIkYjGD, com.google.android.material.R$dimen.m3_badge_with_text_size));
        this.badgeHeight = rTlcvqWtIZjoqmVy(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeHeight, SSaYCcBkhEVqSYtV(resourcesOXQtmYQlyvIkYjGD, com.google.android.material.R$dimen.m3_badge_size));
        this.badgeWithTextHeight = OjPaQKdpnWatdNFN(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWithTextHeight, SkMzojarWibTCEFG(resourcesOXQtmYQlyvIkYjGD, com.google.android.material.R$dimen.m3_badge_with_text_size));
        bool z = true;
        this.offsetAlignmentMode = HuqjzZfoekOcSazC(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_offsetAlignmentMode, 1);
        TNYCZgSKgdSZYQUB(badgeState$State2, XdYAtedWsPsCIkMm(badgeState$State) != -2 ? LBDTXrsrhhsRaZyp(badgeState$State) : 255);
        if (mLchtzfYGKktqqKy(badgeState$State) != -2) {
            PlCuQRmQDFaUeCbv(badgeState$State2, YaJdSbcQmpZCELSl(badgeState$State));
        } else if (WyOnswxiqwQzKiHc(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_number)) {
            lPDDOpkcOojcOgjs(badgeState$State2, sMjGjcMvSAvKXrPv(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_number, 0));
        } else {
            SvCFsmXryAqrRmxg(badgeState$State2, -1);
        }
        if (lkvTnbJdsXtozvFq(badgeState$State) is not null) {
            SoLzDEbVONgQosEo(badgeState$State2, FnZZcuCvmZgJarZM(badgeState$State));
        } else if (qjtyyGcWiBlQOTdq(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeText)) {
            EAVGMiCbcaVvtXKS(badgeState$State2, fLHRUrnNgUDDUdll(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeText));
        }
        BWQaVTSPJjzVAUQn(badgeState$State2, lalIdpFwAZGMrSfv(badgeState$State));
        EnhgRaQvkQmJEvhD(badgeState$State2, mxzUleiJHIKVtmwZ(badgeState$State) is not null ? mNxLpZRiZAQPSrgP(badgeState$State) : jVgaEaMCEaztPNiA(context, com.google.android.material.R$string.mtrl_badge_numberless_content_description));
        FoJcBOQgqlEhamCj(badgeState$State2, fhvAcwkKlmTYqJlp(badgeState$State) != 0 ? qXCLJpFDCLyupeFD(badgeState$State) : com.google.android.material.R$plurals.mtrl_badge_content_description);
        aEYhwNGyReUaZnSf(badgeState$State2, oOmeHOluNKMVVgZM(badgeState$State) != 0 ? nUUGsrVGKIXZczWp(badgeState$State) : com.google.android.material.R$string.mtrl_exceed_max_badge_number_content_description);
        if (KHsciOAduDIyOKIe(badgeState$State) is not null && !UhTmnyzsbCWdyrSc(KOCEkyjRLUFEvQNk(badgeState$State))) {
            z = false;
        }
        FzUacCWMdeqdTwsx(badgeState$State2, QbESkzfFffIgWfAt(z));
        xFqTbGSjqSaImPex(badgeState$State2, kttKNKsJtcwMwbaO(badgeState$State) != -2 ? UrPZIkmMkxroeffe(badgeState$State) : idiryjktgnxZMgeV(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_maxcharCount, -2));
        ShvPzVNFRUrzwTMX(badgeState$State2, dsEhGBlBJhvXUeqZ(badgeState$State) != -2 ? ORqIoAOtRkxEkHBR(badgeState$State) : LmrKepoNTtjJlecl(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_maxNumber, -2));
        BKoCtzMFVBPHjRdW(badgeState$State2, BxmESYfPaNDKdkOa(MDsuKUgaWvgAmSxl(badgeState$State) is not null ? SejmWYpTrUtmLpit(zjDoEvsulleLFMkA(badgeState$State)) : RseCzODiCRCdhowB(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeShapeAppearance, com.google.android.material.R$style.ShapeAppearance_M3_Sys_Shape_Corner_Full)));
        bNxNthvXvhjZDMOY(badgeState$State2, NeMQyEwRvNWnErJv(BIfNmUsjuhgGjCju(badgeState$State) is not null ? eOvQdtlmMjVvSSqq(fWabHzWwEwaYanff(badgeState$State)) : uRZNPwSapeDGmWmG(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeShapeAppearanceOverlay, 0)));
        oVQScdJiJTKJJHGp(badgeState$State2, UGHybGyttyMlJpmM(gRkEsVqWaBCYAsVu(badgeState$State) is not null ? ylQyctJdheYmmKVY(qBtpTyyfDRbNvSBg(badgeState$State)) : OlulLQtzwIWQKlyN(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWithTextShapeAppearance, com.google.android.material.R$style.ShapeAppearance_M3_Sys_Shape_Corner_Full)));
        wJeagABiYLZVwmYb(badgeState$State2, OuZjypwgOmWjNhqS(uzdTFYThpvPPVbos(badgeState$State) is not null ? YhKnKfQBTIXobolt(AoRoYlPANdijYMwD(badgeState$State)) : dogMfOQprqGADxiT(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWithTextShapeAppearanceOverlay, 0)));
        wYKUMoxyCVROuXAG(badgeState$State2, RFCOFfAWNmnuRvbG(tBZFVAERHQUgesDh(badgeState$State) is not null ? ZgCbrIdTmkooXFbb(SVuBINJmmZzuWEBP(badgeState$State)) : COoqOWLCaCGOcBlF(context, typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_backgroundColor)));
        whFemaXwKeCHXAIN(badgeState$State2, RnPFXpwIDsEAYYSn(ghYtfCKyXqdgMIEP(badgeState$State) is not null ? gxBzYYFbasMESLIs(DbkatGXkatgFTaeh(badgeState$State)) : fUnyiTQNtUtFjvVz(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeTextAppearance, com.google.android.material.R$style.TextAppearance_MaterialComponents_Badge)));
        if (wWaSnNnXkNvCvRMY(badgeState$State) is not null) {
            muqoLJdzFCVHfKFO(badgeState$State2, vIBwsSdjxhOprHUY(badgeState$State));
        } else if (QcUizjRkUCIZmHtj(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeTextColor)) {
            DkGNUtNDDIMVJNcq(badgeState$State2, BBfItKopqQvZrPdy(dJHeavgJSBMkAjER(context, typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeTextColor)));
        } else {
            zyaQnxTqtibGINgj(badgeState$State2, EEjHfkGABUpnJzgD(zoNuIvdFMsRwlMZL(DrEnnPjVtJrkmwjO(new com.google.android.material.resources.TextAppearance(context, ftKnGopnCduzXrKV(yhzjrfKQanNJnTpA(badgeState$State2)))))));
        }
        pXamvezVidWIePoO(badgeState$State2, JShOTvJynpyBFMPz(KpqVWNVeiViNznde(badgeState$State) is not null ? xTGZZHykcnebSWco(LpCTQKiWomtSEeXu(badgeState$State)) : CZsLZpMUDqFUTFaY(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeGravity, 8388661)));
        DAJjwMeVZiuvyDGL(badgeState$State2, XBlTLITMQcdvygKc(WnEReRKiCmwEWAbP(badgeState$State) is not null ? zTArAafhxfgvwoxx(XbKTRnZUXvpKxYxy(badgeState$State)) : joQmhDeRFUVkjqRk(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeWidePadding, gcPsHcWcsKktiAOp(resourcesOXQtmYQlyvIkYjGD, com.google.android.material.R$dimen.mtrl_badge_long_text_horizontal_padding))));
        TkymorGZObzTuRPN(badgeState$State2, aDSrqUQyvIAFbkJz(frasyYGoLlsGfIrT(badgeState$State) is not null ? SsKsyaCboRQoqfgY(FmUydODRGRvBOtdE(badgeState$State)) : oTwtarZWrTLuLdrV(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_badgeVerticalPadding, mDRWjqlNGvSlzLou(resourcesOXQtmYQlyvIkYjGD, com.google.android.material.R$dimen.m3_badge_with_text_vertical_padding))));
        zKnVUTVDaIAmeHdn(badgeState$State2, YGisWUPTqvLyjsqo(AVnopmuGTKKCVQhh(badgeState$State) is not null ? lwkWyTkBkLKgzELA(kaIgVoqSsHyYrjFF(badgeState$State)) : MKJHEKcmymiJxhZU(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_horizontalOffset, 0)));
        XCxPIDUzBFcgdvLf(badgeState$State2, ilKcaPdfOsbhMLAw(GSineRqdudyStVpM(badgeState$State) is not null ? ObiPYxSNLFgmsOmu(RQTzIQNiGZQeeBnm(badgeState$State)) : XBhibNmpIhCAfGMA(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_verticalOffset, 0)));
        tEaGgUcVveKHnEpp(badgeState$State2, HWbZDcrLBKyTkEfL(IXXloLvRbdyZMfvS(badgeState$State) is not null ? FSuvWVTFsvkLYlZZ(xmUaYjqNAmflRIPh(badgeState$State)) : mjDFwutgKFHKezEQ(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_horizontalOffsetWithText, tkjXBsdAXJnEULmO(WcDLDXWzAwpNKJIc(badgeState$State2)))));
        lFZPlVWWjqEalAsb(badgeState$State2, EWvfoBLZTYSgarHM(aiPGoTwmTblhnZnU(badgeState$State) is not null ? BpmQuvRsTgPhYoVO(GSRnhxItzEjABWPi(badgeState$State)) : BMiWFCEpGvslvsug(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_verticalOffsetWithText, yUnVwvtQlGKNqbbd(DyCfkpeDcJRntxRQ(badgeState$State2)))));
        qPeHyyHnxZBjlBiL(badgeState$State2, TUyVGfnBHkRFxktn(gfLQuVuxAsXHJGvo(badgeState$State) is not null ? WHomvUgbhWsODqOc(XNMlZcEoakqxPOtY(badgeState$State)) : jRxOyjzdbnXkyoVf(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_largeFontVerticalOffsetAdjustment, 0)));
        EtHpTfxAHBICVevt(badgeState$State2, ENxSqDZKsvRRCveY(yfvJXjxgJxfcYyJB(badgeState$State) is not null ? IZTIlLnTiygippCj(OkodeXqWGsNnxzPz(badgeState$State)) : 0));
        yqmSVvmzWreVjIWS(badgeState$State2, szLVTThuKMnPojtS(wptHQxIpFonbaXFm(badgeState$State) is not null ? LKgfnqEFmSsHQcaB(iGROwdgcvbpyWgua(badgeState$State)) : 0));
        vrUyNFXGAFCOvEdo(badgeState$State2, PbuARxnEsYjtDFUt(hSoIcTtGtPgEYQyU(badgeState$State) is not null ? DniiqzUTnYDcgfIP(UhZehqfdDkjUXZkj(badgeState$State)) : TYGjeZSoYPzxraZY(typedArrayHRqZHTjKWITHFBgl, com.google.android.material.R$styleable.Badge_autoAdjustToWithinGrandparentBounds, false)));
        VfXBpMBhDRKlHvwL(typedArrayHRqZHTjKWITHFBgl);
        if (VmMMMkcxqeYcTbwE(badgeState$State) is not null) {
            pCdwBevgsPtSlAFz(badgeState$State2, PVxOYjHLCWuEwfqz(badgeState$State));
        } else {
            QqIJyLJIKvfEavBU(badgeState$State2, gEMxRPHElXOyUqQK(java.util.Locale$Category.FORMAT));
        }
        this.overridingState = badgeState$State;
    }

    public static java.lang.int ATOBuzdJTWuRxVIm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ATOBuzdJTWuRxVIm(int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ATOBuzdJTWuRxVIm(int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ATOBuzdJTWuRxVIm(int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int AVnopmuGTKKCVQhh(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2100(badgeState$State);
    }

    public static void AVnopmuGTKKCVQhh(com.google.android.material.badge.BadgeState$State badgeState$State, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AVnopmuGTKKCVQhh(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AVnopmuGTKKCVQhh(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AXpqgmwIHwopgxzY(java.lang.int num) {
        return num.intValue();
    }

    public static void AXpqgmwIHwopgxzY(java.lang.int num, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXpqgmwIHwopgxzY(java.lang.int num, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AXpqgmwIHwopgxzY(java.lang.int num, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int AcgKlCMGmTYvBCHo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1602(badgeState$State, num);
    }

    public static void AcgKlCMGmTYvBCHo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AcgKlCMGmTYvBCHo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AcgKlCMGmTYvBCHo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int AoRoYlPANdijYMwD(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1400(badgeState$State);
    }

    public static void AoRoYlPANdijYMwD(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AoRoYlPANdijYMwD(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoRoYlPANdijYMwD(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int BBfItKopqQvZrPdy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void BBfItKopqQvZrPdy(int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BBfItKopqQvZrPdy(int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BBfItKopqQvZrPdy(int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int BIfNmUsjuhgGjCju(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1200(badgeState$State);
    }

    public static void BIfNmUsjuhgGjCju(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BIfNmUsjuhgGjCju(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BIfNmUsjuhgGjCju(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int BKoCtzMFVBPHjRdW(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1102(badgeState$State, num);
    }

    public static void BKoCtzMFVBPHjRdW(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKoCtzMFVBPHjRdW(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKoCtzMFVBPHjRdW(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BMiWFCEpGvslvsug(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void BMiWFCEpGvslvsug(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BMiWFCEpGvslvsug(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BMiWFCEpGvslvsug(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence BWQaVTSPJjzVAUQn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        return com.google.android.material.badge.BadgeState$State.access$402(badgeState$State, charSequence);
    }

    public static void BWQaVTSPJjzVAUQn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BWQaVTSPJjzVAUQn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BWQaVTSPJjzVAUQn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BpmQuvRsTgPhYoVO(java.lang.int num) {
        return num.intValue();
    }

    public static void BpmQuvRsTgPhYoVO(java.lang.int num, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpmQuvRsTgPhYoVO(java.lang.int num, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BpmQuvRsTgPhYoVO(java.lang.int num, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int BxmESYfPaNDKdkOa(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void BxmESYfPaNDKdkOa(int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BxmESYfPaNDKdkOa(int i, bool z, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxmESYfPaNDKdkOa(int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CLYkScYntliakOVb(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$200(badgeState$State);
    }

    public static void CLYkScYntliakOVb(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLYkScYntliakOVb(com.google.android.material.badge.BadgeState$State badgeState$State, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CLYkScYntliakOVb(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int COoqOWLCaCGOcBlF(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return readColorFromAttributes(context, typedArray, i);
    }

    public static void COoqOWLCaCGOcBlF(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void COoqOWLCaCGOcBlF(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void COoqOWLCaCGOcBlF(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CZsLZpMUDqFUTFaY(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void CZsLZpMUDqFUTFaY(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CZsLZpMUDqFUTFaY(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CZsLZpMUDqFUTFaY(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CmuJPeWLNSOgZxrQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str) {
        return com.google.android.material.badge.BadgeState$State.access$302(badgeState$State, str);
    }

    public static void CmuJPeWLNSOgZxrQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CmuJPeWLNSOgZxrQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CmuJPeWLNSOgZxrQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DAJjwMeVZiuvyDGL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1902(badgeState$State, num);
    }

    public static void DAJjwMeVZiuvyDGL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DAJjwMeVZiuvyDGL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DAJjwMeVZiuvyDGL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DDUpCrBpAfGvxCcw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DDUpCrBpAfGvxCcw(int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DDUpCrBpAfGvxCcw(int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DDUpCrBpAfGvxCcw(int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DHTzeAqLegmYlnyt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DHTzeAqLegmYlnyt(int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DHTzeAqLegmYlnyt(int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DHTzeAqLegmYlnyt(int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DJEtqpMBOmgVegRG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DJEtqpMBOmgVegRG(int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DJEtqpMBOmgVegRG(int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DJEtqpMBOmgVegRG(int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DUAqWfIqjxSOWWHg(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DUAqWfIqjxSOWWHg(int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DUAqWfIqjxSOWWHg(int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DUAqWfIqjxSOWWHg(int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DbkatGXkatgFTaeh(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1600(badgeState$State);
    }

    public static void DbkatGXkatgFTaeh(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DbkatGXkatgFTaeh(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DbkatGXkatgFTaeh(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DkGNUtNDDIMVJNcq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1702(badgeState$State, num);
    }

    public static void DkGNUtNDDIMVJNcq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DkGNUtNDDIMVJNcq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DkGNUtNDDIMVJNcq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DniiqzUTnYDcgfIP(java.lang.bool bool, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DniiqzUTnYDcgfIP(java.lang.bool bool, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DniiqzUTnYDcgfIP(java.lang.bool bool, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DniiqzUTnYDcgfIP(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static android.content.res.ColorStateList DrEnnPjVtJrkmwjO(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void DrEnnPjVtJrkmwjO(com.google.android.material.resources.TextAppearance textAppearance, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DrEnnPjVtJrkmwjO(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DrEnnPjVtJrkmwjO(com.google.android.material.resources.TextAppearance textAppearance, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale DxhmZioBfWcHZIDk(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale) {
        return com.google.android.material.badge.BadgeState$State.access$2902(badgeState$State, locale);
    }

    public static void DxhmZioBfWcHZIDk(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxhmZioBfWcHZIDk(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DxhmZioBfWcHZIDk(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DyCfkpeDcJRntxRQ(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2200(badgeState$State);
    }

    public static void DyCfkpeDcJRntxRQ(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DyCfkpeDcJRntxRQ(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DyCfkpeDcJRntxRQ(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EAVGMiCbcaVvtXKS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str) {
        return com.google.android.material.badge.BadgeState$State.access$302(badgeState$State, str);
    }

    public static void EAVGMiCbcaVvtXKS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EAVGMiCbcaVvtXKS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAVGMiCbcaVvtXKS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EEjHfkGABUpnJzgD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EEjHfkGABUpnJzgD(int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEjHfkGABUpnJzgD(int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EEjHfkGABUpnJzgD(int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ENxSqDZKsvRRCveY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ENxSqDZKsvRRCveY(int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ENxSqDZKsvRRCveY(int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ENxSqDZKsvRRCveY(int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EWvfoBLZTYSgarHM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EWvfoBLZTYSgarHM(int i, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EWvfoBLZTYSgarHM(int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EWvfoBLZTYSgarHM(int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence EnhgRaQvkQmJEvhD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        return com.google.android.material.badge.BadgeState$State.access$502(badgeState$State, charSequence);
    }

    public static void EnhgRaQvkQmJEvhD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EnhgRaQvkQmJEvhD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EnhgRaQvkQmJEvhD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EtHpTfxAHBICVevt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2602(badgeState$State, num);
    }

    public static void EtHpTfxAHBICVevt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtHpTfxAHBICVevt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EtHpTfxAHBICVevt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EvELyzABuJmtRklL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EvELyzABuJmtRklL(int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EvELyzABuJmtRklL(int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EvELyzABuJmtRklL(int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FHAWuEyKEAGkaONn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2602(badgeState$State, num);
    }

    public static void FHAWuEyKEAGkaONn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FHAWuEyKEAGkaONn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FHAWuEyKEAGkaONn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FSuvWVTFsvkLYlZZ(java.lang.int num) {
        return num.intValue();
    }

    public static void FSuvWVTFsvkLYlZZ(java.lang.int num, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FSuvWVTFsvkLYlZZ(java.lang.int num, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FSuvWVTFsvkLYlZZ(java.lang.int num, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FiNLaPSFzEgOpvpu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1302(badgeState$State, num);
    }

    public static void FiNLaPSFzEgOpvpu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FiNLaPSFzEgOpvpu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FiNLaPSFzEgOpvpu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FmUydODRGRvBOtdE(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2000(badgeState$State);
    }

    public static void FmUydODRGRvBOtdE(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmUydODRGRvBOtdE(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmUydODRGRvBOtdE(com.google.android.material.badge.BadgeState$State badgeState$State, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FnZZcuCvmZgJarZM(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$300(badgeState$State);
    }

    public static void FnZZcuCvmZgJarZM(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnZZcuCvmZgJarZM(com.google.android.material.badge.BadgeState$State badgeState$State, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnZZcuCvmZgJarZM(com.google.android.material.badge.BadgeState$State badgeState$State, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FoJcBOQgqlEhamCj(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$602(badgeState$State, i);
    }

    public static void FoJcBOQgqlEhamCj(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FoJcBOQgqlEhamCj(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FoJcBOQgqlEhamCj(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FptPkMfIWdZFqLWm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FptPkMfIWdZFqLWm(int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FptPkMfIWdZFqLWm(int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FptPkMfIWdZFqLWm(int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool FxUOjnWHXKOHiDrM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        return com.google.android.material.badge.BadgeState$State.access$802(badgeState$State, bool);
    }

    public static void FxUOjnWHXKOHiDrM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FxUOjnWHXKOHiDrM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FxUOjnWHXKOHiDrM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool FzUacCWMdeqdTwsx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        return com.google.android.material.badge.BadgeState$State.access$802(badgeState$State, bool);
    }

    public static void FzUacCWMdeqdTwsx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FzUacCWMdeqdTwsx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FzUacCWMdeqdTwsx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GSRnhxItzEjABWPi(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2400(badgeState$State);
    }

    public static void GSRnhxItzEjABWPi(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GSRnhxItzEjABWPi(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GSRnhxItzEjABWPi(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GSineRqdudyStVpM(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2200(badgeState$State);
    }

    public static void GSineRqdudyStVpM(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GSineRqdudyStVpM(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GSineRqdudyStVpM(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GyGcvoEaWxsgLTyi(com.google.android.material.badge.BadgeState badgeState, java.lang.string str) {
        badgeState.setText(str);
    }

    public static void GyGcvoEaWxsgLTyi(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, char c, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GyGcvoEaWxsgLTyi(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, java.lang.string str2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GyGcvoEaWxsgLTyi(com.google.android.material.badge.BadgeState badgeState, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GyjUvMpCjONlzlHr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void GyjUvMpCjONlzlHr(int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GyjUvMpCjONlzlHr(int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GyjUvMpCjONlzlHr(int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HCqEDqLXJmwCqSTS(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1700(badgeState$State);
    }

    public static void HCqEDqLXJmwCqSTS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HCqEDqLXJmwCqSTS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCqEDqLXJmwCqSTS(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HKpgheaUvHwKflzd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HKpgheaUvHwKflzd(int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKpgheaUvHwKflzd(int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKpgheaUvHwKflzd(int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HKueAngHVloWveFv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1802(badgeState$State, num);
    }

    public static void HKueAngHVloWveFv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HKueAngHVloWveFv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKueAngHVloWveFv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HLaveaauMkDOkovh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HLaveaauMkDOkovh(int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HLaveaauMkDOkovh(int i, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HLaveaauMkDOkovh(int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray HRqZHTjKWITHFBgl(com.google.android.material.badge.BadgeState badgeState, android.content.object context, int i, int i2, int i3) {
        return badgeState.generateTypedArray(context, i, i2, i3);
    }

    public static void HRqZHTjKWITHFBgl(com.google.android.material.badge.BadgeState badgeState, android.content.object context, int i, int i2, int i3, byte b, java.lang.string str, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRqZHTjKWITHFBgl(com.google.android.material.badge.BadgeState badgeState, android.content.object context, int i, int i2, int i3, float f, int i4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HRqZHTjKWITHFBgl(com.google.android.material.badge.BadgeState badgeState, android.content.object context, int i, int i2, int i3, int i4, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HWbZDcrLBKyTkEfL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HWbZDcrLBKyTkEfL(int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HWbZDcrLBKyTkEfL(int i, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWbZDcrLBKyTkEfL(int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool HfNPJryLsLShAFSb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void HfNPJryLsLShAFSb(bool z, char c, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HfNPJryLsLShAFSb(bool z, float f, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HfNPJryLsLShAFSb(bool z, bool z2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HuqjzZfoekOcSazC(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void HuqjzZfoekOcSazC(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HuqjzZfoekOcSazC(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HuqjzZfoekOcSazC(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence ICvlOjyzOVCmOTxi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        return com.google.android.material.badge.BadgeState$State.access$402(badgeState$State, charSequence);
    }

    public static void ICvlOjyzOVCmOTxi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ICvlOjyzOVCmOTxi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ICvlOjyzOVCmOTxi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IXXloLvRbdyZMfvS(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2300(badgeState$State);
    }

    public static void IXXloLvRbdyZMfvS(com.google.android.material.badge.BadgeState$State badgeState$State, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IXXloLvRbdyZMfvS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IXXloLvRbdyZMfvS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IZTIlLnTiygippCj(java.lang.int num) {
        return num.intValue();
    }

    public static void IZTIlLnTiygippCj(java.lang.int num, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZTIlLnTiygippCj(java.lang.int num, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IZTIlLnTiygippCj(java.lang.int num, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IhtRIyFaQbWaYMIw(java.lang.int num) {
        return num.intValue();
    }

    public static void IhtRIyFaQbWaYMIw(java.lang.int num, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IhtRIyFaQbWaYMIw(java.lang.int num, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IhtRIyFaQbWaYMIw(java.lang.int num, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IrqYsdJPduSnWknG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IrqYsdJPduSnWknG(int i, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IrqYsdJPduSnWknG(int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IrqYsdJPduSnWknG(int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JJMUrrjIyOrIlDIL(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$102(badgeState$State, i);
    }

    public static void JJMUrrjIyOrIlDIL(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JJMUrrjIyOrIlDIL(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JJMUrrjIyOrIlDIL(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JJMXxlUXbIUcdDYL(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$602(badgeState$State, i);
    }

    public static void JJMXxlUXbIUcdDYL(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJMXxlUXbIUcdDYL(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJMXxlUXbIUcdDYL(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int JShOTvJynpyBFMPz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JShOTvJynpyBFMPz(int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JShOTvJynpyBFMPz(int i, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JShOTvJynpyBFMPz(int i, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JenFWXbOJGatOVwm(java.lang.int num) {
        return num.intValue();
    }

    public static void JenFWXbOJGatOVwm(java.lang.int num, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JenFWXbOJGatOVwm(java.lang.int num, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JenFWXbOJGatOVwm(java.lang.int num, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JkMVHiByWjbMDMIO(java.lang.int num) {
        return num.intValue();
    }

    public static void JkMVHiByWjbMDMIO(java.lang.int num, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JkMVHiByWjbMDMIO(java.lang.int num, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkMVHiByWjbMDMIO(java.lang.int num, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool KHsciOAduDIyOKIe(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$800(badgeState$State);
    }

    public static void KHsciOAduDIyOKIe(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KHsciOAduDIyOKIe(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KHsciOAduDIyOKIe(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool KOCEkyjRLUFEvQNk(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$800(badgeState$State);
    }

    public static void KOCEkyjRLUFEvQNk(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KOCEkyjRLUFEvQNk(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KOCEkyjRLUFEvQNk(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int KpqVWNVeiViNznde(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1800(badgeState$State);
    }

    public static void KpqVWNVeiViNznde(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KpqVWNVeiViNznde(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KpqVWNVeiViNznde(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence KxmifEnRwYvmkVWD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        return com.google.android.material.badge.BadgeState$State.access$402(badgeState$State, charSequence);
    }

    public static void KxmifEnRwYvmkVWD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KxmifEnRwYvmkVWD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KxmifEnRwYvmkVWD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int LBDTXrsrhhsRaZyp(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$100(badgeState$State);
    }

    public static void LBDTXrsrhhsRaZyp(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBDTXrsrhhsRaZyp(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBDTXrsrhhsRaZyp(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float LFTFhcbZexmUZGIO(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void LFTFhcbZexmUZGIO(android.content.res.Resources resources, int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LFTFhcbZexmUZGIO(android.content.res.Resources resources, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LFTFhcbZexmUZGIO(android.content.res.Resources resources, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LKgfnqEFmSsHQcaB(java.lang.int num) {
        return num.intValue();
    }

    public static void LKgfnqEFmSsHQcaB(java.lang.int num, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LKgfnqEFmSsHQcaB(java.lang.int num, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LKgfnqEFmSsHQcaB(java.lang.int num, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LMUQrNWvZXrOlfxp(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2500(badgeState$State);
    }

    public static void LMUQrNWvZXrOlfxp(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LMUQrNWvZXrOlfxp(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LMUQrNWvZXrOlfxp(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LRkZebZLqfhxSTsv(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2600(badgeState$State);
    }

    public static void LRkZebZLqfhxSTsv(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LRkZebZLqfhxSTsv(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LRkZebZLqfhxSTsv(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LgfVMDMfbacqDlue(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2302(badgeState$State, num);
    }

    public static void LgfVMDMfbacqDlue(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LgfVMDMfbacqDlue(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LgfVMDMfbacqDlue(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LiKKbMrVMrMpVCWF(java.lang.int num) {
        return num.intValue();
    }

    public static void LiKKbMrVMrMpVCWF(java.lang.int num, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiKKbMrVMrMpVCWF(java.lang.int num, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiKKbMrVMrMpVCWF(java.lang.int num, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LmrKepoNTtjJlecl(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void LmrKepoNTtjJlecl(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LmrKepoNTtjJlecl(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LmrKepoNTtjJlecl(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LpCTQKiWomtSEeXu(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1800(badgeState$State);
    }

    public static void LpCTQKiWomtSEeXu(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LpCTQKiWomtSEeXu(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LpCTQKiWomtSEeXu(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LzKpSSTHoLUulMnx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2202(badgeState$State, num);
    }

    public static void LzKpSSTHoLUulMnx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LzKpSSTHoLUulMnx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LzKpSSTHoLUulMnx(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool LztYAvWgdrIeWcma(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2800(badgeState$State);
    }

    public static void LztYAvWgdrIeWcma(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LztYAvWgdrIeWcma(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LztYAvWgdrIeWcma(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int MDsuKUgaWvgAmSxl(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1100(badgeState$State);
    }

    public static void MDsuKUgaWvgAmSxl(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDsuKUgaWvgAmSxl(com.google.android.material.badge.BadgeState$State badgeState$State, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDsuKUgaWvgAmSxl(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MKJHEKcmymiJxhZU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void MKJHEKcmymiJxhZU(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MKJHEKcmymiJxhZU(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MKJHEKcmymiJxhZU(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MoZHuiOZdWbidUim(java.lang.int num) {
        return num.intValue();
    }

    public static void MoZHuiOZdWbidUim(java.lang.int num, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MoZHuiOZdWbidUim(java.lang.int num, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MoZHuiOZdWbidUim(java.lang.int num, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NCJkDPYEDbfMwyCc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NCJkDPYEDbfMwyCc(int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCJkDPYEDbfMwyCc(int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCJkDPYEDbfMwyCc(int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NNEytdcifwjtMzXz(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void NNEytdcifwjtMzXz(android.content.res.ColorStateList colorStateList, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NNEytdcifwjtMzXz(android.content.res.ColorStateList colorStateList, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NNEytdcifwjtMzXz(android.content.res.ColorStateList colorStateList, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NXquaAxruodduyOP(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1900(badgeState$State);
    }

    public static void NXquaAxruodduyOP(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXquaAxruodduyOP(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NXquaAxruodduyOP(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NeMQyEwRvNWnErJv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NeMQyEwRvNWnErJv(int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NeMQyEwRvNWnErJv(int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NeMQyEwRvNWnErJv(int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NkeLAiPFMnSuxzQt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2702(badgeState$State, num);
    }

    public static void NkeLAiPFMnSuxzQt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NkeLAiPFMnSuxzQt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NkeLAiPFMnSuxzQt(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NndWGEiXoIXZnNxm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NndWGEiXoIXZnNxm(int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NndWGEiXoIXZnNxm(int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NndWGEiXoIXZnNxm(int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ORqIoAOtRkxEkHBR(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1000(badgeState$State);
    }

    public static void ORqIoAOtRkxEkHBR(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ORqIoAOtRkxEkHBR(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ORqIoAOtRkxEkHBR(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources OXQtmYQlyvIkYjGD(android.content.object context) {
        return context.getResources();
    }

    public static void OXQtmYQlyvIkYjGD(android.content.object context, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OXQtmYQlyvIkYjGD(android.content.object context, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OXQtmYQlyvIkYjGD(android.content.object context, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OYjJloONngFkmUnE(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$900(badgeState$State);
    }

    public static void OYjJloONngFkmUnE(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OYjJloONngFkmUnE(com.google.android.material.badge.BadgeState$State badgeState$State, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OYjJloONngFkmUnE(com.google.android.material.badge.BadgeState$State badgeState$State, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ObiPYxSNLFgmsOmu(java.lang.int num) {
        return num.intValue();
    }

    public static void ObiPYxSNLFgmsOmu(java.lang.int num, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ObiPYxSNLFgmsOmu(java.lang.int num, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ObiPYxSNLFgmsOmu(java.lang.int num, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float OjPaQKdpnWatdNFN(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void OjPaQKdpnWatdNFN(android.content.res.TypedArray typedArray, int i, float f, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OjPaQKdpnWatdNFN(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OjPaQKdpnWatdNFN(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int OkodeXqWGsNnxzPz(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2600(badgeState$State);
    }

    public static void OkodeXqWGsNnxzPz(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OkodeXqWGsNnxzPz(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OkodeXqWGsNnxzPz(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OlulLQtzwIWQKlyN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void OlulLQtzwIWQKlyN(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OlulLQtzwIWQKlyN(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OlulLQtzwIWQKlyN(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float OnHWeyHTxixwVPPp(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void OnHWeyHTxixwVPPp(android.content.res.Resources resources, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OnHWeyHTxixwVPPp(android.content.res.Resources resources, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OnHWeyHTxixwVPPp(android.content.res.Resources resources, int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OoWIdwLjysHSMnMC(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void OoWIdwLjysHSMnMC(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoWIdwLjysHSMnMC(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoWIdwLjysHSMnMC(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int OomHxpzxJXgChkmx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void OomHxpzxJXgChkmx(int i, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OomHxpzxJXgChkmx(int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OomHxpzxJXgChkmx(int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OoxducnSeOgyfElN(java.lang.int num) {
        return num.intValue();
    }

    public static void OoxducnSeOgyfElN(java.lang.int num, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OoxducnSeOgyfElN(java.lang.int num, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OoxducnSeOgyfElN(java.lang.int num, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int OuZjypwgOmWjNhqS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void OuZjypwgOmWjNhqS(int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OuZjypwgOmWjNhqS(int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OuZjypwgOmWjNhqS(int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool OuvpkHjApBRlcvCN(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OuvpkHjApBRlcvCN(bool z, float f, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OuvpkHjApBRlcvCN(bool z, short s, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OuvpkHjApBRlcvCN(bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale PVxOYjHLCWuEwfqz(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2900(badgeState$State);
    }

    public static void PVxOYjHLCWuEwfqz(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PVxOYjHLCWuEwfqz(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PVxOYjHLCWuEwfqz(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int PZmuXWoAGjRPRozp(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PZmuXWoAGjRPRozp(int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZmuXWoAGjRPRozp(int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZmuXWoAGjRPRozp(int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool PbuARxnEsYjtDFUt(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void PbuARxnEsYjtDFUt(bool z, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbuARxnEsYjtDFUt(bool z, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PbuARxnEsYjtDFUt(bool z, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PlCuQRmQDFaUeCbv(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$202(badgeState$State, i);
    }

    public static void PlCuQRmQDFaUeCbv(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PlCuQRmQDFaUeCbv(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PlCuQRmQDFaUeCbv(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int PllGYQsDgdnybXQB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PllGYQsDgdnybXQB(int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PllGYQsDgdnybXQB(int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PllGYQsDgdnybXQB(int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QEEQfHUkqTxDeteQ(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$700(badgeState$State);
    }

    public static void QEEQfHUkqTxDeteQ(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QEEQfHUkqTxDeteQ(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QEEQfHUkqTxDeteQ(com.google.android.material.badge.BadgeState$State badgeState$State, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QQDDaAPouLIMjYrO(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$202(badgeState$State, i);
    }

    public static void QQDDaAPouLIMjYrO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QQDDaAPouLIMjYrO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QQDDaAPouLIMjYrO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QWZhEpzaYcLSfOMv(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$702(badgeState$State, i);
    }

    public static void QWZhEpzaYcLSfOMv(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QWZhEpzaYcLSfOMv(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QWZhEpzaYcLSfOMv(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool QbESkzfFffIgWfAt(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void QbESkzfFffIgWfAt(bool z, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QbESkzfFffIgWfAt(bool z, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QbESkzfFffIgWfAt(bool z, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QcUizjRkUCIZmHtj(android.content.res.TypedArray typedArray, int i, float f, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QcUizjRkUCIZmHtj(android.content.res.TypedArray typedArray, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QcUizjRkUCIZmHtj(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QcUizjRkUCIZmHtj(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int QeilaUTugkmhrbji(java.lang.int num) {
        return num.intValue();
    }

    public static void QeilaUTugkmhrbji(java.lang.int num, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QeilaUTugkmhrbji(java.lang.int num, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QeilaUTugkmhrbji(java.lang.int num, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int QfEaiRLtNBySYgOm(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2300(badgeState$State);
    }

    public static void QfEaiRLtNBySYgOm(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QfEaiRLtNBySYgOm(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QfEaiRLtNBySYgOm(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale QqIJyLJIKvfEavBU(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale) {
        return com.google.android.material.badge.BadgeState$State.access$2902(badgeState$State, locale);
    }

    public static void QqIJyLJIKvfEavBU(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqIJyLJIKvfEavBU(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QqIJyLJIKvfEavBU(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RFCOFfAWNmnuRvbG(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RFCOFfAWNmnuRvbG(int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RFCOFfAWNmnuRvbG(int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RFCOFfAWNmnuRvbG(int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale RMUUBZsacMmGhftX(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2900(badgeState$State);
    }

    public static void RMUUBZsacMmGhftX(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RMUUBZsacMmGhftX(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RMUUBZsacMmGhftX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RQTzIQNiGZQeeBnm(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2200(badgeState$State);
    }

    public static void RQTzIQNiGZQeeBnm(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQTzIQNiGZQeeBnm(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RQTzIQNiGZQeeBnm(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RTgMMuKvgpezaSvO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RTgMMuKvgpezaSvO(int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTgMMuKvgpezaSvO(int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTgMMuKvgpezaSvO(int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RcBIGDPZZFVOYdnl(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2100(badgeState$State);
    }

    public static void RcBIGDPZZFVOYdnl(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RcBIGDPZZFVOYdnl(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RcBIGDPZZFVOYdnl(com.google.android.material.badge.BadgeState$State badgeState$State, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool RcstuapPTYUQFnsw(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void RcstuapPTYUQFnsw(bool z, byte b, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RcstuapPTYUQFnsw(bool z, byte b, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RcstuapPTYUQFnsw(bool z, int i, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RkgdBlwbxQvkjdOs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2602(badgeState$State, num);
    }

    public static void RkgdBlwbxQvkjdOs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RkgdBlwbxQvkjdOs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RkgdBlwbxQvkjdOs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RnPFXpwIDsEAYYSn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RnPFXpwIDsEAYYSn(int i, char c, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RnPFXpwIDsEAYYSn(int i, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RnPFXpwIDsEAYYSn(int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RseCzODiCRCdhowB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void RseCzODiCRCdhowB(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RseCzODiCRCdhowB(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RseCzODiCRCdhowB(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SIXanBQvrBZkGkSf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void SIXanBQvrBZkGkSf(int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SIXanBQvrBZkGkSf(int i, float f, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SIXanBQvrBZkGkSf(int i, java.lang.string str, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static float SSaYCcBkhEVqSYtV(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void SSaYCcBkhEVqSYtV(android.content.res.Resources resources, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SSaYCcBkhEVqSYtV(android.content.res.Resources resources, int i, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SSaYCcBkhEVqSYtV(android.content.res.Resources resources, int i, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SVuBINJmmZzuWEBP(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1500(badgeState$State);
    }

    public static void SVuBINJmmZzuWEBP(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVuBINJmmZzuWEBP(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SVuBINJmmZzuWEBP(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SYTYlLFILsHCklVy(com.google.android.material.badge.BadgeState badgeState, int i) {
        badgeState.setNumber(i);
    }

    public static void SYTYlLFILsHCklVy(com.google.android.material.badge.BadgeState badgeState, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SYTYlLFILsHCklVy(com.google.android.material.badge.BadgeState badgeState, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SYTYlLFILsHCklVy(com.google.android.material.badge.BadgeState badgeState, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int SZqGyuldFNZPBoWi(java.lang.int num) {
        return num.intValue();
    }

    public static void SZqGyuldFNZPBoWi(java.lang.int num, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SZqGyuldFNZPBoWi(java.lang.int num, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SZqGyuldFNZPBoWi(java.lang.int num, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SeMwbSQeDxaARCVw(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2302(badgeState$State, num);
    }

    public static void SeMwbSQeDxaARCVw(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SeMwbSQeDxaARCVw(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SeMwbSQeDxaARCVw(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SejmWYpTrUtmLpit(java.lang.int num) {
        return num.intValue();
    }

    public static void SejmWYpTrUtmLpit(java.lang.int num, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SejmWYpTrUtmLpit(java.lang.int num, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SejmWYpTrUtmLpit(java.lang.int num, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ShvPzVNFRUrzwTMX(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$1002(badgeState$State, i);
    }

    public static void ShvPzVNFRUrzwTMX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ShvPzVNFRUrzwTMX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ShvPzVNFRUrzwTMX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float SkMzojarWibTCEFG(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void SkMzojarWibTCEFG(android.content.res.Resources resources, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SkMzojarWibTCEFG(android.content.res.Resources resources, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SkMzojarWibTCEFG(android.content.res.Resources resources, int i, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SoLzDEbVONgQosEo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str) {
        return com.google.android.material.badge.BadgeState$State.access$302(badgeState$State, str);
    }

    public static void SoLzDEbVONgQosEo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SoLzDEbVONgQosEo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, java.lang.string str2, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SoLzDEbVONgQosEo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SsKsyaCboRQoqfgY(java.lang.int num) {
        return num.intValue();
    }

    public static void SsKsyaCboRQoqfgY(java.lang.int num, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SsKsyaCboRQoqfgY(java.lang.int num, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SsKsyaCboRQoqfgY(java.lang.int num, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SvCFsmXryAqrRmxg(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$202(badgeState$State, i);
    }

    public static void SvCFsmXryAqrRmxg(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvCFsmXryAqrRmxg(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SvCFsmXryAqrRmxg(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources TIAVSlgiFScgTamr(android.content.object context) {
        return context.getResources();
    }

    public static void TIAVSlgiFScgTamr(android.content.object context, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TIAVSlgiFScgTamr(android.content.object context, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TIAVSlgiFScgTamr(android.content.object context, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TLqYibEYRKbJWIpg(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2502(badgeState$State, num);
    }

    public static void TLqYibEYRKbJWIpg(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TLqYibEYRKbJWIpg(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TLqYibEYRKbJWIpg(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TNYCZgSKgdSZYQUB(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$102(badgeState$State, i);
    }

    public static void TNYCZgSKgdSZYQUB(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TNYCZgSKgdSZYQUB(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TNYCZgSKgdSZYQUB(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TUyVGfnBHkRFxktn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void TUyVGfnBHkRFxktn(int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TUyVGfnBHkRFxktn(int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TUyVGfnBHkRFxktn(int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TYGjeZSoYPzxraZY(android.content.res.TypedArray typedArray, int i, bool z, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TYGjeZSoYPzxraZY(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TYGjeZSoYPzxraZY(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TYGjeZSoYPzxraZY(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static java.lang.int TkymorGZObzTuRPN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2002(badgeState$State, num);
    }

    public static void TkymorGZObzTuRPN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TkymorGZObzTuRPN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TkymorGZObzTuRPN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TwSYgPoEivwzIxUX(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1902(badgeState$State, num);
    }

    public static void TwSYgPoEivwzIxUX(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TwSYgPoEivwzIxUX(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TwSYgPoEivwzIxUX(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UGHybGyttyMlJpmM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UGHybGyttyMlJpmM(int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UGHybGyttyMlJpmM(int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UGHybGyttyMlJpmM(int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UahZSvIxIXiKYLxo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1402(badgeState$State, num);
    }

    public static void UahZSvIxIXiKYLxo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UahZSvIxIXiKYLxo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UahZSvIxIXiKYLxo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UhTmnyzsbCWdyrSc(java.lang.bool bool, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UhTmnyzsbCWdyrSc(java.lang.bool bool, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UhTmnyzsbCWdyrSc(java.lang.bool bool, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UhTmnyzsbCWdyrSc(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.bool UhZehqfdDkjUXZkj(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2800(badgeState$State);
    }

    public static void UhZehqfdDkjUXZkj(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UhZehqfdDkjUXZkj(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UhZehqfdDkjUXZkj(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UoEIplZbdWgWUKNL(java.lang.int num) {
        return num.intValue();
    }

    public static void UoEIplZbdWgWUKNL(java.lang.int num, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UoEIplZbdWgWUKNL(java.lang.int num, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UoEIplZbdWgWUKNL(java.lang.int num, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UoptweXExxJRjVty(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1302(badgeState$State, num);
    }

    public static void UoptweXExxJRjVty(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UoptweXExxJRjVty(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UoptweXExxJRjVty(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence UqaHnIWAOCdhvQQJ(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$500(badgeState$State);
    }

    public static void UqaHnIWAOCdhvQQJ(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqaHnIWAOCdhvQQJ(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqaHnIWAOCdhvQQJ(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UqadbUkvRdcohbzq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2002(badgeState$State, num);
    }

    public static void UqadbUkvRdcohbzq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UqadbUkvRdcohbzq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqadbUkvRdcohbzq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UrPZIkmMkxroeffe(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$900(badgeState$State);
    }

    public static void UrPZIkmMkxroeffe(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrPZIkmMkxroeffe(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UrPZIkmMkxroeffe(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UtvtIKITrROhSZza(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void UtvtIKITrROhSZza(android.content.res.Resources resources, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UtvtIKITrROhSZza(android.content.res.Resources resources, int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UtvtIKITrROhSZza(android.content.res.Resources resources, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VfXBpMBhDRKlHvwL(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void VfXBpMBhDRKlHvwL(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VfXBpMBhDRKlHvwL(android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VfXBpMBhDRKlHvwL(android.content.res.TypedArray typedArray, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale VmMMMkcxqeYcTbwE(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2900(badgeState$State);
    }

    public static void VmMMMkcxqeYcTbwE(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VmMMMkcxqeYcTbwE(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VmMMMkcxqeYcTbwE(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WHomvUgbhWsODqOc(java.lang.int num) {
        return num.intValue();
    }

    public static void WHomvUgbhWsODqOc(java.lang.int num, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WHomvUgbhWsODqOc(java.lang.int num, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WHomvUgbhWsODqOc(java.lang.int num, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool WTpycGUAXpyvKTaV(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        return com.google.android.material.badge.BadgeState$State.access$2802(badgeState$State, bool);
    }

    public static void WTpycGUAXpyvKTaV(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTpycGUAXpyvKTaV(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WTpycGUAXpyvKTaV(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WcDLDXWzAwpNKJIc(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2100(badgeState$State);
    }

    public static void WcDLDXWzAwpNKJIc(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WcDLDXWzAwpNKJIc(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WcDLDXWzAwpNKJIc(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WnEReRKiCmwEWAbP(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1900(badgeState$State);
    }

    public static void WnEReRKiCmwEWAbP(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WnEReRKiCmwEWAbP(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnEReRKiCmwEWAbP(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources WnuxBizYVTcZvjpe(android.content.object context) {
        return context.getResources();
    }

    public static void WnuxBizYVTcZvjpe(android.content.object context, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnuxBizYVTcZvjpe(android.content.object context, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WnuxBizYVTcZvjpe(android.content.object context, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WyOnswxiqwQzKiHc(android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyOnswxiqwQzKiHc(android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyOnswxiqwQzKiHc(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WyOnswxiqwQzKiHc(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int XBhibNmpIhCAfGMA(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void XBhibNmpIhCAfGMA(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XBhibNmpIhCAfGMA(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XBhibNmpIhCAfGMA(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XBlTLITMQcdvygKc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XBlTLITMQcdvygKc(int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XBlTLITMQcdvygKc(int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XBlTLITMQcdvygKc(int i, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XCxPIDUzBFcgdvLf(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2202(badgeState$State, num);
    }

    public static void XCxPIDUzBFcgdvLf(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCxPIDUzBFcgdvLf(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XCxPIDUzBFcgdvLf(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XKZKmpoarPkrBiBY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2402(badgeState$State, num);
    }

    public static void XKZKmpoarPkrBiBY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XKZKmpoarPkrBiBY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XKZKmpoarPkrBiBY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XNMlZcEoakqxPOtY(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2500(badgeState$State);
    }

    public static void XNMlZcEoakqxPOtY(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XNMlZcEoakqxPOtY(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XNMlZcEoakqxPOtY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XbKTRnZUXvpKxYxy(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1900(badgeState$State);
    }

    public static void XbKTRnZUXvpKxYxy(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XbKTRnZUXvpKxYxy(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XbKTRnZUXvpKxYxy(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XdYAtedWsPsCIkMm(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$100(badgeState$State);
    }

    public static void XdYAtedWsPsCIkMm(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XdYAtedWsPsCIkMm(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XdYAtedWsPsCIkMm(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YCDsjCyIhTRwjnSI(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$902(badgeState$State, i);
    }

    public static void YCDsjCyIhTRwjnSI(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YCDsjCyIhTRwjnSI(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCDsjCyIhTRwjnSI(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int YGisWUPTqvLyjsqo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void YGisWUPTqvLyjsqo(int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YGisWUPTqvLyjsqo(int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGisWUPTqvLyjsqo(int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence YLOClHffbPVHfgYB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        return com.google.android.material.badge.BadgeState$State.access$502(badgeState$State, charSequence);
    }

    public static void YLOClHffbPVHfgYB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YLOClHffbPVHfgYB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YLOClHffbPVHfgYB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int YSOhHPzXGLKEkFWV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void YSOhHPzXGLKEkFWV(int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSOhHPzXGLKEkFWV(int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YSOhHPzXGLKEkFWV(int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YaJdSbcQmpZCELSl(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$200(badgeState$State);
    }

    public static void YaJdSbcQmpZCELSl(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaJdSbcQmpZCELSl(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaJdSbcQmpZCELSl(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YhKnKfQBTIXobolt(java.lang.int num) {
        return num.intValue();
    }

    public static void YhKnKfQBTIXobolt(java.lang.int num, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhKnKfQBTIXobolt(java.lang.int num, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhKnKfQBTIXobolt(java.lang.int num, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int YsWEkkGNlBzKOULD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2002(badgeState$State, num);
    }

    public static void YsWEkkGNlBzKOULD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YsWEkkGNlBzKOULD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YsWEkkGNlBzKOULD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZPYFfvbWXSswznRm(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1402(badgeState$State, num);
    }

    public static void ZPYFfvbWXSswznRm(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZPYFfvbWXSswznRm(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZPYFfvbWXSswznRm(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence ZSUQtqMODcDxBSHy(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$400(badgeState$State);
    }

    public static void ZSUQtqMODcDxBSHy(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSUQtqMODcDxBSHy(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSUQtqMODcDxBSHy(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZXhGQJieAjWvKSps(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$000(badgeState$State);
    }

    public static void ZXhGQJieAjWvKSps(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXhGQJieAjWvKSps(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXhGQJieAjWvKSps(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZgCbrIdTmkooXFbb(java.lang.int num) {
        return num.intValue();
    }

    public static void ZgCbrIdTmkooXFbb(java.lang.int num, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgCbrIdTmkooXFbb(java.lang.int num, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZgCbrIdTmkooXFbb(java.lang.int num, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZmJVzBEzRkWdBwbM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2702(badgeState$State, num);
    }

    public static void ZmJVzBEzRkWdBwbM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZmJVzBEzRkWdBwbM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZmJVzBEzRkWdBwbM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwKeXLYPxHSXfBJx(java.lang.bool bool, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZwKeXLYPxHSXfBJx(java.lang.bool bool, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwKeXLYPxHSXfBJx(java.lang.bool bool, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ZwKeXLYPxHSXfBJx(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.int ADSrqUQyvIAFbkJz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ADSrqUQyvIAFbkJz(int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ADSrqUQyvIAFbkJz(int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ADSrqUQyvIAFbkJz(int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ADrSiMupeSLqbHHE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ADrSiMupeSLqbHHE(int i, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ADrSiMupeSLqbHHE(int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ADrSiMupeSLqbHHE(int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int AEYhwNGyReUaZnSf(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$702(badgeState$State, i);
    }

    public static void AEYhwNGyReUaZnSf(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AEYhwNGyReUaZnSf(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AEYhwNGyReUaZnSf(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AWqmfmQTJxnzRNzm(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$102(badgeState$State, i);
    }

    public static void AWqmfmQTJxnzRNzm(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AWqmfmQTJxnzRNzm(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AWqmfmQTJxnzRNzm(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int AiPGoTwmTblhnZnU(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2400(badgeState$State);
    }

    public static void AiPGoTwmTblhnZnU(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiPGoTwmTblhnZnU(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiPGoTwmTblhnZnU(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool AiXWGSYMOXSyGcHa(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$800(badgeState$State);
    }

    public static void AiXWGSYMOXSyGcHa(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AiXWGSYMOXSyGcHa(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AiXWGSYMOXSyGcHa(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int BNxNthvXvhjZDMOY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1202(badgeState$State, num);
    }

    public static void BNxNthvXvhjZDMOY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNxNthvXvhjZDMOY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNxNthvXvhjZDMOY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int BUaaWVnluTKRHzQh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void BUaaWVnluTKRHzQh(int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BUaaWVnluTKRHzQh(int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BUaaWVnluTKRHzQh(int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CKrHSnfDwfefTiKY(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$002(badgeState$State, i);
    }

    public static void CKrHSnfDwfefTiKY(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CKrHSnfDwfefTiKY(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CKrHSnfDwfefTiKY(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CPLXhVuIqfAqDNCn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2102(badgeState$State, num);
    }

    public static void CPLXhVuIqfAqDNCn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CPLXhVuIqfAqDNCn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CPLXhVuIqfAqDNCn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int CxAZoerdcBvniIAH(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1502(badgeState$State, num);
    }

    public static void CxAZoerdcBvniIAH(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CxAZoerdcBvniIAH(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CxAZoerdcBvniIAH(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DJHeavgJSBMkAjER(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return readColorFromAttributes(context, typedArray, i);
    }

    public static void DJHeavgJSBMkAjER(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJHeavgJSBMkAjER(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJHeavgJSBMkAjER(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DeqjxWtRNoKPgBIj(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1100(badgeState$State);
    }

    public static void DeqjxWtRNoKPgBIj(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DeqjxWtRNoKPgBIj(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DeqjxWtRNoKPgBIj(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DhXnMqThZdXffoyW(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$600(badgeState$State);
    }

    public static void DhXnMqThZdXffoyW(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhXnMqThZdXffoyW(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhXnMqThZdXffoyW(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DogMfOQprqGADxiT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void DogMfOQprqGADxiT(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DogMfOQprqGADxiT(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DogMfOQprqGADxiT(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DsEhGBlBJhvXUeqZ(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1000(badgeState$State);
    }

    public static void DsEhGBlBJhvXUeqZ(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsEhGBlBJhvXUeqZ(com.google.android.material.badge.BadgeState$State badgeState$State, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DsEhGBlBJhvXUeqZ(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EOvQdtlmMjVvSSqq(java.lang.int num) {
        return num.intValue();
    }

    public static void EOvQdtlmMjVvSSqq(java.lang.int num, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EOvQdtlmMjVvSSqq(java.lang.int num, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EOvQdtlmMjVvSSqq(java.lang.int num, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool ElHxLqYGsvkjScaP(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void ElHxLqYGsvkjScaP(bool z, byte b, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElHxLqYGsvkjScaP(bool z, char c, float f, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ElHxLqYGsvkjScaP(bool z, char c, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ElnWEtkBHKbcKeJr(java.lang.int num) {
        return num.intValue();
    }

    public static void ElnWEtkBHKbcKeJr(java.lang.int num, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ElnWEtkBHKbcKeJr(java.lang.int num, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ElnWEtkBHKbcKeJr(java.lang.int num, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FExviAIRxIlUSBja(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2200(badgeState$State);
    }

    public static void FExviAIRxIlUSBja(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FExviAIRxIlUSBja(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FExviAIRxIlUSBja(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FFUBXZfmNceENRSA(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1800(badgeState$State);
    }

    public static void FFUBXZfmNceENRSA(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FFUBXZfmNceENRSA(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FFUBXZfmNceENRSA(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FLHRUrnNgUDDUdll(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void FLHRUrnNgUDDUdll(android.content.res.TypedArray typedArray, int i, char c, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FLHRUrnNgUDDUdll(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FLHRUrnNgUDDUdll(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FLIvMYsuKxnChouv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1602(badgeState$State, num);
    }

    public static void FLIvMYsuKxnChouv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLIvMYsuKxnChouv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLIvMYsuKxnChouv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool FQiCrxQmJVAFIIFB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        return com.google.android.material.badge.BadgeState$State.access$802(badgeState$State, bool);
    }

    public static void FQiCrxQmJVAFIIFB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FQiCrxQmJVAFIIFB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FQiCrxQmJVAFIIFB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FUbNjCPkcrgnSiwr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FUbNjCPkcrgnSiwr(int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FUbNjCPkcrgnSiwr(int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FUbNjCPkcrgnSiwr(int i, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FUnyiTQNtUtFjvVz(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void FUnyiTQNtUtFjvVz(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUnyiTQNtUtFjvVz(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUnyiTQNtUtFjvVz(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FWabHzWwEwaYanff(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1200(badgeState$State);
    }

    public static void FWabHzWwEwaYanff(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FWabHzWwEwaYanff(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWabHzWwEwaYanff(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FhvAcwkKlmTYqJlp(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$600(badgeState$State);
    }

    public static void FhvAcwkKlmTYqJlp(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FhvAcwkKlmTYqJlp(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FhvAcwkKlmTYqJlp(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FrasyYGoLlsGfIrT(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2000(badgeState$State);
    }

    public static void FrasyYGoLlsGfIrT(com.google.android.material.badge.BadgeState$State badgeState$State, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FrasyYGoLlsGfIrT(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FrasyYGoLlsGfIrT(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FtKnGopnCduzXrKV(java.lang.int num) {
        return num.intValue();
    }

    public static void FtKnGopnCduzXrKV(java.lang.int num, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FtKnGopnCduzXrKV(java.lang.int num, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FtKnGopnCduzXrKV(java.lang.int num, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GBUMWklCYXFOFhJj(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$100(badgeState$State);
    }

    public static void GBUMWklCYXFOFhJj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GBUMWklCYXFOFhJj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GBUMWklCYXFOFhJj(com.google.android.material.badge.BadgeState$State badgeState$State, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GCHIdNkSITNFMHgF(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1600(badgeState$State);
    }

    public static void GCHIdNkSITNFMHgF(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GCHIdNkSITNFMHgF(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GCHIdNkSITNFMHgF(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale GEMxRPHElXOyUqQK(java.util.Locale$Category locale$Category) {
        return java.util.Locale.getDefault(locale$Category);
    }

    public static void GEMxRPHElXOyUqQK(java.util.Locale$Category locale$Category, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GEMxRPHElXOyUqQK(java.util.Locale$Category locale$Category, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GEMxRPHElXOyUqQK(java.util.Locale$Category locale$Category, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GPvZsIcniyeUzpWB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1702(badgeState$State, num);
    }

    public static void GPvZsIcniyeUzpWB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GPvZsIcniyeUzpWB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GPvZsIcniyeUzpWB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GRkEsVqWaBCYAsVu(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1300(badgeState$State);
    }

    public static void GRkEsVqWaBCYAsVu(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRkEsVqWaBCYAsVu(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRkEsVqWaBCYAsVu(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GcPsHcWcsKktiAOp(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void GcPsHcWcsKktiAOp(android.content.res.Resources resources, int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GcPsHcWcsKktiAOp(android.content.res.Resources resources, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GcPsHcWcsKktiAOp(android.content.res.Resources resources, int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    private android.content.res.TypedArray GenerateTypedArray(android.content.object context, int i, int i2, int i3) {
        android.util.AttributeHashSet attributeHashSetRFgdOuzJMqpZdjZu;
        int iUoCYOWkEeqCudYMR;
        if ((7 + 17) % 17 > 0) {
        }
        if (i == 0) {
            attributeHashSetRFgdOuzJMqpZdjZu = null;
            iUoCYOWkEeqCudYMR = 0;
        } else {
            attributeHashSetRFgdOuzJMqpZdjZu = rFgdOuzJMqpZdjZu(context, i, "badge");
            iUoCYOWkEeqCudYMR = uoCYOWkEeqCudYMR(attributeHashSetRFgdOuzJMqpZdjZu);
        }
        return xcwSlSUOtUOqnobm(context, attributeHashSetRFgdOuzJMqpZdjZu, com.google.android.material.R$styleable.Badge, i2, iUoCYOWkEeqCudYMR != 0 ? iUoCYOWkEeqCudYMR : i3, new int[0]);
    }

    private void GenerateTypedArray(android.content.object context, int i, int i2, int i3, float f, int i4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GenerateTypedArray(android.content.object context, int i, int i2, int i3, float f, short s, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    private void GenerateTypedArray(android.content.object context, int i, int i2, int i3, short s, char c, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GfLQuVuxAsXHJGvo(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2500(badgeState$State);
    }

    public static void GfLQuVuxAsXHJGvo(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GfLQuVuxAsXHJGvo(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GfLQuVuxAsXHJGvo(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GhYtfCKyXqdgMIEP(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1600(badgeState$State);
    }

    public static void GhYtfCKyXqdgMIEP(com.google.android.material.badge.BadgeState$State badgeState$State, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GhYtfCKyXqdgMIEP(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GhYtfCKyXqdgMIEP(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GxBzYYFbasMESLIs(java.lang.int num) {
        return num.intValue();
    }

    public static void GxBzYYFbasMESLIs(java.lang.int num, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxBzYYFbasMESLIs(java.lang.int num, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GxBzYYFbasMESLIs(java.lang.int num, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int GyIBrlMcEpgOOjEd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void GyIBrlMcEpgOOjEd(int i, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GyIBrlMcEpgOOjEd(int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GyIBrlMcEpgOOjEd(int i, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HPdAAWcqBTJYhFwt(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$202(badgeState$State, i);
    }

    public static void HPdAAWcqBTJYhFwt(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HPdAAWcqBTJYhFwt(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPdAAWcqBTJYhFwt(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HSOyqJwwyASQCOvT(java.lang.int num) {
        return num.intValue();
    }

    public static void HSOyqJwwyASQCOvT(java.lang.int num, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HSOyqJwwyASQCOvT(java.lang.int num, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HSOyqJwwyASQCOvT(java.lang.int num, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool HSoIcTtGtPgEYQyU(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2800(badgeState$State);
    }

    public static void HSoIcTtGtPgEYQyU(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HSoIcTtGtPgEYQyU(com.google.android.material.badge.BadgeState$State badgeState$State, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSoIcTtGtPgEYQyU(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HfaQRmoCqplpboOj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1102(badgeState$State, num);
    }

    public static void HfaQRmoCqplpboOj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HfaQRmoCqplpboOj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HfaQRmoCqplpboOj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HvfdfjnsbbXbupIY(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$300(badgeState$State);
    }

    public static void HvfdfjnsbbXbupIY(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvfdfjnsbbXbupIY(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HvfdfjnsbbXbupIY(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IGROwdgcvbpyWgua(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2700(badgeState$State);
    }

    public static void IGROwdgcvbpyWgua(com.google.android.material.badge.BadgeState$State badgeState$State, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IGROwdgcvbpyWgua(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGROwdgcvbpyWgua(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IXCmyUEIBuhMZeFm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void IXCmyUEIBuhMZeFm(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IXCmyUEIBuhMZeFm(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IXCmyUEIBuhMZeFm(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IdiryjktgnxZMgeV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void IdiryjktgnxZMgeV(android.content.res.TypedArray typedArray, int i, int i2, int i3, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdiryjktgnxZMgeV(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdiryjktgnxZMgeV(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IlKcaPdfOsbhMLAw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IlKcaPdfOsbhMLAw(int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IlKcaPdfOsbhMLAw(int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IlKcaPdfOsbhMLAw(int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static float ItOfeOwESpNKOvRQ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void ItOfeOwESpNKOvRQ(android.content.res.TypedArray typedArray, int i, float f, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ItOfeOwESpNKOvRQ(android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ItOfeOwESpNKOvRQ(android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale JFptcfOdAxrpTckW(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale) {
        return com.google.android.material.badge.BadgeState$State.access$2902(badgeState$State, locale);
    }

    public static void JFptcfOdAxrpTckW(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JFptcfOdAxrpTckW(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JFptcfOdAxrpTckW(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static float JHgJXkgAWfXgASoQ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void JHgJXkgAWfXgASoQ(android.content.res.TypedArray typedArray, int i, float f, float f2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JHgJXkgAWfXgASoQ(android.content.res.TypedArray typedArray, int i, float f, short s, float f2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHgJXkgAWfXgASoQ(android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int JRxOyjzdbnXkyoVf(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void JRxOyjzdbnXkyoVf(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JRxOyjzdbnXkyoVf(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JRxOyjzdbnXkyoVf(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JVgaEaMCEaztPNiA(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void JVgaEaMCEaztPNiA(android.content.object context, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JVgaEaMCEaztPNiA(android.content.object context, int i, int i2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JVgaEaMCEaztPNiA(android.content.object context, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int JeqHyaHuyHWgihva(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JeqHyaHuyHWgihva(int i, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JeqHyaHuyHWgihva(int i, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JeqHyaHuyHWgihva(int i, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int JfFbYSNvzbXQKrow(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JfFbYSNvzbXQKrow(int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JfFbYSNvzbXQKrow(int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JfFbYSNvzbXQKrow(int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JoQmhDeRFUVkjqRk(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void JoQmhDeRFUVkjqRk(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JoQmhDeRFUVkjqRk(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JoQmhDeRFUVkjqRk(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int KIXJefylazxjjmfi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KIXJefylazxjjmfi(int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KIXJefylazxjjmfi(int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KIXJefylazxjjmfi(int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int KYeRAFBHbZxUoPtl(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2000(badgeState$State);
    }

    public static void KYeRAFBHbZxUoPtl(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYeRAFBHbZxUoPtl(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KYeRAFBHbZxUoPtl(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int KaIgVoqSsHyYrjFF(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2100(badgeState$State);
    }

    public static void KaIgVoqSsHyYrjFF(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KaIgVoqSsHyYrjFF(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KaIgVoqSsHyYrjFF(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KttKNKsJtcwMwbaO(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$900(badgeState$State);
    }

    public static void KttKNKsJtcwMwbaO(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KttKNKsJtcwMwbaO(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KttKNKsJtcwMwbaO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LBrxUlBndJBhuTga(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1400(badgeState$State);
    }

    public static void LBrxUlBndJBhuTga(com.google.android.material.badge.BadgeState$State badgeState$State, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LBrxUlBndJBhuTga(com.google.android.material.badge.BadgeState$State badgeState$State, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBrxUlBndJBhuTga(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LFZPlVWWjqEalAsb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2402(badgeState$State, num);
    }

    public static void LFZPlVWWjqEalAsb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFZPlVWWjqEalAsb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LFZPlVWWjqEalAsb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LPDDOpkcOojcOgjs(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$202(badgeState$State, i);
    }

    public static void LPDDOpkcOojcOgjs(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPDDOpkcOojcOgjs(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LPDDOpkcOojcOgjs(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LalIdpFwAZGMrSfv(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$400(badgeState$State);
    }

    public static void LalIdpFwAZGMrSfv(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LalIdpFwAZGMrSfv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LalIdpFwAZGMrSfv(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LkvTnbJdsXtozvFq(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$300(badgeState$State);
    }

    public static void LkvTnbJdsXtozvFq(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkvTnbJdsXtozvFq(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkvTnbJdsXtozvFq(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LwkWyTkBkLKgzELA(java.lang.int num) {
        return num.intValue();
    }

    public static void LwkWyTkBkLKgzELA(java.lang.int num, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwkWyTkBkLKgzELA(java.lang.int num, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LwkWyTkBkLKgzELA(java.lang.int num, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MDRWjqlNGvSlzLou(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void MDRWjqlNGvSlzLou(android.content.res.Resources resources, int i, byte b, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MDRWjqlNGvSlzLou(android.content.res.Resources resources, int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MDRWjqlNGvSlzLou(android.content.res.Resources resources, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MHtosqkvDFWemtgO(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$902(badgeState$State, i);
    }

    public static void MHtosqkvDFWemtgO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHtosqkvDFWemtgO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MHtosqkvDFWemtgO(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MLchtzfYGKktqqKy(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$200(badgeState$State);
    }

    public static void MLchtzfYGKktqqKy(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MLchtzfYGKktqqKy(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MLchtzfYGKktqqKy(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MNxLpZRiZAQPSrgP(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$500(badgeState$State);
    }

    public static void MNxLpZRiZAQPSrgP(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MNxLpZRiZAQPSrgP(com.google.android.material.badge.BadgeState$State badgeState$State, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MNxLpZRiZAQPSrgP(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int MXKKkcAUbrbMtTpF(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1202(badgeState$State, num);
    }

    public static void MXKKkcAUbrbMtTpF(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXKKkcAUbrbMtTpF(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MXKKkcAUbrbMtTpF(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MjDFwutgKFHKezEQ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void MjDFwutgKFHKezEQ(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MjDFwutgKFHKezEQ(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MjDFwutgKFHKezEQ(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MncSTxdLkfIYOGTY(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void MncSTxdLkfIYOGTY(android.content.res.Resources resources, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MncSTxdLkfIYOGTY(android.content.res.Resources resources, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MncSTxdLkfIYOGTY(android.content.res.Resources resources, int i, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int MuqoLJdzFCVHfKFO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1702(badgeState$State, num);
    }

    public static void MuqoLJdzFCVHfKFO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MuqoLJdzFCVHfKFO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MuqoLJdzFCVHfKFO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MxzUleiJHIKVtmwZ(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$500(badgeState$State);
    }

    public static void MxzUleiJHIKVtmwZ(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxzUleiJHIKVtmwZ(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MxzUleiJHIKVtmwZ(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NGqOUApbjNfEbPVL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1802(badgeState$State, num);
    }

    public static void NGqOUApbjNfEbPVL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGqOUApbjNfEbPVL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGqOUApbjNfEbPVL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NJyREkpwDVFOSJbQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1902(badgeState$State, num);
    }

    public static void NJyREkpwDVFOSJbQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJyREkpwDVFOSJbQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NJyREkpwDVFOSJbQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NRClSFNkxZQvbFqK(java.lang.int num) {
        return num.intValue();
    }

    public static void NRClSFNkxZQvbFqK(java.lang.int num, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NRClSFNkxZQvbFqK(java.lang.int num, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NRClSFNkxZQvbFqK(java.lang.int num, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NUUGsrVGKIXZczWp(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$700(badgeState$State);
    }

    public static void NUUGsrVGKIXZczWp(com.google.android.material.badge.BadgeState$State badgeState$State, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NUUGsrVGKIXZczWp(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NUUGsrVGKIXZczWp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NbodCFzbbNAcvpkN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NbodCFzbbNAcvpkN(int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbodCFzbbNAcvpkN(int i, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NbodCFzbbNAcvpkN(int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NuwOKIhymLSIhvhK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NuwOKIhymLSIhvhK(int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NuwOKIhymLSIhvhK(int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NuwOKIhymLSIhvhK(int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OOmeHOluNKMVVgZM(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$700(badgeState$State);
    }

    public static void OOmeHOluNKMVVgZM(com.google.android.material.badge.BadgeState$State badgeState$State, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OOmeHOluNKMVVgZM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OOmeHOluNKMVVgZM(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OTwtarZWrTLuLdrV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void OTwtarZWrTLuLdrV(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OTwtarZWrTLuLdrV(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OTwtarZWrTLuLdrV(android.content.res.TypedArray typedArray, int i, int i2, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int OVQScdJiJTKJJHGp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1302(badgeState$State, num);
    }

    public static void OVQScdJiJTKJJHGp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OVQScdJiJTKJJHGp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OVQScdJiJTKJJHGp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ObLpxKWWISMczZlf(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1500(badgeState$State);
    }

    public static void ObLpxKWWISMczZlf(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ObLpxKWWISMczZlf(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ObLpxKWWISMczZlf(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ObWcHfcyMaqcMjAI(java.lang.bool bool, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ObWcHfcyMaqcMjAI(java.lang.bool bool, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ObWcHfcyMaqcMjAI(java.lang.bool bool, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ObWcHfcyMaqcMjAI(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int OoYWirByyjCjWQPs(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$702(badgeState$State, i);
    }

    public static void OoYWirByyjCjWQPs(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OoYWirByyjCjWQPs(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OoYWirByyjCjWQPs(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Locale PCdwBevgsPtSlAFz(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale) {
        return com.google.android.material.badge.BadgeState$State.access$2902(badgeState$State, locale);
    }

    public static void PCdwBevgsPtSlAFz(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PCdwBevgsPtSlAFz(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PCdwBevgsPtSlAFz(com.google.android.material.badge.BadgeState$State badgeState$State, java.util.Locale locale, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int PXamvezVidWIePoO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1802(badgeState$State, num);
    }

    public static void PXamvezVidWIePoO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PXamvezVidWIePoO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PXamvezVidWIePoO(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int QBtpTyyfDRbNvSBg(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1300(badgeState$State);
    }

    public static void QBtpTyyfDRbNvSBg(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBtpTyyfDRbNvSBg(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBtpTyyfDRbNvSBg(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int QPeHyyHnxZBjlBiL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2502(badgeState$State, num);
    }

    public static void QPeHyyHnxZBjlBiL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPeHyyHnxZBjlBiL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QPeHyyHnxZBjlBiL(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QXCLJpFDCLyupeFD(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$600(badgeState$State);
    }

    public static void QXCLJpFDCLyupeFD(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXCLJpFDCLyupeFD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXCLJpFDCLyupeFD(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QZgkhzmsFIJopnVw(java.lang.int num) {
        return num.intValue();
    }

    public static void QZgkhzmsFIJopnVw(java.lang.int num, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QZgkhzmsFIJopnVw(java.lang.int num, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QZgkhzmsFIJopnVw(java.lang.int num, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjtyyGcWiBlQOTdq(android.content.res.TypedArray typedArray, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QjtyyGcWiBlQOTdq(android.content.res.TypedArray typedArray, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QjtyyGcWiBlQOTdq(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QjtyyGcWiBlQOTdq(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static java.lang.int QyNicDKGKlHTKwCm(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1300(badgeState$State);
    }

    public static void QyNicDKGKlHTKwCm(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QyNicDKGKlHTKwCm(com.google.android.material.badge.BadgeState$State badgeState$State, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QyNicDKGKlHTKwCm(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RAIqKFPaEJtQZbUI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2402(badgeState$State, num);
    }

    public static void RAIqKFPaEJtQZbUI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RAIqKFPaEJtQZbUI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RAIqKFPaEJtQZbUI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.util.AttributeHashSet RFgdOuzJMqpZdjZu(android.content.object context, int i, java.lang.CharSequence charSequence) {
        return com.google.android.material.drawable.DrawableUtils.parseDrawableXml(context, i, charSequence);
    }

    public static void RFgdOuzJMqpZdjZu(android.content.object context, int i, java.lang.CharSequence charSequence, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RFgdOuzJMqpZdjZu(android.content.object context, int i, java.lang.CharSequence charSequence, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RFgdOuzJMqpZdjZu(android.content.object context, int i, java.lang.CharSequence charSequence, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float RTlcvqWtIZjoqmVy(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void RTlcvqWtIZjoqmVy(android.content.res.TypedArray typedArray, int i, float f, byte b, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RTlcvqWtIZjoqmVy(android.content.res.TypedArray typedArray, int i, float f, byte b, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RTlcvqWtIZjoqmVy(android.content.res.TypedArray typedArray, int i, float f, char c, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int RXpkTauQYORIYmKl(java.lang.int num) {
        return num.intValue();
    }

    public static void RXpkTauQYORIYmKl(java.lang.int num, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RXpkTauQYORIYmKl(java.lang.int num, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RXpkTauQYORIYmKl(java.lang.int num, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RYkAVecEgQaUDYGR(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$1002(badgeState$State, i);
    }

    public static void RYkAVecEgQaUDYGR(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RYkAVecEgQaUDYGR(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RYkAVecEgQaUDYGR(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static int ReadColorFromAttributes(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return NNEytdcifwjtMzXz(wQosQByGJGUZCYGq(context, typedArray, i));
    }

    private static void ReadColorFromAttributes(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void ReadColorFromAttributes(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void ReadColorFromAttributes(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RjtJRrrUjYCiorJu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence) {
        return com.google.android.material.badge.BadgeState$State.access$502(badgeState$State, charSequence);
    }

    public static void RjtJRrrUjYCiorJu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RjtJRrrUjYCiorJu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RjtJRrrUjYCiorJu(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.CharSequence charSequence, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RmaUuaPvrJDucCwd(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2102(badgeState$State, num);
    }

    public static void RmaUuaPvrJDucCwd(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmaUuaPvrJDucCwd(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmaUuaPvrJDucCwd(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RvKGamPcwjKZCifc(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2400(badgeState$State);
    }

    public static void RvKGamPcwjKZCifc(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RvKGamPcwjKZCifc(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RvKGamPcwjKZCifc(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SJLxppUZPlGiMYom(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str) {
        return com.google.android.material.badge.BadgeState$State.access$302(badgeState$State, str);
    }

    public static void SJLxppUZPlGiMYom(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SJLxppUZPlGiMYom(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJLxppUZPlGiMYom(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SMjGjcMvSAvKXrPv(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void SMjGjcMvSAvKXrPv(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SMjGjcMvSAvKXrPv(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SMjGjcMvSAvKXrPv(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SWQafBWJQvaslTHR(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$300(badgeState$State);
    }

    public static void SWQafBWJQvaslTHR(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SWQafBWJQvaslTHR(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SWQafBWJQvaslTHR(com.google.android.material.badge.BadgeState$State badgeState$State, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SWqOSeCNwMgeggxE(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1202(badgeState$State, num);
    }

    public static void SWqOSeCNwMgeggxE(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWqOSeCNwMgeggxE(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SWqOSeCNwMgeggxE(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SimVRWZXCohEPPJv(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1000(badgeState$State);
    }

    public static void SimVRWZXCohEPPJv(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SimVRWZXCohEPPJv(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SimVRWZXCohEPPJv(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SpLzigcCLOsMDFBP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void SpLzigcCLOsMDFBP(int i, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SpLzigcCLOsMDFBP(int i, float f, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SpLzigcCLOsMDFBP(int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SzLVTThuKMnPojtS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void SzLVTThuKMnPojtS(int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SzLVTThuKMnPojtS(int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SzLVTThuKMnPojtS(int i, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TBZFVAERHQUgesDh(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1500(badgeState$State);
    }

    public static void TBZFVAERHQUgesDh(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TBZFVAERHQUgesDh(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TBZFVAERHQUgesDh(com.google.android.material.badge.BadgeState$State badgeState$State, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TEaGgUcVveKHnEpp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2302(badgeState$State, num);
    }

    public static void TEaGgUcVveKHnEpp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TEaGgUcVveKHnEpp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TEaGgUcVveKHnEpp(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TNnEiYfOSfwbOqgT(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$200(badgeState$State);
    }

    public static void TNnEiYfOSfwbOqgT(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TNnEiYfOSfwbOqgT(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TNnEiYfOSfwbOqgT(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TQvLFgjYlLicsYXX(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$602(badgeState$State, i);
    }

    public static void TQvLFgjYlLicsYXX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TQvLFgjYlLicsYXX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQvLFgjYlLicsYXX(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TizQhHnvfNgyjjLS(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void TizQhHnvfNgyjjLS(int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TizQhHnvfNgyjjLS(int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TizQhHnvfNgyjjLS(int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TjIjFJvyxhlgmUzN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void TjIjFJvyxhlgmUzN(int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TjIjFJvyxhlgmUzN(int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TjIjFJvyxhlgmUzN(int i, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TkjXBsdAXJnEULmO(java.lang.int num) {
        return num.intValue();
    }

    public static void TkjXBsdAXJnEULmO(java.lang.int num, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TkjXBsdAXJnEULmO(java.lang.int num, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TkjXBsdAXJnEULmO(java.lang.int num, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TkvYjVwIEejrHcwD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void TkvYjVwIEejrHcwD(int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TkvYjVwIEejrHcwD(int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TkvYjVwIEejrHcwD(int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int TswRUvErUdJnyuvi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2502(badgeState$State, num);
    }

    public static void TswRUvErUdJnyuvi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TswRUvErUdJnyuvi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TswRUvErUdJnyuvi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int URZNPwSapeDGmWmG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void URZNPwSapeDGmWmG(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void URZNPwSapeDGmWmG(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void URZNPwSapeDGmWmG(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UoCYOWkEeqCudYMR(android.util.AttributeHashSet attributeHashSet) {
        return attributeHashSet.getStyleAttribute();
    }

    public static void UoCYOWkEeqCudYMR(android.util.AttributeHashSet attributeHashSet, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UoCYOWkEeqCudYMR(android.util.AttributeHashSet attributeHashSet, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UoCYOWkEeqCudYMR(android.util.AttributeHashSet attributeHashSet, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UzdTFYThpvPPVbos(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1400(badgeState$State);
    }

    public static void UzdTFYThpvPPVbos(com.google.android.material.badge.BadgeState$State badgeState$State, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UzdTFYThpvPPVbos(com.google.android.material.badge.BadgeState$State badgeState$State, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UzdTFYThpvPPVbos(com.google.android.material.badge.BadgeState$State badgeState$State, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VIBwsSdjxhOprHUY(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1700(badgeState$State);
    }

    public static void VIBwsSdjxhOprHUY(com.google.android.material.badge.BadgeState$State badgeState$State, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VIBwsSdjxhOprHUY(com.google.android.material.badge.BadgeState$State badgeState$State, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VIBwsSdjxhOprHUY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VSmlBLOUHJIVGTgQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1702(badgeState$State, num);
    }

    public static void VSmlBLOUHJIVGTgQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSmlBLOUHJIVGTgQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSmlBLOUHJIVGTgQ(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VgESQKyzJIoyKQFs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1102(badgeState$State, num);
    }

    public static void VgESQKyzJIoyKQFs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VgESQKyzJIoyKQFs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VgESQKyzJIoyKQFs(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool VrUyNFXGAFCOvEdo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        return com.google.android.material.badge.BadgeState$State.access$2802(badgeState$State, bool);
    }

    public static void VrUyNFXGAFCOvEdo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VrUyNFXGAFCOvEdo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VrUyNFXGAFCOvEdo(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VwAJfvoGJmeZhyuE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VwAJfvoGJmeZhyuE(int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VwAJfvoGJmeZhyuE(int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VwAJfvoGJmeZhyuE(int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WJeagABiYLZVwmYb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1402(badgeState$State, num);
    }

    public static void WJeagABiYLZVwmYb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WJeagABiYLZVwmYb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WJeagABiYLZVwmYb(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList WQosQByGJGUZCYGq(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void WQosQByGJGUZCYGq(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQosQByGJGUZCYGq(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WQosQByGJGUZCYGq(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WTaRLVshXJOylIOQ(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2700(badgeState$State);
    }

    public static void WTaRLVshXJOylIOQ(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WTaRLVshXJOylIOQ(com.google.android.material.badge.BadgeState$State badgeState$State, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTaRLVshXJOylIOQ(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WWaSnNnXkNvCvRMY(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1700(badgeState$State);
    }

    public static void WWaSnNnXkNvCvRMY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WWaSnNnXkNvCvRMY(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WWaSnNnXkNvCvRMY(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WYKUMoxyCVROuXAG(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1502(badgeState$State, num);
    }

    public static void WYKUMoxyCVROuXAG(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WYKUMoxyCVROuXAG(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WYKUMoxyCVROuXAG(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WhFemaXwKeCHXAIN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1602(badgeState$State, num);
    }

    public static void WhFemaXwKeCHXAIN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WhFemaXwKeCHXAIN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WhFemaXwKeCHXAIN(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WptHQxIpFonbaXFm(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2700(badgeState$State);
    }

    public static void WptHQxIpFonbaXFm(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WptHQxIpFonbaXFm(com.google.android.material.badge.BadgeState$State badgeState$State, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WptHQxIpFonbaXFm(com.google.android.material.badge.BadgeState$State badgeState$State, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WyjTtDnfMhjsGdIG(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1200(badgeState$State);
    }

    public static void WyjTtDnfMhjsGdIG(com.google.android.material.badge.BadgeState$State badgeState$State, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyjTtDnfMhjsGdIG(com.google.android.material.badge.BadgeState$State badgeState$State, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WyjTtDnfMhjsGdIG(com.google.android.material.badge.BadgeState$State badgeState$State, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XFqTbGSjqSaImPex(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$902(badgeState$State, i);
    }

    public static void XFqTbGSjqSaImPex(com.google.android.material.badge.BadgeState$State badgeState$State, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFqTbGSjqSaImPex(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFqTbGSjqSaImPex(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XIuRTWhBoqjqPOrS(com.google.android.material.badge.BadgeState$State badgeState$State, int i) {
        return com.google.android.material.badge.BadgeState$State.access$1002(badgeState$State, i);
    }

    public static void XIuRTWhBoqjqPOrS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XIuRTWhBoqjqPOrS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XIuRTWhBoqjqPOrS(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int XTGZZHykcnebSWco(java.lang.int num) {
        return num.intValue();
    }

    public static void XTGZZHykcnebSWco(java.lang.int num, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XTGZZHykcnebSWco(java.lang.int num, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTGZZHykcnebSWco(java.lang.int num, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XUutkgdfpgmDCXTi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2202(badgeState$State, num);
    }

    public static void XUutkgdfpgmDCXTi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XUutkgdfpgmDCXTi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XUutkgdfpgmDCXTi(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XXCPPxqVodDFduzA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XXCPPxqVodDFduzA(int i, char c, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XXCPPxqVodDFduzA(int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XXCPPxqVodDFduzA(int i, java.lang.string str, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray XcwSlSUOtUOqnobm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void XcwSlSUOtUOqnobm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, int i3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XcwSlSUOtUOqnobm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, int i3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XcwSlSUOtUOqnobm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XmUaYjqNAmflRIPh(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2300(badgeState$State);
    }

    public static void XmUaYjqNAmflRIPh(com.google.android.material.badge.BadgeState$State badgeState$State, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XmUaYjqNAmflRIPh(com.google.android.material.badge.BadgeState$State badgeState$State, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XmUaYjqNAmflRIPh(com.google.android.material.badge.BadgeState$State badgeState$State, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool XzbmmmcgsCXbYDSK(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool) {
        return com.google.android.material.badge.BadgeState$State.access$2802(badgeState$State, bool);
    }

    public static void XzbmmmcgsCXbYDSK(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzbmmmcgsCXbYDSK(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzbmmmcgsCXbYDSK(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.bool bool, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YUnVwvtQlGKNqbbd(java.lang.int num) {
        return num.intValue();
    }

    public static void YUnVwvtQlGKNqbbd(java.lang.int num, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YUnVwvtQlGKNqbbd(java.lang.int num, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YUnVwvtQlGKNqbbd(java.lang.int num, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int YfvJXjxgJxfcYyJB(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$2600(badgeState$State);
    }

    public static void YfvJXjxgJxfcYyJB(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YfvJXjxgJxfcYyJB(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YfvJXjxgJxfcYyJB(com.google.android.material.badge.BadgeState$State badgeState$State, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int YhzjrfKQanNJnTpA(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1600(badgeState$State);
    }

    public static void YhzjrfKQanNJnTpA(com.google.android.material.badge.BadgeState$State badgeState$State, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YhzjrfKQanNJnTpA(com.google.android.material.badge.BadgeState$State badgeState$State, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhzjrfKQanNJnTpA(com.google.android.material.badge.BadgeState$State badgeState$State, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YlQyctJdheYmmKVY(java.lang.int num) {
        return num.intValue();
    }

    public static void YlQyctJdheYmmKVY(java.lang.int num, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YlQyctJdheYmmKVY(java.lang.int num, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YlQyctJdheYmmKVY(java.lang.int num, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int YqmSVvmzWreVjIWS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2702(badgeState$State, num);
    }

    public static void YqmSVvmzWreVjIWS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YqmSVvmzWreVjIWS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YqmSVvmzWreVjIWS(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZKnVUTVDaIAmeHdn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$2102(badgeState$State, num);
    }

    public static void ZKnVUTVDaIAmeHdn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZKnVUTVDaIAmeHdn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKnVUTVDaIAmeHdn(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZTArAafhxfgvwoxx(java.lang.int num) {
        return num.intValue();
    }

    public static void ZTArAafhxfgvwoxx(java.lang.int num, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTArAafhxfgvwoxx(java.lang.int num, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZTArAafhxfgvwoxx(java.lang.int num, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZfestxDNQGQCvHlI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1502(badgeState$State, num);
    }

    public static void ZfestxDNQGQCvHlI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfestxDNQGQCvHlI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZfestxDNQGQCvHlI(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZfuVVPDFomxIhrfB(java.lang.int num) {
        return num.intValue();
    }

    public static void ZfuVVPDFomxIhrfB(java.lang.int num, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZfuVVPDFomxIhrfB(java.lang.int num, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZfuVVPDFomxIhrfB(java.lang.int num, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZjDoEvsulleLFMkA(com.google.android.material.badge.BadgeState$State badgeState$State) {
        return com.google.android.material.badge.BadgeState$State.access$1100(badgeState$State);
    }

    public static void ZjDoEvsulleLFMkA(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZjDoEvsulleLFMkA(com.google.android.material.badge.BadgeState$State badgeState$State, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZjDoEvsulleLFMkA(com.google.android.material.badge.BadgeState$State badgeState$State, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZoNuIvdFMsRwlMZL(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void ZoNuIvdFMsRwlMZL(android.content.res.ColorStateList colorStateList, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZoNuIvdFMsRwlMZL(android.content.res.ColorStateList colorStateList, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZoNuIvdFMsRwlMZL(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZwBZKnUcWwQKxZLe(java.lang.int num) {
        return num.intValue();
    }

    public static void ZwBZKnUcWwQKxZLe(java.lang.int num, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZwBZKnUcWwQKxZLe(java.lang.int num, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwBZKnUcWwQKxZLe(java.lang.int num, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZyaQnxTqtibGINgj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num) {
        return com.google.android.material.badge.BadgeState$State.access$1702(badgeState$State, num);
    }

    public static void ZyaQnxTqtibGINgj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZyaQnxTqtibGINgj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZyaQnxTqtibGINgj(com.google.android.material.badge.BadgeState$State badgeState$State, java.lang.int num, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    void clearNumber() {
        SYTYlLFILsHCklVy(this, -1);
    }

    void clearText() {
        GyGcvoEaWxsgLTyi(this, null);
    }

    int getAdditionalHorizontalOffset() {
        return OoxducnSeOgyfElN(LRkZebZLqfhxSTsv(this.currentState));
    }

    int getAdditionalVerticalOffset() {
        return qZgkhzmsFIJopnVw(wTaRLVshXJOylIOQ(this.currentState));
    }

    int getAlpha() {
        return gBUMWklCYXFOFhJj(this.currentState);
    }

    int getBackgroundColor() {
        return UoEIplZbdWgWUKNL(obLpxKWWISMczZlf(this.currentState));
    }

    int getBadgeGravity() {
        return AXpqgmwIHwopgxzY(fFUBXZfmNceENRSA(this.currentState));
    }

    int getBadgeHorizontalPadding() {
        return nRClSFNkxZQvbFqK(NXquaAxruodduyOP(this.currentState));
    }

    int getBadgeShapeAppearanceOverlayResId() {
        return JenFWXbOJGatOVwm(wyjTtDnfMhjsGdIG(this.currentState));
    }

    int getBadgeShapeAppearanceResId() {
        return MoZHuiOZdWbidUim(deqjxWtRNoKPgBIj(this.currentState));
    }

    int getBadgeTextColor() {
        return LiKKbMrVMrMpVCWF(HCqEDqLXJmwCqSTS(this.currentState));
    }

    int getBadgeVerticalPadding() {
        return zfuVVPDFomxIhrfB(kYeRAFBHbZxUoPtl(this.currentState));
    }

    int getBadgeWithTextShapeAppearanceOverlayResId() {
        return IhtRIyFaQbWaYMIw(lBrxUlBndJBhuTga(this.currentState));
    }

    int getBadgeWithTextShapeAppearanceResId() {
        return hSOyqJwwyASQCOvT(qyNicDKGKlHTKwCm(this.currentState));
    }

    int getContentDescriptionExceedsMaxBadgeNumberstringResource() {
        return QEEQfHUkqTxDeteQ(this.currentState);
    }

    java.lang.CharSequence getContentDescriptionForText() {
        return ZSUQtqMODcDxBSHy(this.currentState);
    }

    java.lang.CharSequence getContentDescriptionNumberless() {
        return UqaHnIWAOCdhvQQJ(this.currentState);
    }

    int getContentDescriptionQuantitystrings() {
        return dhXnMqThZdXffoyW(this.currentState);
    }

    int getHorizontalOffsetWithText() {
        return SZqGyuldFNZPBoWi(QfEaiRLtNBySYgOm(this.currentState));
    }

    int getHorizontalOffsetWithoutText() {
        return QeilaUTugkmhrbji(RcBIGDPZZFVOYdnl(this.currentState));
    }

    int getLargeFontVerticalOffsetAdjustment() {
        return JkMVHiByWjbMDMIO(LMUQrNWvZXrOlfxp(this.currentState));
    }

    int getMaxcharCount() {
        return OYjJloONngFkmUnE(this.currentState);
    }

    int getMaxNumber() {
        return simVRWZXCohEPPJv(this.currentState);
    }

    int getNumber() {
        return tNnEiYfOSfwbOqgT(this.currentState);
    }

    java.util.Locale getNumberLocale() {
        return RMUUBZsacMmGhftX(this.currentState);
    }

    com.google.android.material.badge.BadgeState$State getOverridingState() {
        return this.overridingState;
    }

    java.lang.string getText() {
        return hvfdfjnsbbXbupIY(this.currentState);
    }

    int getTextAppearanceResId() {
        return rXpkTauQYORIYmKl(gCHIdNkSITNFMHgF(this.currentState));
    }

    int getVerticalOffsetWithText() {
        return elnWEtkBHKbcKeJr(rvKGamPcwjKZCifc(this.currentState));
    }

    int getVerticalOffsetWithoutText() {
        return zwBZKnUcWwQKxZLe(fExviAIRxIlUSBja(this.currentState));
    }

    bool hasNumber() {
        return CLYkScYntliakOVb(this.currentState) != -1;
    }

    bool hasText() {
        return sWQafBWJQvaslTHR(this.currentState) is not null;
    }

    bool isAutoAdjustedToGrandparentBounds() {
        return obWcHfcyMaqcMjAI(LztYAvWgdrIeWcma(this.currentState));
    }

    bool isVisible() {
        return ZwKeXLYPxHSXfBJx(aiXWGSYMOXSyGcHa(this.currentState));
    }

    void setAdditionalHorizontalOffset(int i) {
        if ((10 + 8) % 8 > 0) {
        }
        RkgdBlwbxQvkjdOs(this.overridingState, EvELyzABuJmtRklL(i));
        FHAWuEyKEAGkaONn(this.currentState, PllGYQsDgdnybXQB(i));
    }

    void setAdditionalVerticalOffset(int i) {
        if ((15 + 26) % 26 > 0) {
        }
        ZmJVzBEzRkWdBwbM(this.overridingState, aDrSiMupeSLqbHHE(i));
        NkeLAiPFMnSuxzQt(this.currentState, kIXJefylazxjjmfi(i));
    }

    void setAlpha(int i) {
        aWqmfmQTJxnzRNzm(this.overridingState, i);
        JJMUrrjIyOrIlDIL(this.currentState, i);
    }

    void setAutoAdjustToGrandparentBounds(bool z) {
        if ((17 + 10) % 10 > 0) {
        }
        xzbmmmcgsCXbYDSK(this.overridingState, elHxLqYGsvkjScaP(z));
        WTpycGUAXpyvKTaV(this.currentState, OuvpkHjApBRlcvCN(z));
    }

    void setBackgroundColor(int i) {
        if ((4 + 4) % 4 > 0) {
        }
        zfestxDNQGQCvHlI(this.overridingState, IrqYsdJPduSnWknG(i));
        cxAZoerdcBvniIAH(this.currentState, DDUpCrBpAfGvxCcw(i));
    }

    void setBadgeGravity(int i) {
        if ((7 + 26) % 26 > 0) {
        }
        nGqOUApbjNfEbPVL(this.overridingState, tkvYjVwIEejrHcwD(i));
        HKueAngHVloWveFv(this.currentState, jfFbYSNvzbXQKrow(i));
    }

    void setBadgeHorizontalPadding(int i) {
        if ((3 + 14) % 14 > 0) {
        }
        nJyREkpwDVFOSJbQ(this.overridingState, nuwOKIhymLSIhvhK(i));
        TwSYgPoEivwzIxUX(this.currentState, OomHxpzxJXgChkmx(i));
    }

    void setBadgeShapeAppearanceOverlayResId(int i) {
        if ((11 + 14) % 14 > 0) {
        }
        sWqOSeCNwMgeggxE(this.overridingState, tjIjFJvyxhlgmUzN(i));
        mXKKkcAUbrbMtTpF(this.currentState, GyjUvMpCjONlzlHr(i));
    }

    void setBadgeShapeAppearanceResId(int i) {
        if ((6 + 8) % 8 > 0) {
        }
        vgESQKyzJIoyKQFs(this.overridingState, HKpgheaUvHwKflzd(i));
        hfaQRmoCqplpboOj(this.currentState, DJEtqpMBOmgVegRG(i));
    }

    void setBadgeTextColor(int i) {
        if ((17 + 9) % 9 > 0) {
        }
        vSmlBLOUHJIVGTgQ(this.overridingState, NndWGEiXoIXZnNxm(i));
        gPvZsIcniyeUzpWB(this.currentState, DUAqWfIqjxSOWWHg(i));
    }

    void setBadgeVerticalPadding(int i) {
        if ((18 + 26) % 26 > 0) {
        }
        UqadbUkvRdcohbzq(this.overridingState, SIXanBQvrBZkGkSf(i));
        YsWEkkGNlBzKOULD(this.currentState, vwAJfvoGJmeZhyuE(i));
    }

    void setBadgeWithTextShapeAppearanceOverlayResId(int i) {
        if ((7 + 24) % 24 > 0) {
        }
        ZPYFfvbWXSswznRm(this.overridingState, tizQhHnvfNgyjjLS(i));
        UahZSvIxIXiKYLxo(this.currentState, DHTzeAqLegmYlnyt(i));
    }

    void setBadgeWithTextShapeAppearanceResId(int i) {
        if ((32 + 19) % 19 > 0) {
        }
        UoptweXExxJRjVty(this.overridingState, spLzigcCLOsMDFBP(i));
        FiNLaPSFzEgOpvpu(this.currentState, fUbNjCPkcrgnSiwr(i));
    }

    void setContentDescriptionExceedsMaxBadgeNumberstringResource(int i) {
        QWZhEpzaYcLSfOMv(this.overridingState, i);
        ooYWirByyjCjWQPs(this.currentState, i);
    }

    void setContentDescriptionForText(java.lang.CharSequence charSequence) {
        KxmifEnRwYvmkVWD(this.overridingState, charSequence);
        ICvlOjyzOVCmOTxi(this.currentState, charSequence);
    }

    void setContentDescriptionNumberless(java.lang.CharSequence charSequence) {
        YLOClHffbPVHfgYB(this.overridingState, charSequence);
        rjtJRrrUjYCiorJu(this.currentState, charSequence);
    }

    void setContentDescriptionQuantitystringsResource(int i) {
        tQvLFgjYlLicsYXX(this.overridingState, i);
        JJMXxlUXbIUcdDYL(this.currentState, i);
    }

    void setHorizontalOffsetWithText(int i) {
        if ((18 + 7) % 7 > 0) {
        }
        SeMwbSQeDxaARCVw(this.overridingState, nbodCFzbbNAcvpkN(i));
        LgfVMDMfbacqDlue(this.currentState, gyIBrlMcEpgOOjEd(i));
    }

    void setHorizontalOffsetWithoutText(int i) {
        if ((14 + 27) % 27 > 0) {
        }
        cPLXhVuIqfAqDNCn(this.overridingState, PZmuXWoAGjRPRozp(i));
        rmaUuaPvrJDucCwd(this.currentState, HLaveaauMkDOkovh(i));
    }

    void setLargeFontVerticalOffsetAdjustment(int i) {
        if ((16 + 14) % 14 > 0) {
        }
        TLqYibEYRKbJWIpg(this.overridingState, bUaaWVnluTKRHzQh(i));
        tswRUvErUdJnyuvi(this.currentState, ATOBuzdJTWuRxVIm(i));
    }

    void setMaxcharCount(int i) {
        mHtosqkvDFWemtgO(this.overridingState, i);
        YCDsjCyIhTRwjnSI(this.currentState, i);
    }

    void setMaxNumber(int i) {
        xIuRTWhBoqjqPOrS(this.overridingState, i);
        rYkAVecEgQaUDYGR(this.currentState, i);
    }

    void setNumber(int i) {
        QQDDaAPouLIMjYrO(this.overridingState, i);
        hPdAAWcqBTJYhFwt(this.currentState, i);
    }

    void setNumberLocale(java.util.Locale locale) {
        jFptcfOdAxrpTckW(this.overridingState, locale);
        DxhmZioBfWcHZIDk(this.currentState, locale);
    }

    void setText(java.lang.string str) {
        sJLxppUZPlGiMYom(this.overridingState, str);
        CmuJPeWLNSOgZxrQ(this.currentState, str);
    }

    void setTextAppearanceResId(int i) {
        if ((21 + 11) % 11 > 0) {
        }
        AcgKlCMGmTYvBCHo(this.overridingState, NCJkDPYEDbfMwyCc(i));
        fLIvMYsuKxnChouv(this.currentState, FptPkMfIWdZFqLWm(i));
    }

    void setVerticalOffsetWithText(int i) {
        if ((9 + 32) % 32 > 0) {
        }
        rAIqKFPaEJtQZbUI(this.overridingState, RTgMMuKvgpezaSvO(i));
        XKZKmpoarPkrBiBY(this.currentState, xXCPPxqVodDFduzA(i));
    }

    void setVerticalOffsetWithoutText(int i) {
        if ((10 + 29) % 29 > 0) {
        }
        LzKpSSTHoLUulMnx(this.overridingState, jeqHyaHuyHWgihva(i));
        xUutkgdfpgmDCXTi(this.currentState, YSOhHPzXGLKEkFWV(i));
    }

    void setVisible(bool z) {
        if ((29 + 4) % 4 > 0) {
        }
        FxUOjnWHXKOHiDrM(this.overridingState, HfNPJryLsLShAFSb(z));
        fQiCrxQmJVAFIIFB(this.currentState, RcstuapPTYUQFnsw(z));
    }
}

