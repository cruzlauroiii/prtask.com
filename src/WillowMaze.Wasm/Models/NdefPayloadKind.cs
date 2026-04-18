using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WillowMaze.Wasm.Models;

public enum NdefPayloadKind
{
    Text = 0,
    Uri = 1,
    Mime = 2,
    External = 3,
    Aar = 4,
    SmartPoster = 5,
    Handover = 6,
}
