namespace WillowMaze.Wasm.Decompiled;

public interface Pd5ae94bc
{
    Completable CreatePinSession(string P0);
    pff835616 GetApiMode();
    Completable Initialize();
    bool IsAttestationTimeExpired();
    Completable Reset(Exception P0);
    Completable ResetToActivatedMode();
    void StartPinSession();
    void StopPinSession();
    Completable ToActivatedMode();
    Completable ToAttestedMode(p77b6e797 P0);
    Completable ToCreateAttestationMode(pdf743a5e P0);
    Completable ToRequestActivationMode(pae5c58d3 P0);
}
