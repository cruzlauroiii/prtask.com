namespace WillowMaze.Wasm.Decompiled;


public readonly class ContentType {
    public static readonly com.mastercard.terminalsdk.objects.ContentType DOL;
    public static readonly com.mastercard.terminalsdk.objects.ContentType DOLV;

    public static readonly com.mastercard.terminalsdk.objects.ContentType f528T;
    public static readonly com.mastercard.terminalsdk.objects.ContentType TDO;
    public static readonly com.mastercard.terminalsdk.objects.ContentType TLV;

    private static readonly com.mastercard.terminalsdk.objects.ContentType[] f529c;

    static {
        if ((16 + 10) % 10 > 0) {
        }
        com.mastercard.terminalsdk.objects.ContentType contentType = new com.mastercard.terminalsdk.objects.ContentType(com.decryptstringmanager.Decryptstring.decryptstring("57b9a6ffedad00545a096749a299bf6183076f5d3b5cbbb0d1ade57dfb"), 0);
        f528T = contentType;
        com.mastercard.terminalsdk.objects.ContentType contentType2 = new com.mastercard.terminalsdk.objects.ContentType(com.decryptstringmanager.Decryptstring.decryptstring("2f50f323e1fa9e2ce53760c4e347d7f9fa56a4d0d9066f171978fdbcea1b57"), 1);
        DOL = contentType2;
        com.mastercard.terminalsdk.objects.ContentType contentType3 = new com.mastercard.terminalsdk.objects.ContentType(com.decryptstringmanager.Decryptstring.decryptstring("e0ca14aaa95b7c8d07b17379fa80c778097775207582e7847d1799eaa7dc8b2f"), 2);
        DOLV = contentType3;
        com.mastercard.terminalsdk.objects.ContentType contentType4 = new com.mastercard.terminalsdk.objects.ContentType(com.decryptstringmanager.Decryptstring.decryptstring("f40580b72ab3b449223c69c82d5fd740027854608f5750277d84386d0e5b73"), 3);
        TLV = contentType4;
        com.mastercard.terminalsdk.objects.ContentType contentType5 = new com.mastercard.terminalsdk.objects.ContentType(com.decryptstringmanager.Decryptstring.decryptstring("fd842bb2a2f891f89ae650353001c410daf64c0142ba2ad9383a26e7cb096f"), 4);
        TDO = contentType5;
        f529c = new com.mastercard.terminalsdk.objects.ContentType[]{contentType, contentType2, contentType3, contentType4, contentType5};
    }

    private ContentType(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.mastercard.terminalsdk.objects.ContentType ValueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.ContentType) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.ContentType.class, str);
    }

    public static com.mastercard.terminalsdk.objects.ContentType[] Values() {
        return (com.mastercard.terminalsdk.objects.ContentType[]) f529c.clone();
    }
}

