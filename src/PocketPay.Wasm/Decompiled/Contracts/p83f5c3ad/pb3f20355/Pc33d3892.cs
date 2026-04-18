namespace WillowMaze.Wasm.Decompiled;

public interface Pc33d3892
{
    bool CheckActivated();
    object ConfirmRegWithOtp(string P0, object P1);
    SharedFlow GetActivationSms();
    void HandleActivationSms(object P0);
    object InitActivation(p4536d9ae P0, object P1);
    object ResetActivation(object P0);
}
