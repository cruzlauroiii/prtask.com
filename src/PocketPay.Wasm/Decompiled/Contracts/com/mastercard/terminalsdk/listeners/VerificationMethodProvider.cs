namespace WillowMaze.Wasm.Decompiled;

public interface VerificationMethodProvider
{
    CvmObject GetCurrentCardholderVerification(CvmType P0);
    CvmObject GetUpdatedCardHolderVerification(CvmType P0);
    bool IsPinEntryByPassed();
    bool IsPinPadMalfunctioning();
    bool IsSubsequentPinByPassed();
}
