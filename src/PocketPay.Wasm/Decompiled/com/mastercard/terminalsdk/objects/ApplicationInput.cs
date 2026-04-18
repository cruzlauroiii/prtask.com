namespace WillowMaze.Wasm.Decompiled;


public interface ApplicationInput {
    java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> additionalTlvs();

    bool continueWithTransaction();

    byte[] tagsToRead();

    java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> tlvsToWriteAfterGenAC();

    java.util.List<com.mastercard.terminalsdk.iso8825.BerTlv> tlvsToWriteBeforeGenAC();
}

