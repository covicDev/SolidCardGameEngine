using System.Collections.Generic;

using Field.Hand.Slot;

namespace Field.Hand
{
    public interface IHandFieldReferences
    {
        List<SlotFieldController> SlotFieldControllerReferences { get; }
    }
}