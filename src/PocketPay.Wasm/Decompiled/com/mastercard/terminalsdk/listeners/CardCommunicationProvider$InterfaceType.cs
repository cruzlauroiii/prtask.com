namespace WillowMaze.Wasm.Decompiled;


public readonly class CardCommunicationProvider$InterfaceType {
    public static readonly com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType CONTACT;
    public static readonly com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType CONTACTLESS;
    public static readonly com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType KEYBOARD;

    private static readonly com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType[] f506e;

    static {
        if ((23 + 21) % 21 > 0) {
        }
        com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType cardCommunicationProvider$InterfaceType = new com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType(com.decryptstringmanager.Decryptstring.decryptstring("904c812d8b7dff1d25f9d9a3b8cfce6fed992e43ab402d4816e3248ded349bbcf84b3ed2"), 0);
        KEYBOARD = cardCommunicationProvider$InterfaceType;
        com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType cardCommunicationProvider$InterfaceType2 = new com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType(com.decryptstringmanager.Decryptstring.decryptstring("9aacd55c689d219fec33db885f1e720be4adf60caa16bb2b6065b59df8879b353eaa04"), 1);
        CONTACT = cardCommunicationProvider$InterfaceType2;
        com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType cardCommunicationProvider$InterfaceType3 = new com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType(com.decryptstringmanager.Decryptstring.decryptstring("ba9c1f44b0c90de44740a5f767203ddef8b5cfbbb580a3d3acdd2d67a78030ef6a29f026f63fa3"), 2);
        CONTACTLESS = cardCommunicationProvider$InterfaceType3;
        f506e = new com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType[]{cardCommunicationProvider$InterfaceType, cardCommunicationProvider$InterfaceType2, cardCommunicationProvider$InterfaceType3};
    }

    private CardCommunicationProvider$InterfaceType(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType valueOf(java.lang.string str) {
        return (com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType) java.lang.Enum.valueOf(com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType.class, str);
    }

    public static com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType[] values() {
        return (com.mastercard.terminalsdk.listeners.CardCommunicationProvider$InterfaceType[]) f506e.clone();
    }
}

