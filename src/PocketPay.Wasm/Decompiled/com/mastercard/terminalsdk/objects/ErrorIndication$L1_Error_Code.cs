namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorIndication$L1_Error_Code {
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code OK;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code PROTOCOL_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code TIMEOUT_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code TRANSMISSION_ERROR;

    private static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code[] f543a;

    private byte f544b;

    private java.lang.string f545c;

    static {
        if ((12 + 5) % 5 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("65d3137de6be1dc492094858f5f0baa5422381771bc5f3f505f15f589d95");
        com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code = new com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code(strDecryptstring, 0, (byte) 0, strDecryptstring);
        OK = errorIndication$L1_Error_Code;
        com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code2 = new com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("540ff4a6951d7bdc62a5840097d07312c3f3368855dc40d59bf79ad6e7ee595b69232509a304bbede5"), 1, (byte) 1, com.decryptstringmanager.Decryptstring.decryptstring("31c8a2b122555d0de38e3f2117e68a463933354834222be41f03bcd0c0239eb186d4abef513e3b729e76"));
        TIMEOUT_ERROR = errorIndication$L1_Error_Code2;
        com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code3 = new com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("0de88425a75271a6fee20c1dcc8d045231b05e4978713ef488aa04d525b7e873549b319e550394260941c06b34b9"), 2, (byte) 2, com.decryptstringmanager.Decryptstring.decryptstring("25eef71fd855ffc0c5c75578ed0eb13571e4bfa613799a61432199bc2f356c81d943645323aeff052e77ec7c256d"));
        TRANSMISSION_ERROR = errorIndication$L1_Error_Code3;
        com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code errorIndication$L1_Error_Code4 = new com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("b1d7add1601f51358f112c6703134cf4abb879598db96203b15056404f9ef934e99714c0a799832c7b50"), 3, (byte) 3, com.decryptstringmanager.Decryptstring.decryptstring("8fdd6d247071d6726b65767e7390e98e44028a5ac13eafcb536b7ad2516242bb5faea7e9c5269fdd6bd0"));
        PROTOCOL_ERROR = errorIndication$L1_Error_Code4;
        f543a = new com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code[]{errorIndication$L1_Error_Code, errorIndication$L1_Error_Code2, errorIndication$L1_Error_Code3, errorIndication$L1_Error_Code4};
    }

    private ErrorIndication$L1_Error_Code(java.lang.string str, int i, byte b, java.lang.string str2) {
        super(str, i);
        this.f544b = b;
        this.f545c = str2;
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code.class, str);
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code[] values() {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$L1_Error_Code[]) f543a.clone();
    }

    public byte GetL1ErrorCode() {
        return this.f544b;
    }

    public java.lang.string GetMessage() {
        return this.f545c;
    }
}

