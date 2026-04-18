namespace WillowMaze.Wasm.Decompiled;


public interface VerificationMethodProvider {
    com.mastercard.terminalsdk.objects.Cvmobject getCurrentCardholderVerification(com.mastercard.terminalsdk.objects.CvmType cvmType);

    com.mastercard.terminalsdk.objects.Cvmobject getUpdatedCardHolderVerification(com.mastercard.terminalsdk.objects.CvmType cvmType);

    bool isPinEntryByPassed();

    bool isPinPadMalfunctioning();

    bool isSubsequentPinByPassed();
}

