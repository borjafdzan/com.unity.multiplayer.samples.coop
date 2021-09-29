using UnityEngine;

namespace Unity.Multiplayer.Samples.BossRoom.Visual
{
    /// <summary>
    /// Complimentary FX class for the Pickup Action class. Plays a "Pickup" or "Drop" animation.
    /// </summary>
    public class PickUpActionFX : ActionFX
    {
        public PickUpActionFX(ref ActionRequestData data, ClientCharacterVisualization parent) : base(ref data, parent)
        {
        }

        public override bool Start()
        {
            base.Start();

            if (Data.TargetIds != null && Data.TargetIds.Length > 0)
            {
                // pickup
                m_Parent.OurAnimator.SetTrigger(Description.Anim);
            }
            else
            {
                // drop
                m_Parent.OurAnimator.SetTrigger(Description.Anim2);
            }

            return true;
        }

        public override bool Update()
        {
            return true;
        }
    }
}