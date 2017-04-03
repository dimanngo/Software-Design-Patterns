using System;

namespace FacadePattern.Subsystems
{
    public class HardDrive
    {
        
            public byte[] Read(long lba, int size)
            {
                var bytes = new byte[size];
                var random = new Random();
                random.NextBytes(bytes);
                return bytes;
            }

    }
}
