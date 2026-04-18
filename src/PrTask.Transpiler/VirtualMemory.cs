using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace PrTask.Transpiler;

public sealed class VirtualMemory
{
    private const int PageSizeBits = 12;
    public const int PageSize = 1 << PageSizeBits;
    private const ulong PageMask = PageSize - 1;

    private readonly ConcurrentDictionary<ulong, byte[]> Pages = new();
    private readonly HashSet<ulong> AllocatedRegions = [];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private byte[] GetOrCreatePage(ulong PageIndex)
    {
        return Pages.GetOrAdd(PageIndex, static _ => new byte[PageSize]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private byte ReadByteInternal(ulong Addr)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        return Pages.TryGetValue(PageIndex, out var Page) ? Page[Offset] : (byte)0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void WriteByteInternal(ulong Addr, byte Value)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        GetOrCreatePage(PageIndex)[Offset] = Value;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public byte Read8(ulong Addr)
    {
        return ReadByteInternal(Addr);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public ushort Read16(ulong Addr)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        if (Offset <= PageSize - 2 && Pages.TryGetValue(PageIndex, out var Page))
        {
            return BinaryPrimitives.ReadUInt16LittleEndian(new ReadOnlySpan<byte>(Page, Offset, 2));
        }
        return (ushort)(ReadByteInternal(Addr) | (ReadByteInternal(Addr + 1) << 8));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public uint Read32(ulong Addr)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        if (Offset <= PageSize - 4 && Pages.TryGetValue(PageIndex, out var Page))
        {
            return BinaryPrimitives.ReadUInt32LittleEndian(new ReadOnlySpan<byte>(Page, Offset, 4));
        }
        return (uint)(
            ReadByteInternal(Addr) |
            (ReadByteInternal(Addr + 1) << 8) |
            (ReadByteInternal(Addr + 2) << 16) |
            (ReadByteInternal(Addr + 3) << 24));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public ulong Read64(ulong Addr)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        if (Offset <= PageSize - 8 && Pages.TryGetValue(PageIndex, out var Page))
        {
            return BinaryPrimitives.ReadUInt64LittleEndian(new ReadOnlySpan<byte>(Page, Offset, 8));
        }
        return ReadByteInternal(Addr) |
            ((ulong)ReadByteInternal(Addr + 1) << 8) |
            ((ulong)ReadByteInternal(Addr + 2) << 16) |
            ((ulong)ReadByteInternal(Addr + 3) << 24) |
            ((ulong)ReadByteInternal(Addr + 4) << 32) |
            ((ulong)ReadByteInternal(Addr + 5) << 40) |
            ((ulong)ReadByteInternal(Addr + 6) << 48) |
            ((ulong)ReadByteInternal(Addr + 7) << 56);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write8(ulong Addr, byte Value)
    {
        WriteByteInternal(Addr, Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write16(ulong Addr, ushort Value)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        if (Offset <= PageSize - 2)
        {
            var Page = GetOrCreatePage(PageIndex);
            BinaryPrimitives.WriteUInt16LittleEndian(new Span<byte>(Page, Offset, 2), Value);
            return;
        }
        WriteByteInternal(Addr, (byte)Value);
        WriteByteInternal(Addr + 1, (byte)(Value >> 8));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write32(ulong Addr, uint Value)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        if (Offset <= PageSize - 4)
        {
            var Page = GetOrCreatePage(PageIndex);
            BinaryPrimitives.WriteUInt32LittleEndian(new Span<byte>(Page, Offset, 4), Value);
            return;
        }
        WriteByteInternal(Addr, (byte)Value);
        WriteByteInternal(Addr + 1, (byte)(Value >> 8));
        WriteByteInternal(Addr + 2, (byte)(Value >> 16));
        WriteByteInternal(Addr + 3, (byte)(Value >> 24));
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
    public void Write64(ulong Addr, ulong Value)
    {
        var PageIndex = Addr >> PageSizeBits;
        var Offset = (int)(Addr & PageMask);
        if (Offset <= PageSize - 8)
        {
            var Page = GetOrCreatePage(PageIndex);
            BinaryPrimitives.WriteUInt64LittleEndian(new Span<byte>(Page, Offset, 8), Value);
            return;
        }
        WriteByteInternal(Addr, (byte)Value);
        WriteByteInternal(Addr + 1, (byte)(Value >> 8));
        WriteByteInternal(Addr + 2, (byte)(Value >> 16));
        WriteByteInternal(Addr + 3, (byte)(Value >> 24));
        WriteByteInternal(Addr + 4, (byte)(Value >> 32));
        WriteByteInternal(Addr + 5, (byte)(Value >> 40));
        WriteByteInternal(Addr + 6, (byte)(Value >> 48));
        WriteByteInternal(Addr + 7, (byte)(Value >> 56));
    }

    public byte[] ReadBytes(ulong Addr, int Length)
    {
        var Result = new byte[Length];
        if (Length == 0)
        {
            return Result;
        }

        var CurrentAddr = Addr;
        var DestOffset = 0;
        var BytesRemaining = Length;

        var FirstPageOffset = (int)(CurrentAddr & PageMask);
        if (FirstPageOffset != 0)
        {
            var BytesInFirstPage = Math.Min(PageSize - FirstPageOffset, BytesRemaining);
            var PageIndex = CurrentAddr >> PageSizeBits;
            if (Pages.TryGetValue(PageIndex, out var Page))
            {
                Array.Copy(Page, FirstPageOffset, Result, DestOffset, BytesInFirstPage);
            }
            DestOffset += BytesInFirstPage;
            BytesRemaining -= BytesInFirstPage;
            CurrentAddr += (ulong)BytesInFirstPage;
        }

        while (BytesRemaining >= PageSize)
        {
            var PageIndex = CurrentAddr >> PageSizeBits;
            if (Pages.TryGetValue(PageIndex, out var Page))
            {
                Array.Copy(Page, 0, Result, DestOffset, PageSize);
            }
            DestOffset += PageSize;
            BytesRemaining -= PageSize;
            CurrentAddr += PageSize;
        }

        if (BytesRemaining > 0)
        {
            var PageIndex = CurrentAddr >> PageSizeBits;
            if (Pages.TryGetValue(PageIndex, out var Page))
            {
                Array.Copy(Page, 0, Result, DestOffset, BytesRemaining);
            }
        }

        return Result;
    }

    public void WriteBytes(ulong Addr, byte[] Data)
    {
        if (Data.Length == 0)
        {
            return;
        }

        var CurrentAddr = Addr;
        var SrcOffset = 0;
        var BytesRemaining = Data.Length;

        var FirstPageOffset = (int)(CurrentAddr & PageMask);
        if (FirstPageOffset != 0)
        {
            var BytesInFirstPage = Math.Min(PageSize - FirstPageOffset, BytesRemaining);
            var PageIndex = CurrentAddr >> PageSizeBits;
            var Page = GetOrCreatePage(PageIndex);
            Array.Copy(Data, SrcOffset, Page, FirstPageOffset, BytesInFirstPage);
            SrcOffset += BytesInFirstPage;
            BytesRemaining -= BytesInFirstPage;
            CurrentAddr += (ulong)BytesInFirstPage;
        }

        while (BytesRemaining >= PageSize)
        {
            var PageIndex = CurrentAddr >> PageSizeBits;
            var Page = GetOrCreatePage(PageIndex);
            Array.Copy(Data, SrcOffset, Page, 0, PageSize);
            SrcOffset += PageSize;
            BytesRemaining -= PageSize;
            CurrentAddr += PageSize;
        }

        if (BytesRemaining > 0)
        {
            var PageIndex = CurrentAddr >> PageSizeBits;
            var Page = GetOrCreatePage(PageIndex);
            Array.Copy(Data, SrcOffset, Page, 0, BytesRemaining);
        }
    }

    public void Allocate(ulong Addr, uint Size)
    {
        var AlignedAddr = Addr & ~PageMask;
        var EndAddr = (Addr + Size + PageMask) & ~PageMask;
        for (var PageAddr = AlignedAddr; PageAddr < EndAddr; PageAddr += PageSize)
        {
            var PageIndex = PageAddr >> PageSizeBits;
            GetOrCreatePage(PageIndex);
        }
        AllocatedRegions.Add(AlignedAddr);
    }

    public void Free(ulong Addr)
    {
        var AlignedAddr = Addr & ~PageMask;
        if (!AllocatedRegions.Remove(AlignedAddr))
        {
            return;
        }

        var PageIndex = AlignedAddr >> PageSizeBits;
        Pages.TryRemove(PageIndex, out _);
    }

    public ulong LoadPeSections(string FilePath, ulong ImageBase)
    {
        using var Fs = File.OpenRead(FilePath);
        using var PeReader = new PEReader(Fs);
        var Headers = PeReader.PEHeaders;

        foreach (var Section in Headers.SectionHeaders)
        {
            if (Section.SizeOfRawData == 0)
            {
                continue;
            }

            var SectionData = PeReader.GetSectionData(Section.VirtualAddress);
            var Reader = SectionData.GetReader();
            var Bytes = Reader.ReadBytes(Math.Min(Section.SizeOfRawData, Reader.Length));
            var DestAddr = ImageBase + (ulong)Section.VirtualAddress;
            Allocate(DestAddr, (uint)Section.VirtualSize);
            WriteBytes(DestAddr, Bytes);
        }

        return Headers.PEHeader is not null
            ? unchecked(Headers.PEHeader.ImageBase)
            : ImageBase;
    }

    public int AllocatedPageCount => Pages.Count;

    public long AllocatedBytes => (long)Pages.Count * PageSize;
}
