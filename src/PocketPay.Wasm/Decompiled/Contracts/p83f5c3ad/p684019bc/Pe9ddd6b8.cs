namespace WillowMaze.Wasm.Decompiled;

public interface Pe9ddd6b8
{
    bool CheckActivated();
    object ConfirmRegWithOtp(string P0, object P1);
    SharedFlow GetActivationSms();
    object InitActivation(p4536d9ae P0, object P1);
    object InitActivationWithToken(string P0, object P1);
    bool IsActivatedCache();
}
