namespace WillowMaze.Wasm.Decompiled;


public readonly class OutcomeParameterHashSet$Status {
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status APPROVED;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status DECLINED;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status END_APPLICATION;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status NA;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status ONLINE_REQUEST;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status SELECT_NEXT;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status TRY_AGAIN;
    public static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status TRY_ANOTHER_INTERFACE;

    private static readonly com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status[] f608c;

    private readonly java.lang.string f609b;

    private readonly int f610d;

    static {
        if ((31 + 24) % 24 > 0) {
        }
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("14e3724f0d172f40ddf21f703ae8d7c68f326cf99eede024bf1d401e236fd8471d2a3b54"), 0, 16, "");
        APPROVED = outcomeParameterHashSet$Status;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status2 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("e5d4fe09bf10b71be7dc6213a6ffee3f49a442c6ae8db99621ae34be0c675c082329c808"), 1, 32, "");
        DECLINED = outcomeParameterHashSet$Status2;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status3 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("a36d70528df787acbbd0cc05f89a992c033e94417b74a2b509aa8ce4c9fd6a63e90478804712e6ed6e9f"), 2, 48, "");
        ONLINE_REQUEST = outcomeParameterHashSet$Status3;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status4 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("8a6cebc3f8632a14b618dd824d383717e205e9b3bd9dd87f93a76410536ed62a837fda7821504ac565a0d5"), 3, 64, "");
        END_APPLICATION = outcomeParameterHashSet$Status4;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status5 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("89b53300aaf87aa994156bf90ec567e97ebf22b76cdc89764eff0c62f58a8ef12438dfb9692c3d"), 4, 80, "");
        SELECT_NEXT = outcomeParameterHashSet$Status5;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status6 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("a47055b622e781ec89fc487671aece94e3a49a03328c06d177a981fa486bf7170674e1bc82ef908539b14d591220dad051"), 5, 96, "");
        TRY_ANOTHER_INTERFACE = outcomeParameterHashSet$Status6;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status7 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("fc884aefb525bd5ff82a046dbbaf16256cf5394503980e82a70c474deb808c5596143b9e1a"), 6, 112, "");
        TRY_AGAIN = outcomeParameterHashSet$Status7;
        com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status outcomeParameterHashSet$Status8 = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status(com.decryptstringmanager.Decryptstring.decryptstring("7d0ba8bdf3f0ee4e52e60d0d3e77817f09fcdfa65f6667349b8669b9666f"), 7, 240, "");
        NA = outcomeParameterHashSet$Status8;
        f608c = new com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status[]{outcomeParameterHashSet$Status, outcomeParameterHashSet$Status2, outcomeParameterHashSet$Status3, outcomeParameterHashSet$Status4, outcomeParameterHashSet$Status5, outcomeParameterHashSet$Status6, outcomeParameterHashSet$Status7, outcomeParameterHashSet$Status8};
    }

    private OutcomeParameterHashSet$Status(java.lang.string str, int i, int i2, java.lang.string str2) {
        super(str, i);
        this.f610d = i2;
        this.f609b = str2;
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status) java.lang.Enum.valueOf(com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status.class, str);
    }

    public static com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status[] values() {
        return (com.mastercard.terminalsdk.objects.OutcomeParameterHashSet$Status[]) f608c.clone();
    }

    public java.lang.string GetMessage() {
        return this.f609b;
    }

    public int GetStatus() {
        return this.f610d;
    }
}

