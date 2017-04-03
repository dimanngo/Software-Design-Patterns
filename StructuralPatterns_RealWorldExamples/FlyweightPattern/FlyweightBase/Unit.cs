namespace FlyweightPattern.FlyweightBase
{
    public abstract class Unit
    {
        public string Name { get; internal set; }
        public int Armour { get; internal set; }
        public int Speed { get; internal set; }
        public int RotationRate { get; internal set; }
        public int FireRate { get; internal set; }
        public int Range { get; internal set; }
        public int FirePower { get; internal set; }



        public abstract void FireAt(Target target);
    }
}
