using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;
using PrTask.Application.Services;
using PrTask.Domain.Constants;
using PrTask.Domain.Models;

namespace PrTask.Transpiler;

public sealed class BunExtractor : IBunExtractor
{
    public ExtractedBundle ExtractBundle(string ExePath)
    {
        using var Stream = File.OpenRead(ExePath);
        using var PeReader = new PEReader(Stream);

        var SectionHeader = FindBunSection(PeReader);
        var SectionData = ReadSectionData(Stream, SectionHeader);

        var PayloadLength = BitConverter.ToUInt64(SectionData, 0);
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.PayloadLengthFormat, PayloadLength));
        Console.WriteLine(string.Format(CultureInfo.InvariantCulture, BunConstants.SectionRawSizeFormat, SectionData.Length));

        var PayloadStart = BunConstants.PayloadLengthSize;
        var PayloadData = new ReadOnlySpan<byte>(SectionData, PayloadStart, (int)PayloadLength);

        VerifyTrailer(PayloadData, PayloadLength);

        var OffsetsStart = (int)PayloadLength - BunConstants.TrailerLength - BunConstants.OffsetsStructSize;
        var OffsetsSpan = PayloadData.Slice(OffsetsStart, BunConstants.OffsetsStructSize);

        var ByteCount = BitConverter.ToUInt64(SectionData, PayloadStart + OffsetsStart);
        var ModulesOffset = BitConverter.ToUInt32(SectionData, PayloadStart + OffsetsStart + 8);
        var ModulesLength = BitConverter.ToUInt32(SectionData, PayloadStart + OffsetsStart + 12);
        var EntryPointId = BitConverter.ToUInt32(SectionData, PayloadStart + OffsetsStart + 16);

        var ModuleCount = (int)(ModulesLength / BunConstants.CompiledModuleGraphFileSize);
        var Modules = new List<BunModule>(ModuleCount);

        for (var I = 0; I < ModuleCount; I++)
        {
            var ModuleStart = PayloadStart + (int)ModulesOffset + (I * BunConstants.CompiledModuleGraphFileSize);

            var NameOffset = BitConverter.ToUInt32(SectionData, ModuleStart);
            var NameLength = BitConverter.ToUInt32(SectionData, ModuleStart + 4);
            var ContentsOffset = BitConverter.ToUInt32(SectionData, ModuleStart + 8);
            var ContentsLength = BitConverter.ToUInt32(SectionData, ModuleStart + 12);

            var EncodingByte = SectionData[ModuleStart + 48];
            var LoaderByte = SectionData[ModuleStart + 49];
            var ModuleFormatByte = SectionData[ModuleStart + 50];
            var SideByte = SectionData[ModuleStart + 51];

            var Name = Encoding.UTF8.GetString(SectionData, PayloadStart + (int)NameOffset, (int)NameLength);
            var Source = ExtractSource(SectionData, PayloadStart, ContentsOffset, ContentsLength, EncodingByte);

            Modules.Add(new BunModule
            {
                Name = Name,
                Source = Source,
                SourceOffset = (int)ContentsOffset,
                SourceLength = (int)ContentsLength,
                Encoding = EncodingByte,
                Loader = LoaderByte,
                ModuleFormat = ModuleFormatByte,
                Side = SideByte
            });
        }

        return new ExtractedBundle
        {
            Modules = Modules,
            EntryPointId = (int)EntryPointId,
            TotalSize = (long)PayloadLength
        };
    }

    public BundleComparisonResult CompareWithSource(ExtractedBundle Bundle, string SourcePath)
    {
        var ReferenceBytes = File.ReadAllBytes(SourcePath);
        var EntryModule = Bundle.Modules[Bundle.EntryPointId];
        var ExtractedBytes = Encoding.UTF8.GetBytes(EntryModule.Source);

        if (ExtractedBytes.Length != ReferenceBytes.Length)
        {
            var MinLength = Math.Min(ExtractedBytes.Length, ReferenceBytes.Length);
            var FirstDiff = -1;
            for (var I = 0; I < MinLength; I++)
            {
                if (ExtractedBytes[I] != ReferenceBytes[I])
                {
                    FirstDiff = I;
                    break;
                }
            }

            if (FirstDiff < 0)
            {
                FirstDiff = MinLength;
            }

            return BuildMismatchResult(ExtractedBytes, ReferenceBytes, FirstDiff);
        }

        for (var I = 0; I < ExtractedBytes.Length; I++)
        {
            if (ExtractedBytes[I] != ReferenceBytes[I])
            {
                return BuildMismatchResult(ExtractedBytes, ReferenceBytes, I);
            }
        }

        return new BundleComparisonResult
        {
            IsMatch = true,
            ExtractedSize = ExtractedBytes.Length,
            ReferenceSize = ReferenceBytes.Length
        };
    }

    private static SectionHeader FindBunSection(PEReader PeReader)
    {
        foreach (var Section in PeReader.PEHeaders.SectionHeaders)
        {
            if (string.Equals(Section.Name, BunConstants.BunSectionName, StringComparison.Ordinal))
            {
                return Section;
            }
        }

        throw new InvalidOperationException(BunConstants.BunSectionNotFoundMessage);
    }

    private static byte[] ReadSectionData(FileStream Stream, SectionHeader Section)
    {
        var Data = new byte[Section.SizeOfRawData];
        Stream.Position = Section.PointerToRawData;
        Stream.ReadExactly(Data, 0, Data.Length);
        return Data;
    }

    private static void VerifyTrailer(ReadOnlySpan<byte> PayloadData, ulong PayloadLength)
    {
        var TrailerStart = (int)PayloadLength - BunConstants.TrailerLength;
        var TrailerSpan = PayloadData.Slice(TrailerStart, BunConstants.TrailerLength);
        var TrailerBytes = Encoding.ASCII.GetBytes(BunConstants.TrailerString);

        for (var I = 0; I < BunConstants.TrailerLength; I++)
        {
            if (TrailerSpan[I] != TrailerBytes[I])
            {
                throw new InvalidOperationException(BunConstants.TrailerNotFoundMessage);
            }
        }
    }

    private static string ExtractSource(byte[] SectionData, int PayloadStart, uint ContentsOffset, uint ContentsLength, byte EncodingType)
    {
        if (ContentsLength == 0)
        {
            return string.Empty;
        }

        var Start = PayloadStart + (int)ContentsOffset;

        if (EncodingType == BunConstants.EncodingLatin1)
        {
            return Encoding.Latin1.GetString(SectionData, Start, (int)ContentsLength);
        }

        return Encoding.UTF8.GetString(SectionData, Start, (int)ContentsLength);
    }

    private static BundleComparisonResult BuildMismatchResult(byte[] ExtractedBytes, byte[] ReferenceBytes, int FirstDiff)
    {
        var ExtractedContext = ExtractContext(ExtractedBytes, FirstDiff);
        var ReferenceContext = ExtractContext(ReferenceBytes, FirstDiff);

        return new BundleComparisonResult
        {
            IsMatch = false,
            ExtractedSize = ExtractedBytes.Length,
            ReferenceSize = ReferenceBytes.Length,
            FirstDifferenceOffset = FirstDiff,
            ExtractedContext = ExtractedContext,
            ReferenceContext = ReferenceContext
        };
    }

    private static string ExtractContext(byte[] Data, int Offset)
    {
        var Start = Math.Max(0, Offset - BunConstants.ComparisonContextRadius);
        var End = Math.Min(Data.Length, Offset + BunConstants.ComparisonContextRadius);
        return Encoding.UTF8.GetString(Data, Start, End - Start);
    }
}
