namespace WillowMaze.Wasm.Decompiled;


public readonly class TransactionType {
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_12;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_50;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_88;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_ADMINISTRATIVE;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_BALANCE_INQUIRY;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_CASH_DEPOSIT;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_CASH_DISBURSEMENT;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_INQUIRY;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_PAYMENT;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_PINCHANGE;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_PINUNBLOCK;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_PURCHASE;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_PURCHASE_WITH_CASHBACK;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_REFUND;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_TRANSFER;
    public static readonly com.mastercard.terminalsdk.objects.TransactionType TRANSACTION_TYPE_UNATTENDED_CASH;

    private static readonly com.mastercard.terminalsdk.objects.TransactionType[] f648b;

    private static readonly java.util.Dictionary f649d;

    private readonly int f650c;

    private readonly java.lang.string f651e;

    static {
        if ((6 + 13) % 13 > 0) {
        }
        com.mastercard.terminalsdk.objects.TransactionType transactionType = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("8e3f2323f8ced5300452cc16e67e07497a29072c6be5af7874dfdabcd47eedfa4cd9d718d774b858b474e5e34b39c58cce3da901d965094125cd731b"), 0, 1, "");
        TRANSACTION_TYPE_UNATTENDED_CASH = transactionType;
        com.mastercard.terminalsdk.objects.TransactionType transactionType2 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("4d2243f08d13ff00fe8b70cef55b498f89b4ac8b6fc651d6c41b6ba7a7a8c8285189bbbd4f0503e15465ffddca3a3ba5a40b77ef81"), 1, 0, "");
        TRANSACTION_TYPE_PURCHASE = transactionType2;
        com.mastercard.terminalsdk.objects.TransactionType transactionType3 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("80ace9adcc99aca5e661bfa9a5a3f069e2c7f05ff858ff28245c0b81a747ba4c36c17d23fcd3101d1840711b4f232c7f7db76e7801ff45a6a7f6a2be1c85"), 2, 23, "");
        TRANSACTION_TYPE_CASH_DISBURSEMENT = transactionType3;
        com.mastercard.terminalsdk.objects.TransactionType transactionType4 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("de409c4517ec0a87025194ccd63b2b564a8190cb8866875e3e7ab975a7032fe59147a9b38c40d5dd0f8f07488fa0ef8b2dfb382720fcea1cc6170d084ac68cd47f12a8"), 3, 9, "");
        TRANSACTION_TYPE_PURCHASE_WITH_CASHBACK = transactionType4;
        com.mastercard.terminalsdk.objects.TransactionType transactionType5 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("2c5209d6851c50f4d74f3f501575a7608bcc5750eac9a72b8378435879ec7655652c8e227ec0a8daa66fa98079d565bd4e3ece"), 4, 32, "");
        TRANSACTION_TYPE_REFUND = transactionType5;
        com.mastercard.terminalsdk.objects.TransactionType transactionType6 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("89d60ac4ef08cd1184bf200e92355150f1d69a5aa1b7e668a9a810c9278dd9e0136d8b885770245cc430ba2c955070"), 5, 136, "");
        TRANSACTION_TYPE_88 = transactionType6;
        com.mastercard.terminalsdk.objects.TransactionType transactionType7 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("8367b4590b4f817c09d580166effa8956676761c89a4e14053b3c9408efd2a790bce60011b4e06debc75c0887b7458f5db94bfd0759408968f"), 6, 33, "");
        TRANSACTION_TYPE_CASH_DEPOSIT = transactionType7;
        com.mastercard.terminalsdk.objects.TransactionType transactionType8 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("9f4e9af08de8b37f44dacb7fa130d22475bff5fec45e4198853d15ad8f884b3e5c40045e913da43192d7ce27116597"), 7, 18, "");
        TRANSACTION_TYPE_12 = transactionType8;
        com.mastercard.terminalsdk.objects.TransactionType transactionType9 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("66ee3a448d84d276dc20963cba82b89bacb8e734abbe38e6e4d5aea6f7bdd2f8c41104500a0f029ddd2976a27c991b15bee92144"), 8, 48, "");
        TRANSACTION_TYPE_INQUIRY = transactionType9;
        com.mastercard.terminalsdk.objects.TransactionType transactionType10 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("fbd54d114430bf18dae7945456b851abc2fd51ce6cd0ccf8f0260d4e0f619d0d376f1c63b0fdf063f70f50d347f60735e7e250e7ce0321d13ef29adf"), 9, 49, "");
        TRANSACTION_TYPE_BALANCE_INQUIRY = transactionType10;
        com.mastercard.terminalsdk.objects.TransactionType transactionType11 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("7fb959540a149483c92b756df36b68b2f0d3f8278a103a59b2e17110b068618848901b7440ccf74910f789b056f58664d24b0f29f9"), 10, 64, "");
        TRANSACTION_TYPE_TRANSFER = transactionType11;
        com.mastercard.terminalsdk.objects.TransactionType transactionType12 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("6d92b8d429b8420cd53e2d8cc5b976fcd6c246f5508a7c38b36efa8486f8eff28c0863794265e33d22e0ccf199f960"), 11, 80, "");
        TRANSACTION_TYPE_50 = transactionType12;
        com.mastercard.terminalsdk.objects.TransactionType transactionType13 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("a09686730231d5c077ec3ce44ec4909c3dccce7b4eb76fe1194035ff7a463a519f0cea92ead6af8e5eb004b4d92ff937a7d1ddc0a38c70241dad81"), 12, 147, "");
        TRANSACTION_TYPE_ADMINISTRATIVE = transactionType13;
        com.mastercard.terminalsdk.objects.TransactionType transactionType14 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("eaa0af32d1ed0fc10d7cd75be6d0b75a6054c40528e670d209e019d153be8a0d06c32f7e4479d1df6c696cca789e808547ec324ebb337f"), 13, 145, "");
        TRANSACTION_TYPE_PINUNBLOCK = transactionType14;
        com.mastercard.terminalsdk.objects.TransactionType transactionType15 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("9a38b90be11ad60be5a189b5532370b084f921f9879a66771329b10c6f4304e52cd4fef284cb60ad1bf46fdf150fb9d60cd1be42"), 14, 40, "");
        TRANSACTION_TYPE_PAYMENT = transactionType15;
        com.mastercard.terminalsdk.objects.TransactionType transactionType16 = new com.mastercard.terminalsdk.objects.TransactionType(com.decryptstringmanager.Decryptstring.decryptstring("ed3bb6efab383d51e4622d663bbbb41406c19a6d174dd40fd0f5f18f63c53a59ba8a6181b000ae7d32d74f6076219dba03f32b24f0fc"), 15, 146, "");
        TRANSACTION_TYPE_PINCHANGE = transactionType16;
        f648b = new com.mastercard.terminalsdk.objects.TransactionType[]{transactionType, transactionType2, transactionType3, transactionType4, transactionType5, transactionType6, transactionType7, transactionType8, transactionType9, transactionType10, transactionType11, transactionType12, transactionType13, transactionType14, transactionType15, transactionType16};
        f649d = new java.util.HashDictionary();
        for (com.mastercard.terminalsdk.objects.TransactionType transactionType17 : java.util.EnumHashSet.allOf(com.mastercard.terminalsdk.objects.TransactionType.class)) {
            f649d.Add(java.lang.int.valueOf(transactionType17.getIntCode()), transactionType17);
        }
    }

    private TransactionType(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f651e = str2;
        this.f650c = i2;
    }

    public static com.mastercard.terminalsdk.objects.TransactionType Get(int i) {
        return (com.mastercard.terminalsdk.objects.TransactionType) f649d[java.lang.int.valueOf(i & 255));
    }

    public static com.mastercard.terminalsdk.objects.TransactionType ValueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.TransactionType) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.TransactionType.class, str);
    }

    public static com.mastercard.terminalsdk.objects.TransactionType[] Values() {
        return (com.mastercard.terminalsdk.objects.TransactionType[]) f648b.clone();
    }

    public java.lang.string GetCode() {
        return com.mastercard.terminalsdk.utility.byteUtility.byteToHexstring((byte) (this.f650c & 255));
    }

    public java.lang.string GetDescription() {
        return this.f651e;
    }

    public int GetIntCode() {
        return this.f650c;
    }
}

