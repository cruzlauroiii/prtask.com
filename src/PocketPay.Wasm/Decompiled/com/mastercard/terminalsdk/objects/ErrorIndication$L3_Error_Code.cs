namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorIndication$L3_Error_Code {
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code AMOUNT_NOT_PRESENT;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code OK;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code STOP;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code TIME_OUT;

    private static readonly com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code[] f549d;

    private java.lang.string f550b;

    private byte f551e;

    static {
        if ((8 + 3) % 3 > 0) {
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("74d212597ccd11e8a08bbb6c7dd96bc032b0f473d5cb4666cfb9f39e63e2");
        com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code errorIndication$L3_Error_Code = new com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code(strDecryptstring, 0, (byte) 0, strDecryptstring);
        OK = errorIndication$L3_Error_Code;
        com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code errorIndication$L3_Error_Code2 = new com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("f808c6d8a90b59e102d87dd0ac3ffeac0bedf954ee5c6b3279d16261307b9c22700c881a"), 1, (byte) 1, com.decryptstringmanager.Decryptstring.decryptstring("92568e882a3734c5db60099877b448242271b1bedb454ff87ccaccdf13caa420cc4ad090"));
        TIME_OUT = errorIndication$L3_Error_Code2;
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("31532d042a1b4edb3db3869307e99b0a134997ea50149baf26e7b1008a1cbf94");
        com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code errorIndication$L3_Error_Code3 = new com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code(strDecryptstring2, 2, (byte) 2, strDecryptstring2);
        STOP = errorIndication$L3_Error_Code3;
        com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code errorIndication$L3_Error_Code4 = new com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code(com.decryptstringmanager.Decryptstring.decryptstring("b405a5d0a37db65feff148b6670a5310b6cb48b6cabab27e0d89e1fe3996e362087b58cefd7c9b3422ba152f93a7"), 3, (byte) 3, com.decryptstringmanager.Decryptstring.decryptstring("6f62fa4eca7985e0c819463237015c599944405542ac9f255fbc69a01135593ee89d0ef47799e23a898e3224f60a"));
        AMOUNT_NOT_PRESENT = errorIndication$L3_Error_Code4;
        f549d = new com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code[]{errorIndication$L3_Error_Code, errorIndication$L3_Error_Code2, errorIndication$L3_Error_Code3, errorIndication$L3_Error_Code4};
    }

    private ErrorIndication$L3_Error_Code(java.lang.string str, int i, byte b, java.lang.string str2) {
        super(str, i);
        this.f551e = b;
        this.f550b = str2;
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code.class, str);
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code[] values() {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$L3_Error_Code[]) f549d.clone();
    }

    public byte GetL3ErrorCode() {
        return this.f551e;
    }

    public java.lang.string GetMessage() {
        return this.f550b;
    }
}

