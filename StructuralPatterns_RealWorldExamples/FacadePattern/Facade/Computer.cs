using FacadePattern.Subsystems;

namespace FacadePattern.Facade
{
    public class Computer
    {
        private readonly CPU _cpu;
        private readonly HardDrive _hardDrive;
        private readonly Memory _memory;

        private const long BootAddress = 1;
        private const long BootSector = 1;
        private const int SectorSize = 10;

        public Computer()
        {
            _cpu = new CPU();
            _hardDrive = new HardDrive();
            _memory = new Memory();
        }

        public void Start()
        {
            _cpu.Freeze();
            _memory.Load(BootAddress, _hardDrive.Read(BootSector, SectorSize));
            _cpu.Jump(BootAddress);
            _cpu.Execute();
        }
    }
}
