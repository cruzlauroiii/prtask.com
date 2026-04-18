namespace WillowMaze.Wasm.Decompiled;


public readonly class UserInterfaceData$UIRDStatus {
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus CARD_READ_SUCCESSFULLY;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus IDLE;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus NA;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus NOT_READY;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus PROCESSING;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus PROCESSING_ERROR;
    public static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus READY_TO_READ;

    private static readonly com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus[] f662c;

    private java.lang.string f663b;

    private int f664e;

    static {
        if ((7 + 27) % 27 > 0) {
        }
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(com.decryptstringmanager.Decryptstring.decryptstring("744e083275ebe8f90e07ab634296567d9b25df0fa9232580103d8f495aaaf43fea943ca028"), 0, 0, com.decryptstringmanager.Decryptstring.decryptstring("ebb02af2ae35ece00184515da6c4f192406e340c3e2ab81a15a975b3426f784f3967e84fcc"));
        NOT_READY = userInterfaceData$UIRDStatus;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("971c440867fb7e3e7c598e84c3f9de235b46ff026e4a02109c7f9605e2706e35");
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus2 = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(strDecryptstring, 1, 1, strDecryptstring);
        IDLE = userInterfaceData$UIRDStatus2;
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus3 = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(com.decryptstringmanager.Decryptstring.decryptstring("dbbd90ff7d0686c917e4a8facfb4ec3ed9ba357990d1c66c835b608ef8c1f93b972b48089f32984041"), 2, 2, com.decryptstringmanager.Decryptstring.decryptstring("94db2b47c17de0f72c775f34b608f8a45293f0d34596a7e72fcadfc695546fff141044735f04799b1b"));
        READY_TO_READ = userInterfaceData$UIRDStatus3;
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("92e15aa528d06ba6b4f0a37ec45c70812bcade5e783a4c3647e1681c11a94c2e3e5adc237eee");
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus4 = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(strDecryptstring2, 3, 3, strDecryptstring2);
        PROCESSING = userInterfaceData$UIRDStatus4;
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus5 = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(com.decryptstringmanager.Decryptstring.decryptstring("e7867718304659991f8c80bb243f1cf28e17dd9c22f221e6c19e8ae7e67a8f3deb86d1c3e11b3249df8493c0d267b563266a"), 4, 4, com.decryptstringmanager.Decryptstring.decryptstring("c5ab6bb157a41b7b30b898b79556faba0a6acc91ee9239458f9b5a2faeddeb7d96cb5370e6b1acc308bd5905dcfef4d78d2c"));
        CARD_READ_SUCCESSFULLY = userInterfaceData$UIRDStatus5;
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus6 = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(com.decryptstringmanager.Decryptstring.decryptstring("bda66460416562ab46b58c22df217d824279f6df269697c11287b7203e15bcf31aaa6bcd864e439b9b3bd6a6"), 5, 5, com.decryptstringmanager.Decryptstring.decryptstring("2b5587d79c2942d9823d1aa600872d129e2c7a3f1b0254461b528da2ffc12694ab484788f9d739b8d5c41a10"));
        PROCESSING_ERROR = userInterfaceData$UIRDStatus6;
        java.lang.string strDecryptstring3 = com.decryptstringmanager.Decryptstring.decryptstring("f1be320ee27ccfc033f79d03b303542b5bf2a637d30887293fb2ac0923cc");
        com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus userInterfaceData$UIRDStatus7 = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus(strDecryptstring3, 6, 255, strDecryptstring3);
        NA = userInterfaceData$UIRDStatus7;
        f662c = new com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus[]{userInterfaceData$UIRDStatus, userInterfaceData$UIRDStatus2, userInterfaceData$UIRDStatus3, userInterfaceData$UIRDStatus4, userInterfaceData$UIRDStatus5, userInterfaceData$UIRDStatus6, userInterfaceData$UIRDStatus7};
    }

    private UserInterfaceData$UIRDStatus(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f664e = i2;
        this.f663b = str2;
    }

    public static com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus.class, str);
    }

    public static com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus[] values() {
        return (com.mastercard.terminalsdk.objects.UserInterfaceData$UIRDStatus[]) f662c.clone();
    }

    public int GetUIRDStatus() {
        return this.f664e;
    }

    public java.lang.string GetValue() {
        return this.f663b;
    }
}

