namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorIndication$L2_Error_Code {
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code CAM_FAILED;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code CARD_DATA_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code CARD_DATA_MISSING;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code EMPTY_CANDIDATE_LIST;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code IDS_DATA_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code IDS_NO_MATCHING_AC;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code IDS_READ_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code IDS_WRITE_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code MAGSTRIPE_NOT_SUPPORTED;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code MAX_LIMIT_EXCEEDED;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code NO_PPSE;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code OK;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code PARSING_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code PPSE_FAULT;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code STATUS_BYTES;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code TERMINAL_DATA_ERROR;

    private static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code[] f546c;

    private byte f547a;

    private java.lang.string f548d;

    static {
        if ((31 + 5) % 5 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("f7795c1439ba08f96438cfb632e0824e0a25ca1b43b6b4aa3064ac507a3c");
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(strDecryptstring, 0, (byte) 0, strDecryptstring);
        OK = errorIndication$L2_Error_Code;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code2 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("611555ab107953bf3a508fc821f51b4b5f07c0caf560d101424e7da721bd7ea7a33e43f505a3cdf632a611ef80"), 1, (byte) 1, com.decryptstringmanager.Decryptstring.decryptstring("3f7d6ca41574bbd7e861dae79a3d79ab57e9038fa1a329c92cc6bb4428053d3859342a564b51509e68ac2eb541"));
        CARD_DATA_MISSING = errorIndication$L2_Error_Code2;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code3 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("b00dc512751f888931aae3dc32127deecf1fa49e52c77aba34d292537a21b17a8b106dd912fa"), 2, (byte) 2, com.decryptstringmanager.Decryptstring.decryptstring("b402ce21c66c9affb2a176365de414c15804d026d413c308d9de9d094924f4a5e50c3ed56bfd"));
        CAM_FAILED = errorIndication$L2_Error_Code3;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code4 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("05586aece3706b651a94954311c2efa891551990c68d4d10f4ba6a26cd319fd7b0d4808552a40071"), 3, (byte) 3, com.decryptstringmanager.Decryptstring.decryptstring("63cadd3edfeafc5b975334418d0ede70d1f258ea5160fb89dd67bd4cf7ee6f36793cf74f9f8c6b10"));
        STATUS_BYTES = errorIndication$L2_Error_Code4;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code5 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("67eeca6951a12960c726e550335f7330e22ec8d10b90d4ce51591fe5c7f2f6b7f52e3d6fe421e0a824"), 4, (byte) 4, com.decryptstringmanager.Decryptstring.decryptstring("6c290860e5d48016dff78082eb46ef6f2ba49723a10abe8036f9c209977ccf550542d497bcb690109a"));
        PARSING_ERROR = errorIndication$L2_Error_Code5;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code6 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("a00d9b75c56282d504294be8634e8b694e1c6768a370e9c6271da8746ac4f44c7581437faff4f366260380c9668b"), 5, (byte) 5, com.decryptstringmanager.Decryptstring.decryptstring("80f00809996ecdd9fcae939236376d4fadc63ce0ff277f525159b6c2ff7dee90983060fbe2cc882b29df428ed23d"));
        MAX_LIMIT_EXCEEDED = errorIndication$L2_Error_Code6;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code7 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("299ba3c7499c139068a866f4c7982ff862fd7c24ad485149e3b3090b47d849679b1bbe602e38f89cb6b970"), 6, (byte) 6, com.decryptstringmanager.Decryptstring.decryptstring("58a9075753358f80efba9bb5fe4ec200f7b4c085c02d9d376c230934b0207770df60211b1ef11ba34f8e76"));
        CARD_DATA_ERROR = errorIndication$L2_Error_Code7;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code8 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("90e324ab7d118718564eecd700a8e9e4c5c089dd8f2b208a76897302b63034d318cd7686066b7b5b5b741e897a45c34ee8156f"), 7, (byte) 7, com.decryptstringmanager.Decryptstring.decryptstring("852d6f43613c249219f65dc8f68ef9db21c56fa15be9f1144e28026a956a1f7e94a115a7f1f12cbf85c1744e874f7be030482b"));
        MAGSTRIPE_NOT_SUPPORTED = errorIndication$L2_Error_Code8;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code9 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("587edd7685fa5e60029b73a31fb1bb1439940fc66b980f491b24870498bd664c2faecc"), 8, (byte) 8, com.decryptstringmanager.Decryptstring.decryptstring("aa40bec6a75c12d29ecb51e817e382f51ec4ff2bb04c14773d9b908258251137ea1344"));
        NO_PPSE = errorIndication$L2_Error_Code9;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code10 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("f5b92c1055ab5f9a93b68a7c1c246d9a91ca5fee65974c884f0067ad8b17f8d50eae63b7d3b5"), 9, (byte) 9, com.decryptstringmanager.Decryptstring.decryptstring("87b4969695abe70b752b25fd2838d44cce284fad355717208a713b2cdeed852f6154ce5a8fff"));
        PPSE_FAULT = errorIndication$L2_Error_Code10;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code11 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("830efc949d7457a6deb1e2057acb7690d9d2ab112a1ece7e894c269f8a0dcaf14763322b9a25a91a49c2d6546d2096c6"), 10, (byte) 10, com.decryptstringmanager.Decryptstring.decryptstring("71eddc55f67bc49e195c5a07ca4d264a22e9fcc4da68b3d8419fb2d2c7bd5df9158174390b6c2dc53955ea751da893a1"));
        EMPTY_CANDIDATE_LIST = errorIndication$L2_Error_Code11;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code12 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("c67e2f88f65f62b5a5bff3330173819c208c21f0ede666ab471670dc8af03aea229e959056f52366e3da"), 11, (byte) 11, com.decryptstringmanager.Decryptstring.decryptstring("2e5fd2950875ebf8ab770b05963b88f3a55322475973fd504b184068ee7006844c32de671e0adbb6461e"));
        IDS_READ_ERROR = errorIndication$L2_Error_Code12;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code13 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("8fce10fd21ab9953f8660cf59069a47585abc4d672e87cdbe6b7905de481fceab18df516eb013f268dc040"), 12, (byte) 12, com.decryptstringmanager.Decryptstring.decryptstring("1d6b146138a774e56ca9d38bea44de445818b0ece294bc0f4b2f4a5bed961c6a437c2f2375762e5077ce47"));
        IDS_WRITE_ERROR = errorIndication$L2_Error_Code13;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code14 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("9d69357e0580a932e2b11841f2aaa97b8796f3f464960fdc244ba2742599b03aff2f2a05b0172e12b2c9"), 13, (byte) 13, com.decryptstringmanager.Decryptstring.decryptstring("9654c898761c0fd5a136575298d965c2be5215c1dd36ce9be8565b6e9c17f7a10936a912e3cb0f2d5765"));
        IDS_DATA_ERROR = errorIndication$L2_Error_Code14;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code15 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("9efe7988f734d781e7e700d3d8f84299d6188ac10e9cf3ed45b9235302d761dd96d5ac2ed6e546bcd5d3ebd179b9"), 14, (byte) 14, com.decryptstringmanager.Decryptstring.decryptstring("306b3a7cb4aaf2485b2f49082176cea1b23d1d08e23ba33d7c99bbd090a9025ae9956b8f8f0a60a0ebfd5c2b24f6"));
        IDS_NO_MATCHING_AC = errorIndication$L2_Error_Code15;
        com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code errorIndication$L2_Error_Code16 = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("fffebb1b01f933e84ddca980bb89df91f76acf2fe5e47eb7838885485a12e69258c4ce69a235bb3ae1baa65db22f6a"), 15, (byte) 15, com.decryptstringmanager.Decryptstring.decryptstring("194e0644a97804e00d11968f0a00cb8c1177ca6d4413b7978c57b73c2fa4fced268033b879aea9ca9d214a45880fa9"));
        TERMINAL_DATA_ERROR = errorIndication$L2_Error_Code16;
        f546c = new com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code[]{errorIndication$L2_Error_Code, errorIndication$L2_Error_Code2, errorIndication$L2_Error_Code3, errorIndication$L2_Error_Code4, errorIndication$L2_Error_Code5, errorIndication$L2_Error_Code6, errorIndication$L2_Error_Code7, errorIndication$L2_Error_Code8, errorIndication$L2_Error_Code9, errorIndication$L2_Error_Code10, errorIndication$L2_Error_Code11, errorIndication$L2_Error_Code12, errorIndication$L2_Error_Code13, errorIndication$L2_Error_Code14, errorIndication$L2_Error_Code15, errorIndication$L2_Error_Code16};
    }

    private ErrorIndication$L2_Error_Code(java.lang.string str, int i, byte b, java.lang.string str2) {
        super(str, i);
        this.f547a = b;
        this.f548d = str2;
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code.class, str);
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code[] values() {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$L2_Error_Code[]) f546c.clone();
    }

    public byte GetL2ErrorCode() {
        return this.f547a;
    }

    public java.lang.string GetMessage() {
        return this.f548d;
    }
}

