﻿namespace Spessman.Inventory
{
    public interface IItemWithSupply
    {
        void ChangeSupply(int amount);
        int GetSupplyDrainRate();
        float GetRemainingSupplyPercentage();
    }
}