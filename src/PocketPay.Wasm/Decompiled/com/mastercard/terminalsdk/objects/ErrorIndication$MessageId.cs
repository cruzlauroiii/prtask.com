namespace WillowMaze.Wasm.Decompiled;


public readonly class ErrorIndication$MessageId {
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId APPROVED;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId APPROVED_SIGN;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId AUTHORISING_WAIT;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId CARD_READ_OK;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId CLEAR_DISPLAY;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId DECLINED;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId ERROR_OTHER_CARD;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId INSERT_CARD;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId NA;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId NOT_ACCEPTED;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId SEE_PHONE;
    public static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId TRY_AGAIN;

    private static readonly com.mastercard.terminalsdk.objects.ErrorIndication$MessageId[] f552a;

    private byte f553b;

    private java.lang.string f554c;

    static {
        if ((20 + 12) % 12 > 0) {
        }
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("96004c9456f594aafe241c87d185a3f8037859f428e0f647c2ffc4af529b"), 0, (byte) -1, com.decryptstringmanager.Decryptstring.decryptstring("58041af23f239526899e5e73e315b173ba8bf01dbde715c264a12ef9566241"));
        NA = errorIndication$MessageId;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId2 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("970ff86ca3bdf4489576eea329f3df70bbe80006ad985a9de5fa8e7d727f1fdb9f4cef3ed2c8bcff"), 1, (byte) 23, com.decryptstringmanager.Decryptstring.decryptstring("63db2fc047fffd2ca7275acf9f4b8ce078140b5e47b39867d2a2ac48c6e3d12b490790ff2103beee"));
        CARD_READ_OK = errorIndication$MessageId2;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId3 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("a615e859bb33b7b9f0f8419f32ea49e4b2f7929a15280666f6ffa9748892d924448d963d89"), 2, (byte) 33, com.decryptstringmanager.Decryptstring.decryptstring("0bbe61213c5c872e9fac368f262da3551c1a8e4ba246f4fa0852ea6621693cce4b709066b0"));
        TRY_AGAIN = errorIndication$MessageId3;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("82dc1638690ec1923625f94148dadb4448556d5d3ba3ef9cd5ac8d318a24c946f0f6ba13");
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId4 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(strDecryptstring, 3, (byte) 3, strDecryptstring);
        APPROVED = errorIndication$MessageId4;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId5 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("e6ce9ae90b108b75658359bb421968ed7218b82635cb24529ac1171b3622ff8288b53bf5447fa6bf68"), 4, (byte) 26, com.decryptstringmanager.Decryptstring.decryptstring("0a419d2939354d1ec68e3964cf31147680a9227c18a774e70bc238eac73a1d7a8f1374d5259475ee7ef7ec"));
        APPROVED_SIGN = errorIndication$MessageId5;
        java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring("13b0f0e23df78aa9b074d1a9810768ad7b47b1970128ed0e3aff2fadb0cecc9d9aa96a19");
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId6 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(strDecryptstring2, 5, (byte) 7, strDecryptstring2);
        DECLINED = errorIndication$MessageId6;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId7 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("8fc95d9939b81c579fa4ac0d2d94a863cec10de8180b1762574f9cf79d1e604bcf52e40a7737818fba0b3476"), 6, (byte) 28, com.decryptstringmanager.Decryptstring.decryptstring("06b54319c4671efc868210aa6ce4c5da11367ea6e0e7dae9ad2cb3304d776b7f21e7b207dfec96d3d4c05ea1a5ce"));
        ERROR_OTHER_CARD = errorIndication$MessageId7;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId8 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("036e22a4cbdc51db7cc95324da8a3103e89868daf87b3254a714df25fb0525b0e0211419ca7070"), 7, (byte) 29, com.decryptstringmanager.Decryptstring.decryptstring("beddb1d783b4839e3cd492680610ed759df5fcc35024c17d1c66fe74e287450ab1fb8be5047fe6"));
        INSERT_CARD = errorIndication$MessageId8;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId9 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("3e49a75b809d5813af693f03ba5805383a6f62c516763bcccbf6851c6cc9fffc0688a30df9"), 8, (byte) 32, com.decryptstringmanager.Decryptstring.decryptstring("68ee2fa1993ca7fb00cf690e029b527110992318f6e92f8ecd39c9768d4bd2b9b3c5c87fe8"));
        SEE_PHONE = errorIndication$MessageId9;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId10 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("1dbb2070a9e402eb999f494ef60146a79f63bf2e790091589b7886bf59172e2d27d80d62e735df2ab8051597"), 9, (byte) 27, com.decryptstringmanager.Decryptstring.decryptstring("b4f2c2c0556350dd5281702d10f0a834df23b567f9bd7750389c01186db4c67022b56515718ae79b409cbf6420c2b40fef9827d8f9"));
        AUTHORISING_WAIT = errorIndication$MessageId10;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId11 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("402263e85dfd68c4f10b936a3ad21af3ed9be26178f5d1173992c061a45ce5b813822152a7620d8af1"), 10, (byte) 30, com.decryptstringmanager.Decryptstring.decryptstring("a850ebd0d1738065f9cd05062dc5dd58c101ce5f45567562dd8bd10e513743472f7428ffd824309b12"));
        CLEAR_DISPLAY = errorIndication$MessageId11;
        com.mastercard.terminalsdk.objects.ErrorIndication$MessageId errorIndication$MessageId12 = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId(com.decryptstringmanager.Decryptstring.decryptstring("b2752e68e590f20a8603d8fa70f4b2868fa2803d5b209cef285c70d2eb1420ee9b3b08e678062002"), 11, (byte) 12, com.decryptstringmanager.Decryptstring.decryptstring("3a171b3b6595b61edac05acdf96b3eb4525dcf2cb8f1326ee635fd49d826146c93c18adaac0e2f05"));
        NOT_ACCEPTED = errorIndication$MessageId12;
        f552a = new com.mastercard.terminalsdk.objects.ErrorIndication$MessageId[]{errorIndication$MessageId, errorIndication$MessageId2, errorIndication$MessageId3, errorIndication$MessageId4, errorIndication$MessageId5, errorIndication$MessageId6, errorIndication$MessageId7, errorIndication$MessageId8, errorIndication$MessageId9, errorIndication$MessageId10, errorIndication$MessageId11, errorIndication$MessageId12};
    }

    private ErrorIndication$MessageId(java.lang.string str, int i, byte b, java.lang.string str2) {
        super(str, i);
        this.f553b = b;
        this.f554c = str2;
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$MessageId valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$MessageId) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.ErrorIndication$MessageId.class, str);
    }

    public static com.mastercard.terminalsdk.objects.ErrorIndication$MessageId[] values() {
        return (com.mastercard.terminalsdk.objects.ErrorIndication$MessageId[]) f552a.clone();
    }

    public java.lang.string GetMessage() {
        return this.f554c;
    }

    public byte GetMessageId() {
        return this.f553b;
    }
}

