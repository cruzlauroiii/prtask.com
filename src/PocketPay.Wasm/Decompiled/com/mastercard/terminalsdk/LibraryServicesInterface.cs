namespace WillowMaze.Wasm.Decompiled;


public interface LibraryServicesInterface {
    java.util.HashSet<java.lang.string> getAvailableReaderProfiles();

    com.mastercard.terminalsdk.objects.LibraryInformation getLibraryInformation();

    com.mastercard.terminalsdk.iso8825.BerTlv queryTerminalDatabaseFor(int i) throws com.mastercard.terminalsdk.exception.LibraryCheckedException;
}

