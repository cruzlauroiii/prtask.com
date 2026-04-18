namespace WillowMaze.Wasm.Decompiled;


public readonly class ODAException$ERRORCODE {
    private static int BuildConfig = 0;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE CID_MISMATCH;
    private static int ContactlessConfiguration = 1;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE EXP_DATE_ERROR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE EXP_ISSUER_ID_ERROR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE GEN_PK_ERROR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_CDA_FORMAT;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_CERT_HASH_LENGTH;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_CERT_SERIAL_NUMBER;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_DDA_FORMAT;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_DDA_VERSION;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_DEVICE_RELAY_RESISTANCE;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_DIGEST;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_ENCRYPTION_RESULTS;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_FORMAT;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_HASH;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_HASH_INDICATOR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_HEADER_OR_TRAILER;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_HEADER_OR_TRAILER_OR_FORMAT;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_ICC_CERT_ENCRYPTION;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_ICC_PK_MOD_LEN;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_MAXTIME_FOR_PRR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_MINTIME_FOR_PRR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_ODA_ALGORITHM;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_PADDING;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_PK_ALGO_INDICATOR;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_SIGNATURE_DIGEST;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_TERMINAL_RELAY_RESISTANCE;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE INVALID_TRANSMISSION_TIME;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE MISSING_IN_PARAMS;
    public static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE PAN_VALIDATION_ERROR;
    private static int e1 = 0;
    private static readonly com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] getInstance;
    private static int getTerminalData = 1;

    static {
        if ((13 + 4) % 4 > 0) {
        }
        CID_MISMATCH = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(RcDxXXBQtCEPxCvN("97eb4764658542c97c93db26f7c284eca6c3f807d9e440999bb8a35c2645613d9f6d84af01d734ad"), 0);
        EXP_DATE_ERROR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(yKUbLZSIsJlBtCQu("32b86e355b5cf94601a63c0a1069ec3047f9f3bcf9ad042adfdce6c3fc4ae239931affe8952b63aca66d"), 1);
        EXP_ISSUER_ID_ERROR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(ftWTqNSNFSpuQlxM("0dbda93d67c777c60f8436ef3c7aa17f543be7c622bf465db67d31c1c59d24ed2b0d8ff2f4504633e900c4569a7bac"), 2);
        GEN_PK_ERROR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(EUsssfvIQDOcHtlc("da6e4cef77900c70e0cb9b3a03a76d485bc8528ff29d00ea67d599f59abc5dce3cd14925ae06417d"), 3);
        INVALID_CDA_FORMAT = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(hgMAeHSPgjbLzpJw("0d31b54d5de8dc8077626f2059bb737f12ec193e735378bb4684d0fb4f5f9c8c795e6a7446a00c05c524ba012dbf"), 4);
        INVALID_CERT_HASH_LENGTH = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(yIeLKQEsiFkzxrOy("7a88121fc2026f22827c4ffef5e291eb438d859a2308acb6902a4e83ebeedce4eb203be70d337f3c54cff247224b44ba9e19fff6"), 5);
        INVALID_CERT_SERIAL_NUMBER = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(OYMQGpzngKGNbvgZ("b40195532b7ae462c5f518925003437cd8dc2551801f80e169299800c1f40cc56db2ff695afb11c40007f7f43da2f9bcb288c38f0ebb"), 6);
        INVALID_DDA_FORMAT = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(uGElSqtlzGBshQDs("1515382551a8f958128f713161093c1201b7886bee00437614197ab078ea3857e15ab8fd4c2f8d60e4ef7e1269b9"), 7);
        INVALID_DDA_VERSION = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(hJYJzfyqyWjTlDtj("1e0ff1e60e87da1d967c7606435b871bb1cef355d69d218f1e9e26e1d469b6ae8c995be9f89baf3f5a68cf997db61d"), 8);
        INVALID_DEVICE_RELAY_RESISTANCE = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(nxpfhGAhDnALPAEg("b6c3f439b01c3072614edb6e5deedf98f0b406e5e50ecaa059fa748f007291f7c90e362d4ba5a4d0c54e89e3dc9f9caad0d298c2b412c78cbd6d95"), 9);
        INVALID_DIGEST = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(VsBytRBsHnZwXzjW("8f221cb6f2272dfa9e20d567765502cbb066735fe045f3fd611e41bd7ad9e3680f5a3f59511f051ab762"), 10);
        INVALID_ENCRYPTION_RESULTS = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(ROTkywqKOPygXgRS("05569959e63d96541575038c687d75b5e1abdf59e773b148279522f1ececf0f1cc93f711d0279ae4bc44e896688a8da7286b16190ad6"), 11);
        INVALID_FORMAT = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(auJZDdQpwXieaJHg("dd7bbf9aee250ee295868871f5b13d92ca8fb648e704a6d641008551a4ee3b894e246949dd2fe91ffb44"), 12);
        INVALID_HASH = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(lAekUHNXSijDHKNf("00568dff91a6b4b8f4138d7b8b6f062f8efff3eee5e1d7992c80a0a85a0a8b21cf106ff2602fce0f"), 13);
        INVALID_HASH_INDICATOR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(MVqVLMFSpcVHYiKX("52a987f4641d63535e1599073b590784f50bfda8555045ae263649dd887013ca764a68d532f9ae27550dac271ebcf0288e3d"), 14);
        INVALID_HEADER_OR_TRAILER = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(EPuRhJOwfdeBaNxE("cd94efb9a40fbd67aa4565f386707500be69d2c6f0c63b3a5125f753e27ccb965af68f5f8cd9e03e040de7592e6ec002ef79254d89"), 15);
        INVALID_HEADER_OR_TRAILER_OR_FORMAT = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(epibrHKELosmaUlK("5d9533226ab26c96cd4d98e369c29cc85c4dc6ee848678d7ce65c7f2916ed1ba041ff7992bdc7c7babe5b5b3311d2f8733fff272fc6ac0b184a05a2ca3ee91"), 16);
        INVALID_ICC_CERT_ENCRYPTION = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(hQkrlXqPuAPRvdEJ("94d2bee533c12ccf543a0647504b2348ba9f988f77bde7ba31973b9fcdff74ad0e7f9161bcd04b54de9c19b72bc3a5abc2fd8d55ba66a5"), 17);
        INVALID_ICC_PK_MOD_LEN = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(ztusQpmMrymUwgLH("64277c3f429864a6824578241a335da3f7cf3337a3c66abb80d6503aa16652816a67343a3b9573739986de8eb20e0502a27c"), 18);
        INVALID_MAXTIME_FOR_PRR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(fugyCVDRBguJBPWd("f0e94198ef4f364f2646dac3b5696bd5c405e1311256ff37f62a3068573bd4307b8804fbf2a328263338c2cedb8b82b9267734"), 19);
        INVALID_MINTIME_FOR_PRR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(raiPYdWctsZFGlkv("10970fc0f5618a979da7cfe0585ce786703bcb04b673993fb9c477d21bcf3cbc9b533cc679c30ead45db4acc82eba85dfdad0c"), 20);
        INVALID_ODA_ALGORITHM = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(wopOMoOaLscjtQkS("742d821de3e6f1ff6bb53390011a7b6dba19599ba7a15206b14d61ed49e90997f71f1408d08cee26e66a20a3c98ad0a586"), 21);
        INVALID_PADDING = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(tjUAqCgBkKPyphDT("5df55143c0492f8eefdf17cd5299d3d9189deef01fc31ae003fc303da51c9ec99f666b9fcd172a823aabc6"), 22);
        INVALID_PK_ALGO_INDICATOR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(niDQoMSotknvhgWB("39a207c5cb0524570660a4b77ffb5251b398651e563541285c4c1e38089cebcf0968d17a1fbf3d62b631e3d538eb2ed7e7f4d37af0"), 23);
        INVALID_SIGNATURE_DIGEST = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(gdFxbkeHYUPboDsI("4ed0a1e01bcba6b58dbfc954529e681c1255bb3d359f3805ae62c46fce99d7d429732830e1d367209a02cf9cbdbd4591f0af149c"), 24);
        INVALID_TERMINAL_RELAY_RESISTANCE = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(aLVRJmNlTKgoDVVs("83b9be4f235abcee3e54168b93d9abf33949d39379045cb39864e64518b9a74228ddd5601fcb503ba6562a9635e9f253078027b0821faff927613e0353"), 25);
        INVALID_TRANSMISSION_TIME = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(ekmqCBgqpFAPcEEH("8d0b9cf55696597da072e8072d23dc6aa3ae492c3009a5493aa45b8b32df63fe86b5e939982520b997a8bc406eefe6a5ab31395995"), 26);
        MISSING_IN_PARAMS = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(PdVZETIEANZJttgJ("b18dea4c6432eb5647270399ff6a3d8f69b8571c488d46faf180b7382523aba6b6d7cd5a05fc57152e6c71a20c"), 27);
        PAN_VALIDATION_ERROR = new com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE(UKRLnuCvhJLRozSS("703addeaaef658f920ac9fd7183a35bde3ea0c498e8751ce3c03164696db5d3afb07e83cba93c2c3dc1558a4d948a84e"), 28);
        getInstance = SyBskseuWWCKVrSE();
        int i = ContactlessConfiguration + 123;
        e1 = i % 128;
        if (i % 2 != 0) {
            nVTLvivEpTIvBRVS(null);
            throw null;
        }
    }

    private ODAException$ERRORCODE(java.lang.string str, int i) {
        super(str, i);
    }

    private static com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] ContactlessConfiguration() {
        if ((14 + 7) % 7 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 63;
        int i3 = i2 % 128;
        BuildConfig = i3;
        int i4 = i2 % 2;
        com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] oDAException$ERRORCODEArr = {CID_MISMATCH, EXP_DATE_ERROR, EXP_ISSUER_ID_ERROR, GEN_PK_ERROR, INVALID_CDA_FORMAT, INVALID_CERT_HASH_LENGTH, INVALID_CERT_SERIAL_NUMBER, INVALID_DDA_FORMAT, INVALID_DDA_VERSION, INVALID_DEVICE_RELAY_RESISTANCE, INVALID_DIGEST, INVALID_ENCRYPTION_RESULTS, INVALID_FORMAT, INVALID_HASH, INVALID_HASH_INDICATOR, INVALID_HEADER_OR_TRAILER, INVALID_HEADER_OR_TRAILER_OR_FORMAT, INVALID_ICC_CERT_ENCRYPTION, INVALID_ICC_PK_MOD_LEN, INVALID_MAXTIME_FOR_PRR, INVALID_MINTIME_FOR_PRR, INVALID_ODA_ALGORITHM, INVALID_PADDING, INVALID_PK_ALGO_INDICATOR, INVALID_SIGNATURE_DIGEST, INVALID_TERMINAL_RELAY_RESISTANCE, INVALID_TRANSMISSION_TIME, MISSING_IN_PARAMS, PAN_VALIDATION_ERROR};
        int i5 = i3 + 5;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return oDAException$ERRORCODEArr;
    }

    public static java.lang.string EPuRhJOwfdeBaNxE(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string EUsssfvIQDOcHtlc(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object GnHUJQXAaCCSRqMv(com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] oDAException$ERRORCODEArr) {
        return oDAException$ERRORCODEArr.clone();
    }

    public static java.lang.object JUjSXtBHhEradyot(com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] oDAException$ERRORCODEArr) {
        return oDAException$ERRORCODEArr.clone();
    }

    public static java.lang.string MVqVLMFSpcVHYiKX(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string OYMQGpzngKGNbvgZ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string PdVZETIEANZJttgJ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string ROTkywqKOPygXgRS(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string RcDxXXBQtCEPxCvN(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] SyBskseuWWCKVrSE() {
        return ContactlessConfiguration();
    }

    public static java.lang.string UKRLnuCvhJLRozSS(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string VsBytRBsHnZwXzjW(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string ALVRJmNlTKgoDVVs(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string AuJZDdQpwXieaJHg(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.Enum COHfTWpLQJacidfq(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string EkmqCBgqpFAPcEEH(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string EpibrHKELosmaUlK(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string FtWTqNSNFSpuQlxM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string FugyCVDRBguJBPWd(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string GdFxbkeHYUPboDsI(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string HJYJzfyqyWjTlDtj(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string HQkrlXqPuAPRvdEJ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string HgMAeHSPgjbLzpJw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string LAekUHNXSijDHKNf(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int NVTLvivEpTIvBRVS(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string NiDQoMSotknvhgWB(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string NxpfhGAhDnALPAEg(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string RaiPYdWctsZFGlkv(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string TjUAqCgBkKPyphDT(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UGElSqtlzGBshQDs(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE valueOf(java.lang.string str) {
        if ((27 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 101;
        BuildConfig = i2 % 128;
        int i3 = i2 % 2;
        com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE oDAException$ERRORCODE = (com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE) cOHfTWpLQJacidfq(com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE.class, str);
        if (i3 != 0) {
            throw null;
        }
        return oDAException$ERRORCODE;
    }

    public static com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] values() {
        com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[] oDAException$ERRORCODEArr;
        if ((30 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig + 115;
        getTerminalData = i2 % 128;
        if (i2 % 2 != 0) {
            oDAException$ERRORCODEArr = (com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[]) GnHUJQXAaCCSRqMv(getInstance);
        } else {
            oDAException$ERRORCODEArr = (com.visa.vac.tc.emvconverter.Exception.ODAException$ERRORCODE[]) JUjSXtBHhEradyot(getInstance);
            int i3 = 82 / 0;
        }
        int i4 = BuildConfig + 21;
        getTerminalData = i4 % 128;
        if (i4 % 2 == 0) {
            int i5 = 9 / 0;
        }
        return oDAException$ERRORCODEArr;
    }

    public static java.lang.string WopOMoOaLscjtQkS(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string YIeLKQEsiFkzxrOy(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string YKUbLZSIsJlBtCQu(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string ZtusQpmMrymUwgLH(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }
}

