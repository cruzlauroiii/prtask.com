using global::Android.App;
using global::Android.Content;
using global::Android.OS;
using WillowMaze.Wasm.Companion.Services;

namespace WillowMaze.Wasm.Companion.Platforms.Android;

[Activity(
    MainLauncher = true,
    ScreenOrientation = global::Android.Content.PM.ScreenOrientation.Portrait,
    Exported = true)]
public class MainActivity : Activity, global::Android.Nfc.NfcAdapter.IReaderCallback
{
    public static MainActivity? Instance { get; private set; }
    private global::Android.Nfc.NfcAdapter? Nfc;

    protected override void OnCreate(Bundle? SavedInstanceState)
    {
        base.OnCreate(SavedInstanceState);
        Instance = this;
        Nfc = global::Android.Nfc.NfcAdapter.GetDefaultAdapter(this);
        global::Android.Util.Log.Info("Companion", $"MainActivity created, NFC={Nfc != null}");
        var ServiceIntent = new Intent(this, typeof(CompanionService));
        StartForegroundService(ServiceIntent);
        FinishAndRemoveTask();
    }

    protected override void OnResume()
    {
        base.OnResume();
        Instance = this;
        if (Nfc != null)
        {
            var NfcExtras = new Bundle(); NfcExtras.PutInt(global::Android.Nfc.NfcAdapter.ExtraReaderPresenceCheckDelay, 2000); Nfc.EnableReaderMode(this, this, global::Android.Nfc.NfcReaderFlags.NfcA | global::Android.Nfc.NfcReaderFlags.NfcB | global::Android.Nfc.NfcReaderFlags.SkipNdefCheck, NfcExtras);
            global::Android.Util.Log.Info("Companion", "NFC reader mode enabled");
        }
    }

    protected override void OnPause()
    {
        base.OnPause();
        Nfc?.DisableReaderMode(this);
    }

    public void OnTagDiscovered(global::Android.Nfc.Tag? Tag)
    {
        if (Tag == null) return;
        global::Android.Util.Log.Info("Companion", "NFC tag discovered!");
        global::Android.Util.Log.Info("Companion", "Card detected — reading...");
        EmvCardReader.ReadCard(Tag);
        var Card = EmvCardReader.LastCard;
        if (Card != null)
        {
            global::Android.Util.Log.Info("Companion", "Card read: " + Card.MaskedPan + " " + Card.Network + " ARQC=" + Card.Arqc);
            CompanionService.SendCardData(Card);
            WillowMaze.Wasm.Companion.Platforms.Android.CardEmulationService.LoadCard(Card);
        }
        CompanionService.NotifyCardRead();
    }
}
