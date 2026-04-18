using System.Globalization;
using System.Text;

namespace PrTask.Transpiler;

public sealed class ArscParser
{
    private readonly byte[] Data;
    public Dictionary<int, string> StringResources { get; } = [];
    public Dictionary<int, string> DrawableNames { get; } = [];
    public Dictionary<int, string> IdNames { get; } = [];
    public string PackageName { get; private set; } = string.Empty;

    public ArscParser(byte[] Data) => this.Data = Data;

    public bool Parse()
    {
        if (Data.Length < 12 || R16(0) != 0x0002)
        {
            return false;
        }

        var GlobalPool = ParseStringPool(12);
        var GlobalPoolSize = R32(12 + 4);
        var PkgOffset = 12 + GlobalPoolSize;

        if (PkgOffset + 288 > Data.Length || R16(PkgOffset) != 0x0200)
        {
            return false;
        }

        PackageName = Encoding.Unicode.GetString(Data, PkgOffset + 12, 256).TrimEnd('\0');
        var PkgId = R32(PkgOffset + 8);
        var PkgHeaderSize = R16(PkgOffset + 2);
        var PkgSize = R32(PkgOffset + 4);

        var TypeStringsOff = R32(PkgOffset + 268);
        var KeyStringsOff = R32(PkgOffset + 276);

        var TypePool = ParseStringPool(PkgOffset + TypeStringsOff);
        var KeyPool = ParseStringPool(PkgOffset + KeyStringsOff);
        var KeyPoolSize = R32(PkgOffset + KeyStringsOff + 4);

        var Pos = PkgOffset + KeyStringsOff + KeyPoolSize;
        var End = PkgOffset + PkgSize;

        var CurrentTypeId = -1;

        while (Pos + 8 <= End && Pos + 8 <= Data.Length)
        {
            var ChunkType = R16(Pos);
            var ChunkHeaderSize = R16(Pos + 2);
            var ChunkSize = R32(Pos + 4);

            if (ChunkSize <= 0 || Pos + ChunkSize > Data.Length)
            {
                break;
            }

            if (ChunkType == 0x0202)
            {
                CurrentTypeId = Data[Pos + 8];
            }
            else if (ChunkType == 0x0201)
            {
                var TypeId = Data[Pos + 8];
                var EntryCount = R32(Pos + 12);
                var EntriesStart = R32(Pos + 16);

                var TypeName = (TypeId - 1) >= 0 && (TypeId - 1) < TypePool.Length
                    ? TypePool[TypeId - 1] : string.Empty;

                var OffsetTableStart = Pos + ChunkHeaderSize;

                for (var I = 0; I < EntryCount && I < 10000; I++)
                {
                    var EntryOffset = R32(OffsetTableStart + (I * 4));
                    if (EntryOffset == -1 || EntryOffset == unchecked((int)0xFFFFFFFF))
                    {
                        continue;
                    }

                    var EntryPos = Pos + EntriesStart + EntryOffset;
                    if (EntryPos + 8 > Data.Length)
                    {
                        continue;
                    }

                    var EntrySize = R16(EntryPos);
                    var EntryFlags = R16(EntryPos + 2);
                    var KeyIdx = R32(EntryPos + 4);
                    var KeyName = KeyIdx >= 0 && KeyIdx < KeyPool.Length ? KeyPool[KeyIdx] : string.Empty;

                    var ResId = (PkgId << 24) | (TypeId << 16) | I;

                    if ((EntryFlags & 0x0001) == 0 && EntryPos + 8 + 8 <= Data.Length)
                    {
                        var ValueSize = R16(EntryPos + 8);
                        var ValueType = Data[EntryPos + 11];
                        var ValueData = R32(EntryPos + 12);

                        if (TypeName == "string" && ValueType == 0x03 && ValueData >= 0 && ValueData < GlobalPool.Length)
                        {
                            StringResources[ResId] = GlobalPool[ValueData];
                        }
                        else if (TypeName == "drawable" || TypeName == "mipmap")
                        {
                            DrawableNames[ResId] = KeyName;
                        }
                        else if (TypeName == "id")
                        {
                            IdNames[ResId] = KeyName;
                        }
                        else if (TypeName == "color" || TypeName == "dimen" || TypeName == "style" || TypeName == "layout")
                        {
                            if (KeyName.Length > 0)
                            {
                                IdNames[ResId] = KeyName;
                            }
                        }
                    }
                    else
                    {
                        if (TypeName == "drawable" || TypeName == "mipmap")
                        {
                            DrawableNames[ResId] = KeyName;
                        }

                        if (TypeName == "id" || TypeName == "layout")
                        {
                            IdNames[ResId] = KeyName;
                        }
                    }
                }
            }

            Pos += ChunkSize;
        }

        return true;
    }

    public string ResolveResource(int ResId)
    {
        if (StringResources.TryGetValue(ResId, out var Str))
        {
            return Str;
        }

        if (DrawableNames.TryGetValue(ResId, out var Drawable))
        {
            return Drawable;
        }

        if (IdNames.TryGetValue(ResId, out var Id))
        {
            return Id;
        }

        return string.Format(CultureInfo.InvariantCulture, "0x{0:X8}", ResId);
    }

    private string[] ParseStringPool(int Offset)
    {
        if (Offset + 28 > Data.Length || R16(Offset) != 0x0001)
        {
            return [];
        }

        var StringCount = R32(Offset + 8);
        var Flags = R32(Offset + 16);
        var StringsStart = R32(Offset + 20);
        var IsUtf8 = (Flags & (1 << 8)) != 0;
        var Pool = new string[StringCount];

        for (var I = 0; I < StringCount; I++)
        {
            var StrOff = R32(Offset + 28 + (I * 4));
            var AbsOff = Offset + StringsStart + StrOff;

            if (AbsOff >= Data.Length)
            {
                Pool[I] = string.Empty;
                continue;
            }

            try
            {
                if (IsUtf8)
                {
                    var P = AbsOff;
                    if (P >= Data.Length) { Pool[I] = string.Empty; continue; }
                    var CharLen = Data[P++];
                    if ((CharLen & 0x80) != 0 && P < Data.Length) P++;
                    if (P >= Data.Length) { Pool[I] = string.Empty; continue; }
                    var ByteLen = (int)Data[P++];
                    if ((ByteLen & 0x80) != 0 && P < Data.Length) ByteLen = ((ByteLen & 0x7F) << 8) | Data[P++];
                    if (P + ByteLen > Data.Length) ByteLen = Data.Length - P;
                    Pool[I] = Encoding.UTF8.GetString(Data, P, ByteLen);
                }
                else
                {
                    var Len = R16(AbsOff);
                    if ((Len & 0x8000) != 0) { Len = ((Len & 0x7FFF) << 16) | R16(AbsOff + 2); AbsOff += 4; } else { AbsOff += 2; }
                    var ByteLen = Math.Min(Len * 2, Data.Length - AbsOff);
                    Pool[I] = Encoding.Unicode.GetString(Data, AbsOff, ByteLen);
                }
            }
            catch
            {
                Pool[I] = string.Empty;
            }
        }

        return Pool;
    }

    private int R16(int Off) => Off + 1 < Data.Length ? BitConverter.ToUInt16(Data, Off) : 0;
    private int R32(int Off) => Off + 3 < Data.Length ? BitConverter.ToInt32(Data, Off) : 0;
}
