namespace WillowMaze.Wasm.Decompiled;


public interface CardCommunicationProvider {
    bool connectReader() throws com.mastercard.terminalsdk.exception.L1RSPException;

    bool disconnectReader();

    java.lang.string getDescription();

    long getPreviousCommandExecutionTime();

    bool isCardPresent();

    bool isReaderConnected();

    bool removeCard();

    byte[] sendReceive(byte[] bArr) throws com.mastercard.terminalsdk.exception.L1RSPException;

    com.mastercard.terminalsdk.listeners.CardCommunicationProvider$Connectionobject waitForCard() throws com.mastercard.terminalsdk.exception.L1RSPException;
}

