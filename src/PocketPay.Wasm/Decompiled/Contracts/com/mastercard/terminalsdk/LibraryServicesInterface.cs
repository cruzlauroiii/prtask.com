namespace WillowMaze.Wasm.Decompiled;

public interface LibraryServicesInterface
{
    HashSet<object> GetAvailableReaderProfiles();
    LibraryInformation GetLibraryInformation();
    BerTlv QueryTerminalDatabaseFor(int P0);
}
