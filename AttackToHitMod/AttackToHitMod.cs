using KHMI;
using KHMI.Types;

namespace AttackToHitMod
{
    public class AttackToHitMod : KHMod
    {
        public AttackToHitMod(ModInterface mi) : base(mi)
        {
            KHCommand attackCommand = KHCommand.FromID(mi.dataInterface, 1);
            attackCommand.ActionID = 0x0156;
        }
    }
}
