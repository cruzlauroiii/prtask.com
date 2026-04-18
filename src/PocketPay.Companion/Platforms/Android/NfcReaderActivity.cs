using Android.App;
using Android.Content;
using Android.Nfc;
using Android.OS;

namespace PocketPay.Companion.Platforms.Android;

[Activity(
    Theme = "@android:style/Theme.Translucent.NoTitleBar",
    Exported = true)]
[IntentFilter(["android.nfc.action.TECH_DISCOVERED"])]
[MetaData("android.nfc.action.TECH_DISCOVERED", Resource = "@xml/nfc_tech_filter")]
public class NfcReaderActivity : Activity, NfcAdapter.IReaderCallback
{
    protected override void OnCreate(Bundle? SavedInstanceState)
    {
        base.OnCreate(SavedInstanceState);
        global::Android.Util.Log.Info("Companion", "NfcReaderActivity created");
    }

    protected override void OnResume()
    {
        base.OnResume();
        var Nfc = NfcAdapter.GetDefaultAdapter(this);
        if (Nfc == null)
        {
            global::Android.Util.Log.Error("Companion", "NFC not available");
            FinishAndRemoveTask();
            return;
        }

        global::Android.Util.Log.Info("Companion", "NFC reader mode enabled — tap card now");
        Nfc.EnableReaderMode(this, this,
            NfcReaderFlags.NfcA | NfcReaderFlags.NfcB | NfcReaderFlags.SkipNdefCheck,
            null);
    }

    protected override void OnPause()
    {
        base.OnPause();
        NfcAdapter.GetDefaultAdapter(this)?.DisableReaderMode(this);
    }

    public void OnTagDiscovered(Tag? Tag)
    {
        if (Tag == null) return;
        global::Android.Util.Log.Info("Companion", "NFC tag discovered");

        var Card = Services.EmvCardReader.ReadCard(Tag);
        if (Card != null)
        {
            global::Android.Util.Log.Info("Companion", $"Card: {Card.MaskedPan} {Card.Network} {Card.Expiry}");
        }
        else
        {
            global::Android.Util.Log.Info("Companion", "NFC: Failed to read card");
        }

        RunOnUiThread(FinishAndRemoveTask);
    }
}
